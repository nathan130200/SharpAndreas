// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CPedGroups : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=1;
    public CPedGroups(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("ScriptReferenceIndex")]
    public static NativeArray<short> @ScriptReferenceIndex { get => new NativeArray<short>(new IntPtr(0xC098D0),8); }
    [NativeMember("ms_activeGroups")]
    public static NativeArray<sbyte> @ActiveGroups { get => new NativeArray<sbyte>(new IntPtr(0xC098E0),8); }
    [NativeMember("ms_bIsPlayerOnAMission")]
    public static bool @IsPlayerOnAMission { get => SdkMemory.Read<bool >(new IntPtr(0xC098E8)); set { SdkMemory.Write(new IntPtr(0xC098E8),value); } }
    [NativeMember("ms_iNoOfPlayerKills")]
    public static uint @INoOfPlayerKills { get => SdkMemory.Read<uint >(new IntPtr(0xC098EC)); set { SdkMemory.Write(new IntPtr(0xC098EC),value); } }
    [NativeMember("ms_groups")]
    public static NativeObjectArray<CPedGroup> @Groups { get => new NativeObjectArray<CPedGroup>(new IntPtr(0xC09920),8,724); }
    public static int @AddGroup() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3296 >(3296)(); return __sdkResult; }
    public static bool @AreInSameGroup(CPed? @ped1,CPed? @ped2) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3297 >(3297)(@ped1?.Pointer ?? IntPtr.Zero,@ped2?.Pointer ?? IntPtr.Zero); return __sdkResult != 0; }
    public static void @CleanUpForShutDown() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3298 >(3298)(); }
    public static int @GetGroupId(CPedGroup? @pedgrp) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3299 >(3299)(@pedgrp?.Pointer ?? IntPtr.Zero); return __sdkResult; }
    public static NativePointer<sbyte> @GetPedsGroup(CPed? @ped) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3300 >(3300)(@ped?.Pointer ?? IntPtr.Zero); return new NativePointer<sbyte>(__sdkResult); }
    public static void @Init() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3301 >(3301)(); }
    public static bool @IsGroupLeader(CPed? @ped) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3302 >(3302)(@ped?.Pointer ?? IntPtr.Zero); return __sdkResult != 0; }
    public static sbyte @IsInPlayersGroup(CPed? @a1) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3303 >(3303)(@a1?.Pointer ?? IntPtr.Zero); return __sdkResult; }
    public static void @Process() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3304 >(3304)(); }
    public static void @RegisterKillByPlayer() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3305 >(3305)(); }
    public static void @RemoveAllFollowersFromGroup(int @groupID) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3306 >(3306)(@groupID); }
    public static void @RemoveGroup(int @groupID) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3307 >(3307)(@groupID); }
}
