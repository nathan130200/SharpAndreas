// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class RpUVAnimKeyFrame : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=32;
    public RpUVAnimKeyFrame(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("prevFrame")]
    public RpUVAnimKeyFrame? @PrevFrame { get => SdkMemory.Read<IntPtr>(Pointer+0) == IntPtr.Zero ? null : new RpUVAnimKeyFrame(SdkMemory.Read<IntPtr>(Pointer+0)); set { SdkMemory.Write(Pointer+0,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("time")]
    public float @Time { get => SdkMemory.Read<float >(Pointer+4); set { SdkMemory.Write(Pointer+4,value); } }
    [NativeMember("data")]
    public RpUVAnimKeyFrameData @Data { get => new RpUVAnimKeyFrameData(Pointer+8); set { SdkMemory.Copy(value.Pointer,Pointer+8,24); } }
}
