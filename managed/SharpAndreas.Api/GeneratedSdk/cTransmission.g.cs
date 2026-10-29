// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class cTransmission : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=104;
    public cTransmission(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_aGears")]
    public NativeObjectArray<tTransmissionGear> @Gears { get => new NativeObjectArray<tTransmissionGear>(Pointer+0,6,12); }
    [NativeMember("m_nDriveType")]
    public byte @DriveType { get => SdkMemory.Read<byte >(Pointer+72); set { SdkMemory.Write(Pointer+72,value); } }
    [NativeMember("m_nEngineType")]
    public byte @EngineType { get => SdkMemory.Read<byte >(Pointer+73); set { SdkMemory.Write(Pointer+73,value); } }
    [NativeMember("m_nNumberOfGears")]
    public byte @NumberOfGears { get => SdkMemory.Read<byte >(Pointer+74); set { SdkMemory.Write(Pointer+74,value); } }
    [NativeMember("field_4B")]
    public sbyte @Field4B { get => SdkMemory.Read<sbyte >(Pointer+75); set { SdkMemory.Write(Pointer+75,value); } }
    [NativeMember("m_nHandlingFlags")]
    public uint @HandlingFlags { get => SdkMemory.Read<uint >(Pointer+76); set { SdkMemory.Write(Pointer+76,value); } }
    [NativeMember("m_fEngineAcceleration")]
    public float @EngineAcceleration { get => SdkMemory.Read<float >(Pointer+80); set { SdkMemory.Write(Pointer+80,value); } }
    [NativeMember("m_fEngineInertia")]
    public float @EngineInertia { get => SdkMemory.Read<float >(Pointer+84); set { SdkMemory.Write(Pointer+84,value); } }
    [NativeMember("m_fMaxGearVelocity")]
    public float @MaxGearVelocity { get => SdkMemory.Read<float >(Pointer+88); set { SdkMemory.Write(Pointer+88,value); } }
    [NativeMember("field_5C")]
    public int @Field5C { get => SdkMemory.Read<int >(Pointer+92); set { SdkMemory.Write(Pointer+92,value); } }
    [NativeMember("m_fMinGearVelocity")]
    public float @MinGearVelocity { get => SdkMemory.Read<float >(Pointer+96); set { SdkMemory.Write(Pointer+96,value); } }
    [NativeMember("m_fCurrentSpeed")]
    public float @CurrentSpeed { get => SdkMemory.Read<float >(Pointer+100); set { SdkMemory.Write(Pointer+100,value); } }
    public void @InitializeAt() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D261 >(261)(Pointer); }
    public void @InitGearRatios() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D262 >(262)(Pointer); }
    public void @CalculateGearForSimpleCar(float @velocity,NativePointer<byte> @currrentGear) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D263 >(263)(Pointer,@velocity,@currrentGear.Pointer); }
    public void @DisplayGearRatios() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D264 >(264)(Pointer); }
    public float @CalculateDriveAcceleration(NativePointer<float> @gasPedal,NativePointer<byte> @currrentGear,NativePointer<float> @gearChangeCount,NativePointer<float> @speed,NativePointer<float> @unk1,NativePointer<float> @unk2,bool @allWheelsOnGround,byte @handlingType) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D265 >(265)(Pointer,@gasPedal.Pointer,@currrentGear.Pointer,@gearChangeCount.Pointer,@speed.Pointer,@unk1.Pointer,@unk2.Pointer,(@allWheelsOnGround ? 1 : 0),@handlingType); return __sdkResult; }
}
