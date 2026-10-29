// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class RpMaterialChunkInfo : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=28;
    public RpMaterialChunkInfo(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("flags")]
    public int @Flags { get => SdkMemory.Read<int >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("color")]
    public RwRGBA @Color { get => new RwRGBA(Pointer+4); set { SdkMemory.Copy(value.Pointer,Pointer+4,4); } }
    [NativeMember("unused")]
    public int @Unused { get => SdkMemory.Read<int >(Pointer+8); set { SdkMemory.Write(Pointer+8,value); } }
    [NativeMember("textured")]
    public int @Textured { get => SdkMemory.Read<int >(Pointer+12); set { SdkMemory.Write(Pointer+12,value); } }
    [NativeMember("surfaceProps")]
    public RwSurfaceProperties @SurfaceProps { get => new RwSurfaceProperties(Pointer+16); set { SdkMemory.Copy(value.Pointer,Pointer+16,12); } }
}
