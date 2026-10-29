// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CColourSet : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=172;
    public CColourSet(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_fAmbientRed")]
    public float @AmbientRed { get => SdkMemory.Read<float >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("m_fAmbientGreen")]
    public float @AmbientGreen { get => SdkMemory.Read<float >(Pointer+4); set { SdkMemory.Write(Pointer+4,value); } }
    [NativeMember("m_fAmbientBlue")]
    public float @AmbientBlue { get => SdkMemory.Read<float >(Pointer+8); set { SdkMemory.Write(Pointer+8,value); } }
    [NativeMember("m_fAmbientRed_Obj")]
    public float @AmbientRedObject { get => SdkMemory.Read<float >(Pointer+12); set { SdkMemory.Write(Pointer+12,value); } }
    [NativeMember("m_fAmbientGreen_Obj")]
    public float @AmbientGreenObject { get => SdkMemory.Read<float >(Pointer+16); set { SdkMemory.Write(Pointer+16,value); } }
    [NativeMember("m_fAmbientBlue_Obj")]
    public float @AmbientBlueObject { get => SdkMemory.Read<float >(Pointer+20); set { SdkMemory.Write(Pointer+20,value); } }
    [NativeMember("m_fDirectionalRed")]
    public float @DirectionalRed { get => SdkMemory.Read<float >(Pointer+24); set { SdkMemory.Write(Pointer+24,value); } }
    [NativeMember("m_fDirectionalGreen")]
    public float @DirectionalGreen { get => SdkMemory.Read<float >(Pointer+28); set { SdkMemory.Write(Pointer+28,value); } }
    [NativeMember("m_fDirectionalBlue")]
    public float @DirectionalBlue { get => SdkMemory.Read<float >(Pointer+32); set { SdkMemory.Write(Pointer+32,value); } }
    [NativeMember("m_nSkyTopRed")]
    public ushort @SkyTopRed { get => SdkMemory.Read<ushort >(Pointer+36); set { SdkMemory.Write(Pointer+36,value); } }
    [NativeMember("m_nSkyTopGreen")]
    public ushort @SkyTopGreen { get => SdkMemory.Read<ushort >(Pointer+38); set { SdkMemory.Write(Pointer+38,value); } }
    [NativeMember("m_nSkyTopBlue")]
    public ushort @SkyTopBlue { get => SdkMemory.Read<ushort >(Pointer+40); set { SdkMemory.Write(Pointer+40,value); } }
    [NativeMember("m_nSkyBottomRed")]
    public ushort @SkyBottomRed { get => SdkMemory.Read<ushort >(Pointer+42); set { SdkMemory.Write(Pointer+42,value); } }
    [NativeMember("m_nSkyBottomGreen")]
    public ushort @SkyBottomGreen { get => SdkMemory.Read<ushort >(Pointer+44); set { SdkMemory.Write(Pointer+44,value); } }
    [NativeMember("m_nSkyBottomBlue")]
    public ushort @SkyBottomBlue { get => SdkMemory.Read<ushort >(Pointer+46); set { SdkMemory.Write(Pointer+46,value); } }
    [NativeMember("m_nSunCoreRed")]
    public ushort @SunCoreRed { get => SdkMemory.Read<ushort >(Pointer+48); set { SdkMemory.Write(Pointer+48,value); } }
    [NativeMember("m_nSunCoreGreen")]
    public ushort @SunCoreGreen { get => SdkMemory.Read<ushort >(Pointer+50); set { SdkMemory.Write(Pointer+50,value); } }
    [NativeMember("m_nSunCoreBlue")]
    public ushort @SunCoreBlue { get => SdkMemory.Read<ushort >(Pointer+52); set { SdkMemory.Write(Pointer+52,value); } }
    [NativeMember("m_nSunCoronaRed")]
    public ushort @SunCoronaRed { get => SdkMemory.Read<ushort >(Pointer+54); set { SdkMemory.Write(Pointer+54,value); } }
    [NativeMember("m_nSunCoronaGreen")]
    public ushort @SunCoronaGreen { get => SdkMemory.Read<ushort >(Pointer+56); set { SdkMemory.Write(Pointer+56,value); } }
    [NativeMember("m_nSunCoronaBlue")]
    public ushort @SunCoronaBlue { get => SdkMemory.Read<ushort >(Pointer+58); set { SdkMemory.Write(Pointer+58,value); } }
    [NativeMember("m_fSunSize")]
    public float @SunSize { get => SdkMemory.Read<float >(Pointer+60); set { SdkMemory.Write(Pointer+60,value); } }
    [NativeMember("m_fSpriteSize")]
    public float @SpriteSize { get => SdkMemory.Read<float >(Pointer+64); set { SdkMemory.Write(Pointer+64,value); } }
    [NativeMember("m_fSpriteBrightness")]
    public float @SpriteBrightness { get => SdkMemory.Read<float >(Pointer+68); set { SdkMemory.Write(Pointer+68,value); } }
    [NativeMember("m_nShadowStrength")]
    public ushort @ShadowStrength { get => SdkMemory.Read<ushort >(Pointer+72); set { SdkMemory.Write(Pointer+72,value); } }
    [NativeMember("m_nLightShadowStrength")]
    public ushort @LightShadowStrength { get => SdkMemory.Read<ushort >(Pointer+74); set { SdkMemory.Write(Pointer+74,value); } }
    [NativeMember("m_nPoleShadowStrength")]
    public ushort @PoleShadowStrength { get => SdkMemory.Read<ushort >(Pointer+76); set { SdkMemory.Write(Pointer+76,value); } }
    [NativeMember("m_fFarClip")]
    public float @FarClip { get => SdkMemory.Read<float >(Pointer+80); set { SdkMemory.Write(Pointer+80,value); } }
    [NativeMember("m_fFogStart")]
    public float @FogStart { get => SdkMemory.Read<float >(Pointer+84); set { SdkMemory.Write(Pointer+84,value); } }
    [NativeMember("m_fLightsOnGroundBrightness")]
    public float @LightsOnGroundBrightness { get => SdkMemory.Read<float >(Pointer+88); set { SdkMemory.Write(Pointer+88,value); } }
    [NativeMember("m_nLowCloudsRed")]
    public ushort @LowCloudsRed { get => SdkMemory.Read<ushort >(Pointer+92); set { SdkMemory.Write(Pointer+92,value); } }
    [NativeMember("m_nLowCloudsGreen")]
    public ushort @LowCloudsGreen { get => SdkMemory.Read<ushort >(Pointer+94); set { SdkMemory.Write(Pointer+94,value); } }
    [NativeMember("m_nLowCloudsBlue")]
    public ushort @LowCloudsBlue { get => SdkMemory.Read<ushort >(Pointer+96); set { SdkMemory.Write(Pointer+96,value); } }
    [NativeMember("m_nFluffyCloudsBottomRed")]
    public ushort @FluffyCloudsBottomRed { get => SdkMemory.Read<ushort >(Pointer+98); set { SdkMemory.Write(Pointer+98,value); } }
    [NativeMember("m_nFluffyCloudsBottomGreen")]
    public ushort @FluffyCloudsBottomGreen { get => SdkMemory.Read<ushort >(Pointer+100); set { SdkMemory.Write(Pointer+100,value); } }
    [NativeMember("m_nFluffyCloudsBottomBlue")]
    public ushort @FluffyCloudsBottomBlue { get => SdkMemory.Read<ushort >(Pointer+102); set { SdkMemory.Write(Pointer+102,value); } }
    [NativeMember("m_fWaterRed")]
    public float @WaterRed { get => SdkMemory.Read<float >(Pointer+104); set { SdkMemory.Write(Pointer+104,value); } }
    [NativeMember("m_fWaterGreen")]
    public float @WaterGreen { get => SdkMemory.Read<float >(Pointer+108); set { SdkMemory.Write(Pointer+108,value); } }
    [NativeMember("m_fWaterBlue")]
    public float @WaterBlue { get => SdkMemory.Read<float >(Pointer+112); set { SdkMemory.Write(Pointer+112,value); } }
    [NativeMember("m_fWaterAlpha")]
    public float @WaterAlpha { get => SdkMemory.Read<float >(Pointer+116); set { SdkMemory.Write(Pointer+116,value); } }
    [NativeMember("m_fPostFx1Red")]
    public float @PostFx1Red { get => SdkMemory.Read<float >(Pointer+120); set { SdkMemory.Write(Pointer+120,value); } }
    [NativeMember("m_fPostFx1Green")]
    public float @PostFx1Green { get => SdkMemory.Read<float >(Pointer+124); set { SdkMemory.Write(Pointer+124,value); } }
    [NativeMember("m_fPostFx1Blue")]
    public float @PostFx1Blue { get => SdkMemory.Read<float >(Pointer+128); set { SdkMemory.Write(Pointer+128,value); } }
    [NativeMember("m_fPostFx1Alpha")]
    public float @PostFx1Alpha { get => SdkMemory.Read<float >(Pointer+132); set { SdkMemory.Write(Pointer+132,value); } }
    [NativeMember("m_fPostFx2Red")]
    public float @PostFx2Red { get => SdkMemory.Read<float >(Pointer+136); set { SdkMemory.Write(Pointer+136,value); } }
    [NativeMember("m_fPostFx2Green")]
    public float @PostFx2Green { get => SdkMemory.Read<float >(Pointer+140); set { SdkMemory.Write(Pointer+140,value); } }
    [NativeMember("m_fPostFx2Blue")]
    public float @PostFx2Blue { get => SdkMemory.Read<float >(Pointer+144); set { SdkMemory.Write(Pointer+144,value); } }
    [NativeMember("m_fPostFx2Alpha")]
    public float @PostFx2Alpha { get => SdkMemory.Read<float >(Pointer+148); set { SdkMemory.Write(Pointer+148,value); } }
    [NativeMember("m_fCloudAlpha")]
    public float @CloudAlpha { get => SdkMemory.Read<float >(Pointer+152); set { SdkMemory.Write(Pointer+152,value); } }
    [NativeMember("m_nHighLightMinIntensity")]
    public uint @HighLightMinIntensity { get => SdkMemory.Read<uint >(Pointer+156); set { SdkMemory.Write(Pointer+156,value); } }
    [NativeMember("m_nWaterFogAlpha")]
    public ushort @WaterFogAlpha { get => SdkMemory.Read<ushort >(Pointer+160); set { SdkMemory.Write(Pointer+160,value); } }
    [NativeMember("m_fIllumination")]
    public float @Illumination { get => SdkMemory.Read<float >(Pointer+164); set { SdkMemory.Write(Pointer+164,value); } }
    [NativeMember("m_fLodDistMult")]
    public float @LodDistanceMult { get => SdkMemory.Read<float >(Pointer+168); set { SdkMemory.Write(Pointer+168,value); } }
    public void @InitializeAt(int @weatherId,int @timeId) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2227 >(2227)(Pointer,@weatherId,@timeId); }
    public void @Interpolate(CColourSet? @a,CColourSet? @b,float @factor_a,float @factor_b,bool @bIgnoreSky) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2228 >(2228)(Pointer,@a?.Pointer ?? IntPtr.Zero,@b?.Pointer ?? IntPtr.Zero,@factor_a,@factor_b,(@bIgnoreSky ? 1 : 0)); }
}
