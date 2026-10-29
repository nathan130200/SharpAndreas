// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CGangWars : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=1;
    public CGangWars(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("ZoneInfoForTraining")]
    public static int @ZoneInfoForTraining { get => SdkMemory.Read<int >(new IntPtr(0x8A5F40)); set { SdkMemory.Write(new IntPtr(0x8A5F40),value); } }
    [NativeMember("GangRatingStrength")]
    public static NativeArray<int> @GangRatingStrength { get => new NativeArray<int>(new IntPtr(0x96AB2C),3); }
    [NativeMember("GangRatings")]
    public static NativeArray<int> @GangRatings { get => new NativeArray<int>(new IntPtr(0x96AB38),3); }
    [NativeMember("FightTimer")]
    public static int @FightTimer { get => SdkMemory.Read<int >(new IntPtr(0x96AB44)); set { SdkMemory.Write(new IntPtr(0x96AB44),value); } }
    [NativeMember("TimeTillNextAttack")]
    public static float @TimeTillNextAttack { get => SdkMemory.Read<float >(new IntPtr(0x96AB48)); set { SdkMemory.Write(new IntPtr(0x96AB48),value); } }
    [NativeMember("State2")]
    public static eGangAttackState @State2 { get => SdkMemory.Read<eGangAttackState >(new IntPtr(0x96AB4C)); set { SdkMemory.Write(new IntPtr(0x96AB4C),value); } }
    [NativeMember("Gang2")]
    public static int @Gang2 { get => SdkMemory.Read<int >(new IntPtr(0x96AB50)); set { SdkMemory.Write(new IntPtr(0x96AB50),value); } }
    [NativeMember("LastTimeInArea")]
    public static uint @LastTimeInArea { get => SdkMemory.Read<uint >(new IntPtr(0x96AB54)); set { SdkMemory.Write(new IntPtr(0x96AB54),value); } }
    [NativeMember("WarFerocity")]
    public static int @WarFerocity { get => SdkMemory.Read<int >(new IntPtr(0x96AB58)); set { SdkMemory.Write(new IntPtr(0x96AB58),value); } }
    [NativeMember("Provocation")]
    public static float @Provocation { get => SdkMemory.Read<float >(new IntPtr(0x96AB5C)); set { SdkMemory.Write(new IntPtr(0x96AB5C),value); } }
    [NativeMember("TimeStarted")]
    public static uint @TimeStarted { get => SdkMemory.Read<uint >(new IntPtr(0x96AB60)); set { SdkMemory.Write(new IntPtr(0x96AB60),value); } }
    [NativeMember("State")]
    public static eGangWarState @State { get => SdkMemory.Read<eGangWarState >(new IntPtr(0x96AB64)); set { SdkMemory.Write(new IntPtr(0x96AB64),value); } }
    [NativeMember("aSpecificZones")]
    public static NativeArray<int> @SpecificZones { get => new NativeArray<int>(new IntPtr(0x96AB68),6); }
    [NativeMember("Difficulty")]
    public static float @Difficulty { get => SdkMemory.Read<float >(new IntPtr(0x96AB80)); set { SdkMemory.Write(new IntPtr(0x96AB80),value); } }
    [NativeMember("Gang1")]
    public static int @Gang1 { get => SdkMemory.Read<int >(new IntPtr(0x96AB84)); set { SdkMemory.Write(new IntPtr(0x96AB84),value); } }
    [NativeMember("pZoneToFightOver")]
    public static CZone? @ZoneToFightOver { get => SdkMemory.Read<IntPtr>(new IntPtr(0x96AB88)) == IntPtr.Zero ? null : new CZone(SdkMemory.Read<IntPtr>(new IntPtr(0x96AB88))); set { SdkMemory.Write(new IntPtr(0x96AB88),value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("pZoneInfoToFightOver")]
    public static CZoneInfo? @ZoneInfoToFightOver { get => SdkMemory.Read<IntPtr>(new IntPtr(0x96AB8C)) == IntPtr.Zero ? null : new CZoneInfo(SdkMemory.Read<IntPtr>(new IntPtr(0x96AB8C))); set { SdkMemory.Write(new IntPtr(0x96AB8C),value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("bGangWarsActive")]
    public static bool @GangWarsActive { get => SdkMemory.Read<bool >(new IntPtr(0x96AB90)); set { SdkMemory.Write(new IntPtr(0x96AB90),value); } }
    [NativeMember("bTrainingMission")]
    public static bool @TrainingMission { get => SdkMemory.Read<bool >(new IntPtr(0x96AB91)); set { SdkMemory.Write(new IntPtr(0x96AB91),value); } }
    [NativeMember("bPlayerIsCloseby")]
    public static bool @PlayerIsCloseby { get => SdkMemory.Read<bool >(new IntPtr(0x96AB92)); set { SdkMemory.Write(new IntPtr(0x96AB92),value); } }
    [NativeMember("bCanTriggerGangWarWhenOnAMission")]
    public static bool @CanTriggerGangWarWhenOnAMission { get => SdkMemory.Read<bool >(new IntPtr(0x96AB93)); set { SdkMemory.Write(new IntPtr(0x96AB93),value); } }
    [NativeMember("NumSpecificZones")]
    public static int @CountSpecificZones { get => SdkMemory.Read<int >(new IntPtr(0x96AB94)); set { SdkMemory.Write(new IntPtr(0x96AB94),value); } }
    [NativeMember("RadarBlip")]
    public static CRadar? @RadarBlip { get => SdkMemory.Read<IntPtr>(new IntPtr(0x96AB98)) == IntPtr.Zero ? null : new CRadar(SdkMemory.Read<IntPtr>(new IntPtr(0x96AB98))); set { SdkMemory.Write(new IntPtr(0x96AB98),value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("TerritoryUnderControlPercentage")]
    public static float @TerritoryUnderControlPercentage { get => SdkMemory.Read<float >(new IntPtr(0x96AB9C)); set { SdkMemory.Write(new IntPtr(0x96AB9C),value); } }
    [NativeMember("bIsPlayerOnAMission")]
    public static bool @IsPlayerOnAMission { get => SdkMemory.Read<bool >(new IntPtr(0x96ABA0)); set { SdkMemory.Write(new IntPtr(0x96ABA0),value); } }
    [NativeMember("CoorsOfPlayerAtStartOfWar")]
    public static CVector @CoorsOfPlayerAtStartOfWar { get => new CVector(new IntPtr(0x96ABBC)); set { SdkMemory.Copy(value.Pointer,new IntPtr(0x96ABBC),12); } }
    [NativeMember("PointOfAttack")]
    public static CVector @PointOfAttack { get => new CVector(new IntPtr(0x96ABC8)); set { SdkMemory.Copy(value.Pointer,new IntPtr(0x96ABC8),12); } }
    public static void @AddKillToProvocation(int @Pedtype) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2853 >(2853)(@Pedtype); }
    public static bool @AttackWaveOvercome() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2854 >(2854)(); return __sdkResult != 0; }
    public static uint @CalculateTimeTillNextAttack() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2855 >(2855)(); return __sdkResult; }
    public static bool @CanPlayerStartAGangWarHere(CZoneInfo? @zoneInfo) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2856 >(2856)(@zoneInfo?.Pointer ?? IntPtr.Zero); return __sdkResult != 0; }
    public static void @CheerVictory() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2857 >(2857)(); }
    public static void @ClearSpecificZonesToTriggerGangWar() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2858 >(2858)(); }
    public static void @ClearTheStreets() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2859 >(2859)(); }
    public static bool @CreateAttackWave(int @warFerocity,int @waveID) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2860 >(2860)(@warFerocity,@waveID); return __sdkResult != 0; }
    public static bool @CreateDefendingGroup(int @unused) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2861 >(2861)(@unused); return __sdkResult != 0; }
    public static void @DoStuffWhenPlayerVictorious() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2862 >(2862)(); }
    public static bool @DoesPlayerControlThisZone(CZoneInfo? @zoneinfo) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2863 >(2863)(@zoneinfo?.Pointer ?? IntPtr.Zero); return __sdkResult != 0; }
    public static bool @DontCreateCivilians() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2864 >(2864)(); return __sdkResult != 0; }
    public static void @EndGangWar(bool @bEnd) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2865 >(2865)((@bEnd ? 1 : 0)); }
    public static bool @GangWarFightingGoingOn() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2866 >(2866)(); return __sdkResult != 0; }
    public static bool @GangWarGoingOn() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2867 >(2867)(); return __sdkResult != 0; }
    public static void @InitAtStartOfGame() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2868 >(2868)(); }
    public static void @Load() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2869 >(2869)(); }
    public static void @MakeEnemyGainInfluenceInZone(int @GangID,int @GangDensityIncreaser) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2870 >(2870)(@GangID,@GangDensityIncreaser); }
    public static bool @MakePlayerGainInfluenceInZone(float @remove_mult) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2871 >(2871)(@remove_mult); return __sdkResult != 0; }
    public static bool @PedStreamedInForThisGang(int @gangID) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2872 >(2872)(@gangID); return __sdkResult != 0; }
    public static bool @PickStreamedInPedForThisGang(int @gangID,NativePointer<int> @outPedID) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2873 >(2873)(@gangID,@outPedID.Pointer); return __sdkResult != 0; }
    public static bool @PickZoneToAttack() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2874 >(2874)(); return __sdkResult != 0; }
    public static void @ReleaseCarsInAttackWave() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2875 >(2875)(); }
    public static int @ReleasePedsInAttackWave(bool @IsEndOfWar,bool @RestoreGangPedsAcquaintance) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2876 >(2876)((@IsEndOfWar ? 1 : 0),(@RestoreGangPedsAcquaintance ? 1 : 0)); return __sdkResult; }
    public static void @Save() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2877 >(2877)(); }
    public static void @SetGangWarsActive(bool @bActive) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2878 >(2878)((@bActive ? 1 : 0)); }
    public static void @SetSpecificZoneToTriggerGangWar(int @zoneId) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2879 >(2879)(@zoneId); }
    public static void @StartDefensiveGangWar() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2880 >(2880)(); }
    public static void @StartOffensiveGangWar() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2881 >(2881)(); }
    public static void @StrengthenPlayerInfluenceInZone(int @GroveDensityIncreaser) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2882 >(2882)(@GroveDensityIncreaser); }
    public static void @SwitchGangWarsActive() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2883 >(2883)(); }
    public static void @TellGangMembersTo(int @bIsGangWarEnding) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2884 >(2884)(@bIsGangWarEnding); }
    public static void @TellStreamingWhichGangsAreNeeded(NativePointer<int> @GangsBitFlags) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2885 >(2885)(@GangsBitFlags.Pointer); }
    public static void @Update() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2886 >(2886)(); }
    public static void @UpdateTerritoryUnderControlPercentage() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2887 >(2887)(); }
}
