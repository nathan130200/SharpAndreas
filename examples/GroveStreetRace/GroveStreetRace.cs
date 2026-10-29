using System.Numerics;
using System.Diagnostics;
namespace SharpAndreas.Examples;

/// <summary>One-lap Los Santos race ending in Grove Street. F9 starts; F10 aborts.</summary>
public sealed class GroveStreetRace:Mod
{
    private static readonly Vector3 StartPosition=new(1785,-1890,13.4f);
    private static readonly Vector3[] Course=
    [
        new(1855,-1890,13.4f),new(1970,-1880,13.4f),new(2090,-1870,13.4f),
        new(2210,-1845,13.4f),new(2300,-1750,13.4f),new(2390,-1715,13.4f),
        new(2450,-1670,13.4f),new(2491,-1668,13.4f) // Grove Street cul-de-sac: final goal.
    ];
    private static readonly int[] CarModels=[415,429,451,541,506,559,562,411];
    private static readonly int[] PedModels=[7,19,20,21,22,23,24,25];
    private sealed class Opponent(Ped driver,Vehicle car,int model)
    {
        public readonly Ped Driver=driver;
        public readonly Vehicle Car=car;
        public readonly int Model=model;
        public int Next;
        public bool Retired;
    }
    private sealed class RaceFailure(string message):Exception(message);
    private readonly List<Ped> ownedPeds=[];
    private readonly List<Vehicle> ownedCars=[];
    private readonly List<Opponent> opponents=[];
    private RaceSettings settings=new();
    private Ped? player;
    private Vehicle? playerCar;
    private bool ownsMission,controlsDisabled,active;
    private int checkpoint=-1,blip=-1,next,place=1;
    private string title="F9: Los Santos race to Grove Street",detail="F10 aborts an active race.";

