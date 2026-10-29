// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CEmergencyPed : CPed
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=1948;
    public CEmergencyPed(System.IntPtr pointer) : base(pointer) {}
    public void @InitializeAt(uint @pedType,uint @modelIndex) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2490 >(2490)(Pointer,@pedType,@modelIndex); }
    public bool @InRange(CPed? @ped) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2491 >(2491)(Pointer,@ped?.Pointer ?? IntPtr.Zero); return __sdkResult != 0; }
    public void @ProcessControl() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2492 >(2492)(Pointer); }
}
