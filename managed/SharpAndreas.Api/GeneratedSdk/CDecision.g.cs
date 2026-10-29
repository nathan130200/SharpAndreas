// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CDecision : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=60;
    public CDecision(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("RESPONSE_COUNT")]
    public static int @RESPONSECOUNT { get => SdkMemory.Read<int >(SdkBindings.Address(4651)); }
    [NativeMember("task")]
    public NativeArray<eTaskType> @Task { get => new NativeArray<eTaskType>(Pointer+0,6); }
    [NativeMember("chances")]
    public NativeObjectArray<DecisionChances> @Chances { get => new NativeObjectArray<DecisionChances>(Pointer+24,6,4); }
    [NativeMember("context")]
    public NativeObjectArray<DecisionContext> @Context { get => new NativeObjectArray<DecisionContext>(Pointer+48,6,2); }
    public void @InitializeAt() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1258 >(1258)(Pointer); }
}
