// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class tScanLists : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=20;
    public tScanLists(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("buildingsList")]
    public CPtrListDoubleLink? @BuildingsList { get => SdkMemory.Read<IntPtr>(Pointer+0) == IntPtr.Zero ? null : new CPtrListDoubleLink(SdkMemory.Read<IntPtr>(Pointer+0)); set { SdkMemory.Write(Pointer+0,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("objectsList")]
    public CPtrListDoubleLink? @ObjectsList { get => SdkMemory.Read<IntPtr>(Pointer+4) == IntPtr.Zero ? null : new CPtrListDoubleLink(SdkMemory.Read<IntPtr>(Pointer+4)); set { SdkMemory.Write(Pointer+4,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("vehiclesList")]
    public CPtrListDoubleLink? @VehiclesList { get => SdkMemory.Read<IntPtr>(Pointer+8) == IntPtr.Zero ? null : new CPtrListDoubleLink(SdkMemory.Read<IntPtr>(Pointer+8)); set { SdkMemory.Write(Pointer+8,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("pedsList")]
    public CPtrListDoubleLink? @PedsList { get => SdkMemory.Read<IntPtr>(Pointer+12) == IntPtr.Zero ? null : new CPtrListDoubleLink(SdkMemory.Read<IntPtr>(Pointer+12)); set { SdkMemory.Write(Pointer+12,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("dummiesList")]
    public CPtrListDoubleLink? @DummiesList { get => SdkMemory.Read<IntPtr>(Pointer+16) == IntPtr.Zero ? null : new CPtrListDoubleLink(SdkMemory.Read<IntPtr>(Pointer+16)); set { SdkMemory.Write(Pointer+16,value?.Pointer ?? IntPtr.Zero); } }
}
