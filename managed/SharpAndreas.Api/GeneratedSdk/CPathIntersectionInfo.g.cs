// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CPathIntersectionInfo : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=1;
    public CPathIntersectionInfo(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_bRoadCross")]
    public byte @RoadCross { get => (byte)SdkMemory.ReadBits(Pointer,0,1); set { SdkMemory.WriteBits(Pointer,0,1,unchecked((ulong)value)); } }
    [NativeMember("m_bPedTrafficLight")]
    public byte @PedTrafficLight { get => (byte)SdkMemory.ReadBits(Pointer,1,1); set { SdkMemory.WriteBits(Pointer,1,1,unchecked((ulong)value)); } }
}
