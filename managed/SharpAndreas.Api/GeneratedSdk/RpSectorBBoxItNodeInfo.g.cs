// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class RpSectorBBoxItNodeInfo : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=4;
    public RpSectorBBoxItNodeInfo(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("sector")]
    public RpSector? @Sector { get => SdkMemory.Read<IntPtr>(Pointer+0) == IntPtr.Zero ? null : new RpSector(SdkMemory.Read<IntPtr>(Pointer+0)); set { SdkMemory.Write(Pointer+0,value?.Pointer ?? IntPtr.Zero); } }
}
