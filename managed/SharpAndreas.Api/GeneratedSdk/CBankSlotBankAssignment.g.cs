// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CBankSlotBankAssignment : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=32;
    public CBankSlotBankAssignment(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_pBankSlotInfo")]
    public CBankSlotsInfos? @BankSlotInfo { get => SdkMemory.Read<IntPtr>(Pointer+0) == IntPtr.Zero ? null : new CBankSlotsInfos(SdkMemory.Read<IntPtr>(Pointer+0)); set { SdkMemory.Write(Pointer+0,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_nBankOffset")]
    public int @BankOffset { get => SdkMemory.Read<int >(Pointer+4); set { SdkMemory.Write(Pointer+4,value); } }
    [NativeMember("m_nBankLength")]
    public int @BankLength { get => SdkMemory.Read<int >(Pointer+8); set { SdkMemory.Write(Pointer+8,value); } }
    [NativeMember("m_pStreamOffset")]
    public int @StreamOffset { get => SdkMemory.Read<int >(Pointer+12); set { SdkMemory.Write(Pointer+12,value); } }
    [NativeMember("m_pStreamBuffer")]
    public int @StreamBuffer { get => SdkMemory.Read<int >(Pointer+16); set { SdkMemory.Write(Pointer+16,value); } }
    [NativeMember("m_dwState")]
    public int @State { get => SdkMemory.Read<int >(Pointer+20); set { SdkMemory.Write(Pointer+20,value); } }
    [NativeMember("m_nBankId")]
    public short @BankId { get => SdkMemory.Read<short >(Pointer+24); set { SdkMemory.Write(Pointer+24,value); } }
    [NativeMember("m_nBankSlotId")]
    public short @BankSlotId { get => SdkMemory.Read<short >(Pointer+26); set { SdkMemory.Write(Pointer+26,value); } }
    [NativeMember("m_nNumSounds")]
    public short @CountSounds { get => SdkMemory.Read<short >(Pointer+28); set { SdkMemory.Write(Pointer+28,value); } }
    [NativeMember("m_nPakFileNumber")]
    public sbyte @PakFileNumber { get => SdkMemory.Read<sbyte >(Pointer+30); set { SdkMemory.Write(Pointer+30,value); } }
    [NativeMember("__pad")]
    public sbyte @Pad { get => SdkMemory.Read<sbyte >(Pointer+31); set { SdkMemory.Write(Pointer+31,value); } }
}
