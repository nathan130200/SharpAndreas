using System.Diagnostics;
using System.Globalization;

namespace SharpAndreas.Runtime;

internal static class GlobalDiagnostics
{
    private sealed class PluginTraceListener:TraceListener
    {
        public override bool IsThreadSafe=>true;
        // Each Write is persisted immediately; no newline or Flush is needed to retain it.
        public override void Write(string? message)=>Log.Info(message??"");
        public override void WriteLine(string? message)=>Log.Info(message??"");
        public override void TraceEvent(TraceEventCache? cache,string source,TraceEventType type,int id,string? message)=>WriteLine(message);
        public override void TraceEvent(TraceEventCache? cache,string source,TraceEventType type,int id,string? format,params object?[]? args)
        {
            try {WriteLine(args is null?format:string.Format(CultureInfo.InvariantCulture,format??"",args));}
            catch {Log.Write("Loader","Trace event formatting failed.");}
        }
        public override void Fail(string? message,string? detailMessage)=>WriteLine("Trace assertion: "+message+" "+detailMessage);
    }
    internal static void Initialize()
    {
        Trace.Listeners.Add(new PluginTraceListener{Name="SharpAndreas"});Trace.AutoFlush=true;
        AppDomain.CurrentDomain.UnhandledException+=(_,args)=>
        {
            try {Log.ReportException("Loader","Unhandled exception",args.ExceptionObject as Exception ?? new Exception("A non-Exception object was thrown."));}catch { }
        };
        TaskScheduler.UnobservedTaskException+=(_,args)=>
        {
            try {Log.ReportException("Loader","Unobserved task exception",args.Exception);args.SetObserved();}catch { }
        };
    }
}
