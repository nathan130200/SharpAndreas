// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class _rwPalQuantBranchNode : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=64;
    public _rwPalQuantBranchNode(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("dir")]
    public NativeArray<IntPtr> @Direction { get => new NativeArray<IntPtr>(Pointer+0,16); }
}
