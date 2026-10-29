// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CTaskSimpleGangDriveBy : CTaskSimple
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=68;
    public CTaskSimpleGangDriveBy(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_bIsFinished")]
    public bool @IsFinished { get => SdkMemory.Read<bool >(Pointer+8); set { SdkMemory.Write(Pointer+8,value); } }
    [NativeMember("m_bAnimsReferenced")]
    public bool @AnimsReferenced { get => SdkMemory.Read<bool >(Pointer+9); set { SdkMemory.Write(Pointer+9,value); } }
    [NativeMember("m_bSeatRHS")]
    public bool @SeatRHS { get => SdkMemory.Read<bool >(Pointer+10); set { SdkMemory.Write(Pointer+10,value); } }
    [NativeMember("m_bInRangeToShoot")]
    public bool @InRangeToShoot { get => SdkMemory.Read<bool >(Pointer+11); set { SdkMemory.Write(Pointer+11,value); } }
    [NativeMember("m_bInWeaponRange")]
    public bool @InWeaponRange { get => SdkMemory.Read<bool >(Pointer+12); set { SdkMemory.Write(Pointer+12,value); } }
    [NativeMember("m_bReachedAbortRange")]
    public bool @ReachedAbortRange { get => SdkMemory.Read<bool >(Pointer+13); set { SdkMemory.Write(Pointer+13,value); } }
    [NativeMember("m_bFromScriptCommand")]
    public bool @FromScriptCommand { get => SdkMemory.Read<bool >(Pointer+14); set { SdkMemory.Write(Pointer+14,value); } }
    [NativeMember("m_nNextCommand")]
    public sbyte @NextCommand { get => SdkMemory.Read<sbyte >(Pointer+15); set { SdkMemory.Write(Pointer+15,value); } }
    [NativeMember("m_nLastCommand")]
    public sbyte @LastCommand { get => SdkMemory.Read<sbyte >(Pointer+16); set { SdkMemory.Write(Pointer+16,value); } }
    [NativeMember("m_nBurstShots")]
    public sbyte @BurstShots { get => SdkMemory.Read<sbyte >(Pointer+17); set { SdkMemory.Write(Pointer+17,value); } }
    [NativeMember("m_nDrivebyStyle")]
    public sbyte @DrivebyStyle { get => SdkMemory.Read<sbyte >(Pointer+18); set { SdkMemory.Write(Pointer+18,value); } }
    [NativeMember("m_nFrequencyPercentage")]
    public sbyte @FrequencyPercentage { get => SdkMemory.Read<sbyte >(Pointer+19); set { SdkMemory.Write(Pointer+19,value); } }
    [NativeMember("m_nFakeShootDirn")]
    public sbyte @FakeShootDirn { get => SdkMemory.Read<sbyte >(Pointer+20); set { SdkMemory.Write(Pointer+20,value); } }
    [NativeMember("m_nAttackTimer")]
    public short @AttackTimer { get => SdkMemory.Read<short >(Pointer+22); set { SdkMemory.Write(Pointer+22,value); } }
    [NativeMember("m_nLOSCheckTime")]
    public uint @LOSCheckTime { get => SdkMemory.Read<uint >(Pointer+24); set { SdkMemory.Write(Pointer+24,value); } }
    [NativeMember("m_nLOSBlocked")]
    public bool @LOSBlocked { get => SdkMemory.Read<bool >(Pointer+28); set { SdkMemory.Write(Pointer+28,value); } }
    [NativeMember("m_fAbortRange")]
    public float @AbortRange { get => SdkMemory.Read<float >(Pointer+32); set { SdkMemory.Write(Pointer+32,value); } }
    [NativeMember("m_nRequiredAnimID")]
    public int @RequiredAnimationID { get => SdkMemory.Read<int >(Pointer+36); set { SdkMemory.Write(Pointer+36,value); } }
    [NativeMember("m_nRequiredAnimGroup")]
    public int @RequiredAnimationGroup { get => SdkMemory.Read<int >(Pointer+40); set { SdkMemory.Write(Pointer+40,value); } }
    [NativeMember("m_pAnim")]
    public CAnimBlendAssociation? @Animation { get => SdkMemory.Read<IntPtr>(Pointer+44) == IntPtr.Zero ? null : new CAnimBlendAssociation(SdkMemory.Read<IntPtr>(Pointer+44)); set { SdkMemory.Write(Pointer+44,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_pWeaponInfo")]
    public CWeaponInfo? @WeaponInfo { get => SdkMemory.Read<IntPtr>(Pointer+48) == IntPtr.Zero ? null : new CWeaponInfo(SdkMemory.Read<IntPtr>(Pointer+48)); set { SdkMemory.Write(Pointer+48,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_pTargetEntity")]
    public CEntity? @TargetEntity { get => SdkMemory.Read<IntPtr>(Pointer+52) == IntPtr.Zero ? null : new CEntity(SdkMemory.Read<IntPtr>(Pointer+52)); set { SdkMemory.Write(Pointer+52,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_vecCoords")]
    public CVector @Coordinates { get => new CVector(Pointer+56); set { SdkMemory.Copy(value.Pointer,Pointer+56,12); } }
    public void @InitializeAt(CEntity? @pTargetEntity,CVector? @pVecTarget,float @fAbortRange,sbyte @FrequencyPercentage,sbyte @nDrivebyStyle,bool @bSeatRHS) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4044 >(4044)(Pointer,@pTargetEntity?.Pointer ?? IntPtr.Zero,@pVecTarget?.Pointer ?? IntPtr.Zero,@fAbortRange,@FrequencyPercentage,@nDrivebyStyle,(@bSeatRHS ? 1 : 0)); }
}
