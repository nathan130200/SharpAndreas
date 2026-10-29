// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class RxPipelineCluster : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=8;
    public RxPipelineCluster(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("clusterRef")]
    public RxClusterDefinition? @ClusterRef { get => SdkMemory.Read<IntPtr>(Pointer+0) == IntPtr.Zero ? null : new RxClusterDefinition(SdkMemory.Read<IntPtr>(Pointer+0)); set { SdkMemory.Write(Pointer+0,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("creationAttributes")]
    public uint @CreationAttributes { get => SdkMemory.Read<uint >(Pointer+4); set { SdkMemory.Write(Pointer+4,value); } }
}
