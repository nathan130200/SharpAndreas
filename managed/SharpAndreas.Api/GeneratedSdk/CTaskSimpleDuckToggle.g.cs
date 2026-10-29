// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CTaskSimpleDuckToggle : CTaskSimple
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=12;
    public CTaskSimpleDuckToggle(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_nToggleType")]
    public int @ToggleType { get => SdkMemory.Read<int >(Pointer+8); set { SdkMemory.Write(Pointer+8,value); } }
    public void @InitializeAt(int @toggleType) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4043 >(4043)(Pointer,@toggleType); }
}
