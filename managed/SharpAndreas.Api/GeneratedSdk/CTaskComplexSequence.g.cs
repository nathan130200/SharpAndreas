// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CTaskComplexSequence : CTaskComplex
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=12;
    public CTaskComplexSequence(System.IntPtr pointer) : base(pointer) {}
    public void @InitializeAt() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4029 >(4029)(Pointer); }
    public void @DestroyNative() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4030 >(4030)(Pointer); }
    public bool @AddTask(CTask? @pTask) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4031 >(4031)(Pointer,@pTask?.Pointer ?? IntPtr.Zero); return __sdkResult != 0; }
}
