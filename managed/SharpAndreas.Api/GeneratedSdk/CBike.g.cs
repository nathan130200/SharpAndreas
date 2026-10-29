// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CBike : CVehicle
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=2068;
    public CBike(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("NUM_WHEELS")]
    public static int @CountWHEELS { get => SdkMemory.Read<int >(SdkBindings.Address(4649)); }
    [NativeMember("NUM_SUSP_LINES")]
    public static int @CountSUSPLINES { get => SdkMemory.Read<int >(SdkBindings.Address(4650)); }
    [NativeMember("m_aBikeNodes")]
    public NativeArray<IntPtr> @BikeNodes { get => new NativeArray<IntPtr>(Pointer+1440,10); }
    [NativeMember("m_bLeanMatrixCalculated")]
    public bool @LeanMatrixCalculated { get => SdkMemory.Read<bool >(Pointer+1480); set { SdkMemory.Write(Pointer+1480,value); } }
    [NativeMember("m_mLeanMatrix")]
    public CMatrix @MLeanMatrix { get => new CMatrix(Pointer+1484); set { SdkMemory.Copy(value.Pointer,Pointer+1484,72); } }
    [NativeMember("m_vecAveGroundNormal")]
    public CVector @AveGroundNormal { get => new CVector(Pointer+1560); set { SdkMemory.Copy(value.Pointer,Pointer+1560,12); } }
    [NativeMember("m_vecGroundRight")]
    public CVector @GroundRight { get => new CVector(Pointer+1572); set { SdkMemory.Copy(value.Pointer,Pointer+1572,12); } }
    [NativeMember("m_vecOldSpeedForPlayback")]
    public CVector @OldSpeedForPlayback { get => new CVector(Pointer+1584); set { SdkMemory.Copy(value.Pointer,Pointer+1584,12); } }
    [NativeMember("m_pBikeHandlingData")]
    public tBikeHandlingData? @BikeHandlingData { get => SdkMemory.Read<IntPtr>(Pointer+1596) == IntPtr.Zero ? null : new tBikeHandlingData(SdkMemory.Read<IntPtr>(Pointer+1596)); set { SdkMemory.Write(Pointer+1596,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_rideAnimData")]
    public CRideAnimData @RideAnimationData { get => new CRideAnimData(Pointer+1600); set { SdkMemory.Copy(value.Pointer,Pointer+1600,28); } }
    [NativeMember("m_nWheelStatus")]
    public NativeArray<byte> @WheelStatus { get => new NativeArray<byte>(Pointer+1628,2); }
    [NativeMember("m_anWheelColPoint")]
    public NativeObjectArray<CColPoint> @WheelCollisionPoint { get => new NativeObjectArray<CColPoint>(Pointer+1632,4,44); }
    [NativeMember("m_aWheelRatios")]
    public NativeArray<float> @WheelRatios { get => new NativeArray<float>(Pointer+1808,4); }
    [NativeMember("m_aRatioHistory")]
    public NativeArray<float> @RatioHistory { get => new NativeArray<float>(Pointer+1824,4); }
    [NativeMember("m_fWheelCounts")]
    public NativeArray<float> @WheelCounts { get => new NativeArray<float>(Pointer+1840,4); }
    [NativeMember("m_fBrakeCount")]
    public float @BrakeCount { get => SdkMemory.Read<float >(Pointer+1856); set { SdkMemory.Write(Pointer+1856,value); } }
    [NativeMember("m_aWheelSkidmarkType")]
    public NativeArray<eSkidmarkType> @WheelSkidmarkType { get => new NativeArray<eSkidmarkType>(Pointer+1860,2); }
    [NativeMember("m_bWheelBloody")]
    public NativeArray<bool> @WheelBloody { get => new NativeArray<bool>(Pointer+1868,2); }
    [NativeMember("m_bMoreSkidMarks")]
    public NativeArray<bool> @MoreSkidMarks { get => new NativeArray<bool>(Pointer+1870,2); }
    [NativeMember("m_aWheelPitchAngles")]
    public NativeArray<float> @WheelPitchAngles { get => new NativeArray<float>(Pointer+1872,2); }
    [NativeMember("m_aWheelAngularVelocity")]
    public NativeArray<float> @WheelAngularVelocity { get => new NativeArray<float>(Pointer+1880,2); }
    [NativeMember("m_aWheelSuspensionHeights")]
    public NativeArray<float> @WheelSuspensionHeights { get => new NativeArray<float>(Pointer+1888,2); }
    [NativeMember("m_aWheelOrigHeights")]
    public NativeArray<float> @WheelOrigHeights { get => new NativeArray<float>(Pointer+1896,2); }
    [NativeMember("m_fSuspensionLength")]
    public NativeArray<float> @SuspensionLength { get => new NativeArray<float>(Pointer+1904,4); }
    [NativeMember("m_fLineLength")]
    public NativeArray<float> @LineLength { get => new NativeArray<float>(Pointer+1920,4); }
    [NativeMember("m_fHeightAboveRoad")]
    public float @HeightAboveRoad { get => SdkMemory.Read<float >(Pointer+1936); set { SdkMemory.Write(Pointer+1936,value); } }
    [NativeMember("m_fExtraTractionMult")]
    public float @ExtraTractionMult { get => SdkMemory.Read<float >(Pointer+1940); set { SdkMemory.Write(Pointer+1940,value); } }
    [NativeMember("m_fSwingArmLength")]
    public float @SwingArmLength { get => SdkMemory.Read<float >(Pointer+1944); set { SdkMemory.Write(Pointer+1944,value); } }
    [NativeMember("m_fForkYOffset")]
    public float @ForkYOffset { get => SdkMemory.Read<float >(Pointer+1948); set { SdkMemory.Write(Pointer+1948,value); } }
    [NativeMember("m_fForkZOffset")]
    public float @ForkZOffset { get => SdkMemory.Read<float >(Pointer+1952); set { SdkMemory.Write(Pointer+1952,value); } }
    [NativeMember("m_fSteerAngleTan")]
    public float @SteerAngleTan { get => SdkMemory.Read<float >(Pointer+1956); set { SdkMemory.Write(Pointer+1956,value); } }
    [NativeMember("m_nBrakesOn")]
    public ushort @BrakesOn { get => SdkMemory.Read<ushort >(Pointer+1960); set { SdkMemory.Write(Pointer+1960,value); } }
    [NativeMember("m_fNitroValue")]
    public float @NitroValue { get => SdkMemory.Read<float >(Pointer+1964); set { SdkMemory.Write(Pointer+1964,value); } }
    [NativeMember("m_fBrakingSlide")]
    public float @BrakingSlide { get => SdkMemory.Read<float >(Pointer+1968); set { SdkMemory.Write(Pointer+1968,value); } }
    [NativeMember("m_nFixLeftHand")]
    public byte @FixLeftHand { get => SdkMemory.Read<byte >(Pointer+1972); set { SdkMemory.Write(Pointer+1972,value); } }
    [NativeMember("m_nFixRightHand")]
    public byte @FixRightHand { get => SdkMemory.Read<byte >(Pointer+1973); set { SdkMemory.Write(Pointer+1973,value); } }
    [NativeMember("m_nTestPedCollision")]
    public byte @TestPedCollision { get => SdkMemory.Read<byte >(Pointer+1974); set { SdkMemory.Write(Pointer+1974,value); } }
    [NativeMember("m_fPrevSpeed")]
    public float @PrevSpeed { get => SdkMemory.Read<float >(Pointer+1976); set { SdkMemory.Write(Pointer+1976,value); } }
    [NativeMember("m_fBurningTimer")]
    public float @BurningTimer { get => SdkMemory.Read<float >(Pointer+1980); set { SdkMemory.Write(Pointer+1980,value); } }
    [NativeMember("m_apWheelCollisionEntity")]
    public NativeArray<IntPtr> @WheelCollisionEntity { get => new NativeArray<IntPtr>(Pointer+1984,4); }
    [NativeMember("m_avTouchPointsLocalSpace")]
    public NativeObjectArray<CVector> @TouchPointsLocalSpace { get => new NativeObjectArray<CVector>(Pointer+2000,4,12); }
    [NativeMember("m_pDamager")]
    public CEntity? @Damager { get => SdkMemory.Read<IntPtr>(Pointer+2048) == IntPtr.Zero ? null : new CEntity(SdkMemory.Read<IntPtr>(Pointer+2048)); set { SdkMemory.Write(Pointer+2048,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_nNumContactWheels")]
    public byte @CountContactWheels { get => SdkMemory.Read<byte >(Pointer+2052); set { SdkMemory.Write(Pointer+2052,value); } }
    [NativeMember("m_nNumWheelsOnGround")]
    public byte @CountWheelsOnGround { get => SdkMemory.Read<byte >(Pointer+2053); set { SdkMemory.Write(Pointer+2053,value); } }
    [NativeMember("m_nNumDriveWheelsOnGroundLastFrame")]
    public byte @CountDriveWheelsOnGroundLastFrame { get => SdkMemory.Read<byte >(Pointer+2054); set { SdkMemory.Write(Pointer+2054,value); } }
    [NativeMember("m_fGasPedalAudioRevs")]
    public float @GasPedalAudioRevs { get => SdkMemory.Read<float >(Pointer+2056); set { SdkMemory.Write(Pointer+2056,value); } }
    [NativeMember("m_wheelState")]
    public NativeArray<eWheelState> @WheelState { get => new NativeArray<eWheelState>(Pointer+2060,2); }
    public void @ProcessAI(NativePointer<uint> @arg0) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1194 >(1194)(Pointer,@arg0.Pointer); }
    public void @InitializeAt(int @modelIndex,byte @createdBy) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1195 >(1195)(Pointer,@modelIndex,@createdBy); }
    public void @SetupModelNodes() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1196 >(1196)(Pointer); }
    public void @dmgDrawCarCollidingParticles(CVector @position,float @power,eWeaponType @weaponType) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1197 >(1197)(Pointer,@position.Pointer,@power,(int)@weaponType); }
    public static bool @DamageKnockOffRider(CVehicle? @arg0,float @arg1,ushort @arg2,CEntity? @arg3,CVector @arg4,CVector @arg5) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1198 >(1198)(@arg0?.Pointer ?? IntPtr.Zero,@arg1,@arg2,@arg3?.Pointer ?? IntPtr.Zero,@arg4.Pointer,@arg5.Pointer); return __sdkResult != 0; }
    public CPed? @KnockOffRider(eWeaponType @arg0,byte @arg1,CPed? @arg2,bool @arg3) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1199 >(1199)(Pointer,(int)@arg0,@arg1,@arg2?.Pointer ?? IntPtr.Zero,(@arg3 ? 1 : 0)); return __sdkResult == IntPtr.Zero ? null : new CPed(__sdkResult); }
    public void @SetRemoveAnimFlags(CPed? @ped) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1200 >(1200)(Pointer,@ped?.Pointer ?? IntPtr.Zero); }
    public void @ReduceHornCounter() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1201 >(1201)(Pointer); }
    public void @ProcessBuoyancy() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1202 >(1202)(Pointer); }
    public void @ResetSuspension() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1203 >(1203)(Pointer); }
    public bool @GetAllWheelsOffGround() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1204 >(1204)(Pointer); return __sdkResult != 0; }
    public void @DebugCode() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1205 >(1205)(Pointer); }
    public void @DoSoftGroundResistance(NativePointer<uint> @arg0) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1206 >(1206)(Pointer,@arg0.Pointer); }
    public void @PlayHornIfNecessary() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1207 >(1207)(Pointer); }
    public void @CalculateLeanMatrix() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1208 >(1208)(Pointer); }
    public static void @ProcessRiderAnims(CPed? @rider,CVehicle? @vehicle,CRideAnimData? @rideData,tBikeHandlingData? @handling) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1209 >(1209)(@rider?.Pointer ?? IntPtr.Zero,@vehicle?.Pointer ?? IntPtr.Zero,@rideData?.Pointer ?? IntPtr.Zero,@handling?.Pointer ?? IntPtr.Zero); }
    public void @FixHandsToBars(CPed? @rider) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1210 >(1210)(Pointer,@rider?.Pointer ?? IntPtr.Zero); }
    public void @PlaceOnRoadProperly() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1211 >(1211)(Pointer); }
    public void @GetCorrectedWorldDoorPosition(CVector @out,CVector @arg1,CVector @arg2) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1212 >(1212)(Pointer,@out.Pointer,@arg1.Pointer,@arg2.Pointer); }
}
