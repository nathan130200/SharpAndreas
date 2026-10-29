// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class RxExecutionContext : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=24;
    public RxExecutionContext(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("pipeline")]
    public RxPipeline? @Pipeline { get => SdkMemory.Read<IntPtr>(Pointer+0) == IntPtr.Zero ? null : new RxPipeline(SdkMemory.Read<IntPtr>(Pointer+0)); set { SdkMemory.Write(Pointer+0,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("currentNode")]
    public RxPipelineNode? @CurrentNode { get => SdkMemory.Read<IntPtr>(Pointer+4) == IntPtr.Zero ? null : new RxPipelineNode(SdkMemory.Read<IntPtr>(Pointer+4)); set { SdkMemory.Write(Pointer+4,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("exitCode")]
    public int @ExitCode { get => SdkMemory.Read<int >(Pointer+8); set { SdkMemory.Write(Pointer+8,value); } }
    [NativeMember("pad")]
    public uint @Pad { get => SdkMemory.Read<uint >(Pointer+12); set { SdkMemory.Write(Pointer+12,value); } }
    [NativeMember("params")]
    public RxPipelineNodeParam @Params { get => new RxPipelineNodeParam(Pointer+16); set { SdkMemory.Copy(value.Pointer,Pointer+16,8); } }
}
