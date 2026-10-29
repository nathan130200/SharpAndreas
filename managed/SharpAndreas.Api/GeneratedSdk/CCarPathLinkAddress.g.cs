// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CCarPathLinkAddress : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=2;
    public CCarPathLinkAddress(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_nCarPathLinkId")]
    public short @CarPathLinkId { get => (short)SdkMemory.ReadSignedBits(Pointer,0,10); set { SdkMemory.WriteBits(Pointer,0,10,unchecked((ulong)value)); } }
    [NativeMember("m_nAreaId")]
    public short @AreaId { get => (short)SdkMemory.ReadSignedBits(Pointer,10,6); set { SdkMemory.WriteBits(Pointer,10,6,unchecked((ulong)value)); } }
}
