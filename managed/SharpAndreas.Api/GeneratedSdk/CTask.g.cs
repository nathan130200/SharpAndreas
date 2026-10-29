// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CTask : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=8;
    public CTask(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_pParentTask")]
    public CTask? @ParentTask { get => SdkMemory.Read<IntPtr>(Pointer+4) == IntPtr.Zero ? null : new CTask(SdkMemory.Read<IntPtr>(Pointer+4)); set { SdkMemory.Write(Pointer+4,value?.Pointer ?? IntPtr.Zero); } }
    public static NativePointer<IntPtr> @AllocateNative(uint @size) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1268 >(1268)(@size); return new NativePointer<IntPtr>(__sdkResult); }
    public static void @FreeNative(NativePointer<IntPtr> @object) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1269 >(1269)(@object.Pointer); }
    public void @DestroyNative() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1270 >(1270)(Pointer); }
    public CTask? @Clone() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1271 >(1271)(Pointer); return __sdkResult == IntPtr.Zero ? null : new CTask(__sdkResult); }
    public CTask? @GetSubTask() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1272 >(1272)(Pointer); return __sdkResult == IntPtr.Zero ? null : new CTask(__sdkResult); }
    public bool @IsSimple() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1273 >(1273)(Pointer); return __sdkResult != 0; }
    public eTaskType @GetId() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1274 >(1274)(Pointer); return (eTaskType)__sdkResult; }
    public void @StopTimer(CEvent? @_event) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1275 >(1275)(Pointer,@_event?.Pointer ?? IntPtr.Zero); }
    public bool @MakeAbortable(CPed? @ped,eAbortPriority @priority,CEvent? @_event) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1276 >(1276)(Pointer,@ped?.Pointer ?? IntPtr.Zero,(int)@priority,@_event?.Pointer ?? IntPtr.Zero); return __sdkResult != 0; }
}
