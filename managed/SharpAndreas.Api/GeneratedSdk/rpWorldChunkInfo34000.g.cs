// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class rpWorldChunkInfo34000 : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=52;
    public rpWorldChunkInfo34000(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("rootIsWorldSector")]
    public int @RootIsWorldSector { get => SdkMemory.Read<int >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("invWorldOrigin")]
    public RwV3d @InvWorldOrigin { get => new RwV3d(Pointer+4); set { SdkMemory.Copy(value.Pointer,Pointer+4,12); } }
    [NativeMember("surfaceProps")]
    public RwSurfaceProperties @SurfaceProps { get => new RwSurfaceProperties(Pointer+16); set { SdkMemory.Copy(value.Pointer,Pointer+16,12); } }
    [NativeMember("numTriangles")]
    public int @CountTriangles { get => SdkMemory.Read<int >(Pointer+28); set { SdkMemory.Write(Pointer+28,value); } }
    [NativeMember("numVertices")]
    public int @CountVertices { get => SdkMemory.Read<int >(Pointer+32); set { SdkMemory.Write(Pointer+32,value); } }
    [NativeMember("numPlaneSectors")]
    public int @CountPlaneSectors { get => SdkMemory.Read<int >(Pointer+36); set { SdkMemory.Write(Pointer+36,value); } }
    [NativeMember("numWorldSectors")]
    public int @CountWorldSectors { get => SdkMemory.Read<int >(Pointer+40); set { SdkMemory.Write(Pointer+40,value); } }
    [NativeMember("colSectorSize")]
    public int @CollisionSectorSize { get => SdkMemory.Read<int >(Pointer+44); set { SdkMemory.Write(Pointer+44,value); } }
    [NativeMember("format")]
    public int @Format { get => SdkMemory.Read<int >(Pointer+48); set { SdkMemory.Write(Pointer+48,value); } }
}
