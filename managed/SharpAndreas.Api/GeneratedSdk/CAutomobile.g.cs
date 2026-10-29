// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CAutomobile : CVehicle
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=2440;
    public CAutomobile(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_damageManager")]
    public CDamageManager @DamageManager { get => new CDamageManager(Pointer+1440); set { SdkMemory.Copy(value.Pointer,Pointer+1440,24); } }
    [NativeMember("m_doors")]
    public NativeObjectArray<CDoor> @Doors { get => new NativeObjectArray<CDoor>(Pointer+1464,6,24); }
    [NativeMember("m_aCarNodes")]
    public NativeArray<IntPtr> @CarNodes { get => new NativeArray<IntPtr>(Pointer+1608,25); }
    [NativeMember("m_panels")]
    public NativeObjectArray<CBouncingPanel> @Panels { get => new NativeObjectArray<CBouncingPanel>(Pointer+1708,3,32); }
    [NativeMember("m_swingingChassis")]
    public CDoor @SwingingChassis { get => new CDoor(Pointer+1804); set { SdkMemory.Copy(value.Pointer,Pointer+1804,24); } }
    [NativeMember("m_wheelColPoint")]
    public NativeObjectArray<CColPoint> @WheelCollisionPoint { get => new NativeObjectArray<CColPoint>(Pointer+1828,4,44); }
    [NativeMember("m_fWheelsSuspensionCompression")]
    public NativeArray<float> @WheelsSuspensionCompression { get => new NativeArray<float>(Pointer+2004,4); }
    [NativeMember("m_fWheelsSuspensionCompressionPrev")]
    public NativeArray<float> @WheelsSuspensionCompressionPrev { get => new NativeArray<float>(Pointer+2020,4); }
    [NativeMember("m_fWheelCounts")]
    public NativeArray<float> @WheelCounts { get => new NativeArray<float>(Pointer+2036,4); }
    [NativeMember("m_fBrakeCount")]
    public float @BrakeCount { get => SdkMemory.Read<float >(Pointer+2052); set { SdkMemory.Write(Pointer+2052,value); } }
    [NativeMember("m_fIntertiaValue1")]
    public float @IntertiaValue1 { get => SdkMemory.Read<float >(Pointer+2056); set { SdkMemory.Write(Pointer+2056,value); } }
    [NativeMember("m_fIntertiaValue2")]
    public float @IntertiaValue2 { get => SdkMemory.Read<float >(Pointer+2060); set { SdkMemory.Write(Pointer+2060,value); } }
    [NativeMember("m_wheelSkidmarkType")]
    public NativeArray<eSkidmarkType> @WheelSkidmarkType { get => new NativeArray<eSkidmarkType>(Pointer+2064,4); }
    [NativeMember("m_bWheelSkidmarkBloody")]
    public NativeArray<bool> @WheelSkidmarkBloody { get => new NativeArray<bool>(Pointer+2080,4); }
    [NativeMember("m_bWheelSkidmarkMuddy")]
    public NativeArray<bool> @WheelSkidmarkMuddy { get => new NativeArray<bool>(Pointer+2084,4); }
    [NativeMember("m_fWheelRotation")]
    public NativeArray<float> @WheelRotation { get => new NativeArray<float>(Pointer+2088,4); }
    [NativeMember("m_fWheelPosition")]
    public NativeArray<float> @WheelPosition { get => new NativeArray<float>(Pointer+2104,4); }
    [NativeMember("m_fWheelSpeed")]
    public NativeArray<float> @WheelSpeed { get => new NativeArray<float>(Pointer+2120,4); }
    [NativeMember("m_fWheelBurnoutSpeed")]
    public NativeArray<float> @WheelBurnoutSpeed { get => new NativeArray<float>(Pointer+2136,4); }
    [NativeMember("m_nAutomobileFlags")]
    public CAutomobile___unnamed__at_D__plugin_sdk_plugin_sa_game_sa_CAutomobile__75858922c0 @AutomobileFlags { get => new CAutomobile___unnamed__at_D__plugin_sdk_plugin_sa_game_sa_CAutomobile__75858922c0(Pointer+2152); set { SdkMemory.Copy(value.Pointer,Pointer+2152,1); } }
    [NativeMember("m_bDoingBurnout")]
    public short @DoingBurnout { get => SdkMemory.Read<short >(Pointer+2154); set { SdkMemory.Write(Pointer+2154,value); } }
    [NativeMember("m_wMiscComponentAngle")]
    public short @MiscComponentAngle { get => SdkMemory.Read<short >(Pointer+2156); set { SdkMemory.Write(Pointer+2156,value); } }
    [NativeMember("m_wMiscComponentAnglePrev")]
    public short @MiscComponentAnglePrev { get => SdkMemory.Read<short >(Pointer+2158); set { SdkMemory.Write(Pointer+2158,value); } }
    [NativeMember("m_dwBusDoorTimerEnd")]
    public int @BusDoorTimerEnd { get => SdkMemory.Read<int >(Pointer+2160); set { SdkMemory.Write(Pointer+2160,value); } }
    [NativeMember("m_dwBusDoorTimerStart")]
    public int @BusDoorTimerStart { get => SdkMemory.Read<int >(Pointer+2164); set { SdkMemory.Write(Pointer+2164,value); } }
    [NativeMember("m_aSuspensionSpringLength")]
    public NativeArray<float> @SuspensionSpringLength { get => new NativeArray<float>(Pointer+2168,4); }
    [NativeMember("m_aSuspensionLineLength")]
    public NativeArray<float> @SuspensionLineLength { get => new NativeArray<float>(Pointer+2184,4); }
    [NativeMember("m_fFrontHeightAboveRoad")]
    public float @FrontHeightAboveRoad { get => SdkMemory.Read<float >(Pointer+2200); set { SdkMemory.Write(Pointer+2200,value); } }
    [NativeMember("m_fRearHeightAboveRoad")]
    public float @RearHeightAboveRoad { get => SdkMemory.Read<float >(Pointer+2204); set { SdkMemory.Write(Pointer+2204,value); } }
    [NativeMember("m_fExtraTractionMult")]
    public float @ExtraTractionMult { get => SdkMemory.Read<float >(Pointer+2208); set { SdkMemory.Write(Pointer+2208,value); } }
    [NativeMember("m_fNitroValue")]
    public float @NitroValue { get => SdkMemory.Read<float >(Pointer+2212); set { SdkMemory.Write(Pointer+2212,value); } }
    [NativeMember("m_fAircraftGoToHeading")]
    public float @AircraftGoToHeading { get => SdkMemory.Read<float >(Pointer+2216); set { SdkMemory.Write(Pointer+2216,value); } }
    [NativeMember("m_fRotationBalance")]
    public float @RotationBalance { get => SdkMemory.Read<float >(Pointer+2220); set { SdkMemory.Write(Pointer+2220,value); } }
    [NativeMember("m_fMoveDirection")]
    public float @MoveDirection { get => SdkMemory.Read<float >(Pointer+2224); set { SdkMemory.Write(Pointer+2224,value); } }
    [NativeMember("m_vecMoveForce")]
    public CVector @MoveForce { get => new CVector(Pointer+2228); set { SdkMemory.Copy(value.Pointer,Pointer+2228,12); } }
    [NativeMember("m_vecTurnForce")]
    public CVector @TurnForce { get => new CVector(Pointer+2240); set { SdkMemory.Copy(value.Pointer,Pointer+2240,12); } }
    [NativeMember("m_aDoorRotation")]
    public NativeArray<float> @DoorRotation { get => new NativeArray<float>(Pointer+2252,6); }
    [NativeMember("m_fBurningTimer")]
    public float @BurningTimer { get => SdkMemory.Read<float >(Pointer+2276); set { SdkMemory.Write(Pointer+2276,value); } }
    [NativeMember("m_pWheelCollisionEntity")]
    public NativeArray<IntPtr> @WheelCollisionEntity { get => new NativeArray<IntPtr>(Pointer+2280,4); }
    [NativeMember("m_vWheelCollisionPos")]
    public NativeObjectArray<CVector> @WheelCollisionPosition { get => new NativeObjectArray<CVector>(Pointer+2296,4,12); }
    [NativeMember("m_pExplosionVictim")]
    public CPed? @ExplosionVictim { get => SdkMemory.Read<IntPtr>(Pointer+2344) == IntPtr.Zero ? null : new CPed(SdkMemory.Read<IntPtr>(Pointer+2344)); set { SdkMemory.Write(Pointer+2344,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("field_92C")]
    public NativeArray<sbyte> @Field92C { get => new NativeArray<sbyte>(Pointer+2348,24); }
    [NativeMember("m_fLeftDoorOpenForDriveBys")]
    public float @LeftDoorOpenForDriveBys { get => SdkMemory.Read<float >(Pointer+2372); set { SdkMemory.Write(Pointer+2372,value); } }
    [NativeMember("m_fRightDoorOpenForDriveBys")]
    public float @RightDoorOpenForDriveBys { get => SdkMemory.Read<float >(Pointer+2376); set { SdkMemory.Write(Pointer+2376,value); } }
    [NativeMember("m_fDoomVerticalRotation")]
    public float @DoomVerticalRotation { get => SdkMemory.Read<float >(Pointer+2380); set { SdkMemory.Write(Pointer+2380,value); } }
    [NativeMember("m_fDoomHorizontalRotation")]
    public float @DoomHorizontalRotation { get => SdkMemory.Read<float >(Pointer+2384); set { SdkMemory.Write(Pointer+2384,value); } }
    [NativeMember("m_fForcedOrientation")]
    public float @ForcedOrientation { get => SdkMemory.Read<float >(Pointer+2388); set { SdkMemory.Write(Pointer+2388,value); } }
    [NativeMember("m_fPropRotate")]
    public float @PropRotate { get => SdkMemory.Read<float >(Pointer+2392); set { SdkMemory.Write(Pointer+2392,value); } }
    [NativeMember("m_fCumulativeDamage")]
    public float @CumulativeDamage { get => SdkMemory.Read<float >(Pointer+2396); set { SdkMemory.Write(Pointer+2396,value); } }
    [NativeMember("m_nNumContactWheels")]
    public byte @CountContactWheels { get => SdkMemory.Read<byte >(Pointer+2400); set { SdkMemory.Write(Pointer+2400,value); } }
    [NativeMember("m_nWheelsOnGround")]
    public byte @WheelsOnGround { get => SdkMemory.Read<byte >(Pointer+2401); set { SdkMemory.Write(Pointer+2401,value); } }
    [NativeMember("m_nNumDriveWheelsOnGroundLastFrame")]
    public byte @CountDriveWheelsOnGroundLastFrame { get => SdkMemory.Read<byte >(Pointer+2402); set { SdkMemory.Write(Pointer+2402,value); } }
    [NativeMember("m_fGasPedalAudioRevs")]
    public float @GasPedalAudioRevs { get => SdkMemory.Read<float >(Pointer+2404); set { SdkMemory.Write(Pointer+2404,value); } }
    [NativeMember("m_wheelState")]
    public NativeArray<eWheelState> @WheelState { get => new NativeArray<eWheelState>(Pointer+2408,4); }
    [NativeMember("m_pNitroParticle")]
    public NativeArray<IntPtr> @NitroParticle { get => new NativeArray<IntPtr>(Pointer+2424,2); }
    [NativeMember("m_harvesterParticleCounter")]
    public byte @HarvesterParticleCounter { get => SdkMemory.Read<byte >(Pointer+2432); set { SdkMemory.Write(Pointer+2432,value); } }
    [NativeMember("m_fireParticleCounter")]
    public byte @FireParticleCounter { get => SdkMemory.Read<byte >(Pointer+2433); set { SdkMemory.Write(Pointer+2433,value); } }
    [NativeMember("m_heliDustFxTimeConst")]
    public float @HeliDustFxTimeConst { get => SdkMemory.Read<float >(Pointer+2436); set { SdkMemory.Write(Pointer+2436,value); } }
    [NativeMember("m_sAllTaxiLights")]
    public static bool @SAllTaxiLights { get => SdkMemory.Read<bool >(new IntPtr(0xC1BFD0)); set { SdkMemory.Write(new IntPtr(0xC1BFD0),value); } }
    [NativeMember("vecHunterGunPos")]
    public static CVector @HunterGunPosition { get => new CVector(new IntPtr(0x8D3394)); set { SdkMemory.Copy(value.Pointer,new IntPtr(0x8D3394),12); } }
    [NativeMember("matW2B")]
    public static CMatrix? @W2B { get => new IntPtr(0xC1C220) == IntPtr.Zero ? null : new CMatrix(new IntPtr(0xC1C220)); }
    public bool @ProcessAI(NativePointer<uint> @arg0) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1126 >(1126)(Pointer,@arg0.Pointer); return __sdkResult != 0; }
    public void @ResetSuspension() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1127 >(1127)(Pointer); }
    public void @ProcessFlyingCarStuff() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1128 >(1128)(Pointer); }
    public void @DoHoverSuspensionRatios() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1129 >(1129)(Pointer); }
    public void @ProcessSuspension() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1130 >(1130)(Pointer); }
    public void @InitializeAt(int @modelIndex,byte @createdBy,bool @setupSuspensionLines) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1131 >(1131)(Pointer,@modelIndex,@createdBy,(@setupSuspensionLines ? 1 : 0)); }
    public void @SetupModelNodes() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1132 >(1132)(Pointer); }
    public void @HydraulicControl() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1133 >(1133)(Pointer); }
    public bool @UpdateMovingCollision(float @angle) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1134 >(1134)(Pointer,@angle); return __sdkResult != 0; }
    public float @GetMovingCollisionOffset() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1135 >(1135)(Pointer); return __sdkResult; }
    public void @TellHeliToGoToCoors(float @x,float @y,float @z,float @altitudeMin,float @altitudeMax) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1136 >(1136)(Pointer,@x,@y,@z,@altitudeMin,@altitudeMax); }
    public void @SetHeliOrientation(float @angle) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1137 >(1137)(Pointer,@angle); }
    public void @ClearHeliOrientation() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1138 >(1138)(Pointer); }
    public void @TellPlaneToGoToCoors(float @x,float @y,float @z,float @altitudeMin,float @altitudeMax) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1139 >(1139)(Pointer,@x,@y,@z,@altitudeMin,@altitudeMax); }
    public void @HideAllComps() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1140 >(1140)(Pointer); }
    public void @ShowAllComps() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1141 >(1141)(Pointer); }
    public void @SetRandomDamage(bool @arg0) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1142 >(1142)(Pointer,(@arg0 ? 1 : 0)); }
    public void @SetTotalDamage(bool @arg0) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1143 >(1143)(Pointer,(@arg0 ? 1 : 0)); }
    public void @ReduceHornCounter() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1144 >(1144)(Pointer); }
    public void @CustomCarPlate_BeforeRenderingStart(CVehicleModelInfo? @model) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1145 >(1145)(Pointer,@model?.Pointer ?? IntPtr.Zero); }
    public void @CustomCarPlate_AfterRenderingStop(CVehicleModelInfo? @model) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1146 >(1146)(Pointer,@model?.Pointer ?? IntPtr.Zero); }
    public bool @GetAllWheelsOffGround() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1147 >(1147)(Pointer); return __sdkResult != 0; }
    public void @DebugCode() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1148 >(1148)(Pointer); }
    public void @FixTyre(eWheels @wheel) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1149 >(1149)(Pointer,(int)@wheel); }
    public void @FixDoor(int @nodeIndex,eDoors @door) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1150 >(1150)(Pointer,@nodeIndex,(int)@door); }
    public void @FixPanel(int @nodeIndex,ePanels @panel) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1151 >(1151)(Pointer,@nodeIndex,(int)@panel); }
    public void @SetTaxiLight(bool @enable) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1152 >(1152)(Pointer,(@enable ? 1 : 0)); }
    public static void @SetAllTaxiLights(bool @arg0) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1153 >(1153)((@arg0 ? 1 : 0)); }
    public void @PlayHornIfNecessary() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1154 >(1154)(Pointer); }
    public void @SetBusDoorTimer(uint @time,byte @arg1) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1155 >(1155)(Pointer,@time,@arg1); }
    public void @ProcessAutoBusDoors() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1156 >(1156)(Pointer); }
    public void @BoostJumpControl() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1157 >(1157)(Pointer); }
    public void @DoNitroEffect(float @state) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1158 >(1158)(Pointer,@state); }
    public void @StopNitroEffect() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1159 >(1159)(Pointer); }
    public void @NitrousControl(sbyte @arg0) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1160 >(1160)(Pointer,@arg0); }
    public void @TowTruckControl() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1161 >(1161)(Pointer); }
    public CPed? @KnockPedOutCar(eWeaponType @arg0,ushort @arg1,CPed? @arg2) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1162 >(1162)(Pointer,(int)@arg0,@arg1,@arg2?.Pointer ?? IntPtr.Zero); return __sdkResult == IntPtr.Zero ? null : new CPed(__sdkResult); }
    public void @PopBootUsingPhysics() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1163 >(1163)(Pointer); }
    public void @CloseAllDoors() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1164 >(1164)(Pointer); }
    public void @DoSoftGroundResistance(NativePointer<uint> @arg0) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1165 >(1165)(Pointer,@arg0.Pointer); }
    public void @ProcessCarWheelPair(int @arg0,int @arg1,float @arg2,CVector? @arg3,CVector? @arg4,float @arg5,float @arg6,float @arg7,bool @arg8) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1166 >(1166)(Pointer,@arg0,@arg1,@arg2,@arg3?.Pointer ?? IntPtr.Zero,@arg4?.Pointer ?? IntPtr.Zero,@arg5,@arg6,@arg7,(@arg8 ? 1 : 0)); }
    public float @GetCarRoll() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1167 >(1167)(Pointer); return __sdkResult; }
    public float @GetCarPitch() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1168 >(1168)(Pointer); return __sdkResult; }
    public bool @IsInAir() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1169 >(1169)(Pointer); return __sdkResult != 0; }
    public void @dmgDrawCarCollidingParticles(CVector @position,float @force,eWeaponType @weapon) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1170 >(1170)(Pointer,@position.Pointer,@force,(int)@weapon); }
    public void @ProcessCarOnFireAndExplode(byte @arg0) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1171 >(1171)(Pointer,@arg0); }
    public CObject? @SpawnFlyingComponent(int @nodeIndex,uint @collisionType) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1172 >(1172)(Pointer,@nodeIndex,@collisionType); return __sdkResult == IntPtr.Zero ? null : new CObject(__sdkResult); }
    public void @ProcessBuoyancy() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1173 >(1173)(Pointer); }
    public void @ProcessHarvester() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1174 >(1174)(Pointer); }
    public void @ProcessSwingingDoor(int @nodeIndex,eDoors @door) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1175 >(1175)(Pointer,@nodeIndex,(int)@door); }
    public CObject? @RemoveBonnetInPedCollision() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1176 >(1176)(Pointer); return __sdkResult == IntPtr.Zero ? null : new CObject(__sdkResult); }
    public void @UpdateWheelMatrix(int @nodeIndex,int @flags) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1177 >(1177)(Pointer,@nodeIndex,@flags); }
    public void @PopDoor(int @nodeIndex,eDoors @door,bool @showVisualEffect) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1178 >(1178)(Pointer,@nodeIndex,(int)@door,(@showVisualEffect ? 1 : 0)); }
    public void @PopPanel(int @nodeIndex,ePanels @panel,bool @showVisualEffect) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1179 >(1179)(Pointer,@nodeIndex,(int)@panel,(@showVisualEffect ? 1 : 0)); }
    public void @ScanForCrimes() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1180 >(1180)(Pointer); }
    public void @TankControl() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1181 >(1181)(Pointer); }
    public void @BlowUpCarsInPath() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1182 >(1182)(Pointer); }
    public void @PlaceOnRoadProperly() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1183 >(1183)(Pointer); }
    public void @PopBoot() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1184 >(1184)(Pointer); }
    public void @CloseBoot() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1185 >(1185)(Pointer); }
    public void @DoHeliDustEffect(float @arg0,float @arg1) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1186 >(1186)(Pointer,@arg0,@arg1); }
    public void @SetBumperDamage(ePanels @panel,bool @withoutVisualEffect) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1187 >(1187)(Pointer,(int)@panel,(@withoutVisualEffect ? 1 : 0)); }
    public void @SetPanelDamage(ePanels @panel,bool @createWindowGlass) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1188 >(1188)(Pointer,(int)@panel,(@createWindowGlass ? 1 : 0)); }
    public void @SetDoorDamage(eDoors @door,bool @withoutVisualEffect) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1189 >(1189)(Pointer,(int)@door,(@withoutVisualEffect ? 1 : 0)); }
    public bool @RcbanditCheck1CarWheels(CPtrList @ptrlist) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1190 >(1190)(Pointer,@ptrlist.Pointer); return __sdkResult != 0; }
    public bool @RcbanditCheckHitWheels() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1191 >(1191)(Pointer); return __sdkResult != 0; }
    public void @FireTruckControl(float @arg0) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1192 >(1192)(Pointer,@arg0); }
    public bool @HasCarStoppedBecauseOfLight() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1193 >(1193)(Pointer); return __sdkResult != 0; }
}
