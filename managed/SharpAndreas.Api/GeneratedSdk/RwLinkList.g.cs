// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class RwLinkList : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=8;
    public RwLinkList(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("link")]
    public RwLLLink @Link { get => new RwLLLink(Pointer+0); set { SdkMemory.Copy(value.Pointer,Pointer+0,8); } }
}
