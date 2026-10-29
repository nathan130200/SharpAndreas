// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CTaskComplexWander : CTaskComplex
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=40;
    public CTaskComplexWander(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_nMoveState")]
    public int @MoveState { get => SdkMemory.Read<int >(Pointer+12); set { SdkMemory.Write(Pointer+12,value); } }
    [NativeMember("m_nDir")]
    public byte @Direction { get => SdkMemory.Read<byte >(Pointer+16); set { SdkMemory.Write(Pointer+16,value); } }
    [NativeMember("m_fTargetRadius")]
    public float @TargetRadius { get => SdkMemory.Read<float >(Pointer+20); set { SdkMemory.Write(Pointer+20,value); } }
    [NativeMember("m_LastNode")]
    public CNodeAddress @LastNode { get => new CNodeAddress(Pointer+24); set { SdkMemory.Copy(value.Pointer,Pointer+24,4); } }
    [NativeMember("m_NextNode")]
    public CNodeAddress @NextNode { get => new CNodeAddress(Pointer+28); set { SdkMemory.Copy(value.Pointer,Pointer+28,4); } }
    [NativeMember("m_nLastUpdateDirFrameCount")]
    public int @LastUpdateDirectionFrameCount { get => SdkMemory.Read<int >(Pointer+32); set { SdkMemory.Write(Pointer+32,value); } }
    public void @InitializeAt(int @MoveState,byte @Dir,bool @bWanderSensibly,float @TargetRadius) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4035 >(4035)(Pointer,@MoveState,@Dir,(@bWanderSensibly ? 1 : 0),@TargetRadius); }
}
