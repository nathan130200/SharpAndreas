// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CTaskComplexJump : CTaskComplex
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=20;
    public CTaskComplexJump(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_nType")]
    public uint @Type { get => SdkMemory.Read<uint >(Pointer+12); set { SdkMemory.Write(Pointer+12,value); } }
    [NativeMember("bUnkFlag")]
    public bool @UnkFlag { get => SdkMemory.Read<bool >(Pointer+16); set { SdkMemory.Write(Pointer+16,value); } }
    public void @InitializeAt(uint @jumpType) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4002 >(4002)(Pointer,@jumpType); }
}
