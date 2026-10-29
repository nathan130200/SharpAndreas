// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class RxPipelineNode : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=40;
    public RxPipelineNode(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("nodeDef")]
    public RxNodeDefinition? @NodeDef { get => SdkMemory.Read<IntPtr>(Pointer+0) == IntPtr.Zero ? null : new RxNodeDefinition(SdkMemory.Read<IntPtr>(Pointer+0)); set { SdkMemory.Write(Pointer+0,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("numOutputs")]
    public uint @CountOutputs { get => SdkMemory.Read<uint >(Pointer+4); set { SdkMemory.Write(Pointer+4,value); } }
    [NativeMember("outputs")]
    public NativePointer<uint> @Outputs { get => new NativePointer<uint>(SdkMemory.Read<IntPtr>(Pointer+8)); set { SdkMemory.Write(Pointer+8,value.Pointer); } }
    [NativeMember("slotClusterRefs")]
    public NativePointer<IntPtr> @SlotClusterRefs { get => new NativePointer<IntPtr>(SdkMemory.Read<IntPtr>(Pointer+12)); set { SdkMemory.Write(Pointer+12,value.Pointer); } }
    [NativeMember("slotsContinue")]
    public NativePointer<uint> @SlotsContinue { get => new NativePointer<uint>(SdkMemory.Read<IntPtr>(Pointer+16)); set { SdkMemory.Write(Pointer+16,value.Pointer); } }
    [NativeMember("privateData")]
    public NativePointer<IntPtr> @PrivateData { get => new NativePointer<IntPtr>(SdkMemory.Read<IntPtr>(Pointer+20)); set { SdkMemory.Write(Pointer+20,value.Pointer); } }
    [NativeMember("inputToClusterSlot")]
    public NativePointer<uint> @InputToClusterSlot { get => new NativePointer<uint>(SdkMemory.Read<IntPtr>(Pointer+24)); set { SdkMemory.Write(Pointer+24,value.Pointer); } }
    [NativeMember("topSortData")]
    public RxPipelineNodeTopSortData? @TopSortData { get => SdkMemory.Read<IntPtr>(Pointer+28) == IntPtr.Zero ? null : new RxPipelineNodeTopSortData(SdkMemory.Read<IntPtr>(Pointer+28)); set { SdkMemory.Write(Pointer+28,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("initializationData")]
    public NativePointer<IntPtr> @InitializationData { get => new NativePointer<IntPtr>(SdkMemory.Read<IntPtr>(Pointer+32)); set { SdkMemory.Write(Pointer+32,value.Pointer); } }
    [NativeMember("initializationDataSize")]
    public uint @InitializationDataSize { get => SdkMemory.Read<uint >(Pointer+36); set { SdkMemory.Write(Pointer+36,value); } }
}
