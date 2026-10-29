// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class RxPipelineNodeParam : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=8;
    public RxPipelineNodeParam(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("dataParam")]
    public NativePointer<IntPtr> @DataParam { get => new NativePointer<IntPtr>(SdkMemory.Read<IntPtr>(Pointer+0)); set { SdkMemory.Write(Pointer+0,value.Pointer); } }
    [NativeMember("heap")]
    public RxHeap? @Heap { get => SdkMemory.Read<IntPtr>(Pointer+4) == IntPtr.Zero ? null : new RxHeap(SdkMemory.Read<IntPtr>(Pointer+4)); set { SdkMemory.Write(Pointer+4,value?.Pointer ?? IntPtr.Zero); } }
}
