// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class rwResourcesGlobals : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=40;
    public rwResourcesGlobals(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("res")]
    public rwResources @Res { get => new rwResources(Pointer+0); set { SdkMemory.Copy(value.Pointer,Pointer+0,40); } }
}
