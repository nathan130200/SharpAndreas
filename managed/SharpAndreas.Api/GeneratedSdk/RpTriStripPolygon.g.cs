// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class RpTriStripPolygon : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=52;
    public RpTriStripPolygon(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("inEndLink")]
    public RwLLLink @InEndLink { get => new RwLLLink(Pointer+0); set { SdkMemory.Copy(value.Pointer,Pointer+0,8); } }
    [NativeMember("inUsedLink")]
    public RwLLLink @InUsedLink { get => new RwLLLink(Pointer+8); set { SdkMemory.Copy(value.Pointer,Pointer+8,8); } }
    [NativeMember("inFreeLink")]
    public RwLLLink @InFreeLink { get => new RwLLLink(Pointer+16); set { SdkMemory.Copy(value.Pointer,Pointer+16,8); } }
    [NativeMember("numEdges")]
    public uint @CountEdges { get => SdkMemory.Read<uint >(Pointer+24); set { SdkMemory.Write(Pointer+24,value); } }
    [NativeMember("edges")]
    public NativeArray<IntPtr> @Edges { get => new NativeArray<IntPtr>(Pointer+28,3); }
    [NativeMember("vertIndex")]
    public NativeArray<ushort> @VertIndex { get => new NativeArray<ushort>(Pointer+40,3); }
    [NativeMember("testFrame")]
    public uint @TestFrame { get => SdkMemory.Read<uint >(Pointer+48); set { SdkMemory.Write(Pointer+48,value); } }
}
