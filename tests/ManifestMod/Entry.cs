using System.Diagnostics;
using System.Runtime.Loader;
using SharpAndreas;
namespace ManifestSample;
public sealed class ActualMod:Mod
{
    private ModContext context=null!;
    private readonly Errors errors=new();
    public override void Start(ModContext value)
    {
        context=value;
        if(context.Name!="Friendly Name" || context.ScriptName!="Friendly Name" || context.ModId!="ManifestFolder" || context.Version is not ("4.3.2.1" or "4.3.2.2"))throw new Exception("Manifest identity missing");
        if(typeof(Mod).Assembly.GetType("SharpAndreas.ModAttribute") is not null)throw new Exception("Obsolete ModAttribute remains");
        if(PrivateValue.Marker!="N" || AssemblyLoadContext.GetLoadContext(typeof(PrivateValue).Assembly)!=AssemblyLoadContext.GetLoadContext(GetType().Assembly))throw new Exception("Root-scoped Libraries resolution failed for nested entry assembly");
        Trace.Listeners.Add(errors);
        Trace.Write("TRACE WRITE WITHOUT NEWLINE");
        Trace.TraceError("EXPLICIT TRACE ERROR");
        Log.For<ActualMod>().Info("TYPED LOGGER MANIFEST NAME");
        File.AppendAllText(Path.Combine(context.Directory,"manifest-started.txt"),context.Version+"\n");
        Log.Info("MANIFEST SELECTION PASS "+context.Version);
    }
    public override void Stop()
    {
        Trace.Listeners.Remove(errors);
        File.AppendAllText(Path.Combine(context.Directory,"manifest-stopped.txt"),context.Version+"\n");
        File.AppendAllText(Path.Combine(context.Directory,"trace-errors.txt"),errors.Count+"\n");
    }
    private sealed class Errors:TraceListener
    {
        public int Count;
        public override void Write(string? message) { }
        public override void WriteLine(string? message) { }
        public override void TraceEvent(TraceEventCache? cache,string source,TraceEventType type,int id,string? message) {if(type==TraceEventType.Error)Count++;}
        public override void TraceEvent(TraceEventCache? cache,string source,TraceEventType type,int id,string? format,params object?[]? args) {if(type==TraceEventType.Error)Count++;}
    }
}
public sealed class NotSelected:Mod {public NotSelected()=>throw new Exception("Unselected entry class was instantiated");}
