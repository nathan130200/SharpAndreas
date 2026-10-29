using System.Diagnostics;
using System.Numerics;
using SharpAndreas;

public abstract class AsyncFixture : Mod
{
    private int ticks;
    public override void Tick() => ticks++;
    public override async Task RunAsync(ModContext context, CancellationToken cancellationToken)
    {
        int thread = Environment.CurrentManagedThreadId;
        string mode = Path.GetFileName(context.Directory);
        if (mode == "AsyncPending")
        {
            try { await Delay(-1); }
            finally
            {
                if (Environment.CurrentManagedThreadId != thread) throw new Exception("Cleanup on wrong thread");
                Game.IsKeyDown(0);
                context.Log("CANCELLED ON GAME THREAD");
            }
            return;
        }
        if (mode == "AsyncFault") { await Delay(20); throw new Exception("Expected async failure"); }
        if (mode == "AsyncVoidFault") { ThrowAsyncVoid(); return; }
        if (mode == "AsyncZero")
        {
            for (int i = 0; i < 10; i++)
            {
                int before = ticks;
                await Delay(0);
                if (ticks <= before) throw new Exception("Delay(0) did not yield a game frame");
            }
            context.Log("ZERO DELAY YIELDED FRAMES");
            return;
        }
        var watch = Stopwatch.StartNew();
        await Delay(1000);
        if (watch.Elapsed.TotalMilliseconds < 999.9 || ticks == 0) throw new Exception($"Delay blocked or resumed early: elapsed={watch.Elapsed.TotalMilliseconds}, ticks={ticks}");
        await Task.Delay(10);
        int answer = await Task.Run(() => 42);
        await Task.Yield();
        if (Environment.CurrentManagedThreadId != thread || answer != 42) throw new Exception("Continuation left game thread");
        bool rejected = await Task.Run(() =>
        {
            try { Game.IsKeyDown(0); return false; }
            catch (InvalidOperationException) { return true; }
        });
        if (!rejected) throw new Exception("Worker-thread game API call was accepted");
        using var cancel = new CancellationTokenSource();
        Task delay = Delay(1000, cancel.Token);
        cancel.Cancel();
        try { await delay; throw new Exception("Canceled delay completed successfully"); }
        catch (OperationCanceledException) { }
        Game.IsKeyDown(0);
        var variable = new ScmVariable();
        Scm.Call(ScmOpcode.SetLocalInt, variable, 1234);
        if (variable.Int32 != 1234) throw new Exception("SCM integer output mismatch");
        Scm.Call(ScmOpcode.SetLocalFloat, variable, 1.25f);
        if (variable.Single != 1.25f) throw new Exception("SCM float output mismatch");
        Scm.Call(ScmOpcode.Nop, "pascal", ScmArgument.Label("GXTKEY")); // Transport-only mock test.
        try { Scm.Call(0x0001, 1000); throw new Exception("SCM WAIT was accepted"); }
        catch (InvalidOperationException ex) when (ex.Message.StartsWith("SCM")) { }
        try { Scm.Call(ScmOpcode.Nop, ScmArgument.Label("TOO_LONG_LABEL")); throw new Exception("Long SCM label accepted"); }
        catch (ArgumentException) { }
        var ped = Player.Local.Character ?? throw new Exception("Player ped missing");
        if (!ped.Exists || ped.Handle != 42 || ped.Health != 100 || ped.Position != new Vector3(1, 2, 3) || ped.Model != 7)
            throw new Exception("Entity bridge mismatch");
        if (new Ped(999).Exists) throw new Exception("Invalid entity exists");
        try { _ = new Ped(999).Health; throw new Exception("Invalid entity accepted"); }
        catch (InvalidOperationException ex) when (ex.Message.Contains("no longer exists")) { }
        context.Log($"ASYNC AND SCM PASS ticks={ticks}");
    }
    private static async void ThrowAsyncVoid()
    {
        await NextFrame();
        throw new Exception("Expected async void failure");
    }
}
#if AsyncHealthy
public sealed class AsyncHealthy:AsyncFixture { }
#elif AsyncFault
public sealed class AsyncFault:AsyncFixture { }
#elif AsyncPending
public sealed class AsyncPending:AsyncFixture { }
#elif AsyncZero
public sealed class AsyncZero:AsyncFixture { }
#elif AsyncVoidFault
public sealed class AsyncVoidFault:AsyncFixture { }
#else
public sealed class AsyncMod:AsyncFixture { }
#endif
