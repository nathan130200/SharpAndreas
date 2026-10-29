// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class COnscreenCounterEntry : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=68;
    public COnscreenCounterEntry(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_nVarId")]
    public uint @VariableId { get => SdkMemory.Read<uint >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("m_nMaxVarValue")]
    public uint @MaxVariableValue { get => SdkMemory.Read<uint >(Pointer+4); set { SdkMemory.Write(Pointer+4,value); } }
    [NativeMember("m_szDescriptionTextKey")]
    public NativeArray<sbyte> @DescriptionTextKey { get => new NativeArray<sbyte>(Pointer+8,10); }
    [NativeMember("m_nType")]
    public ushort @Type { get => SdkMemory.Read<ushort >(Pointer+18); set { SdkMemory.Write(Pointer+18,value); } }
    [NativeMember("m_szDisplayedText")]
    public NativeArray<sbyte> @DisplayedText { get => new NativeArray<sbyte>(Pointer+20,42); }
    [NativeMember("m_bEnabled")]
    public bool @Enabled { get => SdkMemory.Read<bool >(Pointer+62); set { SdkMemory.Write(Pointer+62,value); } }
    [NativeMember("m_bFlashWhenFirstDisplayed")]
    public bool @FlashWhenFirstDisplayed { get => SdkMemory.Read<bool >(Pointer+63); set { SdkMemory.Write(Pointer+63,value); } }
    [NativeMember("m_nColourId")]
    public byte @ColorId { get => SdkMemory.Read<byte >(Pointer+64); set { SdkMemory.Write(Pointer+64,value); } }
    public void @ProcessForDisplayCounter(int @type) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3231 >(3231)(Pointer,@type); }
    public void @SetColourID(byte @ColourID) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3232 >(3232)(Pointer,@ColourID); }
}
