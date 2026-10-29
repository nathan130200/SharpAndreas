// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CBankSlotInfo : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=4820;
    public CBankSlotInfo(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_nOffset")]
    public int @Offset { get => SdkMemory.Read<int >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("m_nLength")]
    public int @Length { get => SdkMemory.Read<int >(Pointer+4); set { SdkMemory.Write(Pointer+4,value); } }
    [NativeMember("field_8")]
    public int @Field8 { get => SdkMemory.Read<int >(Pointer+8); set { SdkMemory.Write(Pointer+8,value); } }
    [NativeMember("field_C")]
    public int @FieldC { get => SdkMemory.Read<int >(Pointer+12); set { SdkMemory.Write(Pointer+12,value); } }
    [NativeMember("m_nBankId")]
    public short @BankId { get => SdkMemory.Read<short >(Pointer+16); set { SdkMemory.Write(Pointer+16,value); } }
    [NativeMember("m_nNumSoundInfo")]
    public short @CountSoundInfo { get => SdkMemory.Read<short >(Pointer+18); set { SdkMemory.Write(Pointer+18,value); } }
    [NativeMember("m_aSoundsHeader")]
    public NativeObjectArray<CBankHeader> @SoundsHeader { get => new NativeObjectArray<CBankHeader>(Pointer+20,400,12); }
}
