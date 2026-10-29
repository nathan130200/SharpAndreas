// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CPtrListSingleLink : CPtrList
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=4;
    public CPtrListSingleLink(System.IntPtr pointer) : base(pointer) {}
    public CPtrNodeSingleLink? @GetNode() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2232 >(2232)(Pointer); return __sdkResult == IntPtr.Zero ? null : new CPtrNodeSingleLink(__sdkResult); }
    public void @DestroyNative() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2233 >(2233)(Pointer); }
    public void @Flush() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2234 >(2234)(Pointer); }
    public void @AddItem(NativePointer<IntPtr> @item) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2235 >(2235)(Pointer,@item.Pointer); }
    public void @DeleteItem(NativePointer<IntPtr> @item) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2236 >(2236)(Pointer,@item.Pointer); }
}
