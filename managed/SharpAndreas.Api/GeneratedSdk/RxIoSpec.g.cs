// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class RxIoSpec : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=20;
    public RxIoSpec(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("numClustersOfInterest")]
    public uint @CountClustersOfInterest { get => SdkMemory.Read<uint >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("clustersOfInterest")]
    public RxClusterRef? @ClustersOfInterest { get => SdkMemory.Read<IntPtr>(Pointer+4) == IntPtr.Zero ? null : new RxClusterRef(SdkMemory.Read<IntPtr>(Pointer+4)); set { SdkMemory.Write(Pointer+4,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("inputRequirements")]
    public NativePointer<RxClusterValidityReq> @InputRequirements { get => new NativePointer<RxClusterValidityReq>(SdkMemory.Read<IntPtr>(Pointer+8)); set { SdkMemory.Write(Pointer+8,value.Pointer); } }
    [NativeMember("numOutputs")]
    public uint @CountOutputs { get => SdkMemory.Read<uint >(Pointer+12); set { SdkMemory.Write(Pointer+12,value); } }
    [NativeMember("outputs")]
    public RxOutputSpec? @Outputs { get => SdkMemory.Read<IntPtr>(Pointer+16) == IntPtr.Zero ? null : new RxOutputSpec(SdkMemory.Read<IntPtr>(Pointer+16)); set { SdkMemory.Write(Pointer+16,value?.Pointer ?? IntPtr.Zero); } }
}
