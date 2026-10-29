// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class COnscreenTimerEntry : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=64;
    public COnscreenTimerEntry(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_nVarId")]
    public uint @VariableId { get => SdkMemory.Read<uint >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("m_szDescriptionTextKey")]
    public NativeArray<sbyte> @DescriptionTextKey { get => new NativeArray<sbyte>(Pointer+4,10); }
    [NativeMember("m_szDisplayedText")]
    public NativeArray<sbyte> @DisplayedText { get => new NativeArray<sbyte>(Pointer+14,42); }
    [NativeMember("m_bEnabled")]
    public bool @Enabled { get => SdkMemory.Read<bool >(Pointer+56); set { SdkMemory.Write(Pointer+56,value); } }
    [NativeMember("m_nTimerDirection")]
    public byte @TimerDirection { get => SdkMemory.Read<byte >(Pointer+57); set { SdkMemory.Write(Pointer+57,value); } }
    [NativeMember("m_nClockBeepCountdownSecs")]
    public uint @ClockBeepCountdownSecs { get => SdkMemory.Read<uint >(Pointer+60); set { SdkMemory.Write(Pointer+60,value); } }
    public void @Process() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3233 >(3233)(Pointer); }
    public void @ProcessForDisplayClock() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3234 >(3234)(Pointer); }
}
