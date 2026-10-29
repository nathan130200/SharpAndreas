// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class RpHAnimInterpFrame : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=36;
    public RpHAnimInterpFrame(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("keyFrame1")]
    public RpHAnimKeyFrame? @KeyFrame1 { get => SdkMemory.Read<IntPtr>(Pointer+0) == IntPtr.Zero ? null : new RpHAnimKeyFrame(SdkMemory.Read<IntPtr>(Pointer+0)); set { SdkMemory.Write(Pointer+0,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("keyFrame2")]
    public RpHAnimKeyFrame? @KeyFrame2 { get => SdkMemory.Read<IntPtr>(Pointer+4) == IntPtr.Zero ? null : new RpHAnimKeyFrame(SdkMemory.Read<IntPtr>(Pointer+4)); set { SdkMemory.Write(Pointer+4,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("q")]
    public RtQuat @Q { get => new RtQuat(Pointer+8); set { SdkMemory.Copy(value.Pointer,Pointer+8,16); } }
    [NativeMember("t")]
    public RwV3d @T { get => new RwV3d(Pointer+24); set { SdkMemory.Copy(value.Pointer,Pointer+24,12); } }
}
