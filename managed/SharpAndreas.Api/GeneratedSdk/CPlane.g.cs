// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CPlane : CAutomobile
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=2564;
    public CPlane(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("field_988")]
    public float @Field988 { get => SdkMemory.Read<float >(Pointer+2440); set { SdkMemory.Write(Pointer+2440,value); } }
    [NativeMember("field_98C")]
    public int @Field98C { get => SdkMemory.Read<int >(Pointer+2444); set { SdkMemory.Write(Pointer+2444,value); } }
    [NativeMember("field_990")]
    public int @Field990 { get => SdkMemory.Read<int >(Pointer+2448); set { SdkMemory.Write(Pointer+2448,value); } }
    [NativeMember("field_994")]
    public int @Field994 { get => SdkMemory.Read<int >(Pointer+2452); set { SdkMemory.Write(Pointer+2452,value); } }
    [NativeMember("field_998")]
    public float @Field998 { get => SdkMemory.Read<float >(Pointer+2456); set { SdkMemory.Write(Pointer+2456,value); } }
    [NativeMember("field_99C")]
    public int @Field99C { get => SdkMemory.Read<int >(Pointer+2460); set { SdkMemory.Write(Pointer+2460,value); } }
    [NativeMember("field_9A0")]
    public int @Field9A0 { get => SdkMemory.Read<int >(Pointer+2464); set { SdkMemory.Write(Pointer+2464,value); } }
    [NativeMember("field_9A4")]
    public int @Field9A4 { get => SdkMemory.Read<int >(Pointer+2468); set { SdkMemory.Write(Pointer+2468,value); } }
    [NativeMember("field_9A8")]
    public float @Field9A8 { get => SdkMemory.Read<float >(Pointer+2472); set { SdkMemory.Write(Pointer+2472,value); } }
    [NativeMember("field_9AC")]
    public float @Field9AC { get => SdkMemory.Read<float >(Pointer+2476); set { SdkMemory.Write(Pointer+2476,value); } }
    [NativeMember("field_9B0")]
    public float @Field9B0 { get => SdkMemory.Read<float >(Pointer+2480); set { SdkMemory.Write(Pointer+2480,value); } }
    [NativeMember("field_9B4")]
    public float @Field9B4 { get => SdkMemory.Read<float >(Pointer+2484); set { SdkMemory.Write(Pointer+2484,value); } }
    [NativeMember("field_9B8")]
    public int @Field9B8 { get => SdkMemory.Read<int >(Pointer+2488); set { SdkMemory.Write(Pointer+2488,value); } }
    [NativeMember("field_9BC")]
    public int @Field9BC { get => SdkMemory.Read<int >(Pointer+2492); set { SdkMemory.Write(Pointer+2492,value); } }
    [NativeMember("m_nStartedFlyingTime")]
    public uint @StartedFlyingTime { get => SdkMemory.Read<uint >(Pointer+2496); set { SdkMemory.Write(Pointer+2496,value); } }
    [NativeMember("field_9C4")]
    public int @Field9C4 { get => SdkMemory.Read<int >(Pointer+2500); set { SdkMemory.Write(Pointer+2500,value); } }
    [NativeMember("field_9C8")]
    public float @Field9C8 { get => SdkMemory.Read<float >(Pointer+2504); set { SdkMemory.Write(Pointer+2504,value); } }
    [NativeMember("m_fLandingGearStatus")]
    public float @LandingGearStatus { get => SdkMemory.Read<float >(Pointer+2508); set { SdkMemory.Write(Pointer+2508,value); } }
    [NativeMember("field_9D0")]
    public int @Field9D0 { get => SdkMemory.Read<int >(Pointer+2512); set { SdkMemory.Write(Pointer+2512,value); } }
    [NativeMember("m_pGunParticles")]
    public NativePointer<IntPtr> @GunParticles { get => new NativePointer<IntPtr>(SdkMemory.Read<IntPtr>(Pointer+2516)); set { SdkMemory.Write(Pointer+2516,value.Pointer); } }
    [NativeMember("m_nFiringMultiplier")]
    public byte @FiringMultiplier { get => SdkMemory.Read<byte >(Pointer+2520); set { SdkMemory.Write(Pointer+2520,value); } }
    [NativeMember("field_9DC")]
    public int @Field9DC { get => SdkMemory.Read<int >(Pointer+2524); set { SdkMemory.Write(Pointer+2524,value); } }
    [NativeMember("field_9E0")]
    public int @Field9E0 { get => SdkMemory.Read<int >(Pointer+2528); set { SdkMemory.Write(Pointer+2528,value); } }
    [NativeMember("field_9E4")]
    public int @Field9E4 { get => SdkMemory.Read<int >(Pointer+2532); set { SdkMemory.Write(Pointer+2532,value); } }
    [NativeMember("m_apJettrusParticles")]
    public NativeArray<IntPtr> @JettrusParticles { get => new NativeArray<IntPtr>(Pointer+2536,4); }
    [NativeMember("m_pSmokeParticle")]
    public FxSystem_c? @SmokeParticle { get => SdkMemory.Read<IntPtr>(Pointer+2552) == IntPtr.Zero ? null : new FxSystem_c(SdkMemory.Read<IntPtr>(Pointer+2552)); set { SdkMemory.Write(Pointer+2552,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_nSmokeTimer")]
    public uint @SmokeTimer { get => SdkMemory.Read<uint >(Pointer+2556); set { SdkMemory.Write(Pointer+2556,value); } }
    [NativeMember("m_bSmokeEjectorEnabled")]
    public bool @SmokeEjectorEnabled { get => SdkMemory.Read<bool >(Pointer+2560); set { SdkMemory.Write(Pointer+2560,value); } }
    [NativeMember("GenPlane_Active")]
    public static bool @GenPlaneActive { get => SdkMemory.Read<bool >(new IntPtr(0x8D33BC)); set { SdkMemory.Write(new IntPtr(0x8D33BC),value); } }
    [NativeMember("GenPlane_ModelIndex")]
    public static int @GenPlaneModelIndex { get => SdkMemory.Read<int >(new IntPtr(0xC1CAD8)); set { SdkMemory.Write(new IntPtr(0xC1CAD8),value); } }
    [NativeMember("GenPlane_Status")]
    public static uint @GenPlaneStatus { get => SdkMemory.Read<uint >(new IntPtr(0xC1CADC)); set { SdkMemory.Write(new IntPtr(0xC1CADC),value); } }
    [NativeMember("GenPlane_LastTimeGenerated")]
    public static uint @GenPlaneLastTimeGenerated { get => SdkMemory.Read<uint >(new IntPtr(0xC1CAE0)); set { SdkMemory.Write(new IntPtr(0xC1CAE0),value); } }
    [NativeMember("ANDROM_COL_ANGLE_MULT")]
    public static float @ANDROMCollisionANGLEMULT { get => SdkMemory.Read<float >(new IntPtr(0x8D33C0)); set { SdkMemory.Write(new IntPtr(0x8D33C0),value); } }
    [NativeMember("HARRIER_NOZZLE_ROTATE_LIMIT")]
    public static float @HARRIERNOZZLEROTATELIMIT { get => SdkMemory.Read<float >(new IntPtr(0x8D33C4)); set { SdkMemory.Write(new IntPtr(0x8D33C4),value); } }
    [NativeMember("HARRIER_NOZZLE_SWITCH_LIMIT")]
    public static float @HARRIERNOZZLESWITCHLIMIT { get => SdkMemory.Read<float >(new IntPtr(0x8D33C8)); set { SdkMemory.Write(new IntPtr(0x8D33C8),value); } }
    [NativeMember("PLANE_MIN_PROP_SPEED")]
    public static float @PLANEMINPROPSPEED { get => SdkMemory.Read<float >(new IntPtr(0x8D33CC)); set { SdkMemory.Write(new IntPtr(0x8D33CC),value); } }
    [NativeMember("PLANE_STD_PROP_SPEED")]
    public static float @PLANESTDPROPSPEED { get => SdkMemory.Read<float >(new IntPtr(0x8D33D0)); set { SdkMemory.Write(new IntPtr(0x8D33D0),value); } }
    [NativeMember("PLANE_MAX_PROP_SPEED")]
    public static float @PLANEMAXPROPSPEED { get => SdkMemory.Read<float >(new IntPtr(0x8D33D4)); set { SdkMemory.Write(new IntPtr(0x8D33D4),value); } }
    [NativeMember("PLANE_ROC_PROP_SPEED")]
    public static float @PLANEROCPROPSPEED { get => SdkMemory.Read<float >(new IntPtr(0x8D33D8)); set { SdkMemory.Write(new IntPtr(0x8D33D8),value); } }
    public void @InitializeAt(int @modelIndex,byte @createdBy) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1727 >(1727)(Pointer,@modelIndex,@createdBy); }
    public void @IsAlreadyFlying() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1728 >(1728)(Pointer); }
    public void @SetGearUp() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1729 >(1729)(Pointer); }
    public void @SetGearDown() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1730 >(1730)(Pointer); }
    public static void @InitPlaneGenerationAndRemoval() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1731 >(1731)(); }
    public static uint @CountPlanesAndHelis() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1732 >(1732)(); return __sdkResult; }
    public static bool @AreWeInNoPlaneZone() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1733 >(1733)(); return __sdkResult != 0; }
    public static bool @AreWeInNoBigPlaneZone() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1734 >(1734)(); return __sdkResult != 0; }
    public static void @SwitchAmbientPlanes(bool @enable) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1735 >(1735)((@enable ? 1 : 0)); }
    public static void @FindPlaneCreationCoors(CVector? @arg0,CVector? @arg1,NativePointer<float> @arg2,NativePointer<float> @arg3,bool @arg4) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1736 >(1736)(@arg0?.Pointer ?? IntPtr.Zero,@arg1?.Pointer ?? IntPtr.Zero,@arg2.Pointer,@arg3.Pointer,(@arg4 ? 1 : 0)); }
    public static void @DoPlaneGenerationAndRemoval() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1737 >(1737)(); }
}
