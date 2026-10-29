// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CUpsideDownCarCheck : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=48;
    public CUpsideDownCarCheck(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_aUpsideDownCars")]
    public NativeObjectArray<CUpsideDownCarCheck___unnamed__at_D__plugin_sdk_plugin_sa_game_sa_CUps_747651c732> @UpsideDownCars { get => new NativeObjectArray<CUpsideDownCarCheck___unnamed__at_D__plugin_sdk_plugin_sa_game_sa_CUps_747651c732>(Pointer+0,6,8); }
    public void @AddCarToCheck(int @carHandle) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4079 >(4079)(Pointer,@carHandle); }
    public bool @AreAnyCarsUpsideDown() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4080 >(4080)(Pointer); return __sdkResult != 0; }
    public sbyte @HasCarBeenUpsideDownForAWhile(int @carHandle) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4081 >(4081)(Pointer,@carHandle); return __sdkResult; }
    public void @Init() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4082 >(4082)(Pointer); }
    public void @RemoveCarFromCheck(int @carHandle) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4083 >(4083)(Pointer,@carHandle); }
    public void @UpdateTimers() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4084 >(4084)(Pointer); }
    public static bool @IsCarUpsideDown(CVehicle? @pVehicle) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4085 >(4085)(@pVehicle?.Pointer ?? IntPtr.Zero); return __sdkResult != 0; }
    public static bool @IsCarUpsideDown(int @carhandle) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4086 >(4086)(@carhandle); return __sdkResult != 0; }
}
