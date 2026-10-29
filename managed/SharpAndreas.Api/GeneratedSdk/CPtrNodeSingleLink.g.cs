// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CPtrNodeSingleLink : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=8;
    public CPtrNodeSingleLink(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("pItem")]
    public NativePointer<IntPtr> @Item { get => new NativePointer<IntPtr>(SdkMemory.Read<IntPtr>(Pointer+0)); set { SdkMemory.Write(Pointer+0,value.Pointer); } }
    [NativeMember("pNext")]
    public CPtrNodeSingleLink? @Next { get => SdkMemory.Read<IntPtr>(Pointer+4) == IntPtr.Zero ? null : new CPtrNodeSingleLink(SdkMemory.Read<IntPtr>(Pointer+4)); set { SdkMemory.Write(Pointer+4,value?.Pointer ?? IntPtr.Zero); } }
    public void @InitializeAt(NativePointer<IntPtr> @item) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2229 >(2229)(Pointer,@item.Pointer); }
    public static NativePointer<IntPtr> @AllocateNative(uint @size) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2230 >(2230)(@size); return new NativePointer<IntPtr>(__sdkResult); }
    public static void @FreeNative(NativePointer<IntPtr> @data) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2231 >(2231)(@data.Pointer); }
}
