// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CPedGroupMembership : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=40;
    public CPedGroupMembership(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_pPedGroup")]
    public CPedGroup? @PedGroup { get => SdkMemory.Read<IntPtr>(Pointer+0) == IntPtr.Zero ? null : new CPedGroup(SdkMemory.Read<IntPtr>(Pointer+0)); set { SdkMemory.Write(Pointer+0,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_apMembers")]
    public NativeArray<IntPtr> @Members { get => new NativeArray<IntPtr>(Pointer+4,8); }
    [NativeMember("m_fMaxSeparation")]
    public float @MaxSeparation { get => SdkMemory.Read<float >(Pointer+36); set { SdkMemory.Write(Pointer+36,value); } }
    [NativeMember("ms_fMaxSeparation")]
    public static float @MaxSeparationValue { get => SdkMemory.Read<float >(new IntPtr(0x86C6BC)); }
    [NativeMember("ms_fPlayerGroupMaxSeparation")]
    public static float @PlayerGroupMaxSeparation { get => SdkMemory.Read<float >(new IntPtr(0x86C6C0)); }
    public void @AddFollower(CPed? @ped) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2702 >(2702)(Pointer,@ped?.Pointer ?? IntPtr.Zero); }
    public void @AddMember(CPed? @member,int @memberID) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2703 >(2703)(Pointer,@member?.Pointer ?? IntPtr.Zero,@memberID); }
    public void @AppointNewLeader() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2704 >(2704)(Pointer); }
    public int @CountMembers() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2705 >(2705)(Pointer); return __sdkResult; }
    public int @CountMembersExcludingLeader() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2706 >(2706)(Pointer); return __sdkResult; }
    public void @Flush() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2707 >(2707)(Pointer); }
    public void @From(CPedGroupMembership? @obj) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2708 >(2708)(Pointer,@obj?.Pointer ?? IntPtr.Zero); }
    public CPed? @GetLeader() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2709 >(2709)(Pointer); return __sdkResult == IntPtr.Zero ? null : new CPed(__sdkResult); }
    public CPed? @GetMember(int @memberId) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2710 >(2710)(Pointer,@memberId); return __sdkResult == IntPtr.Zero ? null : new CPed(__sdkResult); }
    public bool @IsFollower(CPed? @ped) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2711 >(2711)(Pointer,@ped?.Pointer ?? IntPtr.Zero); return __sdkResult != 0; }
    public bool @IsLeader(CPed? @ped) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2712 >(2712)(Pointer,@ped?.Pointer ?? IntPtr.Zero); return __sdkResult != 0; }
    public bool @IsMember(CPed? @ped) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2713 >(2713)(Pointer,@ped?.Pointer ?? IntPtr.Zero); return __sdkResult != 0; }
    public void @Process() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2714 >(2714)(Pointer); }
    public void @RemoveAllFollowers(bool @bCreatedByGameOnly) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2715 >(2715)(Pointer,(@bCreatedByGameOnly ? 1 : 0)); }
    public void @RemoveMember(int @memberID) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2716 >(2716)(Pointer,@memberID); }
    public sbyte @RemoveNFollowers(int @count) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2717 >(2717)(Pointer,@count); return __sdkResult; }
    public void @SetLeader(CPed? @ped) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2718 >(2718)(Pointer,@ped?.Pointer ?? IntPtr.Zero); }
    public static int @GetObjectForPedToHold() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2719 >(2719)(); return __sdkResult; }
}
