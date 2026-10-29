// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class RxOutputSpec : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=12;
    public RxOutputSpec(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("name")]
    public NativePointer<sbyte> @Name { get => new NativePointer<sbyte>(SdkMemory.Read<IntPtr>(Pointer+0)); set { SdkMemory.Write(Pointer+0,value.Pointer); } }
    [NativeMember("outputClusters")]
    public NativePointer<RxClusterValid> @OutputClusters { get => new NativePointer<RxClusterValid>(SdkMemory.Read<IntPtr>(Pointer+4)); set { SdkMemory.Write(Pointer+4,value.Pointer); } }
    [NativeMember("allOtherClusters")]
    public RxClusterValid @AllOtherClusters { get => SdkMemory.Read<RxClusterValid >(Pointer+8); set { SdkMemory.Write(Pointer+8,value); } }
}
