// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class RpTriStripEdge : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=32;
    public RpTriStripEdge(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("inUsedLink")]
    public RwLLLink @InUsedLink { get => new RwLLLink(Pointer+0); set { SdkMemory.Copy(value.Pointer,Pointer+0,8); } }
    [NativeMember("inFreeLink")]
    public RwLLLink @InFreeLink { get => new RwLLLink(Pointer+8); set { SdkMemory.Copy(value.Pointer,Pointer+8,8); } }
    [NativeMember("poly1")]
    public RpTriStripPolygon? @Poly1 { get => SdkMemory.Read<IntPtr>(Pointer+16) == IntPtr.Zero ? null : new RpTriStripPolygon(SdkMemory.Read<IntPtr>(Pointer+16)); set { SdkMemory.Write(Pointer+16,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("poly2")]
    public RpTriStripPolygon? @Poly2 { get => SdkMemory.Read<IntPtr>(Pointer+20) == IntPtr.Zero ? null : new RpTriStripPolygon(SdkMemory.Read<IntPtr>(Pointer+20)); set { SdkMemory.Write(Pointer+20,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("vert1")]
    public ushort @Vert1 { get => SdkMemory.Read<ushort >(Pointer+24); set { SdkMemory.Write(Pointer+24,value); } }
    [NativeMember("vert2")]
    public ushort @Vert2 { get => SdkMemory.Read<ushort >(Pointer+26); set { SdkMemory.Write(Pointer+26,value); } }
    [NativeMember("strip")]
    public int @Strip { get => SdkMemory.Read<int >(Pointer+28); set { SdkMemory.Write(Pointer+28,value); } }
}
