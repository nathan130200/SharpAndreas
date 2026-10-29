// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class TxdDef : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=12;
    public TxdDef(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_pRwDictionary")]
    public RwTexDictionary? @RenderWareDictionary { get => SdkMemory.Read<IntPtr>(Pointer+0) == IntPtr.Zero ? null : new RwTexDictionary(SdkMemory.Read<IntPtr>(Pointer+0)); set { SdkMemory.Write(Pointer+0,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_wRefsCount")]
    public ushort @RefsCount { get => SdkMemory.Read<ushort >(Pointer+4); set { SdkMemory.Write(Pointer+4,value); } }
    [NativeMember("m_wParentIndex")]
    public short @ParentIndex { get => SdkMemory.Read<short >(Pointer+6); set { SdkMemory.Write(Pointer+6,value); } }
    [NativeMember("m_hash")]
    public uint @Hash { get => SdkMemory.Read<uint >(Pointer+8); set { SdkMemory.Write(Pointer+8,value); } }
}
