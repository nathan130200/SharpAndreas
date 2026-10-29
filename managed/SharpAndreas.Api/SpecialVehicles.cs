using System.Numerics;

namespace SharpAndreas;

public enum VehicleKind { Automobile=0,MonsterTruck=1,Quad=2,Helicopter=3,Plane=4,Boat=5,Train=6,FakeHelicopter=7,FakePlane=8,Motorcycle=9,Bicycle=10,Trailer=11 }

public sealed class Plane:Vehicle
{
    private readonly Lazy<Sdk.CPlane> native;
    public Plane(int handle):base(handle)
    {
        native = new(() => new Sdk.CPlane(base.Native.Pointer), LazyThreadSafetyMode.ExecutionAndPublication);
    }
    public new Sdk.CPlane Native
    {
        get { RequireKind(VehicleKind.Plane); return native.Value; }
    }
    public float Throttle {set { RequireKind(VehicleKind.Plane);if(!float.IsFinite(value) || value is < -1 or > 1) throw new ArgumentOutOfRangeException(nameof(value));Scm.Call((ushort)0x0742,Handle,value); } }
    public void SetLandingGearRetracted(bool retracted) { RequireKind(VehicleKind.Plane);Scm.Call((ushort)0x08E6,Handle,retracted); }
    public new static async Task<Plane> CreateAsync(int model,Vector3 position,CancellationToken cancellationToken=default)
    {
        var vehicle=await Vehicle.CreateAsync(model,position,cancellationToken);
        if(vehicle is Plane plane)return plane;
        vehicle.Delete();throw new ArgumentException("The model is not a plane.",nameof(model));
    }
}
public sealed class Helicopter:Vehicle
{
    private readonly Lazy<Sdk.CHeli> native;
    public Helicopter(int handle):base(handle)
    {
        native = new(() => new Sdk.CHeli(base.Native.Pointer), LazyThreadSafetyMode.ExecutionAndPublication);
    }
    public new Sdk.CHeli Native
    {
        get { RequireKind(VehicleKind.Helicopter); return native.Value; }
    }
    public new static async Task<Helicopter> CreateAsync(int model,Vector3 position,CancellationToken cancellationToken=default)
    {
        var vehicle=await Vehicle.CreateAsync(model,position,cancellationToken);
        if(vehicle is Helicopter helicopter)return helicopter;
        vehicle.Delete();throw new ArgumentException("The model is not a helicopter.",nameof(model));
    }
}
public sealed class Trailer:Vehicle
{
    private readonly Lazy<Sdk.CTrailer> native;
    public Trailer(int handle):base(handle)
    {
        native = new(() => new Sdk.CTrailer(base.Native.Pointer), LazyThreadSafetyMode.ExecutionAndPublication);
    }
    public new Sdk.CTrailer Native
    {
        get { RequireKind(VehicleKind.Trailer); return native.Value; }
    }
    public bool IsAttached {get { RequireKind(VehicleKind.Trailer);return base.Native.Tractor is not null; } }
    public void AttachTo(Vehicle cab) { ArgumentNullException.ThrowIfNull(cab);RequireKind(VehicleKind.Trailer);if(!cab.Exists)throw new InvalidOperationException("Cab no longer exists.");Scm.Call((ushort)0x0893,Handle,cab.Handle); }
    public void Detach()
    {
        RequireKind(VehicleKind.Trailer);
        var tractor=base.Native.Tractor;
        if(tractor is null)return;
        int handle=Sdk.CPools.GetVehicleRef(tractor);
        Scm.Call((ushort)0x07AC,Handle,handle);
    }
    public new static async Task<Trailer> CreateAsync(int model,Vector3 position,CancellationToken cancellationToken=default)
    {
        var vehicle=await Vehicle.CreateAsync(model,position,cancellationToken);
        if(vehicle is Trailer trailer)return trailer;
        vehicle.Delete();throw new ArgumentException("The model is not a trailer.",nameof(model));
    }
}
public sealed class Train:Vehicle
{
    private readonly Lazy<Sdk.CTrain> native;
    public Train(int handle):base(handle)
    {
        native = new(() => new Sdk.CTrain(base.Native.Pointer), LazyThreadSafetyMode.ExecutionAndPublication);
    }
    public new Sdk.CTrain Native
    {
        get { RequireKind(VehicleKind.Train); return native.Value; }
    }
    public new float Speed
    {
        get=>Native.TrainSpeed;
        set { RequireKind(VehicleKind.Train);if(!float.IsFinite(value))throw new ArgumentOutOfRangeException(nameof(value));Native.TrainSpeed=value; }
    }
    public float CruiseSpeed {set { RequireKind(VehicleKind.Train);if(!float.IsFinite(value))throw new ArgumentOutOfRangeException(nameof(value));Scm.Call((ushort)0x06DD,Handle,value); } }
    public Train? GetCarriage(int index)
    {
        RequireKind(VehicleKind.Train);if(index<0)throw new ArgumentOutOfRangeException(nameof(index));
        var value=new ScmVariable(-1);Scm.Call((ushort)0x078A,Handle,index,value);
        return value.Int32<0 || !Scm.Call(ScmOpcode.DoesVehicleExist,value.Int32)?null:new Train(value.Int32);
    }
    public override void Delete() { if(Exists)Sdk.CTrain.RemoveOneMissionTrain(Native); }
    /// <summary>Creates a train consist, not a generic CREATE_CAR train model. Models must be streamed before creation.</summary>
    public static async Task<Train> CreateMissionAsync(int configuration,Vector3 position,bool clockwise=true,CancellationToken cancellationToken=default)
    {
        ValidatePosition(position);if(configuration is < 0 or > 15)throw new ArgumentOutOfRangeException(nameof(configuration));
        // Stock rail models. Stream cooperatively so the engine never creates an unloaded carriage.
        int[] models=[537,538,569,570,590,449];
        var requested=new List<int>();
        try
        {
            foreach(int model in models) { await Models.RequestAsync(model,cancellationToken);requested.Add(model); }
            cancellationToken.ThrowIfCancellationRequested();
            var value=new ScmVariable(-1);Scm.Call((ushort)0x06D8,configuration,position.X,position.Y,position.Z,clockwise,value);
            var train=new Train(value.Int32);train.RequireKind(VehicleKind.Train);return train;
        }
        finally {foreach(int model in requested)Models.MarkAsNoLongerNeeded(model);}
    }
}
