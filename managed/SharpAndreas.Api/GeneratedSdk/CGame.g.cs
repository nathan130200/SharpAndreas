// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CGame : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=1;
    public CGame(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("aDatFile")]
    public static NativeArray<sbyte> @DatFile { get => new NativeArray<sbyte>(new IntPtr(0xB728EC),32); }
    [NativeMember("currLevel")]
    public static int @CurrLevel { get => SdkMemory.Read<int >(new IntPtr(0xB7290C)); set { SdkMemory.Write(new IntPtr(0xB7290C),value); } }
    [NativeMember("bMissionPackGame")]
    public static byte @MissionPackGame { get => SdkMemory.Read<byte >(new IntPtr(0xB72910)); set { SdkMemory.Write(new IntPtr(0xB72910),value); } }
    [NativeMember("currArea")]
    public static int @CurrArea { get => SdkMemory.Read<int >(new IntPtr(0xB72914)); set { SdkMemory.Write(new IntPtr(0xB72914),value); } }
    [NativeMember("m_pWorkingMatrix1")]
    public static RwMatrixTag? @WorkingMatrix1 { get => SdkMemory.Read<IntPtr>(new IntPtr(0xB72920)) == IntPtr.Zero ? null : new RwMatrixTag(SdkMemory.Read<IntPtr>(new IntPtr(0xB72920))); set { SdkMemory.Write(new IntPtr(0xB72920),value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_pWorkingMatrix2")]
    public static RwMatrixTag? @WorkingMatrix2 { get => SdkMemory.Read<IntPtr>(new IntPtr(0xB72924)) == IntPtr.Zero ? null : new RwMatrixTag(SdkMemory.Read<IntPtr>(new IntPtr(0xB72924))); set { SdkMemory.Write(new IntPtr(0xB72924),value?.Pointer ?? IntPtr.Zero); } }
    public static bool @CanSeeOutSideFromCurrArea() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2738 >(2738)(); return __sdkResult != 0; }
    public static bool @CanSeeWaterFromCurrArea() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2739 >(2739)(); return __sdkResult != 0; }
    public static void @DrasticTidyUpMemory(bool @a1) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2740 >(2740)((@a1 ? 1 : 0)); }
    public static void @FinalShutdown() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2741 >(2741)(); }
    public static void @GenerateTempPedAtStartOfNetworkGame() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2742 >(2742)(); }
    public static bool @Init1(NativePointer<sbyte> @datFile) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2743 >(2743)(@datFile.Pointer); return __sdkResult != 0; }
    public static bool @Init2(NativePointer<sbyte> @datFile) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2744 >(2744)(@datFile.Pointer); return __sdkResult != 0; }
    public static bool @Init3(NativePointer<sbyte> @datFile) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2745 >(2745)(@datFile.Pointer); return __sdkResult != 0; }
    public static void @InitAfterLostFocus() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2746 >(2746)(); }
    public static bool @Initialise(NativePointer<sbyte> @datFile) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2747 >(2747)(@datFile.Pointer); return __sdkResult != 0; }
    public static bool @InitialiseCoreDataAfterRW() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2748 >(2748)(); return __sdkResult != 0; }
    public static bool @InitialiseEssentialsAfterRW() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2749 >(2749)(); return __sdkResult != 0; }
    public static bool @InitialiseOnceBeforeRW() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2750 >(2750)(); return __sdkResult != 0; }
    public static bool @InitialiseRenderWare() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2751 >(2751)(); return __sdkResult != 0; }
    public static void @InitialiseWhenRestarting() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2752 >(2752)(); }
    public static void @Process() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2753 >(2753)(); }
    public static void @ReInitGameObjectVariables() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2754 >(2754)(); }
    public static void @ReloadIPLs() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2755 >(2755)(); }
    public static void @ShutDownForRestart() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2756 >(2756)(); }
    public static bool @Shutdown() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2757 >(2757)(); return __sdkResult != 0; }
    public static void @ShutdownRenderWare() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2758 >(2758)(); }
    public static void @TidyUpMemory(bool @a1,bool @clearD3Dmem) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2759 >(2759)((@a1 ? 1 : 0),(@clearD3Dmem ? 1 : 0)); }
}
