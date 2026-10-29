// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CTaskSimpleJump : CTaskSimple
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=44;
    public CTaskSimpleJump(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_vecPosn")]
    public CVector @Position { get => new CVector(Pointer+8); set { SdkMemory.Copy(value.Pointer,Pointer+8,12); } }
    [NativeMember("m_fAngle")]
    public float @Angle { get => SdkMemory.Read<float >(Pointer+20); set { SdkMemory.Write(Pointer+20,value); } }
    [NativeMember("m_nSurfaceType")]
    public byte @SurfaceType { get => SdkMemory.Read<byte >(Pointer+24); set { SdkMemory.Write(Pointer+24,value); } }
    [NativeMember("m_pEntity")]
    public CEntity? @Entity { get => SdkMemory.Read<IntPtr>(Pointer+28) == IntPtr.Zero ? null : new CEntity(SdkMemory.Read<IntPtr>(Pointer+28)); set { SdkMemory.Write(Pointer+28,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_bIsFinished")]
    public bool @IsFinished { get => SdkMemory.Read<bool >(Pointer+32); set { SdkMemory.Write(Pointer+32,value); } }
    [NativeMember("bHitHisHead")]
    public bool @HitHisHead { get => SdkMemory.Read<bool >(Pointer+33); set { SdkMemory.Write(Pointer+33,value); } }
    [NativeMember("m_bIsBlockedByEntity")]
    public bool @IsBlockedByEntity { get => SdkMemory.Read<bool >(Pointer+34); set { SdkMemory.Write(Pointer+34,value); } }
    [NativeMember("m_bStartedLaunchAnim")]
    public bool @StartedLaunchAnimation { get => SdkMemory.Read<bool >(Pointer+35); set { SdkMemory.Write(Pointer+35,value); } }
    [NativeMember("m_bIsClimb")]
    public bool @IsClimb { get => SdkMemory.Read<bool >(Pointer+36); set { SdkMemory.Write(Pointer+36,value); } }
    [NativeMember("m_bIsInPlayersGroup")]
    public bool @IsInPlayersGroup { get => SdkMemory.Read<bool >(Pointer+37); set { SdkMemory.Write(Pointer+37,value); } }
    [NativeMember("m_pAnimBlendAssoc")]
    public CAnimBlendAssociation? @AnimationBlendAssoc { get => SdkMemory.Read<IntPtr>(Pointer+40) == IntPtr.Zero ? null : new CAnimBlendAssociation(SdkMemory.Read<IntPtr>(Pointer+40)); set { SdkMemory.Write(Pointer+40,value?.Pointer ?? IntPtr.Zero); } }
    public void @InitializeAt(bool @bIsClimb) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4048 >(4048)(Pointer,(@bIsClimb ? 1 : 0)); }
}
