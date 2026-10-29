// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class tRadarTrace : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=40;
    public tRadarTrace(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_nColour")]
    public uint @Color { get => SdkMemory.Read<uint >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("m_nEntityHandle")]
    public uint @EntityHandle { get => SdkMemory.Read<uint >(Pointer+4); set { SdkMemory.Write(Pointer+4,value); } }
    [NativeMember("m_vecPos")]
    public CVector @Position { get => new CVector(Pointer+8); set { SdkMemory.Copy(value.Pointer,Pointer+8,12); } }
    [NativeMember("m_nCounter")]
    public ushort @Counter { get => SdkMemory.Read<ushort >(Pointer+20); set { SdkMemory.Write(Pointer+20,value); } }
    [NativeMember("m_fSphereRadius")]
    public float @SphereRadius { get => SdkMemory.Read<float >(Pointer+24); set { SdkMemory.Write(Pointer+24,value); } }
    [NativeMember("m_nBlipSize")]
    public ushort @BlipSize { get => SdkMemory.Read<ushort >(Pointer+28); set { SdkMemory.Write(Pointer+28,value); } }
    [NativeMember("m_pEntryExit")]
    public CEntryExit? @EntryExit { get => SdkMemory.Read<IntPtr>(Pointer+32) == IntPtr.Zero ? null : new CEntryExit(SdkMemory.Read<IntPtr>(Pointer+32)); set { SdkMemory.Write(Pointer+32,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_nRadarSprite")]
    public byte @RadarSprite { get => SdkMemory.Read<byte >(Pointer+36); set { SdkMemory.Write(Pointer+36,value); } }
    [NativeMember("m_bBright")]
    public byte @Bright { get => (byte)SdkMemory.ReadBits(Pointer,296,1); set { SdkMemory.WriteBits(Pointer,296,1,unchecked((ulong)value)); } }
    [NativeMember("m_bInUse")]
    public byte @InUse { get => (byte)SdkMemory.ReadBits(Pointer,297,1); set { SdkMemory.WriteBits(Pointer,297,1,unchecked((ulong)value)); } }
    [NativeMember("m_bShortRange")]
    public byte @ShortRange { get => (byte)SdkMemory.ReadBits(Pointer,298,1); set { SdkMemory.WriteBits(Pointer,298,1,unchecked((ulong)value)); } }
    [NativeMember("m_bFriendly")]
    public byte @Friendly { get => (byte)SdkMemory.ReadBits(Pointer,299,1); set { SdkMemory.WriteBits(Pointer,299,1,unchecked((ulong)value)); } }
    [NativeMember("m_bBlipRemain")]
    public byte @BlipRemain { get => (byte)SdkMemory.ReadBits(Pointer,300,1); set { SdkMemory.WriteBits(Pointer,300,1,unchecked((ulong)value)); } }
    [NativeMember("m_bBlipFade")]
    public byte @BlipFade { get => (byte)SdkMemory.ReadBits(Pointer,301,1); set { SdkMemory.WriteBits(Pointer,301,1,unchecked((ulong)value)); } }
    [NativeMember("m_nCoordBlipAppearance")]
    public byte @CoordinateBlipAppearance { get => (byte)SdkMemory.ReadBits(Pointer,302,2); set { SdkMemory.WriteBits(Pointer,302,2,unchecked((ulong)value)); } }
    [NativeMember("m_nBlipDisplay")]
    public byte @BlipDisplay { get => (byte)SdkMemory.ReadBits(Pointer,304,2); set { SdkMemory.WriteBits(Pointer,304,2,unchecked((ulong)value)); } }
    [NativeMember("m_nBlipType")]
    public byte @BlipType { get => (byte)SdkMemory.ReadBits(Pointer,306,4); set { SdkMemory.WriteBits(Pointer,306,4,unchecked((ulong)value)); } }
}
