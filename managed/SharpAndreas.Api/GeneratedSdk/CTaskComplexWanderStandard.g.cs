// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CTaskComplexWanderStandard : CTaskComplexWander
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=56;
    public CTaskComplexWanderStandard(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_TaskTimer")]
    public CTaskTimer @TaskTimer { get => new CTaskTimer(Pointer+40); set { SdkMemory.Copy(value.Pointer,Pointer+40,12); } }
    [NativeMember("m_nMinNextScanTime")]
    public int @MinNextScanTime { get => SdkMemory.Read<int >(Pointer+52); set { SdkMemory.Write(Pointer+52,value); } }
    public void @InitializeAt(int @MoveState,byte @Dir,bool @bWanderSensibly) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4036 >(4036)(Pointer,@MoveState,@Dir,(@bWanderSensibly ? 1 : 0)); }
}
