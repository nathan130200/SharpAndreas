// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class RpWorldSector : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=136;
    public RpWorldSector(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("type")]
    public int @Type { get => SdkMemory.Read<int >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("triangles")]
    public RpTriangle? @Triangles { get => SdkMemory.Read<IntPtr>(Pointer+4) == IntPtr.Zero ? null : new RpTriangle(SdkMemory.Read<IntPtr>(Pointer+4)); set { SdkMemory.Write(Pointer+4,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("vertices")]
    public RwV3d? @Vertices { get => SdkMemory.Read<IntPtr>(Pointer+8) == IntPtr.Zero ? null : new RwV3d(SdkMemory.Read<IntPtr>(Pointer+8)); set { SdkMemory.Write(Pointer+8,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("normals")]
    public RpVertexNormal? @Normals { get => SdkMemory.Read<IntPtr>(Pointer+12) == IntPtr.Zero ? null : new RpVertexNormal(SdkMemory.Read<IntPtr>(Pointer+12)); set { SdkMemory.Write(Pointer+12,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("texCoords")]
    public NativeArray<IntPtr> @TexCoordinates { get => new NativeArray<IntPtr>(Pointer+16,8); }
    [NativeMember("preLitLum")]
    public RwRGBA? @PreLitLum { get => SdkMemory.Read<IntPtr>(Pointer+48) == IntPtr.Zero ? null : new RwRGBA(SdkMemory.Read<IntPtr>(Pointer+48)); set { SdkMemory.Write(Pointer+48,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("repEntry")]
    public RwResEntry? @RepEntry { get => SdkMemory.Read<IntPtr>(Pointer+52) == IntPtr.Zero ? null : new RwResEntry(SdkMemory.Read<IntPtr>(Pointer+52)); set { SdkMemory.Write(Pointer+52,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("collAtomicsInWorldSector")]
    public RwLinkList @CollAtomicsInWorldSector { get => new RwLinkList(Pointer+56); set { SdkMemory.Copy(value.Pointer,Pointer+56,8); } }
    [NativeMember("lightsInWorldSector")]
    public RwLinkList @LightsInWorldSector { get => new RwLinkList(Pointer+64); set { SdkMemory.Copy(value.Pointer,Pointer+64,8); } }
    [NativeMember("boundingBox")]
    public RwBBox @BoundingBox { get => new RwBBox(Pointer+72); set { SdkMemory.Copy(value.Pointer,Pointer+72,24); } }
    [NativeMember("tightBoundingBox")]
    public RwBBox @TightBoundingBox { get => new RwBBox(Pointer+96); set { SdkMemory.Copy(value.Pointer,Pointer+96,24); } }
    [NativeMember("mesh")]
    public RpMeshHeader? @Mesh { get => SdkMemory.Read<IntPtr>(Pointer+120) == IntPtr.Zero ? null : new RpMeshHeader(SdkMemory.Read<IntPtr>(Pointer+120)); set { SdkMemory.Write(Pointer+120,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("pipeline")]
    public RxPipeline? @Pipeline { get => SdkMemory.Read<IntPtr>(Pointer+124) == IntPtr.Zero ? null : new RxPipeline(SdkMemory.Read<IntPtr>(Pointer+124)); set { SdkMemory.Write(Pointer+124,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("matListWindowBase")]
    public ushort @ListWindowBase { get => SdkMemory.Read<ushort >(Pointer+128); set { SdkMemory.Write(Pointer+128,value); } }
    [NativeMember("numVertices")]
    public ushort @CountVertices { get => SdkMemory.Read<ushort >(Pointer+130); set { SdkMemory.Write(Pointer+130,value); } }
    [NativeMember("numTriangles")]
    public ushort @CountTriangles { get => SdkMemory.Read<ushort >(Pointer+132); set { SdkMemory.Write(Pointer+132,value); } }
    [NativeMember("pad")]
    public ushort @Pad { get => SdkMemory.Read<ushort >(Pointer+134); set { SdkMemory.Write(Pointer+134,value); } }
}
