// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CLodAtomicModelInfo : CAtomicModelInfo
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=36;
    public CLodAtomicModelInfo(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_numChildren")]
    public short @CountChildren { get => SdkMemory.Read<short >(Pointer+32); set { SdkMemory.Write(Pointer+32,value); } }
    [NativeMember("m_numChildrenRendered")]
    public short @CountChildrenRendered { get => SdkMemory.Read<short >(Pointer+34); set { SdkMemory.Write(Pointer+34,value); } }
}
