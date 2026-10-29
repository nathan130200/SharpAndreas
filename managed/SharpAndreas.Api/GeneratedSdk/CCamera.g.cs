// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CCamera : CPlaceable
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=3448;
    public CCamera(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_bAboveGroundTrainNodesLoaded")]
    public bool @AboveGroundTrainNodesLoaded { get => SdkMemory.Read<bool >(Pointer+24); set { SdkMemory.Write(Pointer+24,value); } }
    [NativeMember("m_bBelowGroundTrainNodesLoaded")]
    public bool @BelowGroundTrainNodesLoaded { get => SdkMemory.Read<bool >(Pointer+25); set { SdkMemory.Write(Pointer+25,value); } }
    [NativeMember("m_bCamDirectlyBehind")]
    public bool @CamDirectlyBehind { get => SdkMemory.Read<bool >(Pointer+26); set { SdkMemory.Write(Pointer+26,value); } }
    [NativeMember("m_bCamDirectlyInFront")]
    public bool @CamDirectlyInFront { get => SdkMemory.Read<bool >(Pointer+27); set { SdkMemory.Write(Pointer+27,value); } }
    [NativeMember("m_bCameraJustRestored")]
    public bool @CameraJustRestored { get => SdkMemory.Read<bool >(Pointer+28); set { SdkMemory.Write(Pointer+28,value); } }
    [NativeMember("m_bcutsceneFinished")]
    public bool @BcutsceneFinished { get => SdkMemory.Read<bool >(Pointer+29); set { SdkMemory.Write(Pointer+29,value); } }
    [NativeMember("m_bCullZoneChecksOn")]
    public bool @CullZoneChecksOn { get => SdkMemory.Read<bool >(Pointer+30); set { SdkMemory.Write(Pointer+30,value); } }
    [NativeMember("m_bFirstPersonBeingUsed")]
    public bool @FirstPersonBeingUsed { get => SdkMemory.Read<bool >(Pointer+31); set { SdkMemory.Write(Pointer+31,value); } }
    [NativeMember("m_bJustJumpedOutOf1stPersonBecauseOfTarget")]
    public bool @JustJumpedOutOf1stPersonBecauseOfTarget { get => SdkMemory.Read<bool >(Pointer+32); set { SdkMemory.Write(Pointer+32,value); } }
    [NativeMember("m_bIdleOn")]
    public bool @IdleOn { get => SdkMemory.Read<bool >(Pointer+33); set { SdkMemory.Write(Pointer+33,value); } }
    [NativeMember("m_bInATunnelAndABigVehicle")]
    public bool @InATunnelAndABigVehicle { get => SdkMemory.Read<bool >(Pointer+34); set { SdkMemory.Write(Pointer+34,value); } }
    [NativeMember("m_bInitialNodeFound")]
    public bool @InitialNodeFound { get => SdkMemory.Read<bool >(Pointer+35); set { SdkMemory.Write(Pointer+35,value); } }
    [NativeMember("m_bInitialNoNodeStaticsSet")]
    public bool @InitialNoNodeStaticsSet { get => SdkMemory.Read<bool >(Pointer+36); set { SdkMemory.Write(Pointer+36,value); } }
    [NativeMember("m_bIgnoreFadingStuffForMusic")]
    public bool @IgnoreFadingStuffForMusic { get => SdkMemory.Read<bool >(Pointer+37); set { SdkMemory.Write(Pointer+37,value); } }
    [NativeMember("m_bPlayerIsInGarage")]
    public bool @PlayerIsInGarage { get => SdkMemory.Read<bool >(Pointer+38); set { SdkMemory.Write(Pointer+38,value); } }
    [NativeMember("m_bPlayerWasOnBike")]
    public bool @PlayerWasOnBike { get => SdkMemory.Read<bool >(Pointer+39); set { SdkMemory.Write(Pointer+39,value); } }
    [NativeMember("m_bJustCameOutOfGarage")]
    public bool @JustCameOutOfGarage { get => SdkMemory.Read<bool >(Pointer+40); set { SdkMemory.Write(Pointer+40,value); } }
    [NativeMember("m_bJustInitalised")]
    public bool @JustInitalised { get => SdkMemory.Read<bool >(Pointer+41); set { SdkMemory.Write(Pointer+41,value); } }
    [NativeMember("m_bJust_Switched")]
    public bool @JustSwitched { get => SdkMemory.Read<bool >(Pointer+42); set { SdkMemory.Write(Pointer+42,value); } }
    [NativeMember("m_bLookingAtPlayer")]
    public bool @LookingAtPlayer { get => SdkMemory.Read<bool >(Pointer+43); set { SdkMemory.Write(Pointer+43,value); } }
    [NativeMember("m_bLookingAtVector")]
    public bool @LookingAtVector { get => SdkMemory.Read<bool >(Pointer+44); set { SdkMemory.Write(Pointer+44,value); } }
    [NativeMember("m_bMoveCamToAvoidGeom")]
    public bool @MoveCamToAvoidGeom { get => SdkMemory.Read<bool >(Pointer+45); set { SdkMemory.Write(Pointer+45,value); } }
    [NativeMember("m_bObbeCinematicPedCamOn")]
    public bool @ObbeCinematicPedCamOn { get => SdkMemory.Read<bool >(Pointer+46); set { SdkMemory.Write(Pointer+46,value); } }
    [NativeMember("m_bObbeCinematicCarCamOn")]
    public bool @ObbeCinematicCarCamOn { get => SdkMemory.Read<bool >(Pointer+47); set { SdkMemory.Write(Pointer+47,value); } }
    [NativeMember("m_bRestoreByJumpCut")]
    public bool @RestoreByJumpCut { get => SdkMemory.Read<bool >(Pointer+48); set { SdkMemory.Write(Pointer+48,value); } }
    [NativeMember("m_bUseNearClipScript")]
    public bool @UseNearClipScript { get => SdkMemory.Read<bool >(Pointer+49); set { SdkMemory.Write(Pointer+49,value); } }
    [NativeMember("m_bStartInterScript")]
    public bool @StartInterScript { get => SdkMemory.Read<bool >(Pointer+50); set { SdkMemory.Write(Pointer+50,value); } }
    [NativeMember("m_bStartingSpline")]
    public bool @StartingSpline { get => SdkMemory.Read<bool >(Pointer+51); set { SdkMemory.Write(Pointer+51,value); } }
    [NativeMember("m_bTargetJustBeenOnTrain")]
    public bool @TargetJustBeenOnTrain { get => SdkMemory.Read<bool >(Pointer+52); set { SdkMemory.Write(Pointer+52,value); } }
    [NativeMember("m_bTargetJustCameOffTrain")]
    public bool @TargetJustCameOffTrain { get => SdkMemory.Read<bool >(Pointer+53); set { SdkMemory.Write(Pointer+53,value); } }
    [NativeMember("m_bUseSpecialFovTrain")]
    public bool @UseSpecialFovTrain { get => SdkMemory.Read<bool >(Pointer+54); set { SdkMemory.Write(Pointer+54,value); } }
    [NativeMember("m_bUseTransitionBeta")]
    public bool @UseTransitionBeta { get => SdkMemory.Read<bool >(Pointer+55); set { SdkMemory.Write(Pointer+55,value); } }
    [NativeMember("m_bUseScriptZoomValuePed")]
    public bool @UseScriptZoomValuePed { get => SdkMemory.Read<bool >(Pointer+56); set { SdkMemory.Write(Pointer+56,value); } }
    [NativeMember("m_bUseScriptZoomValueCar")]
    public bool @UseScriptZoomValueCar { get => SdkMemory.Read<bool >(Pointer+57); set { SdkMemory.Write(Pointer+57,value); } }
    [NativeMember("m_bWaitForInterpolToFinish")]
    public bool @WaitForInterpolToFinish { get => SdkMemory.Read<bool >(Pointer+58); set { SdkMemory.Write(Pointer+58,value); } }
    [NativeMember("m_bItsOkToLookJustAtThePlayer")]
    public bool @ItsOkToLookJustAtThePlayer { get => SdkMemory.Read<bool >(Pointer+59); set { SdkMemory.Write(Pointer+59,value); } }
    [NativeMember("m_bWantsToSwitchWidescreenOff")]
    public bool @WantsToSwitchWidescreenOff { get => SdkMemory.Read<bool >(Pointer+60); set { SdkMemory.Write(Pointer+60,value); } }
    [NativeMember("m_bWideScreenOn")]
    public bool @WideScreenOn { get => SdkMemory.Read<bool >(Pointer+61); set { SdkMemory.Write(Pointer+61,value); } }
    [NativeMember("m_b1rstPersonRunCloseToAWall")]
    public bool @B1rstPersonRunCloseToAWall { get => SdkMemory.Read<bool >(Pointer+62); set { SdkMemory.Write(Pointer+62,value); } }
    [NativeMember("m_bHeadBob")]
    public bool @HeadBob { get => SdkMemory.Read<bool >(Pointer+63); set { SdkMemory.Write(Pointer+63,value); } }
    [NativeMember("m_bVehicleSuspenHigh")]
    public bool @VehicleSuspenHigh { get => SdkMemory.Read<bool >(Pointer+64); set { SdkMemory.Write(Pointer+64,value); } }
    [NativeMember("m_bEnable1rstPersonCamCntrlsScript")]
    public bool @Enable1rstPersonCamCntrlsScriptValue { get => SdkMemory.Read<bool >(Pointer+65); set { SdkMemory.Write(Pointer+65,value); } }
    [NativeMember("m_bAllow1rstPersonWeaponsCamera")]
    public bool @Allow1rstPersonWeaponsCamera { get => SdkMemory.Read<bool >(Pointer+66); set { SdkMemory.Write(Pointer+66,value); } }
    [NativeMember("m_bCooperativeCamMode")]
    public bool @CooperativeCamMode { get => SdkMemory.Read<bool >(Pointer+67); set { SdkMemory.Write(Pointer+67,value); } }
    [NativeMember("m_bAllowShootingWith2PlayersInCar")]
    public bool @AllowShootingWith2PlayersInCarValue { get => SdkMemory.Read<bool >(Pointer+68); set { SdkMemory.Write(Pointer+68,value); } }
    [NativeMember("m_bDisableFirstPersonInCar")]
    public bool @DisableFirstPersonInCar { get => SdkMemory.Read<bool >(Pointer+69); set { SdkMemory.Write(Pointer+69,value); } }
    [NativeMember("m_nModeForTwoPlayersSeparateCars")]
    public ushort @ModeForTwoPlayersSeparateCars { get => SdkMemory.Read<ushort >(Pointer+70); set { SdkMemory.Write(Pointer+70,value); } }
    [NativeMember("m_nModeForTwoPlayersSameCarShootingAllowed")]
    public ushort @ModeForTwoPlayersSameCarShootingAllowed { get => SdkMemory.Read<ushort >(Pointer+72); set { SdkMemory.Write(Pointer+72,value); } }
    [NativeMember("m_nModeForTwoPlayersSameCarShootingNotAllowed")]
    public ushort @ModeForTwoPlayersSameCarShootingNotAllowed { get => SdkMemory.Read<ushort >(Pointer+74); set { SdkMemory.Write(Pointer+74,value); } }
    [NativeMember("m_nModeForTwoPlayersNotBothInCar")]
    public ushort @ModeForTwoPlayersNotBothInCar { get => SdkMemory.Read<ushort >(Pointer+76); set { SdkMemory.Write(Pointer+76,value); } }
    [NativeMember("m_bGarageFixedCamPositionSet")]
    public bool @GarageFixedCamPositionSet { get => SdkMemory.Read<bool >(Pointer+78); set { SdkMemory.Write(Pointer+78,value); } }
    [NativeMember("m_bDoingSpecialInterPolation")]
    public bool @DoingSpecialInterPolation { get => SdkMemory.Read<bool >(Pointer+79); set { SdkMemory.Write(Pointer+79,value); } }
    [NativeMember("m_bScriptParametersSetForInterPol")]
    public bool @ScriptParametersSetForInterPol { get => SdkMemory.Read<bool >(Pointer+80); set { SdkMemory.Write(Pointer+80,value); } }
    [NativeMember("m_bFading")]
    public bool @Fading { get => SdkMemory.Read<bool >(Pointer+81); set { SdkMemory.Write(Pointer+81,value); } }
    [NativeMember("m_bMusicFading")]
    public bool @MusicFading { get => SdkMemory.Read<bool >(Pointer+82); set { SdkMemory.Write(Pointer+82,value); } }
    [NativeMember("m_bMusicFadedOut")]
    public bool @MusicFadedOut { get => SdkMemory.Read<bool >(Pointer+83); set { SdkMemory.Write(Pointer+83,value); } }
    [NativeMember("m_bFailedCullZoneTestPreviously")]
    public bool @FailedCullZoneTestPreviously { get => SdkMemory.Read<bool >(Pointer+84); set { SdkMemory.Write(Pointer+84,value); } }
    [NativeMember("m_bFadeTargetIsSplashScreen")]
    public bool @FadeTargetIsSplashScreen { get => SdkMemory.Read<bool >(Pointer+85); set { SdkMemory.Write(Pointer+85,value); } }
    [NativeMember("m_bWorldViewerBeingUsed")]
    public bool @WorldViewerBeingUsed { get => SdkMemory.Read<bool >(Pointer+86); set { SdkMemory.Write(Pointer+86,value); } }
    [NativeMember("m_bTransitionJUSTStarted")]
    public bool @TransitionJUSTStarted { get => SdkMemory.Read<bool >(Pointer+87); set { SdkMemory.Write(Pointer+87,value); } }
    [NativeMember("m_bTransitionState")]
    public bool @TransitionState { get => SdkMemory.Read<bool >(Pointer+88); set { SdkMemory.Write(Pointer+88,value); } }
    [NativeMember("m_nActiveCam")]
    public byte @ActiveCam { get => SdkMemory.Read<byte >(Pointer+89); set { SdkMemory.Write(Pointer+89,value); } }
    [NativeMember("m_nCamShakeStart")]
    public uint @CamShakeStart { get => SdkMemory.Read<uint >(Pointer+92); set { SdkMemory.Write(Pointer+92,value); } }
    [NativeMember("m_nFirstPersonCamLastInputTime")]
    public uint @FirstPersonCamLastInputTime { get => SdkMemory.Read<uint >(Pointer+96); set { SdkMemory.Write(Pointer+96,value); } }
    [NativeMember("m_nLongestTimeInMill")]
    public uint @LongestTimeInMill { get => SdkMemory.Read<uint >(Pointer+100); set { SdkMemory.Write(Pointer+100,value); } }
    [NativeMember("m_nNumberOfTrainCamNodes")]
    public uint @NumberOfTrainCamNodes { get => SdkMemory.Read<uint >(Pointer+104); set { SdkMemory.Write(Pointer+104,value); } }
    [NativeMember("m_nTimeLastChange")]
    public uint @TimeLastChange { get => SdkMemory.Read<uint >(Pointer+108); set { SdkMemory.Write(Pointer+108,value); } }
    [NativeMember("m_nTimeWeLeftIdle_StillNoInput")]
    public uint @TimeWeLeftIdleStillNoInput { get => SdkMemory.Read<uint >(Pointer+112); set { SdkMemory.Write(Pointer+112,value); } }
    [NativeMember("m_nTimeWeEnteredIdle")]
    public uint @TimeWeEnteredIdle { get => SdkMemory.Read<uint >(Pointer+116); set { SdkMemory.Write(Pointer+116,value); } }
    [NativeMember("m_nTimeTransitionStart")]
    public uint @TimeTransitionStart { get => SdkMemory.Read<uint >(Pointer+120); set { SdkMemory.Write(Pointer+120,value); } }
    [NativeMember("m_nTransitionDuration")]
    public uint @TransitionDuration { get => SdkMemory.Read<uint >(Pointer+124); set { SdkMemory.Write(Pointer+124,value); } }
    [NativeMember("m_nTransitionDurationTargetCoors")]
    public uint @TransitionDurationTargetCoors { get => SdkMemory.Read<uint >(Pointer+128); set { SdkMemory.Write(Pointer+128,value); } }
    [NativeMember("m_nBlurBlue")]
    public uint @BlurBlue { get => SdkMemory.Read<uint >(Pointer+132); set { SdkMemory.Write(Pointer+132,value); } }
    [NativeMember("m_nBlurGreen")]
    public uint @BlurGreen { get => SdkMemory.Read<uint >(Pointer+136); set { SdkMemory.Write(Pointer+136,value); } }
    [NativeMember("m_nBlurRed")]
    public uint @BlurRed { get => SdkMemory.Read<uint >(Pointer+140); set { SdkMemory.Write(Pointer+140,value); } }
    [NativeMember("m_nBlurType")]
    public uint @BlurType { get => SdkMemory.Read<uint >(Pointer+144); set { SdkMemory.Write(Pointer+144,value); } }
    [NativeMember("m_nWorkOutSpeedThisNumFrames")]
    public uint @WorkOutSpeedThisCountFrames { get => SdkMemory.Read<uint >(Pointer+148); set { SdkMemory.Write(Pointer+148,value); } }
    [NativeMember("m_nNumFramesSoFar")]
    public uint @CountFramesSoFar { get => SdkMemory.Read<uint >(Pointer+152); set { SdkMemory.Write(Pointer+152,value); } }
    [NativeMember("m_nCurrentTrainCamNode")]
    public uint @CurrentTrainCamNode { get => SdkMemory.Read<uint >(Pointer+156); set { SdkMemory.Write(Pointer+156,value); } }
    [NativeMember("m_nMotionBlur")]
    public uint @MotionBlur { get => SdkMemory.Read<uint >(Pointer+160); set { SdkMemory.Write(Pointer+160,value); } }
    [NativeMember("m_nMotionBlurAddAlpha")]
    public uint @MotionBlurAddAlpha { get => SdkMemory.Read<uint >(Pointer+164); set { SdkMemory.Write(Pointer+164,value); } }
    [NativeMember("m_nCheckCullZoneThisNumFrames")]
    public uint @CheckCullZoneThisCountFrames { get => SdkMemory.Read<uint >(Pointer+168); set { SdkMemory.Write(Pointer+168,value); } }
    [NativeMember("m_nZoneCullFrameNumWereAt")]
    public uint @ZoneCullFrameCountWereAt { get => SdkMemory.Read<uint >(Pointer+172); set { SdkMemory.Write(Pointer+172,value); } }
    [NativeMember("m_nWhoIsInControlOfTheCamera")]
    public uint @WhoIsInControlOfTheCamera { get => SdkMemory.Read<uint >(Pointer+176); set { SdkMemory.Write(Pointer+176,value); } }
    [NativeMember("m_nCarZoom")]
    public uint @CarZoom { get => SdkMemory.Read<uint >(Pointer+180); set { SdkMemory.Write(Pointer+180,value); } }
    [NativeMember("m_fCarZoomBase")]
    public float @CarZoomBase { get => SdkMemory.Read<float >(Pointer+184); set { SdkMemory.Write(Pointer+184,value); } }
    [NativeMember("m_fCarZoomTotal")]
    public float @CarZoomTotal { get => SdkMemory.Read<float >(Pointer+188); set { SdkMemory.Write(Pointer+188,value); } }
    [NativeMember("m_fCarZoomSmoothed")]
    public float @CarZoomSmoothed { get => SdkMemory.Read<float >(Pointer+192); set { SdkMemory.Write(Pointer+192,value); } }
    [NativeMember("m_fCarZoomValueScript")]
    public float @CarZoomValueScript { get => SdkMemory.Read<float >(Pointer+196); set { SdkMemory.Write(Pointer+196,value); } }
    [NativeMember("m_nPedZoom")]
    public uint @PedZoom { get => SdkMemory.Read<uint >(Pointer+200); set { SdkMemory.Write(Pointer+200,value); } }
    [NativeMember("m_fPedZoomBase")]
    public float @PedZoomBase { get => SdkMemory.Read<float >(Pointer+204); set { SdkMemory.Write(Pointer+204,value); } }
    [NativeMember("m_fPedZoomTotal")]
    public float @PedZoomTotal { get => SdkMemory.Read<float >(Pointer+208); set { SdkMemory.Write(Pointer+208,value); } }
    [NativeMember("m_fPedZoomSmoothed")]
    public float @PedZoomSmoothed { get => SdkMemory.Read<float >(Pointer+212); set { SdkMemory.Write(Pointer+212,value); } }
    [NativeMember("m_fPedZoomValueScript")]
    public float @PedZoomValueScript { get => SdkMemory.Read<float >(Pointer+216); set { SdkMemory.Write(Pointer+216,value); } }
    [NativeMember("m_fCamFrontXNorm")]
    public float @CamFrontXNorm { get => SdkMemory.Read<float >(Pointer+220); set { SdkMemory.Write(Pointer+220,value); } }
    [NativeMember("m_fCamFrontYNorm")]
    public float @CamFrontYNorm { get => SdkMemory.Read<float >(Pointer+224); set { SdkMemory.Write(Pointer+224,value); } }
    [NativeMember("m_fDistanceToWater")]
    public float @DistanceToWater { get => SdkMemory.Read<float >(Pointer+228); set { SdkMemory.Write(Pointer+228,value); } }
    [NativeMember("m_fHeightOfNearestWater")]
    public float @HeightOfNearestWater { get => SdkMemory.Read<float >(Pointer+232); set { SdkMemory.Write(Pointer+232,value); } }
    [NativeMember("m_fFOVDuringInter")]
    public float @FOVDuringInter { get => SdkMemory.Read<float >(Pointer+236); set { SdkMemory.Write(Pointer+236,value); } }
    [NativeMember("m_fLODDistMultiplier")]
    public float @LODDistMultiplier { get => SdkMemory.Read<float >(Pointer+240); set { SdkMemory.Write(Pointer+240,value); } }
    [NativeMember("m_fGenerationDistMultiplier")]
    public float @GenerationDistanceMultiplier { get => SdkMemory.Read<float >(Pointer+244); set { SdkMemory.Write(Pointer+244,value); } }
    [NativeMember("m_fAlphaSpeedAtStartInter")]
    public float @AlphaSpeedAtStartInter { get => SdkMemory.Read<float >(Pointer+248); set { SdkMemory.Write(Pointer+248,value); } }
    [NativeMember("m_fAlphaWhenInterPol")]
    public float @AlphaWhenInterPol { get => SdkMemory.Read<float >(Pointer+252); set { SdkMemory.Write(Pointer+252,value); } }
    [NativeMember("m_fAlphaDuringInterPol")]
    public float @AlphaDuringInterPol { get => SdkMemory.Read<float >(Pointer+256); set { SdkMemory.Write(Pointer+256,value); } }
    [NativeMember("m_fBetaDuringInterPol")]
    public float @BetaDuringInterPol { get => SdkMemory.Read<float >(Pointer+260); set { SdkMemory.Write(Pointer+260,value); } }
    [NativeMember("m_fBetaSpeedAtStartInter")]
    public float @BetaSpeedAtStartInter { get => SdkMemory.Read<float >(Pointer+264); set { SdkMemory.Write(Pointer+264,value); } }
    [NativeMember("m_fBetaWhenInterPol")]
    public float @BetaWhenInterPol { get => SdkMemory.Read<float >(Pointer+268); set { SdkMemory.Write(Pointer+268,value); } }
    [NativeMember("m_fFOVWhenInterPol")]
    public float @FOVWhenInterPol { get => SdkMemory.Read<float >(Pointer+272); set { SdkMemory.Write(Pointer+272,value); } }
    [NativeMember("m_fFOVSpeedAtStartInter")]
    public float @FOVSpeedAtStartInter { get => SdkMemory.Read<float >(Pointer+276); set { SdkMemory.Write(Pointer+276,value); } }
    [NativeMember("m_fStartingBetaForInterPol")]
    public float @StartingBetaForInterPol { get => SdkMemory.Read<float >(Pointer+280); set { SdkMemory.Write(Pointer+280,value); } }
    [NativeMember("m_fStartingAlphaForInterPol")]
    public float @StartingAlphaForInterPol { get => SdkMemory.Read<float >(Pointer+284); set { SdkMemory.Write(Pointer+284,value); } }
    [NativeMember("m_fPedOrientForBehindOrInFront")]
    public float @PedOrientForBehindOrInFront { get => SdkMemory.Read<float >(Pointer+288); set { SdkMemory.Write(Pointer+288,value); } }
    [NativeMember("m_fCameraAverageSpeed")]
    public float @CameraAverageSpeed { get => SdkMemory.Read<float >(Pointer+292); set { SdkMemory.Write(Pointer+292,value); } }
    [NativeMember("m_fCameraSpeedSoFar")]
    public float @CameraSpeedSoFar { get => SdkMemory.Read<float >(Pointer+296); set { SdkMemory.Write(Pointer+296,value); } }
    [NativeMember("m_fCamShakeForce")]
    public float @CamShakeForce { get => SdkMemory.Read<float >(Pointer+300); set { SdkMemory.Write(Pointer+300,value); } }
    [NativeMember("m_fFovForTrain")]
    public float @FovForTrain { get => SdkMemory.Read<float >(Pointer+304); set { SdkMemory.Write(Pointer+304,value); } }
    [NativeMember("m_fFOV_Wide_Screen")]
    public float @FOVWideScreen { get => SdkMemory.Read<float >(Pointer+308); set { SdkMemory.Write(Pointer+308,value); } }
    [NativeMember("m_fNearClipScript")]
    public float @NearClipScript { get => SdkMemory.Read<float >(Pointer+312); set { SdkMemory.Write(Pointer+312,value); } }
    [NativeMember("m_fOldBetaDiff")]
    public float @OldBetaDiff { get => SdkMemory.Read<float >(Pointer+316); set { SdkMemory.Write(Pointer+316,value); } }
    [NativeMember("m_fPositionAlongSpline")]
    public float @PositionAlongSpline { get => SdkMemory.Read<float >(Pointer+320); set { SdkMemory.Write(Pointer+320,value); } }
    [NativeMember("m_fScreenReductionPercentage")]
    public float @ScreenReductionPercentage { get => SdkMemory.Read<float >(Pointer+324); set { SdkMemory.Write(Pointer+324,value); } }
    [NativeMember("m_fScreenReductionSpeed")]
    public float @ScreenReductionSpeed { get => SdkMemory.Read<float >(Pointer+328); set { SdkMemory.Write(Pointer+328,value); } }
    [NativeMember("m_fAlphaForPlayerAnim1rstPerson")]
    public float @AlphaForPlayerAnim1rstPerson { get => SdkMemory.Read<float >(Pointer+332); set { SdkMemory.Write(Pointer+332,value); } }
    [NativeMember("m_fOrientation")]
    public float @Orientation { get => SdkMemory.Read<float >(Pointer+336); set { SdkMemory.Write(Pointer+336,value); } }
    [NativeMember("m_fPlayerExhaustion")]
    public float @PlayerExhaustion { get => SdkMemory.Read<float >(Pointer+340); set { SdkMemory.Write(Pointer+340,value); } }
    [NativeMember("m_fSoundDistUp")]
    public float @SoundDistanceUp { get => SdkMemory.Read<float >(Pointer+344); set { SdkMemory.Write(Pointer+344,value); } }
    [NativeMember("m_fSoundDistUpAsRead")]
    public float @SoundDistanceUpAsRead { get => SdkMemory.Read<float >(Pointer+348); set { SdkMemory.Write(Pointer+348,value); } }
    [NativeMember("m_fSoundDistUpAsReadOld")]
    public float @SoundDistanceUpAsReadOld { get => SdkMemory.Read<float >(Pointer+352); set { SdkMemory.Write(Pointer+352,value); } }
    [NativeMember("m_fAvoidTheGeometryProbsTimer")]
    public float @AvoidTheGeometryProbsTimer { get => SdkMemory.Read<float >(Pointer+356); set { SdkMemory.Write(Pointer+356,value); } }
    [NativeMember("m_nAvoidTheGeometryProbsDirn")]
    public ushort @AvoidTheGeometryProbsDirn { get => SdkMemory.Read<ushort >(Pointer+360); set { SdkMemory.Write(Pointer+360,value); } }
    [NativeMember("m_fWideScreenReductionAmount")]
    public float @WideScreenReductionAmount { get => SdkMemory.Read<float >(Pointer+364); set { SdkMemory.Write(Pointer+364,value); } }
    [NativeMember("m_fStartingFOVForInterPol")]
    public float @StartingFOVForInterPol { get => SdkMemory.Read<float >(Pointer+368); set { SdkMemory.Write(Pointer+368,value); } }
    [NativeMember("m_aCams")]
    public NativeObjectArray<CCam> @Cams { get => new NativeObjectArray<CCam>(Pointer+372,3,568); }
    [NativeMember("m_pToGarageWeAreIn")]
    public CGarage? @ToGarageWeAreIn { get => SdkMemory.Read<IntPtr>(Pointer+2076) == IntPtr.Zero ? null : new CGarage(SdkMemory.Read<IntPtr>(Pointer+2076)); set { SdkMemory.Write(Pointer+2076,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_pToGarageWeAreInForHackAvoidFirstPerson")]
    public CGarage? @ToGarageWeAreInForHackAvoidFirstPerson { get => SdkMemory.Read<IntPtr>(Pointer+2080) == IntPtr.Zero ? null : new CGarage(SdkMemory.Read<IntPtr>(Pointer+2080)); set { SdkMemory.Write(Pointer+2080,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_PlayerMode")]
    public CQueuedMode @PlayerMode { get => new CQueuedMode(Pointer+2084); set { SdkMemory.Copy(value.Pointer,Pointer+2084,12); } }
    [NativeMember("m_PlayerWeaponMode")]
    public CQueuedMode @PlayerWeaponMode { get => new CQueuedMode(Pointer+2096); set { SdkMemory.Copy(value.Pointer,Pointer+2096,12); } }
    [NativeMember("m_vecPreviousCameraPosition")]
    public CVector @PreviousCameraPosition { get => new CVector(Pointer+2108); set { SdkMemory.Copy(value.Pointer,Pointer+2108,12); } }
    [NativeMember("m_vecRealPreviousCameraPosition")]
    public CVector @RealPreviousCameraPosition { get => new CVector(Pointer+2120); set { SdkMemory.Copy(value.Pointer,Pointer+2120,12); } }
    [NativeMember("m_vecAimingTargetCoors")]
    public CVector @AimingTargetCoors { get => new CVector(Pointer+2132); set { SdkMemory.Copy(value.Pointer,Pointer+2132,12); } }
    [NativeMember("m_vecFixedModeVector")]
    public CVector @FixedModeVector { get => new CVector(Pointer+2144); set { SdkMemory.Copy(value.Pointer,Pointer+2144,12); } }
    [NativeMember("m_vecFixedModeSource")]
    public CVector @FixedModeSource { get => new CVector(Pointer+2156); set { SdkMemory.Copy(value.Pointer,Pointer+2156,12); } }
    [NativeMember("m_vecFixedModeUpOffSet")]
    public CVector @FixedModeUpOffSet { get => new CVector(Pointer+2168); set { SdkMemory.Copy(value.Pointer,Pointer+2168,12); } }
    [NativeMember("m_vecCutSceneOffset")]
    public CVector @CutSceneOffset { get => new CVector(Pointer+2180); set { SdkMemory.Copy(value.Pointer,Pointer+2180,12); } }
    [NativeMember("m_vecStartingSourceForInterPol")]
    public CVector @StartingSourceForInterPol { get => new CVector(Pointer+2192); set { SdkMemory.Copy(value.Pointer,Pointer+2192,12); } }
    [NativeMember("m_vecStartingTargetForInterPol")]
    public CVector @StartingTargetForInterPol { get => new CVector(Pointer+2204); set { SdkMemory.Copy(value.Pointer,Pointer+2204,12); } }
    [NativeMember("m_vecStartingUpForInterPol")]
    public CVector @StartingUpForInterPol { get => new CVector(Pointer+2216); set { SdkMemory.Copy(value.Pointer,Pointer+2216,12); } }
    [NativeMember("m_vecSourceSpeedAtStartInter")]
    public CVector @SourceSpeedAtStartInter { get => new CVector(Pointer+2228); set { SdkMemory.Copy(value.Pointer,Pointer+2228,12); } }
    [NativeMember("m_vecTargetSpeedAtStartInter")]
    public CVector @TargetSpeedAtStartInter { get => new CVector(Pointer+2240); set { SdkMemory.Copy(value.Pointer,Pointer+2240,12); } }
    [NativeMember("m_vecUpSpeedAtStartInter")]
    public CVector @UpSpeedAtStartInter { get => new CVector(Pointer+2252); set { SdkMemory.Copy(value.Pointer,Pointer+2252,12); } }
    [NativeMember("m_vecSourceWhenInterPol")]
    public CVector @SourceWhenInterPol { get => new CVector(Pointer+2264); set { SdkMemory.Copy(value.Pointer,Pointer+2264,12); } }
    [NativeMember("m_vecTargetWhenInterPol")]
    public CVector @TargetWhenInterPol { get => new CVector(Pointer+2276); set { SdkMemory.Copy(value.Pointer,Pointer+2276,12); } }
    [NativeMember("m_vecUpWhenInterPol")]
    public CVector @UpWhenInterPol { get => new CVector(Pointer+2288); set { SdkMemory.Copy(value.Pointer,Pointer+2288,12); } }
    [NativeMember("m_vecClearGeometryVec")]
    public CVector @ClearGeometryVec { get => new CVector(Pointer+2300); set { SdkMemory.Copy(value.Pointer,Pointer+2300,12); } }
    [NativeMember("m_vecGameCamPos")]
    public CVector @GameCamPosition { get => new CVector(Pointer+2312); set { SdkMemory.Copy(value.Pointer,Pointer+2312,12); } }
    [NativeMember("m_vecSourceDuringInter")]
    public CVector @SourceDuringInter { get => new CVector(Pointer+2324); set { SdkMemory.Copy(value.Pointer,Pointer+2324,12); } }
    [NativeMember("m_vecTargetDuringInter")]
    public CVector @TargetDuringInter { get => new CVector(Pointer+2336); set { SdkMemory.Copy(value.Pointer,Pointer+2336,12); } }
    [NativeMember("m_vecUpDuringInter")]
    public CVector @UpDuringInter { get => new CVector(Pointer+2348); set { SdkMemory.Copy(value.Pointer,Pointer+2348,12); } }
    [NativeMember("m_vecAttachedCamOffset")]
    public CVector @AttachedCamOffset { get => new CVector(Pointer+2360); set { SdkMemory.Copy(value.Pointer,Pointer+2360,12); } }
    [NativeMember("m_vecAttachedCamLookAt")]
    public CVector @AttachedCamLookAt { get => new CVector(Pointer+2372); set { SdkMemory.Copy(value.Pointer,Pointer+2372,12); } }
    [NativeMember("m_fAttachedCamAngle")]
    public float @AttachedCamAngle { get => SdkMemory.Read<float >(Pointer+2384); set { SdkMemory.Write(Pointer+2384,value); } }
    [NativeMember("m_pRwCamera")]
    public RwCamera? @RenderWareCamera { get => SdkMemory.Read<IntPtr>(Pointer+2388) == IntPtr.Zero ? null : new RwCamera(SdkMemory.Read<IntPtr>(Pointer+2388)); set { SdkMemory.Write(Pointer+2388,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_pTargetEntity")]
    public CEntity? @TargetEntity { get => SdkMemory.Read<IntPtr>(Pointer+2392) == IntPtr.Zero ? null : new CEntity(SdkMemory.Read<IntPtr>(Pointer+2392)); set { SdkMemory.Write(Pointer+2392,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_pAttachedEntity")]
    public CEntity? @AttachedEntity { get => SdkMemory.Read<IntPtr>(Pointer+2396) == IntPtr.Zero ? null : new CEntity(SdkMemory.Read<IntPtr>(Pointer+2396)); set { SdkMemory.Write(Pointer+2396,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_aPathArray")]
    public NativeObjectArray<CCamPathSplines> @PathArray { get => new NativeObjectArray<CCamPathSplines>(Pointer+2400,4,4); }
    [NativeMember("m_bMirrorActive")]
    public bool @MirrorActive { get => SdkMemory.Read<bool >(Pointer+2416); set { SdkMemory.Write(Pointer+2416,value); } }
    [NativeMember("m_bResetOldMatrix")]
    public bool @ResetOldMatrix { get => SdkMemory.Read<bool >(Pointer+2417); set { SdkMemory.Write(Pointer+2417,value); } }
    [NativeMember("m_mCameraMatrix")]
    public CMatrix @MCameraMatrix { get => new CMatrix(Pointer+2420); set { SdkMemory.Copy(value.Pointer,Pointer+2420,72); } }
    [NativeMember("m_mCameraMatrixOld")]
    public CMatrix @MCameraMatrixOld { get => new CMatrix(Pointer+2492); set { SdkMemory.Copy(value.Pointer,Pointer+2492,72); } }
    [NativeMember("m_mViewMatrix")]
    public CMatrix @MViewMatrix { get => new CMatrix(Pointer+2564); set { SdkMemory.Copy(value.Pointer,Pointer+2564,72); } }
    [NativeMember("m_mMatInverse")]
    public CMatrix @MMatInverse { get => new CMatrix(Pointer+2636); set { SdkMemory.Copy(value.Pointer,Pointer+2636,72); } }
    [NativeMember("m_mMatMirrorInverse")]
    public CMatrix @MMatMirrorInverse { get => new CMatrix(Pointer+2708); set { SdkMemory.Copy(value.Pointer,Pointer+2708,72); } }
    [NativeMember("m_mMatMirror")]
    public CMatrix @MMatMirror { get => new CMatrix(Pointer+2780); set { SdkMemory.Copy(value.Pointer,Pointer+2780,72); } }
    [NativeMember("m_avecFrustumNormals")]
    public NativeObjectArray<CVector> @FrustumNormals { get => new NativeObjectArray<CVector>(Pointer+2852,4,12); }
    [NativeMember("m_avecFrustumWorldNormals")]
    public NativeObjectArray<CVector> @FrustumWorldNormals { get => new NativeObjectArray<CVector>(Pointer+2900,4,12); }
    [NativeMember("m_avecFrustumWorldNormals_Mirror")]
    public NativeObjectArray<CVector> @FrustumWorldNormalsMirror { get => new NativeObjectArray<CVector>(Pointer+2948,4,12); }
    [NativeMember("m_fFrustumPlaneOffsets")]
    public NativeArray<float> @FrustumPlaneOffsets { get => new NativeArray<float>(Pointer+2996,4); }
    [NativeMember("m_fFrustumPlaneOffsets_Mirror")]
    public NativeArray<float> @FrustumPlaneOffsetsMirror { get => new NativeArray<float>(Pointer+3012,4); }
    [NativeMember("m_vecRightFrustumNormal")]
    public CVector @RightFrustumNormal { get => new CVector(Pointer+3028); set { SdkMemory.Copy(value.Pointer,Pointer+3028,12); } }
    [NativeMember("m_vecBottomFrustumNormal")]
    public CVector @BottomFrustumNormal { get => new CVector(Pointer+3040); set { SdkMemory.Copy(value.Pointer,Pointer+3040,12); } }
    [NativeMember("m_vecTopFrustumNormal")]
    public CVector @TopFrustumNormal { get => new CVector(Pointer+3052); set { SdkMemory.Copy(value.Pointer,Pointer+3052,12); } }
    [NativeMember("field_BF8")]
    public float @FieldBF8 { get => SdkMemory.Read<float >(Pointer+3064); set { SdkMemory.Write(Pointer+3064,value); } }
    [NativeMember("m_fFadeAlpha")]
    public float @FadeAlpha { get => SdkMemory.Read<float >(Pointer+3068); set { SdkMemory.Write(Pointer+3068,value); } }
    [NativeMember("m_fEffectsFaderScalingFactor")]
    public float @EffectsFaderScalingFactor { get => SdkMemory.Read<float >(Pointer+3072); set { SdkMemory.Write(Pointer+3072,value); } }
    [NativeMember("m_fFadeDuration")]
    public float @FadeDuration { get => SdkMemory.Read<float >(Pointer+3076); set { SdkMemory.Write(Pointer+3076,value); } }
    [NativeMember("m_fTimeToFadeMusic")]
    public float @TimeToFadeMusic { get => SdkMemory.Read<float >(Pointer+3080); set { SdkMemory.Write(Pointer+3080,value); } }
    [NativeMember("m_fTimeToWaitToFadeMusic")]
    public float @TimeToWaitToFadeMusic { get => SdkMemory.Read<float >(Pointer+3084); set { SdkMemory.Write(Pointer+3084,value); } }
    [NativeMember("m_fFractionInterToStopMoving")]
    public float @FractionInterToStopMoving { get => SdkMemory.Read<float >(Pointer+3088); set { SdkMemory.Write(Pointer+3088,value); } }
    [NativeMember("m_fFractionInterToStopCatchUp")]
    public float @FractionInterToStopCatchUp { get => SdkMemory.Read<float >(Pointer+3092); set { SdkMemory.Write(Pointer+3092,value); } }
    [NativeMember("m_fFractionInterToStopMovingTarget")]
    public float @FractionInterToStopMovingTarget { get => SdkMemory.Read<float >(Pointer+3096); set { SdkMemory.Write(Pointer+3096,value); } }
    [NativeMember("m_fFractionInterToStopCatchUpTarget")]
    public float @FractionInterToStopCatchUpTarget { get => SdkMemory.Read<float >(Pointer+3100); set { SdkMemory.Write(Pointer+3100,value); } }
    [NativeMember("m_fGaitSwayBuffer")]
    public float @GaitSwayBuffer { get => SdkMemory.Read<float >(Pointer+3104); set { SdkMemory.Write(Pointer+3104,value); } }
    [NativeMember("m_fScriptPercentageInterToStopMoving")]
    public float @ScriptPercentageInterToStopMoving { get => SdkMemory.Read<float >(Pointer+3108); set { SdkMemory.Write(Pointer+3108,value); } }
    [NativeMember("m_fScriptPercentageInterToCatchUp")]
    public float @ScriptPercentageInterToCatchUp { get => SdkMemory.Read<float >(Pointer+3112); set { SdkMemory.Write(Pointer+3112,value); } }
    [NativeMember("m_nScriptTimeForInterPolation")]
    public uint @ScriptTimeForInterPolation { get => SdkMemory.Read<uint >(Pointer+3116); set { SdkMemory.Write(Pointer+3116,value); } }
    [NativeMember("m_nFadeInOutFlag")]
    public ushort @FadeInOutFlag { get => SdkMemory.Read<ushort >(Pointer+3120); set { SdkMemory.Write(Pointer+3120,value); } }
    [NativeMember("m_nModeObbeCamIsInForCar")]
    public int @ModeObbeCamIsInForCar { get => SdkMemory.Read<int >(Pointer+3124); set { SdkMemory.Write(Pointer+3124,value); } }
    [NativeMember("m_nModeToGoTo")]
    public short @ModeToGoTo { get => SdkMemory.Read<short >(Pointer+3128); set { SdkMemory.Write(Pointer+3128,value); } }
    [NativeMember("m_nMusicFadingDirection")]
    public short @MusicFadingDirection { get => SdkMemory.Read<short >(Pointer+3130); set { SdkMemory.Write(Pointer+3130,value); } }
    [NativeMember("m_nTypeOfSwitch")]
    public short @TypeOfSwitch { get => SdkMemory.Read<short >(Pointer+3132); set { SdkMemory.Write(Pointer+3132,value); } }
    [NativeMember("m_nFadeStartTime")]
    public uint @FadeStartTime { get => SdkMemory.Read<uint >(Pointer+3136); set { SdkMemory.Write(Pointer+3136,value); } }
    [NativeMember("m_nFadeTimeStartedMusic")]
    public uint @FadeTimeStartedMusic { get => SdkMemory.Read<uint >(Pointer+3140); set { SdkMemory.Write(Pointer+3140,value); } }
    [NativeMember("m_nExtraEntitiesCount")]
    public int @ExtraEntitiesCount { get => SdkMemory.Read<int >(Pointer+3144); set { SdkMemory.Write(Pointer+3144,value); } }
    [NativeMember("m_pExtraEntity")]
    public NativeArray<IntPtr> @ExtraEntity { get => new NativeArray<IntPtr>(Pointer+3148,2); }
    [NativeMember("m_fDuckCamMotionFactor")]
    public float @DuckCamMotionFactor { get => SdkMemory.Read<float >(Pointer+3156); set { SdkMemory.Write(Pointer+3156,value); } }
    [NativeMember("m_fDuckAimCamMotionFactor")]
    public float @DuckAimCamMotionFactor { get => SdkMemory.Read<float >(Pointer+3160); set { SdkMemory.Write(Pointer+3160,value); } }
    [NativeMember("m_fTrackLinearStartTime")]
    public float @TrackLinearStartTime { get => SdkMemory.Read<float >(Pointer+3164); set { SdkMemory.Write(Pointer+3164,value); } }
    [NativeMember("m_fTrackLinearEndTime")]
    public float @TrackLinearEndTime { get => SdkMemory.Read<float >(Pointer+3168); set { SdkMemory.Write(Pointer+3168,value); } }
    [NativeMember("m_vecTrackLinearEndPoint")]
    public CVector @TrackLinearEndPoint { get => new CVector(Pointer+3172); set { SdkMemory.Copy(value.Pointer,Pointer+3172,12); } }
    [NativeMember("m_vecTrackLinearStartPoint")]
    public CVector @TrackLinearStartPoint { get => new CVector(Pointer+3184); set { SdkMemory.Copy(value.Pointer,Pointer+3184,12); } }
    [NativeMember("m_bTrackLinearWithEase")]
    public bool @TrackLinearWithEase { get => SdkMemory.Read<bool >(Pointer+3196); set { SdkMemory.Write(Pointer+3196,value); } }
    [NativeMember("field_C7D")]
    public sbyte @FieldC7D { get => SdkMemory.Read<sbyte >(Pointer+3197); set { SdkMemory.Write(Pointer+3197,value); } }
    [NativeMember("field_C7E")]
    public sbyte @FieldC7E { get => SdkMemory.Read<sbyte >(Pointer+3198); set { SdkMemory.Write(Pointer+3198,value); } }
    [NativeMember("field_C7F")]
    public sbyte @FieldC7F { get => SdkMemory.Read<sbyte >(Pointer+3199); set { SdkMemory.Write(Pointer+3199,value); } }
    [NativeMember("m_vecTrackLinear")]
    public CVector @TrackLinear { get => new CVector(Pointer+3200); set { SdkMemory.Copy(value.Pointer,Pointer+3200,12); } }
    [NativeMember("m_bVecTrackLinearProcessed")]
    public bool @VecTrackLinearProcessed { get => SdkMemory.Read<bool >(Pointer+3212); set { SdkMemory.Write(Pointer+3212,value); } }
    [NativeMember("field_C8D")]
    public sbyte @FieldC8D { get => SdkMemory.Read<sbyte >(Pointer+3213); set { SdkMemory.Write(Pointer+3213,value); } }
    [NativeMember("field_C8E")]
    public sbyte @FieldC8E { get => SdkMemory.Read<sbyte >(Pointer+3214); set { SdkMemory.Write(Pointer+3214,value); } }
    [NativeMember("field_C8F")]
    public sbyte @FieldC8F { get => SdkMemory.Read<sbyte >(Pointer+3215); set { SdkMemory.Write(Pointer+3215,value); } }
    [NativeMember("m_fShakeIntensity")]
    public float @ShakeIntensity { get => SdkMemory.Read<float >(Pointer+3216); set { SdkMemory.Write(Pointer+3216,value); } }
    [NativeMember("m_fStartShakeTime")]
    public float @StartShakeTime { get => SdkMemory.Read<float >(Pointer+3220); set { SdkMemory.Write(Pointer+3220,value); } }
    [NativeMember("m_fEndShakeTime")]
    public float @EndShakeTime { get => SdkMemory.Read<float >(Pointer+3224); set { SdkMemory.Write(Pointer+3224,value); } }
    [NativeMember("field_C9C")]
    public int @FieldC9C { get => SdkMemory.Read<int >(Pointer+3228); set { SdkMemory.Write(Pointer+3228,value); } }
    [NativeMember("m_nShakeType")]
    public int @ShakeType { get => SdkMemory.Read<int >(Pointer+3232); set { SdkMemory.Write(Pointer+3232,value); } }
    [NativeMember("m_fStartZoomTime")]
    public float @StartZoomTime { get => SdkMemory.Read<float >(Pointer+3236); set { SdkMemory.Write(Pointer+3236,value); } }
    [NativeMember("m_fEndZoomTime")]
    public float @EndZoomTime { get => SdkMemory.Read<float >(Pointer+3240); set { SdkMemory.Write(Pointer+3240,value); } }
    [NativeMember("m_fZoomInFactor")]
    public float @ZoomInFactor { get => SdkMemory.Read<float >(Pointer+3244); set { SdkMemory.Write(Pointer+3244,value); } }
    [NativeMember("m_fZoomOutFactor")]
    public float @ZoomOutFactor { get => SdkMemory.Read<float >(Pointer+3248); set { SdkMemory.Write(Pointer+3248,value); } }
    [NativeMember("m_nZoomMode")]
    public byte @ZoomMode { get => SdkMemory.Read<byte >(Pointer+3252); set { SdkMemory.Write(Pointer+3252,value); } }
    [NativeMember("m_bFOVLerpProcessed")]
    public bool @FOVLerpProcessed { get => SdkMemory.Read<bool >(Pointer+3253); set { SdkMemory.Write(Pointer+3253,value); } }
    [NativeMember("field_CB6")]
    public sbyte @FieldCB6 { get => SdkMemory.Read<sbyte >(Pointer+3254); set { SdkMemory.Write(Pointer+3254,value); } }
    [NativeMember("field_CB7")]
    public sbyte @FieldCB7 { get => SdkMemory.Read<sbyte >(Pointer+3255); set { SdkMemory.Write(Pointer+3255,value); } }
    [NativeMember("m_fFOVNew")]
    public float @FOVNew { get => SdkMemory.Read<float >(Pointer+3256); set { SdkMemory.Write(Pointer+3256,value); } }
    [NativeMember("m_fMoveLinearStartTime")]
    public float @MoveLinearStartTime { get => SdkMemory.Read<float >(Pointer+3260); set { SdkMemory.Write(Pointer+3260,value); } }
    [NativeMember("m_fMoveLinearEndTime")]
    public float @MoveLinearEndTime { get => SdkMemory.Read<float >(Pointer+3264); set { SdkMemory.Write(Pointer+3264,value); } }
    [NativeMember("m_vecMoveLinearPosnStart")]
    public CVector @MoveLinearPositionStart { get => new CVector(Pointer+3268); set { SdkMemory.Copy(value.Pointer,Pointer+3268,12); } }
    [NativeMember("m_vecMoveLinearPosnEnd")]
    public CVector @MoveLinearPositionEnd { get => new CVector(Pointer+3280); set { SdkMemory.Copy(value.Pointer,Pointer+3280,12); } }
    [NativeMember("m_bMoveLinearWithEase")]
    public bool @MoveLinearWithEase { get => SdkMemory.Read<bool >(Pointer+3292); set { SdkMemory.Write(Pointer+3292,value); } }
    [NativeMember("field_CDD")]
    public sbyte @FieldCDD { get => SdkMemory.Read<sbyte >(Pointer+3293); set { SdkMemory.Write(Pointer+3293,value); } }
    [NativeMember("field_CDE")]
    public sbyte @FieldCDE { get => SdkMemory.Read<sbyte >(Pointer+3294); set { SdkMemory.Write(Pointer+3294,value); } }
    [NativeMember("field_CDF")]
    public sbyte @FieldCDF { get => SdkMemory.Read<sbyte >(Pointer+3295); set { SdkMemory.Write(Pointer+3295,value); } }
    [NativeMember("m_vecMoveLinear")]
    public CVector @MoveLinear { get => new CVector(Pointer+3296); set { SdkMemory.Copy(value.Pointer,Pointer+3296,12); } }
    [NativeMember("m_bVecMoveLinearProcessed")]
    public bool @VecMoveLinearProcessed { get => SdkMemory.Read<bool >(Pointer+3308); set { SdkMemory.Write(Pointer+3308,value); } }
    [NativeMember("m_bBlockZoom")]
    public bool @BlockZoom { get => SdkMemory.Read<bool >(Pointer+3309); set { SdkMemory.Write(Pointer+3309,value); } }
    [NativeMember("m_bCameraPersistPosition")]
    public bool @CameraPersistPosition { get => SdkMemory.Read<bool >(Pointer+3310); set { SdkMemory.Write(Pointer+3310,value); } }
    [NativeMember("m_bCameraPersistTrack")]
    public bool @CameraPersistTrack { get => SdkMemory.Read<bool >(Pointer+3311); set { SdkMemory.Write(Pointer+3311,value); } }
    [NativeMember("m_bCinemaCamera")]
    public bool @CinemaCamera { get => SdkMemory.Read<bool >(Pointer+3312); set { SdkMemory.Write(Pointer+3312,value); } }
    [NativeMember("field_CF1")]
    public sbyte @FieldCF1 { get => SdkMemory.Read<sbyte >(Pointer+3313); set { SdkMemory.Write(Pointer+3313,value); } }
    [NativeMember("field_CF2")]
    public sbyte @FieldCF2 { get => SdkMemory.Read<sbyte >(Pointer+3314); set { SdkMemory.Write(Pointer+3314,value); } }
    [NativeMember("field_CF3")]
    public sbyte @FieldCF3 { get => SdkMemory.Read<sbyte >(Pointer+3315); set { SdkMemory.Write(Pointer+3315,value); } }
    [NativeMember("m_aCamTweak")]
    public NativeObjectArray<CCamera___unnamed__at_D__plugin_sdk_plugin_sa_game_sa_CCamera_h_298_5__1263a4fca1> @CamTweak { get => new NativeObjectArray<CCamera___unnamed__at_D__plugin_sdk_plugin_sa_game_sa_CCamera_h_298_5__1263a4fca1>(Pointer+3316,5,16); }
    [NativeMember("m_bCameraVehicleTweaksInitialized")]
    public bool @CameraVehicleTweaksInitialized { get => SdkMemory.Read<bool >(Pointer+3396); set { SdkMemory.Write(Pointer+3396,value); } }
    [NativeMember("m_fCurrentTweakDistance")]
    public float @CurrentTweakDistance { get => SdkMemory.Read<float >(Pointer+3400); set { SdkMemory.Write(Pointer+3400,value); } }
    [NativeMember("m_fCurrentTweakAltitude")]
    public float @CurrentTweakAltitude { get => SdkMemory.Read<float >(Pointer+3404); set { SdkMemory.Write(Pointer+3404,value); } }
    [NativeMember("m_fCurrentTweakAngle")]
    public float @CurrentTweakAngle { get => SdkMemory.Read<float >(Pointer+3408); set { SdkMemory.Write(Pointer+3408,value); } }
    [NativeMember("m_nCurrentTweakModelIndex")]
    public int @CurrentTweakModelIndex { get => SdkMemory.Read<int >(Pointer+3412); set { SdkMemory.Write(Pointer+3412,value); } }
    [NativeMember("field_D58")]
    public int @FieldD58 { get => SdkMemory.Read<int >(Pointer+3416); set { SdkMemory.Write(Pointer+3416,value); } }
    [NativeMember("field_D5C")]
    public int @FieldD5C { get => SdkMemory.Read<int >(Pointer+3420); set { SdkMemory.Write(Pointer+3420,value); } }
    [NativeMember("field_D60")]
    public int @FieldD60 { get => SdkMemory.Read<int >(Pointer+3424); set { SdkMemory.Write(Pointer+3424,value); } }
    [NativeMember("field_D64")]
    public int @FieldD64 { get => SdkMemory.Read<int >(Pointer+3428); set { SdkMemory.Write(Pointer+3428,value); } }
    [NativeMember("field_D68")]
    public int @FieldD68 { get => SdkMemory.Read<int >(Pointer+3432); set { SdkMemory.Write(Pointer+3432,value); } }
    [NativeMember("field_D6C")]
    public int @FieldD6C { get => SdkMemory.Read<int >(Pointer+3436); set { SdkMemory.Write(Pointer+3436,value); } }
    [NativeMember("field_D70")]
    public int @FieldD70 { get => SdkMemory.Read<int >(Pointer+3440); set { SdkMemory.Write(Pointer+3440,value); } }
    [NativeMember("field_D74")]
    public int @FieldD74 { get => SdkMemory.Read<int >(Pointer+3444); set { SdkMemory.Write(Pointer+3444,value); } }
    [NativeMember("m_f3rdPersonCHairMultY")]
    public static float @F3rdPersonCHairMultY { get => SdkMemory.Read<float >(new IntPtr(0xB6EC10)); set { SdkMemory.Write(new IntPtr(0xB6EC10),value); } }
    [NativeMember("m_f3rdPersonCHairMultX")]
    public static float @F3rdPersonCHairMultX { get => SdkMemory.Read<float >(new IntPtr(0xB6EC14)); set { SdkMemory.Write(new IntPtr(0xB6EC14),value); } }
    [NativeMember("m_fMouseAccelVertical")]
    public static float @MouseAccelVertical { get => SdkMemory.Read<float >(new IntPtr(0xB6EC18)); set { SdkMemory.Write(new IntPtr(0xB6EC18),value); } }
    [NativeMember("m_fMouseAccelHorzntal")]
    public static float @MouseAccelHorzntal { get => SdkMemory.Read<float >(new IntPtr(0xB6EC1C)); set { SdkMemory.Write(new IntPtr(0xB6EC1C),value); } }
    [NativeMember("m_bUseMouse3rdPerson")]
    public static bool @UseMouse3rdPerson { get => SdkMemory.Read<bool >(new IntPtr(0xB6EC2E)); set { SdkMemory.Write(new IntPtr(0xB6EC2E),value); } }
    public void @AddShakeSimple(float @duration,int @type,float @intensity) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1592 >(1592)(Pointer,@duration,@type,@intensity); }
    public void @AllowShootingWith2PlayersInCar(bool @bAllowShootingWith2PlayersInCar) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1593 >(1593)(Pointer,(@bAllowShootingWith2PlayersInCar ? 1 : 0)); }
    public void @ApplyVehicleCameraTweaks(CVehicle? @vehicle) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1594 >(1594)(Pointer,@vehicle?.Pointer ?? IntPtr.Zero); }
    public void @AvoidTheGeometry(CVector? @arg2,CVector? @arg3,CVector? @arg4,float @FOV) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1595 >(1595)(Pointer,@arg2?.Pointer ?? IntPtr.Zero,@arg3?.Pointer ?? IntPtr.Zero,@arg4?.Pointer ?? IntPtr.Zero,@FOV); }
    public void @CalculateDerivedValues(bool @bForMirror,bool @bOriented) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1596 >(1596)(Pointer,(@bForMirror ? 1 : 0),(@bOriented ? 1 : 0)); }
    public void @CalculateFrustumPlanes(bool @bForMirror) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1597 >(1597)(Pointer,(@bForMirror ? 1 : 0)); }
    public float @CalculateGroundHeight(uint @type) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1598 >(1598)(Pointer,@type); return __sdkResult; }
    public void @CalculateMirroredMatrix(CVector @posn,float @MirrorV,CMatrix? @CamMat,CMatrix? @MirrorMat) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1599 >(1599)(Pointer,@posn.Pointer,@MirrorV,@CamMat?.Pointer ?? IntPtr.Zero,@MirrorMat?.Pointer ?? IntPtr.Zero); }
    public void @CamControl() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1600 >(1600)(Pointer); }
    public void @CamShake(float @arg2,float @x,float @y,float @z) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1601 >(1601)(Pointer,@arg2,@x,@y,@z); }
    public sbyte @CameraColDetAndReact(CVector? @source,CVector? @target) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1602 >(1602)(Pointer,@source?.Pointer ?? IntPtr.Zero,@target?.Pointer ?? IntPtr.Zero); return __sdkResult; }
    public void @CameraGenericModeSpecialCases(CPed? @targetPed) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1603 >(1603)(Pointer,@targetPed?.Pointer ?? IntPtr.Zero); }
    public void @CameraPedAimModeSpecialCases(CPed? @targPed) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1604 >(1604)(Pointer,@targPed?.Pointer ?? IntPtr.Zero); }
    public void @CameraPedModeSpecialCases() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1605 >(1605)(Pointer); }
    public void @CameraVehicleModeSpecialCases(CVehicle? @targVehicle) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1606 >(1606)(Pointer,@targVehicle?.Pointer ?? IntPtr.Zero); }
    public void @ClearPlayerWeaponMode() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1607 >(1607)(Pointer); }
    public bool @ConeCastCollisionResolve(CVector? @source,CVector? @center,CVector? @pVecOut,float @radius,float @arg5,NativePointer<float> @pFloatOut) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1608 >(1608)(Pointer,@source?.Pointer ?? IntPtr.Zero,@center?.Pointer ?? IntPtr.Zero,@pVecOut?.Pointer ?? IntPtr.Zero,@radius,@arg5,@pFloatOut.Pointer); return __sdkResult != 0; }
    public bool @ConsiderPedAsDucking(CPed? @ped) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1609 >(1609)(Pointer,@ped?.Pointer ?? IntPtr.Zero); return __sdkResult != 0; }
    public void @CopyCameraMatrixToRWCam(bool @bUpdateMatrix) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1610 >(1610)(Pointer,(@bUpdateMatrix ? 1 : 0)); }
    public void @DealWithMirrorBeforeConstructRenderList(bool @bActiveMirror,CVector @MirrorNormal,float @MirrorV,CMatrix? @matMirror) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1611 >(1611)(Pointer,(@bActiveMirror ? 1 : 0),@MirrorNormal.Pointer,@MirrorV,@matMirror?.Pointer ?? IntPtr.Zero); }
    public void @DeleteCutSceneCamDataMemory() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1612 >(1612)(Pointer); }
    public void @DrawBordersForWideScreen() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1613 >(1613)(Pointer); }
    public void @Enable1rstPersonCamCntrlsScript() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1614 >(1614)(Pointer); }
    public void @Enable1rstPersonWeaponsCamera() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1615 >(1615)(Pointer); }
    public void @Fade(float @fadeDuration,short @FadeInOutFlag) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1616 >(1616)(Pointer,@fadeDuration,@FadeInOutFlag); }
    public void @Find3rdPersonCamTargetVector(float @range,CVector @source,CVector? @pCamera,CVector? @pPoint) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1617 >(1617)(Pointer,@range,@source.Pointer,@pCamera?.Pointer ?? IntPtr.Zero,@pPoint?.Pointer ?? IntPtr.Zero); }
    public float @Find3rdPersonQuickAimPitch() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1618 >(1618)(Pointer); return __sdkResult; }
    public float @FindCamFOV() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1619 >(1619)(Pointer); return __sdkResult; }
    public void @FinishCutscene() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1620 >(1620)(Pointer); }
    public void @GetArrPosForVehicleType(int @type,NativePointer<int> @arrPos) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1621 >(1621)(Pointer,@type,@arrPos.Pointer); }
    public uint @GetCutSceneFinishTime() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1622 >(1622)(Pointer); return __sdkResult; }
    public bool @GetFading() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1623 >(1623)(Pointer); return __sdkResult != 0; }
    public int @GetFadingDirection() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1624 >(1624)(Pointer); return __sdkResult; }
    public CVector? @GetGameCamPosition() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1625 >(1625)(Pointer); return __sdkResult == IntPtr.Zero ? null : new CVector(__sdkResult); }
    public int @GetLookDirection() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1626 >(1626)(Pointer); return __sdkResult; }
    public bool @GetLookingForwardFirstPerson() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1627 >(1627)(Pointer); return __sdkResult != 0; }
    public bool @GetLookingLRBFirstPerson() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1628 >(1628)(Pointer); return __sdkResult != 0; }
    public float @GetPositionAlongSpline() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1629 >(1629)(Pointer); return __sdkResult; }
    public float @GetRoughDistanceToGround() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1630 >(1630)(Pointer); return __sdkResult; }
    public int @GetScreenFadeStatus() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1631 >(1631)(Pointer); return __sdkResult; }
    public void @GetScreenRect(CRect? @pRect) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1632 >(1632)(Pointer,@pRect?.Pointer ?? IntPtr.Zero); }
    public bool @Get_Just_Switched_Status() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1633 >(1633)(Pointer); return __sdkResult != 0; }
    public void @HandleCameraMotionForDucking(CPed? @ped,CVector? @source,CVector? @targPosn,bool @arg5) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1634 >(1634)(Pointer,@ped?.Pointer ?? IntPtr.Zero,@source?.Pointer ?? IntPtr.Zero,@targPosn?.Pointer ?? IntPtr.Zero,(@arg5 ? 1 : 0)); }
    public void @HandleCameraMotionForDuckingDuringAim(CPed? @ped,CVector? @source,CVector? @targPosn,bool @arg5) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1635 >(1635)(Pointer,@ped?.Pointer ?? IntPtr.Zero,@source?.Pointer ?? IntPtr.Zero,@targPosn?.Pointer ?? IntPtr.Zero,(@arg5 ? 1 : 0)); }
    public void @ImproveNearClip(CVehicle? @pVehicle,CPed? @pPed,CVector? @source,CVector? @targPosn) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1636 >(1636)(Pointer,@pVehicle?.Pointer ?? IntPtr.Zero,@pPed?.Pointer ?? IntPtr.Zero,@source?.Pointer ?? IntPtr.Zero,@targPosn?.Pointer ?? IntPtr.Zero); }
    public void @Init() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1637 >(1637)(Pointer); }
    public void @InitCameraVehicleTweaks() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1638 >(1638)(Pointer); }
    public int @InitialiseScriptableComponents() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1639 >(1639)(Pointer); return __sdkResult; }
    public bool @IsExtraEntityToIgnore(CEntity? @entity) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1640 >(1640)(Pointer,@entity?.Pointer ?? IntPtr.Zero); return __sdkResult != 0; }
    public bool @IsItTimeForNewcam(int @CamSequence,int @StartTime) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1641 >(1641)(Pointer,@CamSequence,@StartTime); return __sdkResult != 0; }
    public bool @IsSphereVisible(CVector @origin,float @radius,RwMatrixTag? @transformMatrix) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1642 >(1642)(Pointer,@origin.Pointer,@radius,@transformMatrix?.Pointer ?? IntPtr.Zero); return __sdkResult != 0; }
    public bool @IsSphereVisible(CVector @origin,float @radius) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1643 >(1643)(Pointer,@origin.Pointer,@radius); return __sdkResult != 0; }
    public void @LerpFOV(float @zoomInFactor,float @zoomOutFactor,float @timelimit,bool @bEase) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1644 >(1644)(Pointer,@zoomInFactor,@zoomOutFactor,@timelimit,(@bEase ? 1 : 0)); }
    public void @LoadPathSplines(int @pFile) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1645 >(1645)(Pointer,@pFile); }
    public void @Process() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1646 >(1646)(Pointer); }
    public void @ProcessFOVLerp(float @ratio) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1647 >(1647)(Pointer,@ratio); }
    public void @ProcessFOVLerp() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1648 >(1648)(Pointer); }
    public void @ProcessFade() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1649 >(1649)(Pointer); }
    public void @ProcessMusicFade() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1650 >(1650)(Pointer); }
    public void @ProcessObbeCinemaCameraBoat() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1651 >(1651)(Pointer); }
    public void @ProcessObbeCinemaCameraCar() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1652 >(1652)(Pointer); }
    public void @ProcessObbeCinemaCameraHeli() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1653 >(1653)(Pointer); }
    public uint @ProcessObbeCinemaCameraPed() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1654 >(1654)(Pointer); return __sdkResult; }
    public void @ProcessObbeCinemaCameraPlane() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1655 >(1655)(Pointer); }
    public void @ProcessObbeCinemaCameraTrain() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1656 >(1656)(Pointer); }
    public void @ProcessScriptedCommands() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1657 >(1657)(Pointer); }
    public void @ProcessShake(float @JiggleIntensity) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1658 >(1658)(Pointer,@JiggleIntensity); }
    public void @ProcessShake() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1659 >(1659)(Pointer); }
    public void @ProcessVectorMoveLinear(float @ratio) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1660 >(1660)(Pointer,@ratio); }
    public void @ProcessVectorMoveLinear() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1661 >(1661)(Pointer); }
    public void @ProcessVectorTrackLinear(float @ratio) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1662 >(1662)(Pointer,@ratio); }
    public void @ProcessVectorTrackLinear() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1663 >(1663)(Pointer); }
    public void @ProcessWideScreenOn() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1664 >(1664)(Pointer); }
    public void @RenderMotionBlur() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1665 >(1665)(Pointer); }
    public void @ResetDuckingSystem(CPed? @ped) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1666 >(1666)(Pointer,@ped?.Pointer ?? IntPtr.Zero); }
    public void @Restore() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1667 >(1667)(Pointer); }
    public void @RestoreCameraAfterMirror() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1668 >(1668)(Pointer); }
    public void @RestoreWithJumpCut() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1669 >(1669)(Pointer); }
    public void @SetCamCutSceneOffSet(CVector? @cutsceneOffset) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1670 >(1670)(Pointer,@cutsceneOffset?.Pointer ?? IntPtr.Zero); }
    public void @SetCamPositionForFixedMode(CVector? @fixedModeSource,CVector? @fixedModeUpOffset) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1671 >(1671)(Pointer,@fixedModeSource?.Pointer ?? IntPtr.Zero,@fixedModeUpOffset?.Pointer ?? IntPtr.Zero); }
    public void @SetCameraDirectlyBehindForFollowPed_CamOnAString() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1672 >(1672)(Pointer); }
    public void @SetCameraDirectlyBehindForFollowPed_ForAPed_CamOnAString(CPed? @targetPed) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1673 >(1673)(Pointer,@targetPed?.Pointer ?? IntPtr.Zero); }
    public void @SetCameraUpForMirror() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1674 >(1674)(Pointer); }
    public void @SetFadeColour(byte @Red,byte @Green,byte @Blue) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1675 >(1675)(Pointer,@Red,@Green,@Blue); }
    public void @SetMotionBlur(int @Red,int @Green,int @Blue,int @value,int @Blurtype) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1676 >(1676)(Pointer,@Red,@Green,@Blue,@value,@Blurtype); }
    public void @SetMotionBlurAlpha(int @Alpha) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1677 >(1677)(Pointer,@Alpha); }
    public void @SetNearClipBasedOnPedCollision(float @arg2) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1678 >(1678)(Pointer,@arg2); }
    public void @SetNearClipScript(float @NearClip) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1679 >(1679)(Pointer,@NearClip); }
    public void @SetNewPlayerWeaponMode(short @mode,short @maxZoom,short @minZoom) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1680 >(1680)(Pointer,@mode,@maxZoom,@minZoom); }
    public void @SetParametersForScriptInterpolation(float @InterpolationToStopMoving,float @InterpolationToCatchUp,uint @TimeForInterPolation) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1681 >(1681)(Pointer,@InterpolationToStopMoving,@InterpolationToCatchUp,@TimeForInterPolation); }
    public void @SetPercentAlongCutScene(float @percent) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1682 >(1682)(Pointer,@percent); }
    public void @SetRwCamera(RwCamera? @rwcamera) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1683 >(1683)(Pointer,@rwcamera?.Pointer ?? IntPtr.Zero); }
    public void @SetWideScreenOff() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1684 >(1684)(Pointer); }
    public void @SetWideScreenOn() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1685 >(1685)(Pointer); }
    public void @SetZoomValueCamStringScript(short @zoomMode) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1686 >(1686)(Pointer,@zoomMode); }
    public void @SetZoomValueFollowPedScript(short @zoomMode) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1687 >(1687)(Pointer,@zoomMode); }
    public void @StartCooperativeCamMode() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1688 >(1688)(Pointer); }
    public void @StartTransition(short @currentCamMode) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1689 >(1689)(Pointer,@currentCamMode); }
    public void @StartTransitionWhenNotFinishedInter(short @currentCamMode) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1690 >(1690)(Pointer,@currentCamMode); }
    public void @StopCooperativeCamMode() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1691 >(1691)(Pointer); }
    public void @StoreValuesDuringInterPol(CVector? @SourceDuringInter,CVector? @TargetDuringInter,CVector? @UpDuringInter,NativePointer<float> @FOVDuringInter) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1692 >(1692)(Pointer,@SourceDuringInter?.Pointer ?? IntPtr.Zero,@TargetDuringInter?.Pointer ?? IntPtr.Zero,@UpDuringInter?.Pointer ?? IntPtr.Zero,@FOVDuringInter.Pointer); }
    public void @TakeControl(CEntity? @target,short @ModeToGoTo,short @TypeOfSwitch,int @WhoIsInControlOfTheCamera) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1693 >(1693)(Pointer,@target?.Pointer ?? IntPtr.Zero,@ModeToGoTo,@TypeOfSwitch,@WhoIsInControlOfTheCamera); }
    public void @TakeControlAttachToEntity(CEntity? @target,CEntity? @attached,CVector? @AttachedCamOffset,CVector? @AttachedCamLookAt,float @AttachedCamAngle,short @TypeOfSwitch,int @WhoIsInControlOfTheCamera) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1694 >(1694)(Pointer,@target?.Pointer ?? IntPtr.Zero,@attached?.Pointer ?? IntPtr.Zero,@AttachedCamOffset?.Pointer ?? IntPtr.Zero,@AttachedCamLookAt?.Pointer ?? IntPtr.Zero,@AttachedCamAngle,@TypeOfSwitch,@WhoIsInControlOfTheCamera); }
    public void @TakeControlNoEntity(CVector? @FixedModeVector,short @TypeOfSwitch,int @WhoIsInControlOfTheCamera) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1695 >(1695)(Pointer,@FixedModeVector?.Pointer ?? IntPtr.Zero,@TypeOfSwitch,@WhoIsInControlOfTheCamera); }
    public void @TakeControlWithSpline(short @TypeOfSwitch) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1696 >(1696)(Pointer,@TypeOfSwitch); }
    public bool @TryToStartNewCamMode(int @CamSequence) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1697 >(1697)(Pointer,@CamSequence); return __sdkResult != 0; }
    public void @UpdateAimingCoors(CVector? @AimingTargetCoors) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1698 >(1698)(Pointer,@AimingTargetCoors?.Pointer ?? IntPtr.Zero); }
    public void @UpdateSoundDistances() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1699 >(1699)(Pointer); }
    public void @UpdateTargetEntity() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1700 >(1700)(Pointer); }
    public bool @Using1stPersonWeaponMode() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1701 >(1701)(Pointer); return __sdkResult != 0; }
    public void @VectorMoveLinear(CVector? @MoveLinearPosnEnd,CVector? @MoveLinearPosnStart,float @duration,bool @bMoveLinearWithEase) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1702 >(1702)(Pointer,@MoveLinearPosnEnd?.Pointer ?? IntPtr.Zero,@MoveLinearPosnStart?.Pointer ?? IntPtr.Zero,@duration,(@bMoveLinearWithEase ? 1 : 0)); }
    public bool @VectorMoveRunning() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1703 >(1703)(Pointer); return __sdkResult != 0; }
    public void @VectorTrackLinear(CVector? @TrackLinearStartPoint,CVector? @TrackLinearEndPoint,float @duration,bool @bEase) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1704 >(1704)(Pointer,@TrackLinearStartPoint?.Pointer ?? IntPtr.Zero,@TrackLinearEndPoint?.Pointer ?? IntPtr.Zero,@duration,(@bEase ? 1 : 0)); }
    public bool @VectorTrackRunning() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1705 >(1705)(Pointer); return __sdkResult != 0; }
    public static void @DontProcessObbeCinemaCamera() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1706 >(1706)(); }
    public static void @SetCamCollisionVarDataSet(int @index) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1707 >(1707)(@index); }
    public static void @SetColVarsAimWeapon(int @aimingType) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1708 >(1708)(@aimingType); }
    public static void @SetColVarsPed(int @pedtype,int @nCamPedZoom) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1709 >(1709)(@pedtype,@nCamPedZoom); }
    public static void @SetColVarsVehicle(int @vehicletype,int @CamVehicleZoom) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1710 >(1710)(@vehicletype,@CamVehicleZoom); }
}
