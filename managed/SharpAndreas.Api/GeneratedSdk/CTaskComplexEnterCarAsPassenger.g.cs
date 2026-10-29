// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CTaskComplexEnterCarAsPassenger : CTaskComplexEnterCar
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=80;
    public CTaskComplexEnterCarAsPassenger(System.IntPtr pointer) : base(pointer) {}
    public void @InitializeAt(CVehicle? @pTargetVehicle,int @nTargetSeat,bool @bCarryOnAfterFallingOff) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4014 >(4014)(Pointer,@pTargetVehicle?.Pointer ?? IntPtr.Zero,@nTargetSeat,(@bCarryOnAfterFallingOff ? 1 : 0)); }
}
