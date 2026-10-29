// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class RpSectorLineIt : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=820;
    public RpSectorLineIt(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("start")]
    public RwV3d @Start { get => new RwV3d(Pointer+0); set { SdkMemory.Copy(value.Pointer,Pointer+0,12); } }
    [NativeMember("delta")]
    public RwV3d @Delta { get => new RwV3d(Pointer+12); set { SdkMemory.Copy(value.Pointer,Pointer+12,12); } }
    [NativeMember("recip")]
    public RwV3d @Recip { get => new RwV3d(Pointer+24); set { SdkMemory.Copy(value.Pointer,Pointer+24,12); } }
    [NativeMember("stack")]
    public NativeObjectArray<RpSectorLineItNodeInfo> @Stack { get => new NativeObjectArray<RpSectorLineItNodeInfo>(Pointer+36,65,12); }
    [NativeMember("curr")]
    public RpSectorLineItNodeInfo? @Curr { get => SdkMemory.Read<IntPtr>(Pointer+816) == IntPtr.Zero ? null : new RpSectorLineItNodeInfo(SdkMemory.Read<IntPtr>(Pointer+816)); set { SdkMemory.Write(Pointer+816,value?.Pointer ?? IntPtr.Zero); } }
}
