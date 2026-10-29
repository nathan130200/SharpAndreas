// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class RxPipelineRequiresCluster : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=12;
    public RxPipelineRequiresCluster(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("clusterDef")]
    public RxClusterDefinition? @ClusterDef { get => SdkMemory.Read<IntPtr>(Pointer+0) == IntPtr.Zero ? null : new RxClusterDefinition(SdkMemory.Read<IntPtr>(Pointer+0)); set { SdkMemory.Write(Pointer+0,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("rqdOrOpt")]
    public RxClusterValidityReq @RqdOrOpt { get => SdkMemory.Read<RxClusterValidityReq >(Pointer+4); set { SdkMemory.Write(Pointer+4,value); } }
    [NativeMember("slotIndex")]
    public uint @SlotIndex { get => SdkMemory.Read<uint >(Pointer+8); set { SdkMemory.Write(Pointer+8,value); } }
}
