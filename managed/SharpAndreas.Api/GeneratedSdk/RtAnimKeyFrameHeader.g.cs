// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class RtAnimKeyFrameHeader : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=8;
    public RtAnimKeyFrameHeader(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("prevFrame")]
    public NativePointer<IntPtr> @PrevFrame { get => new NativePointer<IntPtr>(SdkMemory.Read<IntPtr>(Pointer+0)); set { SdkMemory.Write(Pointer+0,value.Pointer); } }
    [NativeMember("time")]
    public float @Time { get => SdkMemory.Read<float >(Pointer+4); set { SdkMemory.Write(Pointer+4,value); } }
}
