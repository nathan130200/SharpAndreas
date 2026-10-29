// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CPickups : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=1;
    public CPickups(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("DisplayHelpMessage")]
    public static byte @DisplayHelpMessage { get => SdkMemory.Read<byte >(new IntPtr(0x8A5F48)); set { SdkMemory.Write(new IntPtr(0x8A5F48),value); } }
    [NativeMember("PlayerOnWeaponPickup")]
    public static int @PlayerOnWeaponPickup { get => SdkMemory.Read<int >(new IntPtr(0x97D640)); set { SdkMemory.Write(new IntPtr(0x97D640),value); } }
    [NativeMember("StaticCamStartTime")]
    public static int @StaticCamStartTime { get => SdkMemory.Read<int >(new IntPtr(0x978618)); set { SdkMemory.Write(new IntPtr(0x978618),value); } }
    [NativeMember("StaticCamCoors")]
    public static CVector? @StaticCamCoors { get => new IntPtr(0x97D660) == IntPtr.Zero ? null : new CVector(new IntPtr(0x97D660)); }
    [NativeMember("pPlayerVehicle")]
    public static CVehicle? @PlayerVehicle { get => SdkMemory.Read<IntPtr>(new IntPtr(0x97861C)) == IntPtr.Zero ? null : new CVehicle(SdkMemory.Read<IntPtr>(new IntPtr(0x97861C))); set { SdkMemory.Write(new IntPtr(0x97861C),value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("bPickUpcamActivated")]
    public static bool @PickUpcamActivated { get => SdkMemory.Read<bool >(new IntPtr(0x978620)); set { SdkMemory.Write(new IntPtr(0x978620),value); } }
    [NativeMember("CollectedPickUpIndex")]
    public static ushort @CollectedPickUpIndex { get => SdkMemory.Read<ushort >(new IntPtr(0x978624)); set { SdkMemory.Write(new IntPtr(0x978624),value); } }
    [NativeMember("aPickUpsCollected")]
    public static NativePointer<int> @PickUpsCollected { get => new NativePointer<int>(new IntPtr(0x978628)); }
    [NativeMember("NumMessages")]
    public static ushort @CountMessages { get => SdkMemory.Read<ushort >(new IntPtr(0x978678)); set { SdkMemory.Write(new IntPtr(0x978678),value); } }
    [NativeMember("aMessages")]
    public static tPickupMessage? @Messages { get => new IntPtr(0x978680) == IntPtr.Zero ? null : new tPickupMessage(new IntPtr(0x978680)); }
    [NativeMember("aPickUps")]
    public static CPickup? @PickUps { get => new IntPtr(0x9788C0) == IntPtr.Zero ? null : new CPickup(new IntPtr(0x9788C0)); }
    public static void @AddToCollectedPickupsArray(int @handle) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3332 >(3332)(@handle); }
    public static void @CreatePickupCoorsCloseToCoors(float @in_x,float @in_y,float @in_z,NativePointer<float> @out_x,NativePointer<float> @out_y,NativePointer<float> @out_z) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3333 >(3333)(@in_x,@in_y,@in_z,@out_x.Pointer,@out_y.Pointer,@out_z.Pointer); }
    public static void @CreateSomeMoney(CVector @coors,int @amount) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3334 >(3334)(@coors.Pointer,@amount); }
    public static void @DetonateMinesHitByGunShot(CVector? @shotOrigin,CVector? @shotTarget) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3335 >(3335)(@shotOrigin?.Pointer ?? IntPtr.Zero,@shotTarget?.Pointer ?? IntPtr.Zero); }
    public static void @DoCollectableEffects(CEntity? @entity) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3336 >(3336)(@entity?.Pointer ?? IntPtr.Zero); }
    public static void @DoMineEffects(CEntity? @entity) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3337 >(3337)(@entity?.Pointer ?? IntPtr.Zero); }
    public static void @DoMoneyEffects(CEntity? @entity) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3338 >(3338)(@entity?.Pointer ?? IntPtr.Zero); }
    public static void @DoPickUpEffects(CEntity? @entity) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3339 >(3339)(@entity?.Pointer ?? IntPtr.Zero); }
    public static CPickup? @FindPickUpForThisObject(CObject? @object) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3340 >(3340)(@object?.Pointer ?? IntPtr.Zero); return __sdkResult == IntPtr.Zero ? null : new CPickup(__sdkResult); }
    public static int @GenerateNewOne(CVector @coors,uint @modelId,byte @pickupType,uint @ammo,uint @moneyPerDay,bool @isEmpty,NativePointer<sbyte> @message) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3341 >(3341)(@coors.Pointer,@modelId,@pickupType,@ammo,@moneyPerDay,(@isEmpty ? 1 : 0),@message.Pointer); return __sdkResult; }
    public static int @GenerateNewOne_WeaponType(CVector @coors,eWeaponType @weaponType,byte @pickupType,uint @ammo,bool @isEmpty,NativePointer<sbyte> @message) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3342 >(3342)(@coors.Pointer,(int)@weaponType,@pickupType,@ammo,(@isEmpty ? 1 : 0),@message.Pointer); return __sdkResult; }
    public static int @GetActualPickupIndex(int @pickupIndex) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3343 >(3343)(@pickupIndex); return __sdkResult; }
    public static int @GetNewUniquePickupIndex(int @pickupIndex) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3344 >(3344)(@pickupIndex); return __sdkResult; }
    public static int @GetUniquePickupIndex(int @pickupIndex) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3345 >(3345)(@pickupIndex); return __sdkResult; }
    public static bool @GivePlayerGoodiesWithPickUpMI(ushort @modelId,int @playerId) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3346 >(3346)(@modelId,@playerId); return __sdkResult != 0; }
    public static void @Init() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3347 >(3347)(); }
    public static bool @IsPickUpPickedUp(int @pickupHandle) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3348 >(3348)(@pickupHandle); return __sdkResult != 0; }
    public static bool @Load() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3349 >(3349)(); return __sdkResult != 0; }
    public static int @ModelForWeapon(eWeaponType @weaponType) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3350 >(3350)((int)@weaponType); return __sdkResult; }
    public static void @PassTime(uint @time) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3351 >(3351)(@time); }
    public static void @PickedUpHorseShoe() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3352 >(3352)(); }
    public static void @PickedUpOyster() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3353 >(3353)(); }
    public static void @PictureTaken() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3354 >(3354)(); }
    public static bool @PlayerCanPickUpThisWeaponTypeAtThisMoment(eWeaponType @weaponType) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3355 >(3355)((int)@weaponType); return __sdkResult != 0; }
    public static void @ReInit() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3356 >(3356)(); }
    public static void @RemoveMissionPickUps() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3357 >(3357)(); }
    public static void @RemovePickUp(int @pickupHandle) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3358 >(3358)(@pickupHandle); }
    public static void @RemovePickUpsInArea(float @cornerA_x,float @cornerA_y,float @cornerA_z,float @cornerB_x,float @cornerB_y,float @cornerB_z) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3359 >(3359)(@cornerA_x,@cornerA_y,@cornerA_z,@cornerB_x,@cornerB_y,@cornerB_z); }
    public static void @RemovePickupObjects() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3360 >(3360)(); }
    public static void @RemoveUnnecessaryPickups(CVector @posn,float @radius) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3361 >(3361)(@posn.Pointer,@radius); }
    public static void @RenderPickUpText() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3362 >(3362)(); }
    public static bool @Save() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3363 >(3363)(); return __sdkResult != 0; }
    public static bool @TestForPickupsInBubble(CVector @posn,float @radius) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3364 >(3364)(@posn.Pointer,@radius); return __sdkResult != 0; }
    public static bool @TryToMerge_WeaponType(CVector @posn,eWeaponType @weaponType,byte @pickupType,uint @ammo,bool @arg4) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3365 >(3365)(@posn.Pointer,(int)@weaponType,@pickupType,@ammo,(@arg4 ? 1 : 0)); return __sdkResult != 0; }
    public static void @Update() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3366 >(3366)(); }
    public static void @UpdateMoneyPerDay(int @pickupHandle,ushort @money) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3367 >(3367)(@pickupHandle,@money); }
    public static int @WeaponForModel(int @modelId) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3368 >(3368)(@modelId); return __sdkResult; }
}
