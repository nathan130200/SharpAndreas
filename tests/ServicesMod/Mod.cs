using System.Numerics;
using SharpAndreas;
using Sdk=SharpAndreas.Sdk;
public class ServicesFixture:Mod
{
    private Txd? dictionary;
    private HudTexture? texture;
    private Sprite? sprite;
    public override async Task RunAsync(ModContext context,CancellationToken token)
    {
        var zone=Zone.At(new(2491,-1668,13))??throw new Exception("Missing zone");
        if(zone.Label!="GANTON" || zone.Level!=ZoneLevel.LosSantos || !zone.Contains(new(2491,-1668,13)) || Zone.Find("ganton")?.TextKey!="GANTON")throw new Exception("Zone snapshot failed");
        try {Zone.Find("TOO_LONG_LABEL");throw new Exception("Invalid zone accepted");}catch(ArgumentException) {}
        if(Weather.State.Rain!=0.25f || Weather.State.Next!=WeatherType.CloudyLosSantos)throw new Exception("Weather bridge failed");
        Weather.Force(WeatherType.SunnyLosSantos,true);Weather.Release();Weather.SetHeatHaze(false);Weather.SetAppropriateNow();
        var boat=Vehicle.FromHandle(108) as Boat??throw new Exception("Boat classification failed");
        if(!ReferenceEquals(boat.Native,boat.Native))throw new Exception("Boat Native cache failed");
        boat.Anchor();boat.GoTo(new(1,2,3));boat.SetCruiseSpeed(10);boat.Stop();
        var car=Vehicle.FromHandle(42) as Car??throw new Exception("Car classification failed");
        if(!ReferenceEquals(car.Native,car.Native) || car.Speed!=12.5f || car.Velocity!=Vector3.Zero || car.PassengerCount!=1 || car.PassengerCapacity!=3)throw new Exception("Car helpers failed");
        car.Repair();car.SetColors(1,2);car.SetForwardSpeed(10);car.SetEngineRunning(true);
        if(Player.Local.Money!=500 || Player.Local.WantedLevel!=2 || !Player.Local.IsControlEnabled)throw new Exception("Player helpers failed");
        Player.Local.AddMoney(1);Player.Local.ClearWantedLevel();
        using var characterDecision=DecisionMakerChar.Copy(DecisionMakerCharTemplate.Empty);
        characterDecision.AssignTo(Player.Local.Character!);
        var eventType=Enum.GetValues<Sdk.eEventType>().First(value=>(int)value>0 && (int)value<96);
        var taskType=Enum.GetValues<Sdk.eTaskType>().First(value=>(int)value>0);
        characterDecision.ClearEventResponses(eventType);characterDecision.AddEventResponse(eventType,taskType,new(0,100,0,0));
        using(var clone=characterDecision.Copy()) {if(!clone.Exists)throw new Exception("Decision clone missing");}
        using(var loaded=DecisionMakerChar.Load(DecisionMakerCharType.Normal)) {if(!loaded.Exists)throw new Exception("Decision load failed");}
        using var groupDecision=DecisionMakerGroup.Copy(DecisionMakerGroupTemplate.RandomPassive);groupDecision.AssignTo(Player.Local.Group);
        using(var loaded=DecisionMakerGroup.Load()) {if(!loaded.Exists)throw new Exception("Group decision load failed");}
        DecisionMakerChar.AssignTemplate(Player.Local.Character!,DecisionMakerCharTemplate.RandomNormal);DecisionMakerGroup.AssignTemplate(Player.Local.Group,DecisionMakerGroupTemplate.RandomPassive);
        var pickup=await Pickup.CreateAsync(346,PickupType.Once,new(1,2,3),100,token);
        if(pickup.Model!=346 || pickup.Type!=PickupType.Once || pickup.Position!=new Vector3(1,2,3) || !ReferenceEquals(pickup.Native,pickup.Native) || pickup.WasCollected)throw new Exception("Pickup API failed");
        // Deliberately leave owned resources for loader cleanup, including on the fault path.
        var blip=Blips.Create(pickup.Position);blip.SetColor(1);blip.SetScale(2);blip.SetDisplay(3);
        Sphere.Create(new(1,2,3),2);User3DMarker.Create(new(1,2,3));
        if(World.GetAllPickups().Length!=3 || World.GetClosestPickup(Vector3.Zero)==null || World.GetGroundHeight(Vector3.Zero)!=13.5f)throw new Exception("World helpers failed");
        Paths.SetPedRoadsEnabled(Vector3.Zero,Vector3.One,false);Paths.RestorePedRoads(Vector3.Zero,Vector3.One);Paths.SetVehicleRoadsEnabled(Vector3.Zero,Vector3.One,false);Paths.RestoreVehicleRoads(Vector3.Zero,Vector3.One);
        if(Camera.Position!=Vector3.Zero || Camera.Target!=Vector3.Zero)throw new Exception("Camera getters failed");Camera.SetFixed(Vector3.Zero,Vector3.UnitZ);Camera.LookAt(Vector3.One);Camera.Fade(100,true);Camera.Restore();
        Sound.PlayAt(1057,Vector3.Zero);Shopping.Load("TEST");if(Shopping.ItemCount!=3 || Shopping.GetItem(1)!=101 || Shopping.GetPrice(101)!=50 || !Shopping.HasBought(101))throw new Exception("Shopping helpers failed");Shopping.Clear();
        Skip.SetDestination(Vector3.Zero,0);Skip.Clear();await Streaming.RequestAnimationAsync("PED",token);Streaming.RemoveAnimation("PED");await Streaming.RequestCarRecordingAsync(1,token);Streaming.RemoveCarRecording(1);
        if(Enum.GetValues<StatType>().Length!=305 || Stat.GetInt(StatType.ProgressMade)!=7 || Stat.GetFloat(StatType.Fat)!=2.5f)throw new Exception("Stats failed");Stat.SetFloat(StatType.Fat,1);
        string path=Path.Combine(context.Directory,"fixture.txd");await File.WriteAllBytesAsync(path,[1,2,3],token);
        // The host backend supplies a texture fixture; actual TXD parsing is exercised by GTA only.
        dictionary=await Txd.LoadAsync(path,token);texture=dictionary.GetTexture("test");sprite=new(texture);
        try {await AudioStream3D.LoadAsync(path,token);throw new Exception("Missing BASS was accepted");}catch(FileNotFoundException ex) when(ex.Message.Contains("BASS")) {}
        Log.Info("WORLD ZONE BOAT DECISIONS SERVICES PASS");
        if(context.ModId=="ServicesFault")throw new InvalidOperationException("Services cleanup fixture");
    }
    public override void Draw() {sprite?.Draw(new(10,10,32,32));}
    public override void Stop() {Log.Info("SERVICES STOP");}
}
#if ServicesHealthy
public sealed class ServicesHealthy:ServicesFixture {}
#else
public sealed class ServicesFault:ServicesFixture {}
#endif
