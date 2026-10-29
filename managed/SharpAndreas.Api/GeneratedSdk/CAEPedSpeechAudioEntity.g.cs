// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CAEPedSpeechAudioEntity : CAEAudioEntity
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=256;
    public CAEPedSpeechAudioEntity(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("field_7C")]
    public NativeArray<sbyte> @Field7C { get => new NativeArray<sbyte>(Pointer+124,20); }
    [NativeMember("field_90")]
    public sbyte @Field90 { get => SdkMemory.Read<sbyte >(Pointer+144); set { SdkMemory.Write(Pointer+144,value); } }
    [NativeMember("field_91")]
    public sbyte @Field91 { get => SdkMemory.Read<sbyte >(Pointer+145); set { SdkMemory.Write(Pointer+145,value); } }
    [NativeMember("m_nVoiceType")]
    public short @VoiceType { get => SdkMemory.Read<short >(Pointer+146); set { SdkMemory.Write(Pointer+146,value); } }
    [NativeMember("m_nVoiceID")]
    public short @VoiceID { get => SdkMemory.Read<short >(Pointer+148); set { SdkMemory.Write(Pointer+148,value); } }
    [NativeMember("m_nVoiceGender")]
    public short @VoiceGender { get => SdkMemory.Read<short >(Pointer+150); set { SdkMemory.Write(Pointer+150,value); } }
    [NativeMember("field_98")]
    public sbyte @Field98 { get => SdkMemory.Read<sbyte >(Pointer+152); set { SdkMemory.Write(Pointer+152,value); } }
    [NativeMember("m_bEnableVocalType")]
    public bool @EnableVocalType { get => SdkMemory.Read<bool >(Pointer+153); set { SdkMemory.Write(Pointer+153,value); } }
    [NativeMember("m_bMuted")]
    public bool @Muted { get => SdkMemory.Read<bool >(Pointer+154); set { SdkMemory.Write(Pointer+154,value); } }
    [NativeMember("m_nVocalEnableFlag")]
    public sbyte @VocalEnableFlag { get => SdkMemory.Read<sbyte >(Pointer+155); set { SdkMemory.Write(Pointer+155,value); } }
    [NativeMember("field_9C")]
    public sbyte @Field9C { get => SdkMemory.Read<sbyte >(Pointer+156); set { SdkMemory.Write(Pointer+156,value); } }
    [NativeMember("field_9D")]
    public sbyte @Field9D { get => SdkMemory.Read<sbyte >(Pointer+157); set { SdkMemory.Write(Pointer+157,value); } }
    [NativeMember("field_9E")]
    public sbyte @Field9E { get => SdkMemory.Read<sbyte >(Pointer+158); set { SdkMemory.Write(Pointer+158,value); } }
    [NativeMember("field_9F")]
    public sbyte @Field9F { get => SdkMemory.Read<sbyte >(Pointer+159); set { SdkMemory.Write(Pointer+159,value); } }
    [NativeMember("m_pSound")]
    public CAESound? @Sound { get => SdkMemory.Read<IntPtr>(Pointer+160) == IntPtr.Zero ? null : new CAESound(SdkMemory.Read<IntPtr>(Pointer+160)); set { SdkMemory.Write(Pointer+160,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("field_A4")]
    public short @FieldA4 { get => SdkMemory.Read<short >(Pointer+164); set { SdkMemory.Write(Pointer+164,value); } }
    [NativeMember("field_A6")]
    public short @FieldA6 { get => SdkMemory.Read<short >(Pointer+166); set { SdkMemory.Write(Pointer+166,value); } }
    [NativeMember("field_A8")]
    public short @FieldA8 { get => SdkMemory.Read<short >(Pointer+168); set { SdkMemory.Write(Pointer+168,value); } }
    [NativeMember("field_AA")]
    public short @FieldAA { get => SdkMemory.Read<short >(Pointer+170); set { SdkMemory.Write(Pointer+170,value); } }
    [NativeMember("m_fVoiceVolume")]
    public float @VoiceVolume { get => SdkMemory.Read<float >(Pointer+172); set { SdkMemory.Write(Pointer+172,value); } }
    [NativeMember("m_nCurrentPhraseId")]
    public short @CurrentPhraseId { get => SdkMemory.Read<short >(Pointer+176); set { SdkMemory.Write(Pointer+176,value); } }
    [NativeMember("field_B2")]
    public short @FieldB2 { get => SdkMemory.Read<short >(Pointer+178); set { SdkMemory.Write(Pointer+178,value); } }
    [NativeMember("field_B4")]
    public NativeArray<int> @FieldB4 { get => new NativeArray<int>(Pointer+180,19); }
    public void @Initialise(CPed? @ped) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D260 >(260)(Pointer,@ped?.Pointer ?? IntPtr.Zero); }
}
