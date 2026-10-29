// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class RwSingleList : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=4;
    public RwSingleList(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("link")]
    public RwSLLink @Link { get => new RwSLLink(Pointer+0); set { SdkMemory.Copy(value.Pointer,Pointer+0,4); } }
}
