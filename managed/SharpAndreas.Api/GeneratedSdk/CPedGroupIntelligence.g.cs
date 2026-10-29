// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CPedGroupIntelligence : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=672;
    public CPedGroupIntelligence(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_pPedGroup")]
    public CPedGroup? @PedGroup { get => SdkMemory.Read<IntPtr>(Pointer+0) == IntPtr.Zero ? null : new CPedGroup(SdkMemory.Read<IntPtr>(Pointer+0)); set { SdkMemory.Write(Pointer+0,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_pGroupEventHandler")]
    public CGroupEventHandler? @GroupEventHandler { get => SdkMemory.Read<IntPtr>(Pointer+4) == IntPtr.Zero ? null : new CGroupEventHandler(SdkMemory.Read<IntPtr>(Pointer+4)); set { SdkMemory.Write(Pointer+4,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_pEventGroupEvent")]
    public int @EventGroupEvent { get => SdkMemory.Read<int >(Pointer+8); set { SdkMemory.Write(Pointer+8,value); } }
    [NativeMember("m_groupTasks")]
    public NativeObjectArray<CPedTaskPair> @GroupTasks { get => new NativeObjectArray<CPedTaskPair>(Pointer+12,53,12); }
    [NativeMember("gap288")]
    public NativeArray<byte> @Gap288 { get => new NativeArray<byte>(Pointer+648,4); }
    [NativeMember("m_pPedGroupDefaultTaskAllocator")]
    public CPedGroupDefaultTaskAllocator? @PedGroupDefaultTaskAllocator { get => SdkMemory.Read<IntPtr>(Pointer+652) == IntPtr.Zero ? null : new CPedGroupDefaultTaskAllocator(SdkMemory.Read<IntPtr>(Pointer+652)); set { SdkMemory.Write(Pointer+652,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_pPrimaryTaskAllocator")]
    public CTaskAllocator? @PrimaryTaskAllocator { get => SdkMemory.Read<IntPtr>(Pointer+656) == IntPtr.Zero ? null : new CTaskAllocator(SdkMemory.Read<IntPtr>(Pointer+656)); set { SdkMemory.Write(Pointer+656,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_pEventResponseTaskAllocator")]
    public CTaskAllocator? @EventResponseTaskAllocator { get => SdkMemory.Read<IntPtr>(Pointer+660) == IntPtr.Zero ? null : new CTaskAllocator(SdkMemory.Read<IntPtr>(Pointer+660)); set { SdkMemory.Write(Pointer+660,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_dwDecisionMakerType")]
    public int @DecisionMakerType { get => SdkMemory.Read<int >(Pointer+664); set { SdkMemory.Write(Pointer+664,value); } }
    [NativeMember("field_29C")]
    public sbyte @Field29C { get => SdkMemory.Read<sbyte >(Pointer+668); set { SdkMemory.Write(Pointer+668,value); } }
    public bool @AddEvent(CEvent? @event) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3254 >(3254)(Pointer,@event?.Pointer ?? IntPtr.Zero); return __sdkResult != 0; }
    public void @ComputeDefaultTasks(CPed? @ped) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3255 >(3255)(Pointer,@ped?.Pointer ?? IntPtr.Zero); }
    public NativePointer<IntPtr> @ComputeEventResponseTasks() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3256 >(3256)(Pointer); return new NativePointer<IntPtr>(__sdkResult); }
    public void @ComputeScriptCommandTasks() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3257 >(3257)(Pointer); }
    public void @FlushTasks(CPedTaskPair? @taskpair,CPed? @ped) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3258 >(3258)(Pointer,@taskpair?.Pointer ?? IntPtr.Zero,@ped?.Pointer ?? IntPtr.Zero); }
    public CTask? @GetTask(CPed? @ped,CPedTaskPair? @taskpair) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3259 >(3259)(Pointer,@ped?.Pointer ?? IntPtr.Zero,@taskpair?.Pointer ?? IntPtr.Zero); return __sdkResult == IntPtr.Zero ? null : new CTask(__sdkResult); }
    public CTask? @GetTaskDefault(CPed? @ped) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3260 >(3260)(Pointer,@ped?.Pointer ?? IntPtr.Zero); return __sdkResult == IntPtr.Zero ? null : new CTask(__sdkResult); }
    public CTask? @GetTaskScriptCommand(CPed? @ped) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3261 >(3261)(Pointer,@ped?.Pointer ?? IntPtr.Zero); return __sdkResult == IntPtr.Zero ? null : new CTask(__sdkResult); }
    public CTask? @GetTaskSecondary(CPed? @ped) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3262 >(3262)(Pointer,@ped?.Pointer ?? IntPtr.Zero); return __sdkResult == IntPtr.Zero ? null : new CTask(__sdkResult); }
    public int @GetTaskSecondarySlot(CPed? @ped) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3263 >(3263)(Pointer,@ped?.Pointer ?? IntPtr.Zero); return __sdkResult; }
    public bool @IsCurrentEventValid() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3264 >(3264)(Pointer); return __sdkResult != 0; }
    public bool @IsGroupResponding() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3265 >(3265)(Pointer); return __sdkResult != 0; }
    public void @Process() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3266 >(3266)(Pointer); }
    public void @ProcessIgnorePlayerGroup() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3267 >(3267)(Pointer); }
    public void @ReportAllBarScriptTasksFinished() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3268 >(3268)(Pointer); }
    public void @ReportAllTasksFinished(CPedTaskPair? @taskpair) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3269 >(3269)(Pointer,@taskpair?.Pointer ?? IntPtr.Zero); }
    public void @ReportAllTasksFinished() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3270 >(3270)(Pointer); }
    public bool @ReportFinishedTask(CPed? @ped,CTask? @task,CPedTaskPair? @taskpair) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3271 >(3271)(Pointer,@ped?.Pointer ?? IntPtr.Zero,@task?.Pointer ?? IntPtr.Zero,@taskpair?.Pointer ?? IntPtr.Zero); return __sdkResult != 0; }
    public bool @ReportFinishedTask(CPed? @ped,CTask? @task) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3272 >(3272)(Pointer,@ped?.Pointer ?? IntPtr.Zero,@task?.Pointer ?? IntPtr.Zero); return __sdkResult != 0; }
    public void @SetDefaultTask(CPed? @ped,CTask? @task) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3273 >(3273)(Pointer,@ped?.Pointer ?? IntPtr.Zero,@task?.Pointer ?? IntPtr.Zero); }
    public void @SetDefaultTaskAllocator(CPedGroupDefaultTaskAllocator? @PedGroupDefaultTaskAllocator) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3274 >(3274)(Pointer,@PedGroupDefaultTaskAllocator?.Pointer ?? IntPtr.Zero); }
    public void @SetDefaultTaskAllocatorType(int @nPedGroupTaskAllocator) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3275 >(3275)(Pointer,@nPedGroupTaskAllocator); }
    public void @SetEventResponseTask(CPed? @ped,bool @arg3,CTask? @task1,bool @arg5,CTask? @task2,int @arg7) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3276 >(3276)(Pointer,@ped?.Pointer ?? IntPtr.Zero,(@arg3 ? 1 : 0),@task1?.Pointer ?? IntPtr.Zero,(@arg5 ? 1 : 0),@task2?.Pointer ?? IntPtr.Zero,@arg7); }
    public int @SetEventResponseTaskAllocator(int @a2) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3277 >(3277)(Pointer,@a2); return __sdkResult; }
    public int @SetGroupDecisionMakerType(int @a2) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3278 >(3278)(Pointer,@a2); return __sdkResult; }
    public void @SetPrimaryTaskAllocator(CTaskAllocator? @taskAllocator) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3279 >(3279)(Pointer,@taskAllocator?.Pointer ?? IntPtr.Zero); }
    public void @SetScriptCommandTask(CPed? @ped,CTask? @task) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3280 >(3280)(Pointer,@ped?.Pointer ?? IntPtr.Zero,@task?.Pointer ?? IntPtr.Zero); }
    public void @SetTask(CPed? @ped,CTask? @task,CPedTaskPair? @taskpair,int @arg5,bool @arg6) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3281 >(3281)(Pointer,@ped?.Pointer ?? IntPtr.Zero,@task?.Pointer ?? IntPtr.Zero,@taskpair?.Pointer ?? IntPtr.Zero,@arg5,(@arg6 ? 1 : 0)); }
}
