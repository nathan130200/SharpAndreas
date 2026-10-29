// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class RwStreamUnion : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=20;
    public RwStreamUnion(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("memory")]
    public RwStreamMemory @Memory { get => new RwStreamMemory(Pointer+0); set { SdkMemory.Copy(value.Pointer,Pointer+0,12); } }
    [NativeMember("file")]
    public RwStreamFile @File { get => new RwStreamFile(Pointer+0); set { SdkMemory.Copy(value.Pointer,Pointer+0,4); } }
    [NativeMember("custom")]
    public RwStreamCustom @Custom { get => new RwStreamCustom(Pointer+0); set { SdkMemory.Copy(value.Pointer,Pointer+0,20); } }
}
