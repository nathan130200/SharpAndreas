// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CTrain : CVehicle
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=1708;
    public CTrain(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_nNodeIndex")]
    public short @NodeIndex { get => SdkMemory.Read<short >(Pointer+1440); set { SdkMemory.Write(Pointer+1440,value); } }
    [NativeMember("m_fTrainSpeed")]
    public float @TrainSpeed { get => SdkMemory.Read<float >(Pointer+1444); set { SdkMemory.Write(Pointer+1444,value); } }
    [NativeMember("m_fCurrentRailDistance")]
    public float @CurrentRailDistance { get => SdkMemory.Read<float >(Pointer+1448); set { SdkMemory.Write(Pointer+1448,value); } }
    [NativeMember("m_fLength")]
    public float @Length { get => SdkMemory.Read<float >(Pointer+1452); set { SdkMemory.Write(Pointer+1452,value); } }
    [NativeMember("m_fTrainGas")]
    public float @TrainGas { get => SdkMemory.Read<float >(Pointer+1456); set { SdkMemory.Write(Pointer+1456,value); } }
    [NativeMember("m_fTrainBrake")]
    public float @TrainBrake { get => SdkMemory.Read<float >(Pointer+1460); set { SdkMemory.Write(Pointer+1460,value); } }
    [NativeMember("m_nTrainFlags")]
    public CTrain___unnamed__at_D__plugin_sdk_plugin_sa_game_sa_CTrain_h_55_5__08fafcda5c @TrainFlags { get => new CTrain___unnamed__at_D__plugin_sdk_plugin_sa_game_sa_CTrain_h_55_5__08fafcda5c(Pointer+1464); set { SdkMemory.Copy(value.Pointer,Pointer+1464,2); } }
    [NativeMember("m_nTimeWhenStoppedAtStation")]
    public int @TimeWhenStoppedAtStation { get => SdkMemory.Read<int >(Pointer+1468); set { SdkMemory.Write(Pointer+1468,value); } }
    [NativeMember("m_nTrackId")]
    public sbyte @TrackId { get => SdkMemory.Read<sbyte >(Pointer+1472); set { SdkMemory.Write(Pointer+1472,value); } }
    [NativeMember("m_nTimeWhenCreated")]
    public int @TimeWhenCreated { get => SdkMemory.Read<int >(Pointer+1476); set { SdkMemory.Write(Pointer+1476,value); } }
    [NativeMember("field_5C8")]
    public short @Field5C8 { get => SdkMemory.Read<short >(Pointer+1480); set { SdkMemory.Write(Pointer+1480,value); } }
    [NativeMember("m_nPassengersGenerationState")]
    public byte @PassengersGenerationState { get => SdkMemory.Read<byte >(Pointer+1482); set { SdkMemory.Write(Pointer+1482,value); } }
    [NativeMember("m_nNumPassengersToLeave")]
    public byte @CountPassengersToLeave { get => (byte)SdkMemory.ReadBits(Pointer,11864,4); set { SdkMemory.WriteBits(Pointer,11864,4,unchecked((ulong)value)); } }
    [NativeMember("m_nNumPassengersToEnter")]
    public byte @CountPassengersToEnter { get => (byte)SdkMemory.ReadBits(Pointer,11868,4); set { SdkMemory.WriteBits(Pointer,11868,4,unchecked((ulong)value)); } }
    [NativeMember("m_pTemporaryPassenger")]
    public CPed? @TemporaryPassenger { get => SdkMemory.Read<IntPtr>(Pointer+1484) == IntPtr.Zero ? null : new CPed(SdkMemory.Read<IntPtr>(Pointer+1484)); set { SdkMemory.Write(Pointer+1484,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_pPrevCarriage")]
    public CTrain? @PrevCarriage { get => SdkMemory.Read<IntPtr>(Pointer+1488) == IntPtr.Zero ? null : new CTrain(SdkMemory.Read<IntPtr>(Pointer+1488)); set { SdkMemory.Write(Pointer+1488,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_pNextCarriage")]
    public CTrain? @NextCarriage { get => SdkMemory.Read<IntPtr>(Pointer+1492) == IntPtr.Zero ? null : new CTrain(SdkMemory.Read<IntPtr>(Pointer+1492)); set { SdkMemory.Write(Pointer+1492,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_aDoors")]
    public NativeObjectArray<CDoor> @Doors { get => new NativeObjectArray<CDoor>(Pointer+1496,6,24); }
    [NativeMember("m_aTrainNodes")]
    public NativeArray<IntPtr> @TrainNodes { get => new NativeArray<IntPtr>(Pointer+1640,17); }
    [NativeMember("GenTrain_Track")]
    public static uint @GenTrainTrack { get => SdkMemory.Read<uint >(new IntPtr(0xC37FFC)); set { SdkMemory.Write(new IntPtr(0xC37FFC),value); } }
    [NativeMember("GenTrain_TrainConfig")]
    public static uint @GenTrainTrainConfig { get => SdkMemory.Read<uint >(new IntPtr(0xC38000)); set { SdkMemory.Write(new IntPtr(0xC38000),value); } }
    [NativeMember("GenTrain_Direction")]
    public static byte @GenTrainDirection { get => SdkMemory.Read<byte >(new IntPtr(0xC38004)); set { SdkMemory.Write(new IntPtr(0xC38004),value); } }
    [NativeMember("GenTrain_GenerationNode")]
    public static uint @GenTrainGenerationNode { get => SdkMemory.Read<uint >(new IntPtr(0xC38008)); set { SdkMemory.Write(new IntPtr(0xC38008),value); } }
    [NativeMember("GenTrain_Status")]
    public static uint @GenTrainStatus { get => SdkMemory.Read<uint >(new IntPtr(0xC3800C)); set { SdkMemory.Write(new IntPtr(0xC3800C),value); } }
    [NativeMember("bDisableRandomTrains")]
    public static bool @DisableRandomTrainsValue { get => SdkMemory.Read<bool >(new IntPtr(0xC38010)); set { SdkMemory.Write(new IntPtr(0xC38010),value); } }
    [NativeMember("aStationCoors")]
    public static CVector? @StationCoors { get => new IntPtr(0x8D48F8) == IntPtr.Zero ? null : new CVector(new IntPtr(0x8D48F8)); }
    public void @InitializeAt(int @modelIndex,byte @createdBy) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4229 >(4229)(Pointer,@modelIndex,@createdBy); }
    public bool @FindMaximumSpeedToStopAtStations(NativePointer<float> @speed) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4230 >(4230)(Pointer,@speed.Pointer); return __sdkResult != 0; }
    public uint @FindNumCarriagesPulled() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4231 >(4231)(Pointer); return __sdkResult; }
    public void @OpenTrainDoor(float @state) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4232 >(4232)(Pointer,@state); }
    public void @AddPassenger(CPed? @ped) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4233 >(4233)(Pointer,@ped?.Pointer ?? IntPtr.Zero); }
    public void @RemovePassenger(CPed? @ped) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4234 >(4234)(Pointer,@ped?.Pointer ?? IntPtr.Zero); }
    public bool @FindSideStationIsOn() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4235 >(4235)(Pointer); return __sdkResult != 0; }
    public bool @IsInTunnel() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4236 >(4236)(Pointer); return __sdkResult != 0; }
    public void @RemoveRandomPassenger() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4237 >(4237)(Pointer); }
    public void @FindPositionOnTrackFromCoors() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4238 >(4238)(Pointer); }
    public void @AddNearbyPedAsRandomPassenger() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4239 >(4239)(Pointer); }
    public static void @ReadAndInterpretTrackFile(NativePointer<sbyte> @filename,NativePointer<IntPtr> @nodes,NativePointer<int> @lineCount,NativePointer<float> @totalDist,int @skipStations) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4240 >(4240)(@filename.Pointer,@nodes.Pointer,@lineCount.Pointer,@totalDist.Pointer,@skipStations); }
    public static void @Shutdown() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4241 >(4241)(); }
    public static void @UpdateTrains() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4242 >(4242)(); }
    public static void @FindCoorsFromPositionOnTrack(float @railDistance,int @trackId,CVector? @outCoors) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4243 >(4243)(@railDistance,@trackId,@outCoors?.Pointer ?? IntPtr.Zero); }
    public static void @DisableRandomTrains(bool @disable) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4244 >(4244)((@disable ? 1 : 0)); }
    public static void @RemoveOneMissionTrain(CTrain? @train) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4245 >(4245)(@train?.Pointer ?? IntPtr.Zero); }
    public static void @ReleaseOneMissionTrain(CTrain? @train) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4246 >(4246)(@train?.Pointer ?? IntPtr.Zero); }
    public static void @SetTrainSpeed(CTrain? @train,float @speed) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4247 >(4247)(@train?.Pointer ?? IntPtr.Zero,@speed); }
    public static void @SetTrainCruiseSpeed(CTrain? @arg0,float @cruiseSpeed) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4248 >(4248)(@arg0?.Pointer ?? IntPtr.Zero,@cruiseSpeed); }
    public static CTrain? @FindCaboose(CTrain? @train) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4249 >(4249)(@train?.Pointer ?? IntPtr.Zero); return __sdkResult == IntPtr.Zero ? null : new CTrain(__sdkResult); }
    public static CTrain? @FindEngine(CTrain? @train) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4250 >(4250)(@train?.Pointer ?? IntPtr.Zero); return __sdkResult == IntPtr.Zero ? null : new CTrain(__sdkResult); }
    public static CTrain? @FindCarriage(CTrain? @train,byte @carriage) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4251 >(4251)(@train?.Pointer ?? IntPtr.Zero,@carriage); return __sdkResult == IntPtr.Zero ? null : new CTrain(__sdkResult); }
    public static void @FindNextStationPositionInDirection(bool @clockwiseDirection,float @distance,NativePointer<float> @distanceToStation,NativePointer<int> @numStations) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4252 >(4252)((@clockwiseDirection ? 1 : 0),@distance,@distanceToStation.Pointer,@numStations.Pointer); }
    public static void @RemoveMissionTrains() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4253 >(4253)(); }
    public static void @RemoveAllTrains() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4254 >(4254)(); }
    public static void @ReleaseMissionTrains() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4255 >(4255)(); }
    public static int @FindClosestTrackNode(CVector @posn,NativePointer<int> @outTrackId) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4256 >(4256)(@posn.Pointer,@outTrackId.Pointer); return __sdkResult; }
    public static CTrain? @FindNearestTrain(CVector @posn,bool @mustBeMainTrain) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4257 >(4257)(@posn.Pointer,(@mustBeMainTrain ? 1 : 0)); return __sdkResult == IntPtr.Zero ? null : new CTrain(__sdkResult); }
    public static void @SetNewTrainPosition(CTrain? @train,CVector @posn) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4258 >(4258)(@train?.Pointer ?? IntPtr.Zero,@posn.Pointer); }
    public static bool @IsNextStationAllowed(CTrain? @train) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4259 >(4259)(@train?.Pointer ?? IntPtr.Zero); return __sdkResult != 0; }
    public static void @SkipToNextAllowedStation(CTrain? @train) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4260 >(4260)(@train?.Pointer ?? IntPtr.Zero); }
    public static void @InitTrains() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4261 >(4261)(); }
    public static void @CreateMissionTrain(CVector @posn,bool @clockwiseDirection,uint @trainType,NativePointer<IntPtr> @outFirstCarriage,NativePointer<IntPtr> @outLastCarriage,int @nodeIndex,int @trackId,bool @isMissionTrain) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4262 >(4262)(@posn.Pointer,(@clockwiseDirection ? 1 : 0),@trainType,@outFirstCarriage.Pointer,@outLastCarriage.Pointer,@nodeIndex,@trackId,(@isMissionTrain ? 1 : 0)); }
    public static void @DoTrainGenerationAndRemoval() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4263 >(4263)(); }
}
