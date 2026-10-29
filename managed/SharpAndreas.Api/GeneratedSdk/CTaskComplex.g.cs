// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CTaskComplex : CTask
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=12;
    public CTaskComplex(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_pSubTask")]
    public CTask? @SubTask { get => SdkMemory.Read<IntPtr>(Pointer+8) == IntPtr.Zero ? null : new CTask(SdkMemory.Read<IntPtr>(Pointer+8)); set { SdkMemory.Write(Pointer+8,value?.Pointer ?? IntPtr.Zero); } }
    public void @InitializeAt() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3997 >(3997)(Pointer); }
    public void @SetSubTask(CTask? @subTask) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3998 >(3998)(Pointer,@subTask?.Pointer ?? IntPtr.Zero); }
    public CTask? @CreateNextSubTask(CPed? @ped) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3999 >(3999)(Pointer,@ped?.Pointer ?? IntPtr.Zero); return __sdkResult == IntPtr.Zero ? null : new CTask(__sdkResult); }
    public CTask? @CreateFirstSubTask(CPed? @ped) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4000 >(4000)(Pointer,@ped?.Pointer ?? IntPtr.Zero); return __sdkResult == IntPtr.Zero ? null : new CTask(__sdkResult); }
    public CTask? @ControlSubTask(CPed? @ped) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4001 >(4001)(Pointer,@ped?.Pointer ?? IntPtr.Zero); return __sdkResult == IntPtr.Zero ? null : new CTask(__sdkResult); }
}
