// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class RpTriangle : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=8;
    public RpTriangle(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("vertIndex")]
    public NativeArray<ushort> @VertIndex { get => new NativeArray<ushort>(Pointer+0,3); }
    [NativeMember("matIndex")]
    public ushort @Index { get => SdkMemory.Read<ushort >(Pointer+6); set { SdkMemory.Write(Pointer+6,value); } }
}
