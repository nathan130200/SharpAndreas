using System.Diagnostics;
using System.Numerics;
using SharpAndreas;
public abstract class HudFixture:Mod
{
    private HudTexture? texture;
    private ModContext context=null!;
    private bool drawn;
    private readonly ThrowingListener listener=new();
    public override void Start(ModContext value)
    {
        context=value;
        var canvas=new TextureCanvas(8,4);canvas.Clear(HudColor.Transparent);
        canvas.FillRectangle(-2,0,4,2,new HudColor(17,34,51));
        if(canvas.Pixels[0]!=0xFF112233 || canvas.Pixels[2]!=0 || canvas.Pixels[31]!=0)throw new Exception("Canvas clipping/ARGB format failed");
        texture=new HudTexture(8,4);texture.Update(canvas);
        try {Hud.DrawRectangle(new(0,0,1,1),HudColor.White);throw new Exception("Drawing outside Draw accepted");}catch(InvalidOperationException) { }
        try {texture.Update(new TextureCanvas(1,1));throw new Exception("Wrong canvas size accepted");}catch(ArgumentException) { }
        if(context.ModId=="HudStartFault")throw new Exception("Expected HUD Start failure after allocating a texture");
    }
    public override void Draw()
    {
        if(context.ModId=="HudFault") {Trace.Listeners.Add(listener);throw new Exception("Expected Draw failure");}
        if(Hud.ScreenSize!=new Vector2(640,448))throw new Exception("Screen size transport failed");
        Hud.DrawRectangle(new(10,10,80,10),new HudColor(255,0,0,128));
        Hud.DrawText("HUD test",new(10,24),HudColor.White);
        Hud.DrawTexture(texture!,new(10,50,80,10));
        if(!Hud.TryProject(new Vector3(1,2,3),out var screen) || screen!=new Vector2(101,98))throw new Exception("World-to-screen failed");
        if(Hud.TryProject(new Vector3(0,0,-1),out _))throw new Exception("Behind-camera point projected");
        if(!Hud.TryProjectHead(new Ped(42),out _))throw new Exception("Head projection failed");
        if(!drawn) {drawn=true;Log.Info("HUD BOTH PATHS PASS");}
    }
    public override void Stop()
    {
        Trace.Listeners.Remove(listener);
        if(context.ModId=="HudHealthy") {texture?.Dispose();texture?.Dispose();}
        File.WriteAllText(Path.Combine(context.Directory,"hud-stopped.txt"),"1");
        if(context.ModId=="HudFault")throw new Exception("Expected HUD Stop failure");
        // Other fixtures deliberately rely on automatic owner cleanup after failure/unload.
    }
    private sealed class ThrowingListener:TraceListener
    {
        public override void Write(string? message)=>throw new Exception("Broken diagnostic listener");
        public override void WriteLine(string? message)=>throw new Exception("Broken diagnostic listener");
    }
}
#if HudFault
public sealed class HudFault:HudFixture { }
#elif HudStartFault
public sealed class HudStartFault:HudFixture { }
#elif HudLeak
public sealed class HudLeak:HudFixture { }
#else
public sealed class HudHealthy:HudFixture { }
#endif
