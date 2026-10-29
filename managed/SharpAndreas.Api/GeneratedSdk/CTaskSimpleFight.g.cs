// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CTaskSimpleFight : CTaskSimple
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=40;
    public CTaskSimpleFight(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_bIsFinished")]
    public bool @IsFinished { get => SdkMemory.Read<bool >(Pointer+8); set { SdkMemory.Write(Pointer+8,value); } }
    [NativeMember("m_bIsInControl")]
    public bool @IsInControl { get => SdkMemory.Read<bool >(Pointer+9); set { SdkMemory.Write(Pointer+9,value); } }
    [NativeMember("m_bAnimsReferenced")]
    public bool @AnimsReferenced { get => SdkMemory.Read<bool >(Pointer+10); set { SdkMemory.Write(Pointer+10,value); } }
    [NativeMember("m_nRequiredAnimGroup")]
    public uint @RequiredAnimationGroup { get => SdkMemory.Read<uint >(Pointer+12); set { SdkMemory.Write(Pointer+12,value); } }
    [NativeMember("m_nIdlePeriod")]
    public ushort @IdlePeriod { get => SdkMemory.Read<ushort >(Pointer+16); set { SdkMemory.Write(Pointer+16,value); } }
    [NativeMember("m_nIdleCounter")]
    public ushort @IdleCounter { get => SdkMemory.Read<ushort >(Pointer+18); set { SdkMemory.Write(Pointer+18,value); } }
    [NativeMember("m_nContinueStrike")]
    public sbyte @ContinueStrike { get => SdkMemory.Read<sbyte >(Pointer+20); set { SdkMemory.Write(Pointer+20,value); } }
    [NativeMember("m_nChainCounter")]
    public sbyte @ChainCounter { get => SdkMemory.Read<sbyte >(Pointer+21); set { SdkMemory.Write(Pointer+21,value); } }
    [NativeMember("m_pTargetEntity")]
    public CEntity? @TargetEntity { get => SdkMemory.Read<IntPtr>(Pointer+24) == IntPtr.Zero ? null : new CEntity(SdkMemory.Read<IntPtr>(Pointer+24)); set { SdkMemory.Write(Pointer+24,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_pAnim")]
    public CAnimBlendAssociation? @Animation { get => SdkMemory.Read<IntPtr>(Pointer+28) == IntPtr.Zero ? null : new CAnimBlendAssociation(SdkMemory.Read<IntPtr>(Pointer+28)); set { SdkMemory.Write(Pointer+28,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_pIdleAnim")]
    public CAnimBlendAssociation? @IdleAnimation { get => SdkMemory.Read<IntPtr>(Pointer+32) == IntPtr.Zero ? null : new CAnimBlendAssociation(SdkMemory.Read<IntPtr>(Pointer+32)); set { SdkMemory.Write(Pointer+32,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_nComboSet")]
    public sbyte @ComboSet { get => SdkMemory.Read<sbyte >(Pointer+36); set { SdkMemory.Write(Pointer+36,value); } }
    [NativeMember("m_nCurrentMove")]
    public sbyte @CurrentMove { get => SdkMemory.Read<sbyte >(Pointer+37); set { SdkMemory.Write(Pointer+37,value); } }
    [NativeMember("m_nNextCommand")]
    public byte @NextCommand { get => SdkMemory.Read<byte >(Pointer+38); set { SdkMemory.Write(Pointer+38,value); } }
    [NativeMember("m_nLastCommand")]
    public byte @LastCommand { get => SdkMemory.Read<byte >(Pointer+39); set { SdkMemory.Write(Pointer+39,value); } }
    public void @InitializeAt(CEntity? @pTargetEntity,int @nCommand,uint @nIdlePeriod) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1315 >(1315)(Pointer,@pTargetEntity?.Pointer ?? IntPtr.Zero,@nCommand,@nIdlePeriod); }
}
