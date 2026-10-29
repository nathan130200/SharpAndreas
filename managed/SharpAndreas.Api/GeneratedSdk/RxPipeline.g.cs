// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class RxPipeline : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=52;
    public RxPipeline(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("locked")]
    public int @Locked { get => SdkMemory.Read<int >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("numNodes")]
    public uint @CountNodes { get => SdkMemory.Read<uint >(Pointer+4); set { SdkMemory.Write(Pointer+4,value); } }
    [NativeMember("nodes")]
    public RxPipelineNode? @Nodes { get => SdkMemory.Read<IntPtr>(Pointer+8) == IntPtr.Zero ? null : new RxPipelineNode(SdkMemory.Read<IntPtr>(Pointer+8)); set { SdkMemory.Write(Pointer+8,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("packetNumClusterSlots")]
    public uint @PacketCountClusterSlots { get => SdkMemory.Read<uint >(Pointer+12); set { SdkMemory.Write(Pointer+12,value); } }
    [NativeMember("embeddedPacketState")]
    public rxEmbeddedPacketState @EmbeddedPacketState { get => SdkMemory.Read<rxEmbeddedPacketState >(Pointer+16); set { SdkMemory.Write(Pointer+16,value); } }
    [NativeMember("embeddedPacket")]
    public RxPacket? @EmbeddedPacket { get => SdkMemory.Read<IntPtr>(Pointer+20) == IntPtr.Zero ? null : new RxPacket(SdkMemory.Read<IntPtr>(Pointer+20)); set { SdkMemory.Write(Pointer+20,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("numInputRequirements")]
    public uint @CountInputRequirements { get => SdkMemory.Read<uint >(Pointer+24); set { SdkMemory.Write(Pointer+24,value); } }
    [NativeMember("inputRequirements")]
    public RxPipelineRequiresCluster? @InputRequirements { get => SdkMemory.Read<IntPtr>(Pointer+28) == IntPtr.Zero ? null : new RxPipelineRequiresCluster(SdkMemory.Read<IntPtr>(Pointer+28)); set { SdkMemory.Write(Pointer+28,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("superBlock")]
    public NativePointer<IntPtr> @SuperBlock { get => new NativePointer<IntPtr>(SdkMemory.Read<IntPtr>(Pointer+32)); set { SdkMemory.Write(Pointer+32,value.Pointer); } }
    [NativeMember("superBlockSize")]
    public uint @SuperBlockSize { get => SdkMemory.Read<uint >(Pointer+36); set { SdkMemory.Write(Pointer+36,value); } }
    [NativeMember("entryPoint")]
    public uint @EntryPoint { get => SdkMemory.Read<uint >(Pointer+40); set { SdkMemory.Write(Pointer+40,value); } }
    [NativeMember("pluginId")]
    public uint @PluginId { get => SdkMemory.Read<uint >(Pointer+44); set { SdkMemory.Write(Pointer+44,value); } }
    [NativeMember("pluginData")]
    public uint @PluginData { get => SdkMemory.Read<uint >(Pointer+48); set { SdkMemory.Write(Pointer+48,value); } }
}
