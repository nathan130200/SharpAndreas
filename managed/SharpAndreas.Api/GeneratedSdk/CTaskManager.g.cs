// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CTaskManager : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=48;
    public CTaskManager(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_aPrimaryTasks")]
    public NativeArray<IntPtr> @PrimaryTasks { get => new NativeArray<IntPtr>(Pointer+0,5); }
    [NativeMember("m_aSecondaryTasks")]
    public NativeArray<IntPtr> @SecondaryTasks { get => new NativeArray<IntPtr>(Pointer+20,6); }
    [NativeMember("m_pPed")]
    public CPed? @Ped { get => SdkMemory.Read<IntPtr>(Pointer+44) == IntPtr.Zero ? null : new CPed(SdkMemory.Read<IntPtr>(Pointer+44)); set { SdkMemory.Write(Pointer+44,value?.Pointer ?? IntPtr.Zero); } }
    public void @InitializeAt(CPed? @ped) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1277 >(1277)(Pointer,@ped?.Pointer ?? IntPtr.Zero); }
    public void @DestroyNative() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1278 >(1278)(Pointer); }
    public CTask? @GetActiveTask() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1279 >(1279)(Pointer); return __sdkResult == IntPtr.Zero ? null : new CTask(__sdkResult); }
    public CTask? @FindActiveTaskByType(int @taskType) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1280 >(1280)(Pointer,@taskType); return __sdkResult == IntPtr.Zero ? null : new CTask(__sdkResult); }
    public CTask? @FindTaskByType(int @taskIndex,int @taskType) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1281 >(1281)(Pointer,@taskIndex,@taskType); return __sdkResult == IntPtr.Zero ? null : new CTask(__sdkResult); }
    public CTask? @GetTaskSecondary(int @taskIndex) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1282 >(1282)(Pointer,@taskIndex); return __sdkResult == IntPtr.Zero ? null : new CTask(__sdkResult); }
    public bool @HasTaskSecondary(CTask? @task) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1283 >(1283)(Pointer,@task?.Pointer ?? IntPtr.Zero); return __sdkResult != 0; }
    public void @Flush() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1284 >(1284)(Pointer); }
    public void @FlushImmediately() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1285 >(1285)(Pointer); }
    public void @SetNextSubTask(CTask? @task) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1286 >(1286)(Pointer,@task?.Pointer ?? IntPtr.Zero); }
    public static CTask? @GetSimplestTask(CTask? @task) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1287 >(1287)(@task?.Pointer ?? IntPtr.Zero); return __sdkResult == IntPtr.Zero ? null : new CTask(__sdkResult); }
    public void @StopTimers(CEvent? @_event) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1288 >(1288)(Pointer,@_event?.Pointer ?? IntPtr.Zero); }
    public CTask? @GetSimplestActiveTask() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1289 >(1289)(Pointer); return __sdkResult == IntPtr.Zero ? null : new CTask(__sdkResult); }
    public CTask? @GetSimplestTask(int @taskIndex) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1290 >(1290)(Pointer,@taskIndex); return __sdkResult == IntPtr.Zero ? null : new CTask(__sdkResult); }
    public void @AddSubTasks(CTask? @task) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1291 >(1291)(Pointer,@task?.Pointer ?? IntPtr.Zero); }
    public void @ParentsControlChildren(CTask? @task) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1292 >(1292)(Pointer,@task?.Pointer ?? IntPtr.Zero); }
    public void @SetTask(CTask? @task,int @taskIndex,bool @arg2) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1293 >(1293)(Pointer,@task?.Pointer ?? IntPtr.Zero,@taskIndex,(@arg2 ? 1 : 0)); }
    public void @SetTaskSecondary(CTask? @task,int @taskIndex) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1294 >(1294)(Pointer,@task?.Pointer ?? IntPtr.Zero,@taskIndex); }
    public void @ClearTaskEventResponse() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1295 >(1295)(Pointer); }
    public void @ManageTasks() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1296 >(1296)(Pointer); }
}
