// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CControllerAction : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=32;
    public CControllerAction(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("keys")]
    public NativeObjectArray<CControllerKey> @Keys { get => new NativeObjectArray<CControllerKey>(Pointer+0,4,8); }
}
