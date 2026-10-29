// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CPedModelInfo : CClumpModelInfo
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=68;
    public CPedModelInfo(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_nAnimType")]
    public int @AnimationType { get => SdkMemory.Read<int >(Pointer+36); set { SdkMemory.Write(Pointer+36,value); } }
    [NativeMember("m_nPedType")]
    public uint @PedType { get => SdkMemory.Read<uint >(Pointer+40); set { SdkMemory.Write(Pointer+40,value); } }
    [NativeMember("m_nStatType")]
    public uint @StatType { get => SdkMemory.Read<uint >(Pointer+44); set { SdkMemory.Write(Pointer+44,value); } }
    [NativeMember("m_nCarsCanDriveMask")]
    public ushort @CarsCanDriveMask { get => SdkMemory.Read<ushort >(Pointer+48); set { SdkMemory.Write(Pointer+48,value); } }
    [NativeMember("m_nPedFlags")]
    public ushort @PedFlags { get => SdkMemory.Read<ushort >(Pointer+50); set { SdkMemory.Write(Pointer+50,value); } }
    [NativeMember("m_pHitColModel")]
    public CColModel? @HitCollisionModel { get => SdkMemory.Read<IntPtr>(Pointer+52) == IntPtr.Zero ? null : new CColModel(SdkMemory.Read<IntPtr>(Pointer+52)); set { SdkMemory.Write(Pointer+52,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_nRadio1")]
    public byte @Radio1 { get => SdkMemory.Read<byte >(Pointer+56); set { SdkMemory.Write(Pointer+56,value); } }
    [NativeMember("m_nRadio2")]
    public byte @Radio2 { get => SdkMemory.Read<byte >(Pointer+57); set { SdkMemory.Write(Pointer+57,value); } }
    [NativeMember("m_nRace")]
    public byte @Race { get => SdkMemory.Read<byte >(Pointer+58); set { SdkMemory.Write(Pointer+58,value); } }
    [NativeMember("m_nPedAudioType")]
    public short @PedAudioType { get => SdkMemory.Read<short >(Pointer+60); set { SdkMemory.Write(Pointer+60,value); } }
    [NativeMember("m_nVoice1")]
    public short @Voice1 { get => SdkMemory.Read<short >(Pointer+62); set { SdkMemory.Write(Pointer+62,value); } }
    [NativeMember("m_nVoice2")]
    public short @Voice2 { get => SdkMemory.Read<short >(Pointer+64); set { SdkMemory.Write(Pointer+64,value); } }
    [NativeMember("m_nVoiceId")]
    public short @VoiceId { get => SdkMemory.Read<short >(Pointer+66); set { SdkMemory.Write(Pointer+66,value); } }
}
