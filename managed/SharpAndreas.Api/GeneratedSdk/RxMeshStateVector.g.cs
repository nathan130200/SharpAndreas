// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class RxMeshStateVector : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=188;
    public RxMeshStateVector(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("Flags")]
    public int @Flags { get => SdkMemory.Read<int >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("SourceObject")]
    public NativePointer<IntPtr> @SourceObject { get => new NativePointer<IntPtr>(SdkMemory.Read<IntPtr>(Pointer+4)); set { SdkMemory.Write(Pointer+4,value.Pointer); } }
    [NativeMember("Obj2World")]
    public RwMatrixTag @Obj2World { get => new RwMatrixTag(Pointer+8); set { SdkMemory.Copy(value.Pointer,Pointer+8,64); } }
    [NativeMember("Obj2Cam")]
    public RwMatrixTag @Obj2Cam { get => new RwMatrixTag(Pointer+72); set { SdkMemory.Copy(value.Pointer,Pointer+72,64); } }
    [NativeMember("SurfaceProperties")]
    public RwSurfaceProperties @SurfaceProperties { get => new RwSurfaceProperties(Pointer+136); set { SdkMemory.Copy(value.Pointer,Pointer+136,12); } }
    [NativeMember("Texture")]
    public RwTexture? @Texture { get => SdkMemory.Read<IntPtr>(Pointer+148) == IntPtr.Zero ? null : new RwTexture(SdkMemory.Read<IntPtr>(Pointer+148)); set { SdkMemory.Write(Pointer+148,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("MatCol")]
    public RwRGBA @MatCollision { get => new RwRGBA(Pointer+152); set { SdkMemory.Copy(value.Pointer,Pointer+152,4); } }
    [NativeMember("Pipeline")]
    public RxPipeline? @Pipeline { get => SdkMemory.Read<IntPtr>(Pointer+156) == IntPtr.Zero ? null : new RxPipeline(SdkMemory.Read<IntPtr>(Pointer+156)); set { SdkMemory.Write(Pointer+156,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("PrimType")]
    public RwPrimitiveType @PrimType { get => SdkMemory.Read<RwPrimitiveType >(Pointer+160); set { SdkMemory.Write(Pointer+160,value); } }
    [NativeMember("NumElements")]
    public uint @CountElements { get => SdkMemory.Read<uint >(Pointer+164); set { SdkMemory.Write(Pointer+164,value); } }
    [NativeMember("NumVertices")]
    public uint @CountVertices { get => SdkMemory.Read<uint >(Pointer+168); set { SdkMemory.Write(Pointer+168,value); } }
    [NativeMember("ClipFlagsOr")]
    public int @ClipFlagsOr { get => SdkMemory.Read<int >(Pointer+172); set { SdkMemory.Write(Pointer+172,value); } }
    [NativeMember("ClipFlagsAnd")]
    public int @ClipFlagsAnd { get => SdkMemory.Read<int >(Pointer+176); set { SdkMemory.Write(Pointer+176,value); } }
    [NativeMember("SourceMesh")]
    public NativePointer<IntPtr> @SourceMesh { get => new NativePointer<IntPtr>(SdkMemory.Read<IntPtr>(Pointer+180)); set { SdkMemory.Write(Pointer+180,value.Pointer); } }
    [NativeMember("DataObject")]
    public NativePointer<IntPtr> @DataObject { get => new NativePointer<IntPtr>(SdkMemory.Read<IntPtr>(Pointer+184)); set { SdkMemory.Write(Pointer+184,value.Pointer); } }
}
