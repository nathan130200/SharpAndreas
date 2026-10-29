// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class RpHAnimKeyFrame : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=36;
    public RpHAnimKeyFrame(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("prevFrame")]
    public RpHAnimKeyFrame? @PrevFrame { get => SdkMemory.Read<IntPtr>(Pointer+0) == IntPtr.Zero ? null : new RpHAnimKeyFrame(SdkMemory.Read<IntPtr>(Pointer+0)); set { SdkMemory.Write(Pointer+0,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("time")]
    public float @Time { get => SdkMemory.Read<float >(Pointer+4); set { SdkMemory.Write(Pointer+4,value); } }
    [NativeMember("q")]
    public RtQuat @Q { get => new RtQuat(Pointer+8); set { SdkMemory.Copy(value.Pointer,Pointer+8,16); } }
    [NativeMember("t")]
    public RwV3d @T { get => new RwV3d(Pointer+24); set { SdkMemory.Copy(value.Pointer,Pointer+24,12); } }
}
