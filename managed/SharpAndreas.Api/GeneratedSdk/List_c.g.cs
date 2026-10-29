// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class List_c : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=12;
    public List_c(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("last")]
    public ListItem_c? @Last { get => SdkMemory.Read<IntPtr>(Pointer+0) == IntPtr.Zero ? null : new ListItem_c(SdkMemory.Read<IntPtr>(Pointer+0)); set { SdkMemory.Write(Pointer+0,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("first")]
    public ListItem_c? @First { get => SdkMemory.Read<IntPtr>(Pointer+4) == IntPtr.Zero ? null : new ListItem_c(SdkMemory.Read<IntPtr>(Pointer+4)); set { SdkMemory.Write(Pointer+4,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("count")]
    public uint @Count { get => SdkMemory.Read<uint >(Pointer+8); set { SdkMemory.Write(Pointer+8,value); } }
    public void @InitializeAt() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D793 >(793)(Pointer); }
    public void @DestroyNative() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D794 >(794)(Pointer); }
    public void @AddItem(ListItem_c? @pItem) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D795 >(795)(Pointer,@pItem?.Pointer ?? IntPtr.Zero); }
    public void @RemoveItem(ListItem_c? @pItem) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D796 >(796)(Pointer,@pItem?.Pointer ?? IntPtr.Zero); }
    public ListItem_c? @GetHead() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D797 >(797)(Pointer); return __sdkResult == IntPtr.Zero ? null : new ListItem_c(__sdkResult); }
    public ListItem_c? @RemoveHead() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D798 >(798)(Pointer); return __sdkResult == IntPtr.Zero ? null : new ListItem_c(__sdkResult); }
    public ListItem_c? @GetNext(ListItem_c? @pItem) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D799 >(799)(Pointer,@pItem?.Pointer ?? IntPtr.Zero); return __sdkResult == IntPtr.Zero ? null : new ListItem_c(__sdkResult); }
    public ListItem_c? @GetPrev(ListItem_c? @pItem) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D800 >(800)(Pointer,@pItem?.Pointer ?? IntPtr.Zero); return __sdkResult == IntPtr.Zero ? null : new ListItem_c(__sdkResult); }
    public ListItem_c? @GetItemOffset(bool @bFromHead,int @iOffset) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D801 >(801)(Pointer,(@bFromHead ? 1 : 0),@iOffset); return __sdkResult == IntPtr.Zero ? null : new ListItem_c(__sdkResult); }
}
