// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CPedPlacement : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=1;
    public CPedPlacement(System.IntPtr pointer) : base(pointer) {}
    public static bool @FindZCoorForPed(CVector? @pos) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3308 >(3308)(@pos?.Pointer ?? IntPtr.Zero); return __sdkResult != 0; }
    public static bool @IsPositionClearForPed(CVector? @pos,float @radius,int @maxNumObjects,NativePointer<IntPtr> @pObjectList,byte @bCheckVehicles,byte @bCheckPeds,byte @bCheckObjects) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3309 >(3309)(@pos?.Pointer ?? IntPtr.Zero,@radius,@maxNumObjects,@pObjectList.Pointer,@bCheckVehicles,@bCheckPeds,@bCheckObjects); return __sdkResult != 0; }
    public static CVehicle? @IsPositionClearOfCars(CVector? @pos) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3310 >(3310)(@pos?.Pointer ?? IntPtr.Zero); return __sdkResult == IntPtr.Zero ? null : new CVehicle(__sdkResult); }
    public static CVehicle? @IsPositionClearOfCars(CPed? @ped) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3311 >(3311)(@ped?.Pointer ?? IntPtr.Zero); return __sdkResult == IntPtr.Zero ? null : new CVehicle(__sdkResult); }
}
