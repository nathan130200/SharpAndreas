// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CDirectory__DirectoryInfo : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=32;
    public CDirectory__DirectoryInfo(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_nOffset")]
    public uint @Offset { get => SdkMemory.Read<uint >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("m_nStreamingSize")]
    public ushort @StreamingSize { get => SdkMemory.Read<ushort >(Pointer+4); set { SdkMemory.Write(Pointer+4,value); } }
    [NativeMember("m_nSizeInArchive")]
    public ushort @SizeInArchive { get => SdkMemory.Read<ushort >(Pointer+6); set { SdkMemory.Write(Pointer+6,value); } }
    [NativeMember("m_szName")]
    public NativeArray<sbyte> @Name { get => new NativeArray<sbyte>(Pointer+8,24); }
}
