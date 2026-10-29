// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class RpIntersection : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=28;
    public RpIntersection(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("t")]
    public RpIntersectData @T { get => new RpIntersectData(Pointer+0); set { SdkMemory.Copy(value.Pointer,Pointer+0,24); } }
    [NativeMember("type")]
    public RpIntersectType @Type { get => SdkMemory.Read<RpIntersectType >(Pointer+24); set { SdkMemory.Write(Pointer+24,value); } }
}
