using System.Runtime.InteropServices;

namespace SharpAndreas;

public abstract class Mod
{
    public virtual void Start(ModContext context) { }
    /// <summary>One tracked asynchronous script per mod. Await instead of blocking the game thread.</summary>
    public virtual Task RunAsync(ModContext context, CancellationToken cancellationToken) => Task.CompletedTask;
    public virtual void Tick() { }
    /// <summary>Draw HUD content once per rendered frame; game-thread callback with render-state isolation.</summary>
    public virtual void Draw() { }
    public virtual void Stop() { }
    protected static Task Delay(int milliseconds, CancellationToken cancellationToken = default) => Script.Delay(milliseconds, cancellationToken);
    protected static Task NextFrame(CancellationToken cancellationToken = default) => Script.NextFrame(cancellationToken);
}

public sealed class ModContext
{
    [ThreadStatic] internal static ModContext? Current;
    private readonly Action<string> log;
    private readonly Func<int, CancellationToken, Task> delay;
    internal ModContext(string directory, Action<string> log, Func<int, CancellationToken, Task> delay, CancellationToken token)
    { Directory = directory; this.log = log; this.delay = delay; CancellationToken = token; Config = new(directory); }
    public string ScriptName { get; internal set; } = "Loader";
    public string ModId {get;internal set;}="";
    public string Name {get;internal set;}="";
    public string Version {get;internal set;}="0.0.0";
    public bool CanTickWhenPaused {get;internal set;}
    internal uint TaskOwner;
    public ModConfiguration Config { get; }
    public string Directory { get; }
    public CancellationToken CancellationToken { get; }
    public void Log(string message) => log(message);
    public void Log(Exception exception) => log(exception.ToString());
    public Task Delay(int milliseconds, CancellationToken cancellationToken = default) => delay(milliseconds, cancellationToken);
    public Task NextFrame(CancellationToken cancellationToken = default) => Delay(0, cancellationToken);
}

public static class Script
{
    public static Task Delay(int milliseconds, CancellationToken cancellationToken = default) =>
        (ModContext.Current ?? throw new InvalidOperationException("Delay requires a running mod on the game thread.")).Delay(milliseconds, cancellationToken);
    public static Task NextFrame(CancellationToken cancellationToken = default) => Delay(0, cancellationToken);
}

/// <summary>Call game functions on the game thread, including captured async continuations.</summary>
public static class Game
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    private delegate int KeyCallback(int key);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    private delegate void HelpCallback([MarshalAs(UnmanagedType.LPStr)] string text);
    private static KeyCallback? keyDown;
    private static HelpCallback? help;
    private static int gameThread;
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)] private delegate int StateCallback(int operation);
    private static StateCallback state=null!;
    internal static void BindState(IntPtr callback)=>state=Marshal.GetDelegateForFunctionPointer<StateCallback>(callback);
    public static bool IsPaused {get {CheckThread();return state(0)!=0;}}
    /// <summary>The SCM on-mission global selected by CTheScripts.OnAMissionFlag.</summary>
    public static bool IsOnMission
    {
        get {CheckThread();return state(2)==1;}
        set {CheckThread();if(state(value?3:4)<0)throw new InvalidOperationException("The SCM mission flag is not initialized.");}
    }
    /// <summary>GTA's game clock in milliseconds, wrapping as an unsigned 32-bit value.</summary>
    public static uint GameTimeMilliseconds {get {CheckThread();return unchecked((uint)state(5));}}

    internal static void BindNative(int threadId, IntPtr key, IntPtr message, IntPtr scm)
    {
        if (keyDown is not null) throw new InvalidOperationException("Native API already bound.");
        gameThread = threadId;
        keyDown = Marshal.GetDelegateForFunctionPointer<KeyCallback>(key);
        help = Marshal.GetDelegateForFunctionPointer<HelpCallback>(message);
        Scm.Bind(scm);
    }
    internal static void CheckThread()
    {
        if (Environment.CurrentManagedThreadId != gameThread || keyDown is null)
            throw new InvalidOperationException("Game API must run on the game thread after initialization.");
    }
    public static bool IsKeyDown(int virtualKey)
    {
        CheckThread();
        if (virtualKey is < 0 or > 255) throw new ArgumentOutOfRangeException(nameof(virtualKey));
        return keyDown!(virtualKey) != 0;
    }
    public static void ShowHelp(string text)
    {
        CheckThread();
        ArgumentNullException.ThrowIfNull(text);
        if (text.Length > 200 || text.Any(c => c is < ' ' or > '~'))
            throw new ArgumentException("Use at most 200 printable ASCII characters (GTA text codes allowed).", nameof(text));
        help!(text);
    }
}
