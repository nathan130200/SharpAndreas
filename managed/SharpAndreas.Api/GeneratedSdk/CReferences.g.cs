// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CReferences : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=1;
    public CReferences(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("aRefs")]
    public static CReference? @Refs { get => new IntPtr(0xB9B9A8) == IntPtr.Zero ? null : new CReference(new IntPtr(0xB9B9A8)); }
    [NativeMember("pEmptyList")]
    public static NativePointer<IntPtr> @EmptyList { get => new NativePointer<IntPtr>(new IntPtr(0xBA1768)); }
    public static void @Init() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3554 >(3554)(); }
    public static uint @ListSize(CReference? @ref) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3555 >(3555)(@ref?.Pointer ?? IntPtr.Zero); return __sdkResult; }
    public static void @RemoveReferencesToPlayer() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3556 >(3556)(); }
    public static void @PruneAllReferencesInWorld() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3557 >(3557)(); }
}
