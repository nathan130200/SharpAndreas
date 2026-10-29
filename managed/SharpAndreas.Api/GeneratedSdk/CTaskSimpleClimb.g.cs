// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CTaskSimpleClimb : CTaskSimple
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=48;
    public CTaskSimpleClimb(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_bIsFinished")]
    public bool @IsFinished { get => SdkMemory.Read<bool >(Pointer+8); set { SdkMemory.Write(Pointer+8,value); } }
    [NativeMember("m_bChangeAnimation")]
    public bool @ChangeAnimation { get => SdkMemory.Read<bool >(Pointer+9); set { SdkMemory.Write(Pointer+9,value); } }
    [NativeMember("m_bChangePosition")]
    public bool @ChangePosition { get => SdkMemory.Read<bool >(Pointer+10); set { SdkMemory.Write(Pointer+10,value); } }
    [NativeMember("m_bForceClimb")]
    public bool @ForceClimb { get => SdkMemory.Read<bool >(Pointer+11); set { SdkMemory.Write(Pointer+11,value); } }
    [NativeMember("m_bInvalidClimb")]
    public bool @InvalidClimb { get => SdkMemory.Read<bool >(Pointer+12); set { SdkMemory.Write(Pointer+12,value); } }
    [NativeMember("m_nHeightForAnim")]
    public sbyte @HeightForAnimation { get => SdkMemory.Read<sbyte >(Pointer+13); set { SdkMemory.Write(Pointer+13,value); } }
    [NativeMember("m_nHeightForPos")]
    public sbyte @HeightForPosition { get => SdkMemory.Read<sbyte >(Pointer+14); set { SdkMemory.Write(Pointer+14,value); } }
    [NativeMember("m_nSurfaceType")]
    public byte @SurfaceType { get => SdkMemory.Read<byte >(Pointer+15); set { SdkMemory.Write(Pointer+15,value); } }
    [NativeMember("m_nFallAfterVault")]
    public sbyte @FallAfterVault { get => SdkMemory.Read<sbyte >(Pointer+16); set { SdkMemory.Write(Pointer+16,value); } }
    [NativeMember("m_fHandholdHeading")]
    public float @HandholdHeading { get => SdkMemory.Read<float >(Pointer+20); set { SdkMemory.Write(Pointer+20,value); } }
    [NativeMember("m_vecHandholdPos")]
    public CVector @HandholdPosition { get => new CVector(Pointer+24); set { SdkMemory.Copy(value.Pointer,Pointer+24,12); } }
    [NativeMember("m_pClimbEnt")]
    public CEntity? @ClimbEnt { get => SdkMemory.Read<IntPtr>(Pointer+36) == IntPtr.Zero ? null : new CEntity(SdkMemory.Read<IntPtr>(Pointer+36)); set { SdkMemory.Write(Pointer+36,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_nGetToPosCounter")]
    public short @GetToPositionCounter { get => SdkMemory.Read<short >(Pointer+40); set { SdkMemory.Write(Pointer+40,value); } }
    [NativeMember("m_pAnim")]
    public CAnimBlendAssociation? @Animation { get => SdkMemory.Read<IntPtr>(Pointer+44) == IntPtr.Zero ? null : new CAnimBlendAssociation(SdkMemory.Read<IntPtr>(Pointer+44)); set { SdkMemory.Write(Pointer+44,value?.Pointer ?? IntPtr.Zero); } }
    public void @InitializeAt(CEntity? @pClimbEnt,CVector @vecTarget,float @fHeading,byte @nSurfaceType,eClimbHeights @nHeight,bool @bForceClimb) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1319 >(1319)(Pointer,@pClimbEnt?.Pointer ?? IntPtr.Zero,@vecTarget.Pointer,@fHeading,@nSurfaceType,(int)@nHeight,(@bForceClimb ? 1 : 0)); }
}
