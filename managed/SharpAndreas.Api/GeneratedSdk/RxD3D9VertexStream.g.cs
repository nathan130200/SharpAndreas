// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class RxD3D9VertexStream : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=16;
    public RxD3D9VertexStream(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("vertexBuffer")]
    public NativePointer<IntPtr> @VertexBuffer { get => new NativePointer<IntPtr>(SdkMemory.Read<IntPtr>(Pointer+0)); set { SdkMemory.Write(Pointer+0,value.Pointer); } }
    [NativeMember("offset")]
    public uint @Offset { get => SdkMemory.Read<uint >(Pointer+4); set { SdkMemory.Write(Pointer+4,value); } }
    [NativeMember("stride")]
    public uint @Stride { get => SdkMemory.Read<uint >(Pointer+8); set { SdkMemory.Write(Pointer+8,value); } }
    [NativeMember("geometryFlags")]
    public ushort @GeometryFlags { get => SdkMemory.Read<ushort >(Pointer+12); set { SdkMemory.Write(Pointer+12,value); } }
    [NativeMember("managed")]
    public byte @Managed { get => SdkMemory.Read<byte >(Pointer+14); set { SdkMemory.Write(Pointer+14,value); } }
    [NativeMember("dynamicLock")]
    public byte @DynamicLock { get => SdkMemory.Read<byte >(Pointer+15); set { SdkMemory.Write(Pointer+15,value); } }
}
