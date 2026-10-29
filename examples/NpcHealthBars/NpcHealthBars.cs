using System.Numerics;
namespace SharpAndreas.Examples;
public sealed class NpcHealthBars:Mod
{
    private sealed class Bar(Ped ped,HudTexture texture) {public readonly Ped Ped=ped;public readonly HudTexture Texture=texture;public int Health=-1;}
    private readonly Dictionary<int,Bar> bars=[];
    private readonly TextureCanvas canvas=new(64,8);
    public override async Task RunAsync(ModContext context,CancellationToken token)
    {
        try
        {
            while(true)
            {
                token.ThrowIfCancellationRequested();
                var player=Player.Local.Character;
                var nearby=player is null?[]:World.GetNearbyPeds(player.Position,40f).Where(ped=>ped.Handle!=player.Handle).Take(64).ToArray();
                var present=nearby.Select(ped=>ped.Handle).ToHashSet();
                foreach(var entry in bars.Where(pair=>!present.Contains(pair.Key)).ToArray()) {entry.Value.Texture.Dispose();bars.Remove(entry.Key);}
                foreach(var ped in nearby)
                {
                    if(!ped.Exists)continue;
                    if(!bars.TryGetValue(ped.Handle,out var bar)) {bar=new(ped,new HudTexture(64,8));bars.Add(ped.Handle,bar);}
                    int health=Math.Clamp(ped.Health,0,100);
                    if(health==bar.Health)continue;
                    canvas.Clear(new HudColor(0,0,0,200));
                    canvas.FillRectangle(1,1,(int)(62*health/100f),6,new HudColor(70,220,80));
                    bar.Texture.Update(canvas);bar.Health=health;
                }
                await Delay(250,token);
            }
        }
        finally {foreach(var bar in bars.Values)bar.Texture.Dispose();bars.Clear();}
    }
    public override void Draw()
    {
        if(Game.IsPaused)return;
        // Reproject every rendered frame; textures are updated only when sampled health changes.
        foreach(var bar in bars.Values)
            if(bar.Ped.Exists && Hud.TryProjectHead(bar.Ped,out var screen))
                Hud.DrawTexture(bar.Texture,new HudRect(screen.X-32,screen.Y-18,64,8));
    }
}
