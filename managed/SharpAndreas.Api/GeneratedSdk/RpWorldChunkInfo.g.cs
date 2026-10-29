// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class RpWorldChunkInfo : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=64;
    public RpWorldChunkInfo(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("rootIsWorldSector")]
    public int @RootIsWorldSector { get => SdkMemory.Read<int >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("invWorldOrigin")]
    public RwV3d @InvWorldOrigin { get => new RwV3d(Pointer+4); set { SdkMemory.Copy(value.Pointer,Pointer+4,12); } }
    [NativeMember("numTriangles")]
    public int @CountTriangles { get => SdkMemory.Read<int >(Pointer+16); set { SdkMemory.Write(Pointer+16,value); } }
    [NativeMember("numVertices")]
    public int @CountVertices { get => SdkMemory.Read<int >(Pointer+20); set { SdkMemory.Write(Pointer+20,value); } }
    [NativeMember("numPlaneSectors")]
    public int @CountPlaneSectors { get => SdkMemory.Read<int >(Pointer+24); set { SdkMemory.Write(Pointer+24,value); } }
    [NativeMember("numWorldSectors")]
    public int @CountWorldSectors { get => SdkMemory.Read<int >(Pointer+28); set { SdkMemory.Write(Pointer+28,value); } }
    [NativeMember("colSectorSize")]
    public int @CollisionSectorSize { get => SdkMemory.Read<int >(Pointer+32); set { SdkMemory.Write(Pointer+32,value); } }
    [NativeMember("format")]
    public int @Format { get => SdkMemory.Read<int >(Pointer+36); set { SdkMemory.Write(Pointer+36,value); } }
    [NativeMember("boundingBox")]
    public RwBBox @BoundingBox { get => new RwBBox(Pointer+40); set { SdkMemory.Copy(value.Pointer,Pointer+40,24); } }
}
