using SharpAndreas;

public sealed class HelloCS : Mod
{
    private ModContext context = null!;
    private bool held;
    private int ticks;
    public override void Start(ModContext context)
    {
        this.context = context;
        context.Log("C# mod started. Press F6 for a message.");
    }
    public override void Tick()
    {
        bool down = Game.IsKeyDown(0x75); // F6
        if (down && !held) Game.ShowHelp("Hello from C# and CoreCLR!");
        held = down;
        if (ticks < 3) { context.Log("C# tick"); ticks++; }
    }
    public override void Stop() => context.Log("C# stopped");
    public override async Task RunAsync(ModContext context, CancellationToken cancellationToken)
    {
        await Delay(1000, cancellationToken); // GTA keeps processing frames while this script is suspended.
        var player = Player.Local.Character;
        if (player is not null) context.Log($"Async C#: player {player.Handle}, health {player.Health}");
    }
}
