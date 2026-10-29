// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CColAccel : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=1;
    public CColAccel(System.IntPtr pointer) : base(pointer) {}
    public bool @IsCacheLoading() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2169 >(2169)(Pointer); return __sdkResult != 0; }
}
