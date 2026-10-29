// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class tMessage : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=48;
    public tMessage(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_pText")]
    public NativePointer<sbyte> @Text { get => new NativePointer<sbyte>(SdkMemory.Read<IntPtr>(Pointer+0)); set { SdkMemory.Write(Pointer+0,value.Pointer); } }
    [NativeMember("m_wFlag")]
    public ushort @Flag { get => SdkMemory.Read<ushort >(Pointer+4); set { SdkMemory.Write(Pointer+4,value); } }
    [NativeMember("m_dwTime")]
    public uint @Time { get => SdkMemory.Read<uint >(Pointer+8); set { SdkMemory.Write(Pointer+8,value); } }
    [NativeMember("m_dwStartTime")]
    public uint @StartTime { get => SdkMemory.Read<uint >(Pointer+12); set { SdkMemory.Write(Pointer+12,value); } }
    [NativeMember("m_dwNumber")]
    public NativeArray<int> @Number { get => new NativeArray<int>(Pointer+16,6); }
    [NativeMember("m_pString")]
    public NativePointer<sbyte> @String { get => new NativePointer<sbyte>(SdkMemory.Read<IntPtr>(Pointer+40)); set { SdkMemory.Write(Pointer+40,value.Pointer); } }
    [NativeMember("m_bPreviousBrief")]
    public byte @PreviousBrief { get => SdkMemory.Read<byte >(Pointer+44); set { SdkMemory.Write(Pointer+44,value); } }
}
