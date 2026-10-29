// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class RpCollSectorLineItNodeInfo : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=12;
    public RpCollSectorLineItNodeInfo(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("sector")]
    public RpCollSector? @Sector { get => SdkMemory.Read<IntPtr>(Pointer+0) == IntPtr.Zero ? null : new RpCollSector(SdkMemory.Read<IntPtr>(Pointer+0)); set { SdkMemory.Write(Pointer+0,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("pa")]
    public float @Pa { get => SdkMemory.Read<float >(Pointer+4); set { SdkMemory.Write(Pointer+4,value); } }
    [NativeMember("pb")]
    public float @Pb { get => SdkMemory.Read<float >(Pointer+8); set { SdkMemory.Write(Pointer+8,value); } }
}
