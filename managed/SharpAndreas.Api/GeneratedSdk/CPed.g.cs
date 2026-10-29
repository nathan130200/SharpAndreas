// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CPed : CPhysical
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=1948;
    public CPed(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_pedAudio")]
    public CAEPedAudioEntity @PedAudio { get => new CAEPedAudioEntity(Pointer+312); set { SdkMemory.Copy(value.Pointer,Pointer+312,348); } }
    [NativeMember("m_pedSpeech")]
    public CAEPedSpeechAudioEntity @PedSpeech { get => new CAEPedSpeechAudioEntity(Pointer+660); set { SdkMemory.Copy(value.Pointer,Pointer+660,256); } }
    [NativeMember("m_weaponAudio")]
    public CAEWeaponAudioEntity @WeaponAudio { get => new CAEWeaponAudioEntity(Pointer+916); set { SdkMemory.Copy(value.Pointer,Pointer+916,168); } }
    [NativeMember("field_43C")]
    public NativeArray<sbyte> @Field43C { get => new NativeArray<sbyte>(Pointer+1084,36); }
    [NativeMember("m_roadRageWith")]
    public CPed? @RoadRageWith { get => SdkMemory.Read<IntPtr>(Pointer+1120) == IntPtr.Zero ? null : new CPed(SdkMemory.Read<IntPtr>(Pointer+1120)); set { SdkMemory.Write(Pointer+1120,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("field_464")]
    public NativeArray<sbyte> @Field464 { get => new NativeArray<sbyte>(Pointer+1124,4); }
    [NativeMember("field_468")]
    public int @Field468 { get => SdkMemory.Read<int >(Pointer+1128); set { SdkMemory.Write(Pointer+1128,value); } }
    [NativeMember("bIsStanding")]
    public bool @IsStanding { get => SdkMemory.ReadBits(Pointer,9056,1) != 0; set { SdkMemory.WriteBits(Pointer,9056,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bWasStanding")]
    public bool @WasStanding { get => SdkMemory.ReadBits(Pointer,9057,1) != 0; set { SdkMemory.WriteBits(Pointer,9057,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bIsLooking")]
    public bool @IsLooking { get => SdkMemory.ReadBits(Pointer,9058,1) != 0; set { SdkMemory.WriteBits(Pointer,9058,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bIsRestoringLook")]
    public bool @IsRestoringLook { get => SdkMemory.ReadBits(Pointer,9059,1) != 0; set { SdkMemory.WriteBits(Pointer,9059,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bIsAimingGun")]
    public bool @IsAimingGun { get => SdkMemory.ReadBits(Pointer,9060,1) != 0; set { SdkMemory.WriteBits(Pointer,9060,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bIsRestoringGun")]
    public bool @IsRestoringGun { get => SdkMemory.ReadBits(Pointer,9061,1) != 0; set { SdkMemory.WriteBits(Pointer,9061,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bCanPointGunAtTarget")]
    public bool @CanPointGunAtTarget { get => SdkMemory.ReadBits(Pointer,9062,1) != 0; set { SdkMemory.WriteBits(Pointer,9062,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bIsTalking")]
    public bool @IsTalking { get => SdkMemory.ReadBits(Pointer,9063,1) != 0; set { SdkMemory.WriteBits(Pointer,9063,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bInVehicle")]
    public bool @InVehicle { get => SdkMemory.ReadBits(Pointer,9064,1) != 0; set { SdkMemory.WriteBits(Pointer,9064,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bIsInTheAir")]
    public bool @IsInTheAir { get => SdkMemory.ReadBits(Pointer,9065,1) != 0; set { SdkMemory.WriteBits(Pointer,9065,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bIsLanding")]
    public bool @IsLanding { get => SdkMemory.ReadBits(Pointer,9066,1) != 0; set { SdkMemory.WriteBits(Pointer,9066,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bHitSomethingLastFrame")]
    public bool @HitSomethingLastFrame { get => SdkMemory.ReadBits(Pointer,9067,1) != 0; set { SdkMemory.WriteBits(Pointer,9067,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bIsNearCar")]
    public bool @IsNearCar { get => SdkMemory.ReadBits(Pointer,9068,1) != 0; set { SdkMemory.WriteBits(Pointer,9068,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bRenderPedInCar")]
    public bool @RenderPedInCar { get => SdkMemory.ReadBits(Pointer,9069,1) != 0; set { SdkMemory.WriteBits(Pointer,9069,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bUpdateAnimHeading")]
    public bool @UpdateAnimationHeading { get => SdkMemory.ReadBits(Pointer,9070,1) != 0; set { SdkMemory.WriteBits(Pointer,9070,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bRemoveHead")]
    public bool @RemoveHead { get => SdkMemory.ReadBits(Pointer,9071,1) != 0; set { SdkMemory.WriteBits(Pointer,9071,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bFiringWeapon")]
    public bool @FiringWeapon { get => SdkMemory.ReadBits(Pointer,9072,1) != 0; set { SdkMemory.WriteBits(Pointer,9072,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bHasACamera")]
    public bool @HasACamera { get => SdkMemory.ReadBits(Pointer,9073,1) != 0; set { SdkMemory.WriteBits(Pointer,9073,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bPedIsBleeding")]
    public bool @PedIsBleeding { get => SdkMemory.ReadBits(Pointer,9074,1) != 0; set { SdkMemory.WriteBits(Pointer,9074,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bStopAndShoot")]
    public bool @StopAndShoot { get => SdkMemory.ReadBits(Pointer,9075,1) != 0; set { SdkMemory.WriteBits(Pointer,9075,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bIsPedDieAnimPlaying")]
    public bool @IsPedDieAnimationPlaying { get => SdkMemory.ReadBits(Pointer,9076,1) != 0; set { SdkMemory.WriteBits(Pointer,9076,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bStayInSamePlace")]
    public bool @StayInSamePlace { get => SdkMemory.ReadBits(Pointer,9077,1) != 0; set { SdkMemory.WriteBits(Pointer,9077,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bKindaStayInSamePlace")]
    public bool @KindaStayInSamePlace { get => SdkMemory.ReadBits(Pointer,9078,1) != 0; set { SdkMemory.WriteBits(Pointer,9078,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bBeingChasedByPolice")]
    public bool @BeingChasedByPolice { get => SdkMemory.ReadBits(Pointer,9079,1) != 0; set { SdkMemory.WriteBits(Pointer,9079,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bNotAllowedToDuck")]
    public bool @NotAllowedToDuck { get => SdkMemory.ReadBits(Pointer,9080,1) != 0; set { SdkMemory.WriteBits(Pointer,9080,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bCrouchWhenShooting")]
    public bool @CrouchWhenShooting { get => SdkMemory.ReadBits(Pointer,9081,1) != 0; set { SdkMemory.WriteBits(Pointer,9081,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bIsDucking")]
    public bool @IsDucking { get => SdkMemory.ReadBits(Pointer,9082,1) != 0; set { SdkMemory.WriteBits(Pointer,9082,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bGetUpAnimStarted")]
    public bool @GetUpAnimationStarted { get => SdkMemory.ReadBits(Pointer,9083,1) != 0; set { SdkMemory.WriteBits(Pointer,9083,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bDoBloodyFootprints")]
    public bool @DoBloodyFootprints { get => SdkMemory.ReadBits(Pointer,9084,1) != 0; set { SdkMemory.WriteBits(Pointer,9084,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bDontDragMeOutCar")]
    public bool @DontDragMeOutCar { get => SdkMemory.ReadBits(Pointer,9085,1) != 0; set { SdkMemory.WriteBits(Pointer,9085,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bStillOnValidPoly")]
    public bool @StillOnValidPoly { get => SdkMemory.ReadBits(Pointer,9086,1) != 0; set { SdkMemory.WriteBits(Pointer,9086,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bAllowMedicsToReviveMe")]
    public bool @AllowMedicsToReviveMe { get => SdkMemory.ReadBits(Pointer,9087,1) != 0; set { SdkMemory.WriteBits(Pointer,9087,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bResetWalkAnims")]
    public bool @ResetWalkAnims { get => SdkMemory.ReadBits(Pointer,9088,1) != 0; set { SdkMemory.WriteBits(Pointer,9088,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bOnBoat")]
    public bool @OnBoat { get => SdkMemory.ReadBits(Pointer,9089,1) != 0; set { SdkMemory.WriteBits(Pointer,9089,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bBusJacked")]
    public bool @BusJacked { get => SdkMemory.ReadBits(Pointer,9090,1) != 0; set { SdkMemory.WriteBits(Pointer,9090,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bFadeOut")]
    public bool @FadeOut { get => SdkMemory.ReadBits(Pointer,9091,1) != 0; set { SdkMemory.WriteBits(Pointer,9091,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bKnockedUpIntoAir")]
    public bool @KnockedUpIntoAir { get => SdkMemory.ReadBits(Pointer,9092,1) != 0; set { SdkMemory.WriteBits(Pointer,9092,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bHitSteepSlope")]
    public bool @HitSteepSlope { get => SdkMemory.ReadBits(Pointer,9093,1) != 0; set { SdkMemory.WriteBits(Pointer,9093,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bCullExtraFarAway")]
    public bool @CullExtraFarAway { get => SdkMemory.ReadBits(Pointer,9094,1) != 0; set { SdkMemory.WriteBits(Pointer,9094,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bTryingToReachDryLand")]
    public bool @TryingToReachDryLand { get => SdkMemory.ReadBits(Pointer,9095,1) != 0; set { SdkMemory.WriteBits(Pointer,9095,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bCollidedWithMyVehicle")]
    public bool @CollidedWithMyVehicle { get => SdkMemory.ReadBits(Pointer,9096,1) != 0; set { SdkMemory.WriteBits(Pointer,9096,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bRichFromMugging")]
    public bool @RichFromMugging { get => SdkMemory.ReadBits(Pointer,9097,1) != 0; set { SdkMemory.WriteBits(Pointer,9097,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bChrisCriminal")]
    public bool @ChrisCriminal { get => SdkMemory.ReadBits(Pointer,9098,1) != 0; set { SdkMemory.WriteBits(Pointer,9098,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bShakeFist")]
    public bool @ShakeFist { get => SdkMemory.ReadBits(Pointer,9099,1) != 0; set { SdkMemory.WriteBits(Pointer,9099,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bNoCriticalHits")]
    public bool @NoCriticalHits { get => SdkMemory.ReadBits(Pointer,9100,1) != 0; set { SdkMemory.WriteBits(Pointer,9100,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bHasAlreadyBeenRecorded")]
    public bool @HasAlreadyBeenRecorded { get => SdkMemory.ReadBits(Pointer,9101,1) != 0; set { SdkMemory.WriteBits(Pointer,9101,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bUpdateMatricesRequired")]
    public bool @UpdateMatricesRequired { get => SdkMemory.ReadBits(Pointer,9102,1) != 0; set { SdkMemory.WriteBits(Pointer,9102,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bFleeWhenStanding")]
    public bool @FleeWhenStanding { get => SdkMemory.ReadBits(Pointer,9103,1) != 0; set { SdkMemory.WriteBits(Pointer,9103,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bMiamiViceCop")]
    public bool @MiamiViceCop { get => SdkMemory.ReadBits(Pointer,9104,1) != 0; set { SdkMemory.WriteBits(Pointer,9104,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bMoneyHasBeenGivenByScript")]
    public bool @MoneyHasBeenGivenByScript { get => SdkMemory.ReadBits(Pointer,9105,1) != 0; set { SdkMemory.WriteBits(Pointer,9105,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bHasBeenPhotographed")]
    public bool @HasBeenPhotographed { get => SdkMemory.ReadBits(Pointer,9106,1) != 0; set { SdkMemory.WriteBits(Pointer,9106,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bIsDrowning")]
    public bool @IsDrowning { get => SdkMemory.ReadBits(Pointer,9107,1) != 0; set { SdkMemory.WriteBits(Pointer,9107,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bDrownsInWater")]
    public bool @DrownsInWater { get => SdkMemory.ReadBits(Pointer,9108,1) != 0; set { SdkMemory.WriteBits(Pointer,9108,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bHeadStuckInCollision")]
    public bool @HeadStuckInCollision { get => SdkMemory.ReadBits(Pointer,9109,1) != 0; set { SdkMemory.WriteBits(Pointer,9109,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bDeadPedInFrontOfCar")]
    public bool @DeadPedInFrontOfCar { get => SdkMemory.ReadBits(Pointer,9110,1) != 0; set { SdkMemory.WriteBits(Pointer,9110,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bStayInCarOnJack")]
    public bool @StayInCarOnJack { get => SdkMemory.ReadBits(Pointer,9111,1) != 0; set { SdkMemory.WriteBits(Pointer,9111,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bDontFight")]
    public bool @DontFight { get => SdkMemory.ReadBits(Pointer,9112,1) != 0; set { SdkMemory.WriteBits(Pointer,9112,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bDoomAim")]
    public bool @DoomAim { get => SdkMemory.ReadBits(Pointer,9113,1) != 0; set { SdkMemory.WriteBits(Pointer,9113,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bCanBeShotInVehicle")]
    public bool @CanBeShotInVehicle { get => SdkMemory.ReadBits(Pointer,9114,1) != 0; set { SdkMemory.WriteBits(Pointer,9114,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bPushedAlongByCar")]
    public bool @PushedAlongByCar { get => SdkMemory.ReadBits(Pointer,9115,1) != 0; set { SdkMemory.WriteBits(Pointer,9115,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bNeverEverTargetThisPed")]
    public bool @NeverEverTargetThisPed { get => SdkMemory.ReadBits(Pointer,9116,1) != 0; set { SdkMemory.WriteBits(Pointer,9116,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bThisPedIsATargetPriority")]
    public bool @ThisPedIsATargetPriority { get => SdkMemory.ReadBits(Pointer,9117,1) != 0; set { SdkMemory.WriteBits(Pointer,9117,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bCrouchWhenScared")]
    public bool @CrouchWhenScared { get => SdkMemory.ReadBits(Pointer,9118,1) != 0; set { SdkMemory.WriteBits(Pointer,9118,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bKnockedOffBike")]
    public bool @KnockedOffBike { get => SdkMemory.ReadBits(Pointer,9119,1) != 0; set { SdkMemory.WriteBits(Pointer,9119,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bDonePositionOutOfCollision")]
    public bool @DonePositionOutOfCollision { get => SdkMemory.ReadBits(Pointer,9120,1) != 0; set { SdkMemory.WriteBits(Pointer,9120,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bDontRender")]
    public bool @DontRender { get => SdkMemory.ReadBits(Pointer,9121,1) != 0; set { SdkMemory.WriteBits(Pointer,9121,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bHasBeenAddedToPopulation")]
    public bool @HasBeenAddedToPopulation { get => SdkMemory.ReadBits(Pointer,9122,1) != 0; set { SdkMemory.WriteBits(Pointer,9122,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bHasJustLeftCar")]
    public bool @HasJustLeftCar { get => SdkMemory.ReadBits(Pointer,9123,1) != 0; set { SdkMemory.WriteBits(Pointer,9123,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bIsInDisguise")]
    public bool @IsInDisguise { get => SdkMemory.ReadBits(Pointer,9124,1) != 0; set { SdkMemory.WriteBits(Pointer,9124,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bDoesntListenToPlayerGroupCommands")]
    public bool @DoesntListenToPlayerGroupCommands { get => SdkMemory.ReadBits(Pointer,9125,1) != 0; set { SdkMemory.WriteBits(Pointer,9125,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bIsBeingArrested")]
    public bool @IsBeingArrested { get => SdkMemory.ReadBits(Pointer,9126,1) != 0; set { SdkMemory.WriteBits(Pointer,9126,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bHasJustSoughtCover")]
    public bool @HasJustSoughtCover { get => SdkMemory.ReadBits(Pointer,9127,1) != 0; set { SdkMemory.WriteBits(Pointer,9127,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bKilledByStealth")]
    public bool @KilledByStealth { get => SdkMemory.ReadBits(Pointer,9128,1) != 0; set { SdkMemory.WriteBits(Pointer,9128,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bDoesntDropWeaponsWhenDead")]
    public bool @DoesntDropWeaponsWhenDead { get => SdkMemory.ReadBits(Pointer,9129,1) != 0; set { SdkMemory.WriteBits(Pointer,9129,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bCalledPreRender")]
    public bool @CalledPreRender { get => SdkMemory.ReadBits(Pointer,9130,1) != 0; set { SdkMemory.WriteBits(Pointer,9130,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bBloodPuddleCreated")]
    public bool @BloodPuddleCreated { get => SdkMemory.ReadBits(Pointer,9131,1) != 0; set { SdkMemory.WriteBits(Pointer,9131,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bPartOfAttackWave")]
    public bool @PartOfAttackWave { get => SdkMemory.ReadBits(Pointer,9132,1) != 0; set { SdkMemory.WriteBits(Pointer,9132,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bClearRadarBlipOnDeath")]
    public bool @ClearRadarBlipOnDeath { get => SdkMemory.ReadBits(Pointer,9133,1) != 0; set { SdkMemory.WriteBits(Pointer,9133,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bNeverLeavesGroup")]
    public bool @NeverLeavesGroup { get => SdkMemory.ReadBits(Pointer,9134,1) != 0; set { SdkMemory.WriteBits(Pointer,9134,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bTestForBlockedPositions")]
    public bool @TestForBlockedPositions { get => SdkMemory.ReadBits(Pointer,9135,1) != 0; set { SdkMemory.WriteBits(Pointer,9135,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bRightArmBlocked")]
    public bool @RightArmBlocked { get => SdkMemory.ReadBits(Pointer,9136,1) != 0; set { SdkMemory.WriteBits(Pointer,9136,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bLeftArmBlocked")]
    public bool @LeftArmBlocked { get => SdkMemory.ReadBits(Pointer,9137,1) != 0; set { SdkMemory.WriteBits(Pointer,9137,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bDuckRightArmBlocked")]
    public bool @DuckRightArmBlocked { get => SdkMemory.ReadBits(Pointer,9138,1) != 0; set { SdkMemory.WriteBits(Pointer,9138,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bMidriffBlockedForJump")]
    public bool @MidriffBlockedForJump { get => SdkMemory.ReadBits(Pointer,9139,1) != 0; set { SdkMemory.WriteBits(Pointer,9139,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bFallenDown")]
    public bool @FallenDown { get => SdkMemory.ReadBits(Pointer,9140,1) != 0; set { SdkMemory.WriteBits(Pointer,9140,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bUseAttractorInstantly")]
    public bool @UseAttractorInstantly { get => SdkMemory.ReadBits(Pointer,9141,1) != 0; set { SdkMemory.WriteBits(Pointer,9141,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bDontAcceptIKLookAts")]
    public bool @DontAcceptIKLookAts { get => SdkMemory.ReadBits(Pointer,9142,1) != 0; set { SdkMemory.WriteBits(Pointer,9142,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bHasAScriptBrain")]
    public bool @HasAScriptBrain { get => SdkMemory.ReadBits(Pointer,9143,1) != 0; set { SdkMemory.WriteBits(Pointer,9143,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bWaitingForScriptBrainToLoad")]
    public bool @WaitingForScriptBrainToLoad { get => SdkMemory.ReadBits(Pointer,9144,1) != 0; set { SdkMemory.WriteBits(Pointer,9144,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bHasGroupDriveTask")]
    public bool @HasGroupDriveTask { get => SdkMemory.ReadBits(Pointer,9145,1) != 0; set { SdkMemory.WriteBits(Pointer,9145,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bCanExitCar")]
    public bool @CanExitCar { get => SdkMemory.ReadBits(Pointer,9146,1) != 0; set { SdkMemory.WriteBits(Pointer,9146,1,(value ? 1UL : 0UL)); } }
    [NativeMember("CantBeKnockedOffBike")]
    public byte @CantBeKnockedOffBike { get => (byte)SdkMemory.ReadBits(Pointer,9147,2); set { SdkMemory.WriteBits(Pointer,9147,2,unchecked((ulong)value)); } }
    [NativeMember("bHasBeenRendered")]
    public bool @HasBeenRendered { get => SdkMemory.ReadBits(Pointer,9149,1) != 0; set { SdkMemory.WriteBits(Pointer,9149,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bIsCached")]
    public bool @IsCached { get => SdkMemory.ReadBits(Pointer,9150,1) != 0; set { SdkMemory.WriteBits(Pointer,9150,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bPushOtherPeds")]
    public bool @PushOtherPeds { get => SdkMemory.ReadBits(Pointer,9151,1) != 0; set { SdkMemory.WriteBits(Pointer,9151,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bHasBulletProofVest")]
    public bool @HasBulletProofVest { get => SdkMemory.ReadBits(Pointer,9152,1) != 0; set { SdkMemory.WriteBits(Pointer,9152,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bUsingMobilePhone")]
    public bool @UsingMobilePhone { get => SdkMemory.ReadBits(Pointer,9153,1) != 0; set { SdkMemory.WriteBits(Pointer,9153,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bUpperBodyDamageAnimsOnly")]
    public bool @UpperBodyDamageAnimsOnly { get => SdkMemory.ReadBits(Pointer,9154,1) != 0; set { SdkMemory.WriteBits(Pointer,9154,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bStuckUnderCar")]
    public bool @StuckUnderCar { get => SdkMemory.ReadBits(Pointer,9155,1) != 0; set { SdkMemory.WriteBits(Pointer,9155,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bKeepTasksAfterCleanUp")]
    public bool @KeepTasksAfterCleanUp { get => SdkMemory.ReadBits(Pointer,9156,1) != 0; set { SdkMemory.WriteBits(Pointer,9156,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bIsDyingStuck")]
    public bool @IsDyingStuck { get => SdkMemory.ReadBits(Pointer,9157,1) != 0; set { SdkMemory.WriteBits(Pointer,9157,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bIgnoreHeightCheckOnGotoPointTask")]
    public bool @IgnoreHeightCheckOnGotoPointTask { get => SdkMemory.ReadBits(Pointer,9158,1) != 0; set { SdkMemory.WriteBits(Pointer,9158,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bForceDieInCar")]
    public bool @ForceDieInCar { get => SdkMemory.ReadBits(Pointer,9159,1) != 0; set { SdkMemory.WriteBits(Pointer,9159,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bCheckColAboveHead")]
    public bool @CheckCollisionAboveHead { get => SdkMemory.ReadBits(Pointer,9160,1) != 0; set { SdkMemory.WriteBits(Pointer,9160,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bIgnoreWeaponRange")]
    public bool @IgnoreWeaponRange { get => SdkMemory.ReadBits(Pointer,9161,1) != 0; set { SdkMemory.WriteBits(Pointer,9161,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bDruggedUp")]
    public bool @DruggedUp { get => SdkMemory.ReadBits(Pointer,9162,1) != 0; set { SdkMemory.WriteBits(Pointer,9162,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bWantedByPolice")]
    public bool @WantedByPolice { get => SdkMemory.ReadBits(Pointer,9163,1) != 0; set { SdkMemory.WriteBits(Pointer,9163,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bSignalAfterKill")]
    public bool @SignalAfterKill { get => SdkMemory.ReadBits(Pointer,9164,1) != 0; set { SdkMemory.WriteBits(Pointer,9164,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bCanClimbOntoBoat")]
    public bool @CanClimbOntoBoat { get => SdkMemory.ReadBits(Pointer,9165,1) != 0; set { SdkMemory.WriteBits(Pointer,9165,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bPedHitWallLastFrame")]
    public bool @PedHitWallLastFrame { get => SdkMemory.ReadBits(Pointer,9166,1) != 0; set { SdkMemory.WriteBits(Pointer,9166,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bIgnoreHeightDifferenceFollowingNodes")]
    public bool @IgnoreHeightDifferenceFollowingNodes { get => SdkMemory.ReadBits(Pointer,9167,1) != 0; set { SdkMemory.WriteBits(Pointer,9167,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bMoveAnimSpeedHasBeenSetByTask")]
    public bool @MoveAnimationSpeedHasBeenSetByTask { get => SdkMemory.ReadBits(Pointer,9168,1) != 0; set { SdkMemory.WriteBits(Pointer,9168,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bGetOutUpsideDownCar")]
    public bool @GetOutUpsideDownCar { get => SdkMemory.ReadBits(Pointer,9169,1) != 0; set { SdkMemory.WriteBits(Pointer,9169,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bJustGotOffTrain")]
    public bool @JustGotOffTrain { get => SdkMemory.ReadBits(Pointer,9170,1) != 0; set { SdkMemory.WriteBits(Pointer,9170,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bDeathPickupsPersist")]
    public bool @DeathPickupsPersist { get => SdkMemory.ReadBits(Pointer,9171,1) != 0; set { SdkMemory.WriteBits(Pointer,9171,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bTestForShotInVehicle")]
    public bool @TestForShotInVehicle { get => SdkMemory.ReadBits(Pointer,9172,1) != 0; set { SdkMemory.WriteBits(Pointer,9172,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bUsedForReplay")]
    public bool @UsedForReplay { get => SdkMemory.ReadBits(Pointer,9173,1) != 0; set { SdkMemory.WriteBits(Pointer,9173,1,(value ? 1UL : 0UL)); } }
    [NativeMember("m_pIntelligence")]
    public CPedIntelligence? @Intelligence { get => SdkMemory.Read<IntPtr>(Pointer+1148) == IntPtr.Zero ? null : new CPedIntelligence(SdkMemory.Read<IntPtr>(Pointer+1148)); set { SdkMemory.Write(Pointer+1148,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_pPlayerData")]
    public CPlayerData? @PlayerData { get => SdkMemory.Read<IntPtr>(Pointer+1152) == IntPtr.Zero ? null : new CPlayerData(SdkMemory.Read<IntPtr>(Pointer+1152)); set { SdkMemory.Write(Pointer+1152,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_nCreatedBy")]
    public byte @CreatedBy { get => SdkMemory.Read<byte >(Pointer+1156); set { SdkMemory.Write(Pointer+1156,value); } }
    [NativeMember("field_485")]
    public NativeArray<sbyte> @Field485 { get => new NativeArray<sbyte>(Pointer+1157,3); }
    [NativeMember("m_apBones")]
    public NativeArray<IntPtr> @Bones { get => new NativeArray<IntPtr>(Pointer+1160,19); }
    [NativeMember("m_nAnimGroup")]
    public uint @AnimationGroup { get => SdkMemory.Read<uint >(Pointer+1236); set { SdkMemory.Write(Pointer+1236,value); } }
    [NativeMember("m_vecAnimMovingShiftLocal")]
    public CVector2D @AnimationMovingShiftLocal { get => new CVector2D(Pointer+1240); set { SdkMemory.Copy(value.Pointer,Pointer+1240,8); } }
    [NativeMember("m_acquaintance")]
    public CPedAcquaintance @Acquaintance { get => new CPedAcquaintance(Pointer+1248); set { SdkMemory.Copy(value.Pointer,Pointer+1248,20); } }
    [NativeMember("m_pWeaponObject")]
    public RwObject? @WeaponObject { get => SdkMemory.Read<IntPtr>(Pointer+1268) == IntPtr.Zero ? null : new RwObject(SdkMemory.Read<IntPtr>(Pointer+1268)); set { SdkMemory.Write(Pointer+1268,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_pGunflashObject")]
    public RwFrame? @GunflashObject { get => SdkMemory.Read<IntPtr>(Pointer+1272) == IntPtr.Zero ? null : new RwFrame(SdkMemory.Read<IntPtr>(Pointer+1272)); set { SdkMemory.Write(Pointer+1272,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_pGogglesObject")]
    public RwObject? @GogglesObject { get => SdkMemory.Read<IntPtr>(Pointer+1276) == IntPtr.Zero ? null : new RwObject(SdkMemory.Read<IntPtr>(Pointer+1276)); set { SdkMemory.Write(Pointer+1276,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_pGogglesState")]
    public NativePointer<byte> @GogglesState { get => new NativePointer<byte>(SdkMemory.Read<IntPtr>(Pointer+1280)); set { SdkMemory.Write(Pointer+1280,value.Pointer); } }
    [NativeMember("m_nWeaponGunflashAlphaMP1")]
    public short @WeaponGunflashAlphaMP1 { get => SdkMemory.Read<short >(Pointer+1284); set { SdkMemory.Write(Pointer+1284,value); } }
    [NativeMember("m_nWeaponGunFlashAlphaProgMP1")]
    public short @WeaponGunFlashAlphaProgMP1 { get => SdkMemory.Read<short >(Pointer+1286); set { SdkMemory.Write(Pointer+1286,value); } }
    [NativeMember("m_nWeaponGunflashAlphaMP2")]
    public short @WeaponGunflashAlphaMP2 { get => SdkMemory.Read<short >(Pointer+1288); set { SdkMemory.Write(Pointer+1288,value); } }
    [NativeMember("m_nWeaponGunFlashAlphaProgMP2")]
    public short @WeaponGunFlashAlphaProgMP2 { get => SdkMemory.Read<short >(Pointer+1290); set { SdkMemory.Write(Pointer+1290,value); } }
    [NativeMember("m_pedIK")]
    public CPedIK @PedIK { get => new CPedIK(Pointer+1292); set { SdkMemory.Copy(value.Pointer,Pointer+1292,32); } }
    [NativeMember("m_nAntiSpazTimer")]
    public int @AntiSpazTimer { get => SdkMemory.Read<int >(Pointer+1324); set { SdkMemory.Write(Pointer+1324,value); } }
    [NativeMember("m_ePedState")]
    public ePedState @EPedState { get => SdkMemory.Read<ePedState >(Pointer+1328); set { SdkMemory.Write(Pointer+1328,value); } }
    [NativeMember("m_nMoveState")]
    public eMoveState @MoveState { get => SdkMemory.Read<eMoveState >(Pointer+1332); set { SdkMemory.Write(Pointer+1332,value); } }
    [NativeMember("m_nSwimmingMoveState")]
    public eMoveState @SwimmingMoveState { get => SdkMemory.Read<eMoveState >(Pointer+1336); set { SdkMemory.Write(Pointer+1336,value); } }
    [NativeMember("field_53C")]
    public int @Field53C { get => SdkMemory.Read<int >(Pointer+1340); set { SdkMemory.Write(Pointer+1340,value); } }
    [NativeMember("m_fHealth")]
    public float @Health { get => SdkMemory.Read<float >(Pointer+1344); set { SdkMemory.Write(Pointer+1344,value); } }
    [NativeMember("m_fMaxHealth")]
    public float @MaxHealth { get => SdkMemory.Read<float >(Pointer+1348); set { SdkMemory.Write(Pointer+1348,value); } }
    [NativeMember("m_fArmour")]
    public float @Armour { get => SdkMemory.Read<float >(Pointer+1352); set { SdkMemory.Write(Pointer+1352,value); } }
    [NativeMember("m_nTimeTillWeNeedThisPed")]
    public uint @TimeTillWeNeedThisPed { get => SdkMemory.Read<uint >(Pointer+1356); set { SdkMemory.Write(Pointer+1356,value); } }
    [NativeMember("m_vecAnimMovingShift")]
    public CVector2D @AnimationMovingShift { get => new CVector2D(Pointer+1360); set { SdkMemory.Copy(value.Pointer,Pointer+1360,8); } }
    [NativeMember("m_fHeadingCurrent")]
    public float @HeadingCurrent { get => SdkMemory.Read<float >(Pointer+1368); set { SdkMemory.Write(Pointer+1368,value); } }
    [NativeMember("m_fHeadingGoal")]
    public float @HeadingGoal { get => SdkMemory.Read<float >(Pointer+1372); set { SdkMemory.Write(Pointer+1372,value); } }
    [NativeMember("m_fHeadingChangeRate")]
    public float @HeadingChangeRate { get => SdkMemory.Read<float >(Pointer+1376); set { SdkMemory.Write(Pointer+1376,value); } }
    [NativeMember("m_fMoveAnim")]
    public int @MoveAnimation { get => SdkMemory.Read<int >(Pointer+1380); set { SdkMemory.Write(Pointer+1380,value); } }
    [NativeMember("m_standingOnEntity")]
    public CEntity? @StandingOnEntity { get => SdkMemory.Read<IntPtr>(Pointer+1384) == IntPtr.Zero ? null : new CEntity(SdkMemory.Read<IntPtr>(Pointer+1384)); set { SdkMemory.Write(Pointer+1384,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("field_56C")]
    public CVector @Field56C { get => new CVector(Pointer+1388); set { SdkMemory.Copy(value.Pointer,Pointer+1388,12); } }
    [NativeMember("field_578")]
    public CVector @Field578 { get => new CVector(Pointer+1400); set { SdkMemory.Copy(value.Pointer,Pointer+1400,12); } }
    [NativeMember("m_pContactEntity")]
    public CEntity? @ContactEntity { get => SdkMemory.Read<IntPtr>(Pointer+1412) == IntPtr.Zero ? null : new CEntity(SdkMemory.Read<IntPtr>(Pointer+1412)); set { SdkMemory.Write(Pointer+1412,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("field_588")]
    public float @Field588 { get => SdkMemory.Read<float >(Pointer+1416); set { SdkMemory.Write(Pointer+1416,value); } }
    [NativeMember("m_pVehicle")]
    public CVehicle? @Vehicle { get => SdkMemory.Read<IntPtr>(Pointer+1420) == IntPtr.Zero ? null : new CVehicle(SdkMemory.Read<IntPtr>(Pointer+1420)); set { SdkMemory.Write(Pointer+1420,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_VehDeadInFrontOf")]
    public CVehicle? @VehDeadInFrontOf { get => SdkMemory.Read<IntPtr>(Pointer+1424) == IntPtr.Zero ? null : new CVehicle(SdkMemory.Read<IntPtr>(Pointer+1424)); set { SdkMemory.Write(Pointer+1424,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("field_594")]
    public int @Field594 { get => SdkMemory.Read<int >(Pointer+1428); set { SdkMemory.Write(Pointer+1428,value); } }
    [NativeMember("m_nPedType")]
    public int @PedType { get => SdkMemory.Read<int >(Pointer+1432); set { SdkMemory.Write(Pointer+1432,value); } }
    [NativeMember("m_pStats")]
    public NativePointer<IntPtr> @Stats { get => new NativePointer<IntPtr>(SdkMemory.Read<IntPtr>(Pointer+1436)); set { SdkMemory.Write(Pointer+1436,value.Pointer); } }
    [NativeMember("m_aWeapons")]
    public NativeObjectArray<CWeapon> @Weapons { get => new NativeObjectArray<CWeapon>(Pointer+1440,13,28); }
    [NativeMember("m_nSavedWeapon")]
    public eWeaponType @SavedWeapon { get => SdkMemory.Read<eWeaponType >(Pointer+1804); set { SdkMemory.Write(Pointer+1804,value); } }
    [NativeMember("m_nDelayedWeapon")]
    public eWeaponType @DelayedWeapon { get => SdkMemory.Read<eWeaponType >(Pointer+1808); set { SdkMemory.Write(Pointer+1808,value); } }
    [NativeMember("m_nDelayedWeaponAmmo")]
    public uint @DelayedWeaponAmmo { get => SdkMemory.Read<uint >(Pointer+1812); set { SdkMemory.Write(Pointer+1812,value); } }
    [NativeMember("m_nSelectedWepSlot")]
    public byte @SelectedWepSlot { get => SdkMemory.Read<byte >(Pointer+1816); set { SdkMemory.Write(Pointer+1816,value); } }
    [NativeMember("m_nWeaponShootingRate")]
    public byte @WeaponShootingRate { get => SdkMemory.Read<byte >(Pointer+1817); set { SdkMemory.Write(Pointer+1817,value); } }
    [NativeMember("m_nWeaponAccuracy")]
    public byte @WeaponAccuracy { get => SdkMemory.Read<byte >(Pointer+1818); set { SdkMemory.Write(Pointer+1818,value); } }
    [NativeMember("m_pTargetedObject")]
    public CObject? @TargetedObject { get => SdkMemory.Read<IntPtr>(Pointer+1820) == IntPtr.Zero ? null : new CObject(SdkMemory.Read<IntPtr>(Pointer+1820)); set { SdkMemory.Write(Pointer+1820,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("field_720")]
    public int @Field720 { get => SdkMemory.Read<int >(Pointer+1824); set { SdkMemory.Write(Pointer+1824,value); } }
    [NativeMember("field_724")]
    public int @Field724 { get => SdkMemory.Read<int >(Pointer+1828); set { SdkMemory.Write(Pointer+1828,value); } }
    [NativeMember("field_728")]
    public int @Field728 { get => SdkMemory.Read<int >(Pointer+1832); set { SdkMemory.Write(Pointer+1832,value); } }
    [NativeMember("m_nWeaponSkill")]
    public sbyte @WeaponSkill { get => SdkMemory.Read<sbyte >(Pointer+1836); set { SdkMemory.Write(Pointer+1836,value); } }
    [NativeMember("m_nFightingStyle")]
    public eFightingStyle @FightingStyle { get => SdkMemory.Read<eFightingStyle >(Pointer+1837); set { SdkMemory.Write(Pointer+1837,value); } }
    [NativeMember("m_nAllowedAttackMoves")]
    public sbyte @AllowedAttackMoves { get => SdkMemory.Read<sbyte >(Pointer+1838); set { SdkMemory.Write(Pointer+1838,value); } }
    [NativeMember("field_72F")]
    public sbyte @Field72F { get => SdkMemory.Read<sbyte >(Pointer+1839); set { SdkMemory.Write(Pointer+1839,value); } }
    [NativeMember("m_pFire")]
    public CFire? @Fire { get => SdkMemory.Read<IntPtr>(Pointer+1840) == IntPtr.Zero ? null : new CFire(SdkMemory.Read<IntPtr>(Pointer+1840)); set { SdkMemory.Write(Pointer+1840,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_fireDmgMult")]
    public float @FireDmgMult { get => SdkMemory.Read<float >(Pointer+1844); set { SdkMemory.Write(Pointer+1844,value); } }
    [NativeMember("m_pLookTarget")]
    public CEntity? @LookTarget { get => SdkMemory.Read<IntPtr>(Pointer+1848) == IntPtr.Zero ? null : new CEntity(SdkMemory.Read<IntPtr>(Pointer+1848)); set { SdkMemory.Write(Pointer+1848,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_fLookDirection")]
    public float @LookDirection { get => SdkMemory.Read<float >(Pointer+1852); set { SdkMemory.Write(Pointer+1852,value); } }
    [NativeMember("m_nWeaponModelId")]
    public int @WeaponModelId { get => SdkMemory.Read<int >(Pointer+1856); set { SdkMemory.Write(Pointer+1856,value); } }
    [NativeMember("m_nUnconsciousTimer")]
    public uint @UnconsciousTimer { get => SdkMemory.Read<uint >(Pointer+1860); set { SdkMemory.Write(Pointer+1860,value); } }
    [NativeMember("m_nLookTime")]
    public uint @LookTime { get => SdkMemory.Read<uint >(Pointer+1864); set { SdkMemory.Write(Pointer+1864,value); } }
    [NativeMember("m_nAttackTimer")]
    public uint @AttackTimer { get => SdkMemory.Read<uint >(Pointer+1868); set { SdkMemory.Write(Pointer+1868,value); } }
    [NativeMember("m_nDeathTime")]
    public int @DeathTime { get => SdkMemory.Read<int >(Pointer+1872); set { SdkMemory.Write(Pointer+1872,value); } }
    [NativeMember("m_nBodypartToRemove")]
    public sbyte @BodypartToRemove { get => SdkMemory.Read<sbyte >(Pointer+1876); set { SdkMemory.Write(Pointer+1876,value); } }
    [NativeMember("field_755")]
    public sbyte @Field755 { get => SdkMemory.Read<sbyte >(Pointer+1877); set { SdkMemory.Write(Pointer+1877,value); } }
    [NativeMember("m_nMoneyCount")]
    public short @MoneyCount { get => SdkMemory.Read<short >(Pointer+1878); set { SdkMemory.Write(Pointer+1878,value); } }
    [NativeMember("m_Wobble")]
    public float @Wobble { get => SdkMemory.Read<float >(Pointer+1880); set { SdkMemory.Write(Pointer+1880,value); } }
    [NativeMember("m_WobbleSpeed")]
    public float @WobbleSpeed { get => SdkMemory.Read<float >(Pointer+1884); set { SdkMemory.Write(Pointer+1884,value); } }
    [NativeMember("m_nLastWeaponDamage")]
    public eWeaponType @LastWeaponDamage { get => SdkMemory.Read<eWeaponType >(Pointer+1888); set { SdkMemory.Write(Pointer+1888,value); } }
    [NativeMember("m_pLastEntityDamage")]
    public CEntity? @LastEntityDamage { get => SdkMemory.Read<IntPtr>(Pointer+1892) == IntPtr.Zero ? null : new CEntity(SdkMemory.Read<IntPtr>(Pointer+1892)); set { SdkMemory.Write(Pointer+1892,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("field_768")]
    public int @Field768 { get => SdkMemory.Read<int >(Pointer+1896); set { SdkMemory.Write(Pointer+1896,value); } }
    [NativeMember("m_vecTurretOffset")]
    public CVector @TurretOffset { get => new CVector(Pointer+1900); set { SdkMemory.Copy(value.Pointer,Pointer+1900,12); } }
    [NativeMember("m_fTurretAngleA")]
    public float @TurretAngleA { get => SdkMemory.Read<float >(Pointer+1912); set { SdkMemory.Write(Pointer+1912,value); } }
    [NativeMember("m_fTurretAngleB")]
    public float @TurretAngleB { get => SdkMemory.Read<float >(Pointer+1916); set { SdkMemory.Write(Pointer+1916,value); } }
    [NativeMember("m_nTurretPosnMode")]
    public int @TurretPositionMode { get => SdkMemory.Read<int >(Pointer+1920); set { SdkMemory.Write(Pointer+1920,value); } }
    [NativeMember("m_nTurretAmmo")]
    public int @TurretAmmo { get => SdkMemory.Read<int >(Pointer+1924); set { SdkMemory.Write(Pointer+1924,value); } }
    [NativeMember("m_pCoverPoint")]
    public NativePointer<IntPtr> @CoverPoint { get => new NativePointer<IntPtr>(SdkMemory.Read<IntPtr>(Pointer+1928)); set { SdkMemory.Write(Pointer+1928,value.Pointer); } }
    [NativeMember("m_pEnex")]
    public NativePointer<IntPtr> @Enex { get => new NativePointer<IntPtr>(SdkMemory.Read<IntPtr>(Pointer+1932)); set { SdkMemory.Write(Pointer+1932,value.Pointer); } }
    [NativeMember("m_fRemovalDistMultiplier")]
    public float @RemovalDistanceMultiplier { get => SdkMemory.Read<float >(Pointer+1936); set { SdkMemory.Write(Pointer+1936,value); } }
    [NativeMember("m_StreamedScriptBrainToLoad")]
    public short @StreamedScriptBrainToLoad { get => SdkMemory.Read<short >(Pointer+1940); set { SdkMemory.Write(Pointer+1940,value); } }
    [NativeMember("field_796")]
    public NativeArray<sbyte> @Field796 { get => new NativeArray<sbyte>(Pointer+1942,2); }
    [NativeMember("field_798")]
    public int @Field798 { get => SdkMemory.Read<int >(Pointer+1944); set { SdkMemory.Write(Pointer+1944,value); } }
    public void @SetMoveAnim() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1456 >(1456)(Pointer); }
    public bool @Save() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1457 >(1457)(Pointer); return __sdkResult != 0; }
    public bool @Load() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1458 >(1458)(Pointer); return __sdkResult != 0; }
    public void @InitializeAt(ePedType @pedtype) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1459 >(1459)(Pointer,(int)@pedtype); }
    public bool @PedIsInvolvedInConversation() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1460 >(1460)(Pointer); return __sdkResult != 0; }
    public bool @PedIsReadyForConversation(bool @arg0) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1461 >(1461)(Pointer,(@arg0 ? 1 : 0)); return __sdkResult != 0; }
    public bool @PedCanPickUpPickUp() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1462 >(1462)(Pointer); return __sdkResult != 0; }
    public void @CreateDeadPedMoney() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1463 >(1463)(Pointer); }
    public void @CreateDeadPedPickupCoors(NativePointer<float> @pX,NativePointer<float> @pY,NativePointer<float> @pZ) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1464 >(1464)(Pointer,@pX.Pointer,@pY.Pointer,@pZ.Pointer); }
    public void @CreateDeadPedWeaponPickups() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1465 >(1465)(Pointer); }
    public static void @Initialise() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1466 >(1466)(); }
    public void @SetPedStats(ePedStats @statsType) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1467 >(1467)(Pointer,(int)@statsType); }
    public void @Update() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1468 >(1468)(Pointer); }
    public void @SetMoveState(eMoveState @moveState) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1469 >(1469)(Pointer,(int)@moveState); }
    public void @SetMoveAnimSpeed(CAnimBlendAssociation? @association) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1470 >(1470)(Pointer,@association?.Pointer ?? IntPtr.Zero); }
    public void @StopNonPartialAnims() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1471 >(1471)(Pointer); }
    public void @RestartNonPartialAnims() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1472 >(1472)(Pointer); }
    public bool @CanUseTorsoWhenLooking() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1473 >(1473)(Pointer); return __sdkResult != 0; }
    public void @SetLookFlag(float @lookHeading,bool @likeUnused,bool @arg2) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1474 >(1474)(Pointer,@lookHeading,(@likeUnused ? 1 : 0),(@arg2 ? 1 : 0)); }
    public void @SetLookFlag(CEntity? @lookingTo,bool @likeUnused,bool @arg2) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1475 >(1475)(Pointer,@lookingTo?.Pointer ?? IntPtr.Zero,(@likeUnused ? 1 : 0),(@arg2 ? 1 : 0)); }
    public void @SetAimFlag(CEntity? @aimingTo) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1476 >(1476)(Pointer,@aimingTo?.Pointer ?? IntPtr.Zero); }
    public void @ClearAimFlag() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1477 >(1477)(Pointer); }
    public int @GetLocalDirection(CVector2D @arg0) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1478 >(1478)(Pointer,@arg0.Pointer); return __sdkResult; }
    public bool @IsPedShootable() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1479 >(1479)(Pointer); return __sdkResult != 0; }
    public bool @UseGroundColModel() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1480 >(1480)(Pointer); return __sdkResult != 0; }
    public bool @CanPedReturnToState() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1481 >(1481)(Pointer); return __sdkResult != 0; }
    public bool @CanSetPedState() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1482 >(1482)(Pointer); return __sdkResult != 0; }
    public bool @CanBeArrested() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1483 >(1483)(Pointer); return __sdkResult != 0; }
    public bool @CanStrafeOrMouseControl() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1484 >(1484)(Pointer); return __sdkResult != 0; }
    public bool @CanBeDeleted() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1485 >(1485)(Pointer); return __sdkResult != 0; }
    public bool @CanBeDeletedEvenInVehicle() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1486 >(1486)(Pointer); return __sdkResult != 0; }
    public void @RemoveGogglesModel() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1487 >(1487)(Pointer); }
    public int @GetWeaponSlot(eWeaponType @weaponType) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1488 >(1488)(Pointer,(int)@weaponType); return __sdkResult; }
    public void @GrantAmmo(eWeaponType @weaponType,uint @ammo) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1489 >(1489)(Pointer,(int)@weaponType,@ammo); }
    public void @SetAmmo(eWeaponType @weaponType,uint @ammo) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1490 >(1490)(Pointer,(int)@weaponType,@ammo); }
    public bool @DoWeHaveWeaponAvailable(eWeaponType @weaponType) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1491 >(1491)(Pointer,(int)@weaponType); return __sdkResult != 0; }
    public bool @DoGunFlash(int @arg0,bool @arg1) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1492 >(1492)(Pointer,@arg0,(@arg1 ? 1 : 0)); return __sdkResult != 0; }
    public void @SetGunFlashAlpha(bool @rightHand) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1493 >(1493)(Pointer,(@rightHand ? 1 : 0)); }
    public void @ResetGunFlashAlpha() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1494 >(1494)(Pointer); }
    public float @GetBikeRidingSkill() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1495 >(1495)(Pointer); return __sdkResult; }
    public void @ShoulderBoneRotation(RpClump? @clump) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1496 >(1496)(Pointer,@clump?.Pointer ?? IntPtr.Zero); }
    public void @SetLookTimer(uint @time) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1497 >(1497)(Pointer,@time); }
    public bool @IsPlayer() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1498 >(1498)(Pointer); return __sdkResult != 0; }
    public void @SetPedPositionInCar() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1499 >(1499)(Pointer); }
    public void @RestoreHeadingRate() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1500 >(1500)(Pointer); }
    public static void @RestoreHeadingRateCB(CAnimBlendAssociation? @association,NativePointer<IntPtr> @data) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1501 >(1501)(@association?.Pointer ?? IntPtr.Zero,@data.Pointer); }
    public void @SetRadioStation() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1502 >(1502)(Pointer); }
    public void @PositionAttachedPed() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1503 >(1503)(Pointer); }
    public void @Undress(NativePointer<sbyte> @modelName) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1504 >(1504)(Pointer,@modelName.Pointer); }
    public void @Dress() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1505 >(1505)(Pointer); }
    public bool @IsAlive() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1506 >(1506)(Pointer); return __sdkResult != 0; }
    public void @UpdateStatEnteringVehicle() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1507 >(1507)(Pointer); }
    public void @UpdateStatLeavingVehicle() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1508 >(1508)(Pointer); }
    public void @GetTransformedBonePosition(RwV3d @inOffsetOutPosn,uint @boneId,bool @updateSkinBones) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1509 >(1509)(Pointer,@inOffsetOutPosn.Pointer,@boneId,(@updateSkinBones ? 1 : 0)); }
    public void @ReleaseCoverPoint() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1510 >(1510)(Pointer); }
    public CTask? @GetHoldingTask() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1511 >(1511)(Pointer); return __sdkResult == IntPtr.Zero ? null : new CTask(__sdkResult); }
    public CEntity? @GetEntityThatThisPedIsHolding() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1512 >(1512)(Pointer); return __sdkResult == IntPtr.Zero ? null : new CEntity(__sdkResult); }
    public void @DropEntityThatThisPedIsHolding(byte @arg0) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1513 >(1513)(Pointer,@arg0); }
    public bool @CanThrowEntityThatThisPedIsHolding() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1514 >(1514)(Pointer); return __sdkResult != 0; }
    public bool @IsPlayingHandSignal() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1515 >(1515)(Pointer); return __sdkResult != 0; }
    public void @StopPlayingHandSignal() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1516 >(1516)(Pointer); }
    public float @GetWalkAnimSpeed() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1517 >(1517)(Pointer); return __sdkResult; }
    public void @SetPedDefaultDecisionMaker() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1518 >(1518)(Pointer); }
    public bool @CanSeeEntity(CEntity? @entity,float @limitAngle) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1519 >(1519)(Pointer,@entity?.Pointer ?? IntPtr.Zero,@limitAngle); return __sdkResult != 0; }
    public bool @PositionPedOutOfCollision(int @arg0,CVehicle? @arg1,bool @arg2) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1520 >(1520)(Pointer,@arg0,@arg1?.Pointer ?? IntPtr.Zero,(@arg2 ? 1 : 0)); return __sdkResult != 0; }
    public bool @PositionAnyPedOutOfCollision() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1521 >(1521)(Pointer); return __sdkResult != 0; }
    public bool @OurPedCanSeeThisEntity(CEntity? @entity,bool @isSpotted) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1522 >(1522)(Pointer,@entity?.Pointer ?? IntPtr.Zero,(@isSpotted ? 1 : 0)); return __sdkResult != 0; }
    public void @SortPeds(NativePointer<IntPtr> @pedList,int @arg1,int @arg2) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1523 >(1523)(Pointer,@pedList.Pointer,@arg1,@arg2); }
    public void @ClearLookFlag() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1524 >(1524)(Pointer); }
    public float @WorkOutHeadingForMovingFirstPerson(float @heading) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1525 >(1525)(Pointer,@heading); return __sdkResult; }
    public void @UpdatePosition() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1526 >(1526)(Pointer); }
    public void @ProcessBuoyancy() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1527 >(1527)(Pointer); }
    public bool @IsPedInControl() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1528 >(1528)(Pointer); return __sdkResult != 0; }
    public void @RemoveWeaponModel(int @modelIndex) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1529 >(1529)(Pointer,@modelIndex); }
    public void @AddGogglesModel(int @modelIndex,NativePointer<bool> @pGogglesType) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1530 >(1530)(Pointer,@modelIndex,@pGogglesType.Pointer); }
    public void @PutOnGoggles() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1531 >(1531)(Pointer); }
    public sbyte @GetWeaponSkill(eWeaponType @weaponType) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1532 >(1532)(Pointer,(int)@weaponType); return __sdkResult; }
    public void @SetWeaponSkill(eWeaponType @weaponType,sbyte @skill) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1533 >(1533)(Pointer,(int)@weaponType,@skill); }
    public void @ClearLook() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1534 >(1534)(Pointer); }
    public bool @TurnBody() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1535 >(1535)(Pointer); return __sdkResult != 0; }
    public bool @IsPointerValid() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1536 >(1536)(Pointer); return __sdkResult != 0; }
    public void @GetBonePosition(RwV3d @outPosition,uint @boneId,bool @updateSkinBones) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1537 >(1537)(Pointer,@outPosition.Pointer,@boneId,(@updateSkinBones ? 1 : 0)); }
    public CObject? @GiveObjectToPedToHold(int @modelIndex,byte @replace) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1538 >(1538)(Pointer,@modelIndex,@replace); return __sdkResult == IntPtr.Zero ? null : new CObject(__sdkResult); }
    public void @SetPedState(ePedState @pedState) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1539 >(1539)(Pointer,(int)@pedState); }
    public void @SetCharCreatedBy(byte @createdBy) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1540 >(1540)(Pointer,@createdBy); }
    public void @CalculateNewVelocity() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1541 >(1541)(Pointer); }
    public void @CalculateNewOrientation() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1542 >(1542)(Pointer); }
    public void @ClearAll() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1543 >(1543)(Pointer); }
    public void @DoFootLanded(bool @leftFoot,byte @arg1) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1544 >(1544)(Pointer,(@leftFoot ? 1 : 0),@arg1); }
    public void @PlayFootSteps() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1545 >(1545)(Pointer); }
    public void @AddWeaponModel(int @modelIndex) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1546 >(1546)(Pointer,@modelIndex); }
    public void @TakeOffGoggles() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1547 >(1547)(Pointer); }
    public void @GiveWeapon(eWeaponType @weaponType,uint @ammo,bool @likeUnused) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1548 >(1548)(Pointer,(int)@weaponType,@ammo,(@likeUnused ? 1 : 0)); }
    public void @SetCurrentWeapon(int @slot) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1549 >(1549)(Pointer,@slot); }
    public void @SetCurrentWeapon(eWeaponType @weaponType) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1550 >(1550)(Pointer,(int)@weaponType); }
    public void @ClearWeapon(eWeaponType @weaponType) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1551 >(1551)(Pointer,(int)@weaponType); }
    public void @ClearWeapons() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1552 >(1552)(Pointer); }
    public void @RemoveWeaponWhenEnteringVehicle(int @arg0) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1553 >(1553)(Pointer,@arg0); }
    public void @ReplaceWeaponWhenExitingVehicle() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1554 >(1554)(Pointer); }
    public void @ReplaceWeaponForScriptedCutscene() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1555 >(1555)(Pointer); }
    public void @RemoveWeaponForScriptedCutscene() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1556 >(1556)(Pointer); }
    public sbyte @GetWeaponSkill() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1557 >(1557)(Pointer); return __sdkResult; }
    public void @PreRenderAfterTest() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1558 >(1558)(Pointer); }
    public void @SetIdle() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1559 >(1559)(Pointer); }
    public void @SetLook(float @heading) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1560 >(1560)(Pointer,@heading); }
    public void @SetLook(CEntity? @entity) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1561 >(1561)(Pointer,@entity?.Pointer ?? IntPtr.Zero); }
    public void @Look() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1562 >(1562)(Pointer); }
    public CEntity? @AttachPedToEntity(CEntity? @entity,CVector @offset,ushort @arg2,float @arg3,eWeaponType @weaponType) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1563 >(1563)(Pointer,@entity?.Pointer ?? IntPtr.Zero,@offset.Pointer,@arg2,@arg3,(int)@weaponType); return __sdkResult == IntPtr.Zero ? null : new CEntity(__sdkResult); }
    public CEntity? @AttachPedToBike(CEntity? @entity,CVector @offset,ushort @arg2,float @arg3,float @arg4,eWeaponType @weaponType) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1564 >(1564)(Pointer,@entity?.Pointer ?? IntPtr.Zero,@offset.Pointer,@arg2,@arg3,@arg4,(int)@weaponType); return __sdkResult == IntPtr.Zero ? null : new CEntity(__sdkResult); }
    public void @DettachPedFromEntity() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1565 >(1565)(Pointer); }
    public void @SetAimFlag(float @heading) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1566 >(1566)(Pointer,@heading); }
    public bool @CanWeRunAndFireWithWeapon() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1567 >(1567)(Pointer); return __sdkResult != 0; }
    public void @RequestDelayedWeapon() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1568 >(1568)(Pointer); }
    public void @GiveDelayedWeapon(eWeaponType @weaponType,uint @ammo) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1569 >(1569)(Pointer,(int)@weaponType,@ammo); }
    public void @GiveWeaponAtStartOfFight() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1570 >(1570)(Pointer); }
    public void @GiveWeaponWhenJoiningGang() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1571 >(1571)(Pointer); }
    public bool @GetPedTalking() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1572 >(1572)(Pointer); return __sdkResult != 0; }
    public void @DisablePedSpeech(short @arg0) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1573 >(1573)(Pointer,@arg0); }
    public void @EnablePedSpeech() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1574 >(1574)(Pointer); }
    public void @DisablePedSpeechForScriptSpeech(short @arg0) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1575 >(1575)(Pointer,@arg0); }
    public void @EnablePedSpeechForScriptSpeech() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1576 >(1576)(Pointer); }
    public void @CanPedHoldConversation() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1577 >(1577)(Pointer); }
    public void @SayScript(int @arg0,byte @arg1,byte @arg2,byte @arg3) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1578 >(1578)(Pointer,@arg0,@arg1,@arg2,@arg3); }
    public ushort @Say(ushort @gCtx,uint @startTimeDelay,float @probability,bool @overrideSilence,bool @isForceAudible,bool @isFrontEnd) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1579 >(1579)(Pointer,@gCtx,@startTimeDelay,@probability,(@overrideSilence ? 1 : 0),(@isForceAudible ? 1 : 0),(@isFrontEnd ? 1 : 0)); return __sdkResult; }
    public void @RemoveBodyPart(int @boneId,sbyte @localDir) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1580 >(1580)(Pointer,@boneId,@localDir); }
    public void @SpawnFlyingComponent(int @arg0,sbyte @arg1) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1581 >(1581)(Pointer,@arg0,@arg1); }
    public bool @DoesLOSBulletHitPed(CColPoint @colPoint) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1582 >(1582)(Pointer,@colPoint.Pointer); return __sdkResult != 0; }
    public void @RemoveWeaponAnims(int @likeUnused,float @blendDelta) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1583 >(1583)(Pointer,@likeUnused,@blendDelta); }
    public bool @IsPedHeadAbovePos(float @zPos) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1584 >(1584)(Pointer,@zPos); return __sdkResult != 0; }
    public void @KillPedWithCar(CVehicle? @car,float @arg1,bool @arg2) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1585 >(1585)(Pointer,@car?.Pointer ?? IntPtr.Zero,@arg1,(@arg2 ? 1 : 0)); }
    public void @MakeTyresMuddySectorList(CPtrList @ptrList) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1586 >(1586)(Pointer,@ptrList.Pointer); }
    public void @DeadPedMakesTyresBloody() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1587 >(1587)(Pointer); }
    public void @SetModelIndex(uint @modelIndex) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1588 >(1588)(Pointer,@modelIndex); }
    public CWeapon? @GetWeapon() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1589 >(1589)(Pointer); return __sdkResult == IntPtr.Zero ? null : new CWeapon(__sdkResult); }
    public static NativePointer<IntPtr> @AllocateNative(uint @size) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1590 >(1590)(@size); return new NativePointer<IntPtr>(__sdkResult); }
    public static void @FreeNative(NativePointer<IntPtr> @data) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1591 >(1591)(@data.Pointer); }
}
