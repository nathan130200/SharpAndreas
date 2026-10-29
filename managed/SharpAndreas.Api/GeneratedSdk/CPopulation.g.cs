// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CPopulation : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=1;
    public CPopulation(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("PedDensityMultiplier")]
    public static float @PedDensityMultiplier { get => SdkMemory.Read<float >(new IntPtr(0x8D2530)); set { SdkMemory.Write(new IntPtr(0x8D2530),value); } }
    [NativeMember("m_AllRandomPedsThisType")]
    public static int @AllRandomPedsThisType { get => SdkMemory.Read<int >(new IntPtr(0x8D2534)); set { SdkMemory.Write(new IntPtr(0x8D2534),value); } }
    [NativeMember("MaxNumberOfPedsInUse")]
    public static uint @MaxNumberOfPedsInUse { get => SdkMemory.Read<uint >(new IntPtr(0x8D2538)); set { SdkMemory.Write(new IntPtr(0x8D2538),value); } }
    [NativeMember("NumberOfPedsInUseInterior")]
    public static uint @NumberOfPedsInUseInterior { get => SdkMemory.Read<uint >(new IntPtr(0x8D253C)); set { SdkMemory.Write(new IntPtr(0x8D253C),value); } }
    [NativeMember("m_TranslationArray")]
    public static tPedGroupTranslationData? @TranslationArray { get => new IntPtr(0x8D2540) == IntPtr.Zero ? null : new tPedGroupTranslationData(new IntPtr(0x8D2540)); }
    [NativeMember("m_LoadedBoats")]
    public static CLoadedCarGroup @LoadedBoats { get => new CLoadedCarGroup(new IntPtr(0xC0E998)); set { SdkMemory.Copy(value.Pointer,new IntPtr(0xC0E998),46); } }
    [NativeMember("m_InAppropriateLoadedCars")]
    public static CLoadedCarGroup @InAppropriateLoadedCars { get => new CLoadedCarGroup(new IntPtr(0xC0E9C8)); set { SdkMemory.Copy(value.Pointer,new IntPtr(0xC0E9C8),46); } }
    [NativeMember("m_AppropriateLoadedCars")]
    public static CLoadedCarGroup @AppropriateLoadedCars { get => new CLoadedCarGroup(new IntPtr(0xC0E9F8)); set { SdkMemory.Copy(value.Pointer,new IntPtr(0xC0E9F8),46); } }
    [NativeMember("m_LoadedGangCars")]
    public static CLoadedCarGroup? @LoadedGangCars { get => new IntPtr(0xC0EA28) == IntPtr.Zero ? null : new CLoadedCarGroup(new IntPtr(0xC0EA28)); }
    [NativeMember("bZoneChangeHasHappened")]
    public static bool @ZoneChangeHasHappened { get => SdkMemory.Read<bool >(new IntPtr(0xC0EC22)); set { SdkMemory.Write(new IntPtr(0xC0EC22),value); } }
    [NativeMember("m_CountDownToPedsAtStart")]
    public static byte @CountDownToPedsAtStart { get => SdkMemory.Read<byte >(new IntPtr(0xC0EC23)); set { SdkMemory.Write(new IntPtr(0xC0EC23),value); } }
    [NativeMember("ms_nTotalMissionPeds")]
    public static uint @TotalMissionPeds { get => SdkMemory.Read<uint >(new IntPtr(0xC0EC24)); set { SdkMemory.Write(new IntPtr(0xC0EC24),value); } }
    [NativeMember("ms_nTotalPeds")]
    public static uint @TotalPeds { get => SdkMemory.Read<uint >(new IntPtr(0xC0EC28)); set { SdkMemory.Write(new IntPtr(0xC0EC28),value); } }
    [NativeMember("ms_nTotalGangPeds")]
    public static uint @TotalGangPeds { get => SdkMemory.Read<uint >(new IntPtr(0xC0EC2C)); set { SdkMemory.Write(new IntPtr(0xC0EC2C),value); } }
    [NativeMember("ms_nTotalCivPeds")]
    public static uint @TotalCivPeds { get => SdkMemory.Read<uint >(new IntPtr(0xC0EC30)); set { SdkMemory.Write(new IntPtr(0xC0EC30),value); } }
    [NativeMember("ms_nTotalCarPassengerPeds")]
    public static uint @TotalCarPassengerPeds { get => SdkMemory.Read<uint >(new IntPtr(0xC0EC34)); set { SdkMemory.Write(new IntPtr(0xC0EC34),value); } }
    [NativeMember("ms_nNumDealers")]
    public static uint @CountDealers { get => SdkMemory.Read<uint >(new IntPtr(0xC0EC38)); set { SdkMemory.Write(new IntPtr(0xC0EC38),value); } }
    [NativeMember("ms_nNumGang")]
    public static NativePointer<uint> @CountGang { get => new NativePointer<uint>(new IntPtr(0xC0EC3C)); }
    [NativeMember("ms_nNumEmergency")]
    public static uint @CountEmergency { get => SdkMemory.Read<uint >(new IntPtr(0xC0EC64)); set { SdkMemory.Write(new IntPtr(0xC0EC64),value); } }
    [NativeMember("ms_nNumCop")]
    public static uint @CountCop { get => SdkMemory.Read<uint >(new IntPtr(0xC0EC68)); set { SdkMemory.Write(new IntPtr(0xC0EC68),value); } }
    [NativeMember("ms_nNumCivFemale")]
    public static uint @CountCivFemale { get => SdkMemory.Read<uint >(new IntPtr(0xC0EC6C)); set { SdkMemory.Write(new IntPtr(0xC0EC6C),value); } }
    [NativeMember("ms_nNumCivMale")]
    public static uint @CountCivMale { get => SdkMemory.Read<uint >(new IntPtr(0xC0EC70)); set { SdkMemory.Write(new IntPtr(0xC0EC70),value); } }
    [NativeMember("m_nNumCarsInGroup")]
    public static NativePointer<ushort> @CountCarsInGroup { get => new NativePointer<ushort>(new IntPtr(0xC0EC78)); }
    [NativeMember("m_nNumPedsInGroup")]
    public static NativePointer<ushort> @CountPedsInGroup { get => new NativePointer<ushort>(new IntPtr(0xC0ECC0)); }
    [NativeMember("m_CarGroups")]
    public static NativeArray<short> @CarGroups { get => new NativeArray<short>(new IntPtr(0xC0ED38),23); }
    [NativeMember("m_PedGroups")]
    public static NativeArray<short> @PedGroups { get => new NativeArray<short>(new IntPtr(0xC0F358),21); }
    [NativeMember("m_bDontCreateRandomGangMembers")]
    public static bool @DontCreateRandomGangMembers { get => SdkMemory.Read<bool >(new IntPtr(0xC0FCB2)); set { SdkMemory.Write(new IntPtr(0xC0FCB2),value); } }
    [NativeMember("m_bOnlyCreateRandomGangMembers")]
    public static bool @OnlyCreateRandomGangMembers { get => SdkMemory.Read<bool >(new IntPtr(0xC0FCB3)); set { SdkMemory.Write(new IntPtr(0xC0FCB3),value); } }
    [NativeMember("m_bDontCreateRandomCops")]
    public static bool @DontCreateRandomCops { get => SdkMemory.Read<bool >(new IntPtr(0xC0FCB4)); set { SdkMemory.Write(new IntPtr(0xC0FCB4),value); } }
    [NativeMember("m_bMoreCarsAndFewerPeds")]
    public static bool @MoreCarsAndFewerPeds { get => SdkMemory.Read<bool >(new IntPtr(0xC0FCB5)); set { SdkMemory.Write(new IntPtr(0xC0FCB5),value); } }
    [NativeMember("bInPoliceStation")]
    public static bool @InPoliceStation { get => SdkMemory.Read<bool >(new IntPtr(0xC0FCB6)); set { SdkMemory.Write(new IntPtr(0xC0FCB6),value); } }
    [NativeMember("NumMiamiViceCops")]
    public static uint @CountMiamiViceCops { get => SdkMemory.Read<uint >(new IntPtr(0xC0FCB8)); set { SdkMemory.Write(new IntPtr(0xC0FCB8),value); } }
    [NativeMember("CurrentWorldZone")]
    public static uint @CurrentWorldZone { get => SdkMemory.Read<uint >(new IntPtr(0xC0FCBC)); set { SdkMemory.Write(new IntPtr(0xC0FCBC),value); } }
    public static int @FindPedRaceFromName(NativePointer<sbyte> @modelName) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3431 >(3431)(@modelName.Pointer); return __sdkResult; }
    public static void @LoadPedGroups() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3432 >(3432)(); }
    public static void @LoadCarGroups() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3433 >(3433)(); }
    public static void @Initialise() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3434 >(3434)(); }
    public static void @Shutdown() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3435 >(3435)(); }
    public static float @FindDummyDistForModel(int @modelIndex) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3436 >(3436)(@modelIndex); return __sdkResult; }
    public static float @FindPedDensityMultiplierCullZone() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3437 >(3437)(); return __sdkResult; }
    public static void @RemovePed(CPed? @ped) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3438 >(3438)(@ped?.Pointer ?? IntPtr.Zero); }
    public static int @ChoosePolicePedOccupation() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3439 >(3439)(); return __sdkResult; }
    public static bool @ArePedStatsCompatible(int @statType1,int @statType2) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3440 >(3440)(@statType1,@statType2); return __sdkResult != 0; }
    public static bool @PedMICanBeCreatedAtAttractor(int @modelIndex) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3441 >(3441)(@modelIndex); return __sdkResult != 0; }
    public static bool @PedMICanBeCreatedAtThisAttractor(int @modelIndex,NativePointer<sbyte> @attrName) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3442 >(3442)(@modelIndex,@attrName.Pointer); return __sdkResult != 0; }
    public static bool @PedMICanBeCreatedInInterior(int @modelIndex) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3443 >(3443)(@modelIndex); return __sdkResult != 0; }
    public static bool @IsMale(int @modelIndex) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3444 >(3444)(@modelIndex); return __sdkResult != 0; }
    public static bool @IsFemale(int @modelIndex) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3445 >(3445)(@modelIndex); return __sdkResult != 0; }
    public static bool @IsSecurityGuard(ePedType @pedType) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3446 >(3446)((int)@pedType); return __sdkResult != 0; }
    public static bool @IsSkateable(CVector @point) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3447 >(3447)(@point.Pointer); return __sdkResult != 0; }
    public static void @ChooseGangOccupation(int @arg0) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3448 >(3448)(@arg0); }
    public static CPed? @AddExistingPedInCar(CPed? @ped,CVehicle? @vehicle) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3449 >(3449)(@ped?.Pointer ?? IntPtr.Zero,@vehicle?.Pointer ?? IntPtr.Zero); return __sdkResult == IntPtr.Zero ? null : new CPed(__sdkResult); }
    public static void @UpdatePedCount(CPed? @ped,byte @updateState) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3450 >(3450)(@ped?.Pointer ?? IntPtr.Zero,@updateState); }
    public static void @MoveCarsAndPedsOutOfAbandonedZones() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3451 >(3451)(); }
    public static void @DealWithZoneChange(eLevelName @arg0,eLevelName @arg1,bool @arg2) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3452 >(3452)((int)@arg0,(int)@arg1,(@arg2 ? 1 : 0)); }
    public static float @PedCreationDistMultiplier() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3453 >(3453)(); return __sdkResult; }
    public static bool @IsSunbather(int @modelIndex) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3454 >(3454)(@modelIndex); return __sdkResult != 0; }
    public static bool @CanSolicitPlayerOnFoot(int @modelIndex) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3455 >(3455)(@modelIndex); return __sdkResult != 0; }
    public static bool @CanSolicitPlayerInCar(int @modelIndex) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3456 >(3456)(@modelIndex); return __sdkResult != 0; }
    public static bool @CanJeerAtStripper(int @modelIndex) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3457 >(3457)(@modelIndex); return __sdkResult != 0; }
    public static void @PlaceGangMembers(ePedType @pedType,int @arg1,CVector @posn) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3458 >(3458)((int)@pedType,@arg1,@posn.Pointer); }
    public static void @LoadSpecificDriverModelsForCar(int @carModelIndex) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3459 >(3459)(@carModelIndex); }
    public static int @FindSpecificDriverModelForCar_ToUse(int @carModelIndex) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3460 >(3460)(@carModelIndex); return __sdkResult; }
    public static void @RemoveSpecificDriverModelsForCar(int @carModelIndex) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3461 >(3461)(@carModelIndex); }
    public static bool @IsCorrectTimeOfDayForEffect(C2dEffect? @effect) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3462 >(3462)(@effect?.Pointer ?? IntPtr.Zero); return __sdkResult != 0; }
    public static float @FindCarMultiplierMotorway() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3463 >(3463)(); return __sdkResult; }
    public static float @FindPedMultiplierMotorway() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3464 >(3464)(); return __sdkResult; }
    public static void @ManagePed(CPed? @ped,CVector @playerPosn) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3465 >(3465)(@ped?.Pointer ?? IntPtr.Zero,@playerPosn.Pointer); }
    public static int @FindNumberOfPedsWeCanPlaceOnBenches() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3466 >(3466)(); return __sdkResult; }
    public static void @RemoveAllRandomPeds() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3467 >(3467)(); }
    public static bool @TestRoomForDummyObject(CObject? @object) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3468 >(3468)(@object?.Pointer ?? IntPtr.Zero); return __sdkResult != 0; }
    public static bool @TestSafeForRealObject(CDummyObject? @dummyObject) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3469 >(3469)(@dummyObject?.Pointer ?? IntPtr.Zero); return __sdkResult != 0; }
    public static CPed? @AddPed(ePedType @pedType,uint @modelIndex,CVector @posn,bool @makeWander) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3470 >(3470)((int)@pedType,@modelIndex,@posn.Pointer,(@makeWander ? 1 : 0)); return __sdkResult == IntPtr.Zero ? null : new CPed(__sdkResult); }
    public static CPed? @AddDeadPedInFrontOfCar(CVector @posn,CVehicle? @vehicle) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3471 >(3471)(@posn.Pointer,@vehicle?.Pointer ?? IntPtr.Zero); return __sdkResult == IntPtr.Zero ? null : new CPed(__sdkResult); }
    public static int @ChooseCivilianOccupation(bool @male,bool @female,int @animType,int @ignoreModelIndex,int @statType,bool @arg5,bool @arg6,bool @checkAttractor,NativePointer<sbyte> @attrName) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3472 >(3472)((@male ? 1 : 0),(@female ? 1 : 0),@animType,@ignoreModelIndex,@statType,(@arg5 ? 1 : 0),(@arg6 ? 1 : 0),(@checkAttractor ? 1 : 0),@attrName.Pointer); return __sdkResult; }
    public static void @ChooseCivilianCoupleOccupations(NativePointer<int> @model1,NativePointer<int> @model2) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3473 >(3473)(@model1.Pointer,@model2.Pointer); }
    public static int @ChooseCivilianOccupationForVehicle(bool @male,CVehicle? @vehicle) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3474 >(3474)((@male ? 1 : 0),@vehicle?.Pointer ?? IntPtr.Zero); return __sdkResult; }
    public static void @CreateWaitingCoppers(CVector @posn,float @arg1) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3475 >(3475)(@posn.Pointer,@arg1); }
    public static CPed? @AddPedInCar(CVehicle? @vehicle,bool @driver,int @gangPedType,int @seatNumber,bool @male,bool @criminal) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3476 >(3476)(@vehicle?.Pointer ?? IntPtr.Zero,(@driver ? 1 : 0),@gangPedType,@seatNumber,(@male ? 1 : 0),(@criminal ? 1 : 0)); return __sdkResult == IntPtr.Zero ? null : new CPed(__sdkResult); }
    public static void @PlaceMallPedsAsStationaryGroup(CVector @posn) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3477 >(3477)(@posn.Pointer); }
    public static void @PlaceCouple(ePedType @pedType1,int @modelIndex1,ePedType @pedType2,int @modelIndex2,CVector @posn) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3478 >(3478)((int)@pedType1,@modelIndex1,(int)@pedType2,@modelIndex2,@posn.Pointer); }
    public static bool @AddPedAtAttractor(int @modelIndex,C2dEffect? @attractor,CVector @posn,CEntity? @entity,int @decisionMakerType) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3479 >(3479)(@modelIndex,@attractor?.Pointer ?? IntPtr.Zero,@posn.Pointer,@entity?.Pointer ?? IntPtr.Zero,@decisionMakerType); return __sdkResult != 0; }
    public static float @FindDistanceToNearestPedOfType(ePedType @pedType,CVector @posn) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3480 >(3480)((int)@pedType,@posn.Pointer); return __sdkResult; }
    public static int @PickGangCar(int @gangId) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3481 >(3481)(@gangId); return __sdkResult; }
    public static int @PickRiotRoadBlockCar() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3482 >(3482)(); return __sdkResult; }
    public static void @ConvertToRealObject(CDummyObject? @dummyObject) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3483 >(3483)(@dummyObject?.Pointer ?? IntPtr.Zero); }
    public static void @ConvertToDummyObject(CObject? @object) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3484 >(3484)(@object?.Pointer ?? IntPtr.Zero); }
    public static bool @AddToPopulation(float @arg0,float @arg1,float @arg2,float @arg3) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3485 >(3485)(@arg0,@arg1,@arg2,@arg3); return __sdkResult != 0; }
    public static int @GeneratePedsAtAttractors(CVector @posn,float @arg1,float @arg2,float @arg3,float @arg4,int @decisionMakerType,int @numPeds) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3486 >(3486)(@posn.Pointer,@arg1,@arg2,@arg3,@arg4,@decisionMakerType,@numPeds); return __sdkResult; }
    public static void @GeneratePedsAtStartOfGame() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3487 >(3487)(); }
    public static void @ManageObject(CObject? @object,CVector @posn) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3488 >(3488)(@object?.Pointer ?? IntPtr.Zero,@posn.Pointer); }
    public static void @ManageDummy(CDummy? @dummy,CVector @posn) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3489 >(3489)(@dummy?.Pointer ?? IntPtr.Zero,@posn.Pointer); }
    public static void @ManageAllPopulation() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3490 >(3490)(); }
    public static void @ManagePopulation() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3491 >(3491)(); }
    public static void @RemovePedsIfThePoolGetsFull() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3492 >(3492)(); }
    public static void @ConvertAllObjectsToDummyObjects() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3493 >(3493)(); }
    public static void @PopulateInterior(int @numPeds,CVector @posn) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3494 >(3494)(@numPeds,@posn.Pointer); }
    public static void @Update(bool @generatePeds) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3495 >(3495)((@generatePeds ? 1 : 0)); }
}
