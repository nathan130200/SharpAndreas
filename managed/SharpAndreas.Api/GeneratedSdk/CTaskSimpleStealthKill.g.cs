// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CTaskSimpleStealthKill : CTaskSimple
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=32;
    public CTaskSimpleStealthKill(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_bKeepTargetAlive")]
    public bool @KeepTargetAlive { get => SdkMemory.Read<bool >(Pointer+8); set { SdkMemory.Write(Pointer+8,value); } }
    [NativeMember("m_pTarget")]
    public CPed? @Target { get => SdkMemory.Read<IntPtr>(Pointer+12) == IntPtr.Zero ? null : new CPed(SdkMemory.Read<IntPtr>(Pointer+12)); set { SdkMemory.Write(Pointer+12,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_nAssocGroupId")]
    public int @AssocGroupId { get => SdkMemory.Read<int >(Pointer+16); set { SdkMemory.Write(Pointer+16,value); } }
    [NativeMember("b_bIsAborting")]
    public bool @BIsAborting { get => SdkMemory.Read<bool >(Pointer+20); set { SdkMemory.Write(Pointer+20,value); } }
    [NativeMember("b_bIsFinished")]
    public bool @BIsFinished { get => SdkMemory.Read<bool >(Pointer+21); set { SdkMemory.Write(Pointer+21,value); } }
    [NativeMember("m_pAnim")]
    public CAnimBlendAssociation? @Animation { get => SdkMemory.Read<IntPtr>(Pointer+24) == IntPtr.Zero ? null : new CAnimBlendAssociation(SdkMemory.Read<IntPtr>(Pointer+24)); set { SdkMemory.Write(Pointer+24,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_nTime")]
    public uint @Time { get => SdkMemory.Read<uint >(Pointer+28); set { SdkMemory.Write(Pointer+28,value); } }
    public void @InitializeAt(bool @bKeepTargetAlive,CPed? @pTarget,int @nAssocGroupId) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4054 >(4054)(Pointer,(@bKeepTargetAlive ? 1 : 0),@pTarget?.Pointer ?? IntPtr.Zero,@nAssocGroupId); }
}
