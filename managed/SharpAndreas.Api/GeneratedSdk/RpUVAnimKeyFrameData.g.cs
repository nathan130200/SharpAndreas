// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class RpUVAnimKeyFrameData : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=24;
    public RpUVAnimKeyFrameData(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("linear")]
    public RpUVAnimLinearKeyFrameData @Linear { get => new RpUVAnimLinearKeyFrameData(Pointer+0); set { SdkMemory.Copy(value.Pointer,Pointer+0,24); } }
    [NativeMember("param")]
    public RpUVAnimParamKeyFrameData @Param { get => new RpUVAnimParamKeyFrameData(Pointer+0); set { SdkMemory.Copy(value.Pointer,Pointer+0,24); } }
}
