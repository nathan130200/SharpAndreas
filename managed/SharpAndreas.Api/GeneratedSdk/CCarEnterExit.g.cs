// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CCarEnterExit : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=1;
    public CCarEnterExit(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("ms_fMaxSpeed_CanDragPedOut")]
    public static float @MaxSpeedCanDragPedOut { get => SdkMemory.Read<float >(new IntPtr(0x86F104)); }
    [NativeMember("ms_fMaxSpeed_PlayerCanDragPedOut")]
    public static float @MaxSpeedPlayerCanDragPedOut { get => SdkMemory.Read<float >(new IntPtr(0x86F108)); }
    [NativeMember("ms_bPedOffsetsCalculated")]
    public static bool @PedOffsetsCalculated { get => SdkMemory.Read<bool >(new IntPtr(0xC18C20)); set { SdkMemory.Write(new IntPtr(0xC18C20),value); } }
    [NativeMember("ms_vecPedGetUpAnimOffset")]
    public static CVector @PedGetUpAnimationOffset { get => new CVector(new IntPtr(0xC18C3C)); set { SdkMemory.Copy(value.Pointer,new IntPtr(0xC18C3C),12); } }
    [NativeMember("ms_vecPedQuickDraggedOutCarAnimOffset")]
    public static CVector @PedQuickDraggedOutCarAnimationOffset { get => new CVector(new IntPtr(0xC18C48)); set { SdkMemory.Copy(value.Pointer,new IntPtr(0xC18C48),12); } }
    [NativeMember("ms_vecPedBedLAnimOffset")]
    public static CVector @PedBedLAnimOffset { get => new CVector(new IntPtr(0xC18C54)); set { SdkMemory.Copy(value.Pointer,new IntPtr(0xC18C54),12); } }
    [NativeMember("ms_vecPedBedRAnimOffset")]
    public static CVector @PedBedRAnimOffset { get => new CVector(new IntPtr(0xC18C60)); set { SdkMemory.Copy(value.Pointer,new IntPtr(0xC18C60),12); } }
    [NativeMember("ms_vecPedDeskAnimOffset")]
    public static CVector @PedDeskAnimationOffset { get => new CVector(new IntPtr(0xC18C6C)); set { SdkMemory.Copy(value.Pointer,new IntPtr(0xC18C6C),12); } }
    [NativeMember("ms_vecPedChairAnimOffset")]
    public static CVector @PedChairAnimationOffset { get => new CVector(new IntPtr(0xC18C78)); set { SdkMemory.Copy(value.Pointer,new IntPtr(0xC18C78),12); } }
    public static void @AddInCarAnim(CVehicle? @vehicle,CPed? @ped,bool @bAsDriver) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1861 >(1861)(@vehicle?.Pointer ?? IntPtr.Zero,@ped?.Pointer ?? IntPtr.Zero,(@bAsDriver ? 1 : 0)); }
    public static bool @CarHasDoorToClose(CVehicle? @vehicle,int @doorId) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1862 >(1862)(@vehicle?.Pointer ?? IntPtr.Zero,@doorId); return __sdkResult != 0; }
    public static bool @CarHasDoorToOpen(CVehicle? @vehicle,int @doorID) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1863 >(1863)(@vehicle?.Pointer ?? IntPtr.Zero,@doorID); return __sdkResult != 0; }
    public static bool @CarHasOpenableDoor(CVehicle? @vehicle,int @DoorID_UnusedArg,CPed? @ped) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1864 >(1864)(@vehicle?.Pointer ?? IntPtr.Zero,@DoorID_UnusedArg,@ped?.Pointer ?? IntPtr.Zero); return __sdkResult != 0; }
    public static bool @CarHasPartiallyOpenDoor(CVehicle? @vehicle,int @doorID) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1865 >(1865)(@vehicle?.Pointer ?? IntPtr.Zero,@doorID); return __sdkResult != 0; }
    public static int @ComputeDoorFlag(CVehicle? @vehicle,int @doorId,bool @bCheckVehicleType) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1866 >(1866)(@vehicle?.Pointer ?? IntPtr.Zero,@doorId,(@bCheckVehicleType ? 1 : 0)); return __sdkResult; }
    public static int @ComputeOppositeDoorFlag(CVehicle? @vehicle,int @doorId,bool @bCheckVehicleType) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1867 >(1867)(@vehicle?.Pointer ?? IntPtr.Zero,@doorId,(@bCheckVehicleType ? 1 : 0)); return __sdkResult; }
    public static int @ComputePassengerIndexFromCarDoor(CVehicle? @vehicle,int @doorID) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1868 >(1868)(@vehicle?.Pointer ?? IntPtr.Zero,@doorID); return __sdkResult; }
    public static int @ComputeSlowJackedPed(CVehicle? @vehicle,int @doorID) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1869 >(1869)(@vehicle?.Pointer ?? IntPtr.Zero,@doorID); return __sdkResult; }
    public static int @ComputeTargetDoorToEnterAsPassenger(CVehicle? @pVehicle,int @nPassengerNum) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1870 >(1870)(@pVehicle?.Pointer ?? IntPtr.Zero,@nPassengerNum); return __sdkResult; }
    public static int @ComputeTargetDoorToExit(CVehicle? @pVehicle,CPed? @pPed) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1871 >(1871)(@pVehicle?.Pointer ?? IntPtr.Zero,@pPed?.Pointer ?? IntPtr.Zero); return __sdkResult; }
    public static bool @GetNearestCarDoor(CPed? @pPed,CVehicle? @pVehicle,CVector? @outPos,int @doorID) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1872 >(1872)(@pPed?.Pointer ?? IntPtr.Zero,@pVehicle?.Pointer ?? IntPtr.Zero,@outPos?.Pointer ?? IntPtr.Zero,@doorID); return __sdkResult != 0; }
    public static bool @GetNearestCarPassengerDoor(CPed? @ped,CVehicle? @vehicle,CVector? @outVec,NativePointer<int> @doorId,bool @flag1,bool @flag2,bool @flag3) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1873 >(1873)(@ped?.Pointer ?? IntPtr.Zero,@vehicle?.Pointer ?? IntPtr.Zero,@outVec?.Pointer ?? IntPtr.Zero,@doorId.Pointer,(@flag1 ? 1 : 0),(@flag2 ? 1 : 0),(@flag3 ? 1 : 0)); return __sdkResult != 0; }
    public static CVector? @GetPositionToOpenCarDoor(CVector? @out,CVehicle? @vehicle,int @doorId) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1874 >(1874)(@out?.Pointer ?? IntPtr.Zero,@vehicle?.Pointer ?? IntPtr.Zero,@doorId); return __sdkResult == IntPtr.Zero ? null : new CVector(__sdkResult); }
    public static bool @IsCarDoorInUse(CVehicle? @vehicle,int @door1Id,int @door2Id) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1875 >(1875)(@vehicle?.Pointer ?? IntPtr.Zero,@door1Id,@door2Id); return __sdkResult != 0; }
    public static bool @IsCarDoorReady(CVehicle? @vehicle,int @doorID) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1876 >(1876)(@vehicle?.Pointer ?? IntPtr.Zero,@doorID); return __sdkResult != 0; }
    public static bool @IsCarQuickJackPossible(CVehicle? @vehicle,int @doorID,CPed? @ped) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1877 >(1877)(@vehicle?.Pointer ?? IntPtr.Zero,@doorID,@ped?.Pointer ?? IntPtr.Zero); return __sdkResult != 0; }
    public static bool @IsCarSlowJackRequired(CVehicle? @vehicle,int @doorID) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1878 >(1878)(@vehicle?.Pointer ?? IntPtr.Zero,@doorID); return __sdkResult != 0; }
    public static bool @IsClearToDriveAway(CVehicle? @outVehicle) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1879 >(1879)(@outVehicle?.Pointer ?? IntPtr.Zero); return __sdkResult != 0; }
    public static bool @IsPathToDoorBlockedByVehicleCollisionModel(CPed? @ped,CVehicle? @vehicle,CVector? @pos) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1880 >(1880)(@ped?.Pointer ?? IntPtr.Zero,@vehicle?.Pointer ?? IntPtr.Zero,@pos?.Pointer ?? IntPtr.Zero); return __sdkResult != 0; }
    public static bool @IsPedHealthy(CPed? @vehicle) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1881 >(1881)(@vehicle?.Pointer ?? IntPtr.Zero); return __sdkResult != 0; }
    public static bool @IsPlayerToQuitCarEnter(CPed? @ped,CVehicle? @vehicle,int @StartTime,CTask? @task) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1882 >(1882)(@ped?.Pointer ?? IntPtr.Zero,@vehicle?.Pointer ?? IntPtr.Zero,@StartTime,@task?.Pointer ?? IntPtr.Zero); return __sdkResult != 0; }
    public static bool @IsRoomForPedToLeaveCar(CVehicle? @veh,int @doorID,CVector? @pos) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1883 >(1883)(@veh?.Pointer ?? IntPtr.Zero,@doorID,@pos?.Pointer ?? IntPtr.Zero); return __sdkResult != 0; }
    public static bool @IsVehicleHealthy(CVehicle? @vehicle) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1884 >(1884)(@vehicle?.Pointer ?? IntPtr.Zero); return __sdkResult != 0; }
    public static bool @IsVehicleStealable(CVehicle? @vehicle,CPed? @ped) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1885 >(1885)(@vehicle?.Pointer ?? IntPtr.Zero,@ped?.Pointer ?? IntPtr.Zero); return __sdkResult != 0; }
    public static void @MakeUndraggedDriverPedLeaveCar(CVehicle? @vehicle,CPed? @ped) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1886 >(1886)(@vehicle?.Pointer ?? IntPtr.Zero,@ped?.Pointer ?? IntPtr.Zero); }
    public static void @MakeUndraggedPassengerPedsLeaveCar(CVehicle? @targetVehicle,CPed? @draggedPed,CPed? @ped) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1887 >(1887)(@targetVehicle?.Pointer ?? IntPtr.Zero,@draggedPed?.Pointer ?? IntPtr.Zero,@ped?.Pointer ?? IntPtr.Zero); }
    public static void @QuitEnteringCar(CPed? @ped,CVehicle? @vehicle,int @doorID,bool @bCarWasBeingJacked) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1888 >(1888)(@ped?.Pointer ?? IntPtr.Zero,@vehicle?.Pointer ?? IntPtr.Zero,@doorID,(@bCarWasBeingJacked ? 1 : 0)); }
    public static void @RemoveCarSitAnim(CPed? @ped) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1889 >(1889)(@ped?.Pointer ?? IntPtr.Zero); }
    public static void @RemoveGetInAnims(CPed? @ped) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1890 >(1890)(@ped?.Pointer ?? IntPtr.Zero); }
    public static void @SetAnimOffsetForEnterOrExitVehicle() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1891 >(1891)(); }
    public static void @SetPedInCarDirect(CPed? @ped,CVehicle? @vehicle,int @seatNumber,bool @bAsDriver) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1892 >(1892)(@ped?.Pointer ?? IntPtr.Zero,@vehicle?.Pointer ?? IntPtr.Zero,@seatNumber,(@bAsDriver ? 1 : 0)); }
}
