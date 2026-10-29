// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CPlayerData : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=172;
    public CPlayerData(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_pWanted")]
    public CWanted? @Wanted { get => SdkMemory.Read<IntPtr>(Pointer+0) == IntPtr.Zero ? null : new CWanted(SdkMemory.Read<IntPtr>(Pointer+0)); set { SdkMemory.Write(Pointer+0,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_pPedClothesDesc")]
    public CPedClothesDesc? @PedClothesDesc { get => SdkMemory.Read<IntPtr>(Pointer+4) == IntPtr.Zero ? null : new CPedClothesDesc(SdkMemory.Read<IntPtr>(Pointer+4)); set { SdkMemory.Write(Pointer+4,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_pArrestingCop")]
    public CCopPed? @ArrestingCop { get => SdkMemory.Read<IntPtr>(Pointer+8) == IntPtr.Zero ? null : new CCopPed(SdkMemory.Read<IntPtr>(Pointer+8)); set { SdkMemory.Write(Pointer+8,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_vecFightMovement")]
    public CVector2D @FightMovement { get => new CVector2D(Pointer+12); set { SdkMemory.Copy(value.Pointer,Pointer+12,8); } }
    [NativeMember("m_fMoveBlendRatio")]
    public float @MoveBlendRatio { get => SdkMemory.Read<float >(Pointer+20); set { SdkMemory.Write(Pointer+20,value); } }
    [NativeMember("m_fTimeCanRun")]
    public float @TimeCanRun { get => SdkMemory.Read<float >(Pointer+24); set { SdkMemory.Write(Pointer+24,value); } }
    [NativeMember("m_fMoveSpeed")]
    public float @MoveSpeed { get => SdkMemory.Read<float >(Pointer+28); set { SdkMemory.Write(Pointer+28,value); } }
    [NativeMember("m_nChosenWeapon")]
    public byte @ChosenWeapon { get => SdkMemory.Read<byte >(Pointer+32); set { SdkMemory.Write(Pointer+32,value); } }
    [NativeMember("m_nCarDangerCounter")]
    public byte @CarDangerCounter { get => SdkMemory.Read<byte >(Pointer+33); set { SdkMemory.Write(Pointer+33,value); } }
    [NativeMember("m_nStandStillTimer")]
    public uint @StandStillTimer { get => SdkMemory.Read<uint >(Pointer+36); set { SdkMemory.Write(Pointer+36,value); } }
    [NativeMember("m_nHitAnimDelayTimer")]
    public uint @HitAnimationDelayTimer { get => SdkMemory.Read<uint >(Pointer+40); set { SdkMemory.Write(Pointer+40,value); } }
    [NativeMember("m_fAttackButtonCounter")]
    public float @AttackButtonCounter { get => SdkMemory.Read<float >(Pointer+44); set { SdkMemory.Write(Pointer+44,value); } }
    [NativeMember("m_pDangerCar")]
    public NativePointer<IntPtr> @DangerCar { get => new NativePointer<IntPtr>(SdkMemory.Read<IntPtr>(Pointer+48)); set { SdkMemory.Write(Pointer+48,value.Pointer); } }
    [NativeMember("m_bStoppedMoving")]
    public uint @StoppedMoving { get => (uint)SdkMemory.ReadBits(Pointer,416,1); set { SdkMemory.WriteBits(Pointer,416,1,unchecked((ulong)value)); } }
    [NativeMember("m_bAdrenaline")]
    public uint @Adrenaline { get => (uint)SdkMemory.ReadBits(Pointer,417,1); set { SdkMemory.WriteBits(Pointer,417,1,unchecked((ulong)value)); } }
    [NativeMember("m_bHaveTargetSelected")]
    public uint @HaveTargetSelected { get => (uint)SdkMemory.ReadBits(Pointer,418,1); set { SdkMemory.WriteBits(Pointer,418,1,unchecked((ulong)value)); } }
    [NativeMember("m_bFreeAiming")]
    public uint @FreeAiming { get => (uint)SdkMemory.ReadBits(Pointer,419,1); set { SdkMemory.WriteBits(Pointer,419,1,unchecked((ulong)value)); } }
    [NativeMember("m_bCanBeDamaged")]
    public uint @CanBeDamaged { get => (uint)SdkMemory.ReadBits(Pointer,420,1); set { SdkMemory.WriteBits(Pointer,420,1,unchecked((ulong)value)); } }
    [NativeMember("m_bAllMeleeAttackPtsBlocked")]
    public uint @AllMeleeAttackPtsBlocked { get => (uint)SdkMemory.ReadBits(Pointer,421,1); set { SdkMemory.WriteBits(Pointer,421,1,unchecked((ulong)value)); } }
    [NativeMember("m_bJustBeenSnacking")]
    public uint @JustBeenSnacking { get => (uint)SdkMemory.ReadBits(Pointer,422,1); set { SdkMemory.WriteBits(Pointer,422,1,unchecked((ulong)value)); } }
    [NativeMember("m_bRequireHandleBreath")]
    public uint @RequireHandleBreath { get => (uint)SdkMemory.ReadBits(Pointer,423,1); set { SdkMemory.WriteBits(Pointer,423,1,unchecked((ulong)value)); } }
    [NativeMember("m_bGroupStuffDisabled")]
    public uint @GroupStuffDisabled { get => (uint)SdkMemory.ReadBits(Pointer,424,1); set { SdkMemory.WriteBits(Pointer,424,1,unchecked((ulong)value)); } }
    [NativeMember("m_bGroupAlwaysFollow")]
    public uint @GroupAlwaysFollow { get => (uint)SdkMemory.ReadBits(Pointer,425,1); set { SdkMemory.WriteBits(Pointer,425,1,unchecked((ulong)value)); } }
    [NativeMember("m_bGroupNeverFollow")]
    public uint @GroupNeverFollow { get => (uint)SdkMemory.ReadBits(Pointer,426,1); set { SdkMemory.WriteBits(Pointer,426,1,unchecked((ulong)value)); } }
    [NativeMember("m_bInVehicleDontAllowWeaponChange")]
    public uint @InVehicleDontAllowWeaponChange { get => (uint)SdkMemory.ReadBits(Pointer,427,1); set { SdkMemory.WriteBits(Pointer,427,1,unchecked((ulong)value)); } }
    [NativeMember("m_bRenderWeapon")]
    public uint @RenderWeapon { get => (uint)SdkMemory.ReadBits(Pointer,428,1); set { SdkMemory.WriteBits(Pointer,428,1,unchecked((ulong)value)); } }
    [NativeMember("m_nPlayerGroup")]
    public uint @PlayerGroup { get => SdkMemory.Read<uint >(Pointer+56); set { SdkMemory.Write(Pointer+56,value); } }
    [NativeMember("m_nAdrenalineEndTime")]
    public uint @AdrenalineEndTime { get => SdkMemory.Read<uint >(Pointer+60); set { SdkMemory.Write(Pointer+60,value); } }
    [NativeMember("m_nDrunkenness")]
    public byte @Drunkenness { get => SdkMemory.Read<byte >(Pointer+64); set { SdkMemory.Write(Pointer+64,value); } }
    [NativeMember("m_nFadeDrunkenness")]
    public byte @FadeDrunkenness { get => SdkMemory.Read<byte >(Pointer+65); set { SdkMemory.Write(Pointer+65,value); } }
    [NativeMember("m_nDrugLevel")]
    public byte @DrugLevel { get => SdkMemory.Read<byte >(Pointer+66); set { SdkMemory.Write(Pointer+66,value); } }
    [NativeMember("m_nScriptLimitToGangSize")]
    public byte @ScriptLimitToGangSize { get => SdkMemory.Read<byte >(Pointer+67); set { SdkMemory.Write(Pointer+67,value); } }
    [NativeMember("m_fBreath")]
    public float @Breath { get => SdkMemory.Read<float >(Pointer+68); set { SdkMemory.Write(Pointer+68,value); } }
    [NativeMember("m_nMeleeWeaponAnimReferenced")]
    public uint @MeleeWeaponAnimationReferenced { get => SdkMemory.Read<uint >(Pointer+72); set { SdkMemory.Write(Pointer+72,value); } }
    [NativeMember("m_nMeleeWeaponAnimReferencedExtra")]
    public uint @MeleeWeaponAnimationReferencedExtra { get => SdkMemory.Read<uint >(Pointer+76); set { SdkMemory.Write(Pointer+76,value); } }
    [NativeMember("m_fFPSMoveHeading")]
    public float @FPSMoveHeading { get => SdkMemory.Read<float >(Pointer+80); set { SdkMemory.Write(Pointer+80,value); } }
    [NativeMember("m_fLookPitch")]
    public float @LookPitch { get => SdkMemory.Read<float >(Pointer+84); set { SdkMemory.Write(Pointer+84,value); } }
    [NativeMember("m_fSkateBoardSpeed")]
    public float @SkateBoardSpeed { get => SdkMemory.Read<float >(Pointer+88); set { SdkMemory.Write(Pointer+88,value); } }
    [NativeMember("m_fSkateBoardLean")]
    public float @SkateBoardLean { get => SdkMemory.Read<float >(Pointer+92); set { SdkMemory.Write(Pointer+92,value); } }
    [NativeMember("m_pSpecialAtomic")]
    public RpAtomic? @SpecialAtomic { get => SdkMemory.Read<IntPtr>(Pointer+96) == IntPtr.Zero ? null : new RpAtomic(SdkMemory.Read<IntPtr>(Pointer+96)); set { SdkMemory.Write(Pointer+96,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_fGunSpinSpeed")]
    public float @GunSpinSpeed { get => SdkMemory.Read<float >(Pointer+100); set { SdkMemory.Write(Pointer+100,value); } }
    [NativeMember("m_fGunSpinAngle")]
    public float @GunSpinAngle { get => SdkMemory.Read<float >(Pointer+104); set { SdkMemory.Write(Pointer+104,value); } }
    [NativeMember("m_nLastTimeFiring")]
    public uint @LastTimeFiring { get => SdkMemory.Read<uint >(Pointer+108); set { SdkMemory.Write(Pointer+108,value); } }
    [NativeMember("m_nTargetBone")]
    public uint @TargetBone { get => SdkMemory.Read<uint >(Pointer+112); set { SdkMemory.Write(Pointer+112,value); } }
    [NativeMember("m_vecTargetBoneOffset")]
    public CVector @TargetBoneOffset { get => new CVector(Pointer+116); set { SdkMemory.Copy(value.Pointer,Pointer+116,12); } }
    [NativeMember("m_nBusFaresCollected")]
    public uint @BusFaresCollected { get => SdkMemory.Read<uint >(Pointer+128); set { SdkMemory.Write(Pointer+128,value); } }
    [NativeMember("m_bPlayerSprintDisabled")]
    public bool @PlayerSprintDisabled { get => SdkMemory.Read<bool >(Pointer+132); set { SdkMemory.Write(Pointer+132,value); } }
    [NativeMember("m_bDontAllowWeaponChange")]
    public bool @DontAllowWeaponChange { get => SdkMemory.Read<bool >(Pointer+133); set { SdkMemory.Write(Pointer+133,value); } }
    [NativeMember("m_bForceInteriorLighting")]
    public bool @ForceInteriorLighting { get => SdkMemory.Read<bool >(Pointer+134); set { SdkMemory.Write(Pointer+134,value); } }
    [NativeMember("m_nPadDownPressedInMilliseconds")]
    public ushort @PadDownPressedInMilliseconds { get => SdkMemory.Read<ushort >(Pointer+136); set { SdkMemory.Write(Pointer+136,value); } }
    [NativeMember("m_nPadUpPressedInMilliseconds")]
    public ushort @PadUpPressedInMilliseconds { get => SdkMemory.Read<ushort >(Pointer+138); set { SdkMemory.Write(Pointer+138,value); } }
    [NativeMember("m_nWetness")]
    public byte @Wetness { get => SdkMemory.Read<byte >(Pointer+140); set { SdkMemory.Write(Pointer+140,value); } }
    [NativeMember("m_bPlayersGangActive")]
    public bool @PlayersGangActive { get => SdkMemory.Read<bool >(Pointer+141); set { SdkMemory.Write(Pointer+141,value); } }
    [NativeMember("m_nWaterCoverPerc")]
    public byte @WaterCoverPerc { get => SdkMemory.Read<byte >(Pointer+142); set { SdkMemory.Write(Pointer+142,value); } }
    [NativeMember("m_fWaterHeight")]
    public float @WaterHeight { get => SdkMemory.Read<float >(Pointer+144); set { SdkMemory.Write(Pointer+144,value); } }
    [NativeMember("m_nFireHSMissilePressedTime")]
    public uint @FireHSMissilePressedTime { get => SdkMemory.Read<uint >(Pointer+148); set { SdkMemory.Write(Pointer+148,value); } }
    [NativeMember("m_LastHSMissileTarget")]
    public CEntity? @LastHSMissileTarget { get => SdkMemory.Read<IntPtr>(Pointer+152) == IntPtr.Zero ? null : new CEntity(SdkMemory.Read<IntPtr>(Pointer+152)); set { SdkMemory.Write(Pointer+152,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_nModelIndexOfLastBuildingShot")]
    public uint @ModelIndexOfLastBuildingShot { get => SdkMemory.Read<uint >(Pointer+156); set { SdkMemory.Write(Pointer+156,value); } }
    [NativeMember("m_nLastHSMissileLOSTime")]
    public uint @LastHSMissileLOSTime { get => (uint)SdkMemory.ReadBits(Pointer,1280,31); set { SdkMemory.WriteBits(Pointer,1280,31,unchecked((ulong)value)); } }
    [NativeMember("m_bLastHSMissileLOS")]
    public uint @LastHSMissileLOS { get => (uint)SdkMemory.ReadBits(Pointer,1311,1); set { SdkMemory.WriteBits(Pointer,1311,1,unchecked((ulong)value)); } }
    [NativeMember("m_pCurrentProstitutePed")]
    public CPed? @CurrentProstitutePed { get => SdkMemory.Read<IntPtr>(Pointer+164) == IntPtr.Zero ? null : new CPed(SdkMemory.Read<IntPtr>(Pointer+164)); set { SdkMemory.Write(Pointer+164,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_pLastProstituteShagged")]
    public CPed? @LastProstituteShagged { get => SdkMemory.Read<IntPtr>(Pointer+168) == IntPtr.Zero ? null : new CPed(SdkMemory.Read<IntPtr>(Pointer+168)); set { SdkMemory.Write(Pointer+168,value?.Pointer ?? IntPtr.Zero); } }
}
