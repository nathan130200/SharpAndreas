// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CTaskTimer : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=12;
    public CTaskTimer(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_nStartTime")]
    public int @StartTime { get => SdkMemory.Read<int >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("m_nInterval")]
    public int @Interval { get => SdkMemory.Read<int >(Pointer+4); set { SdkMemory.Write(Pointer+4,value); } }
    [NativeMember("m_bStarted")]
    public bool @Started { get => SdkMemory.Read<bool >(Pointer+8); set { SdkMemory.Write(Pointer+8,value); } }
    [NativeMember("m_bStopped")]
    public bool @Stopped { get => SdkMemory.Read<bool >(Pointer+9); set { SdkMemory.Write(Pointer+9,value); } }
    public void @InitializeAt(int @start,int @interval) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D697 >(697)(Pointer,@start,@interval); }
    public void @InitializeAt() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D698 >(698)(Pointer); }
    public bool @IsOutOfTime() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D699 >(699)(Pointer); return __sdkResult != 0; }
}
