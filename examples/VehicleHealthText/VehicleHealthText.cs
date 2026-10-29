using System.Numerics;
namespace SharpAndreas.Examples;
public sealed class VehicleHealthText:Mod
{
    private Vehicle? closest;
    private string label="";
    private HudColor color=HudColor.White;
    public override async Task RunAsync(ModContext context,CancellationToken token)
    {
        try
        {
            while(true)
            {
                token.ThrowIfCancellationRequested();
                var player=Player.Local.Character;
                closest=null;
                if(player is not null)
                {
                    Vector3 position=player.Position;
                    closest=World.GetNearbyVehicles(position,50f)
                        .Where(vehicle=>vehicle.Exists && vehicle.Kind is VehicleKind.Automobile or VehicleKind.MonsterTruck)
                        .MinBy(vehicle=>Vector3.DistanceSquared(position,vehicle.Position));
                    if(closest is not null)
                    {
                        // Stock vehicle health is normalized to 1000 for 100 percent.
                        int percent=Math.Clamp((int)MathF.Round(closest.Health/10f),0,100);
                        label=$"{percent}%";
                        color=percent>60?new(70,220,80):percent>30?new(255,190,60):new(255,80,80);
                    }
                }
                await Delay(200,token);
            }
        }
        finally {closest=null;}
    }
    public override void Draw()
    {
        if(Game.IsPaused || closest is null || !closest.Exists)return;
        if(Hud.TryProjectAboveVehicle(closest,out var screen))
            Hud.DrawText(label,new Vector2(screen.X-15,screen.Y-16),color,0.8f);
    }
}
