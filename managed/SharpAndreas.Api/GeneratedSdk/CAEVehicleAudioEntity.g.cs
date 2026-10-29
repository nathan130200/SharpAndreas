// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CAEVehicleAudioEntity : CAEAudioEntity
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=588;
    public CAEVehicleAudioEntity(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("field_7C")]
    public short @Field7C { get => SdkMemory.Read<short >(Pointer+124); set { SdkMemory.Write(Pointer+124,value); } }
    [NativeMember("field_7E")]
    public NativeArray<sbyte> @Field7E { get => new NativeArray<sbyte>(Pointer+126,2); }
    [NativeMember("m_settings")]
    public tVehicleAudioSettings @Settings { get => new tVehicleAudioSettings(Pointer+128); set { SdkMemory.Copy(value.Pointer,Pointer+128,36); } }
    [NativeMember("m_bEnabled")]
    public bool @Enabled { get => SdkMemory.Read<bool >(Pointer+164); set { SdkMemory.Write(Pointer+164,value); } }
    [NativeMember("m_bPlayerDriver")]
    public bool @PlayerDriver { get => SdkMemory.Read<bool >(Pointer+165); set { SdkMemory.Write(Pointer+165,value); } }
    [NativeMember("m_bPlayerPassenger")]
    public bool @PlayerPassenger { get => SdkMemory.Read<bool >(Pointer+166); set { SdkMemory.Write(Pointer+166,value); } }
    [NativeMember("m_bVehicleRadioPaused")]
    public bool @VehicleRadioPaused { get => SdkMemory.Read<bool >(Pointer+167); set { SdkMemory.Write(Pointer+167,value); } }
    [NativeMember("m_bSoundsStopped")]
    public bool @SoundsStopped { get => SdkMemory.Read<bool >(Pointer+168); set { SdkMemory.Write(Pointer+168,value); } }
    [NativeMember("m_nEngineState")]
    public sbyte @EngineState { get => SdkMemory.Read<sbyte >(Pointer+169); set { SdkMemory.Write(Pointer+169,value); } }
    [NativeMember("field_AA")]
    public sbyte @FieldAA { get => SdkMemory.Read<sbyte >(Pointer+170); set { SdkMemory.Write(Pointer+170,value); } }
    [NativeMember("field_AB")]
    public sbyte @FieldAB { get => SdkMemory.Read<sbyte >(Pointer+171); set { SdkMemory.Write(Pointer+171,value); } }
    [NativeMember("field_AC")]
    public int @FieldAC { get => SdkMemory.Read<int >(Pointer+172); set { SdkMemory.Write(Pointer+172,value); } }
    [NativeMember("m_bInhibitAccForLowSpeed")]
    public bool @InhibitAccForLowSpeed { get => SdkMemory.Read<bool >(Pointer+176); set { SdkMemory.Write(Pointer+176,value); } }
    [NativeMember("field_B1")]
    public sbyte @FieldB1 { get => SdkMemory.Read<sbyte >(Pointer+177); set { SdkMemory.Write(Pointer+177,value); } }
    [NativeMember("m_nRainDropCounter")]
    public short @RainDropCounter { get => SdkMemory.Read<short >(Pointer+178); set { SdkMemory.Write(Pointer+178,value); } }
    [NativeMember("field_B4")]
    public short @FieldB4 { get => SdkMemory.Read<short >(Pointer+180); set { SdkMemory.Write(Pointer+180,value); } }
    [NativeMember("gap_B6")]
    public NativeArray<sbyte> @GapB6 { get => new NativeArray<sbyte>(Pointer+182,2); }
    [NativeMember("field_B8")]
    public int @FieldB8 { get => SdkMemory.Read<int >(Pointer+184); set { SdkMemory.Write(Pointer+184,value); } }
    [NativeMember("field_BC")]
    public sbyte @FieldBC { get => SdkMemory.Read<sbyte >(Pointer+188); set { SdkMemory.Write(Pointer+188,value); } }
    [NativeMember("m_bDisableHeliEngineSounds")]
    public bool @DisableHeliEngineSounds { get => SdkMemory.Read<bool >(Pointer+189); set { SdkMemory.Write(Pointer+189,value); } }
    [NativeMember("field_BE")]
    public sbyte @FieldBE { get => SdkMemory.Read<sbyte >(Pointer+190); set { SdkMemory.Write(Pointer+190,value); } }
    [NativeMember("m_bSirenOrAlarmPlaying")]
    public bool @SirenOrAlarmPlaying { get => SdkMemory.Read<bool >(Pointer+191); set { SdkMemory.Write(Pointer+191,value); } }
    [NativeMember("m_bHornPlaying")]
    public bool @HornPlaying { get => SdkMemory.Read<bool >(Pointer+192); set { SdkMemory.Write(Pointer+192,value); } }
    [NativeMember("gap_C1")]
    public NativeArray<sbyte> @GapC1 { get => new NativeArray<sbyte>(Pointer+193,3); }
    [NativeMember("m_fSirenVolume")]
    public float @SirenVolume { get => SdkMemory.Read<float >(Pointer+196); set { SdkMemory.Write(Pointer+196,value); } }
    [NativeMember("m_bModelWithSiren")]
    public bool @ModelWithSiren { get => SdkMemory.Read<bool >(Pointer+200); set { SdkMemory.Write(Pointer+200,value); } }
    [NativeMember("gap_C9")]
    public NativeArray<sbyte> @GapC9 { get => new NativeArray<sbyte>(Pointer+201,3); }
    [NativeMember("m_nBoatHitWaveLastPlayedTime")]
    public uint @BoatHitWaveLastPlayedTime { get => SdkMemory.Read<uint >(Pointer+204); set { SdkMemory.Write(Pointer+204,value); } }
    [NativeMember("m_nTimeToInhibitAcc")]
    public uint @TimeToInhibitAcc { get => SdkMemory.Read<uint >(Pointer+208); set { SdkMemory.Write(Pointer+208,value); } }
    [NativeMember("m_nTimeToInhibitCrz")]
    public uint @TimeToInhibitCrz { get => SdkMemory.Read<uint >(Pointer+212); set { SdkMemory.Write(Pointer+212,value); } }
    [NativeMember("m_fGeneralVehicleSoundVolume")]
    public float @GeneralVehicleSoundVolume { get => SdkMemory.Read<float >(Pointer+216); set { SdkMemory.Write(Pointer+216,value); } }
    [NativeMember("m_nEngineDecelerateSoundBankId")]
    public short @EngineDecelerateSoundBankId { get => SdkMemory.Read<short >(Pointer+220); set { SdkMemory.Write(Pointer+220,value); } }
    [NativeMember("m_nEngineAccelerateSoundBankId")]
    public short @EngineAccelerateSoundBankId { get => SdkMemory.Read<short >(Pointer+222); set { SdkMemory.Write(Pointer+222,value); } }
    [NativeMember("m_nEngineBankSlotId")]
    public short @EngineBankSlotId { get => SdkMemory.Read<short >(Pointer+224); set { SdkMemory.Write(Pointer+224,value); } }
    [NativeMember("field_E2")]
    public short @FieldE2 { get => SdkMemory.Read<short >(Pointer+226); set { SdkMemory.Write(Pointer+226,value); } }
    [NativeMember("m_aEngineSounds")]
    public NativeObjectArray<tVehicleSound> @EngineSounds { get => new NativeObjectArray<tVehicleSound>(Pointer+228,12,8); }
    [NativeMember("field_144")]
    public int @Field144 { get => SdkMemory.Read<int >(Pointer+324); set { SdkMemory.Write(Pointer+324,value); } }
    [NativeMember("field_148")]
    public short @Field148 { get => SdkMemory.Read<short >(Pointer+328); set { SdkMemory.Write(Pointer+328,value); } }
    [NativeMember("field_14A")]
    public short @Field14A { get => SdkMemory.Read<short >(Pointer+330); set { SdkMemory.Write(Pointer+330,value); } }
    [NativeMember("field_14C")]
    public short @Field14C { get => SdkMemory.Read<short >(Pointer+332); set { SdkMemory.Write(Pointer+332,value); } }
    [NativeMember("field_14E")]
    public short @Field14E { get => SdkMemory.Read<short >(Pointer+334); set { SdkMemory.Write(Pointer+334,value); } }
    [NativeMember("field_150")]
    public int @Field150 { get => SdkMemory.Read<int >(Pointer+336); set { SdkMemory.Write(Pointer+336,value); } }
    [NativeMember("field_154")]
    public short @Field154 { get => SdkMemory.Read<short >(Pointer+340); set { SdkMemory.Write(Pointer+340,value); } }
    [NativeMember("m_nSkidSoundType")]
    public short @SkidSoundType { get => SdkMemory.Read<short >(Pointer+342); set { SdkMemory.Write(Pointer+342,value); } }
    [NativeMember("field_158")]
    public CAESound? @Field158 { get => SdkMemory.Read<IntPtr>(Pointer+344) == IntPtr.Zero ? null : new CAESound(SdkMemory.Read<IntPtr>(Pointer+344)); set { SdkMemory.Write(Pointer+344,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_nRoadNoiseSoundType")]
    public short @RoadNoiseSoundType { get => SdkMemory.Read<short >(Pointer+348); set { SdkMemory.Write(Pointer+348,value); } }
    [NativeMember("gap_15E")]
    public NativeArray<sbyte> @Gap15E { get => new NativeArray<sbyte>(Pointer+350,2); }
    [NativeMember("m_pRoadNoiseSound")]
    public CAESound? @RoadNoiseSound { get => SdkMemory.Read<IntPtr>(Pointer+352) == IntPtr.Zero ? null : new CAESound(SdkMemory.Read<IntPtr>(Pointer+352)); set { SdkMemory.Write(Pointer+352,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_nFlatTyreSoundType")]
    public short @FlatTyreSoundType { get => SdkMemory.Read<short >(Pointer+356); set { SdkMemory.Write(Pointer+356,value); } }
    [NativeMember("gap_166")]
    public NativeArray<sbyte> @Gap166 { get => new NativeArray<sbyte>(Pointer+358,2); }
    [NativeMember("m_pFlatTyreSound")]
    public CAESound? @FlatTyreSound { get => SdkMemory.Read<IntPtr>(Pointer+360) == IntPtr.Zero ? null : new CAESound(SdkMemory.Read<IntPtr>(Pointer+360)); set { SdkMemory.Write(Pointer+360,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_nReverseGearSoundType")]
    public short @ReverseGearSoundType { get => SdkMemory.Read<short >(Pointer+364); set { SdkMemory.Write(Pointer+364,value); } }
    [NativeMember("gap_16E")]
    public NativeArray<sbyte> @Gap16E { get => new NativeArray<sbyte>(Pointer+366,2); }
    [NativeMember("m_pReverseGearSound")]
    public CAESound? @ReverseGearSound { get => SdkMemory.Read<IntPtr>(Pointer+368) == IntPtr.Zero ? null : new CAESound(SdkMemory.Read<IntPtr>(Pointer+368)); set { SdkMemory.Write(Pointer+368,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("gap_174")]
    public NativeArray<sbyte> @Gap174 { get => new NativeArray<sbyte>(Pointer+372,4); }
    [NativeMember("m_pHornTonSound")]
    public CAESound? @HornTonSound { get => SdkMemory.Read<IntPtr>(Pointer+376) == IntPtr.Zero ? null : new CAESound(SdkMemory.Read<IntPtr>(Pointer+376)); set { SdkMemory.Write(Pointer+376,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_pSirenSound")]
    public CAESound? @SirenSound { get => SdkMemory.Read<IntPtr>(Pointer+380) == IntPtr.Zero ? null : new CAESound(SdkMemory.Read<IntPtr>(Pointer+380)); set { SdkMemory.Write(Pointer+380,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_pPoliceSirenSound")]
    public CAESound? @PoliceSirenSound { get => SdkMemory.Read<IntPtr>(Pointer+384) == IntPtr.Zero ? null : new CAESound(SdkMemory.Read<IntPtr>(Pointer+384)); set { SdkMemory.Write(Pointer+384,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_skidSound")]
    public CAETwinLoopSoundEntity @SkidSound { get => new CAETwinLoopSoundEntity(Pointer+388); set { SdkMemory.Copy(value.Pointer,Pointer+388,168); } }
    [NativeMember("field_22C")]
    public float @Field22C { get => SdkMemory.Read<float >(Pointer+556); set { SdkMemory.Write(Pointer+556,value); } }
    [NativeMember("field_230")]
    public float @Field230 { get => SdkMemory.Read<float >(Pointer+560); set { SdkMemory.Write(Pointer+560,value); } }
    [NativeMember("field_234")]
    public float @Field234 { get => SdkMemory.Read<float >(Pointer+564); set { SdkMemory.Write(Pointer+564,value); } }
    [NativeMember("field_238")]
    public float @Field238 { get => SdkMemory.Read<float >(Pointer+568); set { SdkMemory.Write(Pointer+568,value); } }
    [NativeMember("field_23C")]
    public float @Field23C { get => SdkMemory.Read<float >(Pointer+572); set { SdkMemory.Write(Pointer+572,value); } }
    [NativeMember("field_240")]
    public int @Field240 { get => SdkMemory.Read<int >(Pointer+576); set { SdkMemory.Write(Pointer+576,value); } }
    [NativeMember("m_bNitroSoundPresent")]
    public bool @NitroSoundPresent { get => SdkMemory.Read<bool >(Pointer+580); set { SdkMemory.Write(Pointer+580,value); } }
    [NativeMember("field_245")]
    public NativeArray<sbyte> @Field245 { get => new NativeArray<sbyte>(Pointer+581,3); }
    [NativeMember("field_248")]
    public float @Field248 { get => SdkMemory.Read<float >(Pointer+584); set { SdkMemory.Write(Pointer+584,value); } }
    [NativeMember("s_pPlayerAttachedForRadio")]
    public static CPed? @PlayerAttachedForRadio { get => SdkMemory.Read<IntPtr>(new IntPtr(0xB6B98C)) == IntPtr.Zero ? null : new CPed(SdkMemory.Read<IntPtr>(new IntPtr(0xB6B98C))); set { SdkMemory.Write(new IntPtr(0xB6B98C),value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("s_pPlayerDriver")]
    public static CPed? @PlayerDriverValue { get => SdkMemory.Read<IntPtr>(new IntPtr(0xB6B990)) == IntPtr.Zero ? null : new CPed(SdkMemory.Read<IntPtr>(new IntPtr(0xB6B990))); set { SdkMemory.Write(new IntPtr(0xB6B990),value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("s_HelicoptorsDisabled")]
    public static bool @HelicoptorsDisabled { get => SdkMemory.Read<bool >(new IntPtr(0xB6B994)); set { SdkMemory.Write(new IntPtr(0xB6B994),value); } }
    [NativeMember("s_NextDummyEngineSlot")]
    public static short @NextDummyEngineSlot { get => SdkMemory.Read<short >(new IntPtr(0xB6B998)); set { SdkMemory.Write(new IntPtr(0xB6B998),value); } }
    [NativeMember("s_pVehicleAudioSettingsForRadio")]
    public static tVehicleAudioSettings? @VehicleAudioSettingsForRadio { get => SdkMemory.Read<IntPtr>(new IntPtr(0xB6B99C)) == IntPtr.Zero ? null : new tVehicleAudioSettings(SdkMemory.Read<IntPtr>(new IntPtr(0xB6B99C))); set { SdkMemory.Write(new IntPtr(0xB6B99C),value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("s_DummyEngineSlots")]
    public static NativeObjectArray<tEngineDummySlot> @DummyEngineSlots { get => new NativeObjectArray<tEngineDummySlot>(new IntPtr(0xB6B9A0),10,4); }
}
