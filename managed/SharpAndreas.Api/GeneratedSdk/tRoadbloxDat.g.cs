// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class tRoadbloxDat : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=4;
    public tRoadbloxDat(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("areaId")]
    public short @AreaId { get => SdkMemory.Read<short >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("nodeId")]
    public short @NodeId { get => SdkMemory.Read<short >(Pointer+2); set { SdkMemory.Write(Pointer+2,value); } }
}
