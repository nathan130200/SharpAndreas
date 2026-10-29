// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class tVehicleAudioSettings : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=36;
    public tVehicleAudioSettings(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_nVehicleSoundType")]
    public eVehicleSoundType @VehicleSoundType { get => SdkMemory.Read<eVehicleSoundType >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("_pad")]
    public sbyte @Pad { get => SdkMemory.Read<sbyte >(Pointer+1); set { SdkMemory.Write(Pointer+1,value); } }
    [NativeMember("m_nEngineOnSoundBankId")]
    public short @EngineOnSoundBankId { get => SdkMemory.Read<short >(Pointer+2); set { SdkMemory.Write(Pointer+2,value); } }
    [NativeMember("m_nEngineOffSoundBankId")]
    public short @EngineOffSoundBankId { get => SdkMemory.Read<short >(Pointer+4); set { SdkMemory.Write(Pointer+4,value); } }
    [NativeMember("m_nBassSetting")]
    public sbyte @BassSetting { get => SdkMemory.Read<sbyte >(Pointer+6); set { SdkMemory.Write(Pointer+6,value); } }
    [NativeMember("_pad1")]
    public sbyte @Pad1 { get => SdkMemory.Read<sbyte >(Pointer+7); set { SdkMemory.Write(Pointer+7,value); } }
    [NativeMember("m_fBassEq")]
    public float @BassEq { get => SdkMemory.Read<float >(Pointer+8); set { SdkMemory.Write(Pointer+8,value); } }
    [NativeMember("field_C")]
    public float @FieldC { get => SdkMemory.Read<float >(Pointer+12); set { SdkMemory.Write(Pointer+12,value); } }
    [NativeMember("m_bHornTon")]
    public sbyte @HornTon { get => SdkMemory.Read<sbyte >(Pointer+16); set { SdkMemory.Write(Pointer+16,value); } }
    [NativeMember("_pad2")]
    public NativeArray<sbyte> @Pad2 { get => new NativeArray<sbyte>(Pointer+17,3); }
    [NativeMember("m_fHornHigh")]
    public float @HornHigh { get => SdkMemory.Read<float >(Pointer+20); set { SdkMemory.Write(Pointer+20,value); } }
    [NativeMember("m_nDoorSound")]
    public sbyte @DoorSound { get => SdkMemory.Read<sbyte >(Pointer+24); set { SdkMemory.Write(Pointer+24,value); } }
    [NativeMember("field_19")]
    public sbyte @Field19 { get => SdkMemory.Read<sbyte >(Pointer+25); set { SdkMemory.Write(Pointer+25,value); } }
    [NativeMember("m_nRadioID")]
    public eRadioID @RadioID { get => SdkMemory.Read<eRadioID >(Pointer+26); set { SdkMemory.Write(Pointer+26,value); } }
    [NativeMember("m_nRadioType")]
    public eRadioType @RadioType { get => SdkMemory.Read<eRadioType >(Pointer+27); set { SdkMemory.Write(Pointer+27,value); } }
    [NativeMember("vehTypeForAudio")]
    public sbyte @VehTypeForAudio { get => SdkMemory.Read<sbyte >(Pointer+28); set { SdkMemory.Write(Pointer+28,value); } }
    [NativeMember("_pad4")]
    public NativeArray<sbyte> @Pad4 { get => new NativeArray<sbyte>(Pointer+29,3); }
    [NativeMember("m_fHornVolumeDelta")]
    public float @HornVolumeDelta { get => SdkMemory.Read<float >(Pointer+32); set { SdkMemory.Write(Pointer+32,value); } }
}
