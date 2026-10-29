using System.Diagnostics;

namespace SharpAndreas.Runtime;

/// <summary>One context per mod. Producers may post from any thread; only GTA pumps callbacks.</summary>
internal sealed class ScriptScheduler : SynchronizationContext, IDisposable
{
    internal static int MaxCallbacksPerFrame = 64;
    internal static double BudgetMilliseconds = 2;
    private readonly object gate = new();
    private readonly Queue<(SendOrPostCallback Callback, object? State)> queue = new();
    private readonly CancellationTokenSource lifetime = new();
    private readonly List<Waiter> waiters = [];
    private readonly int gameThread = Environment.CurrentManagedThreadId;
    private bool closed;
    private bool firstPump = true;
    private long frame;
    internal ModContext Context = null!;
    public CancellationToken Token => lifetime.Token;
    private sealed class Waiter(long due, long frame, CancellationTokenSource linked)
    {
        public readonly long Due = due, Frame = frame;
        // Inline completion is intentional: lifetime cancellation can execute finally blocks
        // on the game thread before shutdown. Normal completion runs within this context too.
        public readonly TaskCompletionSource Source = new();
        public readonly CancellationTokenSource Linked = linked;
        public CancellationTokenRegistration Registration;
        public void Dispose() { Registration.Dispose(); Linked.Dispose(); }
    }
    public override SynchronizationContext CreateCopy() => this;
    public override void Post(SendOrPostCallback callback, object? state)
    {
        lock (gate) { if (!closed) queue.Enqueue((callback, state)); }
    }
    public override void Send(SendOrPostCallback callback, object? state)
    {
        if (Environment.CurrentManagedThreadId != gameThread)
            throw new NotSupportedException("Synchronous dispatch would block a worker. Use await on the game context.");
        Invoke(() => callback(state));
    }
    internal void Invoke(Action action)
    {
        var previous = Current;
        var previousMod = ModContext.Current;
        var previousLog = Log.Enter(Context.ScriptName);
        SetSynchronizationContext(this);
        ModContext.Current = Context;
        try { action(); }
        finally { Log.Restore(previousLog); ModContext.Current = previousMod; SetSynchronizationContext(previous); }
    }
    internal Task Delay(int milliseconds, CancellationToken token)
    {
        if (Environment.CurrentManagedThreadId != gameThread) throw new InvalidOperationException("Schedule delays on the game thread.");
        if (milliseconds < -1) throw new ArgumentOutOfRangeException(nameof(milliseconds));
        ObjectDisposedException.ThrowIf(closed, this);
        if (lifetime.IsCancellationRequested) return Task.FromCanceled(lifetime.Token);
        if (token.IsCancellationRequested) return Task.FromCanceled(token);
        var linked = CancellationTokenSource.CreateLinkedTokenSource(lifetime.Token, token);
        var wait = new Waiter(milliseconds == -1 ? long.MaxValue : Stopwatch.GetTimestamp() + (long)milliseconds * Stopwatch.Frequency / 1000, frame + 1, linked);
        wait.Registration = linked.Token.Register(() => wait.Source.TrySetCanceled(linked.Token));
        waiters.Add(wait);
        return wait.Source.Task;
    }
    internal void Pump()
    {
        // Initialization happens inside the first native Tick; this is still that same frame.
        if (firstPump) { firstPump = false; return; }
        frame++;
        long started = Stopwatch.GetTimestamp();
        long now = Stopwatch.GetTimestamp();
        // Snapshot before completing tasks: continuations may add more waits.
        var ready = waiters.Where(w => w.Source.Task.IsCompleted || w.Frame <= frame && w.Due <= now).Take(MaxCallbacksPerFrame).ToArray();
        foreach (var wait in ready)
        {
            waiters.Remove(wait);
            try { Invoke(() => wait.Source.TrySetResult()); }
            finally { wait.Dispose(); }
            if (Stopwatch.GetElapsedTime(started).TotalMilliseconds >= BudgetMilliseconds) return;
        }
        Drain(started);
    }
    private void Drain(long started)
    {
        // Budget limits work between callbacks; cooperative code must still yield regularly.
        int count;
        lock (gate) count = Math.Min(queue.Count, MaxCallbacksPerFrame);
        for (int i = 0; i < count; i++)
        {
            (SendOrPostCallback Callback, object? State) item;
            lock (gate) { if (queue.Count == 0) break; item = queue.Dequeue(); }
            Invoke(() => item.Callback(item.State));
            if (Stopwatch.GetElapsedTime(started).TotalMilliseconds >= BudgetMilliseconds) break;
        }
    }
    internal void Cancel()
    {
        try { Invoke(lifetime.Cancel); }
        finally { Drain(Stopwatch.GetTimestamp()); }
    }
    public void Dispose()
    {
        lock (gate) { closed = true; queue.Clear(); }
        foreach (var wait in waiters) wait.Dispose();
        waiters.Clear();
        lifetime.Dispose();
    }
}
