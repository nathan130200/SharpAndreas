// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CAEAudioHardware : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=4120;
    public CAEAudioHardware(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("field_0")]
    public byte @Field0 { get => SdkMemory.Read<byte >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("m_bDisableEffectsLoading")]
    public sbyte @DisableEffectsLoading { get => SdkMemory.Read<sbyte >(Pointer+1); set { SdkMemory.Write(Pointer+1,value); } }
    [NativeMember("field_2")]
    public sbyte @Field2 { get => SdkMemory.Read<sbyte >(Pointer+2); set { SdkMemory.Write(Pointer+2,value); } }
    [NativeMember("field_3")]
    public sbyte @Field3 { get => SdkMemory.Read<sbyte >(Pointer+3); set { SdkMemory.Write(Pointer+3,value); } }
    [NativeMember("field_4")]
    public sbyte @Field4 { get => SdkMemory.Read<sbyte >(Pointer+4); set { SdkMemory.Write(Pointer+4,value); } }
    [NativeMember("m_nReverbEnvironment")]
    public sbyte @ReverbEnvironment { get => SdkMemory.Read<sbyte >(Pointer+5); set { SdkMemory.Write(Pointer+5,value); } }
    [NativeMember("m_awChannelFlags")]
    public NativeArray<short> @AwChannelFlags { get => new NativeArray<short>(Pointer+6,64); }
    [NativeMember("field_86")]
    public short @Field86 { get => SdkMemory.Read<short >(Pointer+134); set { SdkMemory.Write(Pointer+134,value); } }
    [NativeMember("m_nReverbDepth")]
    public int @ReverbDepth { get => SdkMemory.Read<int >(Pointer+136); set { SdkMemory.Write(Pointer+136,value); } }
    [NativeMember("m_wNumAvailableChannels")]
    public ushort @CountAvailableChannels { get => SdkMemory.Read<ushort >(Pointer+140); set { SdkMemory.Write(Pointer+140,value); } }
    [NativeMember("m_nNumChannels")]
    public ushort @CountChannels { get => SdkMemory.Read<ushort >(Pointer+142); set { SdkMemory.Write(Pointer+142,value); } }
    [NativeMember("m_anNumSoundsInSlot")]
    public NativeArray<short> @CountSoundsInSlot { get => new NativeArray<short>(Pointer+144,64); }
    [NativeMember("m_afChannelVolumes")]
    public NativeArray<float> @ChannelVolumes { get => new NativeArray<float>(Pointer+272,64); }
    [NativeMember("field_210")]
    public NativeArray<int> @Field210 { get => new NativeArray<int>(Pointer+528,64); }
    [NativeMember("m_afChannelsFrqScalingFactor")]
    public NativeArray<float> @ChannelsFrqScalingFactor { get => new NativeArray<float>(Pointer+784,64); }
    [NativeMember("m_fMusicMasterScalingFactor")]
    public float @MusicMasterScalingFactor { get => SdkMemory.Read<float >(Pointer+1040); set { SdkMemory.Write(Pointer+1040,value); } }
    [NativeMember("m_fEffectMasterScalingFactor")]
    public float @EffectMasterScalingFactor { get => SdkMemory.Read<float >(Pointer+1044); set { SdkMemory.Write(Pointer+1044,value); } }
    [NativeMember("m_fMusicFaderScalingFactor")]
    public float @MusicFaderScalingFactor { get => SdkMemory.Read<float >(Pointer+1048); set { SdkMemory.Write(Pointer+1048,value); } }
    [NativeMember("m_fEffectsFaderScalingFactor")]
    public float @EffectsFaderScalingFactor { get => SdkMemory.Read<float >(Pointer+1052); set { SdkMemory.Write(Pointer+1052,value); } }
    [NativeMember("m_fStreamFaderScalingFactor")]
    public float @StreamFaderScalingFactor { get => SdkMemory.Read<float >(Pointer+1056); set { SdkMemory.Write(Pointer+1056,value); } }
    [NativeMember("m_fNonStreamFaderScalingFactor")]
    public float @NonStreamFaderScalingFactor { get => SdkMemory.Read<float >(Pointer+1060); set { SdkMemory.Write(Pointer+1060,value); } }
    [NativeMember("field_428")]
    public float @Field428 { get => SdkMemory.Read<float >(Pointer+1064); set { SdkMemory.Write(Pointer+1064,value); } }
    [NativeMember("field_42C")]
    public float @Field42C { get => SdkMemory.Read<float >(Pointer+1068); set { SdkMemory.Write(Pointer+1068,value); } }
    [NativeMember("m_aBankSlotIds")]
    public NativeArray<short> @BankSlotIds { get => new NativeArray<short>(Pointer+1072,300); }
    [NativeMember("m_aSoundTypes")]
    public NativeArray<short> @SoundTypes { get => new NativeArray<short>(Pointer+1672,300); }
    [NativeMember("m_anVirtualChannelSoundLoopStartTimes")]
    public NativeArray<short> @VirtualChannelSoundLoopStartTimes { get => new NativeArray<short>(Pointer+2272,300); }
    [NativeMember("m_anVirtualChannelSoundLengths")]
    public NativeArray<short> @VirtualChannelSoundLengths { get => new NativeArray<short>(Pointer+2872,300); }
    [NativeMember("m_nBassSet")]
    public sbyte @BassSet { get => SdkMemory.Read<sbyte >(Pointer+3472); set { SdkMemory.Write(Pointer+3472,value); } }
    [NativeMember("__pad1__")]
    public NativeArray<sbyte> @Pad1 { get => new NativeArray<sbyte>(Pointer+3473,3); }
    [NativeMember("m_fBassEqGain")]
    public float @BassEqGain { get => SdkMemory.Read<float >(Pointer+3476); set { SdkMemory.Write(Pointer+3476,value); } }
    [NativeMember("m_pMP3BankLoader")]
    public CAEMP3BankLoader? @MP3BankLoader { get => SdkMemory.Read<IntPtr>(Pointer+3480) == IntPtr.Zero ? null : new CAEMP3BankLoader(SdkMemory.Read<IntPtr>(Pointer+3480)); set { SdkMemory.Write(Pointer+3480,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_pMP3TrackLoader")]
    public uint @MP3TrackLoader { get => SdkMemory.Read<uint >(Pointer+3484); set { SdkMemory.Write(Pointer+3484,value); } }
    [NativeMember("m_pDirectSound")]
    public NativePointer<IntPtr> @DirectSound { get => new NativePointer<IntPtr>(SdkMemory.Read<IntPtr>(Pointer+3488)); set { SdkMemory.Write(Pointer+3488,value.Pointer); } }
    [NativeMember("m_nSpeakerConfig")]
    public int @SpeakerConfig { get => SdkMemory.Read<int >(Pointer+3492); set { SdkMemory.Write(Pointer+3492,value); } }
    [NativeMember("m_n3dEffectsQueryResult")]
    public sbyte @N3dEffectsQueryResult { get => SdkMemory.Read<sbyte >(Pointer+3496); set { SdkMemory.Write(Pointer+3496,value); } }
    [NativeMember("m_dsCaps")]
    public NativePointer<IntPtr> @DsCaps { get => new NativePointer<IntPtr>(SdkMemory.Read<IntPtr>(Pointer+3500)); set { SdkMemory.Write(Pointer+3500,value.Pointer); } }
    [NativeMember("gap")]
    public NativeArray<sbyte> @Gap { get => new NativeArray<sbyte>(Pointer+3504,92); }
    [NativeMember("m_pDirectSound3dListener")]
    public NativePointer<IntPtr> @DirectSound3dListener { get => new NativePointer<IntPtr>(SdkMemory.Read<IntPtr>(Pointer+3596)); set { SdkMemory.Write(Pointer+3596,value.Pointer); } }
    [NativeMember("m_pStreamingChannel")]
    public CAEStreamingChannel? @StreamingChannel { get => SdkMemory.Read<IntPtr>(Pointer+3600) == IntPtr.Zero ? null : new CAEStreamingChannel(SdkMemory.Read<IntPtr>(Pointer+3600)); set { SdkMemory.Write(Pointer+3600,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_streamThread")]
    public CAEStreamThread @StreamThread { get => new CAEStreamThread(Pointer+3604); set { SdkMemory.Copy(value.Pointer,Pointer+3604,80); } }
    [NativeMember("m_aChannels")]
    public NativeArray<IntPtr> @Channels { get => new NativeArray<IntPtr>(Pointer+3684,64); }
    [NativeMember("field_F64")]
    public NativeArray<sbyte> @FieldF64 { get => new NativeArray<sbyte>(Pointer+3940,160); }
    [NativeMember("field_1004")]
    public int @Field1004 { get => SdkMemory.Read<int >(Pointer+4100); set { SdkMemory.Write(Pointer+4100,value); } }
    [NativeMember("field_1008")]
    public int @Field1008 { get => SdkMemory.Read<int >(Pointer+4104); set { SdkMemory.Write(Pointer+4104,value); } }
    [NativeMember("field_100C")]
    public int @Field100C { get => SdkMemory.Read<int >(Pointer+4108); set { SdkMemory.Write(Pointer+4108,value); } }
    [NativeMember("field_1010")]
    public sbyte @Field1010 { get => SdkMemory.Read<sbyte >(Pointer+4112); set { SdkMemory.Write(Pointer+4112,value); } }
    [NativeMember("field_1014")]
    public int @Field1014 { get => SdkMemory.Read<int >(Pointer+4116); set { SdkMemory.Write(Pointer+4116,value); } }
    public int @GetActiveTrackID() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D252 >(252)(Pointer); return __sdkResult; }
}
