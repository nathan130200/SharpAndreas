// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CLoadingScreen : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=1;
    public CLoadingScreen(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_currDisplayedSplash")]
    public static int @CurrDisplayedSplash { get => SdkMemory.Read<int >(new IntPtr(0x8D093C)); set { SdkMemory.Write(new IntPtr(0x8D093C),value); } }
    [NativeMember("m_numChunksLoaded")]
    public static int @CountChunksLoaded { get => SdkMemory.Read<int >(new IntPtr(0x8D0940)); set { SdkMemory.Write(new IntPtr(0x8D0940),value); } }
    [NativeMember("m_chunkBarAppeared")]
    public static int @ChunkBarAppeared { get => SdkMemory.Read<int >(new IntPtr(0x8D0944)); set { SdkMemory.Write(new IntPtr(0x8D0944),value); } }
    [NativeMember("m_PopUpMessage")]
    public static NativePointer<sbyte> @PopUpMessage { get => new NativePointer<sbyte>(new IntPtr(0xBAB268)); }
    [NativeMember("m_LoadingGxtMsg2")]
    public static NativePointer<sbyte> @LoadingGxtMsg2 { get => new NativePointer<sbyte>(new IntPtr(0xBAB278)); }
    [NativeMember("m_LoadingGxtMsg1")]
    public static NativePointer<sbyte> @LoadingGxtMsg1 { get => new NativePointer<sbyte>(new IntPtr(0xBAB2C8)); }
    [NativeMember("m_bActive")]
    public static bool @Active { get => SdkMemory.Read<bool >(new IntPtr(0xBAB318)); set { SdkMemory.Write(new IntPtr(0xBAB318),value); } }
    [NativeMember("m_bPaused")]
    public static bool @Paused { get => SdkMemory.Read<bool >(new IntPtr(0xBAB319)); set { SdkMemory.Write(new IntPtr(0xBAB319),value); } }
    [NativeMember("m_bWantToPause")]
    public static bool @WantToPause { get => SdkMemory.Read<bool >(new IntPtr(0xBAB31A)); set { SdkMemory.Write(new IntPtr(0xBAB31A),value); } }
    [NativeMember("m_bFading")]
    public static bool @Fading { get => SdkMemory.Read<bool >(new IntPtr(0xBAB31C)); set { SdkMemory.Write(new IntPtr(0xBAB31C),value); } }
    [NativeMember("m_bLegalScreen")]
    public static bool @LegalScreen { get => SdkMemory.Read<bool >(new IntPtr(0xBAB31D)); set { SdkMemory.Write(new IntPtr(0xBAB31D),value); } }
    [NativeMember("m_bFadeInNextSplashFromBlack")]
    public static bool @FadeInNextSplashFromBlack { get => SdkMemory.Read<bool >(new IntPtr(0xBAB31E)); set { SdkMemory.Write(new IntPtr(0xBAB31E),value); } }
    [NativeMember("m_bFadeOutCurrSplashToBlack")]
    public static bool @FadeOutCurrSplashToBlack { get => SdkMemory.Read<bool >(new IntPtr(0xBAB31F)); set { SdkMemory.Write(new IntPtr(0xBAB31F),value); } }
    [NativeMember("m_FadeAlpha")]
    public static sbyte @FadeAlpha { get => SdkMemory.Read<sbyte >(new IntPtr(0xBAB320)); set { SdkMemory.Write(new IntPtr(0xBAB320),value); } }
    [NativeMember("m_StartFadeTime")]
    public static float @StartFadeTime { get => SdkMemory.Read<float >(new IntPtr(0xBAB324)); set { SdkMemory.Write(new IntPtr(0xBAB324),value); } }
    [NativeMember("m_ClockTimeOnPause")]
    public static float @ClockTimeOnPause { get => SdkMemory.Read<float >(new IntPtr(0xBAB328)); set { SdkMemory.Write(new IntPtr(0xBAB328),value); } }
    [NativeMember("m_PauseTime")]
    public static float @PauseTime { get => SdkMemory.Read<float >(new IntPtr(0xBAB32C)); set { SdkMemory.Write(new IntPtr(0xBAB32C),value); } }
    [NativeMember("m_bReadyToDelete")]
    public static bool @ReadyToDelete { get => SdkMemory.Read<bool >(new IntPtr(0xBAB33D)); set { SdkMemory.Write(new IntPtr(0xBAB33D),value); } }
    [NativeMember("m_timeSinceLastScreen")]
    public static float @TimeSinceLastScreen { get => SdkMemory.Read<float >(new IntPtr(0xBAB340)); set { SdkMemory.Write(new IntPtr(0xBAB340),value); } }
    [NativeMember("m_aSplashes")]
    public static CSprite2d? @Splashes { get => new IntPtr(0xBAB35C) == IntPtr.Zero ? null : new CSprite2d(new IntPtr(0xBAB35C)); }
    public static void @Shutdown() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3033 >(3033)(); }
    public static void @RenderSplash() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3034 >(3034)(); }
    public static void @LoadSplashes(byte @bStarting,byte @bNvidia) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3035 >(3035)(@bStarting,@bNvidia); }
    public static void @DisplayMessage(NativePointer<sbyte> @message) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3036 >(3036)(@message.Pointer); }
    public static void @SetLoadingBarMsg(NativePointer<sbyte> @msg1,NativePointer<sbyte> @msg2) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3037 >(3037)(@msg1.Pointer,@msg2.Pointer); }
    public static double @GetClockTime(bool @bIgnorePauseTime) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3038 >(3038)((@bIgnorePauseTime ? 1 : 0)); return __sdkResult; }
    public static void @Init(bool @unusedflag,bool @bLoaded) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3039 >(3039)((@unusedflag ? 1 : 0),(@bLoaded ? 1 : 0)); }
    public static void @Continue() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3040 >(3040)(); }
    public static void @RenderLoadingBar() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3041 >(3041)(); }
    public static void @DisplayNextSplash() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3042 >(3042)(); }
    public static void @StartFading() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3043 >(3043)(); }
    public static void @DisplayPCScreen() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3044 >(3044)(); }
    public static void @Update() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3045 >(3045)(); }
    public static void @DoPCTitleFadeOut() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3046 >(3046)(); }
    public static void @DoPCTitleFadeIn() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3047 >(3047)(); }
    public static void @DoPCScreenChange(uint @bFinish) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3048 >(3048)(@bFinish); }
    public static void @NewChunkLoaded() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3049 >(3049)(); }
}
