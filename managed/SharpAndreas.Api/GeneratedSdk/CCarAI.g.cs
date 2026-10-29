// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CCarAI : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=1;
    public CCarAI(System.IntPtr pointer) : base(pointer) {}
    public static void @BackToCruisingIfNoWantedLevel(CVehicle? @pVehicle) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1711 >(1711)(@pVehicle?.Pointer ?? IntPtr.Zero); }
    public static void @CarHasReasonToStop(CVehicle? @pVehicle) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1712 >(1712)(@pVehicle?.Pointer ?? IntPtr.Zero); }
    public static void @AddPoliceCarOccupants(CVehicle? @pVehicle,bool @arg2) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1713 >(1713)(@pVehicle?.Pointer ?? IntPtr.Zero,(@arg2 ? 1 : 0)); }
    public static void @AddAmbulanceOccupants(CVehicle? @pVehicle) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1714 >(1714)(@pVehicle?.Pointer ?? IntPtr.Zero); }
    public static void @AddFiretruckOccupants(CVehicle? @pVehicle) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1715 >(1715)(@pVehicle?.Pointer ?? IntPtr.Zero); }
    public static void @TellOccupantsToLeaveCar(CVehicle? @pVehicle) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1716 >(1716)(@pVehicle?.Pointer ?? IntPtr.Zero); }
    public static void @TellCarToFollowOtherCar(CVehicle? @pVehicle1,CVehicle? @pVehicle2,float @radius) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1717 >(1717)(@pVehicle1?.Pointer ?? IntPtr.Zero,@pVehicle2?.Pointer ?? IntPtr.Zero,@radius); }
    public static sbyte @FindPoliceBikeMissionForWantedLevel() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1718 >(1718)(); return __sdkResult; }
    public static sbyte @FindPoliceBoatMissionForWantedLevel() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1719 >(1719)(); return __sdkResult; }
    public static int @FindPoliceCarSpeedForWantedLevel(CVehicle? @pVehicle) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1720 >(1720)(@pVehicle?.Pointer ?? IntPtr.Zero); return __sdkResult; }
    public static float @GetCarToGoToCoors(CVehicle? @pVehicle1,CVector? @pVector,int @drivingStyle,bool @bSpeedLimit20) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1721 >(1721)(@pVehicle1?.Pointer ?? IntPtr.Zero,@pVector?.Pointer ?? IntPtr.Zero,@drivingStyle,(@bSpeedLimit20 ? 1 : 0)); return __sdkResult; }
    public static float @GetCarToParkAtCoors(CVehicle? @pVehicle,CVector? @pVector) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1722 >(1722)(@pVehicle?.Pointer ?? IntPtr.Zero,@pVector?.Pointer ?? IntPtr.Zero); return __sdkResult; }
    public static void @MellowOutChaseSpeed(CVehicle? @pVehicle) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1723 >(1723)(@pVehicle?.Pointer ?? IntPtr.Zero); }
    public static void @MakeWayForCarWithSiren(CVehicle? @pVehicle) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1724 >(1724)(@pVehicle?.Pointer ?? IntPtr.Zero); }
    public static void @UpdateCarAI(CVehicle? @pVehicle) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1725 >(1725)(@pVehicle?.Pointer ?? IntPtr.Zero); }
    public static sbyte @FindPoliceCarMissionForWantedLevel() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1726 >(1726)(); return __sdkResult; }
}
