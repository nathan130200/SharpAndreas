// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CTaskSimpleHoldEntity : CTaskSimple
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=60;
    public CTaskSimpleHoldEntity(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_pEntityToHold")]
    public CEntity? @EntityToHold { get => SdkMemory.Read<IntPtr>(Pointer+8) == IntPtr.Zero ? null : new CEntity(SdkMemory.Read<IntPtr>(Pointer+8)); set { SdkMemory.Write(Pointer+8,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_vecPosition")]
    public CVector @Position { get => new CVector(Pointer+12); set { SdkMemory.Copy(value.Pointer,Pointer+12,12); } }
    [NativeMember("m_nBoneFrameId")]
    public byte @BoneFrameId { get => SdkMemory.Read<byte >(Pointer+24); set { SdkMemory.Write(Pointer+24,value); } }
    [NativeMember("m_bBoneFlags")]
    public byte @BoneFlags { get => SdkMemory.Read<byte >(Pointer+25); set { SdkMemory.Write(Pointer+25,value); } }
    [NativeMember("field_1A")]
    public NativeArray<bool> @Field1A { get => new NativeArray<bool>(Pointer+26,2); }
    [NativeMember("m_fRotation")]
    public float @Rotation { get => SdkMemory.Read<float >(Pointer+28); set { SdkMemory.Write(Pointer+28,value); } }
    [NativeMember("m_nAnimId")]
    public int @AnimationId { get => SdkMemory.Read<int >(Pointer+32); set { SdkMemory.Write(Pointer+32,value); } }
    [NativeMember("m_nAnimGroupId")]
    public eAnimGroup @AnimationGroupId { get => SdkMemory.Read<eAnimGroup >(Pointer+36); set { SdkMemory.Write(Pointer+36,value); } }
    [NativeMember("m_animFlags")]
    public int @AnimationFlags { get => SdkMemory.Read<int >(Pointer+40); set { SdkMemory.Write(Pointer+40,value); } }
    [NativeMember("m_pAnimBlock")]
    public CAnimBlock? @AnimationBlock { get => SdkMemory.Read<IntPtr>(Pointer+44) == IntPtr.Zero ? null : new CAnimBlock(SdkMemory.Read<IntPtr>(Pointer+44)); set { SdkMemory.Write(Pointer+44,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_pAnimBlendHierarchy")]
    public CAnimBlendHierarchy? @AnimationBlendHierarchy { get => SdkMemory.Read<IntPtr>(Pointer+48) == IntPtr.Zero ? null : new CAnimBlendHierarchy(SdkMemory.Read<IntPtr>(Pointer+48)); set { SdkMemory.Write(Pointer+48,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_bEntityDropped")]
    public bool @EntityDropped { get => SdkMemory.Read<bool >(Pointer+52); set { SdkMemory.Write(Pointer+52,value); } }
    [NativeMember("m_bEntityRequiresProcessing")]
    public bool @EntityRequiresProcessing { get => SdkMemory.Read<bool >(Pointer+53); set { SdkMemory.Write(Pointer+53,value); } }
    [NativeMember("m_bDisallowDroppingOnAnimEnd")]
    public bool @DisallowDroppingOnAnimationEnd { get => SdkMemory.Read<bool >(Pointer+54); set { SdkMemory.Write(Pointer+54,value); } }
    [NativeMember("field_37")]
    public bool @Field37 { get => SdkMemory.Read<bool >(Pointer+55); set { SdkMemory.Write(Pointer+55,value); } }
    [NativeMember("m_pAnimBlendAssociation")]
    public CAnimBlendAssociation? @AnimationBlendAssociation { get => SdkMemory.Read<IntPtr>(Pointer+56) == IntPtr.Zero ? null : new CAnimBlendAssociation(SdkMemory.Read<IntPtr>(Pointer+56)); set { SdkMemory.Write(Pointer+56,value?.Pointer ?? IntPtr.Zero); } }
}
