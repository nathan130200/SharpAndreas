// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CVehicle : CPhysical
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=1440;
    public CVehicle(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_vehicleAudio")]
    public CAEVehicleAudioEntity @VehicleAudio { get => new CAEVehicleAudioEntity(Pointer+312); set { SdkMemory.Copy(value.Pointer,Pointer+312,588); } }
    [NativeMember("m_pHandlingData")]
    public tHandlingData? @HandlingData { get => SdkMemory.Read<IntPtr>(Pointer+900) == IntPtr.Zero ? null : new tHandlingData(SdkMemory.Read<IntPtr>(Pointer+900)); set { SdkMemory.Write(Pointer+900,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_pFlyingHandlingData")]
    public tFlyingHandlingData? @FlyingHandlingData { get => SdkMemory.Read<IntPtr>(Pointer+904) == IntPtr.Zero ? null : new tFlyingHandlingData(SdkMemory.Read<IntPtr>(Pointer+904)); set { SdkMemory.Write(Pointer+904,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_autoPilot")]
    public CAutoPilot @AutoPilot { get => new CAutoPilot(Pointer+912); set { SdkMemory.Copy(value.Pointer,Pointer+912,152); } }
    [NativeMember("bIsLawEnforcer")]
    public bool @IsLawEnforcer { get => SdkMemory.ReadBits(Pointer,8512,1) != 0; set { SdkMemory.WriteBits(Pointer,8512,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bIsAmbulanceOnDuty")]
    public bool @IsAmbulanceOnDuty { get => SdkMemory.ReadBits(Pointer,8513,1) != 0; set { SdkMemory.WriteBits(Pointer,8513,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bIsFireTruckOnDuty")]
    public bool @IsFireTruckOnDuty { get => SdkMemory.ReadBits(Pointer,8514,1) != 0; set { SdkMemory.WriteBits(Pointer,8514,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bIsLocked")]
    public bool @IsLocked { get => SdkMemory.ReadBits(Pointer,8515,1) != 0; set { SdkMemory.WriteBits(Pointer,8515,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bEngineOn")]
    public bool @EngineOn { get => SdkMemory.ReadBits(Pointer,8516,1) != 0; set { SdkMemory.WriteBits(Pointer,8516,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bIsHandbrakeOn")]
    public bool @IsHandbrakeOn { get => SdkMemory.ReadBits(Pointer,8517,1) != 0; set { SdkMemory.WriteBits(Pointer,8517,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bLightsOn")]
    public bool @LightsOn { get => SdkMemory.ReadBits(Pointer,8518,1) != 0; set { SdkMemory.WriteBits(Pointer,8518,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bFreebies")]
    public bool @Freebies { get => SdkMemory.ReadBits(Pointer,8519,1) != 0; set { SdkMemory.WriteBits(Pointer,8519,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bIsVan")]
    public bool @IsVan { get => SdkMemory.ReadBits(Pointer,8520,1) != 0; set { SdkMemory.WriteBits(Pointer,8520,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bIsBus")]
    public bool @IsBus { get => SdkMemory.ReadBits(Pointer,8521,1) != 0; set { SdkMemory.WriteBits(Pointer,8521,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bIsBig")]
    public bool @IsBig { get => SdkMemory.ReadBits(Pointer,8522,1) != 0; set { SdkMemory.WriteBits(Pointer,8522,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bLowVehicle")]
    public bool @LowVehicle { get => SdkMemory.ReadBits(Pointer,8523,1) != 0; set { SdkMemory.WriteBits(Pointer,8523,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bComedyControls")]
    public bool @ComedyControls { get => SdkMemory.ReadBits(Pointer,8524,1) != 0; set { SdkMemory.WriteBits(Pointer,8524,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bWarnedPeds")]
    public bool @WarnedPeds { get => SdkMemory.ReadBits(Pointer,8525,1) != 0; set { SdkMemory.WriteBits(Pointer,8525,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bCraneMessageDone")]
    public bool @CraneMessageDone { get => SdkMemory.ReadBits(Pointer,8526,1) != 0; set { SdkMemory.WriteBits(Pointer,8526,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bTakeLessDamage")]
    public bool @TakeLessDamage { get => SdkMemory.ReadBits(Pointer,8527,1) != 0; set { SdkMemory.WriteBits(Pointer,8527,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bIsDamaged")]
    public bool @IsDamaged { get => SdkMemory.ReadBits(Pointer,8528,1) != 0; set { SdkMemory.WriteBits(Pointer,8528,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bHasBeenOwnedByPlayer")]
    public bool @HasBeenOwnedByPlayer { get => SdkMemory.ReadBits(Pointer,8529,1) != 0; set { SdkMemory.WriteBits(Pointer,8529,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bFadeOut")]
    public bool @FadeOut { get => SdkMemory.ReadBits(Pointer,8530,1) != 0; set { SdkMemory.WriteBits(Pointer,8530,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bIsBeingCarJacked")]
    public bool @IsBeingCarJacked { get => SdkMemory.ReadBits(Pointer,8531,1) != 0; set { SdkMemory.WriteBits(Pointer,8531,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bCreateRoadBlockPeds")]
    public bool @CreateRoadBlockPeds { get => SdkMemory.ReadBits(Pointer,8532,1) != 0; set { SdkMemory.WriteBits(Pointer,8532,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bCanBeDamaged")]
    public bool @CanBeDamaged { get => SdkMemory.ReadBits(Pointer,8533,1) != 0; set { SdkMemory.WriteBits(Pointer,8533,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bOccupantsHaveBeenGenerated")]
    public bool @OccupantsHaveBeenGenerated { get => SdkMemory.ReadBits(Pointer,8534,1) != 0; set { SdkMemory.WriteBits(Pointer,8534,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bGunSwitchedOff")]
    public bool @GunSwitchedOff { get => SdkMemory.ReadBits(Pointer,8535,1) != 0; set { SdkMemory.WriteBits(Pointer,8535,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bVehicleColProcessed")]
    public bool @VehicleCollisionProcessed { get => SdkMemory.ReadBits(Pointer,8536,1) != 0; set { SdkMemory.WriteBits(Pointer,8536,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bIsCarParkVehicle")]
    public bool @IsCarParkVehicle { get => SdkMemory.ReadBits(Pointer,8537,1) != 0; set { SdkMemory.WriteBits(Pointer,8537,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bHasAlreadyBeenRecorded")]
    public bool @HasAlreadyBeenRecorded { get => SdkMemory.ReadBits(Pointer,8538,1) != 0; set { SdkMemory.WriteBits(Pointer,8538,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bPartOfConvoy")]
    public bool @PartOfConvoy { get => SdkMemory.ReadBits(Pointer,8539,1) != 0; set { SdkMemory.WriteBits(Pointer,8539,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bHeliMinimumTilt")]
    public bool @HeliMinimumTilt { get => SdkMemory.ReadBits(Pointer,8540,1) != 0; set { SdkMemory.WriteBits(Pointer,8540,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bAudioChangingGear")]
    public bool @AudioChangingGear { get => SdkMemory.ReadBits(Pointer,8541,1) != 0; set { SdkMemory.WriteBits(Pointer,8541,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bIsDrowning")]
    public bool @IsDrowning { get => SdkMemory.ReadBits(Pointer,8542,1) != 0; set { SdkMemory.WriteBits(Pointer,8542,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bTyresDontBurst")]
    public bool @TyresDontBurst { get => SdkMemory.ReadBits(Pointer,8543,1) != 0; set { SdkMemory.WriteBits(Pointer,8543,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bCreatedAsPoliceVehicle")]
    public bool @CreatedAsPoliceVehicle { get => SdkMemory.ReadBits(Pointer,8544,1) != 0; set { SdkMemory.WriteBits(Pointer,8544,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bRestingOnPhysical")]
    public bool @RestingOnPhysical { get => SdkMemory.ReadBits(Pointer,8545,1) != 0; set { SdkMemory.WriteBits(Pointer,8545,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bParking")]
    public bool @Parking { get => SdkMemory.ReadBits(Pointer,8546,1) != 0; set { SdkMemory.WriteBits(Pointer,8546,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bCanPark")]
    public bool @CanPark { get => SdkMemory.ReadBits(Pointer,8547,1) != 0; set { SdkMemory.WriteBits(Pointer,8547,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bFireGun")]
    public bool @FireGun { get => SdkMemory.ReadBits(Pointer,8548,1) != 0; set { SdkMemory.WriteBits(Pointer,8548,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bDriverLastFrame")]
    public bool @DriverLastFrame { get => SdkMemory.ReadBits(Pointer,8549,1) != 0; set { SdkMemory.WriteBits(Pointer,8549,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bNeverUseSmallerRemovalRange")]
    public bool @NeverUseSmallerRemovalRange { get => SdkMemory.ReadBits(Pointer,8550,1) != 0; set { SdkMemory.WriteBits(Pointer,8550,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bIsRCVehicle")]
    public bool @IsRCVehicle { get => SdkMemory.ReadBits(Pointer,8551,1) != 0; set { SdkMemory.WriteBits(Pointer,8551,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bAlwaysSkidMarks")]
    public bool @AlwaysSkidMarks { get => SdkMemory.ReadBits(Pointer,8552,1) != 0; set { SdkMemory.WriteBits(Pointer,8552,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bEngineBroken")]
    public bool @EngineBroken { get => SdkMemory.ReadBits(Pointer,8553,1) != 0; set { SdkMemory.WriteBits(Pointer,8553,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bVehicleCanBeTargetted")]
    public bool @VehicleCanBeTargetted { get => SdkMemory.ReadBits(Pointer,8554,1) != 0; set { SdkMemory.WriteBits(Pointer,8554,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bPartOfAttackWave")]
    public bool @PartOfAttackWave { get => SdkMemory.ReadBits(Pointer,8555,1) != 0; set { SdkMemory.WriteBits(Pointer,8555,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bWinchCanPickMeUp")]
    public bool @WinchCanPickMeUp { get => SdkMemory.ReadBits(Pointer,8556,1) != 0; set { SdkMemory.WriteBits(Pointer,8556,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bImpounded")]
    public bool @Impounded { get => SdkMemory.ReadBits(Pointer,8557,1) != 0; set { SdkMemory.WriteBits(Pointer,8557,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bVehicleCanBeTargettedByHS")]
    public bool @VehicleCanBeTargettedByHS { get => SdkMemory.ReadBits(Pointer,8558,1) != 0; set { SdkMemory.WriteBits(Pointer,8558,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bSirenOrAlarm")]
    public bool @SirenOrAlarm { get => SdkMemory.ReadBits(Pointer,8559,1) != 0; set { SdkMemory.WriteBits(Pointer,8559,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bHasGangLeaningOn")]
    public bool @HasGangLeaningOn { get => SdkMemory.ReadBits(Pointer,8560,1) != 0; set { SdkMemory.WriteBits(Pointer,8560,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bGangMembersForRoadBlock")]
    public bool @GangMembersForRoadBlock { get => SdkMemory.ReadBits(Pointer,8561,1) != 0; set { SdkMemory.WriteBits(Pointer,8561,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bDoesProvideCover")]
    public bool @DoesProvideCover { get => SdkMemory.ReadBits(Pointer,8562,1) != 0; set { SdkMemory.WriteBits(Pointer,8562,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bMadDriver")]
    public bool @MadDriver { get => SdkMemory.ReadBits(Pointer,8563,1) != 0; set { SdkMemory.WriteBits(Pointer,8563,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bUpgradedStereo")]
    public bool @UpgradedStereo { get => SdkMemory.ReadBits(Pointer,8564,1) != 0; set { SdkMemory.WriteBits(Pointer,8564,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bConsideredByPlayer")]
    public bool @ConsideredByPlayer { get => SdkMemory.ReadBits(Pointer,8565,1) != 0; set { SdkMemory.WriteBits(Pointer,8565,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bPetrolTankIsWeakPoint")]
    public bool @PetrolTankIsWeakPoint { get => SdkMemory.ReadBits(Pointer,8566,1) != 0; set { SdkMemory.WriteBits(Pointer,8566,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bDisableParticles")]
    public bool @DisableParticles { get => SdkMemory.ReadBits(Pointer,8567,1) != 0; set { SdkMemory.WriteBits(Pointer,8567,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bHasBeenResprayed")]
    public bool @HasBeenResprayed { get => SdkMemory.ReadBits(Pointer,8568,1) != 0; set { SdkMemory.WriteBits(Pointer,8568,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bUseCarCheats")]
    public bool @UseCarCheats { get => SdkMemory.ReadBits(Pointer,8569,1) != 0; set { SdkMemory.WriteBits(Pointer,8569,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bDontSetColourWhenRemapping")]
    public bool @DontSetColorWhenRemapping { get => SdkMemory.ReadBits(Pointer,8570,1) != 0; set { SdkMemory.WriteBits(Pointer,8570,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bUsedForReplay")]
    public bool @UsedForReplay { get => SdkMemory.ReadBits(Pointer,8571,1) != 0; set { SdkMemory.WriteBits(Pointer,8571,1,(value ? 1UL : 0UL)); } }
    [NativeMember("m_nCreationTime")]
    public uint @CreationTime { get => SdkMemory.Read<uint >(Pointer+1072); set { SdkMemory.Write(Pointer+1072,value); } }
    [NativeMember("m_nPrimaryColor")]
    public byte @PrimaryColor { get => SdkMemory.Read<byte >(Pointer+1076); set { SdkMemory.Write(Pointer+1076,value); } }
    [NativeMember("m_nSecondaryColor")]
    public byte @SecondaryColor { get => SdkMemory.Read<byte >(Pointer+1077); set { SdkMemory.Write(Pointer+1077,value); } }
    [NativeMember("m_nTertiaryColor")]
    public byte @TertiaryColor { get => SdkMemory.Read<byte >(Pointer+1078); set { SdkMemory.Write(Pointer+1078,value); } }
    [NativeMember("m_nQuaternaryColor")]
    public byte @QuaternaryColor { get => SdkMemory.Read<byte >(Pointer+1079); set { SdkMemory.Write(Pointer+1079,value); } }
    [NativeMember("m_anExtras")]
    public NativeArray<sbyte> @Extras { get => new NativeArray<sbyte>(Pointer+1080,2); }
    [NativeMember("m_anUpgrades")]
    public NativeArray<short> @Upgrades { get => new NativeArray<short>(Pointer+1082,15); }
    [NativeMember("m_fWheelScale")]
    public float @WheelScale { get => SdkMemory.Read<float >(Pointer+1112); set { SdkMemory.Write(Pointer+1112,value); } }
    [NativeMember("m_nAlarmState")]
    public ushort @AlarmState { get => SdkMemory.Read<ushort >(Pointer+1116); set { SdkMemory.Write(Pointer+1116,value); } }
    [NativeMember("m_nForcedRandomRouteSeed")]
    public short @ForcedRandomRouteSeed { get => SdkMemory.Read<short >(Pointer+1118); set { SdkMemory.Write(Pointer+1118,value); } }
    [NativeMember("m_pDriver")]
    public CPed? @Driver { get => SdkMemory.Read<IntPtr>(Pointer+1120) == IntPtr.Zero ? null : new CPed(SdkMemory.Read<IntPtr>(Pointer+1120)); set { SdkMemory.Write(Pointer+1120,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_apPassengers")]
    public NativeArray<IntPtr> @Passengers { get => new NativeArray<IntPtr>(Pointer+1124,8); }
    [NativeMember("m_nNumPassengers")]
    public byte @CountPassengers { get => SdkMemory.Read<byte >(Pointer+1156); set { SdkMemory.Write(Pointer+1156,value); } }
    [NativeMember("m_nNumGettingIn")]
    public byte @CountGettingIn { get => SdkMemory.Read<byte >(Pointer+1157); set { SdkMemory.Write(Pointer+1157,value); } }
    [NativeMember("m_nGettingInFlags")]
    public byte @GettingInFlags { get => SdkMemory.Read<byte >(Pointer+1158); set { SdkMemory.Write(Pointer+1158,value); } }
    [NativeMember("m_nGettingOutFlags")]
    public byte @GettingOutFlags { get => SdkMemory.Read<byte >(Pointer+1159); set { SdkMemory.Write(Pointer+1159,value); } }
    [NativeMember("m_nMaxPassengers")]
    public byte @MaxPassengers { get => SdkMemory.Read<byte >(Pointer+1160); set { SdkMemory.Write(Pointer+1160,value); } }
    [NativeMember("m_nWindowsOpenFlags")]
    public byte @WindowsOpenFlags { get => SdkMemory.Read<byte >(Pointer+1161); set { SdkMemory.Write(Pointer+1161,value); } }
    [NativeMember("m_nNitroBoosts")]
    public byte @NitroBoosts { get => SdkMemory.Read<byte >(Pointer+1162); set { SdkMemory.Write(Pointer+1162,value); } }
    [NativeMember("m_nSpecialColModel")]
    public byte @SpecialCollisionModel { get => SdkMemory.Read<byte >(Pointer+1163); set { SdkMemory.Write(Pointer+1163,value); } }
    [NativeMember("m_pEntityWeAreOn")]
    public CEntity? @EntityWeAreOn { get => SdkMemory.Read<IntPtr>(Pointer+1164) == IntPtr.Zero ? null : new CEntity(SdkMemory.Read<IntPtr>(Pointer+1164)); set { SdkMemory.Write(Pointer+1164,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_pFire")]
    public CFire? @Fire { get => SdkMemory.Read<IntPtr>(Pointer+1168) == IntPtr.Zero ? null : new CFire(SdkMemory.Read<IntPtr>(Pointer+1168)); set { SdkMemory.Write(Pointer+1168,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_fSteerAngle")]
    public float @SteerAngle { get => SdkMemory.Read<float >(Pointer+1172); set { SdkMemory.Write(Pointer+1172,value); } }
    [NativeMember("m_f2ndSteerAngle")]
    public float @F2ndSteerAngle { get => SdkMemory.Read<float >(Pointer+1176); set { SdkMemory.Write(Pointer+1176,value); } }
    [NativeMember("m_fGasPedal")]
    public float @GasPedal { get => SdkMemory.Read<float >(Pointer+1180); set { SdkMemory.Write(Pointer+1180,value); } }
    [NativeMember("m_fBreakPedal")]
    public float @BreakPedal { get => SdkMemory.Read<float >(Pointer+1184); set { SdkMemory.Write(Pointer+1184,value); } }
    [NativeMember("m_nCreatedBy")]
    public byte @CreatedBy { get => SdkMemory.Read<byte >(Pointer+1188); set { SdkMemory.Write(Pointer+1188,value); } }
    [NativeMember("m_nExtendedRemovalRange")]
    public short @ExtendedRemovalRange { get => SdkMemory.Read<short >(Pointer+1190); set { SdkMemory.Write(Pointer+1190,value); } }
    [NativeMember("m_nBombOnBoard")]
    public byte @BombOnBoard { get => (byte)SdkMemory.ReadBits(Pointer,9536,3); set { SdkMemory.WriteBits(Pointer,9536,3,unchecked((ulong)value)); } }
    [NativeMember("m_nOverrideLights")]
    public byte @OverrideLights { get => (byte)SdkMemory.ReadBits(Pointer,9539,2); set { SdkMemory.WriteBits(Pointer,9539,2,unchecked((ulong)value)); } }
    [NativeMember("m_nWinchType")]
    public byte @WinchType { get => (byte)SdkMemory.ReadBits(Pointer,9541,2); set { SdkMemory.WriteBits(Pointer,9541,2,unchecked((ulong)value)); } }
    [NativeMember("m_nGunsCycleIndex")]
    public byte @GunsCycleIndex { get => (byte)SdkMemory.ReadBits(Pointer,9544,2); set { SdkMemory.WriteBits(Pointer,9544,2,unchecked((ulong)value)); } }
    [NativeMember("m_nOrdnanceCycleIndex")]
    public byte @OrdnanceCycleIndex { get => (byte)SdkMemory.ReadBits(Pointer,9546,2); set { SdkMemory.WriteBits(Pointer,9546,2,unchecked((ulong)value)); } }
    [NativeMember("m_nUsedForCover")]
    public byte @UsedForCover { get => SdkMemory.Read<byte >(Pointer+1194); set { SdkMemory.Write(Pointer+1194,value); } }
    [NativeMember("m_nAmmoInClip")]
    public byte @AmmoInClip { get => SdkMemory.Read<byte >(Pointer+1195); set { SdkMemory.Write(Pointer+1195,value); } }
    [NativeMember("m_nPacMansCollected")]
    public byte @PacMansCollected { get => SdkMemory.Read<byte >(Pointer+1196); set { SdkMemory.Write(Pointer+1196,value); } }
    [NativeMember("m_nPedsPositionForRoadBlock")]
    public byte @PedsPositionForRoadBlock { get => SdkMemory.Read<byte >(Pointer+1197); set { SdkMemory.Write(Pointer+1197,value); } }
    [NativeMember("m_nNumCopsForRoadBlock")]
    public byte @CountCopsForRoadBlock { get => SdkMemory.Read<byte >(Pointer+1198); set { SdkMemory.Write(Pointer+1198,value); } }
    [NativeMember("m_fDirtLevel")]
    public float @DirtLevel { get => SdkMemory.Read<float >(Pointer+1200); set { SdkMemory.Write(Pointer+1200,value); } }
    [NativeMember("m_nCurrentGear")]
    public byte @CurrentGear { get => SdkMemory.Read<byte >(Pointer+1204); set { SdkMemory.Write(Pointer+1204,value); } }
    [NativeMember("m_fGearChangeCount")]
    public float @GearChangeCount { get => SdkMemory.Read<float >(Pointer+1208); set { SdkMemory.Write(Pointer+1208,value); } }
    [NativeMember("m_fWheelSpinForAudio")]
    public float @WheelSpinForAudio { get => SdkMemory.Read<float >(Pointer+1212); set { SdkMemory.Write(Pointer+1212,value); } }
    [NativeMember("m_fHealth")]
    public float @Health { get => SdkMemory.Read<float >(Pointer+1216); set { SdkMemory.Write(Pointer+1216,value); } }
    [NativeMember("m_pTractor")]
    public CVehicle? @Tractor { get => SdkMemory.Read<IntPtr>(Pointer+1220) == IntPtr.Zero ? null : new CVehicle(SdkMemory.Read<IntPtr>(Pointer+1220)); set { SdkMemory.Write(Pointer+1220,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_pTrailer")]
    public CVehicle? @Trailer { get => SdkMemory.Read<IntPtr>(Pointer+1224) == IntPtr.Zero ? null : new CVehicle(SdkMemory.Read<IntPtr>(Pointer+1224)); set { SdkMemory.Write(Pointer+1224,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_pWhoInstalledBombOnMe")]
    public CPed? @WhoInstalledBombOnMe { get => SdkMemory.Read<IntPtr>(Pointer+1228) == IntPtr.Zero ? null : new CPed(SdkMemory.Read<IntPtr>(Pointer+1228)); set { SdkMemory.Write(Pointer+1228,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_nTimeTillWeNeedThisCar")]
    public uint @TimeTillWeNeedThisCar { get => SdkMemory.Read<uint >(Pointer+1232); set { SdkMemory.Write(Pointer+1232,value); } }
    [NativeMember("m_nGunFiringTime")]
    public uint @GunFiringTime { get => SdkMemory.Read<uint >(Pointer+1236); set { SdkMemory.Write(Pointer+1236,value); } }
    [NativeMember("m_nTimeWhenBlowedUp")]
    public uint @TimeWhenBlowedUp { get => SdkMemory.Read<uint >(Pointer+1240); set { SdkMemory.Write(Pointer+1240,value); } }
    [NativeMember("m_nCopsInCarTimer")]
    public short @CopsInCarTimer { get => SdkMemory.Read<short >(Pointer+1244); set { SdkMemory.Write(Pointer+1244,value); } }
    [NativeMember("m_wBombTimer")]
    public short @BombTimer { get => SdkMemory.Read<short >(Pointer+1246); set { SdkMemory.Write(Pointer+1246,value); } }
    [NativeMember("m_pWhoDetonatedMe")]
    public CPed? @WhoDetonatedMe { get => SdkMemory.Read<IntPtr>(Pointer+1248) == IntPtr.Zero ? null : new CPed(SdkMemory.Read<IntPtr>(Pointer+1248)); set { SdkMemory.Write(Pointer+1248,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_fVehicleFrontGroundZ")]
    public float @VehicleFrontGroundZ { get => SdkMemory.Read<float >(Pointer+1252); set { SdkMemory.Write(Pointer+1252,value); } }
    [NativeMember("m_fVehicleRearGroundZ")]
    public float @VehicleRearGroundZ { get => SdkMemory.Read<float >(Pointer+1256); set { SdkMemory.Write(Pointer+1256,value); } }
    [NativeMember("field_4EC")]
    public sbyte @Field4EC { get => SdkMemory.Read<sbyte >(Pointer+1260); set { SdkMemory.Write(Pointer+1260,value); } }
    [NativeMember("field_4ED")]
    public NativeArray<sbyte> @Field4ED { get => new NativeArray<sbyte>(Pointer+1261,11); }
    [NativeMember("m_eDoorLock")]
    public eDoorLock @EDoorLock { get => SdkMemory.Read<eDoorLock >(Pointer+1272); set { SdkMemory.Write(Pointer+1272,value); } }
    [NativeMember("m_nProjectileWeaponFiringTime")]
    public uint @ProjectileWeaponFiringTime { get => SdkMemory.Read<uint >(Pointer+1276); set { SdkMemory.Write(Pointer+1276,value); } }
    [NativeMember("m_nAdditionalProjectileWeaponFiringTime")]
    public uint @AdditionalProjectileWeaponFiringTime { get => SdkMemory.Read<uint >(Pointer+1280); set { SdkMemory.Write(Pointer+1280,value); } }
    [NativeMember("m_nTimeForMinigunFiring")]
    public uint @TimeForMinigunFiring { get => SdkMemory.Read<uint >(Pointer+1284); set { SdkMemory.Write(Pointer+1284,value); } }
    [NativeMember("m_nLastWeaponDamageType")]
    public byte @LastWeaponDamageType { get => SdkMemory.Read<byte >(Pointer+1288); set { SdkMemory.Write(Pointer+1288,value); } }
    [NativeMember("m_pLastDamageEntity")]
    public CEntity? @LastDamageEntity { get => SdkMemory.Read<IntPtr>(Pointer+1292) == IntPtr.Zero ? null : new CEntity(SdkMemory.Read<IntPtr>(Pointer+1292)); set { SdkMemory.Write(Pointer+1292,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("field_510")]
    public sbyte @Field510 { get => SdkMemory.Read<sbyte >(Pointer+1296); set { SdkMemory.Write(Pointer+1296,value); } }
    [NativeMember("field_511")]
    public sbyte @Field511 { get => SdkMemory.Read<sbyte >(Pointer+1297); set { SdkMemory.Write(Pointer+1297,value); } }
    [NativeMember("field_512")]
    public sbyte @Field512 { get => SdkMemory.Read<sbyte >(Pointer+1298); set { SdkMemory.Write(Pointer+1298,value); } }
    [NativeMember("m_nVehicleWeaponInUse")]
    public sbyte @VehicleWeaponInUse { get => SdkMemory.Read<sbyte >(Pointer+1299); set { SdkMemory.Write(Pointer+1299,value); } }
    [NativeMember("m_nHornCounter")]
    public uint @HornCounter { get => SdkMemory.Read<uint >(Pointer+1300); set { SdkMemory.Write(Pointer+1300,value); } }
    [NativeMember("m_HornPattern")]
    public sbyte @HornPattern { get => SdkMemory.Read<sbyte >(Pointer+1304); set { SdkMemory.Write(Pointer+1304,value); } }
    [NativeMember("m_nCarHornTimer")]
    public sbyte @CarHornTimer { get => SdkMemory.Read<sbyte >(Pointer+1305); set { SdkMemory.Write(Pointer+1305,value); } }
    [NativeMember("m_comedyControlState")]
    public eComedyControlState @ComedyControlState { get => SdkMemory.Read<eComedyControlState >(Pointer+1306); set { SdkMemory.Write(Pointer+1306,value); } }
    [NativeMember("m_nHasslePosId")]
    public sbyte @HasslePositionId { get => SdkMemory.Read<sbyte >(Pointer+1307); set { SdkMemory.Write(Pointer+1307,value); } }
    [NativeMember("m_FrontCollPoly")]
    public CStoredCollPoly @FrontCollPoly { get => new CStoredCollPoly(Pointer+1308); set { SdkMemory.Copy(value.Pointer,Pointer+1308,44); } }
    [NativeMember("m_RearCollPoly")]
    public CStoredCollPoly @RearCollPoly { get => new CStoredCollPoly(Pointer+1352); set { SdkMemory.Copy(value.Pointer,Pointer+1352,44); } }
    [NativeMember("m_anCollisionLighting")]
    public NativeArray<byte> @CollisionLighting { get => new NativeArray<byte>(Pointer+1396,4); }
    [NativeMember("m_pOverheatParticle")]
    public FxSystem_c? @OverheatParticle { get => SdkMemory.Read<IntPtr>(Pointer+1400) == IntPtr.Zero ? null : new FxSystem_c(SdkMemory.Read<IntPtr>(Pointer+1400)); set { SdkMemory.Write(Pointer+1400,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_pFireParticle")]
    public FxSystem_c? @FireParticle { get => SdkMemory.Read<IntPtr>(Pointer+1404) == IntPtr.Zero ? null : new FxSystem_c(SdkMemory.Read<IntPtr>(Pointer+1404)); set { SdkMemory.Write(Pointer+1404,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_pDustParticle")]
    public FxSystem_c? @DustParticle { get => SdkMemory.Read<IntPtr>(Pointer+1408) == IntPtr.Zero ? null : new FxSystem_c(SdkMemory.Read<IntPtr>(Pointer+1408)); set { SdkMemory.Write(Pointer+1408,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_pCustomCarPlate")]
    public RwTexture? @CustomCarPlate { get => SdkMemory.Read<IntPtr>(Pointer+1416) == IntPtr.Zero ? null : new RwTexture(SdkMemory.Read<IntPtr>(Pointer+1416)); set { SdkMemory.Write(Pointer+1416,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_fRawSteerAngle")]
    public float @RawSteerAngle { get => SdkMemory.Read<float >(Pointer+1420); set { SdkMemory.Write(Pointer+1420,value); } }
    [NativeMember("m_nVehicleClass")]
    public eVehicleType @VehicleClass { get => SdkMemory.Read<eVehicleType >(Pointer+1424); set { SdkMemory.Write(Pointer+1424,value); } }
    [NativeMember("m_nVehicleSubClass")]
    public eVehicleType @VehicleSubClass { get => SdkMemory.Read<eVehicleType >(Pointer+1428); set { SdkMemory.Write(Pointer+1428,value); } }
    [NativeMember("m_nPreviousRemapTxd")]
    public short @PreviousRemapTxd { get => SdkMemory.Read<short >(Pointer+1432); set { SdkMemory.Write(Pointer+1432,value); } }
    [NativeMember("m_nRemapTxd")]
    public short @RemapTxd { get => SdkMemory.Read<short >(Pointer+1434); set { SdkMemory.Write(Pointer+1434,value); } }
    [NativeMember("m_pRemapTexture")]
    public RwTexture? @RemapTexture { get => SdkMemory.Read<IntPtr>(Pointer+1436) == IntPtr.Zero ? null : new RwTexture(SdkMemory.Read<IntPtr>(Pointer+1436)); set { SdkMemory.Write(Pointer+1436,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("WHEELSPIN_TARGET_RATE")]
    public static float @WHEELSPINTARGETRATE { get => SdkMemory.Read<float >(new IntPtr(0x8D3498)); set { SdkMemory.Write(new IntPtr(0x8D3498),value); } }
    [NativeMember("WHEELSPIN_INAIR_TARGET_RATE")]
    public static float @WHEELSPININAIRTARGETRATE { get => SdkMemory.Read<float >(new IntPtr(0x8D349C)); set { SdkMemory.Write(new IntPtr(0x8D349C),value); } }
    [NativeMember("WHEELSPIN_RISE_RATE")]
    public static float @WHEELSPINRISERATE { get => SdkMemory.Read<float >(new IntPtr(0x8D34A0)); set { SdkMemory.Write(new IntPtr(0x8D34A0),value); } }
    [NativeMember("WHEELSPIN_FALL_RATE")]
    public static float @WHEELSPINFALLRATE { get => SdkMemory.Read<float >(new IntPtr(0x8D34A4)); set { SdkMemory.Write(new IntPtr(0x8D34A4),value); } }
    [NativeMember("m_fAirResistanceMult")]
    public static float @AirResistanceMult { get => SdkMemory.Read<float >(new IntPtr(0x8D34A8)); set { SdkMemory.Write(new IntPtr(0x8D34A8),value); } }
    [NativeMember("ms_fRailTrackResistance")]
    public static float @RailTrackResistance { get => SdkMemory.Read<float >(new IntPtr(0x8D34AC)); set { SdkMemory.Write(new IntPtr(0x8D34AC),value); } }
    [NativeMember("ms_fRailTrackResistanceDefault")]
    public static float @RailTrackResistanceDefault { get => SdkMemory.Read<float >(new IntPtr(0x8D34B0)); set { SdkMemory.Write(new IntPtr(0x8D34B0),value); } }
    [NativeMember("bDisableRemoteDetonation")]
    public static bool @DisableRemoteDetonation { get => SdkMemory.Read<bool >(new IntPtr(0xC1CC00)); set { SdkMemory.Write(new IntPtr(0xC1CC00),value); } }
    [NativeMember("bDisableRemoteDetonationOnContact")]
    public static bool @DisableRemoteDetonationOnContact { get => SdkMemory.Read<bool >(new IntPtr(0xC1CC01)); set { SdkMemory.Write(new IntPtr(0xC1CC01),value); } }
    [NativeMember("m_bEnableMouseSteering")]
    public static bool @EnableMouseSteering { get => SdkMemory.Read<bool >(new IntPtr(0xC1CC02)); set { SdkMemory.Write(new IntPtr(0xC1CC02),value); } }
    [NativeMember("m_bEnableMouseFlying")]
    public static bool @EnableMouseFlying { get => SdkMemory.Read<bool >(new IntPtr(0xC1CC03)); set { SdkMemory.Write(new IntPtr(0xC1CC03),value); } }
    [NativeMember("m_nLastControlInput")]
    public static int @LastControlInput { get => SdkMemory.Read<int >(new IntPtr(0xC1CC04)); set { SdkMemory.Write(new IntPtr(0xC1CC04),value); } }
    [NativeMember("m_aSpecialColVehicle")]
    public static NativePointer<IntPtr> @SpecialCollisionVehicle { get => new NativePointer<IntPtr>(new IntPtr(0xC1CC08)); }
    [NativeMember("ms_forceVehicleLightsOff")]
    public static bool @ForceVehicleLightsOff { get => SdkMemory.Read<bool >(new IntPtr(0xC1CC18)); set { SdkMemory.Write(new IntPtr(0xC1CC18),value); } }
    [NativeMember("s_bPlaneGunsEjectShellCasings")]
    public static bool @PlaneGunsEjectShellCasings { get => SdkMemory.Read<bool >(new IntPtr(0xC1CC19)); set { SdkMemory.Write(new IntPtr(0xC1CC19),value); } }
    [NativeMember("m_aSpecialColModel")]
    public static CColModel? @SpecialCollisionModelValue { get => new IntPtr(0xC1CC78) == IntPtr.Zero ? null : new CColModel(new IntPtr(0xC1CC78)); }
    public void @ProcessControlCollisionCheck() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D945 >(945)(Pointer); }
    public void @ProcessControlInputs(byte @playerNum) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D946 >(946)(Pointer,@playerNum); }
    public void @GetComponentWorldPosition(int @componentId,CVector @posnOut) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D947 >(947)(Pointer,@componentId,@posnOut.Pointer); }
    public bool @IsComponentPresent(int @componentId) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D948 >(948)(Pointer,@componentId); return __sdkResult != 0; }
    public void @OpenDoor(CPed? @ped,int @componentId,eDoors @door,float @doorOpenRatio,bool @playSound) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D949 >(949)(Pointer,@ped?.Pointer ?? IntPtr.Zero,@componentId,(int)@door,@doorOpenRatio,(@playSound ? 1 : 0)); }
    public void @ProcessOpenDoor(CPed? @ped,uint @doorComponentId,uint @arg2,uint @arg3,float @arg4) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D950 >(950)(Pointer,@ped?.Pointer ?? IntPtr.Zero,@doorComponentId,@arg2,@arg3,@arg4); }
    public float @GetDooorAngleOpenRatio(uint @door) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D951 >(951)(Pointer,@door); return __sdkResult; }
    public float @GetDooorAngleOpenRatio(eDoors @door) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D952 >(952)(Pointer,(int)@door); return __sdkResult; }
    public bool @IsDoorReady(uint @door) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D953 >(953)(Pointer,@door); return __sdkResult != 0; }
    public bool @IsDoorReady(eDoors @door) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D954 >(954)(Pointer,(int)@door); return __sdkResult != 0; }
    public bool @IsDoorFullyOpen(uint @door) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D955 >(955)(Pointer,@door); return __sdkResult != 0; }
    public bool @IsDoorFullyOpen(eDoors @door) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D956 >(956)(Pointer,(int)@door); return __sdkResult != 0; }
    public bool @IsDoorClosed(uint @door) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D957 >(957)(Pointer,@door); return __sdkResult != 0; }
    public bool @IsDoorClosed(eDoors @door) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D958 >(958)(Pointer,(int)@door); return __sdkResult != 0; }
    public bool @IsDoorMissing(uint @door) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D959 >(959)(Pointer,@door); return __sdkResult != 0; }
    public bool @IsDoorMissing(eDoors @door) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D960 >(960)(Pointer,(int)@door); return __sdkResult != 0; }
    public bool @IsOpenTopCar() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D961 >(961)(Pointer); return __sdkResult != 0; }
    public void @RemoveRefsToVehicle(CEntity? @entity) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D962 >(962)(Pointer,@entity?.Pointer ?? IntPtr.Zero); }
    public void @BlowUpCar(CEntity? @damager,bool @bHideExplosion) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D963 >(963)(Pointer,@damager?.Pointer ?? IntPtr.Zero,(@bHideExplosion ? 1 : 0)); }
    public void @BlowUpCarCutSceneNoExtras(bool @bNoCamShake,bool @bNoSpawnFlyingComps,bool @bDetachWheels,bool @bExplosionSound) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D964 >(964)(Pointer,(@bNoCamShake ? 1 : 0),(@bNoSpawnFlyingComps ? 1 : 0),(@bDetachWheels ? 1 : 0),(@bExplosionSound ? 1 : 0)); }
    public bool @SetUpWheelColModel(CColModel? @wheelCol) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D965 >(965)(Pointer,@wheelCol?.Pointer ?? IntPtr.Zero); return __sdkResult != 0; }
    public bool @BurstTyre(byte @tyreComponentId,bool @bPhysicalEffect) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D966 >(966)(Pointer,@tyreComponentId,(@bPhysicalEffect ? 1 : 0)); return __sdkResult != 0; }
    public bool @IsRoomForPedToLeaveCar(uint @arg0,CVector? @arg1) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D967 >(967)(Pointer,@arg0,@arg1?.Pointer ?? IntPtr.Zero); return __sdkResult != 0; }
    public void @ProcessDrivingAnims(CPed? @driver,byte @arg1) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D968 >(968)(Pointer,@driver?.Pointer ?? IntPtr.Zero,@arg1); }
    public CRideAnimData? @GetRideAnimData() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D969 >(969)(Pointer); return __sdkResult == IntPtr.Zero ? null : new CRideAnimData(__sdkResult); }
    public void @SetupSuspensionLines() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D970 >(970)(Pointer); }
    public CVector @AddMovingCollisionSpeed(CVector @arg0) { Game.CheckThread(); var result=NativeObject.AllocateStorage<CVector >(12); try { SdkBindings.Get<GeneratedDelegates.D971 >(971)(Pointer,@arg0.Pointer,result.Pointer); return result; } catch { result.Dispose(); throw; } }
    public void @Fix() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D972 >(972)(Pointer); }
    public void @SetupDamageAfterLoad() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D973 >(973)(Pointer); }
    public void @DoBurstAndSoftGroundRatios() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D974 >(974)(Pointer); }
    public float @GetHeightAboveRoad() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D975 >(975)(Pointer); return __sdkResult; }
    public void @PlayCarHorn() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D976 >(976)(Pointer); }
    public int @GetNumContactWheels() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D977 >(977)(Pointer); return __sdkResult; }
    public void @VehicleDamage(float @damageIntensity,ushort @collisionComponent,CEntity? @damager,CVector? @vecCollisionCoors,CVector? @vecCollisionDirection,eWeaponType @weapon) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D978 >(978)(Pointer,@damageIntensity,@collisionComponent,@damager?.Pointer ?? IntPtr.Zero,@vecCollisionCoors?.Pointer ?? IntPtr.Zero,@vecCollisionDirection?.Pointer ?? IntPtr.Zero,(int)@weapon); }
    public bool @CanPedStepOutCar(bool @arg0) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D979 >(979)(Pointer,(@arg0 ? 1 : 0)); return __sdkResult != 0; }
    public bool @CanPedJumpOutCar(CPed? @ped) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D980 >(980)(Pointer,@ped?.Pointer ?? IntPtr.Zero); return __sdkResult != 0; }
    public bool @GetTowHitchPos(CVector @posnOut,bool @arg1,CVehicle? @arg2) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D981 >(981)(Pointer,@posnOut.Pointer,(@arg1 ? 1 : 0),@arg2?.Pointer ?? IntPtr.Zero); return __sdkResult != 0; }
    public bool @GetTowBarPos(CVector @posnOut,bool @arg1,CVehicle? @arg2) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D982 >(982)(Pointer,@posnOut.Pointer,(@arg1 ? 1 : 0),@arg2?.Pointer ?? IntPtr.Zero); return __sdkResult != 0; }
    public bool @SetTowLink(CVehicle? @arg0,bool @arg1) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D983 >(983)(Pointer,@arg0?.Pointer ?? IntPtr.Zero,(@arg1 ? 1 : 0)); return __sdkResult != 0; }
    public bool @BreakTowLink() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D984 >(984)(Pointer); return __sdkResult != 0; }
    public float @FindWheelWidth(bool @bRear) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D985 >(985)(Pointer,(@bRear ? 1 : 0)); return __sdkResult; }
    public bool @Save() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D986 >(986)(Pointer); return __sdkResult != 0; }
    public bool @Load() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D987 >(987)(Pointer); return __sdkResult != 0; }
    public static void @Shutdown() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D988 >(988)(); }
    public int @GetRemapIndex() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D989 >(989)(Pointer); return __sdkResult; }
    public void @SetRemapTexDictionary(int @txdId) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D990 >(990)(Pointer,@txdId); }
    public void @SetRemap(int @remapIndex) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D991 >(991)(Pointer,@remapIndex); }
    public void @SetCollisionLighting(byte @lighting) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D992 >(992)(Pointer,@lighting); }
    public void @UpdateLightingFromStoredPolys() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D993 >(993)(Pointer); }
    public void @CalculateLightingFromCollision() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D994 >(994)(Pointer); }
    public void @ResetAfterRender() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D995 >(995)(Pointer); }
    public int @GetVehicleAppearance() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D996 >(996)(Pointer); return __sdkResult; }
    public bool @CustomCarPlate_TextureCreate(CVehicleModelInfo? @model) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D997 >(997)(Pointer,@model?.Pointer ?? IntPtr.Zero); return __sdkResult != 0; }
    public void @CustomCarPlate_TextureDestroy() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D998 >(998)(Pointer); }
    public bool @CanBeDeleted() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D999 >(999)(Pointer); return __sdkResult != 0; }
    public float @ProcessWheelRotation(int @wheelState,CVector @arg1,CVector @arg2,float @arg3) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1000 >(1000)(Pointer,@wheelState,@arg1.Pointer,@arg2.Pointer,@arg3); return __sdkResult; }
    public bool @CanVehicleBeDamaged(CEntity? @damager,eWeaponType @weapon,NativePointer<byte> @arg2) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1001 >(1001)(Pointer,@damager?.Pointer ?? IntPtr.Zero,(int)@weapon,@arg2.Pointer); return __sdkResult != 0; }
    public void @ProcessDelayedExplosion() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1002 >(1002)(Pointer); }
    public bool @AddPassenger(CPed? @passenger) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1003 >(1003)(Pointer,@passenger?.Pointer ?? IntPtr.Zero); return __sdkResult != 0; }
    public bool @AddPassenger(CPed? @passenger,byte @seatNumber) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1004 >(1004)(Pointer,@passenger?.Pointer ?? IntPtr.Zero,@seatNumber); return __sdkResult != 0; }
    public void @RemovePassenger(CPed? @passenger) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1005 >(1005)(Pointer,@passenger?.Pointer ?? IntPtr.Zero); }
    public void @SetDriver(CPed? @driver) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1006 >(1006)(Pointer,@driver?.Pointer ?? IntPtr.Zero); }
    public void @RemoveDriver(bool @arg0) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1007 >(1007)(Pointer,(@arg0 ? 1 : 0)); }
    public CPed? @SetUpDriver(int @pedType,bool @arg1,bool @arg2) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1008 >(1008)(Pointer,@pedType,(@arg1 ? 1 : 0),(@arg2 ? 1 : 0)); return __sdkResult == IntPtr.Zero ? null : new CPed(__sdkResult); }
    public CPed? @SetupPassenger(int @seatNumber,int @pedType,bool @arg2,bool @arg3) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1009 >(1009)(Pointer,@seatNumber,@pedType,(@arg2 ? 1 : 0),(@arg3 ? 1 : 0)); return __sdkResult == IntPtr.Zero ? null : new CPed(__sdkResult); }
    public bool @IsPassenger(CPed? @ped) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1010 >(1010)(Pointer,@ped?.Pointer ?? IntPtr.Zero); return __sdkResult != 0; }
    public bool @IsPassenger(int @modelIndex) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1011 >(1011)(Pointer,@modelIndex); return __sdkResult != 0; }
    public bool @IsDriver(CPed? @ped) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1012 >(1012)(Pointer,@ped?.Pointer ?? IntPtr.Zero); return __sdkResult != 0; }
    public bool @IsDriver(int @modelIndex) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1013 >(1013)(Pointer,@modelIndex); return __sdkResult != 0; }
    public void @KillPedsInVehicle() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1014 >(1014)(Pointer); }
    public bool @IsUpsideDown() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1015 >(1015)(Pointer); return __sdkResult != 0; }
    public bool @IsOnItsSide() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1016 >(1016)(Pointer); return __sdkResult != 0; }
    public bool @CanPedOpenLocks(CPed? @ped) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1017 >(1017)(Pointer,@ped?.Pointer ?? IntPtr.Zero); return __sdkResult != 0; }
    public bool @CanDoorsBeDamaged() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1018 >(1018)(Pointer); return __sdkResult != 0; }
    public bool @CanPedEnterCar() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1019 >(1019)(Pointer); return __sdkResult != 0; }
    public void @ProcessCarAlarm() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1020 >(1020)(Pointer); }
    public bool @IsVehicleNormal() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1021 >(1021)(Pointer); return __sdkResult != 0; }
    public void @ChangeLawEnforcerState(byte @state) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1022 >(1022)(Pointer,@state); }
    public bool @IsLawEnforcementVehicle() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1023 >(1023)(Pointer); return __sdkResult != 0; }
    public bool @ShufflePassengersToMakeSpace() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1024 >(1024)(Pointer); return __sdkResult != 0; }
    public void @ExtinguishCarFire() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1025 >(1025)(Pointer); }
    public void @ActivateBomb() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1026 >(1026)(Pointer); }
    public void @ActivateBombWhenEntered() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1027 >(1027)(Pointer); }
    public bool @CarHasRoof() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1028 >(1028)(Pointer); return __sdkResult != 0; }
    public float @HeightAboveCeiling(float @arg0,int @arg1) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1029 >(1029)(Pointer,@arg0,@arg1); return __sdkResult; }
    public void @SetComponentVisibility(RwFrame? @component,uint @visibilityState) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1030 >(1030)(Pointer,@component?.Pointer ?? IntPtr.Zero,@visibilityState); }
    public void @ApplyBoatWaterResistance(tBoatHandlingData? @boatHandling,float @arg1) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1031 >(1031)(Pointer,@boatHandling?.Pointer ?? IntPtr.Zero,@arg1); }
    public static void @SetComponentAtomicAlpha(RpAtomic? @atomic,int @alpha) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1032 >(1032)(@atomic?.Pointer ?? IntPtr.Zero,@alpha); }
    public void @UpdateClumpAlpha() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1033 >(1033)(Pointer); }
    public void @UpdatePassengerList() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1034 >(1034)(Pointer); }
    public CPed? @PickRandomPassenger() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1035 >(1035)(Pointer); return __sdkResult == IntPtr.Zero ? null : new CPed(__sdkResult); }
    public void @AddDamagedVehicleParticles() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1036 >(1036)(Pointer); }
    public void @MakeDirty(CColPoint @colPoint) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1037 >(1037)(Pointer,@colPoint.Pointer); }
    public bool @AddWheelDirtAndWater(CColPoint @colPoint,uint @arg1,byte @arg2,byte @arg3) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1038 >(1038)(Pointer,@colPoint.Pointer,@arg1,@arg2,@arg3); return __sdkResult != 0; }
    public void @SetGettingInFlags(byte @doorId) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1039 >(1039)(Pointer,@doorId); }
    public void @SetGettingOutFlags(byte @doorId) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1040 >(1040)(Pointer,@doorId); }
    public void @ClearGettingInFlags(byte @doorId) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1041 >(1041)(Pointer,@doorId); }
    public void @ClearGettingOutFlags(byte @doorId) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1042 >(1042)(Pointer,@doorId); }
    public void @SetWindowOpenFlag(byte @doorId) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1043 >(1043)(Pointer,@doorId); }
    public void @ClearWindowOpenFlag(byte @doorId) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1044 >(1044)(Pointer,@doorId); }
    public bool @SetVehicleUpgradeFlags(int @upgradeModelIndex,int @componentIndex,NativePointer<int> @resultModelIndex) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1045 >(1045)(Pointer,@upgradeModelIndex,@componentIndex,@resultModelIndex.Pointer); return __sdkResult != 0; }
    public bool @ClearVehicleUpgradeFlags(int @arg0,int @componentIndex) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1046 >(1046)(Pointer,@arg0,@componentIndex); return __sdkResult != 0; }
    public RpAtomic? @CreateUpgradeAtomic(CBaseModelInfo? @model,UpgradePosnDesc? @upgradePosn,RwFrame? @parentComponent,bool @isDamaged) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1047 >(1047)(Pointer,@model?.Pointer ?? IntPtr.Zero,@upgradePosn?.Pointer ?? IntPtr.Zero,@parentComponent?.Pointer ?? IntPtr.Zero,(@isDamaged ? 1 : 0)); return __sdkResult == IntPtr.Zero ? null : new RpAtomic(__sdkResult); }
    public void @RemoveUpgrade(int @upgradeId) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1048 >(1048)(Pointer,@upgradeId); }
    public int @GetUpgrade(int @upgradeId) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1049 >(1049)(Pointer,@upgradeId); return __sdkResult; }
    public RpAtomic? @CreateReplacementAtomic(CBaseModelInfo? @model,RwFrame? @component,int @arg2,bool @bDamaged,bool @bIsWheel) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1050 >(1050)(Pointer,@model?.Pointer ?? IntPtr.Zero,@component?.Pointer ?? IntPtr.Zero,@arg2,(@bDamaged ? 1 : 0),(@bIsWheel ? 1 : 0)); return __sdkResult == IntPtr.Zero ? null : new RpAtomic(__sdkResult); }
    public void @AddReplacementUpgrade(int @modelIndex,int @nodeId) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1051 >(1051)(Pointer,@modelIndex,@nodeId); }
    public void @RemoveReplacementUpgrade(int @nodeId) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1052 >(1052)(Pointer,@nodeId); }
    public int @GetReplacementUpgrade(int @nodeId) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1053 >(1053)(Pointer,@nodeId); return __sdkResult; }
    public void @RemoveAllUpgrades() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1054 >(1054)(Pointer); }
    public int @GetSpareHasslePosId() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1055 >(1055)(Pointer); return __sdkResult; }
    public void @SetHasslePosId(int @hasslePos,bool @enable) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1056 >(1056)(Pointer,@hasslePos,(@enable ? 1 : 0)); }
    public void @InitWinch(int @arg0) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1057 >(1057)(Pointer,@arg0); }
    public void @UpdateWinch() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1058 >(1058)(Pointer); }
    public void @RemoveWinch() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1059 >(1059)(Pointer); }
    public void @ReleasePickedUpEntityWithWinch() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1060 >(1060)(Pointer); }
    public void @PickUpEntityWithWinch(CEntity? @arg0) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1061 >(1061)(Pointer,@arg0?.Pointer ?? IntPtr.Zero); }
    public CEntity? @QueryPickedUpEntityWithWinch() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1062 >(1062)(Pointer); return __sdkResult == IntPtr.Zero ? null : new CEntity(__sdkResult); }
    public float @GetRopeHeightForHeli() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1063 >(1063)(Pointer); return __sdkResult; }
    public void @SetRopeHeightForHeli(float @height) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1064 >(1064)(Pointer,@height); }
    public void @RenderDriverAndPassengers() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1065 >(1065)(Pointer); }
    public void @PreRenderDriverAndPassengers() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1066 >(1066)(Pointer); }
    public float @GetPlaneGunsAutoAimAngle() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1067 >(1067)(Pointer); return __sdkResult; }
    public int @GetPlaneNumGuns() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1068 >(1068)(Pointer); return __sdkResult; }
    public void @SetFiringRateMultiplier(float @multiplier) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1069 >(1069)(Pointer,@multiplier); }
    public float @GetFiringRateMultiplier() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1070 >(1070)(Pointer); return __sdkResult; }
    public uint @GetPlaneGunsRateOfFire() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1071 >(1071)(Pointer); return __sdkResult; }
    public CVector @GetPlaneGunsPosition(int @gunId) { Game.CheckThread(); var result=NativeObject.AllocateStorage<CVector >(12); try { SdkBindings.Get<GeneratedDelegates.D1072 >(1072)(Pointer,@gunId,result.Pointer); return result; } catch { result.Dispose(); throw; } }
    public uint @GetPlaneOrdnanceRateOfFire(int @ordnanceType) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1073 >(1073)(Pointer,@ordnanceType); return __sdkResult; }
    public CVector @GetPlaneOrdnancePosition(int @ordnanceType) { Game.CheckThread(); var result=NativeObject.AllocateStorage<CVector >(12); try { SdkBindings.Get<GeneratedDelegates.D1074 >(1074)(Pointer,@ordnanceType,result.Pointer); return result; } catch { result.Dispose(); throw; } }
    public void @SelectPlaneWeapon(bool @bChange,int @ordnanceType) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1075 >(1075)(Pointer,(@bChange ? 1 : 0),@ordnanceType); }
    public void @DoPlaneGunFireFX(CWeapon? @weapon,CVector @particlePos,CVector @gunshellPos,int @particleIndex) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1076 >(1076)(Pointer,@weapon?.Pointer ?? IntPtr.Zero,@particlePos.Pointer,@gunshellPos.Pointer,@particleIndex); }
    public void @FirePlaneGuns() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1077 >(1077)(Pointer); }
    public void @FireUnguidedMissile(int @ordnanceType,bool @bCheckTime) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1078 >(1078)(Pointer,@ordnanceType,(@bCheckTime ? 1 : 0)); }
    public bool @CanBeDriven() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1079 >(1079)(Pointer); return __sdkResult != 0; }
    public void @ReactToVehicleDamage(CPed? @ped) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1080 >(1080)(Pointer,@ped?.Pointer ?? IntPtr.Zero); }
    public bool @GetVehicleLightsStatus() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1081 >(1081)(Pointer); return __sdkResult != 0; }
    public bool @CanPedLeanOut(CPed? @ped) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1082 >(1082)(Pointer,@ped?.Pointer ?? IntPtr.Zero); return __sdkResult != 0; }
    public void @SetVehicleCreatedBy(int @createdBy) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1083 >(1083)(Pointer,@createdBy); }
    public void @SetupRender() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1084 >(1084)(Pointer); }
    public void @ProcessWheel(CVector @arg0,CVector @arg1,CVector @arg2,CVector @arg3,int @arg4,float @arg5,float @arg6,float @arg7,sbyte @arg8,NativePointer<float> @arg9,NativePointer<int> @arg10,ushort @arg11) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1085 >(1085)(Pointer,@arg0.Pointer,@arg1.Pointer,@arg2.Pointer,@arg3.Pointer,@arg4,@arg5,@arg6,@arg7,@arg8,@arg9.Pointer,@arg10.Pointer,@arg11); }
    public void @ProcessBikeWheel(CVector @arg0,CVector @arg1,CVector @arg2,CVector @arg3,int @arg4,float @arg5,float @arg6,float @arg7,float @arg8,sbyte @arg9,NativePointer<float> @arg10,NativePointer<int> @arg11,int @arg12,ushort @arg13) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1086 >(1086)(Pointer,@arg0.Pointer,@arg1.Pointer,@arg2.Pointer,@arg3.Pointer,@arg4,@arg5,@arg6,@arg7,@arg8,@arg9,@arg10.Pointer,@arg11.Pointer,@arg12,@arg13); }
    public int @FindTyreNearestPoint(float @x,float @y) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1087 >(1087)(Pointer,@x,@y); return __sdkResult; }
    public void @InflictDamage(CEntity? @damager,eWeaponType @weapon,float @intensity,CVector @coords) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1088 >(1088)(Pointer,@damager?.Pointer ?? IntPtr.Zero,(int)@weapon,@intensity,@coords.Pointer); }
    public void @KillPedsGettingInVehicle() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1089 >(1089)(Pointer); }
    public bool @UsesSiren() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1090 >(1090)(Pointer); return __sdkResult != 0; }
    public bool @IsSphereTouchingVehicle(float @x,float @y,float @z,float @radius) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1091 >(1091)(Pointer,@x,@y,@z,@radius); return __sdkResult != 0; }
    public void @FlyingControl(int @flightModel,float @arg1,float @arg2,float @arg3,float @arg4) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1092 >(1092)(Pointer,@flightModel,@arg1,@arg2,@arg3,@arg4); }
    public void @BladeColSectorList(CPtrList @ptrList,CColModel @colModel,CMatrix @matrix,short @arg3,float @arg4) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1093 >(1093)(Pointer,@ptrList.Pointer,@colModel.Pointer,@matrix.Pointer,@arg3,@arg4); }
    public void @SetComponentRotation(RwFrame? @component,int @axis,float @angle,bool @bResetPosition) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1094 >(1094)(Pointer,@component?.Pointer ?? IntPtr.Zero,@axis,@angle,(@bResetPosition ? 1 : 0)); }
    public void @SetTransmissionRotation(RwFrame? @component,float @arg1,float @arg2,CVector @posn,bool @isFront) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1095 >(1095)(Pointer,@component?.Pointer ?? IntPtr.Zero,@arg1,@arg2,@posn.Pointer,(@isFront ? 1 : 0)); }
    public void @ProcessBoatControl(tBoatHandlingData? @boatHandling,NativePointer<float> @arg1,bool @arg2,bool @arg3) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1096 >(1096)(Pointer,@boatHandling?.Pointer ?? IntPtr.Zero,@arg1.Pointer,(@arg2 ? 1 : 0),(@arg3 ? 1 : 0)); }
    public void @DoBoatSplashes(float @arg0) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1097 >(1097)(Pointer,@arg0); }
    public void @DoSunGlare() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1098 >(1098)(Pointer); }
    public void @AddWaterSplashParticles() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1099 >(1099)(Pointer); }
    public void @AddExhaustParticles() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1100 >(1100)(Pointer); }
    public bool @AddSingleWheelParticles(int @arg0,uint @arg1,float @arg2,float @arg3,CColPoint? @arg4,CVector? @arg5,float @arg6,int @arg7,uint @surfaceType,NativePointer<bool> @bloodState,uint @arg10) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1101 >(1101)(Pointer,@arg0,@arg1,@arg2,@arg3,@arg4?.Pointer ?? IntPtr.Zero,@arg5?.Pointer ?? IntPtr.Zero,@arg6,@arg7,@surfaceType,@bloodState.Pointer,@arg10); return __sdkResult != 0; }
    public bool @GetSpecialColModel() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1102 >(1102)(Pointer); return __sdkResult != 0; }
    public void @RemoveVehicleUpgrade(int @upgradeModelIndex) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1103 >(1103)(Pointer,@upgradeModelIndex); }
    public void @AddUpgrade(int @modelIndex,int @upgradeIndex) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1104 >(1104)(Pointer,@modelIndex,@upgradeIndex); }
    public void @UpdateTrailerLink(bool @arg0,bool @arg1) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1105 >(1105)(Pointer,(@arg0 ? 1 : 0),(@arg1 ? 1 : 0)); }
    public void @UpdateTractorLink(bool @arg0,bool @arg1) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1106 >(1106)(Pointer,(@arg0 ? 1 : 0),(@arg1 ? 1 : 0)); }
    public CEntity? @ScanAndMarkTargetForHeatSeekingMissile(CEntity? @entity) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1107 >(1107)(Pointer,@entity?.Pointer ?? IntPtr.Zero); return __sdkResult == IntPtr.Zero ? null : new CEntity(__sdkResult); }
    public void @FireHeatSeakingMissile(CEntity? @targetEntity,int @ordnanceType,bool @arg2) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1108 >(1108)(Pointer,@targetEntity?.Pointer ?? IntPtr.Zero,@ordnanceType,(@arg2 ? 1 : 0)); }
    public void @PossiblyDropFreeFallBombForPlayer(int @ordnanceType,bool @arg1) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1109 >(1109)(Pointer,@ordnanceType,(@arg1 ? 1 : 0)); }
    public void @ProcessSirenAndHorn(bool @arg0) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1110 >(1110)(Pointer,(@arg0 ? 1 : 0)); }
    public bool @DoHeadLightEffect(int @dummyId,CMatrix @vehicleMatrix,byte @lightId,byte @lightState) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1111 >(1111)(Pointer,@dummyId,@vehicleMatrix.Pointer,@lightId,@lightState); return __sdkResult != 0; }
    public void @DoHeadLightBeam(int @arg0,CMatrix @matrix,byte @arg2) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1112 >(1112)(Pointer,@arg0,@matrix.Pointer,@arg2); }
    public void @DoHeadLightReflectionSingle(CMatrix @matrix,byte @lightId) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1113 >(1113)(Pointer,@matrix.Pointer,@lightId); }
    public void @DoHeadLightReflectionTwin(CMatrix @matrix) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1114 >(1114)(Pointer,@matrix.Pointer); }
    public void @DoHeadLightReflection(CMatrix @arg0,uint @flags,byte @left,byte @right) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1115 >(1115)(Pointer,@arg0.Pointer,@flags,@left,@right); }
    public bool @DoTailLightEffect(int @lightId,CMatrix @matrix,byte @arg2,byte @arg3,uint @arg4,byte @arg5) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1116 >(1116)(Pointer,@lightId,@matrix.Pointer,@arg2,@arg3,@arg4,@arg5); return __sdkResult != 0; }
    public void @DoVehicleLights(CMatrix @matrix,uint @flags) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1117 >(1117)(Pointer,@matrix.Pointer,@flags); }
    public void @FillVehicleWithPeds(bool @bSetClothesToAfro) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1118 >(1118)(Pointer,(@bSetClothesToAfro ? 1 : 0)); }
    public void @DoBladeCollision(CVector @arg0,CMatrix @matrix,short @arg2,float @arg3,float @arg4) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1119 >(1119)(Pointer,@arg0.Pointer,@matrix.Pointer,@arg2,@arg3,@arg4); }
    public void @AddVehicleUpgrade(int @modelId) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1120 >(1120)(Pointer,@modelId); }
    public void @SetupUpgradesAfterLoad() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1121 >(1121)(Pointer); }
    public void @GetPlaneWeaponFiringStatus(NativePointer<bool> @status,NativePointer<int> @ordnanceType) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1122 >(1122)(Pointer,@status.Pointer,@ordnanceType.Pointer); }
    public void @ProcessWeapons() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1123 >(1123)(Pointer); }
    public static NativePointer<IntPtr> @AllocateNative(uint @size) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1124 >(1124)(@size); return new NativePointer<IntPtr>(__sdkResult); }
    public static void @FreeNative(NativePointer<IntPtr> @data) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1125 >(1125)(@data.Pointer); }
}
