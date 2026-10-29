// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CPedStuckChecker : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=16;
    public CPedStuckChecker(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_lastNonStuckPoint")]
    public CVector @LastNonStuckPoint { get => new CVector(Pointer+0); set { SdkMemory.Copy(value.Pointer,Pointer+0,12); } }
    [NativeMember("m_radius")]
    public ushort @Radius { get => SdkMemory.Read<ushort >(Pointer+12); set { SdkMemory.Write(Pointer+12,value); } }
    [NativeMember("m_state")]
    public ePedStuckState @State { get => SdkMemory.Read<ePedStuckState >(Pointer+14); set { SdkMemory.Write(Pointer+14,value); } }
    public void @InitializeAt() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1300 >(1300)(Pointer); }
    public bool @TestPedStuck(CPed? @ped,CEventGroup? @eventGroup) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1301 >(1301)(Pointer,@ped?.Pointer ?? IntPtr.Zero,@eventGroup?.Pointer ?? IntPtr.Zero); return __sdkResult != 0; }
    public ePedStuckState @GetState() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1302 >(1302)(Pointer); return (ePedStuckState)__sdkResult; }
}
