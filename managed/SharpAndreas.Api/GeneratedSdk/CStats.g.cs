// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CStats : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=1;
    public CStats(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("StatMessage")]
    public static tStatMessage? @StatMessage { get => new IntPtr(0xB78200) == IntPtr.Zero ? null : new tStatMessage(new IntPtr(0xB78200)); }
    [NativeMember("TotalNumStatMessages")]
    public static uint @TotalCountStatMessages { get => SdkMemory.Read<uint >(new IntPtr(0xB794D0)); set { SdkMemory.Write(new IntPtr(0xB794D0),value); } }
    [NativeMember("LastMissionPassedName")]
    public static NativePointer<sbyte> @LastMissionPassedName { get => new NativePointer<sbyte>(new IntPtr(0xB78A00)); }
    [NativeMember("TimesMissionAttempted")]
    public static NativePointer<int> @TimesMissionAttempted { get => new NativePointer<int>(new IntPtr(0xB78CC8)); }
    [NativeMember("FavoriteRadioStationList")]
    public static NativePointer<int> @FavoriteRadioStationList { get => new NativePointer<int>(new IntPtr(0xB78E58)); }
    [NativeMember("PedsKilledOfThisType")]
    public static NativePointer<int> @PedsKilledOfThisType { get => new NativePointer<int>(new IntPtr(0xB78E90)); }
    [NativeMember("StatReactionValue")]
    public static NativePointer<float> @StatReactionValue { get => new NativePointer<float>(new IntPtr(0xB78F10)); }
    [NativeMember("StatTypesInt")]
    public static NativePointer<int> @StatTypesInt { get => new NativePointer<int>(new IntPtr(0xB79000)); }
    [NativeMember("StatTypesFloat")]
    public static NativePointer<float> @StatTypesFloat { get => new NativePointer<float>(new IntPtr(0xB79380)); }
    [NativeMember("m_ThisStatIsABarChart")]
    public static short @ThisStatIsABarChart { get => SdkMemory.Read<short >(new IntPtr(0xB794CC)); set { SdkMemory.Write(new IntPtr(0xB794CC),value); } }
    [NativeMember("bStatUpdateMessageDisplayed")]
    public static bool @StatUpdateMessageDisplayed { get => SdkMemory.Read<bool >(new IntPtr(0xB794D4)); set { SdkMemory.Write(new IntPtr(0xB794D4),value); } }
    [NativeMember("m_SprintStaminaCounter")]
    public static uint @SprintStaminaCounter { get => SdkMemory.Read<uint >(new IntPtr(0xB794D8)); set { SdkMemory.Write(new IntPtr(0xB794D8),value); } }
    [NativeMember("m_CycleStaminaCounter")]
    public static uint @CycleStaminaCounter { get => SdkMemory.Read<uint >(new IntPtr(0xB794DC)); set { SdkMemory.Write(new IntPtr(0xB794DC),value); } }
    [NativeMember("m_CycleSkillCounter")]
    public static uint @CycleSkillCounter { get => SdkMemory.Read<uint >(new IntPtr(0xB794E0)); set { SdkMemory.Write(new IntPtr(0xB794E0),value); } }
    [NativeMember("m_SwimStaminaCounter")]
    public static uint @SwimStaminaCounter { get => SdkMemory.Read<uint >(new IntPtr(0xB794E4)); set { SdkMemory.Write(new IntPtr(0xB794E4),value); } }
    [NativeMember("m_SwimUnderWaterCounter")]
    public static uint @SwimUnderWaterCounter { get => SdkMemory.Read<uint >(new IntPtr(0xB794E8)); set { SdkMemory.Write(new IntPtr(0xB794E8),value); } }
    [NativeMember("m_DrivingCounter")]
    public static uint @DrivingCounter { get => SdkMemory.Read<uint >(new IntPtr(0xB794EC)); set { SdkMemory.Write(new IntPtr(0xB794EC),value); } }
    [NativeMember("m_FlyingCounter")]
    public static uint @FlyingCounter { get => SdkMemory.Read<uint >(new IntPtr(0xB794F0)); set { SdkMemory.Write(new IntPtr(0xB794F0),value); } }
    [NativeMember("m_BoatCounter")]
    public static uint @BoatCounter { get => SdkMemory.Read<uint >(new IntPtr(0xB794F4)); set { SdkMemory.Write(new IntPtr(0xB794F4),value); } }
    [NativeMember("m_BikeCounter")]
    public static uint @BikeCounter { get => SdkMemory.Read<uint >(new IntPtr(0xB794F8)); set { SdkMemory.Write(new IntPtr(0xB794F8),value); } }
    [NativeMember("m_FatCounter")]
    public static uint @FatCounter { get => SdkMemory.Read<uint >(new IntPtr(0xB794FC)); set { SdkMemory.Write(new IntPtr(0xB794FC),value); } }
    [NativeMember("m_RunningCounter")]
    public static uint @RunningCounter { get => SdkMemory.Read<uint >(new IntPtr(0xB79500)); set { SdkMemory.Write(new IntPtr(0xB79500),value); } }
    [NativeMember("m_WeaponCounter")]
    public static uint @WeaponCounter { get => SdkMemory.Read<uint >(new IntPtr(0xB79504)); set { SdkMemory.Write(new IntPtr(0xB79504),value); } }
    [NativeMember("m_DeathCounter")]
    public static uint @DeathCounter { get => SdkMemory.Read<uint >(new IntPtr(0xB79508)); set { SdkMemory.Write(new IntPtr(0xB79508),value); } }
    [NativeMember("m_MaxHealthCounter")]
    public static uint @MaxHealthCounter { get => SdkMemory.Read<uint >(new IntPtr(0xB7950C)); set { SdkMemory.Write(new IntPtr(0xB7950C),value); } }
    [NativeMember("m_AddToHealthCounter")]
    public static uint @AddToHealthCounter { get => SdkMemory.Read<uint >(new IntPtr(0xB79510)); set { SdkMemory.Write(new IntPtr(0xB79510),value); } }
    [NativeMember("m_LastWeaponTypeFired")]
    public static uint @LastWeaponTypeFired { get => SdkMemory.Read<uint >(new IntPtr(0xB79514)); set { SdkMemory.Write(new IntPtr(0xB79514),value); } }
    public static NativePointer<sbyte> @GetStatID(ushort @stat) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3799 >(3799)(@stat); return new NativePointer<sbyte>(__sdkResult); }
    public static bool @GetStatType(ushort @stat) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3800 >(3800)(@stat); return __sdkResult != 0; }
    public static float @GetStatValue(ushort @stat) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3801 >(3801)(@stat); return __sdkResult; }
    public static sbyte @GetTimesMissionAttempted(byte @missionId) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3802 >(3802)(@missionId); return __sdkResult; }
    public static void @RegisterMissionAttempted(byte @missionId) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3803 >(3803)(@missionId); }
    public static void @RegisterMissionPassed(byte @missionId) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3804 >(3804)(@missionId); }
    public static bool @PopulateFavoriteRadioStationList() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3805 >(3805)(); return __sdkResult != 0; }
    public static NativePointer<int> @GetFullFavoriteRadioStationList() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3806 >(3806)(); return new NativePointer<int>(__sdkResult); }
    public static int @FindMostFavoriteRadioStation() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3807 >(3807)(); return __sdkResult; }
    public static int @FindLeastFavoriteRadioStation() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3808 >(3808)(); return __sdkResult; }
    public static int @FindCriminalRatingNumber() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3809 >(3809)(); return __sdkResult; }
    public static float @GetPercentageProgress() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3810 >(3810)(); return __sdkResult; }
    public static void @BuildStatLine(NativePointer<sbyte> @line,NativePointer<IntPtr> @pValue1,int @metrics,NativePointer<IntPtr> @pValue2,int @type) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3811 >(3811)(@line.Pointer,@pValue1.Pointer,@metrics,@pValue2.Pointer,@type); }
    public static int @ConvertToMins(int @value) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3812 >(3812)(@value); return __sdkResult; }
    public static int @ConvertToSecs(int @value) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3813 >(3813)(@value); return __sdkResult; }
    public static bool @SafeToShowThisStat(byte @stat) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3814 >(3814)(@stat); return __sdkResult != 0; }
    public static bool @CheckForThreshold(NativePointer<float> @pValue,float @range) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3815 >(3815)(@pValue.Pointer,@range); return __sdkResult != 0; }
    public static bool @IsStatCapped(ushort @stat) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3816 >(3816)(@stat); return __sdkResult != 0; }
    public static void @ProcessReactionStatsOnDecrement(byte @stat) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3817 >(3817)(@stat); }
    public static void @CheckForStatsMessage() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3818 >(3818)(); }
    public static void @LoadStatUpdateConditions() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3819 >(3819)(); }
    public static void @LoadActionReactionStats() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3820 >(3820)(); }
    public static int @FindMaxNumberOfGroupMembers() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3821 >(3821)(); return __sdkResult; }
    public static float @GetFatAndMuscleModifier(eStatModAbilities @statMod) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3822 >(3822)((int)@statMod); return __sdkResult; }
    public static void @DecrementStat(ushort @stat,float @value) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3823 >(3823)(@stat,@value); }
    public static void @SetStatValue(ushort @stat,float @value) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3824 >(3824)(@stat,@value); }
    public static void @RegisterFastestTime(int @stat,int @time) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3825 >(3825)(@stat,@time); }
    public static void @RegisterBestPosition(int @stat,int @position) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3826 >(3826)(@stat,@position); }
    public static NativePointer<sbyte> @FindCriminalRatingString() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3827 >(3827)(); return new NativePointer<sbyte>(__sdkResult); }
    public static int @ConstructStatLine(int @arg0,byte @arg1) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3828 >(3828)(@arg0,@arg1); return __sdkResult; }
    public static void @ProcessReactionStatsOnIncrement(byte @stat) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3829 >(3829)(@stat); }
    public static void @DisplayScriptStatUpdateMessage(byte @state,uint @stat,float @value) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3830 >(3830)(@state,@stat,@value); }
    public static void @UpdateRespectStat(byte @arg0) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3831 >(3831)(@arg0); }
    public static void @UpdateSexAppealStat() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3832 >(3832)(); }
    public static void @Init() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3833 >(3833)(); }
    public static void @IncrementStat(ushort @stat,float @value) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3834 >(3834)(@stat,@value); }
    public static void @SetNewRecordStat(ushort @stat,float @value) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3835 >(3835)(@stat,@value); }
    public static void @UpdateFatAndMuscleStats(uint @value) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3836 >(3836)(@value); }
    public static void @UpdateStatsWhenSprinting() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3837 >(3837)(); }
    public static void @UpdateStatsWhenRunning() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3838 >(3838)(); }
    public static void @UpdateStatsWhenCycling(bool @arg0,CBmx? @bmx) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3839 >(3839)((@arg0 ? 1 : 0),@bmx?.Pointer ?? IntPtr.Zero); }
    public static void @UpdateStatsWhenSwimming(bool @arg0,bool @arg1) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3840 >(3840)((@arg0 ? 1 : 0),(@arg1 ? 1 : 0)); }
    public static void @UpdateStatsWhenDriving(CVehicle? @vehicle) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3841 >(3841)(@vehicle?.Pointer ?? IntPtr.Zero); }
    public static void @UpdateStatsWhenFlying(CVehicle? @vehicle) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3842 >(3842)(@vehicle?.Pointer ?? IntPtr.Zero); }
    public static void @UpdateStatsWhenOnMotorBike(CBike? @bike) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3843 >(3843)(@bike?.Pointer ?? IntPtr.Zero); }
    public static void @UpdateStatsWhenWeaponHit(int @weaponType) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3844 >(3844)(@weaponType); }
    public static void @UpdateStatsWhenFighting() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3845 >(3845)(); }
    public static void @UpdateStatsOnRespawn() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3846 >(3846)(); }
    public static void @UpdateStatsAddToHealth(uint @addToHealth) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3847 >(3847)(@addToHealth); }
    public static void @ModifyStat(ushort @stat,float @value) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3848 >(3848)(@stat,@value); }
    public static bool @Save() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3849 >(3849)(); return __sdkResult != 0; }
    public static bool @Load() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3850 >(3850)(); return __sdkResult != 0; }
}
