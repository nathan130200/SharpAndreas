// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class tHandlingData : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=224;
    public tHandlingData(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_nVehicleId")]
    public int @VehicleId { get => SdkMemory.Read<int >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("m_fMass")]
    public float @Mass { get => SdkMemory.Read<float >(Pointer+4); set { SdkMemory.Write(Pointer+4,value); } }
    [NativeMember("field_8")]
    public float @Field8 { get => SdkMemory.Read<float >(Pointer+8); set { SdkMemory.Write(Pointer+8,value); } }
    [NativeMember("m_fTurnMass")]
    public float @TurnMass { get => SdkMemory.Read<float >(Pointer+12); set { SdkMemory.Write(Pointer+12,value); } }
    [NativeMember("m_fDragMult")]
    public float @DragMult { get => SdkMemory.Read<float >(Pointer+16); set { SdkMemory.Write(Pointer+16,value); } }
    [NativeMember("m_vecCentreOfMass")]
    public CVector @CentreOfMass { get => new CVector(Pointer+20); set { SdkMemory.Copy(value.Pointer,Pointer+20,12); } }
    [NativeMember("m_nPercentSubmerged")]
    public byte @PercentSubmerged { get => SdkMemory.Read<byte >(Pointer+32); set { SdkMemory.Write(Pointer+32,value); } }
    [NativeMember("m_fBuoyancyConstant")]
    public float @BuoyancyConstant { get => SdkMemory.Read<float >(Pointer+36); set { SdkMemory.Write(Pointer+36,value); } }
    [NativeMember("m_fTractionMultiplier")]
    public float @TractionMultiplier { get => SdkMemory.Read<float >(Pointer+40); set { SdkMemory.Write(Pointer+40,value); } }
    [NativeMember("m_transmissionData")]
    public cTransmission @TransmissionData { get => new cTransmission(Pointer+44); set { SdkMemory.Copy(value.Pointer,Pointer+44,104); } }
    [NativeMember("m_fBrakeDeceleration")]
    public float @BrakeDeceleration { get => SdkMemory.Read<float >(Pointer+148); set { SdkMemory.Write(Pointer+148,value); } }
    [NativeMember("m_fBrakeBias")]
    public float @BrakeBias { get => SdkMemory.Read<float >(Pointer+152); set { SdkMemory.Write(Pointer+152,value); } }
    [NativeMember("m_bABS")]
    public sbyte @ABS { get => SdkMemory.Read<sbyte >(Pointer+156); set { SdkMemory.Write(Pointer+156,value); } }
    [NativeMember("field_9D")]
    public sbyte @Field9D { get => SdkMemory.Read<sbyte >(Pointer+157); set { SdkMemory.Write(Pointer+157,value); } }
    [NativeMember("field_9E")]
    public sbyte @Field9E { get => SdkMemory.Read<sbyte >(Pointer+158); set { SdkMemory.Write(Pointer+158,value); } }
    [NativeMember("field_9F")]
    public sbyte @Field9F { get => SdkMemory.Read<sbyte >(Pointer+159); set { SdkMemory.Write(Pointer+159,value); } }
    [NativeMember("m_fSteeringLock")]
    public float @SteeringLock { get => SdkMemory.Read<float >(Pointer+160); set { SdkMemory.Write(Pointer+160,value); } }
    [NativeMember("m_fTractionLoss")]
    public float @TractionLoss { get => SdkMemory.Read<float >(Pointer+164); set { SdkMemory.Write(Pointer+164,value); } }
    [NativeMember("m_fTractionBias")]
    public float @TractionBias { get => SdkMemory.Read<float >(Pointer+168); set { SdkMemory.Write(Pointer+168,value); } }
    [NativeMember("m_fSuspensionForceLevel")]
    public float @SuspensionForceLevel { get => SdkMemory.Read<float >(Pointer+172); set { SdkMemory.Write(Pointer+172,value); } }
    [NativeMember("m_fSuspensionDampingLevel")]
    public float @SuspensionDampingLevel { get => SdkMemory.Read<float >(Pointer+176); set { SdkMemory.Write(Pointer+176,value); } }
    [NativeMember("m_fSuspensionHighSpdComDamp")]
    public float @SuspensionHighSpdComDamp { get => SdkMemory.Read<float >(Pointer+180); set { SdkMemory.Write(Pointer+180,value); } }
    [NativeMember("m_fSuspensionUpperLimit")]
    public float @SuspensionUpperLimit { get => SdkMemory.Read<float >(Pointer+184); set { SdkMemory.Write(Pointer+184,value); } }
    [NativeMember("m_fSuspensionLowerLimit")]
    public float @SuspensionLowerLimit { get => SdkMemory.Read<float >(Pointer+188); set { SdkMemory.Write(Pointer+188,value); } }
    [NativeMember("m_fSuspensionBiasBetweenFrontAndRear")]
    public float @SuspensionBiasBetweenFrontAndRear { get => SdkMemory.Read<float >(Pointer+192); set { SdkMemory.Write(Pointer+192,value); } }
    [NativeMember("m_fSuspensionAntiDiveMultiplier")]
    public float @SuspensionAntiDiveMultiplier { get => SdkMemory.Read<float >(Pointer+196); set { SdkMemory.Write(Pointer+196,value); } }
    [NativeMember("m_fCollisionDamageMultiplier")]
    public float @CollisionDamageMultiplier { get => SdkMemory.Read<float >(Pointer+200); set { SdkMemory.Write(Pointer+200,value); } }
    [NativeMember("m_fSeatOffsetDistance")]
    public float @SeatOffsetDistance { get => SdkMemory.Read<float >(Pointer+212); set { SdkMemory.Write(Pointer+212,value); } }
    [NativeMember("m_nMonetaryValue")]
    public uint @MonetaryValue { get => SdkMemory.Read<uint >(Pointer+216); set { SdkMemory.Write(Pointer+216,value); } }
    [NativeMember("m_nFrontLights")]
    public eVehicleLightsSize @FrontLights { get => SdkMemory.Read<eVehicleLightsSize >(Pointer+220); set { SdkMemory.Write(Pointer+220,value); } }
    [NativeMember("m_nRearLights")]
    public eVehicleLightsSize @RearLights { get => SdkMemory.Read<eVehicleLightsSize >(Pointer+221); set { SdkMemory.Write(Pointer+221,value); } }
    [NativeMember("m_nAnimGroup")]
    public byte @AnimationGroup { get => SdkMemory.Read<byte >(Pointer+222); set { SdkMemory.Write(Pointer+222,value); } }
}
