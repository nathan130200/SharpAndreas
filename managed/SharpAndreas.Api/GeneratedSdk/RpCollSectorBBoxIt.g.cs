// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class RpCollSectorBBoxIt : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=328;
    public RpCollSectorBBoxIt(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("tree")]
    public RpCollTree? @Tree { get => SdkMemory.Read<IntPtr>(Pointer+0) == IntPtr.Zero ? null : new RpCollTree(SdkMemory.Read<IntPtr>(Pointer+0)); set { SdkMemory.Write(Pointer+0,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("bbox")]
    public RwBBox @Bbox { get => new RwBBox(Pointer+4); set { SdkMemory.Copy(value.Pointer,Pointer+4,24); } }
    [NativeMember("clipBBox")]
    public RwBBox @ClipBBox { get => new RwBBox(Pointer+28); set { SdkMemory.Copy(value.Pointer,Pointer+28,24); } }
    [NativeMember("dummy")]
    public RpCollSector @Dummy { get => new RpCollSector(Pointer+52); set { SdkMemory.Copy(value.Pointer,Pointer+52,8); } }
    [NativeMember("stack")]
    public NativeObjectArray<RpCollSectorBBoxItNodeInfo> @Stack { get => new NativeObjectArray<RpCollSectorBBoxItNodeInfo>(Pointer+60,33,8); }
    [NativeMember("curr")]
    public RpCollSectorBBoxItNodeInfo? @Curr { get => SdkMemory.Read<IntPtr>(Pointer+324) == IntPtr.Zero ? null : new RpCollSectorBBoxItNodeInfo(SdkMemory.Read<IntPtr>(Pointer+324)); set { SdkMemory.Write(Pointer+324,value?.Pointer ?? IntPtr.Zero); } }
}
