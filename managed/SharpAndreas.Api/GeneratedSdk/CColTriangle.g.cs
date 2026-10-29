// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CColTriangle : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=8;
    public CColTriangle(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_nVertA")]
    public ushort @VertA { get => SdkMemory.Read<ushort >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("m_nVertB")]
    public ushort @VertB { get => SdkMemory.Read<ushort >(Pointer+2); set { SdkMemory.Write(Pointer+2,value); } }
    [NativeMember("m_nVertC")]
    public ushort @VertC { get => SdkMemory.Read<ushort >(Pointer+4); set { SdkMemory.Write(Pointer+4,value); } }
    [NativeMember("m_nMaterial")]
    public byte @Material { get => SdkMemory.Read<byte >(Pointer+6); set { SdkMemory.Write(Pointer+6,value); } }
    [NativeMember("m_nLight")]
    public byte @Light { get => SdkMemory.Read<byte >(Pointer+7); set { SdkMemory.Write(Pointer+7,value); } }
}
