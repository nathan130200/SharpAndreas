// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CAtomicModelInfo : CBaseModelInfo
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=32;
    public CAtomicModelInfo(System.IntPtr pointer) : base(pointer) {}
    public void @SetAtomic(RpAtomic? @atomic) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D404 >(404)(Pointer,@atomic?.Pointer ?? IntPtr.Zero); }
    public RpAtomic? @GetAtomicFromDistance(float @distance) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D405 >(405)(Pointer,@distance); return __sdkResult == IntPtr.Zero ? null : new RpAtomic(__sdkResult); }
}
