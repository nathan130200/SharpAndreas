// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class RxNodeDefinition : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=64;
    public RxNodeDefinition(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("name")]
    public NativePointer<sbyte> @Name { get => new NativePointer<sbyte>(SdkMemory.Read<IntPtr>(Pointer+0)); set { SdkMemory.Write(Pointer+0,value.Pointer); } }
    [NativeMember("nodeMethods")]
    public RxNodeMethods @NodeMethods { get => new RxNodeMethods(Pointer+4); set { SdkMemory.Copy(value.Pointer,Pointer+4,28); } }
    [NativeMember("io")]
    public RxIoSpec @Io { get => new RxIoSpec(Pointer+32); set { SdkMemory.Copy(value.Pointer,Pointer+32,20); } }
    [NativeMember("pipelineNodePrivateDataSize")]
    public uint @PipelineNodePrivateDataSize { get => SdkMemory.Read<uint >(Pointer+52); set { SdkMemory.Write(Pointer+52,value); } }
    [NativeMember("editable")]
    public RxNodeDefEditable @Editable { get => SdkMemory.Read<RxNodeDefEditable >(Pointer+56); set { SdkMemory.Write(Pointer+56,value); } }
    [NativeMember("InputPipesCnt")]
    public int @InputPipesCnt { get => SdkMemory.Read<int >(Pointer+60); set { SdkMemory.Write(Pointer+60,value); } }
}
