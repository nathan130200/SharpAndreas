// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class rwImmediGlobals : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=116;
    public rwImmediGlobals(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("im3DTransformPipeline")]
    public RxPipeline? @Im3DTransformPipeline { get => SdkMemory.Read<IntPtr>(Pointer+0) == IntPtr.Zero ? null : new RxPipeline(SdkMemory.Read<IntPtr>(Pointer+0)); set { SdkMemory.Write(Pointer+0,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("im3DRenderPipelines")]
    public rwIm3DRenderPipelines @Im3DRenderPipelines { get => new rwIm3DRenderPipelines(Pointer+4); set { SdkMemory.Copy(value.Pointer,Pointer+4,24); } }
    [NativeMember("platformIm3DTransformPipeline")]
    public RxPipeline? @PlatformIm3DTransformPipeline { get => SdkMemory.Read<IntPtr>(Pointer+28) == IntPtr.Zero ? null : new RxPipeline(SdkMemory.Read<IntPtr>(Pointer+28)); set { SdkMemory.Write(Pointer+28,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("platformIm3DRenderPipelines")]
    public rwIm3DRenderPipelines @PlatformIm3DRenderPipelines { get => new rwIm3DRenderPipelines(Pointer+32); set { SdkMemory.Copy(value.Pointer,Pointer+32,24); } }
    [NativeMember("curPool")]
    public rwIm3DPool @CurPool { get => new rwIm3DPool(Pointer+56); set { SdkMemory.Copy(value.Pointer,Pointer+56,60); } }
}
