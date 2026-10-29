// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class RtAnimInterpFrameHeader : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=8;
    public RtAnimInterpFrameHeader(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("keyFrame1")]
    public RtAnimKeyFrameHeader? @KeyFrame1 { get => SdkMemory.Read<IntPtr>(Pointer+0) == IntPtr.Zero ? null : new RtAnimKeyFrameHeader(SdkMemory.Read<IntPtr>(Pointer+0)); set { SdkMemory.Write(Pointer+0,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("keyFrame2")]
    public RtAnimKeyFrameHeader? @KeyFrame2 { get => SdkMemory.Read<IntPtr>(Pointer+4) == IntPtr.Zero ? null : new RtAnimKeyFrameHeader(SdkMemory.Read<IntPtr>(Pointer+4)); set { SdkMemory.Write(Pointer+4,value?.Pointer ?? IntPtr.Zero); } }
}
