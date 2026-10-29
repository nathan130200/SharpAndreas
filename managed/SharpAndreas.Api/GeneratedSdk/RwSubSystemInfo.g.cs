// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class RwSubSystemInfo : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=80;
    public RwSubSystemInfo(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("name")]
    public NativeArray<sbyte> @Name { get => new NativeArray<sbyte>(Pointer+0,80); }
}
