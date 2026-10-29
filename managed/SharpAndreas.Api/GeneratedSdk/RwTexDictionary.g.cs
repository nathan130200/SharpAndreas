// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class RwTexDictionary : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=24;
    public RwTexDictionary(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("object")]
    public RwObject @Object { get => new RwObject(Pointer+0); set { SdkMemory.Copy(value.Pointer,Pointer+0,8); } }
    [NativeMember("texturesInDict")]
    public RwLinkList @TexturesInDict { get => new RwLinkList(Pointer+8); set { SdkMemory.Copy(value.Pointer,Pointer+8,8); } }
    [NativeMember("lInInstance")]
    public RwLLLink @LInInstance { get => new RwLLLink(Pointer+16); set { SdkMemory.Copy(value.Pointer,Pointer+16,8); } }
}
