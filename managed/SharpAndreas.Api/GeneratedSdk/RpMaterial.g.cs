// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class RpMaterial : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=28;
    public RpMaterial(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("texture")]
    public RwTexture? @Texture { get => SdkMemory.Read<IntPtr>(Pointer+0) == IntPtr.Zero ? null : new RwTexture(SdkMemory.Read<IntPtr>(Pointer+0)); set { SdkMemory.Write(Pointer+0,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("color")]
    public RwRGBA @Color { get => new RwRGBA(Pointer+4); set { SdkMemory.Copy(value.Pointer,Pointer+4,4); } }
    [NativeMember("pipeline")]
    public RxPipeline? @Pipeline { get => SdkMemory.Read<IntPtr>(Pointer+8) == IntPtr.Zero ? null : new RxPipeline(SdkMemory.Read<IntPtr>(Pointer+8)); set { SdkMemory.Write(Pointer+8,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("surfaceProps")]
    public RwSurfaceProperties @SurfaceProps { get => new RwSurfaceProperties(Pointer+12); set { SdkMemory.Copy(value.Pointer,Pointer+12,12); } }
    [NativeMember("refCount")]
    public short @RefCount { get => SdkMemory.Read<short >(Pointer+24); set { SdkMemory.Write(Pointer+24,value); } }
    [NativeMember("pad")]
    public short @Pad { get => SdkMemory.Read<short >(Pointer+26); set { SdkMemory.Write(Pointer+26,value); } }
}
