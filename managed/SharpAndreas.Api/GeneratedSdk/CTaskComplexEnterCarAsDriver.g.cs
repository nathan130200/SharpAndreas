// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CTaskComplexEnterCarAsDriver : CTaskComplexEnterCar
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=80;
    public CTaskComplexEnterCarAsDriver(System.IntPtr pointer) : base(pointer) {}
    public void @InitializeAt(CVehicle? @pTargetVehicle) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4013 >(4013)(Pointer,@pTargetVehicle?.Pointer ?? IntPtr.Zero); }
}
