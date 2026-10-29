// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CTimer : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=1;
    public CTimer(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("bSkipProcessThisFrame")]
    public static bool @SkipProcessThisFrame { get => SdkMemory.Read<bool >(new IntPtr(0xB7CB89)); set { SdkMemory.Write(new IntPtr(0xB7CB89),value); } }
    [NativeMember("bSlowMotionActive")]
    public static bool @SlowMotionActive { get => SdkMemory.Read<bool >(new IntPtr(0xB7CB88)); set { SdkMemory.Write(new IntPtr(0xB7CB88),value); } }
    [NativeMember("game_FPS")]
    public static float @GameFPS { get => SdkMemory.Read<float >(new IntPtr(0xB7CB50)); set { SdkMemory.Write(new IntPtr(0xB7CB50),value); } }
    [NativeMember("m_CodePause")]
    public static bool @CodePause { get => SdkMemory.Read<bool >(new IntPtr(0xB7CB48)); set { SdkMemory.Write(new IntPtr(0xB7CB48),value); } }
    [NativeMember("m_FrameCounter")]
    public static uint @FrameCounter { get => SdkMemory.Read<uint >(new IntPtr(0xB7CB4C)); set { SdkMemory.Write(new IntPtr(0xB7CB4C),value); } }
    [NativeMember("m_UserPause")]
    public static bool @UserPause { get => SdkMemory.Read<bool >(new IntPtr(0xB7CB49)); set { SdkMemory.Write(new IntPtr(0xB7CB49),value); } }
    [NativeMember("ms_fTimeStepNonClipped")]
    public static float @TimeStepNonClipped { get => SdkMemory.Read<float >(new IntPtr(0xB7CB58)); set { SdkMemory.Write(new IntPtr(0xB7CB58),value); } }
    [NativeMember("ms_fTimeStep")]
    public static float @TimeStep { get => SdkMemory.Read<float >(new IntPtr(0xB7CB5C)); set { SdkMemory.Write(new IntPtr(0xB7CB5C),value); } }
    [NativeMember("m_snPPPPreviousTimeInMilliseconds")]
    public static uint @SnPPPPreviousTimeInMilliseconds { get => SdkMemory.Read<uint >(new IntPtr(0xB7CB6C)); set { SdkMemory.Write(new IntPtr(0xB7CB6C),value); } }
    [NativeMember("m_snPPPreviousTimeInMilliseconds")]
    public static uint @SnPPPreviousTimeInMilliseconds { get => SdkMemory.Read<uint >(new IntPtr(0xB7CB70)); set { SdkMemory.Write(new IntPtr(0xB7CB70),value); } }
    [NativeMember("m_snPPreviousTimeInMilliseconds")]
    public static uint @SnPPreviousTimeInMilliseconds { get => SdkMemory.Read<uint >(new IntPtr(0xB7CB74)); set { SdkMemory.Write(new IntPtr(0xB7CB74),value); } }
    [NativeMember("m_snPreviousTimeInMillisecondsNonClipped")]
    public static uint @SnPreviousTimeInMillisecondsNonClipped { get => SdkMemory.Read<uint >(new IntPtr(0xB7CB68)); set { SdkMemory.Write(new IntPtr(0xB7CB68),value); } }
    [NativeMember("ms_fOldTimeStep")]
    public static float @OldTimeStep { get => SdkMemory.Read<float >(new IntPtr(0xB7CB54)); set { SdkMemory.Write(new IntPtr(0xB7CB54),value); } }
    [NativeMember("ms_fSlowMotionScale")]
    public static float @SlowMotionScale { get => SdkMemory.Read<float >(new IntPtr(0xB7CB60)); set { SdkMemory.Write(new IntPtr(0xB7CB60),value); } }
    [NativeMember("ms_fTimeScale")]
    public static float @TimeScale { get => SdkMemory.Read<float >(new IntPtr(0xB7CB64)); set { SdkMemory.Write(new IntPtr(0xB7CB64),value); } }
    [NativeMember("m_snPreviousTimeInMilliseconds")]
    public static uint @SnPreviousTimeInMilliseconds { get => SdkMemory.Read<uint >(new IntPtr(0xB7CB78)); set { SdkMemory.Write(new IntPtr(0xB7CB78),value); } }
    [NativeMember("m_snTimeInMillisecondsPauseMode")]
    public static uint @SnTimeInMillisecondsPauseMode { get => SdkMemory.Read<uint >(new IntPtr(0xB7CB7C)); set { SdkMemory.Write(new IntPtr(0xB7CB7C),value); } }
    [NativeMember("m_snTimeInMillisecondsNonClipped")]
    public static uint @SnTimeInMillisecondsNonClipped { get => SdkMemory.Read<uint >(new IntPtr(0xB7CB80)); set { SdkMemory.Write(new IntPtr(0xB7CB80),value); } }
    [NativeMember("m_snTimeInMilliseconds")]
    public static uint @SnTimeInMilliseconds { get => SdkMemory.Read<uint >(new IntPtr(0xB7CB84)); set { SdkMemory.Write(new IntPtr(0xB7CB84),value); } }
    public static void @Initialise() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4203 >(4203)(); }
    public static void @Shutdown() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4204 >(4204)(); }
    public static void @UpdateVariables(float @timeStep) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4205 >(4205)(@timeStep); }
    public static void @Suspend() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4206 >(4206)(); }
    public static void @Resume() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4207 >(4207)(); }
    public static int @GetCyclesPerMillisecond() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4208 >(4208)(); return __sdkResult; }
    public static int @GetCyclesPerFrame() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4209 >(4209)(); return __sdkResult; }
    public static uint @GetCurrentTimeInCycles() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4210 >(4210)(); return __sdkResult; }
    public static void @Stop() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4211 >(4211)(); }
    public static bool @GetIsSlowMotionActive() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4212 >(4212)(); return __sdkResult != 0; }
    public static void @StartUserPause() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4213 >(4213)(); }
    public static void @EndUserPause() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4214 >(4214)(); }
    public static void @Update() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4215 >(4215)(); }
}
