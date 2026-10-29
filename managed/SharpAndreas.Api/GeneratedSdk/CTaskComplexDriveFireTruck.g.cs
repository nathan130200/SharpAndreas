// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CTaskComplexDriveFireTruck : CTaskComplex
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=12;
    public CTaskComplexDriveFireTruck(System.IntPtr pointer) : base(pointer) {}
    public void @InitializeAt(CVehicle? @pFiretruck,CPed? @pFireman,bool @isPassenger) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4006 >(4006)(Pointer,@pFiretruck?.Pointer ?? IntPtr.Zero,@pFireman?.Pointer ?? IntPtr.Zero,(@isPassenger ? 1 : 0)); }
}
