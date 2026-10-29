// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CCam : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=568;
    public CCam(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_bBelowMinDist")]
    public bool @BelowMinDistance { get => SdkMemory.Read<bool >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("m_bBehindPlayerDesired")]
    public bool @BehindPlayerDesired { get => SdkMemory.Read<bool >(Pointer+1); set { SdkMemory.Write(Pointer+1,value); } }
    [NativeMember("m_bCamLookingAtVector")]
    public bool @CamLookingAtVector { get => SdkMemory.Read<bool >(Pointer+2); set { SdkMemory.Write(Pointer+2,value); } }
    [NativeMember("m_bCollisionChecksOn")]
    public bool @CollisionChecksOn { get => SdkMemory.Read<bool >(Pointer+3); set { SdkMemory.Write(Pointer+3,value); } }
    [NativeMember("m_bFixingBeta")]
    public bool @FixingBeta { get => SdkMemory.Read<bool >(Pointer+4); set { SdkMemory.Write(Pointer+4,value); } }
    [NativeMember("m_bTheHeightFixerVehicleIsATrain")]
    public bool @TheHeightFixerVehicleIsATrain { get => SdkMemory.Read<bool >(Pointer+5); set { SdkMemory.Write(Pointer+5,value); } }
    [NativeMember("m_bLookBehindCamWasInFront")]
    public bool @LookBehindCamWasInFront { get => SdkMemory.Read<bool >(Pointer+6); set { SdkMemory.Write(Pointer+6,value); } }
    [NativeMember("m_bLookingBehind")]
    public bool @LookingBehind { get => SdkMemory.Read<bool >(Pointer+7); set { SdkMemory.Write(Pointer+7,value); } }
    [NativeMember("m_bLookingLeft")]
    public bool @LookingLeft { get => SdkMemory.Read<bool >(Pointer+8); set { SdkMemory.Write(Pointer+8,value); } }
    [NativeMember("m_bLookingRight")]
    public bool @LookingRight { get => SdkMemory.Read<bool >(Pointer+9); set { SdkMemory.Write(Pointer+9,value); } }
    [NativeMember("m_bResetStatics")]
    public bool @ResetStatics { get => SdkMemory.Read<bool >(Pointer+10); set { SdkMemory.Write(Pointer+10,value); } }
    [NativeMember("m_bRotating")]
    public bool @Rotating { get => SdkMemory.Read<bool >(Pointer+11); set { SdkMemory.Write(Pointer+11,value); } }
    [NativeMember("m_nMode")]
    public eCamMode @Mode { get => SdkMemory.Read<eCamMode >(Pointer+12); set { SdkMemory.Write(Pointer+12,value); } }
    [NativeMember("m_nFinishTime")]
    public uint @FinishTime { get => SdkMemory.Read<uint >(Pointer+16); set { SdkMemory.Write(Pointer+16,value); } }
    [NativeMember("m_nDoCollisionChecksOnFrameNum")]
    public uint @DoCollisionChecksOnFrameCount { get => SdkMemory.Read<uint >(Pointer+20); set { SdkMemory.Write(Pointer+20,value); } }
    [NativeMember("m_nDoCollisionCheckEveryNumOfFrames")]
    public uint @DoCollisionCheckEveryCountOfFrames { get => SdkMemory.Read<uint >(Pointer+24); set { SdkMemory.Write(Pointer+24,value); } }
    [NativeMember("m_nFrameNumWereAt")]
    public uint @FrameCountWereAt { get => SdkMemory.Read<uint >(Pointer+28); set { SdkMemory.Write(Pointer+28,value); } }
    [NativeMember("m_nRunningVectorArrayPos")]
    public uint @RunningVectorArrayPosition { get => SdkMemory.Read<uint >(Pointer+32); set { SdkMemory.Write(Pointer+32,value); } }
    [NativeMember("m_nRunningVectorCounter")]
    public uint @RunningVectorCounter { get => SdkMemory.Read<uint >(Pointer+36); set { SdkMemory.Write(Pointer+36,value); } }
    [NativeMember("m_nDirectionWasLooking")]
    public uint @DirectionWasLooking { get => SdkMemory.Read<uint >(Pointer+40); set { SdkMemory.Write(Pointer+40,value); } }
    [NativeMember("m_fMaxRoleAngle")]
    public float @MaxRoleAngle { get => SdkMemory.Read<float >(Pointer+44); set { SdkMemory.Write(Pointer+44,value); } }
    [NativeMember("m_fRoll")]
    public float @Roll { get => SdkMemory.Read<float >(Pointer+48); set { SdkMemory.Write(Pointer+48,value); } }
    [NativeMember("m_fRollSpeed")]
    public float @RollSpeed { get => SdkMemory.Read<float >(Pointer+52); set { SdkMemory.Write(Pointer+52,value); } }
    [NativeMember("m_fSyphonModeTargetZOffSet")]
    public float @SyphonModeTargetZOffSet { get => SdkMemory.Read<float >(Pointer+56); set { SdkMemory.Write(Pointer+56,value); } }
    [NativeMember("m_fAmountFractionObscured")]
    public float @AmountFractionObscured { get => SdkMemory.Read<float >(Pointer+60); set { SdkMemory.Write(Pointer+60,value); } }
    [NativeMember("m_fAlphaSpeedOverOneFrame")]
    public float @AlphaSpeedOverOneFrame { get => SdkMemory.Read<float >(Pointer+64); set { SdkMemory.Write(Pointer+64,value); } }
    [NativeMember("m_fBetaSpeedOverOneFrame")]
    public float @BetaSpeedOverOneFrame { get => SdkMemory.Read<float >(Pointer+68); set { SdkMemory.Write(Pointer+68,value); } }
    [NativeMember("m_fBufferedTargetBeta")]
    public float @BufferedTargetBeta { get => SdkMemory.Read<float >(Pointer+72); set { SdkMemory.Write(Pointer+72,value); } }
    [NativeMember("m_fBufferedTargetOrientation")]
    public float @BufferedTargetOrientation { get => SdkMemory.Read<float >(Pointer+76); set { SdkMemory.Write(Pointer+76,value); } }
    [NativeMember("m_fBufferedTargetOrientationSpeed")]
    public float @BufferedTargetOrientationSpeed { get => SdkMemory.Read<float >(Pointer+80); set { SdkMemory.Write(Pointer+80,value); } }
    [NativeMember("m_fCamBufferedHeight")]
    public float @CamBufferedHeight { get => SdkMemory.Read<float >(Pointer+84); set { SdkMemory.Write(Pointer+84,value); } }
    [NativeMember("m_fCamBufferedHeightSpeed")]
    public float @CamBufferedHeightSpeed { get => SdkMemory.Read<float >(Pointer+88); set { SdkMemory.Write(Pointer+88,value); } }
    [NativeMember("m_fCloseInPedHeightOffset")]
    public float @CloseInPedHeightOffset { get => SdkMemory.Read<float >(Pointer+92); set { SdkMemory.Write(Pointer+92,value); } }
    [NativeMember("m_fCloseInPedHeightOffsetSpeed")]
    public float @CloseInPedHeightOffsetSpeed { get => SdkMemory.Read<float >(Pointer+96); set { SdkMemory.Write(Pointer+96,value); } }
    [NativeMember("m_fCloseInCarHeightOffset")]
    public float @CloseInCarHeightOffset { get => SdkMemory.Read<float >(Pointer+100); set { SdkMemory.Write(Pointer+100,value); } }
    [NativeMember("m_fCloseInCarHeightOffsetSpeed")]
    public float @CloseInCarHeightOffsetSpeed { get => SdkMemory.Read<float >(Pointer+104); set { SdkMemory.Write(Pointer+104,value); } }
    [NativeMember("m_fDimensionOfHighestNearCar")]
    public float @DimensionOfHighestNearCar { get => SdkMemory.Read<float >(Pointer+108); set { SdkMemory.Write(Pointer+108,value); } }
    [NativeMember("m_fDistanceBeforeChanges")]
    public float @DistanceBeforeChanges { get => SdkMemory.Read<float >(Pointer+112); set { SdkMemory.Write(Pointer+112,value); } }
    [NativeMember("m_fFovSpeedOverOneFrame")]
    public float @FovSpeedOverOneFrame { get => SdkMemory.Read<float >(Pointer+116); set { SdkMemory.Write(Pointer+116,value); } }
    [NativeMember("m_fMinDistAwayFromCamWhenInterPolating")]
    public float @MinDistanceAwayFromCamWhenInterPolating { get => SdkMemory.Read<float >(Pointer+120); set { SdkMemory.Write(Pointer+120,value); } }
    [NativeMember("m_fPedBetweenCameraHeightOffset")]
    public float @PedBetweenCameraHeightOffset { get => SdkMemory.Read<float >(Pointer+124); set { SdkMemory.Write(Pointer+124,value); } }
    [NativeMember("m_fPlayerInFrontSyphonAngleOffSet")]
    public float @PlayerInFrontSyphonAngleOffSet { get => SdkMemory.Read<float >(Pointer+128); set { SdkMemory.Write(Pointer+128,value); } }
    [NativeMember("m_fRadiusForDead")]
    public float @RadiusForDead { get => SdkMemory.Read<float >(Pointer+132); set { SdkMemory.Write(Pointer+132,value); } }
    [NativeMember("m_fRealGroundDist")]
    public float @RealGroundDistance { get => SdkMemory.Read<float >(Pointer+136); set { SdkMemory.Write(Pointer+136,value); } }
    [NativeMember("m_fTargetBeta")]
    public float @TargetBeta { get => SdkMemory.Read<float >(Pointer+140); set { SdkMemory.Write(Pointer+140,value); } }
    [NativeMember("m_fTimeElapsedFloat")]
    public float @TimeElapsedFloat { get => SdkMemory.Read<float >(Pointer+144); set { SdkMemory.Write(Pointer+144,value); } }
    [NativeMember("m_fTilt")]
    public float @Tilt { get => SdkMemory.Read<float >(Pointer+148); set { SdkMemory.Write(Pointer+148,value); } }
    [NativeMember("m_fTiltSpeed")]
    public float @TiltSpeed { get => SdkMemory.Read<float >(Pointer+152); set { SdkMemory.Write(Pointer+152,value); } }
    [NativeMember("m_fTransitionBeta")]
    public float @TransitionBeta { get => SdkMemory.Read<float >(Pointer+156); set { SdkMemory.Write(Pointer+156,value); } }
    [NativeMember("m_fTrueBeta")]
    public float @TrueBeta { get => SdkMemory.Read<float >(Pointer+160); set { SdkMemory.Write(Pointer+160,value); } }
    [NativeMember("m_fTrueAlpha")]
    public float @TrueAlpha { get => SdkMemory.Read<float >(Pointer+164); set { SdkMemory.Write(Pointer+164,value); } }
    [NativeMember("m_fInitialPlayerOrientation")]
    public float @InitialPlayerOrientation { get => SdkMemory.Read<float >(Pointer+168); set { SdkMemory.Write(Pointer+168,value); } }
    [NativeMember("m_fVerticalAngle")]
    public float @VerticalAngle { get => SdkMemory.Read<float >(Pointer+172); set { SdkMemory.Write(Pointer+172,value); } }
    [NativeMember("m_fAlphaSpeed")]
    public float @AlphaSpeed { get => SdkMemory.Read<float >(Pointer+176); set { SdkMemory.Write(Pointer+176,value); } }
    [NativeMember("m_fFOV")]
    public float @FOV { get => SdkMemory.Read<float >(Pointer+180); set { SdkMemory.Write(Pointer+180,value); } }
    [NativeMember("m_fFOVSpeed")]
    public float @FOVSpeed { get => SdkMemory.Read<float >(Pointer+184); set { SdkMemory.Write(Pointer+184,value); } }
    [NativeMember("m_fHorizontalAngle")]
    public float @HorizontalAngle { get => SdkMemory.Read<float >(Pointer+188); set { SdkMemory.Write(Pointer+188,value); } }
    [NativeMember("m_fBetaSpeed")]
    public float @BetaSpeed { get => SdkMemory.Read<float >(Pointer+192); set { SdkMemory.Write(Pointer+192,value); } }
    [NativeMember("m_fDistance")]
    public float @Distance { get => SdkMemory.Read<float >(Pointer+196); set { SdkMemory.Write(Pointer+196,value); } }
    [NativeMember("m_fDistanceSpeed")]
    public float @DistanceSpeed { get => SdkMemory.Read<float >(Pointer+200); set { SdkMemory.Write(Pointer+200,value); } }
    [NativeMember("m_fCaMinDistance")]
    public float @CaMinDistance { get => SdkMemory.Read<float >(Pointer+204); set { SdkMemory.Write(Pointer+204,value); } }
    [NativeMember("m_fCaMaxDistance")]
    public float @CaMaxDistance { get => SdkMemory.Read<float >(Pointer+208); set { SdkMemory.Write(Pointer+208,value); } }
    [NativeMember("m_fSpeedVar")]
    public float @SpeedVariable { get => SdkMemory.Read<float >(Pointer+212); set { SdkMemory.Write(Pointer+212,value); } }
    [NativeMember("m_fCameraHeightMultiplier")]
    public float @CameraHeightMultiplier { get => SdkMemory.Read<float >(Pointer+216); set { SdkMemory.Write(Pointer+216,value); } }
    [NativeMember("m_fTargetZoomGroundOne")]
    public float @TargetZoomGroundOne { get => SdkMemory.Read<float >(Pointer+220); set { SdkMemory.Write(Pointer+220,value); } }
    [NativeMember("m_fTargetZoomGroundTwo")]
    public float @TargetZoomGroundTwo { get => SdkMemory.Read<float >(Pointer+224); set { SdkMemory.Write(Pointer+224,value); } }
    [NativeMember("m_fTargetZoomGroundThree")]
    public float @TargetZoomGroundThree { get => SdkMemory.Read<float >(Pointer+228); set { SdkMemory.Write(Pointer+228,value); } }
    [NativeMember("m_fTargetZoomOneZExtra")]
    public float @TargetZoomOneZExtra { get => SdkMemory.Read<float >(Pointer+232); set { SdkMemory.Write(Pointer+232,value); } }
    [NativeMember("m_fTargetZoomTwoZExtra")]
    public float @TargetZoomTwoZExtra { get => SdkMemory.Read<float >(Pointer+236); set { SdkMemory.Write(Pointer+236,value); } }
    [NativeMember("m_fTargetZoomTwoInteriorZExtra")]
    public float @TargetZoomTwoInteriorZExtra { get => SdkMemory.Read<float >(Pointer+240); set { SdkMemory.Write(Pointer+240,value); } }
    [NativeMember("m_fTargetZoomThreeZExtra")]
    public float @TargetZoomThreeZExtra { get => SdkMemory.Read<float >(Pointer+244); set { SdkMemory.Write(Pointer+244,value); } }
    [NativeMember("m_fTargetZoomZCloseIn")]
    public float @TargetZoomZCloseIn { get => SdkMemory.Read<float >(Pointer+248); set { SdkMemory.Write(Pointer+248,value); } }
    [NativeMember("m_fMinRealGroundDist")]
    public float @MinRealGroundDistance { get => SdkMemory.Read<float >(Pointer+252); set { SdkMemory.Write(Pointer+252,value); } }
    [NativeMember("m_fTargetCloseInDist")]
    public float @TargetCloseInDistance { get => SdkMemory.Read<float >(Pointer+256); set { SdkMemory.Write(Pointer+256,value); } }
    [NativeMember("m_fBeta_Targeting")]
    public float @BetaTargeting { get => SdkMemory.Read<float >(Pointer+260); set { SdkMemory.Write(Pointer+260,value); } }
    [NativeMember("m_fX_Targetting")]
    public float @XTargetting { get => SdkMemory.Read<float >(Pointer+264); set { SdkMemory.Write(Pointer+264,value); } }
    [NativeMember("m_fY_Targetting")]
    public float @YTargetting { get => SdkMemory.Read<float >(Pointer+268); set { SdkMemory.Write(Pointer+268,value); } }
    [NativeMember("m_pCarWeAreFocussingOn")]
    public CVehicle? @CarWeAreFocussingOn { get => SdkMemory.Read<IntPtr>(Pointer+272) == IntPtr.Zero ? null : new CVehicle(SdkMemory.Read<IntPtr>(Pointer+272)); set { SdkMemory.Write(Pointer+272,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_pCarWeAreFocussingOnI")]
    public CVehicle? @CarWeAreFocussingOnI { get => SdkMemory.Read<IntPtr>(Pointer+276) == IntPtr.Zero ? null : new CVehicle(SdkMemory.Read<IntPtr>(Pointer+276)); set { SdkMemory.Write(Pointer+276,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_fCamBumpedHorz")]
    public float @CamBumpedHorz { get => SdkMemory.Read<float >(Pointer+280); set { SdkMemory.Write(Pointer+280,value); } }
    [NativeMember("m_fCamBumpedVert")]
    public float @CamBumpedVert { get => SdkMemory.Read<float >(Pointer+284); set { SdkMemory.Write(Pointer+284,value); } }
    [NativeMember("m_nCamBumpedTime")]
    public uint @CamBumpedTime { get => SdkMemory.Read<uint >(Pointer+288); set { SdkMemory.Write(Pointer+288,value); } }
    [NativeMember("m_vecSourceSpeedOverOneFrame")]
    public CVector @SourceSpeedOverOneFrame { get => new CVector(Pointer+292); set { SdkMemory.Copy(value.Pointer,Pointer+292,12); } }
    [NativeMember("m_vecTargetSpeedOverOneFrame")]
    public CVector @TargetSpeedOverOneFrame { get => new CVector(Pointer+304); set { SdkMemory.Copy(value.Pointer,Pointer+304,12); } }
    [NativeMember("m_vecUpOverOneFrame")]
    public CVector @UpOverOneFrame { get => new CVector(Pointer+316); set { SdkMemory.Copy(value.Pointer,Pointer+316,12); } }
    [NativeMember("m_vecTargetCoorsForFudgeInter")]
    public CVector @TargetCoorsForFudgeInter { get => new CVector(Pointer+328); set { SdkMemory.Copy(value.Pointer,Pointer+328,12); } }
    [NativeMember("m_vecCamFixedModeVector")]
    public CVector @CamFixedModeVector { get => new CVector(Pointer+340); set { SdkMemory.Copy(value.Pointer,Pointer+340,12); } }
    [NativeMember("m_vecCamFixedModeSource")]
    public CVector @CamFixedModeSource { get => new CVector(Pointer+352); set { SdkMemory.Copy(value.Pointer,Pointer+352,12); } }
    [NativeMember("m_vecCamFixedModeUpOffSet")]
    public CVector @CamFixedModeUpOffSet { get => new CVector(Pointer+364); set { SdkMemory.Copy(value.Pointer,Pointer+364,12); } }
    [NativeMember("m_vecLastAboveWaterCamPosition")]
    public CVector @LastAboveWaterCamPosition { get => new CVector(Pointer+376); set { SdkMemory.Copy(value.Pointer,Pointer+376,12); } }
    [NativeMember("m_vecBufferedPlayerBodyOffset")]
    public CVector @BufferedPlayerBodyOffset { get => new CVector(Pointer+388); set { SdkMemory.Copy(value.Pointer,Pointer+388,12); } }
    [NativeMember("m_vecFront")]
    public CVector @Front { get => new CVector(Pointer+400); set { SdkMemory.Copy(value.Pointer,Pointer+400,12); } }
    [NativeMember("m_vecSource")]
    public CVector @Source { get => new CVector(Pointer+412); set { SdkMemory.Copy(value.Pointer,Pointer+412,12); } }
    [NativeMember("m_vecSourceBeforeLookBehind")]
    public CVector @SourceBeforeLookBehind { get => new CVector(Pointer+424); set { SdkMemory.Copy(value.Pointer,Pointer+424,12); } }
    [NativeMember("m_vecUp")]
    public CVector @Up { get => new CVector(Pointer+436); set { SdkMemory.Copy(value.Pointer,Pointer+436,12); } }
    [NativeMember("m_avecPreviousVectors")]
    public NativeObjectArray<CVector> @PreviousVectors { get => new NativeObjectArray<CVector>(Pointer+448,2,12); }
    [NativeMember("m_avecTargetHistoryPos")]
    public NativeObjectArray<CVector> @TargetHistoryPosition { get => new NativeObjectArray<CVector>(Pointer+472,4,12); }
    [NativeMember("m_anTargetHistoryTime")]
    public NativeArray<uint> @TargetHistoryTime { get => new NativeArray<uint>(Pointer+520,4); }
    [NativeMember("m_nCurrentHistoryPoints")]
    public uint @CurrentHistoryPoints { get => SdkMemory.Read<uint >(Pointer+536); set { SdkMemory.Write(Pointer+536,value); } }
    [NativeMember("m_pCamTargetEntity")]
    public CEntity? @CamTargetEntity { get => SdkMemory.Read<IntPtr>(Pointer+540) == IntPtr.Zero ? null : new CEntity(SdkMemory.Read<IntPtr>(Pointer+540)); set { SdkMemory.Write(Pointer+540,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_fCameraDistance")]
    public float @CameraDistance { get => SdkMemory.Read<float >(Pointer+544); set { SdkMemory.Write(Pointer+544,value); } }
    [NativeMember("m_fIdealAlpha")]
    public float @IdealAlpha { get => SdkMemory.Read<float >(Pointer+548); set { SdkMemory.Write(Pointer+548,value); } }
    [NativeMember("m_fPlayerVelocity")]
    public float @PlayerVelocity { get => SdkMemory.Read<float >(Pointer+552); set { SdkMemory.Write(Pointer+552,value); } }
    [NativeMember("m_pLastCarEntered")]
    public CVehicle? @LastCarEntered { get => SdkMemory.Read<IntPtr>(Pointer+556) == IntPtr.Zero ? null : new CVehicle(SdkMemory.Read<IntPtr>(Pointer+556)); set { SdkMemory.Write(Pointer+556,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_pLastPedLookedAt")]
    public CPed? @LastPedLookedAt { get => SdkMemory.Read<IntPtr>(Pointer+560) == IntPtr.Zero ? null : new CPed(SdkMemory.Read<IntPtr>(Pointer+560)); set { SdkMemory.Write(Pointer+560,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_bFirstPersonRunAboutActive")]
    public bool @FirstPersonRunAboutActive { get => SdkMemory.Read<bool >(Pointer+564); set { SdkMemory.Write(Pointer+564,value); } }
}
