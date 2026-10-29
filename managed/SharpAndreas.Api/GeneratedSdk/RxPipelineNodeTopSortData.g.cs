// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class RxPipelineNodeTopSortData : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=12;
    public RxPipelineNodeTopSortData(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("numIns")]
    public uint @CountIns { get => SdkMemory.Read<uint >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("numInsVisited")]
    public uint @CountInsVisited { get => SdkMemory.Read<uint >(Pointer+4); set { SdkMemory.Write(Pointer+4,value); } }
    [NativeMember("req")]
    public rxReq? @Req { get => SdkMemory.Read<IntPtr>(Pointer+8) == IntPtr.Zero ? null : new rxReq(SdkMemory.Read<IntPtr>(Pointer+8)); set { SdkMemory.Write(Pointer+8,value?.Pointer ?? IntPtr.Zero); } }
}
