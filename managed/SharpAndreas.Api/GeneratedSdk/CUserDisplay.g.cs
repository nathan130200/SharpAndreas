// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CUserDisplay : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=1;
    public CUserDisplay(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("OnscnTimer")]
    public static COnscreenTimer @OnscnTimer { get => new COnscreenTimer(new IntPtr(0xBA1788)); set { SdkMemory.Copy(value.Pointer,new IntPtr(0xBA1788),340); } }
}
