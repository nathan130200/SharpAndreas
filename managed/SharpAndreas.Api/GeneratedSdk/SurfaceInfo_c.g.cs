// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class SurfaceInfo_c : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=12;
    public SurfaceInfo_c(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("tyreGrip")]
    public sbyte @TyreGrip { get => SdkMemory.Read<sbyte >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("wetGrip")]
    public sbyte @WetGrip { get => SdkMemory.Read<sbyte >(Pointer+1); set { SdkMemory.Write(Pointer+1,value); } }
}
