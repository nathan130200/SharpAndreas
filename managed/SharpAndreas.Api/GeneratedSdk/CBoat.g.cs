// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CBoat : CVehicle
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=2024;
    public CBoat(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_fMovingHiRotation")]
    public float @MovingHiRotation { get => SdkMemory.Read<float >(Pointer+1440); set { SdkMemory.Write(Pointer+1440,value); } }
    [NativeMember("m_fPropSpeed")]
    public float @PropSpeed { get => SdkMemory.Read<float >(Pointer+1444); set { SdkMemory.Write(Pointer+1444,value); } }
    [NativeMember("m_fPropRotation")]
    public float @PropRotation { get => SdkMemory.Read<float >(Pointer+1448); set { SdkMemory.Write(Pointer+1448,value); } }
    [NativeMember("m_nBoatFlags")]
    public CBoat___unnamed__at_D__plugin_sdk_plugin_sa_game_sa_CBoat_h_36_5__fe2e85b57c @BoatFlags { get => new CBoat___unnamed__at_D__plugin_sdk_plugin_sa_game_sa_CBoat_h_36_5__fe2e85b57c(Pointer+1452); set { SdkMemory.Copy(value.Pointer,Pointer+1452,1); } }
    [NativeMember("m_aBoatNodes")]
    public NativeArray<IntPtr> @BoatNodes { get => new NativeArray<IntPtr>(Pointer+1456,12); }
    [NativeMember("m_boatFlap")]
    public CDoor @BoatFlap { get => new CDoor(Pointer+1504); set { SdkMemory.Copy(value.Pointer,Pointer+1504,24); } }
    [NativeMember("m_pBoatHandling")]
    public tBoatHandlingData? @BoatHandling { get => SdkMemory.Read<IntPtr>(Pointer+1528) == IntPtr.Zero ? null : new tBoatHandlingData(SdkMemory.Read<IntPtr>(Pointer+1528)); set { SdkMemory.Write(Pointer+1528,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_fAnchoredAngle")]
    public float @AnchoredAngle { get => SdkMemory.Read<float >(Pointer+1532); set { SdkMemory.Write(Pointer+1532,value); } }
    [NativeMember("m_nAttackPlayerTime")]
    public int @AttackPlayerTime { get => SdkMemory.Read<int >(Pointer+1536); set { SdkMemory.Write(Pointer+1536,value); } }
    [NativeMember("field_604")]
    public int @Field604 { get => SdkMemory.Read<int >(Pointer+1540); set { SdkMemory.Write(Pointer+1540,value); } }
    [NativeMember("m_fBurningTimer")]
    public float @BurningTimer { get => SdkMemory.Read<float >(Pointer+1544); set { SdkMemory.Write(Pointer+1544,value); } }
    [NativeMember("m_pWhoDestroyedMe")]
    public CEntity? @WhoDestroyedMe { get => SdkMemory.Read<IntPtr>(Pointer+1548) == IntPtr.Zero ? null : new CEntity(SdkMemory.Read<IntPtr>(Pointer+1548)); set { SdkMemory.Write(Pointer+1548,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_vecBoatMoveForce")]
    public CVector @BoatMoveForce { get => new CVector(Pointer+1552); set { SdkMemory.Copy(value.Pointer,Pointer+1552,12); } }
    [NativeMember("m_vecBoatTurnForce")]
    public CVector @BoatTurnForce { get => new CVector(Pointer+1564); set { SdkMemory.Copy(value.Pointer,Pointer+1564,12); } }
    [NativeMember("m_apPropSplashFx")]
    public NativeArray<IntPtr> @PropSplashFx { get => new NativeArray<IntPtr>(Pointer+1576,2); }
    [NativeMember("m_vecWaterDamping")]
    public CVector @WaterDamping { get => new CVector(Pointer+1584); set { SdkMemory.Copy(value.Pointer,Pointer+1584,12); } }
    [NativeMember("field_63C")]
    public sbyte @Field63C { get => SdkMemory.Read<sbyte >(Pointer+1596); set { SdkMemory.Write(Pointer+1596,value); } }
    [NativeMember("m_nPadNumber")]
    public byte @PadNumber { get => SdkMemory.Read<byte >(Pointer+1597); set { SdkMemory.Write(Pointer+1597,value); } }
    [NativeMember("m_fWaterResistance")]
    public float @WaterResistance { get => SdkMemory.Read<float >(Pointer+1600); set { SdkMemory.Write(Pointer+1600,value); } }
    [NativeMember("m_nNumWaterTrailPoints")]
    public short @CountWaterTrailPoints { get => SdkMemory.Read<short >(Pointer+1604); set { SdkMemory.Write(Pointer+1604,value); } }
    [NativeMember("m_avecWakePoints")]
    public NativeObjectArray<CVector2D> @WakePoints { get => new NativeObjectArray<CVector2D>(Pointer+1608,32,8); }
    [NativeMember("m_afWakePointLifeTime")]
    public NativeArray<float> @WakePointLifeTime { get => new NativeArray<float>(Pointer+1864,32); }
    [NativeMember("m_anWakePointIntensity")]
    public NativeArray<byte> @WakePointIntensity { get => new NativeArray<byte>(Pointer+1992,32); }
    [NativeMember("apFrameWakeGeneratingBoats")]
    public static NativePointer<IntPtr> @FrameWakeGeneratingBoats { get => new NativePointer<IntPtr>(new IntPtr(0xC27994)); }
    [NativeMember("MAX_WAKE_LENGTH")]
    public static float @MAXWAKELENGTH { get => SdkMemory.Read<float >(new IntPtr(0x8D3938)); set { SdkMemory.Write(new IntPtr(0x8D3938),value); } }
    [NativeMember("MIN_WAKE_INTERVAL")]
    public static float @MINWAKEINTERVAL { get => SdkMemory.Read<float >(new IntPtr(0x8D393C)); set { SdkMemory.Write(new IntPtr(0x8D393C),value); } }
    [NativeMember("WAKE_LIFETIME")]
    public static float @WAKELIFETIME { get => SdkMemory.Read<float >(new IntPtr(0x8D3940)); set { SdkMemory.Write(new IntPtr(0x8D3940),value); } }
    public void @InitializeAt(int @modelIndex,byte @createdBy) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1223 >(1223)(Pointer,@modelIndex,@createdBy); }
    public void @SetupModelNodes() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1224 >(1224)(Pointer); }
    public void @DebugCode() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1225 >(1225)(Pointer); }
    public void @PrintThrustAndRudderInfo() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1226 >(1226)(Pointer); }
    public void @ModifyHandlingValue(NativePointer<bool> @arg0) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1227 >(1227)(Pointer,@arg0.Pointer); }
    public void @PruneWakeTrail() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1228 >(1228)(Pointer); }
    public void @AddWakePoint(CVector @posn) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1229 >(1229)(Pointer,@posn.Pointer); }
    public static bool @IsSectorAffectedByWake(CVector2D @arg0,float @arg1,NativePointer<IntPtr> @arg2) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1230 >(1230)(@arg0.Pointer,@arg1,@arg2.Pointer); return __sdkResult != 0; }
    public static float @IsVertexAffectedByWake(CVector @arg0,CBoat? @arg1,short @arg2,bool @arg3) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1231 >(1231)(@arg0.Pointer,@arg1?.Pointer ?? IntPtr.Zero,@arg2,(@arg3 ? 1 : 0)); return __sdkResult; }
    public static void @CheckForSkippingCalculations() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1232 >(1232)(); }
    public static void @FillBoatList() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1233 >(1233)(); }
}
