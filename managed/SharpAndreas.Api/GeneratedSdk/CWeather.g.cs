// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CWeather : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=1;
    public CWeather(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("TrafficLightsBrightness")]
    public static float @TrafficLightsBrightness { get => SdkMemory.Read<float >(new IntPtr(0xC812A8)); set { SdkMemory.Write(new IntPtr(0xC812A8),value); } }
    [NativeMember("bScriptsForceRain")]
    public static bool @ScriptsForceRain { get => SdkMemory.Read<bool >(new IntPtr(0xC812AC)); set { SdkMemory.Write(new IntPtr(0xC812AC),value); } }
    [NativeMember("Earthquake")]
    public static float @Earthquake { get => SdkMemory.Read<float >(new IntPtr(0xC81340)); set { SdkMemory.Write(new IntPtr(0xC81340),value); } }
    [NativeMember("CurrentRainParticleStrength")]
    public static uint @CurrentRainParticleStrength { get => SdkMemory.Read<uint >(new IntPtr(0xC812B0)); set { SdkMemory.Write(new IntPtr(0xC812B0),value); } }
    [NativeMember("LightningStartY")]
    public static uint @LightningStartY { get => SdkMemory.Read<uint >(new IntPtr(0xC812B4)); set { SdkMemory.Write(new IntPtr(0xC812B4),value); } }
    [NativeMember("LightningStartX")]
    public static uint @LightningStartX { get => SdkMemory.Read<uint >(new IntPtr(0xC812B8)); set { SdkMemory.Write(new IntPtr(0xC812B8),value); } }
    [NativeMember("LightningFlashLastChange")]
    public static int @LightningFlashLastChange { get => SdkMemory.Read<int >(new IntPtr(0xC812BC)); set { SdkMemory.Write(new IntPtr(0xC812BC),value); } }
    [NativeMember("WhenToPlayLightningSound")]
    public static int @WhenToPlayLightningSound { get => SdkMemory.Read<int >(new IntPtr(0xC812C0)); set { SdkMemory.Write(new IntPtr(0xC812C0),value); } }
    [NativeMember("LightningDuration")]
    public static uint @LightningDuration { get => SdkMemory.Read<uint >(new IntPtr(0xC812C4)); set { SdkMemory.Write(new IntPtr(0xC812C4),value); } }
    [NativeMember("LightningStart")]
    public static uint @LightningStart { get => SdkMemory.Read<uint >(new IntPtr(0xC812C8)); set { SdkMemory.Write(new IntPtr(0xC812C8),value); } }
    [NativeMember("LightningFlash")]
    public static bool @LightningFlash { get => SdkMemory.Read<bool >(new IntPtr(0xC812CC)); set { SdkMemory.Write(new IntPtr(0xC812CC),value); } }
    [NativeMember("LightningBurst")]
    public static bool @LightningBurst { get => SdkMemory.Read<bool >(new IntPtr(0xC812CD)); set { SdkMemory.Write(new IntPtr(0xC812CD),value); } }
    [NativeMember("HeadLightsSpectrum")]
    public static float @HeadLightsSpectrum { get => SdkMemory.Read<float >(new IntPtr(0xC812D0)); set { SdkMemory.Write(new IntPtr(0xC812D0),value); } }
    [NativeMember("WaterFogFXControl")]
    public static float @WaterFogFXControl { get => SdkMemory.Read<float >(new IntPtr(0xC81338)); set { SdkMemory.Write(new IntPtr(0xC81338),value); } }
    [NativeMember("HeatHazeFXControl")]
    public static float @HeatHazeFXControl { get => SdkMemory.Read<float >(new IntPtr(0xC812D8)); set { SdkMemory.Write(new IntPtr(0xC812D8),value); } }
    [NativeMember("HeatHaze")]
    public static float @HeatHaze { get => SdkMemory.Read<float >(new IntPtr(0xC812DC)); set { SdkMemory.Write(new IntPtr(0xC812DC),value); } }
    [NativeMember("SunGlare")]
    public static float @SunGlare { get => SdkMemory.Read<float >(new IntPtr(0xC812E0)); set { SdkMemory.Write(new IntPtr(0xC812E0),value); } }
    [NativeMember("Rainbow")]
    public static float @Rainbow { get => SdkMemory.Read<float >(new IntPtr(0xC812E4)); set { SdkMemory.Write(new IntPtr(0xC812E4),value); } }
    [NativeMember("Wavyness")]
    public static float @Wavyness { get => SdkMemory.Read<float >(new IntPtr(0xC812E8)); set { SdkMemory.Write(new IntPtr(0xC812E8),value); } }
    [NativeMember("WindClipped")]
    public static float @WindClipped { get => SdkMemory.Read<float >(new IntPtr(0xC812EC)); set { SdkMemory.Write(new IntPtr(0xC812EC),value); } }
    [NativeMember("WindDir")]
    public static CVector @WindDirection { get => new CVector(new IntPtr(0xC813E0)); set { SdkMemory.Copy(value.Pointer,new IntPtr(0xC813E0),12); } }
    [NativeMember("Wind")]
    public static float @Wind { get => SdkMemory.Read<float >(new IntPtr(0xC812F0)); set { SdkMemory.Write(new IntPtr(0xC812F0),value); } }
    [NativeMember("Sandstorm")]
    public static float @Sandstorm { get => SdkMemory.Read<float >(new IntPtr(0xC812F4)); set { SdkMemory.Write(new IntPtr(0xC812F4),value); } }
    [NativeMember("Rain")]
    public static float @Rain { get => SdkMemory.Read<float >(new IntPtr(0xC81324)); set { SdkMemory.Write(new IntPtr(0xC81324),value); } }
    [NativeMember("InTunnelness")]
    public static float @InTunnelness { get => SdkMemory.Read<float >(new IntPtr(0xC81334)); set { SdkMemory.Write(new IntPtr(0xC81334),value); } }
    [NativeMember("WaterDepth")]
    public static float @WaterDepth { get => SdkMemory.Read<float >(new IntPtr(0xC81330)); set { SdkMemory.Write(new IntPtr(0xC81330),value); } }
    [NativeMember("UnderWaterness")]
    public static float @UnderWaterness { get => SdkMemory.Read<float >(new IntPtr(0xC8132C)); set { SdkMemory.Write(new IntPtr(0xC8132C),value); } }
    [NativeMember("ExtraSunnyness")]
    public static float @ExtraSunnyness { get => SdkMemory.Read<float >(new IntPtr(0xC812F8)); set { SdkMemory.Write(new IntPtr(0xC812F8),value); } }
    [NativeMember("Foggyness_SF")]
    public static float @FoggynessSF { get => SdkMemory.Read<float >(new IntPtr(0xC812FC)); set { SdkMemory.Write(new IntPtr(0xC812FC),value); } }
    [NativeMember("Foggyness")]
    public static float @Foggyness { get => SdkMemory.Read<float >(new IntPtr(0xC81300)); set { SdkMemory.Write(new IntPtr(0xC81300),value); } }
    [NativeMember("CloudCoverage")]
    public static float @CloudCoverage { get => SdkMemory.Read<float >(new IntPtr(0xC81304)); set { SdkMemory.Write(new IntPtr(0xC81304),value); } }
    [NativeMember("WetRoads")]
    public static float @WetRoads { get => SdkMemory.Read<float >(new IntPtr(0xC81308)); set { SdkMemory.Write(new IntPtr(0xC81308),value); } }
    [NativeMember("InterpolationValue")]
    public static float @InterpolationValue { get => SdkMemory.Read<float >(new IntPtr(0xC8130C)); set { SdkMemory.Write(new IntPtr(0xC8130C),value); } }
    [NativeMember("WeatherTypeInList")]
    public static uint @WeatherTypeInList { get => SdkMemory.Read<uint >(new IntPtr(0xC81310)); set { SdkMemory.Write(new IntPtr(0xC81310),value); } }
    [NativeMember("WeatherRegion")]
    public static short @WeatherRegion { get => SdkMemory.Read<short >(new IntPtr(0xC81314)); set { SdkMemory.Write(new IntPtr(0xC81314),value); } }
    [NativeMember("ForcedWeatherType")]
    public static short @ForcedWeatherType { get => SdkMemory.Read<short >(new IntPtr(0xC81318)); set { SdkMemory.Write(new IntPtr(0xC81318),value); } }
    [NativeMember("NewWeatherType")]
    public static short @NewWeatherType { get => SdkMemory.Read<short >(new IntPtr(0xC8131C)); set { SdkMemory.Write(new IntPtr(0xC8131C),value); } }
    [NativeMember("OldWeatherType")]
    public static short @OldWeatherType { get => SdkMemory.Read<short >(new IntPtr(0xC81320)); set { SdkMemory.Write(new IntPtr(0xC81320),value); } }
    [NativeMember("m_WeatherAudioEntity")]
    public static CAEWeatherAudioEntity @WeatherAudioEntity { get => new CAEWeatherAudioEntity(new IntPtr(0xC81360)); set { SdkMemory.Copy(value.Pointer,new IntPtr(0xC81360),128); } }
    public static void @AddRain() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4390 >(4390)(); }
    public static void @AddSandStormParticles() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4391 >(4391)(); }
    public static NativePointer<byte> @FindWeatherTypesList() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4392 >(4392)(); return new NativePointer<byte>(__sdkResult); }
    public static void @ForceWeather(short @weatherType) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4393 >(4393)(@weatherType); }
    public static void @ForceWeatherNow(short @weatherType) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4394 >(4394)(@weatherType); }
    public static bool @ForecastWeather(int @weatherType,int @numSteps) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4395 >(4395)(@weatherType,@numSteps); return __sdkResult != 0; }
    public static void @Init() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4396 >(4396)(); }
    public static void @ReleaseWeather() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4397 >(4397)(); }
    public static void @RenderRainStreaks() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4398 >(4398)(); }
    public static void @SetWeatherToAppropriateTypeNow() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4399 >(4399)(); }
    public static void @Update() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4400 >(4400)(); }
    public static void @UpdateInTunnelness() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4401 >(4401)(); }
    public static void @UpdateWeatherRegion(CVector? @posn) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4402 >(4402)(@posn?.Pointer ?? IntPtr.Zero); }
}
