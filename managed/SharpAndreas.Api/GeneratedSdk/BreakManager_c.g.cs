// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class BreakManager_c : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=2048;
    public BreakManager_c(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_breakObjects")]
    public NativeObjectArray<BreakObject_c> @BreakObjects { get => new NativeObjectArray<BreakObject_c>(Pointer+0,64,32); }
    public bool @Init() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D93 >(93)(Pointer); return __sdkResult != 0; }
    public void @Exit() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D94 >(94)(Pointer); }
    public void @Render(bool @renderAlphas) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D95 >(95)(Pointer,(@renderAlphas ? 1 : 0)); }
    public void @ResetAll() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D96 >(96)(Pointer); }
    public void @Update(float @timeStep) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D97 >(97)(Pointer,@timeStep); }
}
