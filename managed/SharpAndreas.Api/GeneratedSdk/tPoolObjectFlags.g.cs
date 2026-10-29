// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class tPoolObjectFlags : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=1;
    public tPoolObjectFlags(System.IntPtr pointer) : base(pointer) {}
    public byte @IntValue() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D418 >(418)(Pointer); return __sdkResult; }
}
