// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CPtrListDoubleLink : CPtrList
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=4;
    public CPtrListDoubleLink(System.IntPtr pointer) : base(pointer) {}
    public CPtrNodeDoubleLink? @GetNode() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D890 >(890)(Pointer); return __sdkResult == IntPtr.Zero ? null : new CPtrNodeDoubleLink(__sdkResult); }
    public void @DestroyNative() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D891 >(891)(Pointer); }
    public void @Flush() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D892 >(892)(Pointer); }
    public void @AddItem(NativePointer<IntPtr> @item) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D893 >(893)(Pointer,@item.Pointer); }
    public void @DeleteItem(NativePointer<IntPtr> @item) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D894 >(894)(Pointer,@item.Pointer); }
}
