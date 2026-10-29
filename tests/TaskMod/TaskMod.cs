using System.Numerics;
using SharpAndreas;
using Sdk=SharpAndreas.Sdk;
using Plane=SharpAndreas.Plane;

public abstract class TaskFixture:Mod
{
    private ModContext context=null!;
    public override void Start(ModContext value)
    {
        context=value;
        if(Path.GetFileName(context.Directory)=="MalformedConfig")
        {
            File.WriteAllText(Path.Combine(context.Directory,"broken.toml"),"value = [");
            context.Config.Load<Settings>("broken.toml");
        }
    }
    public override async Task RunAsync(ModContext context,CancellationToken token)
    {
        var ped=Player.Local.Character!;
        if(Path.GetFileName(context.Directory)=="TaskFault")
        {
            ped.Tasks.Assign(new Broken());
            try { await Delay(-1); }
            finally { Log.Info("NATIVE FAILURE FINALLY"); }
            return;
        }
        if(WeaponInfo.All.Count!=47 || WeaponInfo.Get(WeaponType.Pistol).Id!=22 || WeaponInfo.Get(22).ModelId!=346 || WeaponInfo.Get(22).ModelName!="colt45")
            throw new Exception("Weapon ID/model mapping failed");
        if(WeaponInfo.Get(WeaponType.Tec9).ModelId!=372 || WeaponInfo.Get(WeaponType.Parachute).ModelId!=371 || WeaponInfo.Get(WeaponType.Unarmed).ModelId!=-1)
            throw new Exception("Special weapon mappings failed");
        if(WeaponInfo.Get(WeaponType.SatchelCharge).SecondaryModelId!=364 || WeaponInfo.GetByModelId(364).Count!=2 || WeaponInfo.GetByModelId(345).Count!=3)
            throw new Exception("Shared/secondary weapon model lookup failed");
        if(WeaponInfo.TryGet(999,out _) || WeaponInfo.TryGet(-1,out _) || WeaponInfo.TryGet(49,out _) || WeaponInfo.GetByModelId(-1).Count!=0 || WeaponInfo.GetByModelId(9999).Count!=0)
            throw new Exception("Invalid weapon/model ID accepted");
        foreach(var info in WeaponInfo.All)
        {
            if(!ReferenceEquals(info,WeaponInfo.Get(info.Type)) || (info.ModelId>=0 && !WeaponInfo.GetByModelId(info.ModelId).Contains(info)))
                throw new Exception("Weapon catalogue round-trip failed");
        }
        await Task.Run(()=>Parallel.For(0,100,i=>
        {
            if(!ReferenceEquals(WeaponInfo.Get(22),WeaponInfo.Get(WeaponType.Pistol)))throw new Exception("Weapon lookup allocated a new descriptor");
        }));
        Log.Info("WEAPON INFO PASS");
        if(PedInfo.All.Count!=276 || PedInfo.Get(0).PedType!=PedType.Player1 || PedInfo.Get(7).ModelName!="male01")
            throw new Exception("Ped metadata catalogue failed");
        if(!PedInfo.TryGet("MaLe01",out var male) || male.ModelId!=7 || male.Stats.Name!="STAT_PROSTITUTE" || male.AnimationGroup!="man")
            throw new Exception("Ped name/stats lookup failed");
        if(PedInfo.Get(51).AudioType!="PED_TYPE_GEN" || !PedInfo.Get(51).BuysDrugs || PedInfo.Get(299).IsSpecialModel!=true)
            throw new Exception("Ped field parsing failed");
        if(PedInfo.TryGet(-1,out _) || PedInfo.TryGet(1,out _) || PedInfo.TryGet(9999,out _) || PedInfo.TryGet("missing",out _))
            throw new Exception("Unknown ped model accepted");
        foreach(var info in PedInfo.All)
        {
            if(PedInfo.Get(info.ModelId)!=info || !PedInfo.GetByPedType(info.PedType).Contains(info) || info.Stats.Name is null)
                throw new Exception("Ped catalogue round-trip failed");
        }
        Log.Info("PED INFO PASS");
        if(VehicleInfo.All.Count!=212 || VehicleInfo.Get(411).ModelName!="infernus" || VehicleInfo.Get(411).HandlingId!="INFERNUS" || VehicleInfo.Get(411).Class!=VehicleClass.Executive)
            throw new Exception("Vehicle metadata catalogue failed");
        if(!VehicleInfo.TryGet("InFeRnUs",out var infernus) || infernus.ModelId!=411 || infernus.GameNameKey!="INFERNU")
            throw new Exception("Vehicle name lookup failed");
        if(VehicleInfo.Get(537).Kind!=VehicleKind.Train || VehicleInfo.Get(435).Kind!=VehicleKind.Trailer || VehicleInfo.Get(520).Kind!=VehicleKind.Plane || VehicleInfo.Get(425).Kind!=VehicleKind.Helicopter)
            throw new Exception("Vehicle type mapping failed");
        if(VehicleInfo.Get(430).WheelScaleFront!=null || VehicleInfo.Get(448).WheelModelId!=16 || VehicleInfo.Get(420).ComponentRules!=0x1f10)
            throw new Exception("Optional/hexadecimal vehicle fields failed");
        if(VehicleInfo.TryGet(-1,out _) || VehicleInfo.TryGet(7,out _) || VehicleInfo.TryGet(99999,out _) || VehicleInfo.TryGet("missing",out _))
            throw new Exception("Unknown vehicle model accepted");
        foreach(var info in VehicleInfo.All)
        {
            if(VehicleInfo.Get(info.ModelId)!=info || !VehicleInfo.GetByKind(info.Kind).Contains(info))
                throw new Exception("Vehicle catalogue round-trip failed");
        }
        Log.Info("VEHICLE INFO PASS");
        int[] worldHandles=[42,556,813]; // Includes generation bytes, skips the free slot at index 1.
        if(!World.GetAllPeds().Select(entity=>entity.Handle).SequenceEqual(worldHandles) ||
           !World.GetAllVehicles().Select(entity=>entity.Handle).SequenceEqual(worldHandles) ||
           !World.GetAllProps().Select(entity=>entity.Handle).SequenceEqual(worldHandles))
            throw new Exception("World pool snapshot/free-slot/handle query failed");
        if(World.GetAllPeds().Any(entity=>!entity.Exists) || World.GetAllVehicles().Any(entity=>!entity.Exists) || World.GetAllProps().Any(entity=>!entity.Exists))
            throw new Exception("World query returned invalid handles");
        var worldVehicles=World.GetAllVehicles();
        if(worldVehicles[1] is not Train || worldVehicles[2] is not Plane || worldVehicles[1].Kind!=VehicleKind.Train)
            throw new Exception("World query lost specialized vehicle type");
        if(World.GetNearbyPeds(Vector3.Zero,3).Single().Handle!=556 || World.GetNearbyVehicles(Vector3.Zero,3).Single() is not Train || World.GetNearbyProps(Vector3.Zero,3).Single().Handle!=556)
            throw new Exception("World radius boundary query failed");
        if(World.GetNearbyPeds(new Vector3(1,2,100),1).Length!=0 || World.GetNearbyVehicles(Vector3.Zero,2.99f).Length!=0 || World.GetNearbyProps(Vector3.Zero,0).Length!=0)
            throw new Exception("World query ignored distance/height");
        if(World.GetClosestPed(Vector3.Zero)?.Handle!=556 || World.GetClosestVehicle(Vector3.Zero) is not Train || World.GetClosestProp(Vector3.Zero)?.Handle!=556)
            throw new Exception("World nearest query failed");
        if(World.GetClosestPed(Vector3.Zero,2)==null && World.GetClosestVehicle(Vector3.Zero,2)==null && World.GetClosestProp(Vector3.Zero,2)==null) { }
        else throw new Exception("Empty nearest query did not return null");
        if(World.GetClosestPed(new Vector3(1,2,3),0)?.Handle!=42)throw new Exception("Zero-radius exact query failed");
        foreach(float radius in new[]{-1,float.NaN,float.PositiveInfinity})
        {
            try { World.GetNearbyVehicles(Vector3.Zero,radius);throw new Exception("Invalid world radius accepted"); }
            catch(ArgumentOutOfRangeException) { }
        }
        try { World.GetNearbyProps(new Vector3(float.NaN,0,0),1);throw new Exception("Invalid world position accepted"); }
        catch(ArgumentOutOfRangeException) { }
        bool worldRejected=await Task.Run(()=>
        {
            try { World.GetAllPeds();return false; }
            catch(InvalidOperationException) { return true; }
        });
        if(!worldRejected)throw new Exception("World query accepted worker-thread game access");
        Log.Info("WORLD QUERY PASS");
        var pedNode=Paths.GetClosestPedNode(Vector3.Zero)??throw new Exception("Ped path node missing");
        if(pedNode.Id!=new PathNodeId(0,3) || pedNode.Position!=new Vector3(2,0,0) || pedNode.Heading!=270 || pedNode.HeadingTarget!=new PathNodeId(0,4) || pedNode.Width!=1)
            throw new Exception("Ped node position/heading/width failed");
        var carNode=Paths.GetClosestVehicleNode(Vector3.Zero)??throw new Exception("Vehicle path node missing");
        if(carNode.Id!=new PathNodeId(0,0) || carNode.Position!=Vector3.Zero || carNode.Heading!=0 || carNode.Type!=PathNodeType.Vehicle)
            throw new Exception("Vehicle node position/heading failed");
        var linkedNodes=pedNode.GetLinkedNodes();
        if(linkedNodes.Length!=1 || linkedNodes[0].Id!=new PathNodeId(0,4) || linkedNodes[0].Heading!=null || linkedNodes[0].LinkCount!=0)
            throw new Exception("Path links/dead-end nullable heading failed");
        if(Paths.GetNthClosestPedNode(Vector3.Zero,1)?.Id!=new PathNodeId(0,4) || Paths.GetNthClosestPedNode(Vector3.Zero,2)!=null || Paths.GetNthClosestVehicleNode(Vector3.Zero,1)?.Id!=new PathNodeId(0,1))
            throw new Exception("Nth path node query failed");
        if(Paths.GetClosestPedNode(Vector3.Zero,1)!=null || Paths.GetClosestPedNode(Vector3.Zero,2)?.Id!=pedNode.Id || Paths.GetClosestVehicleNode(Vector3.Zero,0)?.Id!=carNode.Id)
            throw new Exception("Path radius boundary query failed");
        if(Paths.GetClosestPedNode(new Vector3(1,0,0),includeSwitchedOff:true)?.IsSwitchedOff!=true || Paths.GetClosestVehicleNode(new Vector3(1,0,0),includeWater:true)?.IsWater!=true)
            throw new Exception("Path switched-off/water filter failed");
        if(Paths.GetNode(pedNode.Id)!=pedNode || Paths.GetNode(new PathNodeId(1,0))!=null || Paths.GetLinkedNodes(new PathNodeId(1,0)).Length!=0)
            throw new Exception("Path ID lookup/unloaded area query failed");
        try { Paths.GetNthClosestPedNode(Vector3.Zero,-1);throw new Exception("Negative node rank accepted"); }
        catch(ArgumentOutOfRangeException) { }
        try { Paths.GetNode(new PathNodeId(-1,0));throw new Exception("Invalid node ID accepted"); }
        catch(ArgumentOutOfRangeException) { }
        foreach(float radius in new[]{-1,float.NaN,float.PositiveInfinity})
        {
            try { Paths.GetClosestPedNode(Vector3.Zero,radius);throw new Exception("Invalid path radius accepted"); }
            catch(ArgumentOutOfRangeException) { }
        }
        try { Paths.GetClosestVehicleNode(new Vector3(float.PositiveInfinity,0,0));throw new Exception("Invalid path position accepted"); }
        catch(ArgumentOutOfRangeException) { }
        bool pathsRejected=await Task.Run(()=>
        {
            try { Paths.GetClosestPedNode(Vector3.Zero);return false; }
            catch(InvalidOperationException) { return true; }
        });
        if(!pathsRejected)throw new Exception("Path query accepted worker-thread game access");
        Log.Info("PATH QUERY PASS");
        var settings=context.Config.Load<Settings>();
        settings.DelayMs=42; settings.Names=["one","two"];
        context.Config.Save(settings);
        var loaded=context.Config.Load<Settings>();
        if(loaded.DelayMs!=42 || loaded.Names.Length!=2 || loaded.Section.Name!="nested") throw new Exception("TOML round-trip failed");
        await Task.Run(()=>Log.Info("WORKER LOG"));
        Log.Error(new InvalidOperationException("LOG EXCEPTION"));
        if(Vehicle.FromHandle(104) is not Train || Vehicle.FromHandle(105) is not Trailer || Vehicle.FromHandle(106) is not Plane || Vehicle.FromHandle(107) is not Helicopter)throw new Exception("Special vehicle classification failed");
        if(!ReferenceEquals(ped.Native,ped.Native))throw new Exception("Ped native wrapper was not cached");
        foreach(int handle in new[]{104,105,106,107})
        {
            var vehicle=Vehicle.FromHandle(handle);
            if(!ReferenceEquals(vehicle.Native,vehicle.Native))throw new Exception("Vehicle native wrapper was not cached");
            bool cached=vehicle switch
            {
                Train train=>ReferenceEquals(train.Native,train.Native),
                Trailer trailer=>ReferenceEquals(trailer.Native,trailer.Native),
                Plane plane=>ReferenceEquals(plane.Native,plane.Native),
                Helicopter helicopter=>ReferenceEquals(helicopter.Native,helicopter.Native),
                _=>false
            };
            if(!cached)throw new Exception("Special vehicle native wrapper was not cached");
        }
        Log.Info("NATIVE WRAPPER CACHE PASS");
        if(Player.Local.Gang.Group.Handle!=10)throw new Exception("Player gang/group lookup failed");
        using(var gang=Gang.Create("Test Gang",new Ped(43),GangFaction.Unused2))
        {
            gang.Add(new Ped(44));
            if(!gang.Group.Contains(new Ped(44)) || Gang.GetFaction(new Ped(44))!=GangFaction.Unused2)throw new Exception("Gang assignment failed");
            Gang.SetWeapons(GangFaction.Unused2,22,28,30);
        }
        if(Gang.GetFaction(new Ped(43))!=null || Gang.GetFaction(new Ped(44))!=null)throw new Exception("Gang cleanup did not restore original factions");
        Log.Info("VEHICLES AND GANGS PASS");
        if(Sdk.CClock.GetGameClockMinutesUntil(2,3)!=123) throw new Exception("Generated SDK call transport failed");
        if(typeof(Sdk.CEntity).GetProperty("Type")==null || typeof(Sdk.CPed).GetProperty("Health")==null || typeof(Sdk.CEntity).GetProperty("m_nType")!=null)
            throw new Exception("Native field names leaked into the C# API");
        var browse=(System.ComponentModel.EditorBrowsableAttribute?)Attribute.GetCustomAttribute(typeof(Sdk.CVector).GetField("NativeSize")!,typeof(System.ComponentModel.EditorBrowsableAttribute));
        if(browse?.State!=System.ComponentModel.EditorBrowsableState.Never) throw new Exception("NativeSize is visible in IntelliSense");
        using(var vector=Sdk.NativeObject.AllocateStorage<Sdk.CVector>(Sdk.CVector.NativeSize))
        {
            vector.X=1.25f; vector.Y=2.5f; vector.Z=3.75f;
            if(vector.X!=1.25f || vector.Y!=2.5f || vector.Z!=3.75f) throw new Exception("Generated SDK field offsets failed");
        }
        var sequence=new TaskSequence().StandStill(100).GoTo(new Vector3(1,2,3));
        sequence.Perform(ped);
        if(ped.Tasks.SequenceProgress!=0) throw new Exception("Sequence output mismatch");
        using(var simple=new Counter(3,"SIMPLE"))
        {
            using(var clone=simple.Clone()) { }
            ped.Tasks.Assign(simple);
        }
        await Delay(120);
        using(var complex=new Chain()) ped.Tasks.Assign(complex);
        await Delay(200);
        using(var native=NativeTasks.StandStill(10)) ped.Tasks.Assign(native);
        Log.Info("TASKS CONFIG SDK PASS");
    }
    public override void Stop()
    {
        string file=Path.Combine(context.Directory,"stop.count");
        int count=File.Exists(file)?int.Parse(File.ReadAllText(file)):0;
        File.WriteAllText(file,(count+1).ToString());
        Log.Info("STOP CLEANUP "+Path.GetFileName(context.Directory));
    }
    private sealed class Counter:ManagedSimpleTask
    {
        private readonly int count;
        private readonly string label;
        private int remaining;
        public Counter(int count,string label) { this.count=count;this.label=label;remaining=count; }
        public override bool ProcessPed(Ped ped)
        {
            if(ped.Handle!=42) throw new Exception("Native ped handle callback mismatch");
            Game.IsKeyDown(0);
            if(remaining==count) Log.Info(label+" PROCESS");
            return --remaining<=0;
        }
        public override void OnDeleted()=>Log.Info(label+" DELETED");
        public override ManagedSimpleTask CloneState() { Log.Info("SIMPLE CLONED"); return new Counter(count,label+" CLONE"); }
    }
    private sealed class Chain:ManagedComplexTask
    {
        private int step;
        public override PedTask CreateFirstSubTask(Ped ped)=>new Counter(2,"COMPLEX FIRST");
        public override PedTask? CreateNextSubTask(Ped ped)=>step++==0?new Counter(2,"COMPLEX NEXT"):null;
        public override void OnDeleted()=>Log.Info("COMPLEX DELETED");
        public override ManagedComplexTask CloneState()=>new Chain();
    }
    private sealed class Broken:ManagedSimpleTask
    {
        public override bool ProcessPed(Ped ped)=>throw new Exception("Expected native callback failure");
        public override ManagedSimpleTask CloneState()=>new Broken();
    }
}
#if TaskHealthy
public sealed class TaskHealthy:TaskFixture { }
#elif TaskFault
public sealed class TaskFault:TaskFixture { }
#elif MalformedConfig
public sealed class MalformedConfig:TaskFixture { }
#else
public sealed class TaskMod:TaskFixture { }
#endif
public sealed class Settings
{
    public int DelayMs {get;set;}=1000;
    public string[] Names {get;set;}=[];
    public Nested Section {get;set;}=new();
}
public sealed class Nested { public string Name {get;set;}="nested"; }
