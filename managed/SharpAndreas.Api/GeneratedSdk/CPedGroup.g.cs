// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CPedGroup : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=724;
    public CPedGroup(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("field_0")]
    public int @Field0 { get => SdkMemory.Read<int >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("m_bMembersEnterLeadersVehicle")]
    public bool @MembersEnterLeadersVehicle { get => SdkMemory.Read<bool >(Pointer+4); set { SdkMemory.Write(Pointer+4,value); } }
    [NativeMember("m_groupMembership")]
    public CPedGroupMembership @GroupMembership { get => new CPedGroupMembership(Pointer+8); set { SdkMemory.Copy(value.Pointer,Pointer+8,40); } }
    [NativeMember("m_fSeparationRange")]
    public float @SeparationRange { get => SdkMemory.Read<float >(Pointer+48); set { SdkMemory.Write(Pointer+48,value); } }
    [NativeMember("m_groupIntelligence")]
    public CPedGroupIntelligence @GroupIntelligence { get => new CPedGroupIntelligence(Pointer+52); set { SdkMemory.Copy(value.Pointer,Pointer+52,672); } }
    public float @FindDistanceToFurthestMember() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3282 >(3282)(Pointer); return __sdkResult; }
    public float @FindDistanceToNearestMember(NativePointer<IntPtr> @ppOutNearestMember) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3283 >(3283)(Pointer,@ppOutNearestMember.Pointer); return __sdkResult; }
    public void @Flush() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3284 >(3284)(Pointer); }
    public CPed? @GetClosestGroupPed(CPed? @ped,NativePointer<float> @pOutDistance) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3285 >(3285)(Pointer,@ped?.Pointer ?? IntPtr.Zero,@pOutDistance.Pointer); return __sdkResult == IntPtr.Zero ? null : new CPed(__sdkResult); }
    public bool @IsAnyoneUsingCar(CVehicle? @vehicle) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3286 >(3286)(Pointer,@vehicle?.Pointer ?? IntPtr.Zero); return __sdkResult != 0; }
    public void @PlayerGaveCommand_Attack(CPed? @playerPed,CPed? @ped) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3287 >(3287)(Pointer,@playerPed?.Pointer ?? IntPtr.Zero,@ped?.Pointer ?? IntPtr.Zero); }
    public void @PlayerGaveCommand_Gather(CPed? @ped) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3288 >(3288)(Pointer,@ped?.Pointer ?? IntPtr.Zero); }
    public void @Process() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3289 >(3289)(Pointer); }
    public void @RemoveAllFollowers() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3290 >(3290)(Pointer); }
    public void @Teleport(CVector? @Pos) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3291 >(3291)(Pointer,@Pos?.Pointer ?? IntPtr.Zero); }
}
