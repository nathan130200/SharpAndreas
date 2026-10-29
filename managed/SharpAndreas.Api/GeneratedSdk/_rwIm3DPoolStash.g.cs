// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class _rwIm3DPoolStash : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=48;
    public _rwIm3DPoolStash(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("flags")]
    public uint @Flags { get => SdkMemory.Read<uint >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("ltm")]
    public RwMatrixTag? @Ltm { get => SdkMemory.Read<IntPtr>(Pointer+4) == IntPtr.Zero ? null : new RwMatrixTag(SdkMemory.Read<IntPtr>(Pointer+4)); set { SdkMemory.Write(Pointer+4,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("numVerts")]
    public uint @CountVerts { get => SdkMemory.Read<uint >(Pointer+8); set { SdkMemory.Write(Pointer+8,value); } }
    [NativeMember("objVerts")]
    public RxObjSpace3DVertex? @ObjectVerts { get => SdkMemory.Read<IntPtr>(Pointer+12) == IntPtr.Zero ? null : new RxObjSpace3DVertex(SdkMemory.Read<IntPtr>(Pointer+12)); set { SdkMemory.Write(Pointer+12,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("camVerts")]
    public RxCamSpace3DVertex? @CamVerts { get => SdkMemory.Read<IntPtr>(Pointer+16) == IntPtr.Zero ? null : new RxCamSpace3DVertex(SdkMemory.Read<IntPtr>(Pointer+16)); set { SdkMemory.Write(Pointer+16,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("devVerts")]
    public RwD3D9Vertex? @DevVerts { get => SdkMemory.Read<IntPtr>(Pointer+20) == IntPtr.Zero ? null : new RwD3D9Vertex(SdkMemory.Read<IntPtr>(Pointer+20)); set { SdkMemory.Write(Pointer+20,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("meshState")]
    public RxMeshStateVector? @MeshState { get => SdkMemory.Read<IntPtr>(Pointer+24) == IntPtr.Zero ? null : new RxMeshStateVector(SdkMemory.Read<IntPtr>(Pointer+24)); set { SdkMemory.Write(Pointer+24,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("renderState")]
    public RxRenderStateVector? @RenderState { get => SdkMemory.Read<IntPtr>(Pointer+28) == IntPtr.Zero ? null : new RxRenderStateVector(SdkMemory.Read<IntPtr>(Pointer+28)); set { SdkMemory.Write(Pointer+28,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("pipeline")]
    public RxPipeline? @Pipeline { get => SdkMemory.Read<IntPtr>(Pointer+32) == IntPtr.Zero ? null : new RxPipeline(SdkMemory.Read<IntPtr>(Pointer+32)); set { SdkMemory.Write(Pointer+32,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("primType")]
    public RwPrimitiveType @PrimType { get => SdkMemory.Read<RwPrimitiveType >(Pointer+36); set { SdkMemory.Write(Pointer+36,value); } }
    [NativeMember("indices")]
    public NativePointer<ushort> @Indices { get => new NativePointer<ushort>(SdkMemory.Read<IntPtr>(Pointer+40)); set { SdkMemory.Write(Pointer+40,value.Pointer); } }
    [NativeMember("numIndices")]
    public uint @CountIndices { get => SdkMemory.Read<uint >(Pointer+44); set { SdkMemory.Write(Pointer+44,value); } }
}
