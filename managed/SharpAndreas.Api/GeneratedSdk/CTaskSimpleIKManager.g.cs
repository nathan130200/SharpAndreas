// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CTaskSimpleIKManager : CTaskSimple
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=28;
    public CTaskSimpleIKManager(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_pIKChainTasks")]
    public NativeArray<IntPtr> @IKChainTasks { get => new NativeArray<IntPtr>(Pointer+8,4); }
    [NativeMember("m_bAborting")]
    public bool @Aborting { get => SdkMemory.Read<bool >(Pointer+24); set { SdkMemory.Write(Pointer+24,value); } }
    public void @InitializeAt() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4047 >(4047)(Pointer); }
}
