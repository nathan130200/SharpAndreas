// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CStuckCarCheck : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=576;
    public CStuckCarCheck(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_aStuckCars")]
    public NativeObjectArray<CStuckCarCheck___unnamed__at_D__plugin_sdk_plugin_sa_game_sa_CStuckCar_15c17bac6a> @StuckCars { get => new NativeObjectArray<CStuckCarCheck___unnamed__at_D__plugin_sdk_plugin_sa_game_sa_CStuckCar_15c17bac6a>(Pointer+0,16,36); }
    public void @AddCarToCheck(int @carHandle,float @distance,uint @time,byte @a5,byte @bStuck,byte @bFlipped,byte @bWarp,sbyte @pathID) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3984 >(3984)(Pointer,@carHandle,@distance,@time,@a5,@bStuck,@bFlipped,@bWarp,@pathID); }
    public bool @AttemptToWarpVehicle(CVehicle? @vehicle,CVector? @origin,float @orientation) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3985 >(3985)(Pointer,@vehicle?.Pointer ?? IntPtr.Zero,@origin?.Pointer ?? IntPtr.Zero,@orientation); return __sdkResult != 0; }
    public void @ClearStuckFlagForCar(int @carHandle) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3986 >(3986)(Pointer,@carHandle); }
    public bool @HasCarBeenStuckForAWhile(int @carHandle) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3987 >(3987)(Pointer,@carHandle); return __sdkResult != 0; }
    public void @Init() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3988 >(3988)(Pointer); }
    public bool @IsCarInStuckCarArray(int @carHandle) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3989 >(3989)(Pointer,@carHandle); return __sdkResult != 0; }
    public void @Process() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3990 >(3990)(Pointer); }
    public void @RemoveCarFromCheck(int @carHandle) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3991 >(3991)(Pointer,@carHandle); }
    public void @ResetArrayElement(ushort @index) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3992 >(3992)(Pointer,@index); }
}
