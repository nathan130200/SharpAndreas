// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CPostEffects : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=1;
    public CPostEffects(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_bDisableAllPostEffect")]
    public static bool @DisableAllPostEffect { get => SdkMemory.Read<bool >(new IntPtr(0xC402CF)); set { SdkMemory.Write(new IntPtr(0xC402CF),value); } }
    [NativeMember("m_bSavePhotoFromScript")]
    public static bool @SavePhotoFromScript { get => SdkMemory.Read<bool >(new IntPtr(0xC402D0)); set { SdkMemory.Write(new IntPtr(0xC402D0),value); } }
    [NativeMember("m_bInCutscene")]
    public static bool @InCutscene { get => SdkMemory.Read<bool >(new IntPtr(0xC402B7)); set { SdkMemory.Write(new IntPtr(0xC402B7),value); } }
    [NativeMember("m_xoffset")]
    public static float @Xoffset { get => SdkMemory.Read<float >(new IntPtr(0x8D5130)); set { SdkMemory.Write(new IntPtr(0x8D5130),value); } }
    [NativeMember("m_yoffset")]
    public static float @Yoffset { get => SdkMemory.Read<float >(new IntPtr(0x8D5134)); set { SdkMemory.Write(new IntPtr(0x8D5134),value); } }
    [NativeMember("m_colour1Multiplier")]
    public static float @Colour1Multiplier { get => SdkMemory.Read<float >(new IntPtr(0x8D5160)); set { SdkMemory.Write(new IntPtr(0x8D5160),value); } }
    [NativeMember("m_colour2Multiplier")]
    public static float @Colour2Multiplier { get => SdkMemory.Read<float >(new IntPtr(0x8D5164)); set { SdkMemory.Write(new IntPtr(0x8D5164),value); } }
    [NativeMember("m_colourLeftUOffset")]
    public static float @ColorLeftUOffset { get => SdkMemory.Read<float >(new IntPtr(0x8D5150)); set { SdkMemory.Write(new IntPtr(0x8D5150),value); } }
    [NativeMember("m_colourRightUOffset")]
    public static float @ColorRightUOffset { get => SdkMemory.Read<float >(new IntPtr(0x8D5154)); set { SdkMemory.Write(new IntPtr(0x8D5154),value); } }
    [NativeMember("m_colourTopVOffset")]
    public static float @ColorTopVOffset { get => SdkMemory.Read<float >(new IntPtr(0x8D5158)); set { SdkMemory.Write(new IntPtr(0x8D5158),value); } }
    [NativeMember("m_colourBottomVOffset")]
    public static float @ColorBottomVOffset { get => SdkMemory.Read<float >(new IntPtr(0x8D515C)); set { SdkMemory.Write(new IntPtr(0x8D515C),value); } }
    [NativeMember("m_bNightVision")]
    public static bool @NightVisionValue { get => SdkMemory.Read<bool >(new IntPtr(0xC402B8)); set { SdkMemory.Write(new IntPtr(0xC402B8),value); } }
    [NativeMember("m_fNightVisionSwitchOnFXCount")]
    public static float @NightVisionSwitchOnFXCount { get => SdkMemory.Read<float >(new IntPtr(0xC40300)); set { SdkMemory.Write(new IntPtr(0xC40300),value); } }
    [NativeMember("m_fNightVisionSwitchOnFXTime")]
    public static float @NightVisionSwitchOnFXTime { get => SdkMemory.Read<float >(new IntPtr(0x8D50B0)); set { SdkMemory.Write(new IntPtr(0x8D50B0),value); } }
    [NativeMember("m_NightVisionGrainStrength")]
    public static int @NightVisionGrainStrength { get => SdkMemory.Read<int >(new IntPtr(0x8D50A8)); set { SdkMemory.Write(new IntPtr(0x8D50A8),value); } }
    [NativeMember("m_NightVisionMainCol")]
    public static CRGBA @NightVisionMainCollision { get => new CRGBA(new IntPtr(0x8D50AC)); set { SdkMemory.Copy(value.Pointer,new IntPtr(0x8D50AC),4); } }
    [NativeMember("m_bDarknessFilter")]
    public static bool @DarknessFilterValue { get => SdkMemory.Read<bool >(new IntPtr(0xC402C4)); set { SdkMemory.Write(new IntPtr(0xC402C4),value); } }
    [NativeMember("m_DarknessFilterAlpha")]
    public static int @DarknessFilterAlpha { get => SdkMemory.Read<int >(new IntPtr(0x8D5204)); set { SdkMemory.Write(new IntPtr(0x8D5204),value); } }
    [NativeMember("m_DarknessFilterAlphaDefault")]
    public static int @DarknessFilterAlphaDefault { get => SdkMemory.Read<int >(new IntPtr(0x8D50F4)); set { SdkMemory.Write(new IntPtr(0x8D50F4),value); } }
    [NativeMember("m_DarknessFilterRadiosityIntensityLimit")]
    public static int @DarknessFilterRadiosityIntensityLimit { get => SdkMemory.Read<int >(new IntPtr(0x8D50F8)); set { SdkMemory.Write(new IntPtr(0x8D50F8),value); } }
    [NativeMember("m_fWaterFXStartUnderWaterness")]
    public static float @WaterFXStartUnderWaterness { get => SdkMemory.Read<float >(new IntPtr(0x8D514C)); set { SdkMemory.Write(new IntPtr(0x8D514C),value); } }
    [NativeMember("m_fWaterFullDarknessDepth")]
    public static float @WaterFullDarknessDepth { get => SdkMemory.Read<float >(new IntPtr(0x8D5148)); set { SdkMemory.Write(new IntPtr(0x8D5148),value); } }
    [NativeMember("m_bWaterDepthDarkness")]
    public static bool @WaterDepthDarkness { get => SdkMemory.Read<bool >(new IntPtr(0x8D5144)); set { SdkMemory.Write(new IntPtr(0x8D5144),value); } }
    [NativeMember("m_bHeatHazeFX")]
    public static bool @HeatHazeFXValue { get => SdkMemory.Read<bool >(new IntPtr(0xC402BA)); set { SdkMemory.Write(new IntPtr(0xC402BA),value); } }
    [NativeMember("m_HeatHazeFXSpeedMin")]
    public static int @HeatHazeFXSpeedMin { get => SdkMemory.Read<int >(new IntPtr(0x8D50EC)); set { SdkMemory.Write(new IntPtr(0x8D50EC),value); } }
    [NativeMember("m_HeatHazeFXSpeedMax")]
    public static int @HeatHazeFXSpeedMax { get => SdkMemory.Read<int >(new IntPtr(0x8D50F0)); set { SdkMemory.Write(new IntPtr(0x8D50F0),value); } }
    [NativeMember("m_HeatHazeFXIntensity")]
    public static int @HeatHazeFXIntensity { get => SdkMemory.Read<int >(new IntPtr(0x8D50E8)); set { SdkMemory.Write(new IntPtr(0x8D50E8),value); } }
    [NativeMember("m_HeatHazeFXType")]
    public static int @HeatHazeFXType { get => SdkMemory.Read<int >(new IntPtr(0xC402BC)); set { SdkMemory.Write(new IntPtr(0xC402BC),value); } }
    [NativeMember("m_HeatHazeFXTypeLast")]
    public static int @HeatHazeFXTypeLast { get => SdkMemory.Read<int >(new IntPtr(0x8D50E4)); set { SdkMemory.Write(new IntPtr(0x8D50E4),value); } }
    [NativeMember("m_HeatHazeFXRandomShift")]
    public static int @HeatHazeFXRandomShift { get => SdkMemory.Read<int >(new IntPtr(0xC402C0)); set { SdkMemory.Write(new IntPtr(0xC402C0),value); } }
    [NativeMember("m_HeatHazeFXScanSizeX")]
    public static int @HeatHazeFXScanSizeX { get => SdkMemory.Read<int >(new IntPtr(0xC40304)); set { SdkMemory.Write(new IntPtr(0xC40304),value); } }
    [NativeMember("m_HeatHazeFXScanSizeY")]
    public static int @HeatHazeFXScanSizeY { get => SdkMemory.Read<int >(new IntPtr(0xC40308)); set { SdkMemory.Write(new IntPtr(0xC40308),value); } }
    [NativeMember("m_HeatHazeFXRenderSizeX")]
    public static int @HeatHazeFXRenderSizeX { get => SdkMemory.Read<int >(new IntPtr(0xC4030C)); set { SdkMemory.Write(new IntPtr(0xC4030C),value); } }
    [NativeMember("m_HeatHazeFXRenderSizeY")]
    public static int @HeatHazeFXRenderSizeY { get => SdkMemory.Read<int >(new IntPtr(0xC40310)); set { SdkMemory.Write(new IntPtr(0xC40310),value); } }
    [NativeMember("m_bFog")]
    public static bool @FogValue { get => SdkMemory.Read<bool >(new IntPtr(0xC402C6)); set { SdkMemory.Write(new IntPtr(0xC402C6),value); } }
    [NativeMember("m_bSpeedFX")]
    public static bool @SpeedFXValue { get => SdkMemory.Read<bool >(new IntPtr(0x8D5100)); set { SdkMemory.Write(new IntPtr(0x8D5100),value); } }
    [NativeMember("m_bSpeedFXTestMode")]
    public static bool @SpeedFXTestMode { get => SdkMemory.Read<bool >(new IntPtr(0xC402C7)); set { SdkMemory.Write(new IntPtr(0xC402C7),value); } }
    [NativeMember("m_bSpeedFXUserFlag")]
    public static bool @SpeedFXUserFlag { get => SdkMemory.Read<bool >(new IntPtr(0x8D5108)); set { SdkMemory.Write(new IntPtr(0x8D5108),value); } }
    [NativeMember("m_bSpeedFXUserFlagCurrentFrame")]
    public static bool @SpeedFXUserFlagCurrentFrame { get => SdkMemory.Read<bool >(new IntPtr(0x8D5109)); set { SdkMemory.Write(new IntPtr(0x8D5109),value); } }
    [NativeMember("m_fSpeedFXManualSpeedCurrentFrame")]
    public static float @SpeedFXManualSpeedCurrentFrame { get => SdkMemory.Read<float >(new IntPtr(0xC402C8)); set { SdkMemory.Write(new IntPtr(0xC402C8),value); } }
    [NativeMember("m_SpeedFXAlpha")]
    public static int @SpeedFXAlpha { get => SdkMemory.Read<int >(new IntPtr(0x8D5104)); set { SdkMemory.Write(new IntPtr(0x8D5104),value); } }
    [NativeMember("pRasterFrontBuffer")]
    public static RwRaster? @RasterFrontBuffer { get => SdkMemory.Read<IntPtr>(new IntPtr(0xC402D8)) == IntPtr.Zero ? null : new RwRaster(SdkMemory.Read<IntPtr>(new IntPtr(0xC402D8))); set { SdkMemory.Write(new IntPtr(0xC402D8),value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_bGrainEnable")]
    public static bool @GrainEnable { get => SdkMemory.Read<bool >(new IntPtr(0xC402B4)); set { SdkMemory.Write(new IntPtr(0xC402B4),value); } }
    [NativeMember("m_pGrainRaster")]
    public static RwRaster? @GrainRaster { get => SdkMemory.Read<IntPtr>(new IntPtr(0xC402B0)) == IntPtr.Zero ? null : new RwRaster(SdkMemory.Read<IntPtr>(new IntPtr(0xC402B0))); set { SdkMemory.Write(new IntPtr(0xC402B0),value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_grainStrength")]
    public static NativeArray<sbyte> @GrainStrength { get => new NativeArray<sbyte>(new IntPtr(0x8D5094),2); }
    [NativeMember("m_bCCTV")]
    public static bool @CCTVValue { get => SdkMemory.Read<bool >(new IntPtr(0xC402C5)); set { SdkMemory.Write(new IntPtr(0xC402C5),value); } }
    [NativeMember("m_CCTVcol")]
    public static CRGBA @CCTVcol { get => new CRGBA(new IntPtr(0x8D50FC)); set { SdkMemory.Copy(value.Pointer,new IntPtr(0x8D50FC),4); } }
    [NativeMember("m_bRainEnable")]
    public static bool @RainEnable { get => SdkMemory.Read<bool >(new IntPtr(0xC402D1)); set { SdkMemory.Write(new IntPtr(0xC402D1),value); } }
    [NativeMember("m_bColorEnable")]
    public static bool @ColorEnable { get => SdkMemory.Read<bool >(new IntPtr(0x8D518C)); set { SdkMemory.Write(new IntPtr(0x8D518C),value); } }
    [NativeMember("m_bRadiosity")]
    public static bool @RadiosityValue { get => SdkMemory.Read<bool >(new IntPtr(0xC402CC)); set { SdkMemory.Write(new IntPtr(0xC402CC),value); } }
    [NativeMember("m_bRadiosityDebug")]
    public static bool @RadiosityDebug { get => SdkMemory.Read<bool >(new IntPtr(0xC402CD)); set { SdkMemory.Write(new IntPtr(0xC402CD),value); } }
    [NativeMember("m_bRadiosityLinearFilter")]
    public static bool @RadiosityLinearFilter { get => SdkMemory.Read<bool >(new IntPtr(0x8D510A)); set { SdkMemory.Write(new IntPtr(0x8D510A),value); } }
    [NativeMember("m_bRadiosityStripCopyMode")]
    public static bool @RadiosityStripCopyMode { get => SdkMemory.Read<bool >(new IntPtr(0x8D510B)); set { SdkMemory.Write(new IntPtr(0x8D510B),value); } }
    [NativeMember("m_RadiosityFilterUCorrection")]
    public static int @RadiosityFilterUCorrection { get => SdkMemory.Read<int >(new IntPtr(0x8D511C)); set { SdkMemory.Write(new IntPtr(0x8D511C),value); } }
    [NativeMember("m_RadiosityFilterVCorrection")]
    public static int @RadiosityFilterVCorrection { get => SdkMemory.Read<int >(new IntPtr(0x8D5120)); set { SdkMemory.Write(new IntPtr(0x8D5120),value); } }
    [NativeMember("m_RadiosityIntensity")]
    public static int @RadiosityIntensity { get => SdkMemory.Read<int >(new IntPtr(0x8D5118)); set { SdkMemory.Write(new IntPtr(0x8D5118),value); } }
    [NativeMember("m_RadiosityIntensityLimit")]
    public static int @RadiosityIntensityLimit { get => SdkMemory.Read<int >(new IntPtr(0x8D5114)); set { SdkMemory.Write(new IntPtr(0x8D5114),value); } }
    [NativeMember("m_bRadiosityBypassTimeCycleIntensityLimit")]
    public static bool @RadiosityBypassTimeCycleIntensityLimit { get => SdkMemory.Read<bool >(new IntPtr(0xC402CE)); set { SdkMemory.Write(new IntPtr(0xC402CE),value); } }
    [NativeMember("m_RadiosityPixelsX")]
    public static float @RadiosityPixelsX { get => SdkMemory.Read<float >(new IntPtr(0xC40314)); set { SdkMemory.Write(new IntPtr(0xC40314),value); } }
    [NativeMember("m_RadiosityPixelsY")]
    public static float @RadiosityPixelsY { get => SdkMemory.Read<float >(new IntPtr(0xC40318)); set { SdkMemory.Write(new IntPtr(0xC40318),value); } }
    [NativeMember("m_RadiosityFilterPasses")]
    public static uint @RadiosityFilterPasses { get => SdkMemory.Read<uint >(new IntPtr(0x8D5110)); set { SdkMemory.Write(new IntPtr(0x8D5110),value); } }
    [NativeMember("m_RadiosityRenderPasses")]
    public static uint @RadiosityRenderPasses { get => SdkMemory.Read<uint >(new IntPtr(0x8D510C)); set { SdkMemory.Write(new IntPtr(0x8D510C),value); } }
    [NativeMember("m_VisionFXDayNightBalance")]
    public static float @VisionFXDayNightBalance { get => SdkMemory.Read<float >(new IntPtr(0x8D50A4)); set { SdkMemory.Write(new IntPtr(0x8D50A4),value); } }
    [NativeMember("m_bInfraredVision")]
    public static bool @InfraredVisionValue { get => SdkMemory.Read<bool >(new IntPtr(0xC402B9)); set { SdkMemory.Write(new IntPtr(0xC402B9),value); } }
    [NativeMember("m_InfraredVisionGrainStrength")]
    public static int @InfraredVisionGrainStrength { get => SdkMemory.Read<int >(new IntPtr(0x8D50B4)); set { SdkMemory.Write(new IntPtr(0x8D50B4),value); } }
    [NativeMember("m_fInfraredVisionFilterRadius")]
    public static float @InfraredVisionFilterRadius { get => SdkMemory.Read<float >(new IntPtr(0x8D50B8)); set { SdkMemory.Write(new IntPtr(0x8D50B8),value); } }
    [NativeMember("m_InfraredVisionCol")]
    public static CRGBA @InfraredVisionCollision { get => new CRGBA(new IntPtr(0x8D50CC)); set { SdkMemory.Copy(value.Pointer,new IntPtr(0x8D50CC),4); } }
    [NativeMember("m_InfraredVisionMainCol")]
    public static CRGBA @InfraredVisionMainCollision { get => new CRGBA(new IntPtr(0x8D50D0)); set { SdkMemory.Copy(value.Pointer,new IntPtr(0x8D50D0),4); } }
    [NativeMember("m_fInfraredVisionHeatObjectCol")]
    public static RwRGBAReal @InfraredVisionHeatObjectCollision { get => new RwRGBAReal(new IntPtr(0x8D50BC)); set { SdkMemory.Copy(value.Pointer,new IntPtr(0x8D50BC),16); } }
    [NativeMember("m_HeatHazeFXHourOfDayStart")]
    public static int @HeatHazeFXHourOfDayStart { get => SdkMemory.Read<int >(new IntPtr(0x8D50D4)); set { SdkMemory.Write(new IntPtr(0x8D50D4),value); } }
    [NativeMember("m_HeatHazeFXHourOfDayEnd")]
    public static int @HeatHazeFXHourOfDayEnd { get => SdkMemory.Read<int >(new IntPtr(0x8D50D8)); set { SdkMemory.Write(new IntPtr(0x8D50D8),value); } }
    [NativeMember("m_fHeatHazeFXFadeSpeed")]
    public static float @HeatHazeFXFadeSpeed { get => SdkMemory.Read<float >(new IntPtr(0x8D50DC)); set { SdkMemory.Write(new IntPtr(0x8D50DC),value); } }
    [NativeMember("m_fHeatHazeFXInsideBuildingFadeSpeed")]
    public static float @HeatHazeFXInsideBuildingFadeSpeed { get => SdkMemory.Read<float >(new IntPtr(0x8D50DC)); set { SdkMemory.Write(new IntPtr(0x8D50DC),value); } }
    [NativeMember("m_waterEnable")]
    public static bool @WaterEnable { get => SdkMemory.Read<bool >(new IntPtr(0xC402D3)); set { SdkMemory.Write(new IntPtr(0xC402D3),value); } }
    [NativeMember("m_waterStrength")]
    public static float @WaterStrength { get => SdkMemory.Read<float >(new IntPtr(0x8D512C)); set { SdkMemory.Write(new IntPtr(0x8D512C),value); } }
    [NativeMember("m_waterSpeed")]
    public static float @WaterSpeed { get => SdkMemory.Read<float >(new IntPtr(0x8D5138)); set { SdkMemory.Write(new IntPtr(0x8D5138),value); } }
    [NativeMember("m_waterFreq")]
    public static float @WaterFreq { get => SdkMemory.Read<float >(new IntPtr(0x8D513C)); set { SdkMemory.Write(new IntPtr(0x8D513C),value); } }
    [NativeMember("m_waterCol")]
    public static CRGBA @WaterCollision { get => new CRGBA(new IntPtr(0x8D5140)); set { SdkMemory.Copy(value.Pointer,new IntPtr(0x8D5140),4); } }
    public static void @Initialise() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3496 >(3496)(); }
    public static void @Close() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3497 >(3497)(); }
    public static void @DoScreenModeDependentInitializations() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3498 >(3498)(); }
    public static void @SetupBackBufferVertex() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3499 >(3499)(); }
    public static void @Update() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3500 >(3500)(); }
    public static void @DrawQuad(float @xPos,float @yPos,float @xSize,float @ySize,byte @r,byte @g,byte @b,byte @a,RwRaster? @pRaster) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3501 >(3501)(@xPos,@yPos,@xSize,@ySize,@r,@g,@b,@a,@pRaster?.Pointer ?? IntPtr.Zero); }
    public static void @DrawQuadSetDefaultUVs() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3502 >(3502)(); }
    public static void @DrawQuadSetPixelUVs(float @u1,float @v1,float @u2,float @v2,float @u3,float @v3,float @u4,float @v4) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3503 >(3503)(@u1,@v1,@u2,@v2,@u3,@v3,@u4,@v4); }
    public static void @DrawQuadSetUVs(float @u1,float @v1,float @u2,float @v2,float @u3,float @v3,float @u4,float @v4) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3504 >(3504)(@u1,@v1,@u2,@v2,@u3,@v3,@u4,@v4); }
    public static void @FilterFX_RestoreDayNightBalance() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3505 >(3505)(); }
    public static void @FilterFX_StoreAndSetDayNightBalance() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3506 >(3506)(); }
    public static void @ImmediateModeFilterStuffInitialize() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3507 >(3507)(); }
    public static void @ImmediateModeRenderStatesSet() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3508 >(3508)(); }
    public static void @ImmediateModeRenderStatesStore() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3509 >(3509)(); }
    public static void @ImmediateModeRenderStatesReStore() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3510 >(3510)(); }
    public static RwRaster? @RasterCreatePostEffects(RwRect @rect) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3511 >(3511)(@rect.Pointer); return __sdkResult == IntPtr.Zero ? null : new RwRaster(__sdkResult); }
    public static void @ScriptCCTVSwitch(bool @n) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3512 >(3512)((@n ? 1 : 0)); }
    public static void @ScriptDarknessFilterSwitch(bool @n,int @alpha) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3513 >(3513)((@n ? 1 : 0),@alpha); }
    public static void @ScriptHeatHazeFXSwitch(bool @n) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3514 >(3514)((@n ? 1 : 0)); }
    public static void @ScriptInfraredVisionSwitch(bool @n) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3515 >(3515)((@n ? 1 : 0)); }
    public static void @ScriptNightVisionSwitch(bool @n) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3516 >(3516)((@n ? 1 : 0)); }
    public static void @ScriptResetForEffects() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3517 >(3517)(); }
    public static void @UnderWaterRipple(RwRGBA @col,float @xoffset,float @yoffset,int @strength,float @speed,float @freq) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3518 >(3518)(@col.Pointer,@xoffset,@yoffset,@strength,@speed,@freq); }
    public static void @UnderWaterRippleFadeToFX() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3519 >(3519)(); }
    public static void @HeatHazeFXInit() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3520 >(3520)(); }
    public static void @HeatHazeFX(float @fIntensity,bool @bAlphaMaskMode) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3521 >(3521)(@fIntensity,(@bAlphaMaskMode ? 1 : 0)); }
    public static bool @IsVisionFXActive() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3522 >(3522)(); return __sdkResult != 0; }
    public static void @NightVision() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3523 >(3523)(); }
    public static void @NightVisionSetLights() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3524 >(3524)(); }
    public static void @SetFilterMainColour(RwRaster? @pRaster,RwRGBA @colour) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3525 >(3525)(@pRaster?.Pointer ?? IntPtr.Zero,@colour.Pointer); }
    public static void @InfraredVision(RwRGBA @colour,RwRGBA @colourMain) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3526 >(3526)(@colour.Pointer,@colourMain.Pointer); }
    public static void @InfraredVisionSetLightsForDefaultObjects() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3527 >(3527)(); }
    public static void @InfraredVisionSetLightsForHeatObjects() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3528 >(3528)(); }
    public static void @InfraredVisionStoreAndSetLightsForHeatObjects(CPed? @ped) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3529 >(3529)(@ped?.Pointer ?? IntPtr.Zero); }
    public static void @InfraredVisionRestoreLightsForHeatObjects() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3530 >(3530)(); }
    public static void @Fog() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3531 >(3531)(); }
    public static void @CCTV() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3532 >(3532)(); }
    public static void @Grain(int @strengthMask,bool @update) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3533 >(3533)(@strengthMask,(@update ? 1 : 0)); }
    public static void @SpeedFX(float @speed) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3534 >(3534)(@speed); }
    public static void @DarknessFilter(int @alpha) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3535 >(3535)(@alpha); }
    public static void @ColourFilter(RwRGBA @col1,RwRGBA @col2) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3536 >(3536)(@col1.Pointer,@col2.Pointer); }
    public static void @Radiosity(int @intensityLimit,int @filterPasses,int @renderPasses,int @intensity) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3537 >(3537)(@intensityLimit,@filterPasses,@renderPasses,@intensity); }
    public static void @SetSpeedFXManualSpeedCurrentFrame(float @value) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3538 >(3538)(@value); }
    public static void @Render() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3539 >(3539)(); }
}
