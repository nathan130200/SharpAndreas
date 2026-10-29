// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CPtrNode : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=8;
    public CPtrNode(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_pVoid")]
    public NativePointer<IntPtr> @Void { get => new NativePointer<IntPtr>(SdkMemory.Read<IntPtr>(Pointer+0)); set { SdkMemory.Write(Pointer+0,value.Pointer); } }
    [NativeMember("m_pNext")]
    public CPtrNode? @Next { get => SdkMemory.Read<IntPtr>(Pointer+4) == IntPtr.Zero ? null : new CPtrNode(SdkMemory.Read<IntPtr>(Pointer+4)); set { SdkMemory.Write(Pointer+4,value?.Pointer ?? IntPtr.Zero); } }
    public void @InitializeAt(NativePointer<IntPtr> @item) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D882 >(882)(Pointer,@item.Pointer); }
}
