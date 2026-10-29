// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class RwLine : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=24;
    public RwLine(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("start")]
    public RwV3d @Start { get => new RwV3d(Pointer+0); set { SdkMemory.Copy(value.Pointer,Pointer+0,12); } }
    [NativeMember("end")]
    public RwV3d @End { get => new RwV3d(Pointer+12); set { SdkMemory.Copy(value.Pointer,Pointer+12,12); } }
}
