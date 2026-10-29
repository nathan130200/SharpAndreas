// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CGameLogic : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=1;
    public CGameLogic(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("bFinishedByScript")]
    public static bool @FinishedByScript { get => SdkMemory.Read<bool >(new IntPtr(0x96A894)); set { SdkMemory.Write(new IntPtr(0x96A894),value); } }
    [NativeMember("SkipVehicle")]
    public static CVehicle? @SkipVehicle { get => SdkMemory.Read<IntPtr>(new IntPtr(0x96A898)) == IntPtr.Zero ? null : new CVehicle(SdkMemory.Read<IntPtr>(new IntPtr(0x96A898))); set { SdkMemory.Write(new IntPtr(0x96A898),value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("SkipTimer")]
    public static uint @SkipTimer { get => SdkMemory.Read<uint >(new IntPtr(0x96A89C)); set { SdkMemory.Write(new IntPtr(0x96A89C),value); } }
    [NativeMember("SkipState")]
    public static int @SkipState { get => SdkMemory.Read<int >(new IntPtr(0x96A8A0)); set { SdkMemory.Write(new IntPtr(0x96A8A0),value); } }
    [NativeMember("fSkipAngle")]
    public static float @SkipAngle { get => SdkMemory.Read<float >(new IntPtr(0x96A8A4)); set { SdkMemory.Write(new IntPtr(0x96A8A4),value); } }
    [NativeMember("bScriptCoopGameGoingOn")]
    public static bool @ScriptCoopGameGoingOn { get => SdkMemory.Read<bool >(new IntPtr(0x96A8A8)); set { SdkMemory.Write(new IntPtr(0x96A8A8),value); } }
    [NativeMember("TimeOfLastEvent")]
    public static uint @TimeOfLastEvent { get => SdkMemory.Read<uint >(new IntPtr(0x96A8AC)); set { SdkMemory.Write(new IntPtr(0x96A8AC),value); } }
    [NativeMember("GameState")]
    public static sbyte @GameState { get => SdkMemory.Read<sbyte >(new IntPtr(0x96A8B0)); set { SdkMemory.Write(new IntPtr(0x96A8B0),value); } }
    [NativeMember("bPlayersCannotTargetEachother")]
    public static sbyte @PlayersCannotTargetEachother { get => SdkMemory.Read<sbyte >(new IntPtr(0x96A8B2)); set { SdkMemory.Write(new IntPtr(0x96A8B2),value); } }
    public static void @InitAtStartOfGame() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2760 >(2760)(); }
    public static bool @IsCoopGameGoingOn() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2761 >(2761)(); return __sdkResult != 0; }
    public static void @Remove2ndPlayerIfPresent() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2762 >(2762)(); }
    public static void @SortOutStreamingAndMemory(CVector? @translation,float @angle) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2763 >(2763)(@translation?.Pointer ?? IntPtr.Zero,@angle); }
    public static void @PassTime(uint @time) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2764 >(2764)(@time); }
    public static void @ClearSkip(sbyte @a1) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2765 >(2765)(@a1); }
    public static bool @SkipCanBeActivated() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2766 >(2766)(); return __sdkResult != 0; }
    public static int @IsPointWithinLineArea(RwV3d? @vectors,int @sizeofvectors,float @x,float @y) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2767 >(2767)(@vectors?.Pointer ?? IntPtr.Zero,@sizeofvectors,@x,@y); return __sdkResult; }
    public static void @SetPlayerWantedLevelForForbiddenTerritories(sbyte @townNumber) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2768 >(2768)(@townNumber); }
    public static double @CalcDistanceToForbiddenTrainCrossing(float @x1,float @y1,float @z1,float @x2,float @y2,float @z2,sbyte @a7,CVector? @a8) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2769 >(2769)(@x1,@y1,@z1,@x2,@y2,@z2,@a7,@a8?.Pointer ?? IntPtr.Zero); return __sdkResult; }
    public static bool @LaRiotsActiveHere() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2770 >(2770)(); return __sdkResult != 0; }
    public static int @RestorePedsWeapons(int @a1) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2771 >(2771)(@a1); return __sdkResult; }
    public static bool @IsPlayerAllowedToGoInThisDirection(CPed? @a1,float @a2,float @a3,float @a4,float @a5) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2772 >(2772)(@a1?.Pointer ?? IntPtr.Zero,@a2,@a3,@a4,@a5); return __sdkResult != 0; }
    public static void @RestorePlayerStuffDuringResurrection(CPlayerPed? @player,float @x,float @y,float @z,float @fAngle) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2773 >(2773)(@player?.Pointer ?? IntPtr.Zero,@x,@y,@z,@fAngle); }
    public static void @UpdateSkip() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2774 >(2774)(); }
    public static void @ResetStuffUponResurrection() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2775 >(2775)(); }
    public static void @Update() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2776 >(2776)(); }
    public static void @Save() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2777 >(2777)(); }
    public static void @Load() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2778 >(2778)(); }
}
