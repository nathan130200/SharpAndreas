// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class RpCollSectorLineIt : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=448;
    public RpCollSectorLineIt(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("tree")]
    public RpCollTree? @Tree { get => SdkMemory.Read<IntPtr>(Pointer+0) == IntPtr.Zero ? null : new RpCollTree(SdkMemory.Read<IntPtr>(Pointer+0)); set { SdkMemory.Write(Pointer+0,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("start")]
    public RwV3d @Start { get => new RwV3d(Pointer+4); set { SdkMemory.Copy(value.Pointer,Pointer+4,12); } }
    [NativeMember("delta")]
    public RwV3d @Delta { get => new RwV3d(Pointer+16); set { SdkMemory.Copy(value.Pointer,Pointer+16,12); } }
    [NativeMember("recip")]
    public RwV3d @Recip { get => new RwV3d(Pointer+28); set { SdkMemory.Copy(value.Pointer,Pointer+28,12); } }
    [NativeMember("dummy")]
    public RpCollSector @Dummy { get => new RpCollSector(Pointer+40); set { SdkMemory.Copy(value.Pointer,Pointer+40,8); } }
    [NativeMember("stack")]
    public NativeObjectArray<RpCollSectorLineItNodeInfo> @Stack { get => new NativeObjectArray<RpCollSectorLineItNodeInfo>(Pointer+48,33,12); }
    [NativeMember("curr")]
    public RpCollSectorLineItNodeInfo? @Curr { get => SdkMemory.Read<IntPtr>(Pointer+444) == IntPtr.Zero ? null : new RpCollSectorLineItNodeInfo(SdkMemory.Read<IntPtr>(Pointer+444)); set { SdkMemory.Write(Pointer+444,value?.Pointer ?? IntPtr.Zero); } }
}
