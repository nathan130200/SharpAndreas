// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class RxD3D9ResEntryHeader : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=64;
    public RxD3D9ResEntryHeader(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("serialNumber")]
    public uint @SerialNumber { get => SdkMemory.Read<uint >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("numMeshes")]
    public uint @CountMeshes { get => SdkMemory.Read<uint >(Pointer+4); set { SdkMemory.Write(Pointer+4,value); } }
    [NativeMember("indexBuffer")]
    public NativePointer<IntPtr> @IndexBuffer { get => new NativePointer<IntPtr>(SdkMemory.Read<IntPtr>(Pointer+8)); set { SdkMemory.Write(Pointer+8,value.Pointer); } }
    [NativeMember("primType")]
    public uint @PrimType { get => SdkMemory.Read<uint >(Pointer+12); set { SdkMemory.Write(Pointer+12,value); } }
    [NativeMember("vertexStream")]
    public NativeObjectArray<RxD3D9VertexStream> @VertexStream { get => new NativeObjectArray<RxD3D9VertexStream>(Pointer+16,2,16); }
    [NativeMember("useOffsets")]
    public int @UseOffsets { get => SdkMemory.Read<int >(Pointer+48); set { SdkMemory.Write(Pointer+48,value); } }
    [NativeMember("vertexDeclaration")]
    public NativePointer<IntPtr> @VertexDeclaration { get => new NativePointer<IntPtr>(SdkMemory.Read<IntPtr>(Pointer+52)); set { SdkMemory.Write(Pointer+52,value.Pointer); } }
    [NativeMember("totalNumIndex")]
    public uint @TotalCountIndex { get => SdkMemory.Read<uint >(Pointer+56); set { SdkMemory.Write(Pointer+56,value); } }
    [NativeMember("totalNumVertex")]
    public uint @TotalCountVertex { get => SdkMemory.Read<uint >(Pointer+60); set { SdkMemory.Write(Pointer+60,value); } }
}
