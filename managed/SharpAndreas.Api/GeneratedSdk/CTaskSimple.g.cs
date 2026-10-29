// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CTaskSimple : CTask
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=8;
    public CTaskSimple(System.IntPtr pointer) : base(pointer) {}
    public bool @ProcessPed(CPed? @ped) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1303 >(1303)(Pointer,@ped?.Pointer ?? IntPtr.Zero); return __sdkResult != 0; }
    public bool @SetPedPosition(CPed? @ped) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1304 >(1304)(Pointer,@ped?.Pointer ?? IntPtr.Zero); return __sdkResult != 0; }
}
