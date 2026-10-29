// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CPedAcquaintance : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=20;
    public CPedAcquaintance(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_nRespect")]
    public uint @Respect { get => SdkMemory.Read<uint >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("m_nLike")]
    public uint @Like { get => SdkMemory.Read<uint >(Pointer+4); set { SdkMemory.Write(Pointer+4,value); } }
    [NativeMember("m_nIgnore")]
    public uint @Ignore { get => SdkMemory.Read<uint >(Pointer+8); set { SdkMemory.Write(Pointer+8,value); } }
    [NativeMember("m_nDislike")]
    public uint @Dislike { get => SdkMemory.Read<uint >(Pointer+12); set { SdkMemory.Write(Pointer+12,value); } }
    [NativeMember("m_nHate")]
    public uint @Hate { get => SdkMemory.Read<uint >(Pointer+16); set { SdkMemory.Write(Pointer+16,value); } }
}
