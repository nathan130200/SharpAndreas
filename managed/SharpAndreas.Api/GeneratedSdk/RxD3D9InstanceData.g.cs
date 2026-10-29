// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class RxD3D9InstanceData : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=36;
    public RxD3D9InstanceData(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("numIndex")]
    public uint @CountIndex { get => SdkMemory.Read<uint >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("minVert")]
    public uint @MinVert { get => SdkMemory.Read<uint >(Pointer+4); set { SdkMemory.Write(Pointer+4,value); } }
    [NativeMember("material")]
    public RpMaterial? @Material { get => SdkMemory.Read<IntPtr>(Pointer+8) == IntPtr.Zero ? null : new RpMaterial(SdkMemory.Read<IntPtr>(Pointer+8)); set { SdkMemory.Write(Pointer+8,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("vertexAlpha")]
    public int @VertexAlpha { get => SdkMemory.Read<int >(Pointer+12); set { SdkMemory.Write(Pointer+12,value); } }
    [NativeMember("vertexShader")]
    public NativePointer<IntPtr> @VertexShader { get => new NativePointer<IntPtr>(SdkMemory.Read<IntPtr>(Pointer+16)); set { SdkMemory.Write(Pointer+16,value.Pointer); } }
    [NativeMember("baseIndex")]
    public uint @BaseIndex { get => SdkMemory.Read<uint >(Pointer+20); set { SdkMemory.Write(Pointer+20,value); } }
    [NativeMember("numVertices")]
    public uint @CountVertices { get => SdkMemory.Read<uint >(Pointer+24); set { SdkMemory.Write(Pointer+24,value); } }
    [NativeMember("startIndex")]
    public uint @StartIndex { get => SdkMemory.Read<uint >(Pointer+28); set { SdkMemory.Write(Pointer+28,value); } }
    [NativeMember("numPrimitives")]
    public uint @CountPrimitives { get => SdkMemory.Read<uint >(Pointer+32); set { SdkMemory.Write(Pointer+32,value); } }
}
