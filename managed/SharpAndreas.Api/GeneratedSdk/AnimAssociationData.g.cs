// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class AnimAssociationData : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=44;
    public AnimAssociationData(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_link")]
    public RwLLLink @Link { get => new RwLLLink(Pointer+0); set { SdkMemory.Copy(value.Pointer,Pointer+0,8); } }
    [NativeMember("m_nNumBlendNodes")]
    public ushort @CountBlendNodes { get => SdkMemory.Read<ushort >(Pointer+8); set { SdkMemory.Write(Pointer+8,value); } }
    [NativeMember("m_nAnimGroup")]
    public ushort @AnimationGroup { get => SdkMemory.Read<ushort >(Pointer+10); set { SdkMemory.Write(Pointer+10,value); } }
    [NativeMember("m_pNodeArray")]
    public CAnimBlendNode? @NodeArray { get => SdkMemory.Read<IntPtr>(Pointer+12) == IntPtr.Zero ? null : new CAnimBlendNode(SdkMemory.Read<IntPtr>(Pointer+12)); set { SdkMemory.Write(Pointer+12,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_pHierarchy")]
    public CAnimBlendHierarchy? @Hierarchy { get => SdkMemory.Read<IntPtr>(Pointer+16) == IntPtr.Zero ? null : new CAnimBlendHierarchy(SdkMemory.Read<IntPtr>(Pointer+16)); set { SdkMemory.Write(Pointer+16,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_fBlendAmount")]
    public float @BlendAmount { get => SdkMemory.Read<float >(Pointer+20); set { SdkMemory.Write(Pointer+20,value); } }
    [NativeMember("m_fBlendDelta")]
    public float @BlendDelta { get => SdkMemory.Read<float >(Pointer+24); set { SdkMemory.Write(Pointer+24,value); } }
    [NativeMember("m_fCurrentTime")]
    public float @CurrentTime { get => SdkMemory.Read<float >(Pointer+28); set { SdkMemory.Write(Pointer+28,value); } }
    [NativeMember("m_fSpeed")]
    public float @Speed { get => SdkMemory.Read<float >(Pointer+32); set { SdkMemory.Write(Pointer+32,value); } }
    [NativeMember("fTimeStep")]
    public float @TimeStep { get => SdkMemory.Read<float >(Pointer+36); set { SdkMemory.Write(Pointer+36,value); } }
    [NativeMember("m_nAnimId")]
    public short @AnimationId { get => SdkMemory.Read<short >(Pointer+40); set { SdkMemory.Write(Pointer+40,value); } }
    [NativeMember("m_nFlags")]
    public ushort @Flags { get => SdkMemory.Read<ushort >(Pointer+42); set { SdkMemory.Write(Pointer+42,value); } }
}
