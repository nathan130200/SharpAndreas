// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class RpSectorBBoxIt : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=288;
    public RpSectorBBoxIt(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("bbox")]
    public RwBBox @Bbox { get => new RwBBox(Pointer+0); set { SdkMemory.Copy(value.Pointer,Pointer+0,24); } }
    [NativeMember("stack")]
    public NativeObjectArray<RpSectorBBoxItNodeInfo> @Stack { get => new NativeObjectArray<RpSectorBBoxItNodeInfo>(Pointer+24,65,4); }
    [NativeMember("curr")]
    public RpSectorBBoxItNodeInfo? @Curr { get => SdkMemory.Read<IntPtr>(Pointer+284) == IntPtr.Zero ? null : new RpSectorBBoxItNodeInfo(SdkMemory.Read<IntPtr>(Pointer+284)); set { SdkMemory.Write(Pointer+284,value?.Pointer ?? IntPtr.Zero); } }
}
