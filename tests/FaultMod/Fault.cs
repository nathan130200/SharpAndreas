using SharpAndreas;
public abstract class FaultFixture : Mod
{
    private ModContext context = null!;
    public override void Start(ModContext value)
    {
        context = value;
        if (File.Exists(Path.Combine(context.Directory, "start.fail"))) throw new Exception("Expected Start failure");
    }
    public override void Tick() => throw new Exception("Expected Tick failure");
    public override void Stop() => throw new Exception("Expected Stop failure");
}
#if StartFault
public sealed class StartFault:FaultFixture { }
#else
public sealed class FaultMod:FaultFixture { }
#endif
