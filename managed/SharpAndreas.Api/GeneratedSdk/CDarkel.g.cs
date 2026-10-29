// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CDarkel : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=1;
    public CDarkel(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("RegisteredKills")]
    public static NativePointer<IntPtr> @RegisteredKills { get => new NativePointer<IntPtr>(new IntPtr(0x969A50)); }
    [NativeMember("pStartMessage")]
    public static NativePointer<sbyte> @StartMessage { get => new NativePointer<sbyte>(new IntPtr(0x96A6D0)); }
    [NativeMember("AmmoInterruptedWeapon")]
    public static uint @AmmoInterruptedWeapon { get => SdkMemory.Read<uint >(new IntPtr(0x96A6D4)); set { SdkMemory.Write(new IntPtr(0x96A6D4),value); } }
    [NativeMember("InterruptedWeaponType")]
    public static eWeaponType @InterruptedWeaponType { get => SdkMemory.Read<eWeaponType >(new IntPtr(0x96A6D8)); set { SdkMemory.Write(new IntPtr(0x96A6D8),value); } }
    [NativeMember("InterruptedWeaponTypeSelected")]
    public static eWeaponType @InterruptedWeaponTypeSelected { get => SdkMemory.Read<eWeaponType >(new IntPtr(0x96A6DC)); set { SdkMemory.Write(new IntPtr(0x96A6DC),value); } }
    [NativeMember("TimeOfFrenzyStart")]
    public static uint @TimeOfFrenzyStart { get => SdkMemory.Read<uint >(new IntPtr(0x96A6E0)); set { SdkMemory.Write(new IntPtr(0x96A6E0),value); } }
    [NativeMember("ModelToKill")]
    public static NativePointer<int> @ModelToKill { get => new NativePointer<int>(new IntPtr(0x96A6F0)); }
    [NativeMember("WeaponType")]
    public static eWeaponType @WeaponType { get => SdkMemory.Read<eWeaponType >(new IntPtr(0x96A700)); set { SdkMemory.Write(new IntPtr(0x96A700),value); } }
    [NativeMember("Status")]
    public static short @Status { get => SdkMemory.Read<short >(new IntPtr(0x96A704)); set { SdkMemory.Write(new IntPtr(0x96A704),value); } }
    public static bool @FrenzyOnGoing() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2462 >(2462)(); return __sdkResult != 0; }
    public static void @Init() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2463 >(2463)(); }
    public static void @DrawMessages() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2464 >(2464)(); }
    public static short @ReadStatus() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2465 >(2465)(); return __sdkResult; }
    public static void @RegisterKillNotByPlayer(CPed? @pKilledPed) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2466 >(2466)(@pKilledPed?.Pointer ?? IntPtr.Zero); }
    public static bool @ThisPedShouldBeKilledForFrenzy(CPed? @pPed) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2467 >(2467)(@pPed?.Pointer ?? IntPtr.Zero); return __sdkResult != 0; }
    public static bool @ThisVehicleShouldBeKilledForFrenzy(CVehicle? @pVehicle) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2468 >(2468)(@pVehicle?.Pointer ?? IntPtr.Zero); return __sdkResult != 0; }
    public static void @StartFrenzy(eWeaponType @weapontype,int @Timelimit,ushort @KillsNeeded,int @ModelToKill,NativePointer<ushort> @pStartMessage,int @ModelToKill2,int @ModelToKill3,int @ModelToKill4,bool @bStandardSoundAndMessages,bool @bNeedHeadShot) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2469 >(2469)((int)@weapontype,@Timelimit,@KillsNeeded,@ModelToKill,@pStartMessage.Pointer,@ModelToKill2,@ModelToKill3,@ModelToKill4,(@bStandardSoundAndMessages ? 1 : 0),(@bNeedHeadShot ? 1 : 0)); }
    public static void @ResetModelsKilledByPlayer(int @playerid) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2470 >(2470)(@playerid); }
    public static int @QueryModelsKilledByPlayer(int @player,int @modelid) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2471 >(2471)(@player,@modelid); return __sdkResult; }
    public static int @FindTotalPedsKilledByPlayer(int @player) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2472 >(2472)(@player); return __sdkResult; }
    public static void @DealWithWeaponChangeAtEndOfFrenzy() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2473 >(2473)(); }
    public static bool @CheckDamagedWeaponType(int @damageWeaponID,int @expectedDamageWeaponID) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2474 >(2474)(@damageWeaponID,@expectedDamageWeaponID); return __sdkResult != 0; }
    public static void @Update() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2475 >(2475)(); }
    public static void @ResetOnPlayerDeath() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2476 >(2476)(); }
    public static void @FailKillFrenzy() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2477 >(2477)(); }
    public static void @RegisterKillByPlayer(CPed? @pKilledPed,eWeaponType @damageWeaponID,bool @bHeadShotted,int @arg4) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2478 >(2478)(@pKilledPed?.Pointer ?? IntPtr.Zero,(int)@damageWeaponID,(@bHeadShotted ? 1 : 0),@arg4); }
    public static void @RegisterCarBlownUpByPlayer(CVehicle? @pVehicle,int @arg2) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2479 >(2479)(@pVehicle?.Pointer ?? IntPtr.Zero,@arg2); }
}
