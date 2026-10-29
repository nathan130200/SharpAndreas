// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CTaskSimpleChoking : CTaskSimple
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=28;
    public CTaskSimpleChoking(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_pAttacker")]
    public CPed? @Attacker { get => SdkMemory.Read<IntPtr>(Pointer+8) == IntPtr.Zero ? null : new CPed(SdkMemory.Read<IntPtr>(Pointer+8)); set { SdkMemory.Write(Pointer+8,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_pAnim")]
    public CAnimBlendAssociation? @Animation { get => SdkMemory.Read<IntPtr>(Pointer+12) == IntPtr.Zero ? null : new CAnimBlendAssociation(SdkMemory.Read<IntPtr>(Pointer+12)); set { SdkMemory.Write(Pointer+12,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_nTimeRemaining")]
    public uint @TimeRemaining { get => SdkMemory.Read<uint >(Pointer+16); set { SdkMemory.Write(Pointer+16,value); } }
    [NativeMember("m_nTimeStarted")]
    public uint @TimeStarted { get => SdkMemory.Read<uint >(Pointer+20); set { SdkMemory.Write(Pointer+20,value); } }
    [NativeMember("m_bIsTeargas")]
    public bool @IsTeargas { get => SdkMemory.Read<bool >(Pointer+24); set { SdkMemory.Write(Pointer+24,value); } }
    [NativeMember("m_bIsFinished")]
    public bool @IsFinished { get => SdkMemory.Read<bool >(Pointer+25); set { SdkMemory.Write(Pointer+25,value); } }
    public void @InitializeAt(CPed? @pAttacker,bool @bIsTeargas) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4041 >(4041)(Pointer,@pAttacker?.Pointer ?? IntPtr.Zero,(@bIsTeargas ? 1 : 0)); }
    public void @UpdateChoke(CPed? @pVictim,CPed? @pAttacker,bool @bIsTeargas) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4042 >(4042)(Pointer,@pVictim?.Pointer ?? IntPtr.Zero,@pAttacker?.Pointer ?? IntPtr.Zero,(@bIsTeargas ? 1 : 0)); }
}
