// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class rwStreamMatrix : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=52;
    public rwStreamMatrix(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("right")]
    public RwV3d @Right { get => new RwV3d(Pointer+0); set { SdkMemory.Copy(value.Pointer,Pointer+0,12); } }
    [NativeMember("up")]
    public RwV3d @Up { get => new RwV3d(Pointer+12); set { SdkMemory.Copy(value.Pointer,Pointer+12,12); } }
    [NativeMember("at")]
    public RwV3d @At { get => new RwV3d(Pointer+24); set { SdkMemory.Copy(value.Pointer,Pointer+24,12); } }
    [NativeMember("pos")]
    public RwV3d @Position { get => new RwV3d(Pointer+36); set { SdkMemory.Copy(value.Pointer,Pointer+36,12); } }
    [NativeMember("type")]
    public int @Type { get => SdkMemory.Read<int >(Pointer+48); set { SdkMemory.Write(Pointer+48,value); } }
}
