// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class RpTriStripMesh : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=44;
    public RpTriStripMesh(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("numPolygons")]
    public uint @CountPolygons { get => SdkMemory.Read<uint >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("polygonEndList")]
    public RwLinkList @PolygonEndList { get => new RwLinkList(Pointer+4); set { SdkMemory.Copy(value.Pointer,Pointer+4,8); } }
    [NativeMember("polygonUsedList")]
    public RwLinkList @PolygonUsedList { get => new RwLinkList(Pointer+12); set { SdkMemory.Copy(value.Pointer,Pointer+12,8); } }
    [NativeMember("polygonFreeList")]
    public RwLinkList @PolygonFreeList { get => new RwLinkList(Pointer+20); set { SdkMemory.Copy(value.Pointer,Pointer+20,8); } }
    [NativeMember("edgeUsedList")]
    public RwLinkList @EdgeUsedList { get => new RwLinkList(Pointer+28); set { SdkMemory.Copy(value.Pointer,Pointer+28,8); } }
    [NativeMember("edgeFreeList")]
    public RwLinkList @EdgeFreeList { get => new RwLinkList(Pointer+36); set { SdkMemory.Copy(value.Pointer,Pointer+36,8); } }
}
