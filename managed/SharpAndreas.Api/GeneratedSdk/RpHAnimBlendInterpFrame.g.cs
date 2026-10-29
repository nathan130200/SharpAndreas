// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class RpHAnimBlendInterpFrame : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=28;
    public RpHAnimBlendInterpFrame(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("orientation")]
    public RtQuat @Orientation { get => new RtQuat(Pointer+0); set { SdkMemory.Copy(value.Pointer,Pointer+0,16); } }
    [NativeMember("translation")]
    public RwV3d @Translation { get => new RwV3d(Pointer+16); set { SdkMemory.Copy(value.Pointer,Pointer+16,12); } }
}
