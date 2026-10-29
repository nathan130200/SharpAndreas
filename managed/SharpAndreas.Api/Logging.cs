using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SharpAndreas;

public static class Log
{
    private static readonly object gate = new();
    private static readonly ConditionalWeakTable<Type,ScriptLogger> namedLoggers = new();
    private static readonly AsyncLocal<string?> script = new();
    private static string? path;
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)] private delegate void NativeWriter([MarshalAs(UnmanagedType.LPWStr)]string script,[MarshalAs(UnmanagedType.LPWStr)]string message);
    private static NativeWriter? native;
    internal static void Initialize(string filename,IntPtr callback) {path=filename;native=Marshal.GetDelegateForFunctionPointer<NativeWriter>(callback);}
    internal static string? Enter(string name) { var previous = script.Value; script.Value = name; return previous; }
    internal static void Restore(string? name) => script.Value = name;
    public static void Info(string message) => Write(script.Value ?? "Loader", message);
    public static void Error(Exception exception) => Info(exception?.ToString() ?? throw new ArgumentNullException(nameof(exception)));
    public static ScriptLogger For<TScript>() where TScript : Mod => namedLoggers.GetValue(typeof(TScript),type=>new(type.Name));
    internal static void Register(Type type,string name) => namedLoggers.GetValue(type,t=>new(t.Name)).SetName(name);
    // Never throw from diagnostics, including when another TraceListener misbehaves.
    internal static void ReportException(string name,string message,Exception exception)
    {
        try
        {
            var previous=Enter(name);
            try {Trace.TraceError("{0}: {1}",message,exception);Trace.Flush();}
            finally {Restore(previous);}
        }
        catch
        {
            try {Write(name,message+": "+exception.GetType().FullName);}catch { }
        }
    }
    internal static void Write(string name, string message)
    {
        // Never let a logging failure prevent Stop or escape a native callback.
        try
        {
            if(native is not null) {native(name,message??"");return;}
            string timestamp = DateTimeOffset.Now.ToString("yyyy-MM-dd HH:mm:ss.fff zzz");
            string prefix = $"[{timestamp}] [{name}] ";
            string content = string.Join(Environment.NewLine, (message ?? "").Replace("\r\n", "\n").Replace('\r', '\n').Split('\n').Select(line => prefix + "[" + line + "]")) + Environment.NewLine;
            lock (gate)
            {
                if (path is not null) File.AppendAllText(path, content);
                else Debug.Write(content);
            }
        }
        catch { /* Logging failure must never recurse through Trace or escape a native callback. */ }
    }
}

public sealed class ScriptLogger
{
    private volatile string name;
    internal ScriptLogger(string name) => this.name = name;
    internal void SetName(string value) => name=value;
    public void Info(string message) => Log.Write(name, message);
    public void Error(Exception exception) => Info(exception?.ToString() ?? throw new ArgumentNullException(nameof(exception)));
}
