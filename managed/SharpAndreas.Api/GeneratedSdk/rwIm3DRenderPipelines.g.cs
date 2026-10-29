// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class rwIm3DRenderPipelines : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=24;
    public rwIm3DRenderPipelines(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("triList")]
    public RxPipeline? @TriList { get => SdkMemory.Read<IntPtr>(Pointer+0) == IntPtr.Zero ? null : new RxPipeline(SdkMemory.Read<IntPtr>(Pointer+0)); set { SdkMemory.Write(Pointer+0,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("triFan")]
    public RxPipeline? @TriFan { get => SdkMemory.Read<IntPtr>(Pointer+4) == IntPtr.Zero ? null : new RxPipeline(SdkMemory.Read<IntPtr>(Pointer+4)); set { SdkMemory.Write(Pointer+4,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("triStrip")]
    public RxPipeline? @TriStrip { get => SdkMemory.Read<IntPtr>(Pointer+8) == IntPtr.Zero ? null : new RxPipeline(SdkMemory.Read<IntPtr>(Pointer+8)); set { SdkMemory.Write(Pointer+8,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("lineList")]
    public RxPipeline? @LineList { get => SdkMemory.Read<IntPtr>(Pointer+12) == IntPtr.Zero ? null : new RxPipeline(SdkMemory.Read<IntPtr>(Pointer+12)); set { SdkMemory.Write(Pointer+12,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("polyLine")]
    public RxPipeline? @PolyLine { get => SdkMemory.Read<IntPtr>(Pointer+16) == IntPtr.Zero ? null : new RxPipeline(SdkMemory.Read<IntPtr>(Pointer+16)); set { SdkMemory.Write(Pointer+16,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("pointList")]
    public RxPipeline? @PointList { get => SdkMemory.Read<IntPtr>(Pointer+20) == IntPtr.Zero ? null : new RxPipeline(SdkMemory.Read<IntPtr>(Pointer+20)); set { SdkMemory.Write(Pointer+20,value?.Pointer ?? IntPtr.Zero); } }
}
