// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CCarCtrl : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=1;
    public CCarCtrl(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("bCarIsBeingCreated")]
    public static bool @CarIsBeingCreated { get => SdkMemory.Read<bool >(new IntPtr(0x9690CC)); set { SdkMemory.Write(new IntPtr(0x9690CC),value); } }
    [NativeMember("NumLawEnforcerCars")]
    public static uint @CountLawEnforcerCars { get => SdkMemory.Read<uint >(new IntPtr(0x969098)); set { SdkMemory.Write(new IntPtr(0x969098),value); } }
    [NativeMember("NumParkedCars")]
    public static uint @CountParkedCars { get => SdkMemory.Read<uint >(new IntPtr(0x9690A0)); set { SdkMemory.Write(new IntPtr(0x9690A0),value); } }
    [NativeMember("NumAmbulancesOnDuty")]
    public static uint @CountAmbulancesOnDuty { get => SdkMemory.Read<uint >(new IntPtr(0x9690A8)); set { SdkMemory.Write(new IntPtr(0x9690A8),value); } }
    [NativeMember("NumFireTrucksOnDuty")]
    public static uint @CountFireTrucksOnDuty { get => SdkMemory.Read<uint >(new IntPtr(0x9690AC)); set { SdkMemory.Write(new IntPtr(0x9690AC),value); } }
    [NativeMember("MaxNumberOfCarsInUse")]
    public static uint @MaxNumberOfCarsInUse { get => SdkMemory.Read<uint >(new IntPtr(0x8A5B24)); set { SdkMemory.Write(new IntPtr(0x8A5B24),value); } }
    [NativeMember("CarDensityMultiplier")]
    public static float @CarDensityMultiplier { get => SdkMemory.Read<float >(new IntPtr(0x8A5B20)); set { SdkMemory.Write(new IntPtr(0x8A5B20),value); } }
    [NativeMember("NumRandomCars")]
    public static int @CountRandomCars { get => SdkMemory.Read<int >(new IntPtr(0x969094)); set { SdkMemory.Write(new IntPtr(0x969094),value); } }
    [NativeMember("NumMissionCars")]
    public static int @CountMissionCars { get => SdkMemory.Read<int >(new IntPtr(0x96909C)); set { SdkMemory.Write(new IntPtr(0x96909C),value); } }
    [NativeMember("NumPermanentVehicles")]
    public static int @CountPermanentVehicles { get => SdkMemory.Read<int >(new IntPtr(0x9690A4)); set { SdkMemory.Write(new IntPtr(0x9690A4),value); } }
    [NativeMember("LastTimeAmbulanceCreated")]
    public static int @LastTimeAmbulanceCreated { get => SdkMemory.Read<int >(new IntPtr(0x9690B0)); set { SdkMemory.Write(new IntPtr(0x9690B0),value); } }
    [NativeMember("LastTimeFireTruckCreated")]
    public static int @LastTimeFireTruckCreated { get => SdkMemory.Read<int >(new IntPtr(0x9690B4)); set { SdkMemory.Write(new IntPtr(0x9690B4),value); } }
    [NativeMember("bAllowEmergencyServicesToBeCreated")]
    public static bool @AllowEmergencyServicesToBeCreated { get => SdkMemory.Read<bool >(new IntPtr(0x8A5B28)); set { SdkMemory.Write(new IntPtr(0x8A5B28),value); } }
    [NativeMember("bCarsGeneratedAroundCamera")]
    public static bool @CarsGeneratedAroundCamera { get => SdkMemory.Read<bool >(new IntPtr(0x9690C1)); set { SdkMemory.Write(new IntPtr(0x9690C1),value); } }
    [NativeMember("CountDownToCarsAtStart")]
    public static sbyte @CountDownToCarsAtStart { get => SdkMemory.Read<sbyte >(new IntPtr(0x9690C0)); set { SdkMemory.Write(new IntPtr(0x9690C0),value); } }
    [NativeMember("TimeNextMadDriverChaseCreated")]
    public static float @TimeNextMadDriverChaseCreated { get => SdkMemory.Read<float >(new IntPtr(0x9690BC)); set { SdkMemory.Write(new IntPtr(0x9690BC),value); } }
    [NativeMember("SequenceElements")]
    public static int @SequenceElements { get => SdkMemory.Read<int >(new IntPtr(0x969078)); set { SdkMemory.Write(new IntPtr(0x969078),value); } }
    [NativeMember("SequenceRandomOffset")]
    public static int @SequenceRandomOffset { get => SdkMemory.Read<int >(new IntPtr(0x969074)); set { SdkMemory.Write(new IntPtr(0x969074),value); } }
    [NativeMember("bSequenceOtherWay")]
    public static bool @SequenceOtherWay { get => SdkMemory.Read<bool >(new IntPtr(0x969070)); set { SdkMemory.Write(new IntPtr(0x969070),value); } }
    [NativeMember("LastTimeLawEnforcerCreated")]
    public static int @LastTimeLawEnforcerCreated { get => SdkMemory.Read<int >(new IntPtr(0x9690B8)); set { SdkMemory.Write(new IntPtr(0x9690B8),value); } }
    [NativeMember("apCarsToKeep")]
    public static NativeArray<IntPtr> @CarsToKeep { get => new NativeArray<IntPtr>(new IntPtr(0x969084),2); }
    [NativeMember("aCarsToKeepTime")]
    public static NativeArray<uint> @CarsToKeepTime { get => new NativeArray<uint>(new IntPtr(0x96907C),2); }
    public static int @ChooseBoatModel() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1753 >(1753)(); return __sdkResult; }
    public static int @ChooseCarModelToLoad(int @arg1) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1754 >(1754)(@arg1); return __sdkResult; }
    public static int @ChooseGangCarModel(int @arg1) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1755 >(1755)(@arg1); return __sdkResult; }
    public static int @ChooseModel(NativePointer<int> @arg1) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1756 >(1756)(@arg1.Pointer); return __sdkResult; }
    public static int @ChoosePoliceCarModel(uint @arg0) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1757 >(1757)(@arg0); return __sdkResult; }
    public static void @ClearInterestingVehicleList() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1758 >(1758)(); }
    public static void @ClipTargetOrientationToLink(CVehicle? @pVehicle,CCarPathLinkAddress @arg2,sbyte @arg3,NativePointer<float> @arg4,float @arg5,float @arg6) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1759 >(1759)(@pVehicle?.Pointer ?? IntPtr.Zero,@arg2.Pointer,@arg3,@arg4.Pointer,@arg5,@arg6); }
    public static CVehicle? @CreateCarForScript(int @modelid,CVector @posn,byte @MissionCleanUpFlag) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1760 >(1760)(@modelid,@posn.Pointer,@MissionCleanUpFlag); return __sdkResult == IntPtr.Zero ? null : new CVehicle(__sdkResult); }
    public static bool @CreateConvoy(CVehicle? @pVehicle,int @arg2) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1761 >(1761)(@pVehicle?.Pointer ?? IntPtr.Zero,@arg2); return __sdkResult != 0; }
    public static bool @CreatePoliceChase(CVehicle? @pVehicle,int @arg2,CNodeAddress @NodeAddress) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1762 >(1762)(@pVehicle?.Pointer ?? IntPtr.Zero,@arg2,@NodeAddress.Pointer); return __sdkResult != 0; }
    public static bool @DealWithBend_Racing(CVehicle? @pVehicle,CCarPathLinkAddress @LinkAddress1,CCarPathLinkAddress @LinkAddress2,CCarPathLinkAddress @LinkAddress3,CCarPathLinkAddress @LinkAddress4,sbyte @arg6,sbyte @arg7,sbyte @arg8,sbyte @arg9,float @arg10,NativePointer<float> @arg11,NativePointer<float> @arg12,NativePointer<float> @arg13,NativePointer<float> @arg14,CVector? @pVector) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1763 >(1763)(@pVehicle?.Pointer ?? IntPtr.Zero,@LinkAddress1.Pointer,@LinkAddress2.Pointer,@LinkAddress3.Pointer,@LinkAddress4.Pointer,@arg6,@arg7,@arg8,@arg9,@arg10,@arg11.Pointer,@arg12.Pointer,@arg13.Pointer,@arg14.Pointer,@pVector?.Pointer ?? IntPtr.Zero); return __sdkResult != 0; }
    public static void @DragCarToPoint(CVehicle? @pVehicle,CVector? @pVector) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1764 >(1764)(@pVehicle?.Pointer ?? IntPtr.Zero,@pVector?.Pointer ?? IntPtr.Zero); }
    public static float @FindAngleToWeaveThroughTraffic(CVehicle? @pVehicle,CPhysical? @pPhysical,float @arg3,float @arg4,float @arg5) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1765 >(1765)(@pVehicle?.Pointer ?? IntPtr.Zero,@pPhysical?.Pointer ?? IntPtr.Zero,@arg3,@arg4,@arg5); return __sdkResult; }
    public static void @FindIntersection2Lines(float @arg1,float @arg2,float @arg3,float @arg4,float @arg5,float @arg6,float @arg7,float @arg8,NativePointer<float> @arg9,NativePointer<float> @arg10) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1766 >(1766)(@arg1,@arg2,@arg3,@arg4,@arg5,@arg6,@arg7,@arg8,@arg9.Pointer,@arg10.Pointer); }
    public static void @FindLinksToGoWithTheseNodes(CVehicle? @pVehicle) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1767 >(1767)(@pVehicle?.Pointer ?? IntPtr.Zero); }
    public static float @FindMaximumSpeedForThisCarInTraffic(CVehicle? @pVehicle) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1768 >(1768)(@pVehicle?.Pointer ?? IntPtr.Zero); return __sdkResult; }
    public static void @FindNodesThisCarIsNearestTo(CVehicle? @pVehicle,CNodeAddress @NodeAddress1,CNodeAddress @NodeAddress2) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1769 >(1769)(@pVehicle?.Pointer ?? IntPtr.Zero,@NodeAddress1.Pointer,@NodeAddress2.Pointer); }
    public static sbyte @FindPathDirection(CNodeAddress @NodeAddress1,CNodeAddress @NodeAddress2,CNodeAddress @NodeAddress3,NativePointer<bool> @arg4) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1770 >(1770)(@NodeAddress1.Pointer,@NodeAddress2.Pointer,@NodeAddress3.Pointer,@arg4.Pointer); return __sdkResult; }
    public static float @FindPercDependingOnDistToLink(CVehicle? @pVehicle,CCarPathLinkAddress @LinkAddress) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1771 >(1771)(@pVehicle?.Pointer ?? IntPtr.Zero,@LinkAddress.Pointer); return __sdkResult; }
    public static int @FindSequenceElement(int @arg1) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1772 >(1772)(@arg1); return __sdkResult; }
    public static float @FindSpeedMultiplier(float @arg1,float @arg2,float @arg3,float @arg4) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1773 >(1773)(@arg1,@arg2,@arg3,@arg4); return __sdkResult; }
    public static float @FindSpeedMultiplierWithSpeedFromNodes(sbyte @arg1) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1774 >(1774)(@arg1); return __sdkResult; }
    public static void @FireHeliRocketsAtTarget(CAutomobile? @pEntityLauncher,CEntity? @pEntity) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1775 >(1775)(@pEntityLauncher?.Pointer ?? IntPtr.Zero,@pEntity?.Pointer ?? IntPtr.Zero); }
    public static void @FlyAIHeliInCertainDirection(CHeli? @pHeli,float @arg2,float @arg3,bool @arg4) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1776 >(1776)(@pHeli?.Pointer ?? IntPtr.Zero,@arg2,@arg3,(@arg4 ? 1 : 0)); }
    public static void @FlyAIHeliToTarget_FixedOrientation(CHeli? @pHeli,float @Orientation,CVector @posn) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1777 >(1777)(@pHeli?.Pointer ?? IntPtr.Zero,@Orientation,@posn.Pointer); }
    public static void @FlyAIPlaneInCertainDirection(CPlane? @pPlane) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1778 >(1778)(@pPlane?.Pointer ?? IntPtr.Zero); }
    public static bool @GenerateCarCreationCoors2(CVector @posn,float @radius,float @arg3,float @arg4,bool @arg5,float @arg6,float @arg7,CVector? @pOrigin,CNodeAddress? @pNodeAddress1,CNodeAddress? @pNodeAddress12,NativePointer<float> @arg11,bool @arg12,bool @arg13) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1779 >(1779)(@posn.Pointer,@radius,@arg3,@arg4,(@arg5 ? 1 : 0),@arg6,@arg7,@pOrigin?.Pointer ?? IntPtr.Zero,@pNodeAddress1?.Pointer ?? IntPtr.Zero,@pNodeAddress12?.Pointer ?? IntPtr.Zero,@arg11.Pointer,(@arg12 ? 1 : 0),(@arg13 ? 1 : 0)); return __sdkResult != 0; }
    public static void @GenerateEmergencyServicesCar() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1780 >(1780)(); }
    public static bool @GenerateOneEmergencyServicesCar(uint @modelID,CVector @posn) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1781 >(1781)(@modelID,@posn.Pointer); return __sdkResult != 0; }
    public static void @GenerateOneRandomCar() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1782 >(1782)(); }
    public static void @GenerateRandomCars() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1783 >(1783)(); }
    public static void @GetAIHeliToAttackPlayer(CAutomobile? @pAutomobile) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1784 >(1784)(@pAutomobile?.Pointer ?? IntPtr.Zero); }
    public static void @GetAIHeliToFlyInDirection(CAutomobile? @pAutomobile) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1785 >(1785)(@pAutomobile?.Pointer ?? IntPtr.Zero); }
    public static void @GetAIPlaneToAttackPlayer(CAutomobile? @pAutomobile) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1786 >(1786)(@pAutomobile?.Pointer ?? IntPtr.Zero); }
    public static void @GetAIPlaneToDoDogFight(CAutomobile? @pAutomobile) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1787 >(1787)(@pAutomobile?.Pointer ?? IntPtr.Zero); }
    public static void @GetAIPlaneToDoDogFightAgainstPlayer(CAutomobile? @pAutomobile) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1788 >(1788)(@pAutomobile?.Pointer ?? IntPtr.Zero); }
    public static CVehicle? @GetNewVehicleDependingOnCarModel(int @modelID,byte @createdBy) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1789 >(1789)(@modelID,@createdBy); return __sdkResult == IntPtr.Zero ? null : new CVehicle(__sdkResult); }
    public static void @Init() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1790 >(1790)(); }
    public static void @InitSequence(int @SequenceElements) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1791 >(1791)(@SequenceElements); }
    public static bool @IsAnyoneParking() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1792 >(1792)(); return __sdkResult != 0; }
    public static bool @IsThisAnAppropriateNode(CVehicle? @pVehicle,CNodeAddress @NodeAddress1,CNodeAddress @NodeAddress2,CNodeAddress @NodeAddress3,bool @arg5) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1793 >(1793)(@pVehicle?.Pointer ?? IntPtr.Zero,@NodeAddress1.Pointer,@NodeAddress2.Pointer,@NodeAddress3.Pointer,(@arg5 ? 1 : 0)); return __sdkResult != 0; }
    public static bool @IsThisVehicleInteresting(CVehicle? @pVehicle) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1794 >(1794)(@pVehicle?.Pointer ?? IntPtr.Zero); return __sdkResult != 0; }
    public static void @JoinCarWithRoadAccordingToMission(CVehicle? @pVehicle) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1795 >(1795)(@pVehicle?.Pointer ?? IntPtr.Zero); }
    public static void @JoinCarWithRoadSystem(CVehicle? @pVehicle) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1796 >(1796)(@pVehicle?.Pointer ?? IntPtr.Zero); }
    public static bool @JoinCarWithRoadSystemGotoCoors(CVehicle? @pVehicle,CVector @posn,bool @unused,bool @bIsBoat) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1797 >(1797)(@pVehicle?.Pointer ?? IntPtr.Zero,@posn.Pointer,(@unused ? 1 : 0),(@bIsBoat ? 1 : 0)); return __sdkResult != 0; }
    public static bool @PickNextNodeAccordingStrategy(CVehicle? @pVehicle) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1798 >(1798)(@pVehicle?.Pointer ?? IntPtr.Zero); return __sdkResult != 0; }
    public static void @PickNextNodeRandomly(CVehicle? @pVehicle) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1799 >(1799)(@pVehicle?.Pointer ?? IntPtr.Zero); }
    public static bool @PickNextNodeToChaseCar(CVehicle? @pVehicle,float @x_dest,float @y_dest,float @z_dest) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1800 >(1800)(@pVehicle?.Pointer ?? IntPtr.Zero,@x_dest,@y_dest,@z_dest); return __sdkResult != 0; }
    public static bool @PickNextNodeToFollowPath(CVehicle? @pVehicle) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1801 >(1801)(@pVehicle?.Pointer ?? IntPtr.Zero); return __sdkResult != 0; }
    public static void @PossiblyFireHSMissile(CVehicle? @pEntityLauncher,CEntity? @pTargetEntity) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1802 >(1802)(@pEntityLauncher?.Pointer ?? IntPtr.Zero,@pTargetEntity?.Pointer ?? IntPtr.Zero); }
    public static void @PossiblyRemoveVehicle(CVehicle? @pVehicle) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1803 >(1803)(@pVehicle?.Pointer ?? IntPtr.Zero); }
    public static void @PruneVehiclesOfInterest() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1804 >(1804)(); }
    public static void @ReInit() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1805 >(1805)(); }
    public static void @ReconsiderRoute(CVehicle? @pVehicle) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1806 >(1806)(@pVehicle?.Pointer ?? IntPtr.Zero); }
    public static void @RegisterVehicleOfInterest(CVehicle? @pVehicle) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1807 >(1807)(@pVehicle?.Pointer ?? IntPtr.Zero); }
    public static void @RemoveCarsIfThePoolGetsFull() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1808 >(1808)(); }
    public static void @RemoveDistantCars() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1809 >(1809)(); }
    public static void @RemoveFromInterestingVehicleList(CVehicle? @pVehicle) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1810 >(1810)(@pVehicle?.Pointer ?? IntPtr.Zero); }
    public static void @ScanForPedDanger(CVehicle? @pVehicle) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1811 >(1811)(@pVehicle?.Pointer ?? IntPtr.Zero); }
    public static bool @ScriptGenerateOneEmergencyServicesCar(uint @modelID,CVector @posn) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1812 >(1812)(@modelID,@posn.Pointer); return __sdkResult != 0; }
    public static void @SetCoordsOfScriptCar(CVehicle? @pVehicle,float @x,float @y,float @z,byte @arg5,byte @arg6) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1813 >(1813)(@pVehicle?.Pointer ?? IntPtr.Zero,@x,@y,@z,@arg5,@arg6); }
    public static void @SetUpDriverAndPassengersForVehicle(CVehicle? @pVehicle,int @arg2,int @arg3,bool @arg4,bool @arg5,int @passengersNum) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1814 >(1814)(@pVehicle?.Pointer ?? IntPtr.Zero,@arg2,@arg3,(@arg4 ? 1 : 0),(@arg5 ? 1 : 0),@passengersNum); }
    public static void @SlowCarDownForCarsSectorList(CPtrList @PtrList,CVehicle? @pVehicle,float @arg3,float @arg4,float @arg5,float @arg6,NativePointer<float> @arg7,float @arg8) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1815 >(1815)(@PtrList.Pointer,@pVehicle?.Pointer ?? IntPtr.Zero,@arg3,@arg4,@arg5,@arg6,@arg7.Pointer,@arg8); }
    public static void @SlowCarDownForObject(CEntity? @pEntity,CVehicle? @pVehicle,NativePointer<float> @arg3,float @arg4) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1816 >(1816)(@pEntity?.Pointer ?? IntPtr.Zero,@pVehicle?.Pointer ?? IntPtr.Zero,@arg3.Pointer,@arg4); }
    public static void @SlowCarDownForObjectsSectorList(CPtrList @PtrList,CVehicle? @pVehicle,float @arg3,float @arg4,float @arg5,float @arg6,NativePointer<float> @arg7,float @arg8) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1817 >(1817)(@PtrList.Pointer,@pVehicle?.Pointer ?? IntPtr.Zero,@arg3,@arg4,@arg5,@arg6,@arg7.Pointer,@arg8); }
    public static void @SlowCarDownForOtherCar(CEntity? @pCar1,CVehicle? @pCar2,NativePointer<float> @arg3,float @arg4) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1818 >(1818)(@pCar1?.Pointer ?? IntPtr.Zero,@pCar2?.Pointer ?? IntPtr.Zero,@arg3.Pointer,@arg4); }
    public static void @SlowCarDownForPedsSectorList(CPtrList @PtrList,CVehicle? @pVehicle,float @arg3,float @arg4,float @arg5,float @arg6,NativePointer<float> @arg7,float @arg8) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1819 >(1819)(@PtrList.Pointer,@pVehicle?.Pointer ?? IntPtr.Zero,@arg3,@arg4,@arg5,@arg6,@arg7.Pointer,@arg8); }
    public static void @SlowCarOnRailsDownForTrafficAndLights(CVehicle? @pVehicle) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1820 >(1820)(@pVehicle?.Pointer ?? IntPtr.Zero); }
    public static void @SteerAIBoatWithPhysicsAttackingPlayer(CVehicle? @pVehicle,NativePointer<float> @arg2,NativePointer<float> @arg3,NativePointer<float> @arg4,NativePointer<bool> @arg5) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1821 >(1821)(@pVehicle?.Pointer ?? IntPtr.Zero,@arg2.Pointer,@arg3.Pointer,@arg4.Pointer,@arg5.Pointer); }
    public static void @SteerAIBoatWithPhysicsCirclingPlayer(CVehicle? @pVehicle,NativePointer<float> @arg2,NativePointer<float> @arg3,NativePointer<float> @arg4,NativePointer<bool> @arg5) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1822 >(1822)(@pVehicle?.Pointer ?? IntPtr.Zero,@arg2.Pointer,@arg3.Pointer,@arg4.Pointer,@arg5.Pointer); }
    public static void @SteerAIBoatWithPhysicsHeadingForTarget(CVehicle? @pVehicle,float @arg2,float @arg3,NativePointer<float> @arg4,NativePointer<float> @arg5,NativePointer<float> @arg6) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1823 >(1823)(@pVehicle?.Pointer ?? IntPtr.Zero,@arg2,@arg3,@arg4.Pointer,@arg5.Pointer,@arg6.Pointer); }
    public static void @SteerAICarBlockingPlayerForwardAndBack(CVehicle? @pVehicle,NativePointer<float> @arg2,NativePointer<float> @arg3,NativePointer<float> @arg4,NativePointer<bool> @arg5) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1824 >(1824)(@pVehicle?.Pointer ?? IntPtr.Zero,@arg2.Pointer,@arg3.Pointer,@arg4.Pointer,@arg5.Pointer); }
    public static void @SteerAICarParkParallel(CVehicle? @pVehicle,NativePointer<float> @arg2,NativePointer<float> @arg3,NativePointer<float> @arg4,NativePointer<bool> @arg5) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1825 >(1825)(@pVehicle?.Pointer ?? IntPtr.Zero,@arg2.Pointer,@arg3.Pointer,@arg4.Pointer,@arg5.Pointer); }
    public static void @SteerAICarParkPerpendicular(CVehicle? @pVehicle,NativePointer<float> @arg2,NativePointer<float> @arg3,NativePointer<float> @arg4,NativePointer<bool> @arg5) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1826 >(1826)(@pVehicle?.Pointer ?? IntPtr.Zero,@arg2.Pointer,@arg3.Pointer,@arg4.Pointer,@arg5.Pointer); }
    public static void @SteerAICarTowardsPointInEscort(CVehicle? @pVehicle1,CVehicle? @pVehicle2,float @arg3,float @arg4,NativePointer<float> @arg5,NativePointer<float> @arg6,NativePointer<float> @arg7,NativePointer<bool> @arg8) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1827 >(1827)(@pVehicle1?.Pointer ?? IntPtr.Zero,@pVehicle2?.Pointer ?? IntPtr.Zero,@arg3,@arg4,@arg5.Pointer,@arg6.Pointer,@arg7.Pointer,@arg8.Pointer); }
    public static void @SteerAICarWithPhysics(CVehicle? @pVehicle) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1828 >(1828)(@pVehicle?.Pointer ?? IntPtr.Zero); }
    public static void @SteerAICarWithPhysicsFollowPath(CVehicle? @pVehicle,NativePointer<float> @arg2,NativePointer<float> @arg3,NativePointer<float> @arg4,NativePointer<bool> @arg5) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1829 >(1829)(@pVehicle?.Pointer ?? IntPtr.Zero,@arg2.Pointer,@arg3.Pointer,@arg4.Pointer,@arg5.Pointer); }
    public static void @SteerAICarWithPhysicsFollowPath_Racing(CVehicle? @pVehicle,NativePointer<float> @arg2,NativePointer<float> @arg3,NativePointer<float> @arg4,NativePointer<bool> @arg5) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1830 >(1830)(@pVehicle?.Pointer ?? IntPtr.Zero,@arg2.Pointer,@arg3.Pointer,@arg4.Pointer,@arg5.Pointer); }
    public static void @SteerAICarWithPhysicsFollowPreRecordedPath(CVehicle? @pVehicle,NativePointer<float> @arg2,NativePointer<float> @arg3,NativePointer<float> @arg4,NativePointer<bool> @arg5) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1831 >(1831)(@pVehicle?.Pointer ?? IntPtr.Zero,@arg2.Pointer,@arg3.Pointer,@arg4.Pointer,@arg5.Pointer); }
    public static void @SteerAICarWithPhysicsHeadingForTarget(CVehicle? @pVehicle,CPhysical? @pTarget,float @arg3,float @arg4,NativePointer<float> @arg5,NativePointer<float> @arg6,NativePointer<float> @arg7,NativePointer<bool> @arg8) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1832 >(1832)(@pVehicle?.Pointer ?? IntPtr.Zero,@pTarget?.Pointer ?? IntPtr.Zero,@arg3,@arg4,@arg5.Pointer,@arg6.Pointer,@arg7.Pointer,@arg8.Pointer); }
    public static void @SteerAICarWithPhysicsTryingToBlockTarget(CVehicle? @pVehicle,CEntity? @Unusued,float @arg3,float @arg4,float @arg5,float @arg6,NativePointer<float> @arg7,NativePointer<float> @arg8,NativePointer<float> @arg9,NativePointer<bool> @arg10) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1833 >(1833)(@pVehicle?.Pointer ?? IntPtr.Zero,@Unusued?.Pointer ?? IntPtr.Zero,@arg3,@arg4,@arg5,@arg6,@arg7.Pointer,@arg8.Pointer,@arg9.Pointer,@arg10.Pointer); }
    public static void @SteerAICarWithPhysicsTryingToBlockTarget_Stop(CVehicle? @pVehicle,float @x,float @y,float @arg4,float @arg5,NativePointer<float> @arg6,NativePointer<float> @arg7,NativePointer<float> @arg8,NativePointer<bool> @arg9) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1834 >(1834)(@pVehicle?.Pointer ?? IntPtr.Zero,@x,@y,@arg4,@arg5,@arg6.Pointer,@arg7.Pointer,@arg8.Pointer,@arg9.Pointer); }
    public static void @SteerAICarWithPhysics_OnlyMission(CVehicle? @pVehicle,NativePointer<float> @arg2,NativePointer<float> @arg3,NativePointer<float> @arg4,NativePointer<bool> @arg5) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1835 >(1835)(@pVehicle?.Pointer ?? IntPtr.Zero,@arg2.Pointer,@arg3.Pointer,@arg4.Pointer,@arg5.Pointer); }
    public static void @SteerAIHeliAsPoliceHeli(CAutomobile? @pAutomobile) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1836 >(1836)(@pAutomobile?.Pointer ?? IntPtr.Zero); }
    public static void @SteerAIHeliFlyingAwayFromPlayer(CAutomobile? @pAutomobile) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1837 >(1837)(@pAutomobile?.Pointer ?? IntPtr.Zero); }
    public static void @SteerAIHeliToCrashAndBurn(CAutomobile? @pAutomobile) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1838 >(1838)(@pAutomobile?.Pointer ?? IntPtr.Zero); }
    public static void @SteerAIHeliToFollowEntity(CAutomobile? @pAutomobile) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1839 >(1839)(@pAutomobile?.Pointer ?? IntPtr.Zero); }
    public static void @SteerAIHeliToKeepEntityInView(CAutomobile? @pAutomobile) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1840 >(1840)(@pAutomobile?.Pointer ?? IntPtr.Zero); }
    public static void @SteerAIHeliToLand(CAutomobile? @pAutomobile) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1841 >(1841)(@pAutomobile?.Pointer ?? IntPtr.Zero); }
    public static void @SteerAIHeliTowardsTargetCoors(CAutomobile? @pAutomobile) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1842 >(1842)(@pAutomobile?.Pointer ?? IntPtr.Zero); }
    public static void @SteerAIPlaneToCrashAndBurn(CAutomobile? @pAutomobile) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1843 >(1843)(@pAutomobile?.Pointer ?? IntPtr.Zero); }
    public static void @SteerAIPlaneToFollowEntity(CAutomobile? @pAutomobile) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1844 >(1844)(@pAutomobile?.Pointer ?? IntPtr.Zero); }
    public static void @SteerAIPlaneTowardsTargetCoors(CAutomobile? @pAutomobile) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1845 >(1845)(@pAutomobile?.Pointer ?? IntPtr.Zero); }
    public static bool @StopCarIfNodesAreInvalid(CVehicle? @pVehicle) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1846 >(1846)(@pVehicle?.Pointer ?? IntPtr.Zero); return __sdkResult != 0; }
    public static void @SwitchBetweenPhysicsAndGhost(CVehicle? @pVehicle) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1847 >(1847)(@pVehicle?.Pointer ?? IntPtr.Zero); }
    public static void @SwitchVehicleToRealPhysics(CVehicle? @pVehicle) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1848 >(1848)(@pVehicle?.Pointer ?? IntPtr.Zero); }
    public static float @TestCollisionBetween2MovingRects(CVehicle? @pVehicle1,CVehicle? @pVehicle2,float @arg3,float @arg4,CVector? @pVector1,CVector? @pVector2) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1849 >(1849)(@pVehicle1?.Pointer ?? IntPtr.Zero,@pVehicle2?.Pointer ?? IntPtr.Zero,@arg3,@arg4,@pVector1?.Pointer ?? IntPtr.Zero,@pVector2?.Pointer ?? IntPtr.Zero); return __sdkResult; }
    public static float @TestCollisionBetween2MovingRects_OnlyFrontBumper(CVehicle? @pVehicle1,CVehicle? @pVehicle2,float @arg3,float @arg4,CVector? @pVector1,CVector? @pVector2) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1850 >(1850)(@pVehicle1?.Pointer ?? IntPtr.Zero,@pVehicle2?.Pointer ?? IntPtr.Zero,@arg3,@arg4,@pVector1?.Pointer ?? IntPtr.Zero,@pVector2?.Pointer ?? IntPtr.Zero); return __sdkResult; }
    public static void @TestWhetherToFirePlaneGuns(CVehicle? @pVehicle,CEntity? @pTarget) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1851 >(1851)(@pVehicle?.Pointer ?? IntPtr.Zero,@pTarget?.Pointer ?? IntPtr.Zero); }
    public static bool @ThisVehicleShouldTryNotToTurn(CVehicle? @pVehicle) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1852 >(1852)(@pVehicle?.Pointer ?? IntPtr.Zero); return __sdkResult != 0; }
    public static void @TriggerDogFightMoves(CVehicle? @pVehicle1,CVehicle? @pVehicle2) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1853 >(1853)(@pVehicle1?.Pointer ?? IntPtr.Zero,@pVehicle2?.Pointer ?? IntPtr.Zero); }
    public static void @UpdateCarCount(CVehicle? @pVehicle,byte @bDecrease) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1854 >(1854)(@pVehicle?.Pointer ?? IntPtr.Zero,@bDecrease); }
    public static void @UpdateCarOnRails(CVehicle? @pVehicle) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1855 >(1855)(@pVehicle?.Pointer ?? IntPtr.Zero); }
    public static void @WeaveForObject(CEntity? @pEntity,CVehicle? @pVehicle,NativePointer<float> @arg3,NativePointer<float> @arg4) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1856 >(1856)(@pEntity?.Pointer ?? IntPtr.Zero,@pVehicle?.Pointer ?? IntPtr.Zero,@arg3.Pointer,@arg4.Pointer); }
    public static void @WeaveForOtherCar(CEntity? @pEntity,CVehicle? @pVehicle,NativePointer<float> @arg3,NativePointer<float> @arg4) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1857 >(1857)(@pEntity?.Pointer ?? IntPtr.Zero,@pVehicle?.Pointer ?? IntPtr.Zero,@arg3.Pointer,@arg4.Pointer); }
    public static void @WeaveThroughCarsSectorList(CPtrList @PtrList,CVehicle? @pVehicle,CPhysical? @pPhysical,float @arg4,float @arg5,float @arg6,float @arg7,NativePointer<float> @arg8,NativePointer<float> @arg9) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1858 >(1858)(@PtrList.Pointer,@pVehicle?.Pointer ?? IntPtr.Zero,@pPhysical?.Pointer ?? IntPtr.Zero,@arg4,@arg5,@arg6,@arg7,@arg8.Pointer,@arg9.Pointer); }
    public static void @WeaveThroughObjectsSectorList(CPtrList @PtrList,CVehicle? @pVehicle,float @arg3,float @arg4,float @arg5,float @arg6,NativePointer<float> @arg7,NativePointer<float> @arg8) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1859 >(1859)(@PtrList.Pointer,@pVehicle?.Pointer ?? IntPtr.Zero,@arg3,@arg4,@arg5,@arg6,@arg7.Pointer,@arg8.Pointer); }
    public static void @WeaveThroughPedsSectorList(CPtrList @PtrList,CVehicle? @pVehicle,CPhysical? @pPhysical,float @arg4,float @arg5,float @arg6,float @arg7,NativePointer<float> @arg8,NativePointer<float> @arg9) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1860 >(1860)(@PtrList.Pointer,@pVehicle?.Pointer ?? IntPtr.Zero,@pPhysical?.Pointer ?? IntPtr.Zero,@arg4,@arg5,@arg6,@arg7,@arg8.Pointer,@arg9.Pointer); }
}
