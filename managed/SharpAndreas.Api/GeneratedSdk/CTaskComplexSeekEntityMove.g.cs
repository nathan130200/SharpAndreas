// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CTaskComplexSeekEntityMove : CTaskComplex
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=76;
    public CTaskComplexSeekEntityMove(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_entity")]
    public CEntity? @Entity { get => SdkMemory.Read<IntPtr>(Pointer+12) == IntPtr.Zero ? null : new CEntity(SdkMemory.Read<IntPtr>(Pointer+12)); set { SdkMemory.Write(Pointer+12,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_time")]
    public uint @Time { get => SdkMemory.Read<uint >(Pointer+16); set { SdkMemory.Write(Pointer+16,value); } }
    [NativeMember("m_scanInterval")]
    public uint @ScanInterval { get => SdkMemory.Read<uint >(Pointer+20); set { SdkMemory.Write(Pointer+20,value); } }
    [NativeMember("m_maxEntityDist2D")]
    public float @MaxEntityDist2D { get => SdkMemory.Read<float >(Pointer+24); set { SdkMemory.Write(Pointer+24,value); } }
    [NativeMember("m_moveStateRadius")]
    public float @MoveStateRadius { get => SdkMemory.Read<float >(Pointer+28); set { SdkMemory.Write(Pointer+28,value); } }
    [NativeMember("m_minEntityDist2D")]
    public float @MinEntityDist2D { get => SdkMemory.Read<float >(Pointer+32); set { SdkMemory.Write(Pointer+32,value); } }
    [NativeMember("m_followNodeThresholdHeightChange")]
    public float @FollowNodeThresholdHeightChange { get => SdkMemory.Read<float >(Pointer+36); set { SdkMemory.Write(Pointer+36,value); } }
    [NativeMember("m_scanTimer")]
    public CTaskTimer @ScanTimer { get => new CTaskTimer(Pointer+40); set { SdkMemory.Copy(value.Pointer,Pointer+40,12); } }
    [NativeMember("m_timer")]
    public CTaskTimer @Timer { get => new CTaskTimer(Pointer+52); set { SdkMemory.Copy(value.Pointer,Pointer+52,12); } }
    [NativeMember("posCalculatorVTable")]
    public NativePointer<IntPtr> @PositionCalculatorVTable { get => new NativePointer<IntPtr>(SdkMemory.Read<IntPtr>(Pointer+64)); set { SdkMemory.Write(Pointer+64,value.Pointer); } }
    [NativeMember("m_moveState")]
    public eMoveState @MoveState { get => SdkMemory.Read<eMoveState >(Pointer+68); set { SdkMemory.Write(Pointer+68,value); } }
    [NativeMember("m_playTiredAnim")]
    public bool @PlayTiredAnimation { get => SdkMemory.ReadBits(Pointer,576,1) != 0; set { SdkMemory.WriteBits(Pointer,576,1,(value ? 1UL : 0UL)); } }
    [NativeMember("m_faceEntityWhenDone")]
    public bool @FaceEntityWhenDone { get => SdkMemory.ReadBits(Pointer,577,1) != 0; set { SdkMemory.WriteBits(Pointer,577,1,(value ? 1UL : 0UL)); } }
    [NativeMember("m_achievedSeekEntity")]
    public bool @AchievedSeekEntity { get => SdkMemory.ReadBits(Pointer,578,1) != 0; set { SdkMemory.WriteBits(Pointer,578,1,(value ? 1UL : 0UL)); } }
    [NativeMember("m_trackingEntity")]
    public bool @TrackingEntity { get => SdkMemory.ReadBits(Pointer,579,1) != 0; set { SdkMemory.WriteBits(Pointer,579,1,(value ? 1UL : 0UL)); } }
    public void @InitializeAt(CEntity? @entity,uint @time,uint @scanInterval,float @maxEntityDist2D,float @moveStateRadius,float @followNodeThresholdHeightChange,bool @playTiredAnim,bool @faceEntityWhenDone) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4028 >(4028)(Pointer,@entity?.Pointer ?? IntPtr.Zero,@time,@scanInterval,@maxEntityDist2D,@moveStateRadius,@followNodeThresholdHeightChange,(@playTiredAnim ? 1 : 0),(@faceEntityWhenDone ? 1 : 0)); }
}
