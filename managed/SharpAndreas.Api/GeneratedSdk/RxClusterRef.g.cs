// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class RxClusterRef : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=12;
    public RxClusterRef(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("clusterDef")]
    public RxClusterDefinition? @ClusterDef { get => SdkMemory.Read<IntPtr>(Pointer+0) == IntPtr.Zero ? null : new RxClusterDefinition(SdkMemory.Read<IntPtr>(Pointer+0)); set { SdkMemory.Write(Pointer+0,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("forcePresent")]
    public RxClusterForcePresent @ForcePresent { get => SdkMemory.Read<RxClusterForcePresent >(Pointer+4); set { SdkMemory.Write(Pointer+4,value); } }
    [NativeMember("reserved")]
    public uint @Reserved { get => SdkMemory.Read<uint >(Pointer+8); set { SdkMemory.Write(Pointer+8,value); } }
}
