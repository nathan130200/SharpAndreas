// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CAETwinLoopSoundEntity : CAEAudioEntity
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=168;
    public CAETwinLoopSoundEntity(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_nBankSlotId")]
    public short @BankSlotId { get => SdkMemory.Read<short >(Pointer+124); set { SdkMemory.Write(Pointer+124,value); } }
    [NativeMember("m_nSoundType")]
    public NativeArray<short> @SoundType { get => new NativeArray<short>(Pointer+126,2); }
    [NativeMember("m_pBaseAudio")]
    public CAEAudioEntity? @BaseAudio { get => SdkMemory.Read<IntPtr>(Pointer+132) == IntPtr.Zero ? null : new CAEAudioEntity(SdkMemory.Read<IntPtr>(Pointer+132)); set { SdkMemory.Write(Pointer+132,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("field_88")]
    public short @Field88 { get => SdkMemory.Read<short >(Pointer+136); set { SdkMemory.Write(Pointer+136,value); } }
    [NativeMember("field_8A")]
    public short @Field8A { get => SdkMemory.Read<short >(Pointer+138); set { SdkMemory.Write(Pointer+138,value); } }
    [NativeMember("field_8C")]
    public short @Field8C { get => SdkMemory.Read<short >(Pointer+140); set { SdkMemory.Write(Pointer+140,value); } }
    [NativeMember("m_nPlayTimeMin")]
    public short @PlayTimeMin { get => SdkMemory.Read<short >(Pointer+142); set { SdkMemory.Write(Pointer+142,value); } }
    [NativeMember("m_nPlayTimeMax")]
    public short @PlayTimeMax { get => SdkMemory.Read<short >(Pointer+144); set { SdkMemory.Write(Pointer+144,value); } }
    [NativeMember("m_nTimeToSwapSounds")]
    public uint @TimeToSwapSounds { get => SdkMemory.Read<uint >(Pointer+148); set { SdkMemory.Write(Pointer+148,value); } }
    [NativeMember("m_bPlayingFirstSound")]
    public bool @PlayingFirstSound { get => SdkMemory.Read<bool >(Pointer+152); set { SdkMemory.Write(Pointer+152,value); } }
    [NativeMember("m_anStartingPlayPercentage")]
    public NativeArray<short> @StartingPlayPercentage { get => new NativeArray<short>(Pointer+154,2); }
    [NativeMember("field_9E")]
    public short @Field9E { get => SdkMemory.Read<short >(Pointer+158); set { SdkMemory.Write(Pointer+158,value); } }
    [NativeMember("m_apSounds")]
    public NativeArray<IntPtr> @Sounds { get => new NativeArray<IntPtr>(Pointer+160,2); }
}
