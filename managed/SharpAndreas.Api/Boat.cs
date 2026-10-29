using System.Numerics;
namespace SharpAndreas;
public sealed class Boat:Vehicle
{
    private readonly Lazy<Sdk.CBoat> native;
    public Boat(int handle):base(handle) {native=new(()=>new Sdk.CBoat(base.Native.Pointer),LazyThreadSafetyMode.ExecutionAndPublication);}
    public new Sdk.CBoat Native {get {RequireKind(VehicleKind.Boat);return native.Value;}}
    public void Anchor(bool enabled=true) {RequireKind(VehicleKind.Boat);Scm.Call((ushort)0x0323,Handle,enabled);}
    public void GoTo(Vector3 destination) {ValidatePosition(destination);RequireKind(VehicleKind.Boat);Scm.Call((ushort)0x02D3,Handle,destination.X,destination.Y,destination.Z);}
    public void SetCruiseSpeed(float speed) {if(!float.IsFinite(speed)||speed<0)throw new ArgumentOutOfRangeException(nameof(speed));RequireKind(VehicleKind.Boat);Scm.Call((ushort)0x02DB,Handle,speed);}
    public void Stop() {RequireKind(VehicleKind.Boat);Scm.Call((ushort)0x02D4,Handle);}
    public new static async Task<Boat> CreateAsync(int model,Vector3 position,CancellationToken cancellationToken=default)
    {var vehicle=await Vehicle.CreateAsync(model,position,cancellationToken);if(vehicle is Boat boat)return boat;vehicle.Delete();throw new ArgumentException("The model is not a boat.",nameof(model));}
}
public sealed class Car:Vehicle
{
    private readonly Lazy<Sdk.CAutomobile> native;
    public Car(int handle):base(handle) {native=new(()=>new Sdk.CAutomobile(base.Native.Pointer),LazyThreadSafetyMode.ExecutionAndPublication);}
    public new Sdk.CAutomobile Native {get {RequireKind(VehicleKind.Automobile);return native.Value;}}
    public new static async Task<Car> CreateAsync(int model,Vector3 position,CancellationToken cancellationToken=default)
    {var vehicle=await Vehicle.CreateAsync(model,position,cancellationToken);if(vehicle is Car car)return car;vehicle.Delete();throw new ArgumentException("The model is not an automobile.",nameof(model));}
}
