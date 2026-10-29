// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class LimbOrientation : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=8;
    public LimbOrientation(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_fYaw")]
    public float @Yaw { get => SdkMemory.Read<float >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("m_fPitch")]
    public float @Pitch { get => SdkMemory.Read<float >(Pointer+4); set { SdkMemory.Write(Pointer+4,value); } }
}
