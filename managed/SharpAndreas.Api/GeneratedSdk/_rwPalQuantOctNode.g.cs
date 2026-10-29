// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class _rwPalQuantOctNode : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=92;
    public _rwPalQuantOctNode(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("Leaf")]
    public _rwPalQuantLeafNode @Leaf { get => new _rwPalQuantLeafNode(Pointer+0); set { SdkMemory.Copy(value.Pointer,Pointer+0,28); } }
    [NativeMember("Branch")]
    public _rwPalQuantBranchNode @Branch { get => new _rwPalQuantBranchNode(Pointer+28); set { SdkMemory.Copy(value.Pointer,Pointer+28,64); } }
}
