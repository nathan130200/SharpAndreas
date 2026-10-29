// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class IplDef : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=52;
    public IplDef(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_boundBox")]
    public CRect @BoundBox { get => new CRect(Pointer+0); set { SdkMemory.Copy(value.Pointer,Pointer+0,16); } }
    [NativeMember("m_szName")]
    public NativeArray<sbyte> @Name { get => new NativeArray<sbyte>(Pointer+16,16); }
    [NativeMember("m_nMinBuildingId")]
    public short @MinBuildingId { get => SdkMemory.Read<short >(Pointer+34); set { SdkMemory.Write(Pointer+34,value); } }
    [NativeMember("m_nMaxBuildingId")]
    public short @MaxBuildingId { get => SdkMemory.Read<short >(Pointer+36); set { SdkMemory.Write(Pointer+36,value); } }
    [NativeMember("m_nMinDummyId")]
    public short @MinDummyId { get => SdkMemory.Read<short >(Pointer+38); set { SdkMemory.Write(Pointer+38,value); } }
    [NativeMember("m_nMaxDummyId")]
    public short @MaxDummyId { get => SdkMemory.Read<short >(Pointer+40); set { SdkMemory.Write(Pointer+40,value); } }
    [NativeMember("m_nRelatedIpl")]
    public short @RelatedIpl { get => SdkMemory.Read<short >(Pointer+42); set { SdkMemory.Write(Pointer+42,value); } }
    [NativeMember("m_bInterior")]
    public bool @Interior { get => SdkMemory.Read<bool >(Pointer+44); set { SdkMemory.Write(Pointer+44,value); } }
    [NativeMember("field_2D")]
    public sbyte @Field2D { get => SdkMemory.Read<sbyte >(Pointer+45); set { SdkMemory.Write(Pointer+45,value); } }
    [NativeMember("m_bLoadRequest")]
    public bool @LoadRequest { get => SdkMemory.Read<bool >(Pointer+46); set { SdkMemory.Write(Pointer+46,value); } }
    [NativeMember("m_bDisableDynamicStreaming")]
    public bool @DisableDynamicStreaming { get => SdkMemory.Read<bool >(Pointer+47); set { SdkMemory.Write(Pointer+47,value); } }
    [NativeMember("field_30")]
    public sbyte @Field30 { get => SdkMemory.Read<sbyte >(Pointer+48); set { SdkMemory.Write(Pointer+48,value); } }
    [NativeMember("field_31")]
    public sbyte @Field31 { get => SdkMemory.Read<sbyte >(Pointer+49); set { SdkMemory.Write(Pointer+49,value); } }
}
