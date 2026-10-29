// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CPedList : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=124;
    public CPedList(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_nCount")]
    public int @Count { get => SdkMemory.Read<int >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("m_apPeds")]
    public NativeArray<IntPtr> @Peds { get => new NativeArray<IntPtr>(Pointer+4,30); }
    public void @BuildListFromGroup_NoLeader(CPedGroupMembership? @pedGroupMemberShip) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2720 >(2720)(Pointer,@pedGroupMemberShip?.Pointer ?? IntPtr.Zero); }
    public void @BuildListFromGroup_NotInCar_NoLeader(CPedGroupMembership? @pedGroupMembership) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2721 >(2721)(Pointer,@pedGroupMembership?.Pointer ?? IntPtr.Zero); }
    public void @BuildListOfPedsOfPedType(int @pedtype) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2722 >(2722)(Pointer,@pedtype); }
    public void @Empty() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2723 >(2723)(Pointer); }
    public void @ExtractPedsWithGuns(CPedList? @pedlist) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2724 >(2724)(Pointer,@pedlist?.Pointer ?? IntPtr.Zero); }
    public void @FillUpHoles() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2725 >(2725)(Pointer); }
    public void @RemovePedsAttackingPedType(int @pedtype) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2726 >(2726)(Pointer,@pedtype); }
    public void @RemovePedsThatDontListenToPlayer() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2727 >(2727)(Pointer); }
}
