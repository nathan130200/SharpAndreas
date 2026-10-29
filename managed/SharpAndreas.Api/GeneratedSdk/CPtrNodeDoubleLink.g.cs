// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CPtrNodeDoubleLink : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=12;
    public CPtrNodeDoubleLink(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("pItem")]
    public NativePointer<IntPtr> @Item { get => new NativePointer<IntPtr>(SdkMemory.Read<IntPtr>(Pointer+0)); set { SdkMemory.Write(Pointer+0,value.Pointer); } }
    [NativeMember("pNext")]
    public CPtrNodeDoubleLink? @Next { get => SdkMemory.Read<IntPtr>(Pointer+4) == IntPtr.Zero ? null : new CPtrNodeDoubleLink(SdkMemory.Read<IntPtr>(Pointer+4)); set { SdkMemory.Write(Pointer+4,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("pPrev")]
    public CPtrNodeDoubleLink? @Prev { get => SdkMemory.Read<IntPtr>(Pointer+8) == IntPtr.Zero ? null : new CPtrNodeDoubleLink(SdkMemory.Read<IntPtr>(Pointer+8)); set { SdkMemory.Write(Pointer+8,value?.Pointer ?? IntPtr.Zero); } }
    public void @InitializeAt(NativePointer<IntPtr> @item) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D887 >(887)(Pointer,@item.Pointer); }
    public static NativePointer<IntPtr> @AllocateNative(uint @size) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D888 >(888)(@size); return new NativePointer<IntPtr>(__sdkResult); }
    public static void @FreeNative(NativePointer<IntPtr> @data) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D889 >(889)(@data.Pointer); }
}
