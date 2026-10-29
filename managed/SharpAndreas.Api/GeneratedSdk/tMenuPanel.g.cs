// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class tMenuPanel : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=1048;
    public tMenuPanel(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_anUsedCarColors")]
    public NativeArray<sbyte> @UsedCarColors { get => new NativeArray<sbyte>(Pointer+0,64); }
    [NativeMember("m_nType")]
    public byte @Type { get => SdkMemory.Read<byte >(Pointer+64); set { SdkMemory.Write(Pointer+64,value); } }
    [NativeMember("m_aaacRowTitles")]
    public NativeArray<sbyte> @AaacRowTitles { get => new NativeArray<sbyte>(Pointer+65,480); }
    [NativeMember("m_aadwNumberInRowTitle")]
    public NativeArray<int> @AadwNumberInRowTitle { get => new NativeArray<int>(Pointer+548,48); }
    [NativeMember("m_aadw2ndNumberInRowTitle")]
    public NativeArray<int> @Aadw2ndNumberInRowTitle { get => new NativeArray<int>(Pointer+740,48); }
    [NativeMember("m_aacColumnHeaders")]
    public NativeArray<sbyte> @AacColumnHeaders { get => new NativeArray<sbyte>(Pointer+932,40); }
    [NativeMember("m_acTitle")]
    public NativeArray<sbyte> @AcTitle { get => new NativeArray<sbyte>(Pointer+972,10); }
    [NativeMember("m_abRowSelectable")]
    public NativeArray<bool> @RowSelectable { get => new NativeArray<bool>(Pointer+982,12); }
    [NativeMember("m_abRowAlreadyBought")]
    public NativeArray<bool> @RowAlreadyBought { get => new NativeArray<bool>(Pointer+994,12); }
    [NativeMember("m_anColumnAlignment")]
    public NativeArray<byte> @ColumnAlignment { get => new NativeArray<byte>(Pointer+1006,4); }
    [NativeMember("m_anColumnHeaderAlignment")]
    public NativeArray<byte> @ColumnHeaderAlignment { get => new NativeArray<byte>(Pointer+1010,4); }
    [NativeMember("m_nNumRows")]
    public sbyte @CountRows { get => SdkMemory.Read<sbyte >(Pointer+1014); set { SdkMemory.Write(Pointer+1014,value); } }
    [NativeMember("m_nNumColumns")]
    public sbyte @CountColumns { get => SdkMemory.Read<sbyte >(Pointer+1015); set { SdkMemory.Write(Pointer+1015,value); } }
    [NativeMember("m_abColumnInteractive")]
    public NativeArray<bool> @ColumnInteractive { get => new NativeArray<bool>(Pointer+1016,4); }
    [NativeMember("m_afColumnWidth")]
    public NativeArray<float> @ColumnWidth { get => new NativeArray<float>(Pointer+1020,4); }
    [NativeMember("m_vPosn")]
    public CVector2D @Position { get => new CVector2D(Pointer+1036); set { SdkMemory.Copy(value.Pointer,Pointer+1036,8); } }
    [NativeMember("m_bColumnBackground")]
    public bool @ColumnBackground { get => SdkMemory.Read<bool >(Pointer+1044); set { SdkMemory.Write(Pointer+1044,value); } }
    [NativeMember("m_nSelectedRow")]
    public sbyte @SelectedRow { get => SdkMemory.Read<sbyte >(Pointer+1045); set { SdkMemory.Write(Pointer+1045,value); } }
    [NativeMember("m_nAcceptedRow")]
    public sbyte @AcceptedRow { get => SdkMemory.Read<sbyte >(Pointer+1046); set { SdkMemory.Write(Pointer+1046,value); } }
}
