// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class cVehicleParams : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=76;
    public cVehicleParams(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_nVehicleSubclass")]
    public uint @VehicleSubclass { get => SdkMemory.Read<uint >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("m_nVehicleClass")]
    public uint @VehicleClass { get => SdkMemory.Read<uint >(Pointer+4); set { SdkMemory.Write(Pointer+4,value); } }
    [NativeMember("field_8")]
    public sbyte @Field8 { get => SdkMemory.Read<sbyte >(Pointer+8); set { SdkMemory.Write(Pointer+8,value); } }
    [NativeMember("pad1")]
    public NativeArray<sbyte> @Pad1 { get => new NativeArray<sbyte>(Pointer+9,3); }
    [NativeMember("field_C")]
    public int @FieldC { get => SdkMemory.Read<int >(Pointer+12); set { SdkMemory.Write(Pointer+12,value); } }
    [NativeMember("m_pVehicle")]
    public CVehicle? @Vehicle { get => SdkMemory.Read<IntPtr>(Pointer+16) == IntPtr.Zero ? null : new CVehicle(SdkMemory.Read<IntPtr>(Pointer+16)); set { SdkMemory.Write(Pointer+16,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_pTransmission")]
    public cTransmission? @Transmission { get => SdkMemory.Read<IntPtr>(Pointer+20) == IntPtr.Zero ? null : new cTransmission(SdkMemory.Read<IntPtr>(Pointer+20)); set { SdkMemory.Write(Pointer+20,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_nModelType")]
    public uint @ModelType { get => SdkMemory.Read<uint >(Pointer+24); set { SdkMemory.Write(Pointer+24,value); } }
    [NativeMember("m_fVelocity")]
    public float @Velocity { get => SdkMemory.Read<float >(Pointer+28); set { SdkMemory.Write(Pointer+28,value); } }
    [NativeMember("m_nGasState")]
    public short @GasState { get => SdkMemory.Read<short >(Pointer+32); set { SdkMemory.Write(Pointer+32,value); } }
    [NativeMember("m_nBreakState")]
    public short @BreakState { get => SdkMemory.Read<short >(Pointer+34); set { SdkMemory.Write(Pointer+34,value); } }
    [NativeMember("m_fVelocityAbsolute")]
    public float @VelocityAbsolute { get => SdkMemory.Read<float >(Pointer+36); set { SdkMemory.Write(Pointer+36,value); } }
    [NativeMember("m_fZVelocity")]
    public float @ZVelocity { get => SdkMemory.Read<float >(Pointer+40); set { SdkMemory.Write(Pointer+40,value); } }
    [NativeMember("m_fVelocityPercentage")]
    public float @VelocityPercentage { get => SdkMemory.Read<float >(Pointer+44); set { SdkMemory.Write(Pointer+44,value); } }
    [NativeMember("field_30")]
    public int @Field30 { get => SdkMemory.Read<int >(Pointer+48); set { SdkMemory.Write(Pointer+48,value); } }
    [NativeMember("field_34")]
    public float @Field34 { get => SdkMemory.Read<float >(Pointer+52); set { SdkMemory.Write(Pointer+52,value); } }
    [NativeMember("m_nCurrentGear")]
    public sbyte @CurrentGear { get => SdkMemory.Read<sbyte >(Pointer+56); set { SdkMemory.Write(Pointer+56,value); } }
    [NativeMember("m_bHandbrakeOn")]
    public bool @HandbrakeOn { get => SdkMemory.Read<bool >(Pointer+57); set { SdkMemory.Write(Pointer+57,value); } }
    [NativeMember("pad2")]
    public NativeArray<sbyte> @Pad2 { get => new NativeArray<sbyte>(Pointer+58,2); }
    [NativeMember("m_fVelocityChangingPercentage")]
    public float @VelocityChangingPercentage { get => SdkMemory.Read<float >(Pointer+60); set { SdkMemory.Write(Pointer+60,value); } }
    [NativeMember("m_fWheelSpinForAudio")]
    public float @WheelSpinForAudio { get => SdkMemory.Read<float >(Pointer+64); set { SdkMemory.Write(Pointer+64,value); } }
    [NativeMember("m_nNumberOfGears")]
    public ushort @NumberOfGears { get => SdkMemory.Read<ushort >(Pointer+68); set { SdkMemory.Write(Pointer+68,value); } }
    [NativeMember("m_nWheelsOnGround")]
    public byte @WheelsOnGround { get => SdkMemory.Read<byte >(Pointer+70); set { SdkMemory.Write(Pointer+70,value); } }
    [NativeMember("field_47")]
    public sbyte @Field47 { get => SdkMemory.Read<sbyte >(Pointer+71); set { SdkMemory.Write(Pointer+71,value); } }
    [NativeMember("field_48")]
    public int @Field48 { get => SdkMemory.Read<int >(Pointer+72); set { SdkMemory.Write(Pointer+72,value); } }
}
