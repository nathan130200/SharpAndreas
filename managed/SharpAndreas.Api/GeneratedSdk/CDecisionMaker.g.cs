// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CDecisionMaker : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=2460;
    public CDecisionMaker(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_decision")]
    public NativeObjectArray<CDecision> @Decision { get => new NativeObjectArray<CDecision>(Pointer+0,41,60); }
    public void @InitializeAt() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1259 >(1259)(Pointer); }
}