    public override void Start(ModContext context)
    {
        settings=context.Config.Load<RaceSettings>("race.toml");
        if(settings.NpcRacers is <1 or >12 || settings.Spectators is <0 or >32 || settings.CountdownMilliseconds is <0 or >10000 || settings.TimeLimitSeconds is <5 or >3600 || settings.UpdateMilliseconds is <0 or >100 || !float.IsFinite(settings.CheckpointRadius) || settings.CheckpointRadius is <3 or >30 || !float.IsFinite(settings.AiSpeed) || settings.AiSpeed is <1 or >80 || settings.StartKey is <0 or >255 || settings.AbortKey is <0 or >255 || settings.StartKey==settings.AbortKey)
            throw new FormatException("Invalid race.toml settings.");
        Log.Info("Race ready: F9 starts in Los Santos; finish in Grove Street. F10 aborts.");
    }
    public override async Task RunAsync(ModContext context,CancellationToken token)
    {
        bool held=Game.IsKeyDown(settings.StartKey);
        try
        {
            while(true)
            {
                token.ThrowIfCancellationRequested();
                bool down=Game.IsKeyDown(settings.StartKey),pressed=down && !held;held=down;
                if(pressed)
                {
                    var candidate=Player.Local.Character;
                    if(candidate is null || candidate.Health<=0 || !Scm.Call(0x09E7,Player.Local.Index))Game.ShowHelp("Take control of CJ before starting the race.");
                    else if(Game.IsOnMission)Game.ShowHelp("Finish the current mission before starting this race.");
                    else if(candidate.CurrentVehicle is not null)Game.ShowHelp("Exit your vehicle before starting the race.");
                    else await RunRace(candidate,token);
                }
                await NextFrame(token);
            }
        }
        finally {Cleanup();}
    }
    private async Task RunRace(Ped cj,CancellationToken token)
    {
        player=cj;next=0;place=1;
        // Claim only a previously clear global; never clear another mission's flag.
        if(Game.IsOnMission)return;
        Game.IsOnMission=true;ownsMission=true;active=true;
        Log.Info("RACE ONMISSION TRUE");
        try
        {
            title="Preparing the Los Santos starting grid...";detail="Finish: Grove Street. F10 aborts.";
            Player.Local.SetControl(false);controlsDisabled=true;
            playerCar=await Vehicle.CreateAsync(411,StartPosition,token);ownedCars.Add(playerCar);
            playerCar.Heading=270;playerCar.Health=1000;
            Scm.Call(0x036A,cj,playerCar); // Immediate driver warp before any asynchronous countdown.
            for(int i=0;i<settings.NpcRacers;i++)
            {
                token.ThrowIfCancellationRequested();CheckPlayer();
                int model=CarModels[i%CarModels.Length];
                var position=StartPosition+new Vector3(-8*(i/2+1),i%2==0?-3:3,0);
                var car=await Vehicle.CreateAsync(model,position,token);ownedCars.Add(car);car.Heading=270;car.Health=1000;
                var driver=await Ped.CreateAsync(PedModels[i%PedModels.Length],position,PedType.CivilianMale,token);ownedPeds.Add(driver);
                Scm.Call(0x036A,driver,car);opponents.Add(new(driver,car,model));
            }
            for(int i=0;i<settings.Spectators;i++)
            {
                token.ThrowIfCancellationRequested();CheckPlayer();
                float angle=(float)(i*2*Math.PI/Math.Max(1,settings.Spectators));
                var position=Course[^1]+new Vector3(MathF.Cos(angle)*22,MathF.Sin(angle)*22,0);
                var spectator=await Ped.CreateAsync(PedModels[i%PedModels.Length],position,PedType.CivilianMale,token);ownedPeds.Add(spectator);
                spectator.Tasks.StandStill(-1);
            }
            Log.Info($"RACE GRID: {opponents.Count} opponents, {settings.Spectators} spectators");
            uint countdown=Game.GameTimeMilliseconds;
            while(unchecked(Game.GameTimeMilliseconds-countdown)<settings.CountdownMilliseconds)
            {
                token.ThrowIfCancellationRequested();CheckPlayer();
                int remaining=(int)(settings.CountdownMilliseconds-unchecked(Game.GameTimeMilliseconds-countdown));
                title=$"Starting in {(remaining+999)/1000}...";
                await NextFrame(token);
            }
            RestoreControl();ShowCheckpoint();
            foreach(var opponent in opponents)Drive(opponent);
            uint started=Game.GameTimeMilliseconds,outSince=0;bool outside=false;
            while(true)
            {
                token.ThrowIfCancellationRequested();CheckPlayer();
                uint now=Game.GameTimeMilliseconds,elapsed=unchecked(now-started);
                if(elapsed>=settings.TimeLimitSeconds*1000u)throw new RaceFailure("Time limit exceeded.");
                if(cj.CurrentVehicle?.Handle!=playerCar.Handle)
                {
                    if(!outside){outside=true;outSince=now;}
                    if(unchecked(now-outSince)>5000)throw new RaceFailure("You left the race car for too long.");
                    title="Return to your race car!";
                }
                else
                {
                    outside=false;
                    if(Vector3.DistanceSquared(playerCar.Position,Course[next])<=settings.CheckpointRadius*settings.CheckpointRadius)
                    {
                        if(++next==Course.Length)
                        {
                            place=1+opponents.Count(o=>o.Next==Course.Length);
                            if(place!=1)throw new RaceFailure($"Finished {place}/{opponents.Count+1}; first place wins.");
                            title="RACE PASSED - Grove Street!";detail=$"Finished first in {elapsed/1000f:F1} seconds.";
                            Log.Info("RACE PASSED - Finished first at Grove Street.");return;
                        }
                        ShowCheckpoint();
                    }
                    UpdateOpponents();
                    float playerDistance=Vector3.DistanceSquared(playerCar.Position,Course[next]);
                    place=1+opponents.Count(o=>!o.Retired && (o.Next>next || o.Next==next && Vector3.DistanceSquared(o.Car.Position,Course[next])<playerDistance));
                    title=$"Position {place}/{opponents.Count+1} | Checkpoint {next+1}/{Course.Length}";
                }
                detail=$"Grove Street finish | Time {elapsed/1000f:F1}s / {settings.TimeLimitSeconds}s | F10 abort";
                await Delay(settings.UpdateMilliseconds,token);
            }
        }
        catch(RaceFailure ex) {title="RACE FAILED";detail=ex.Message;Log.Info("RACE FAILED - "+ex.Message);}
        catch(OperationCanceledException) {title="Race cancelled";detail="Mod stopped or reloaded.";Log.Info("RACE CANCELLED");throw;}
        finally {Cleanup();}
    }
    private void CheckPlayer()
    {
        if(Game.IsKeyDown(settings.AbortKey))throw new RaceFailure("Aborted with F10.");
        if(player is null || !player.Exists || player.Health<=0 || Player.Local.Character?.Handle!=player.Handle)throw new RaceFailure("CJ was wasted or the player changed.");
        if(playerCar is not null && (!playerCar.Exists || playerCar.Health<=0))throw new RaceFailure("Race car destroyed.");
    }
    private void UpdateOpponents()
    {
        foreach(var opponent in opponents)
        {
            if(opponent.Retired || opponent.Next==Course.Length)continue;
            if(!opponent.Driver.Exists || opponent.Driver.Health<=0 || !opponent.Car.Exists || opponent.Car.Health<=0) {opponent.Retired=true;continue;}
            if(Vector3.DistanceSquared(opponent.Car.Position,Course[opponent.Next])<=settings.CheckpointRadius*settings.CheckpointRadius)
            {
                if(++opponent.Next<Course.Length)Drive(opponent);
                else opponent.Driver.Tasks.StandStill(-1);
            }
        }
    }
    private void Drive(Opponent opponent)
    {
        var goal=Course[opponent.Next];
        opponent.Driver.Tasks.Invoke(TaskOpcode.TASK_CAR_DRIVE_TO_COORD,opponent.Car,goal.X,goal.Y,goal.Z,settings.AiSpeed,3,opponent.Model,2);
    }
    private void ShowCheckpoint()
    {
        ClearMarkers();var point=Course[next];var target=Course[Math.Min(next+1,Course.Length-1)];
        var value=new ScmVariable(-1);
        Scm.Call(0x06D5,next==Course.Length-1?1:0,point.X,point.Y,point.Z,target.X,target.Y,target.Z,settings.CheckpointRadius,value);
        if(value.Int32<0)throw new InvalidOperationException("GTA could not create the race checkpoint.");checkpoint=value.Int32;
        value=new ScmVariable(-1);Scm.Call(0x018A,point.X,point.Y,point.Z,value);blip=value.Int32;
        if(blip>=0){Scm.Call(0x0165,blip,1);Scm.Call(0x0168,blip,2);}
    }
    private void ClearMarkers()
    {
        if(checkpoint>=0){int id=checkpoint;checkpoint=-1;Safe(()=>Scm.Call(0x06D6,id));}
        if(blip>=0){int id=blip;blip=-1;Safe(()=>Scm.Call(0x0164,id));}
    }
    private void RestoreControl()
    {
        if(!controlsDisabled)return;controlsDisabled=false;
        if(player?.Exists==true && player.Health>0)Player.Local.SetControl(true);
    }
    private void Cleanup()
    {
        // Clear mission state first, even if a later actor/marker cleanup fails.
        if(ownsMission) {ownsMission=false;Safe(()=>Game.IsOnMission=false);Log.Info("RACE ONMISSION FALSE");}
        Safe(RestoreControl);ClearMarkers();
        if(playerCar is not null)
            Safe(()=>
            {
                if(playerCar.Exists && player?.Exists==true && player.CurrentVehicle?.Handle==playerCar.Handle)
                {
                    var position=playerCar.Position+new Vector3(2,0,0.5f);
                    Scm.Call(0x0362,player,position.X,position.Y,position.Z); // Unseat before deleting our car.
                }
            });
        foreach(var ped in ownedPeds)Safe(()=>{if(ped.Exists)ped.Delete();});
        foreach(var car in ownedCars)Safe(()=>{if(car.Exists)car.Delete();});
        ownedPeds.Clear();ownedCars.Clear();opponents.Clear();playerCar=null;player=null;active=false;
    }
    private static void Safe(Action action) {try {action();}catch(Exception ex){Log.Error(ex);}}
    public override void Stop()=>Cleanup();
    public override void Draw()
    {
        if(Game.IsPaused)return;
        Hud.DrawRectangle(new(18,160,530,58),new(0,0,0,170));
        Hud.DrawText(title,new(25,165),active?new(255,220,100):HudColor.White,0.8f);
        Hud.DrawText(detail,new(25,191),HudColor.White,0.65f);
    }
    public sealed class RaceSettings
    {
        public int NpcRacers {get;set;}=8;
        public int Spectators {get;set;}=12;
        public int CountdownMilliseconds {get;set;}=3000;
        public int TimeLimitSeconds {get;set;}=180;
        public int UpdateMilliseconds {get;set;}=50;
        public float CheckpointRadius {get;set;}=12;
        public float AiSpeed {get;set;}=26;
        public int StartKey {get;set;}=0x78;
        public int AbortKey {get;set;}=0x79;
    }
}
