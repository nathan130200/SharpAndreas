// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class RpPlaneSector : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=24;
    public RpPlaneSector(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("type")]
    public int @Type { get => SdkMemory.Read<int >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("value")]
    public float @Value { get => SdkMemory.Read<float >(Pointer+4); set { SdkMemory.Write(Pointer+4,value); } }
    [NativeMember("leftSubTree")]
    public RpSector? @LeftSubTree { get => SdkMemory.Read<IntPtr>(Pointer+8) == IntPtr.Zero ? null : new RpSector(SdkMemory.Read<IntPtr>(Pointer+8)); set { SdkMemory.Write(Pointer+8,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("rightSubTree")]
    public RpSector? @RightSubTree { get => SdkMemory.Read<IntPtr>(Pointer+12) == IntPtr.Zero ? null : new RpSector(SdkMemory.Read<IntPtr>(Pointer+12)); set { SdkMemory.Write(Pointer+12,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("leftValue")]
    public float @LeftValue { get => SdkMemory.Read<float >(Pointer+16); set { SdkMemory.Write(Pointer+16,value); } }
    [NativeMember("rightValue")]
    public float @RightValue { get => SdkMemory.Read<float >(Pointer+20); set { SdkMemory.Write(Pointer+20,value); } }
}
