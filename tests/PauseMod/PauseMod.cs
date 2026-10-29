using SharpAndreas;
public abstract class PauseFixture:Mod
{
    private ModContext context=null!;
    private int pausedTicks,pausedAwaits;
    public override void Start(ModContext value)=>context=value;
    public override void Tick() {if(Game.IsPaused)pausedTicks++;}
    public override async Task RunAsync(ModContext context,CancellationToken token)
    {
        while(!token.IsCancellationRequested) {await NextFrame();if(Game.IsPaused)pausedAwaits++;}
    }
    public override void Stop()
    {
        if(context.CanTickWhenPaused)
        {
            if(pausedTicks==0 || pausedAwaits==0)throw new Exception("Paused opt-in did not execute");
            if(context.Name!="Pause opt-in" || context.Version!="1.2.3")throw new Exception("Mod metadata missing");
        }
        else if(pausedTicks!=0 || pausedAwaits!=0)throw new Exception("Default mod executed while paused");
        context.Log("PAUSE POLICY PASS "+context.ScriptName);
    }
}
#if PausedOptIn
[TickWhenPaused]
public sealed class PausedOptIn:PauseFixture { }
#else
public sealed class PausedDefault:PauseFixture { }
#endif
