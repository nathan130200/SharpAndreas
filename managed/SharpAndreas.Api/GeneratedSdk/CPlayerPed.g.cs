// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CPlayerPed : CPed
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=1956;
    public CPlayerPed(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_pPlayerTargettedPed")]
    public CPed? @PlayerTargettedPed { get => SdkMemory.Read<IntPtr>(Pointer+1948) == IntPtr.Zero ? null : new CPed(SdkMemory.Read<IntPtr>(Pointer+1948)); set { SdkMemory.Write(Pointer+1948,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("field_7A0")]
    public int @Field7A0 { get => SdkMemory.Read<int >(Pointer+1952); set { SdkMemory.Write(Pointer+1952,value); } }
    [NativeMember("bHasDisplayedPlayerQuitEnterCarHelpText")]
    public static bool @HasDisplayedPlayerQuitEnterCarHelpText { get => SdkMemory.Read<bool >(new IntPtr(0xC0BC15)); set { SdkMemory.Write(new IntPtr(0xC0BC15),value); } }
    public void @InitializeAt(int @playerId,bool @bGroupCreated) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2049 >(2049)(Pointer,@playerId,(@bGroupCreated ? 1 : 0)); }
    public CWanted? @GetWanted() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2050 >(2050)(Pointer); return __sdkResult == IntPtr.Zero ? null : new CWanted(__sdkResult); }
    public CPad? @GetPadFromPlayer() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2051 >(2051)(Pointer); return __sdkResult == IntPtr.Zero ? null : new CPad(__sdkResult); }
    public bool @CanPlayerStartMission() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2052 >(2052)(Pointer); return __sdkResult != 0; }
    public bool @IsHidden() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2053 >(2053)(Pointer); return __sdkResult != 0; }
    public void @ReApplyMoveAnims() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2054 >(2054)(Pointer); }
    public bool @DoesPlayerWantNewWeapon(eWeaponType @weaponType,bool @arg1) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2055 >(2055)(Pointer,(int)@weaponType,(@arg1 ? 1 : 0)); return __sdkResult != 0; }
    public void @ProcessPlayerWeapon(CPad? @pad) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2056 >(2056)(Pointer,@pad?.Pointer ?? IntPtr.Zero); }
    public void @PickWeaponAllowedFor2Player() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2057 >(2057)(Pointer); }
    public void @UpdateCameraWeaponModes(CPad? @pad) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2058 >(2058)(Pointer,@pad?.Pointer ?? IntPtr.Zero); }
    public void @ProcessAnimGroups() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2059 >(2059)(Pointer); }
    public void @ClearWeaponTarget() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2060 >(2060)(Pointer); }
    public float @GetWeaponRadiusOnScreen() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2061 >(2061)(Pointer); return __sdkResult; }
    public float @FindTargetPriority(CEntity? @entity) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2062 >(2062)(Pointer,@entity?.Pointer ?? IntPtr.Zero); return __sdkResult; }
    public void @Clear3rdPersonMouseTarget() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2063 >(2063)(Pointer); }
    public void @Busted() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2064 >(2064)(Pointer); }
    public void @SetWantedLevel(int @level) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2065 >(2065)(Pointer,@level); }
    public void @SetWantedLevelNoDrop(int @level) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2066 >(2066)(Pointer,@level); }
    public void @CheatWantedLevel(int @level) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2067 >(2067)(Pointer,@level); }
    public bool @CanIKReachThisTarget(CVector @posn,CWeapon? @weapon,bool @arg2) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2068 >(2068)(Pointer,@posn.Pointer,@weapon?.Pointer ?? IntPtr.Zero,(@arg2 ? 1 : 0)); return __sdkResult != 0; }
    public CPlayerInfo? @GetPlayerInfoForThisPlayerPed() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2069 >(2069)(Pointer); return __sdkResult == IntPtr.Zero ? null : new CPlayerInfo(__sdkResult); }
    public void @DoStuffToGoOnFire() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2070 >(2070)(Pointer); }
    public void @AnnoyPlayerPed(bool @arg0) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2071 >(2071)(Pointer,(@arg0 ? 1 : 0)); }
    public void @ClearAdrenaline() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2072 >(2072)(Pointer); }
    public void @DisbandPlayerGroup() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2073 >(2073)(Pointer); }
    public void @MakeGroupRespondToPlayerTakingDamage(CEventDamage @damageEvent) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2074 >(2074)(Pointer,@damageEvent.Pointer); }
    public void @TellGroupToStartFollowingPlayer(bool @arg0,bool @arg1,bool @arg2) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2075 >(2075)(Pointer,(@arg0 ? 1 : 0),(@arg1 ? 1 : 0),(@arg2 ? 1 : 0)); }
    public void @MakePlayerGroupDisappear() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2076 >(2076)(Pointer); }
    public void @MakePlayerGroupReappear() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2077 >(2077)(Pointer); }
    public void @ResetSprintEnergy() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2078 >(2078)(Pointer); }
    public bool @HandleSprintEnergy(bool @arg0,float @arg1) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2079 >(2079)(Pointer,(@arg0 ? 1 : 0),@arg1); return __sdkResult != 0; }
    public float @ControlButtonSprint(eSprintType @sprintType) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2080 >(2080)(Pointer,(int)@sprintType); return __sdkResult; }
    public float @GetButtonSprintResults(eSprintType @sprintType) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2081 >(2081)(Pointer,(int)@sprintType); return __sdkResult; }
    public void @ResetPlayerBreath() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2082 >(2082)(Pointer); }
    public void @HandlePlayerBreath(bool @arg0,float @arg1) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2083 >(2083)(Pointer,(@arg0 ? 1 : 0),@arg1); }
    public void @SetRealMoveAnim() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2084 >(2084)(Pointer); }
    public void @MakeChangesForNewWeapon(eWeaponType @weaponType) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2085 >(2085)(Pointer,(int)@weaponType); }
    public void @Compute3rdPersonMouseTarget(bool @meleeWeapon) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2086 >(2086)(Pointer,(@meleeWeapon ? 1 : 0)); }
    public void @DrawTriangleForMouseRecruitPed() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2087 >(2087)(Pointer); }
    public bool @DoesTargetHaveToBeBroken(CEntity? @entity,CWeapon? @weapon) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2088 >(2088)(Pointer,@entity?.Pointer ?? IntPtr.Zero,@weapon?.Pointer ?? IntPtr.Zero); return __sdkResult != 0; }
    public void @KeepAreaAroundPlayerClear() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2089 >(2089)(Pointer); }
    public void @SetPlayerMoveBlendRatio(CVector? @arg0) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2090 >(2090)(Pointer,@arg0?.Pointer ?? IntPtr.Zero); }
    public CPed? @FindPedToAttack() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2091 >(2091)(Pointer); return __sdkResult == IntPtr.Zero ? null : new CPed(__sdkResult); }
    public void @ForceGroupToAlwaysFollow(bool @enable) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2092 >(2092)(Pointer,(@enable ? 1 : 0)); }
    public void @ForceGroupToNeverFollow(bool @enable) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2093 >(2093)(Pointer,(@enable ? 1 : 0)); }
    public void @MakeThisPedJoinOurGroup(CPed? @ped) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2094 >(2094)(Pointer,@ped?.Pointer ?? IntPtr.Zero); }
    public bool @PlayerWantsToAttack() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2095 >(2095)(Pointer); return __sdkResult != 0; }
    public void @SetInitialState(bool @bGroupCreated) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2096 >(2096)(Pointer,(@bGroupCreated ? 1 : 0)); }
    public void @MakeChangesForNewWeapon(int @weaponSlot) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2097 >(2097)(Pointer,@weaponSlot); }
    public void @EvaluateTarget(CEntity? @target,NativePointer<IntPtr> @outTarget,NativePointer<float> @outTargetPriority,float @maxDistance,float @arg4,bool @arg5) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2098 >(2098)(Pointer,@target?.Pointer ?? IntPtr.Zero,@outTarget.Pointer,@outTargetPriority.Pointer,@maxDistance,@arg4,(@arg5 ? 1 : 0)); }
    public void @EvaluateNeighbouringTarget(CEntity? @target,NativePointer<IntPtr> @outTarget,NativePointer<float> @outTargetPriority,float @maxDistance,float @arg4,bool @arg5) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2099 >(2099)(Pointer,@target?.Pointer ?? IntPtr.Zero,@outTarget.Pointer,@outTargetPriority.Pointer,@maxDistance,@arg4,(@arg5 ? 1 : 0)); }
    public void @ProcessGroupBehaviour(CPad? @pad) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2100 >(2100)(Pointer,@pad?.Pointer ?? IntPtr.Zero); }
    public bool @PlayerHasJustAttackedSomeone() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2101 >(2101)(Pointer); return __sdkResult != 0; }
    public void @ProcessWeaponSwitch(CPad? @pad) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2102 >(2102)(Pointer,@pad?.Pointer ?? IntPtr.Zero); }
    public bool @FindWeaponLockOnTarget() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2103 >(2103)(Pointer); return __sdkResult != 0; }
    public bool @FindNextWeaponLockOnTarget(CEntity? @arg0,bool @arg1) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2104 >(2104)(Pointer,@arg0?.Pointer ?? IntPtr.Zero,(@arg1 ? 1 : 0)); return __sdkResult != 0; }
    public int @GetWantedLevel() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2105 >(2105)(Pointer); return __sdkResult; }
    public static void @RemovePlayerPed(int @playerId) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2106 >(2106)(@playerId); }
    public static void @DeactivatePlayerPed(int @playerId) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2107 >(2107)(@playerId); }
    public static void @ReactivatePlayerPed(int @playerId) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2108 >(2108)(@playerId); }
    public static bool @PedCanBeTargettedVehicleWise(CPed? @ped) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2109 >(2109)(@ped?.Pointer ?? IntPtr.Zero); return __sdkResult != 0; }
    public static void @SetupPlayerPed(int @playerId) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2110 >(2110)(@playerId); }
}
