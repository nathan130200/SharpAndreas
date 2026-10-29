// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CMatrixLink : CMatrix
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=84;
    public CMatrixLink(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_pOwner")]
    public CPlaceable? @Owner { get => SdkMemory.Read<IntPtr>(Pointer+72) == IntPtr.Zero ? null : new CPlaceable(SdkMemory.Read<IntPtr>(Pointer+72)); set { SdkMemory.Write(Pointer+72,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_pPrev")]
    public CMatrixLink? @Prev { get => SdkMemory.Read<IntPtr>(Pointer+76) == IntPtr.Zero ? null : new CMatrixLink(SdkMemory.Read<IntPtr>(Pointer+76)); set { SdkMemory.Write(Pointer+76,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_pNext")]
    public CMatrixLink? @Next { get => SdkMemory.Read<IntPtr>(Pointer+80) == IntPtr.Zero ? null : new CMatrixLink(SdkMemory.Read<IntPtr>(Pointer+80)); set { SdkMemory.Write(Pointer+80,value?.Pointer ?? IntPtr.Zero); } }
    public void @Insert(CMatrixLink? @where) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D275 >(275)(Pointer,@where?.Pointer ?? IntPtr.Zero); }
    public void @Remove() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D276 >(276)(Pointer); }
}
