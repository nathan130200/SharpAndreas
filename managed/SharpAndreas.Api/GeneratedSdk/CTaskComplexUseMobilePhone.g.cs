// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CTaskComplexUseMobilePhone : CTaskComplex
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=32;
    public CTaskComplexUseMobilePhone(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_nDuration")]
    public int @Duration { get => SdkMemory.Read<int >(Pointer+12); set { SdkMemory.Write(Pointer+12,value); } }
    [NativeMember("m_timer")]
    public CTaskTimer @Timer { get => new CTaskTimer(Pointer+16); set { SdkMemory.Copy(value.Pointer,Pointer+16,12); } }
    [NativeMember("m_bIsAborting")]
    public bool @IsAborting { get => SdkMemory.Read<bool >(Pointer+28); set { SdkMemory.Write(Pointer+28,value); } }
    [NativeMember("m_bQuit")]
    public bool @Quit { get => SdkMemory.Read<bool >(Pointer+29); set { SdkMemory.Write(Pointer+29,value); } }
    public void @InitializeAt(int @nDuration) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4034 >(4034)(Pointer,@nDuration); }
}
