// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CAEMP3BankLoader : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=1764;
    public CAEMP3BankLoader(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_pBankSlotsInfos")]
    public CBankSlotInfo? @BankSlotsInfos { get => SdkMemory.Read<IntPtr>(Pointer+0) == IntPtr.Zero ? null : new CBankSlotInfo(SdkMemory.Read<IntPtr>(Pointer+0)); set { SdkMemory.Write(Pointer+0,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_pBankLkups")]
    public CBankLkup? @BankLkups { get => SdkMemory.Read<IntPtr>(Pointer+4) == IntPtr.Zero ? null : new CBankLkup(SdkMemory.Read<IntPtr>(Pointer+4)); set { SdkMemory.Write(Pointer+4,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_pPakFileName")]
    public NativePointer<IntPtr> @PakFileName { get => new NativePointer<IntPtr>(SdkMemory.Read<IntPtr>(Pointer+8)); set { SdkMemory.Write(Pointer+8,value.Pointer); } }
    [NativeMember("m_nNumBankSlotsInfos")]
    public short @CountBankSlotsInfos { get => SdkMemory.Read<short >(Pointer+12); set { SdkMemory.Write(Pointer+12,value); } }
    [NativeMember("m_nNumBankLkup")]
    public short @CountBankLkup { get => SdkMemory.Read<short >(Pointer+14); set { SdkMemory.Write(Pointer+14,value); } }
    [NativeMember("m_nNumPakFiles")]
    public short @CountPakFiles { get => SdkMemory.Read<short >(Pointer+16); set { SdkMemory.Write(Pointer+16,value); } }
    [NativeMember("__pad1")]
    public short @Pad1 { get => SdkMemory.Read<short >(Pointer+18); set { SdkMemory.Write(Pointer+18,value); } }
    [NativeMember("m_bAudioFileInfoInitialized")]
    public byte @AudioFileInfoInitialized { get => SdkMemory.Read<byte >(Pointer+20); set { SdkMemory.Write(Pointer+20,value); } }
    [NativeMember("__pad2")]
    public NativeArray<sbyte> @Pad2 { get => new NativeArray<sbyte>(Pointer+21,3); }
    [NativeMember("m_nBankSlotsSize")]
    public int @BankSlotsSize { get => SdkMemory.Read<int >(Pointer+24); set { SdkMemory.Write(Pointer+24,value); } }
    [NativeMember("m_pBankSlots")]
    public int @BankSlots { get => SdkMemory.Read<int >(Pointer+28); set { SdkMemory.Write(Pointer+28,value); } }
    [NativeMember("m_pPakFilesStreamHandles")]
    public NativePointer<int> @PakFilesStreamHandles { get => new NativePointer<int>(SdkMemory.Read<IntPtr>(Pointer+32)); set { SdkMemory.Write(Pointer+32,value.Pointer); } }
    [NativeMember("m_aBankSlotBankAssignment")]
    public NativeObjectArray<CBankSlotBankAssignment> @BankSlotBankAssignment { get => new NativeObjectArray<CBankSlotBankAssignment>(Pointer+36,50,32); }
    [NativeMember("field_664")]
    public short @Field664 { get => SdkMemory.Read<short >(Pointer+1636); set { SdkMemory.Write(Pointer+1636,value); } }
    [NativeMember("field_666")]
    public short @Field666 { get => SdkMemory.Read<short >(Pointer+1638); set { SdkMemory.Write(Pointer+1638,value); } }
    [NativeMember("m_nNumBanksAssigned")]
    public short @CountBanksAssigned { get => SdkMemory.Read<short >(Pointer+1640); set { SdkMemory.Write(Pointer+1640,value); } }
    [NativeMember("m_nStreamNum")]
    public ushort @StreamCount { get => SdkMemory.Read<ushort >(Pointer+1642); set { SdkMemory.Write(Pointer+1642,value); } }
    [NativeMember("m_nCurrentSfxInBankSlot")]
    public NativeArray<short> @CurrentSfxInBankSlot { get => new NativeArray<short>(Pointer+1644,60); }
}
