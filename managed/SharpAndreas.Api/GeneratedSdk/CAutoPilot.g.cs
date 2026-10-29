// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CAutoPilot : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=152;
    public CAutoPilot(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_currentAddress")]
    public CNodeAddress @CurrentAddress { get => new CNodeAddress(Pointer+0); set { SdkMemory.Copy(value.Pointer,Pointer+0,4); } }
    [NativeMember("m_startingRouteNode")]
    public CNodeAddress @StartingRouteNode { get => new CNodeAddress(Pointer+4); set { SdkMemory.Copy(value.Pointer,Pointer+4,4); } }
    [NativeMember("field_8")]
    public CNodeAddress @Field8 { get => new CNodeAddress(Pointer+8); set { SdkMemory.Copy(value.Pointer,Pointer+8,4); } }
    [NativeMember("field_C")]
    public int @FieldC { get => SdkMemory.Read<int >(Pointer+12); set { SdkMemory.Write(Pointer+12,value); } }
    [NativeMember("m_nSpeedScaleFactor")]
    public uint @SpeedScaleFactor { get => SdkMemory.Read<uint >(Pointer+16); set { SdkMemory.Write(Pointer+16,value); } }
    [NativeMember("m_nCurrentPathNodeInfo")]
    public CCarPathLinkAddress @CurrentPathNodeInfo { get => new CCarPathLinkAddress(Pointer+20); set { SdkMemory.Copy(value.Pointer,Pointer+20,2); } }
    [NativeMember("m_nNextPathNodeInfo")]
    public CCarPathLinkAddress @NextPathNodeInfo { get => new CCarPathLinkAddress(Pointer+22); set { SdkMemory.Copy(value.Pointer,Pointer+22,2); } }
    [NativeMember("m_nPreviousPathNodeInfo")]
    public CCarPathLinkAddress @PreviousPathNodeInfo { get => new CCarPathLinkAddress(Pointer+24); set { SdkMemory.Copy(value.Pointer,Pointer+24,2); } }
    [NativeMember("field_1A")]
    public NativeArray<sbyte> @Field1A { get => new NativeArray<sbyte>(Pointer+26,2); }
    [NativeMember("m_nTimeToStartMission")]
    public uint @TimeToStartMission { get => SdkMemory.Read<uint >(Pointer+28); set { SdkMemory.Write(Pointer+28,value); } }
    [NativeMember("m_nTimeSwitchedToRealPhysics")]
    public uint @TimeSwitchedToRealPhysics { get => SdkMemory.Read<uint >(Pointer+32); set { SdkMemory.Write(Pointer+32,value); } }
    [NativeMember("field_24")]
    public sbyte @Field24 { get => SdkMemory.Read<sbyte >(Pointer+36); set { SdkMemory.Write(Pointer+36,value); } }
    [NativeMember("_smthCurr")]
    public sbyte @SmthCurr { get => SdkMemory.Read<sbyte >(Pointer+37); set { SdkMemory.Write(Pointer+37,value); } }
    [NativeMember("_smthNext")]
    public sbyte @SmthNext { get => SdkMemory.Read<sbyte >(Pointer+38); set { SdkMemory.Write(Pointer+38,value); } }
    [NativeMember("m_nCurrentLane")]
    public sbyte @CurrentLane { get => SdkMemory.Read<sbyte >(Pointer+39); set { SdkMemory.Write(Pointer+39,value); } }
    [NativeMember("m_nNextLane")]
    public sbyte @NextLane { get => SdkMemory.Read<sbyte >(Pointer+40); set { SdkMemory.Write(Pointer+40,value); } }
    [NativeMember("m_nCarDrivingStyle")]
    public eCarDrivingStyle @CarDrivingStyle { get => SdkMemory.Read<eCarDrivingStyle >(Pointer+41); set { SdkMemory.Write(Pointer+41,value); } }
    [NativeMember("m_nCarMission")]
    public eCarMission @CarMission { get => SdkMemory.Read<eCarMission >(Pointer+42); set { SdkMemory.Write(Pointer+42,value); } }
    [NativeMember("m_nTempAction")]
    public sbyte @TempAction { get => SdkMemory.Read<sbyte >(Pointer+43); set { SdkMemory.Write(Pointer+43,value); } }
    [NativeMember("m_nTempActionTime")]
    public uint @TempActionTime { get => SdkMemory.Read<uint >(Pointer+44); set { SdkMemory.Write(Pointer+44,value); } }
    [NativeMember("_someStartTime")]
    public uint @SomeStartTime { get => SdkMemory.Read<uint >(Pointer+48); set { SdkMemory.Write(Pointer+48,value); } }
    [NativeMember("field_34")]
    public sbyte @Field34 { get => SdkMemory.Read<sbyte >(Pointer+52); set { SdkMemory.Write(Pointer+52,value); } }
    [NativeMember("field_35")]
    public sbyte @Field35 { get => SdkMemory.Read<sbyte >(Pointer+53); set { SdkMemory.Write(Pointer+53,value); } }
    [NativeMember("field_36")]
    public NativeArray<sbyte> @Field36 { get => new NativeArray<sbyte>(Pointer+54,2); }
    [NativeMember("field_38")]
    public float @Field38 { get => SdkMemory.Read<float >(Pointer+56); set { SdkMemory.Write(Pointer+56,value); } }
    [NativeMember("m_fMaxTrafficSpeed")]
    public float @MaxTrafficSpeed { get => SdkMemory.Read<float >(Pointer+60); set { SdkMemory.Write(Pointer+60,value); } }
    [NativeMember("m_nCruiseSpeed")]
    public sbyte @CruiseSpeed { get => SdkMemory.Read<sbyte >(Pointer+64); set { SdkMemory.Write(Pointer+64,value); } }
    [NativeMember("field_41")]
    public sbyte @Field41 { get => SdkMemory.Read<sbyte >(Pointer+65); set { SdkMemory.Write(Pointer+65,value); } }
    [NativeMember("field_42")]
    public NativeArray<sbyte> @Field42 { get => new NativeArray<sbyte>(Pointer+66,2); }
    [NativeMember("field_44")]
    public float @Field44 { get => SdkMemory.Read<float >(Pointer+68); set { SdkMemory.Write(Pointer+68,value); } }
    [NativeMember("field_48")]
    public NativeArray<sbyte> @Field48 { get => new NativeArray<sbyte>(Pointer+72,1); }
    [NativeMember("heliThrustPower")]
    public sbyte @HeliThrustPower { get => SdkMemory.Read<sbyte >(Pointer+73); set { SdkMemory.Write(Pointer+73,value); } }
    [NativeMember("field_4A")]
    public sbyte @Field4A { get => SdkMemory.Read<sbyte >(Pointer+74); set { SdkMemory.Write(Pointer+74,value); } }
    [NativeMember("m_nCarCtrlFlags")]
    public byte @CarCtrlFlags { get => SdkMemory.Read<byte >(Pointer+75); set { SdkMemory.Write(Pointer+75,value); } }
    [NativeMember("field_4C")]
    public sbyte @Field4C { get => SdkMemory.Read<sbyte >(Pointer+76); set { SdkMemory.Write(Pointer+76,value); } }
    [NativeMember("m_nStraightLineDistance")]
    public sbyte @StraightLineDistance { get => SdkMemory.Read<sbyte >(Pointer+77); set { SdkMemory.Write(Pointer+77,value); } }
    [NativeMember("field_4E")]
    public sbyte @Field4E { get => SdkMemory.Read<sbyte >(Pointer+78); set { SdkMemory.Write(Pointer+78,value); } }
    [NativeMember("field_4F")]
    public sbyte @Field4F { get => SdkMemory.Read<sbyte >(Pointer+79); set { SdkMemory.Write(Pointer+79,value); } }
    [NativeMember("field_50")]
    public sbyte @Field50 { get => SdkMemory.Read<sbyte >(Pointer+80); set { SdkMemory.Write(Pointer+80,value); } }
    [NativeMember("field_51")]
    public sbyte @Field51 { get => SdkMemory.Read<sbyte >(Pointer+81); set { SdkMemory.Write(Pointer+81,value); } }
    [NativeMember("field_52")]
    public NativeArray<sbyte> @Field52 { get => new NativeArray<sbyte>(Pointer+82,10); }
    [NativeMember("m_vecDestinationCoors")]
    public CVector @DestinationCoors { get => new CVector(Pointer+92); set { SdkMemory.Copy(value.Pointer,Pointer+92,12); } }
    [NativeMember("m_aPathFindNodesInfo")]
    public NativeObjectArray<CNodeAddress> @PathFindNodesInfo { get => new NativeObjectArray<CNodeAddress>(Pointer+104,8,4); }
    [NativeMember("m_nPathFindNodesCount")]
    public ushort @PathFindNodesCount { get => SdkMemory.Read<ushort >(Pointer+136); set { SdkMemory.Write(Pointer+136,value); } }
    [NativeMember("field_8A")]
    public NativeArray<sbyte> @Field8A { get => new NativeArray<sbyte>(Pointer+138,2); }
    [NativeMember("m_pTargetCar")]
    public CVehicle? @TargetCar { get => SdkMemory.Read<IntPtr>(Pointer+140) == IntPtr.Zero ? null : new CVehicle(SdkMemory.Read<IntPtr>(Pointer+140)); set { SdkMemory.Write(Pointer+140,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_pCarWeMakingSlowDownFor")]
    public CEntity? @CarWeMakingSlowDownFor { get => SdkMemory.Read<IntPtr>(Pointer+144) == IntPtr.Zero ? null : new CEntity(SdkMemory.Read<IntPtr>(Pointer+144)); set { SdkMemory.Write(Pointer+144,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("field_94")]
    public sbyte @Field94 { get => SdkMemory.Read<sbyte >(Pointer+148); set { SdkMemory.Write(Pointer+148,value); } }
    [NativeMember("field_95")]
    public sbyte @Field95 { get => SdkMemory.Read<sbyte >(Pointer+149); set { SdkMemory.Write(Pointer+149,value); } }
    [NativeMember("field_96")]
    public short @Field96 { get => SdkMemory.Read<short >(Pointer+150); set { SdkMemory.Write(Pointer+150,value); } }
}
