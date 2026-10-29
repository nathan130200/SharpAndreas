// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CDecisionMakerTypes : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=61888;
    public CDecisionMakerTypes(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("NUM_TYPES")]
    public static uint @CountTYPES { get => SdkMemory.Read<uint >(SdkBindings.Address(4652)); }
    [NativeMember("ScriptReferenceIndex")]
    public static NativeArray<ushort> @ScriptReferenceIndex { get => new NativeArray<ushort>(new IntPtr(0xC0AFF4),20); }
    [NativeMember("m_IsActive")]
    public static NativeArray<bool> @IsActive { get => new NativeArray<bool>(new IntPtr(0xC0B01C),20); }
    [NativeMember("m_NoOfDecisionMakers")]
    public int @NoOfDecisionMakers { get => SdkMemory.Read<int >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("m_DecisionMakers")]
    public NativeObjectArray<CDecisionMaker> @DecisionMakers { get => new NativeObjectArray<CDecisionMaker>(Pointer+4,20,2460); }
    [NativeMember("m_EventIndices")]
    public NativeArray<int> @EventIndices { get => new NativeArray<int>(Pointer+49204,96); }
    [NativeMember("m_DefaultRandomPedDecisionMaker")]
    public CDecisionMaker @DefaultRandomPedDecisionMaker { get => new CDecisionMaker(Pointer+49588); set { SdkMemory.Copy(value.Pointer,Pointer+49588,2460); } }
    [NativeMember("m_DefaultMissionPedDecisionMaker")]
    public CDecisionMaker @DefaultMissionPedDecisionMaker { get => new CDecisionMaker(Pointer+52048); set { SdkMemory.Copy(value.Pointer,Pointer+52048,2460); } }
    [NativeMember("m_DefaultPlayerPedDecisionMaker")]
    public CDecisionMaker @DefaultPlayerPedDecisionMaker { get => new CDecisionMaker(Pointer+54508); set { SdkMemory.Copy(value.Pointer,Pointer+54508,2460); } }
    [NativeMember("m_DefaultRandomPedGroupDecisionMaker")]
    public CDecisionMaker @DefaultRandomPedGroupDecisionMaker { get => new CDecisionMaker(Pointer+56968); set { SdkMemory.Copy(value.Pointer,Pointer+56968,2460); } }
    [NativeMember("m_DefaultMissionPedGroupDecisionMaker")]
    public CDecisionMaker @DefaultMissionPedGroupDecisionMaker { get => new CDecisionMaker(Pointer+59428); set { SdkMemory.Copy(value.Pointer,Pointer+59428,2460); } }
    public static CDecisionMakerTypes? @GetInstance() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1260 >(1260)(); return __sdkResult == IntPtr.Zero ? null : new CDecisionMakerTypes(__sdkResult); }
    public eDecisionMakerType @AddDecisionMaker(CDecisionMaker? @templateDm,eDecisionMakerType @dm,bool @bDecisionMakerForMission) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1261 >(1261)(Pointer,@templateDm?.Pointer ?? IntPtr.Zero,(int)@dm,(@bDecisionMakerForMission ? 1 : 0)); return (eDecisionMakerType)__sdkResult; }
    public void @RemoveDecisionMaker(eDecisionMakerType @dm) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1262 >(1262)(Pointer,(int)@dm); }
    public void @AddEventResponse(eDecisionMakerType @dm,eEventType @eventType,eTaskType @taskId,DecisionChances @chances,DecisionContext @context) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1263 >(1263)(Pointer,(int)@dm,(int)@eventType,(int)@taskId,@chances.Pointer,@context.Pointer); }
    public void @FlushDecisionMakerEventResponse(eDecisionMakerType @dm,eEventType @eventId) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1264 >(1264)(Pointer,(int)@dm,(int)@eventId); }
    public eTaskType @MakeDecision(CPedGroup? @pedGroup,eEventType @eventType,int @eventSourceType,bool @bIsPedInVehicle,eTaskType @taskId1,eTaskType @taskId2,eTaskType @taskId3,eTaskType @taskId4) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1265 >(1265)(Pointer,@pedGroup?.Pointer ?? IntPtr.Zero,(int)@eventType,@eventSourceType,(@bIsPedInVehicle ? 1 : 0),(int)@taskId1,(int)@taskId2,(int)@taskId3,(int)@taskId4); return (eTaskType)__sdkResult; }
    public void @MakeDecision(CPed? @ped,eEventType @eventType,int @eventSourceType,bool @bIsPedInVehicle,eTaskType @taskTypeToAvoid1,eTaskType @taskTypeToAvoid2,eTaskType @taskTypeToAvoid3,eTaskType @taskTypeToSeek,bool @bUseInGroupDecisionMaker,NativePointer<short> @taskType,NativePointer<short> @facialTaskType) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1266 >(1266)(Pointer,@ped?.Pointer ?? IntPtr.Zero,(int)@eventType,@eventSourceType,(@bIsPedInVehicle ? 1 : 0),(int)@taskTypeToAvoid1,(int)@taskTypeToAvoid2,(int)@taskTypeToAvoid3,(int)@taskTypeToSeek,(@bUseInGroupDecisionMaker ? 1 : 0),@taskType.Pointer,@facialTaskType.Pointer); }
    public void @LoadEventIndices() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1267 >(1267)(Pointer); }
}
