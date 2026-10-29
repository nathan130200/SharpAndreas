using System.Diagnostics;
using SharpAndreas;
public sealed class HotReload:Mod
{
    private ModContext context=null!;
    public override void Start(ModContext value)
    {
        context=value;
        if(GetType().Assembly.Location!="")throw new Exception("Mod DLL was not loaded from memory");
        File.AppendAllText(Path.Combine(context.Directory,"started.txt"),context.Version+"\n");
        Trace.WriteLine("TRACE UNIFIED "+context.Version);
    }
    public override async Task RunAsync(ModContext context,CancellationToken token)
    {
        try {await Delay(-1);}
        finally {Log.Info("HOT RELOAD FINALLY "+context.Version);}
    }
    public override void Stop()=>File.AppendAllText(Path.Combine(context.Directory,"stopped.txt"),context.Version+"\n");
}
