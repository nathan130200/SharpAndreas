// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CTaskComplexEnterBoatAsDriver : CTaskComplex
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=16;
    public CTaskComplexEnterBoatAsDriver(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_pTargetVehicle")]
    public CVehicle? @TargetVehicle { get => SdkMemory.Read<IntPtr>(Pointer+12) == IntPtr.Zero ? null : new CVehicle(SdkMemory.Read<IntPtr>(Pointer+12)); set { SdkMemory.Write(Pointer+12,value?.Pointer ?? IntPtr.Zero); } }
    public void @InitializeAt(CVehicle? @pTargetVehicle) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4007 >(4007)(Pointer,@pTargetVehicle?.Pointer ?? IntPtr.Zero); }
}
