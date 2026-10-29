// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class RxNodeMethods : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=28;
    public RxNodeMethods(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("nodeBody")]
    public NativeFunctionPointer<Callback_36f0d8f8a72a> @NodeBody { get => new NativeFunctionPointer<Callback_36f0d8f8a72a>(SdkMemory.Read<IntPtr>(Pointer+0)); set { SdkMemory.Write(Pointer+0,value.Pointer); } }
    [NativeMember("nodeInit")]
    public NativeFunctionPointer<Callback_3449784caa31> @NodeInit { get => new NativeFunctionPointer<Callback_3449784caa31>(SdkMemory.Read<IntPtr>(Pointer+4)); set { SdkMemory.Write(Pointer+4,value.Pointer); } }
    [NativeMember("nodeTerm")]
    public NativeFunctionPointer<Callback_49694d9477ad> @NodeTerm { get => new NativeFunctionPointer<Callback_49694d9477ad>(SdkMemory.Read<IntPtr>(Pointer+8)); set { SdkMemory.Write(Pointer+8,value.Pointer); } }
    [NativeMember("pipelineNodeInit")]
    public NativeFunctionPointer<Callback_8be0905b78f9> @PipelineNodeInit { get => new NativeFunctionPointer<Callback_8be0905b78f9>(SdkMemory.Read<IntPtr>(Pointer+12)); set { SdkMemory.Write(Pointer+12,value.Pointer); } }
    [NativeMember("pipelineNodeTerm")]
    public NativeFunctionPointer<Callback_864039c4e38c> @PipelineNodeTerm { get => new NativeFunctionPointer<Callback_864039c4e38c>(SdkMemory.Read<IntPtr>(Pointer+16)); set { SdkMemory.Write(Pointer+16,value.Pointer); } }
    [NativeMember("pipelineNodeConfig")]
    public NativeFunctionPointer<Callback_56dcbf51e276> @PipelineNodeConfig { get => new NativeFunctionPointer<Callback_56dcbf51e276>(SdkMemory.Read<IntPtr>(Pointer+20)); set { SdkMemory.Write(Pointer+20,value.Pointer); } }
    [NativeMember("configMsgHandler")]
    public NativeFunctionPointer<Callback_32412054a3ad> @ConfigMsgHandler { get => new NativeFunctionPointer<Callback_32412054a3ad>(SdkMemory.Read<IntPtr>(Pointer+24)); set { SdkMemory.Write(Pointer+24,value.Pointer); } }
}
