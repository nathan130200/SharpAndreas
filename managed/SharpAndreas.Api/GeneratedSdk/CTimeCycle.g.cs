// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CTimeCycle : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=1;
    public CTimeCycle(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_BrightnessAddedToAmbientBlue")]
    public static float @BrightnessAddedToAmbientBlue { get => SdkMemory.Read<float >(new IntPtr(0xB79E30)); set { SdkMemory.Write(new IntPtr(0xB79E30),value); } }
    [NativeMember("m_BrightnessAddedToAmbientGreen")]
    public static float @BrightnessAddedToAmbientGreen { get => SdkMemory.Read<float >(new IntPtr(0xB79E34)); set { SdkMemory.Write(new IntPtr(0xB79E34),value); } }
    [NativeMember("m_BrightnessAddedToAmbientRed")]
    public static float @BrightnessAddedToAmbientRed { get => SdkMemory.Read<float >(new IntPtr(0xB79E38)); set { SdkMemory.Write(new IntPtr(0xB79E38),value); } }
    [NativeMember("m_ExtraColourInter")]
    public static int @ExtraColorInter { get => SdkMemory.Read<int >(new IntPtr(0xB79E3C)); set { SdkMemory.Write(new IntPtr(0xB79E3C),value); } }
    [NativeMember("m_ExtraColourWeatherType")]
    public static int @ExtraColorWeatherType { get => SdkMemory.Read<int >(new IntPtr(0xB79E40)); set { SdkMemory.Write(new IntPtr(0xB79E40),value); } }
    [NativeMember("m_ExtraColour")]
    public static int @ExtraColor { get => SdkMemory.Read<int >(new IntPtr(0xB79E44)); set { SdkMemory.Write(new IntPtr(0xB79E44),value); } }
    [NativeMember("m_FogReduction")]
    public static int @FogReduction { get => SdkMemory.Read<int >(new IntPtr(0xB79E48)); set { SdkMemory.Write(new IntPtr(0xB79E48),value); } }
    [NativeMember("m_fShadowDisplacementY")]
    public static NativePointer<float> @ShadowDisplacementY { get => new NativePointer<float>(new IntPtr(0xB79E50)); }
    [NativeMember("m_fShadowDisplacementX")]
    public static NativePointer<float> @ShadowDisplacementX { get => new NativePointer<float>(new IntPtr(0xB79E90)); }
    [NativeMember("m_fShadowSideY")]
    public static NativePointer<float> @ShadowSideY { get => new NativePointer<float>(new IntPtr(0xB79ED0)); }
    [NativeMember("m_fShadowSideX")]
    public static NativePointer<float> @ShadowSideX { get => new NativePointer<float>(new IntPtr(0xB79F10)); }
    [NativeMember("m_fShadowFrontY")]
    public static NativePointer<float> @ShadowFrontY { get => new NativePointer<float>(new IntPtr(0xB79F50)); }
    [NativeMember("m_fShadowFrontX")]
    public static NativePointer<float> @ShadowFrontX { get => new NativePointer<float>(new IntPtr(0xB79F90)); }
    [NativeMember("m_CurrentStoredValue")]
    public static int @CurrentStoredValue { get => SdkMemory.Read<int >(new IntPtr(0xB79FD0)); set { SdkMemory.Write(new IntPtr(0xB79FD0),value); } }
    [NativeMember("m_nDirectionalMult")]
    public static NativePointer<byte> @DirectionalMult { get => new NativePointer<byte>(new IntPtr(0xB79FD8)); }
    [NativeMember("m_nWaterFogAlpha")]
    public static NativePointer<byte> @WaterFogAlpha { get => new NativePointer<byte>(new IntPtr(0xB7A090)); }
    [NativeMember("m_nHighLightMinIntensity")]
    public static NativePointer<byte> @HighLightMinIntensity { get => new NativePointer<byte>(new IntPtr(0xB7A148)); }
    [NativeMember("m_fCloudAlpha")]
    public static NativePointer<byte> @CloudAlpha { get => new NativePointer<byte>(new IntPtr(0xB7A200)); }
    [NativeMember("m_fPostFx2Alpha")]
    public static NativePointer<byte> @PostFx2Alpha { get => new NativePointer<byte>(new IntPtr(0xB7A2B8)); }
    [NativeMember("m_fPostFx2Blue")]
    public static NativePointer<byte> @PostFx2Blue { get => new NativePointer<byte>(new IntPtr(0xB7A370)); }
    [NativeMember("m_fPostFx2Green")]
    public static NativePointer<byte> @PostFx2Green { get => new NativePointer<byte>(new IntPtr(0xB7A428)); }
    [NativeMember("m_fPostFx2Red")]
    public static NativePointer<byte> @PostFx2Red { get => new NativePointer<byte>(new IntPtr(0xB7A4E0)); }
    [NativeMember("m_fPostFx1Alpha")]
    public static NativePointer<byte> @PostFx1Alpha { get => new NativePointer<byte>(new IntPtr(0xB7A598)); }
    [NativeMember("m_fPostFx1Blue")]
    public static NativePointer<byte> @PostFx1Blue { get => new NativePointer<byte>(new IntPtr(0xB7A650)); }
    [NativeMember("m_fPostFx1Green")]
    public static NativePointer<byte> @PostFx1Green { get => new NativePointer<byte>(new IntPtr(0xB7A708)); }
    [NativeMember("m_fPostFx1Red")]
    public static NativePointer<byte> @PostFx1Red { get => new NativePointer<byte>(new IntPtr(0xB7A7C0)); }
    [NativeMember("m_fWaterAlpha")]
    public static NativePointer<byte> @WaterAlpha { get => new NativePointer<byte>(new IntPtr(0xB7A878)); }
    [NativeMember("m_fWaterBlue")]
    public static NativePointer<byte> @WaterBlue { get => new NativePointer<byte>(new IntPtr(0xB7A930)); }
    [NativeMember("m_fWaterGreen")]
    public static NativePointer<byte> @WaterGreen { get => new NativePointer<byte>(new IntPtr(0xB7A9E8)); }
    [NativeMember("m_fWaterRed")]
    public static NativePointer<byte> @WaterRed { get => new NativePointer<byte>(new IntPtr(0xB7AAA0)); }
    [NativeMember("m_nFluffyCloudsBottomBlue")]
    public static NativePointer<byte> @FluffyCloudsBottomBlue { get => new NativePointer<byte>(new IntPtr(0xB7AB58)); }
    [NativeMember("m_nFluffyCloudsBottomGreen")]
    public static NativePointer<byte> @FluffyCloudsBottomGreen { get => new NativePointer<byte>(new IntPtr(0xB7AC10)); }
    [NativeMember("m_nFluffyCloudsBottomRed")]
    public static NativePointer<byte> @FluffyCloudsBottomRed { get => new NativePointer<byte>(new IntPtr(0xB7ACC8)); }
    [NativeMember("m_nLowCloudsBlue")]
    public static NativePointer<byte> @LowCloudsBlue { get => new NativePointer<byte>(new IntPtr(0xB7AD80)); }
    [NativeMember("m_nLowCloudsGreen")]
    public static NativePointer<byte> @LowCloudsGreen { get => new NativePointer<byte>(new IntPtr(0xB7AE38)); }
    [NativeMember("m_nLowCloudsRed")]
    public static NativePointer<byte> @LowCloudsRed { get => new NativePointer<byte>(new IntPtr(0xB7AEF0)); }
    [NativeMember("m_fLightsOnGroundBrightness")]
    public static NativePointer<byte> @LightsOnGroundBrightness { get => new NativePointer<byte>(new IntPtr(0xB7AFA8)); }
    [NativeMember("m_fFogStart")]
    public static NativePointer<short> @FogStart { get => new NativePointer<short>(new IntPtr(0xB7B060)); }
    [NativeMember("m_fFarClip")]
    public static NativePointer<short> @FarClip { get => new NativePointer<short>(new IntPtr(0xB7B1D0)); }
    [NativeMember("m_nPoleShadowStrength")]
    public static NativePointer<byte> @PoleShadowStrength { get => new NativePointer<byte>(new IntPtr(0xB7B340)); }
    [NativeMember("m_nLightShadowStrength")]
    public static NativePointer<byte> @LightShadowStrength { get => new NativePointer<byte>(new IntPtr(0xB7B3F8)); }
    [NativeMember("m_nShadowStrength")]
    public static NativePointer<byte> @ShadowStrength { get => new NativePointer<byte>(new IntPtr(0xB7B4B0)); }
    [NativeMember("m_fSpriteBrightness")]
    public static NativePointer<sbyte> @SpriteBrightness { get => new NativePointer<sbyte>(new IntPtr(0xB7B568)); }
    [NativeMember("m_fSpriteSize")]
    public static NativePointer<sbyte> @SpriteSize { get => new NativePointer<sbyte>(new IntPtr(0xB7B620)); }
    [NativeMember("m_fSunSize")]
    public static NativePointer<sbyte> @SunSize { get => new NativePointer<sbyte>(new IntPtr(0xB7B6D8)); }
    [NativeMember("m_nSunCoronaBlue")]
    public static NativePointer<byte> @SunCoronaBlue { get => new NativePointer<byte>(new IntPtr(0xB7B790)); }
    [NativeMember("m_nSunCoronaGreen")]
    public static NativePointer<byte> @SunCoronaGreen { get => new NativePointer<byte>(new IntPtr(0xB7B848)); }
    [NativeMember("m_nSunCoronaRed")]
    public static NativePointer<byte> @SunCoronaRed { get => new NativePointer<byte>(new IntPtr(0xB7B900)); }
    [NativeMember("m_nSunCoreBlue")]
    public static NativePointer<byte> @SunCoreBlue { get => new NativePointer<byte>(new IntPtr(0xB7B9B8)); }
    [NativeMember("m_nSunCoreGreen")]
    public static NativePointer<byte> @SunCoreGreen { get => new NativePointer<byte>(new IntPtr(0xB7BA70)); }
    [NativeMember("m_nSunCoreRed")]
    public static NativePointer<byte> @SunCoreRed { get => new NativePointer<byte>(new IntPtr(0xB7BB28)); }
    [NativeMember("m_nSkyBottomBlue")]
    public static NativePointer<byte> @SkyBottomBlue { get => new NativePointer<byte>(new IntPtr(0xB7BBE0)); }
    [NativeMember("m_nSkyBottomGreen")]
    public static NativePointer<byte> @SkyBottomGreen { get => new NativePointer<byte>(new IntPtr(0xB7BC98)); }
    [NativeMember("m_nSkyBottomRed")]
    public static NativePointer<byte> @SkyBottomRed { get => new NativePointer<byte>(new IntPtr(0xB7BD50)); }
    [NativeMember("m_nSkyTopBlue")]
    public static NativePointer<byte> @SkyTopBlue { get => new NativePointer<byte>(new IntPtr(0xB7BE08)); }
    [NativeMember("m_nSkyTopGreen")]
    public static NativePointer<byte> @SkyTopGreen { get => new NativePointer<byte>(new IntPtr(0xB7BEC0)); }
    [NativeMember("m_nSkyTopRed")]
    public static NativePointer<byte> @SkyTopRed { get => new NativePointer<byte>(new IntPtr(0xB7BF78)); }
    [NativeMember("m_nAmbientBlue_Obj")]
    public static NativePointer<byte> @AmbientBlueObject { get => new NativePointer<byte>(new IntPtr(0xB7C030)); }
    [NativeMember("m_nAmbientGreen_Obj")]
    public static NativePointer<byte> @AmbientGreenObject { get => new NativePointer<byte>(new IntPtr(0xB7C0E8)); }
    [NativeMember("m_nAmbientRed_Obj")]
    public static NativePointer<byte> @AmbientRedObject { get => new NativePointer<byte>(new IntPtr(0xB7C1A0)); }
    [NativeMember("m_nAmbientBlue")]
    public static NativePointer<byte> @AmbientBlue { get => new NativePointer<byte>(new IntPtr(0xB7C258)); }
    [NativeMember("m_nAmbientGreen")]
    public static NativePointer<byte> @AmbientGreen { get => new NativePointer<byte>(new IntPtr(0xB7C310)); }
    [NativeMember("m_nAmbientRed")]
    public static NativePointer<byte> @AmbientRed { get => new NativePointer<byte>(new IntPtr(0xB7C3C8)); }
    [NativeMember("m_NumBoxes")]
    public static uint @CountBoxes { get => SdkMemory.Read<uint >(new IntPtr(0xB7C480)); set { SdkMemory.Write(new IntPtr(0xB7C480),value); } }
    [NativeMember("m_bExtraColourOn")]
    public static uint @ExtraColorOn { get => SdkMemory.Read<uint >(new IntPtr(0xB7C484)); set { SdkMemory.Write(new IntPtr(0xB7C484),value); } }
    [NativeMember("m_CurrentColours")]
    public static CColourSet @CurrentColours { get => new CColourSet(new IntPtr(0xB7C4A0)); set { SdkMemory.Copy(value.Pointer,new IntPtr(0xB7C4A0),172); } }
    [NativeMember("m_aBoxes")]
    public static CTimeCycleBox? @Boxes { get => new IntPtr(0xB7C550) == IntPtr.Zero ? null : new CTimeCycleBox(new IntPtr(0xB7C550)); }
    [NativeMember("m_VectorToSun")]
    public static CVector? @VectorToSun { get => new IntPtr(0xB7CA50) == IntPtr.Zero ? null : new CVector(new IntPtr(0xB7CA50)); }
    [NativeMember("m_BelowHorizonGrey")]
    public static RwRGBA @BelowHorizonGrey { get => new RwRGBA(new IntPtr(0xB7CB10)); set { SdkMemory.Copy(value.Pointer,new IntPtr(0xB7CB10),4); } }
    [NativeMember("m_vecDirnLightToSun")]
    public static RwV3d @DirnLightToSun { get => new RwV3d(new IntPtr(0xB7CB14)); set { SdkMemory.Copy(value.Pointer,new IntPtr(0xB7CB14),12); } }
    public static void @AddOne(CBox @box,short @farclip,int @extracolor,float @strength,float @falloff,float @lodDistMult) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4183 >(4183)(@box.Pointer,@farclip,@extracolor,@strength,@falloff,@lodDistMult); }
    public static void @CalcColoursForPoint(CVector @point,CColourSet? @pCurrentColourSet) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4184 >(4184)(@point.Pointer,@pCurrentColourSet?.Pointer ?? IntPtr.Zero); }
    public static void @FindFarClipForCoors(CVector @cam_pos) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4185 >(4185)(@cam_pos.Pointer); }
    public static void @FindTimeCycleBox(CVector @pos,NativePointer<IntPtr> @outbox,NativePointer<float> @interpolation,bool @bCheckLod,bool @bCheckFar,CTimeCycleBox? @exclude) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4186 >(4186)(@pos.Pointer,@outbox.Pointer,@interpolation.Pointer,(@bCheckLod ? 1 : 0),(@bCheckFar ? 1 : 0),@exclude?.Pointer ?? IntPtr.Zero); }
    public static float @GetAmbientBlue() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4187 >(4187)(); return __sdkResult; }
    public static float @GetAmbientBlue_BeforeBrightness() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4188 >(4188)(); return __sdkResult; }
    public static float @GetAmbientBlue_Obj() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4189 >(4189)(); return __sdkResult; }
    public static float @GetAmbientGreen() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4190 >(4190)(); return __sdkResult; }
    public static float @GetAmbientGreen_BeforeBrightness() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4191 >(4191)(); return __sdkResult; }
    public static float @GetAmbientGreen_Obj() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4192 >(4192)(); return __sdkResult; }
    public static float @GetAmbientRed() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4193 >(4193)(); return __sdkResult; }
    public static float @GetAmbientRed_BeforeBrightness() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4194 >(4194)(); return __sdkResult; }
    public static float @GetAmbientRed_Obj() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4195 >(4195)(); return __sdkResult; }
    public static void @InitForRestart() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4196 >(4196)(); }
    public static void @Initialise() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4197 >(4197)(); }
    public static void @SetConstantParametersForPostFX() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4198 >(4198)(); }
    public static void @Shutdown() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4199 >(4199)(); }
    public static void @StartExtraColour(int @colour,bool @bNoExtraColorInterior) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4200 >(4200)(@colour,(@bNoExtraColorInterior ? 1 : 0)); }
    public static void @StopExtraColour(bool @bNoExtraColorInterior) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4201 >(4201)((@bNoExtraColorInterior ? 1 : 0)); }
    public static void @Update() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4202 >(4202)(); }
}
