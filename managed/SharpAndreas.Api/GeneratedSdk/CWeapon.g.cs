// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CWeapon : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=28;
    public CWeapon(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_eWeaponType")]
    public eWeaponType @EWeaponType { get => SdkMemory.Read<eWeaponType >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("m_nState")]
    public eWeaponState @State { get => SdkMemory.Read<eWeaponState >(Pointer+4); set { SdkMemory.Write(Pointer+4,value); } }
    [NativeMember("m_nAmmoInClip")]
    public uint @AmmoInClip { get => SdkMemory.Read<uint >(Pointer+8); set { SdkMemory.Write(Pointer+8,value); } }
    [NativeMember("m_nAmmoTotal")]
    public uint @AmmoTotal { get => SdkMemory.Read<uint >(Pointer+12); set { SdkMemory.Write(Pointer+12,value); } }
    [NativeMember("m_nTimeForNextShot")]
    public uint @TimeForNextShot { get => SdkMemory.Read<uint >(Pointer+16); set { SdkMemory.Write(Pointer+16,value); } }
    [NativeMember("field_14")]
    public sbyte @Field14 { get => SdkMemory.Read<sbyte >(Pointer+20); set { SdkMemory.Write(Pointer+20,value); } }
    [NativeMember("field_15")]
    public sbyte @Field15 { get => SdkMemory.Read<sbyte >(Pointer+21); set { SdkMemory.Write(Pointer+21,value); } }
    [NativeMember("field_16")]
    public sbyte @Field16 { get => SdkMemory.Read<sbyte >(Pointer+22); set { SdkMemory.Write(Pointer+22,value); } }
    [NativeMember("field_17")]
    public sbyte @Field17 { get => SdkMemory.Read<sbyte >(Pointer+23); set { SdkMemory.Write(Pointer+23,value); } }
    [NativeMember("m_pFxSystem")]
    public FxSystem_c? @FxSystem { get => SdkMemory.Read<IntPtr>(Pointer+24) == IntPtr.Zero ? null : new FxSystem_c(SdkMemory.Read<IntPtr>(Pointer+24)); set { SdkMemory.Write(Pointer+24,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("ms_fExtinguisherAimAngle")]
    public static float @ExtinguisherAimAngle { get => SdkMemory.Read<float >(new IntPtr(0x8D610C)); set { SdkMemory.Write(new IntPtr(0x8D610C),value); } }
    [NativeMember("bPhotographHasBeenTaken")]
    public static bool @PhotographHasBeenTaken { get => SdkMemory.Read<bool >(new IntPtr(0xC8A7C0)); set { SdkMemory.Write(new IntPtr(0xC8A7C0),value); } }
    [NativeMember("ms_bTakePhoto")]
    public static bool @TakePhoto { get => SdkMemory.Read<bool >(new IntPtr(0xC8A7C1)); set { SdkMemory.Write(new IntPtr(0xC8A7C1),value); } }
    [NativeMember("ms_PelletTestCol")]
    public static CColModel @PelletTestCollision { get => new CColModel(new IntPtr(0xC8A7DC)); set { SdkMemory.Copy(value.Pointer,new IntPtr(0xC8A7DC),48); } }
    public void @InitializeAt(eWeaponType @weaponType,int @ammo) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1416 >(1416)(Pointer,(int)@weaponType,@ammo); }
    public void @Shutdown() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1417 >(1417)(Pointer); }
    public void @AddGunshell(CEntity? @creator,CVector @position,CVector2D @direction,float @size) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1418 >(1418)(Pointer,@creator?.Pointer ?? IntPtr.Zero,@position.Pointer,@direction.Pointer,@size); }
    public bool @LaserScopeDot(CVector? @outCoord,NativePointer<float> @outSize) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1419 >(1419)(Pointer,@outCoord?.Pointer ?? IntPtr.Zero,@outSize.Pointer); return __sdkResult != 0; }
    public bool @FireSniper(CPed? @creator,CEntity? @victim,CVector? @target) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1420 >(1420)(Pointer,@creator?.Pointer ?? IntPtr.Zero,@victim?.Pointer ?? IntPtr.Zero,@target?.Pointer ?? IntPtr.Zero); return __sdkResult != 0; }
    public void @Reload(CPed? @owner) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1421 >(1421)(Pointer,@owner?.Pointer ?? IntPtr.Zero); }
    public bool @IsTypeMelee() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1422 >(1422)(Pointer); return __sdkResult != 0; }
    public bool @IsType2Handed() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1423 >(1423)(Pointer); return __sdkResult != 0; }
    public bool @IsTypeProjectile() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1424 >(1424)(Pointer); return __sdkResult != 0; }
    public bool @HasWeaponAmmoToBeUsed() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1425 >(1425)(Pointer); return __sdkResult != 0; }
    public void @StopWeaponEffect() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1426 >(1426)(Pointer); }
    public void @Initialise(eWeaponType @weaponType,int @ammo,CPed? @owner) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1427 >(1427)(Pointer,(int)@weaponType,@ammo,@owner?.Pointer ?? IntPtr.Zero); }
    public void @DoBulletImpact(CEntity? @owner,CEntity? @victim,CVector? @startPoint,CVector? @endPoint,CColPoint? @colPoint,int @arg5) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1428 >(1428)(Pointer,@owner?.Pointer ?? IntPtr.Zero,@victim?.Pointer ?? IntPtr.Zero,@startPoint?.Pointer ?? IntPtr.Zero,@endPoint?.Pointer ?? IntPtr.Zero,@colPoint?.Pointer ?? IntPtr.Zero,@arg5); }
    public bool @TakePhotograph(CEntity? @owner,CVector? @point) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1429 >(1429)(Pointer,@owner?.Pointer ?? IntPtr.Zero,@point?.Pointer ?? IntPtr.Zero); return __sdkResult != 0; }
    public void @SetUpPelletCol(int @numPellets,CEntity? @owner,CEntity? @victim,CVector @point,CColPoint @colPoint,CMatrix @outMatrix) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1430 >(1430)(Pointer,@numPellets,@owner?.Pointer ?? IntPtr.Zero,@victim?.Pointer ?? IntPtr.Zero,@point.Pointer,@colPoint.Pointer,@outMatrix.Pointer); }
    public void @FireInstantHitFromCar2(CVector @startPoint,CVector @endPoint,CVehicle? @vehicle,CEntity? @owner) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1431 >(1431)(Pointer,@startPoint.Pointer,@endPoint.Pointer,@vehicle?.Pointer ?? IntPtr.Zero,@owner?.Pointer ?? IntPtr.Zero); }
    public void @Update(CPed? @owner) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1432 >(1432)(Pointer,@owner?.Pointer ?? IntPtr.Zero); }
    public bool @CanBeUsedFor2Player() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1433 >(1433)(Pointer); return __sdkResult != 0; }
    public void @DoWeaponEffect(CVector @origin,CVector @target) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1434 >(1434)(Pointer,@origin.Pointer,@target.Pointer); }
    public bool @FireAreaEffect(CEntity? @firingEntity,CVector? @origin,CEntity? @targetEntity,CVector? @target) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1435 >(1435)(Pointer,@firingEntity?.Pointer ?? IntPtr.Zero,@origin?.Pointer ?? IntPtr.Zero,@targetEntity?.Pointer ?? IntPtr.Zero,@target?.Pointer ?? IntPtr.Zero); return __sdkResult != 0; }
    public bool @FireInstantHitFromCar(CVehicle? @vehicle,bool @leftSide,bool @rightSide) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1436 >(1436)(Pointer,@vehicle?.Pointer ?? IntPtr.Zero,(@leftSide ? 1 : 0),(@rightSide ? 1 : 0)); return __sdkResult != 0; }
    public void @FireFromCar(CVehicle? @vehicle,bool @leftSide,bool @rightSide) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1437 >(1437)(Pointer,@vehicle?.Pointer ?? IntPtr.Zero,(@leftSide ? 1 : 0),(@rightSide ? 1 : 0)); }
    public bool @FireInstantHit(CEntity? @firingEntity,CVector? @origin,CVector? @muzzlePosn,CEntity? @targetEntity,CVector? @target,CVector? @originForDriveBy,bool @arg6,bool @muzzle) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1438 >(1438)(Pointer,@firingEntity?.Pointer ?? IntPtr.Zero,@origin?.Pointer ?? IntPtr.Zero,@muzzlePosn?.Pointer ?? IntPtr.Zero,@targetEntity?.Pointer ?? IntPtr.Zero,@target?.Pointer ?? IntPtr.Zero,@originForDriveBy?.Pointer ?? IntPtr.Zero,(@arg6 ? 1 : 0),(@muzzle ? 1 : 0)); return __sdkResult != 0; }
    public bool @FireProjectile(CEntity? @firingEntity,CVector? @origin,CEntity? @targetEntity,CVector? @target,float @force) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1439 >(1439)(Pointer,@firingEntity?.Pointer ?? IntPtr.Zero,@origin?.Pointer ?? IntPtr.Zero,@targetEntity?.Pointer ?? IntPtr.Zero,@target?.Pointer ?? IntPtr.Zero,@force); return __sdkResult != 0; }
    public bool @FireM16_1stPerson(CEntity? @owner) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1440 >(1440)(Pointer,@owner?.Pointer ?? IntPtr.Zero); return __sdkResult != 0; }
    public bool @Fire(CEntity? @firingEntity,CVector? @origin,CVector? @muzzlePosn,CEntity? @targetEntity,CVector? @target,CVector? @originForDriveBy) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1441 >(1441)(Pointer,@firingEntity?.Pointer ?? IntPtr.Zero,@origin?.Pointer ?? IntPtr.Zero,@muzzlePosn?.Pointer ?? IntPtr.Zero,@targetEntity?.Pointer ?? IntPtr.Zero,@target?.Pointer ?? IntPtr.Zero,@originForDriveBy?.Pointer ?? IntPtr.Zero); return __sdkResult != 0; }
    public static void @InitialiseWeapons() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1442 >(1442)(); }
    public static void @ShutdownWeapons() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1443 >(1443)(); }
    public static void @UpdateWeapons() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1444 >(1444)(); }
    public static void @GenerateDamageEvent(CPed? @victim,CEntity? @creator,eWeaponType @weaponType,int @damageFactor,ePedPieceTypes @pedPiece,int @direction) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1445 >(1445)(@victim?.Pointer ?? IntPtr.Zero,@creator?.Pointer ?? IntPtr.Zero,(int)@weaponType,@damageFactor,(int)@pedPiece,@direction); }
    public static bool @CanBeUsedFor2Player(eWeaponType @weaponType) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1446 >(1446)((int)@weaponType); return __sdkResult != 0; }
    public static float @TargetWeaponRangeMultiplier(CEntity? @victim,CEntity? @weaponOwner) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1447 >(1447)(@victim?.Pointer ?? IntPtr.Zero,@weaponOwner?.Pointer ?? IntPtr.Zero); return __sdkResult; }
    public static void @DoDoomAiming(CEntity? @owner,CVector? @start,CVector? @end) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1448 >(1448)(@owner?.Pointer ?? IntPtr.Zero,@start?.Pointer ?? IntPtr.Zero,@end?.Pointer ?? IntPtr.Zero); }
    public static void @DoTankDoomAiming(CEntity? @vehicle,CEntity? @owner,CVector? @startPoint,CVector? @endPoint) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1449 >(1449)(@vehicle?.Pointer ?? IntPtr.Zero,@owner?.Pointer ?? IntPtr.Zero,@startPoint?.Pointer ?? IntPtr.Zero,@endPoint?.Pointer ?? IntPtr.Zero); }
    public static void @DoDriveByAutoAiming(CEntity? @owner,CVehicle? @vehicle,CVector? @startPoint,CVector? @endPoint,bool @canAimVehicles) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1450 >(1450)(@owner?.Pointer ?? IntPtr.Zero,@vehicle?.Pointer ?? IntPtr.Zero,@startPoint?.Pointer ?? IntPtr.Zero,@endPoint?.Pointer ?? IntPtr.Zero,(@canAimVehicles ? 1 : 0)); }
    public static void @FindNearestTargetEntityWithScreenCoors(float @screenX,float @screenY,float @range,CVector @point,NativePointer<float> @outX,NativePointer<float> @outY) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1451 >(1451)(@screenX,@screenY,@range,@point.Pointer,@outX.Pointer,@outY.Pointer); }
    public static float @EvaluateTargetForHeatSeekingMissile(CEntity? @entity,CVector @posn,CVector @direction,float @distanceMultiplier,bool @fromVehicle,CEntity? @lastEntity) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1452 >(1452)(@entity?.Pointer ?? IntPtr.Zero,@posn.Pointer,@direction.Pointer,@distanceMultiplier,(@fromVehicle ? 1 : 0),@lastEntity?.Pointer ?? IntPtr.Zero); return __sdkResult; }
    public static bool @CheckForShootingVehicleOccupant(NativePointer<IntPtr> @pCarEntity,CColPoint? @colPoint,eWeaponType @weaponType,CVector @origin,CVector @target) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1453 >(1453)(@pCarEntity.Pointer,@colPoint?.Pointer ?? IntPtr.Zero,(int)@weaponType,@origin.Pointer,@target.Pointer); return __sdkResult != 0; }
    public static CEntity? @PickTargetForHeatSeekingMissile(CVector @origin,CVector @direction,float @distanceMultiplier,CEntity? @ignoreEntity,bool @fromVehicle,CEntity? @lastEntity) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1454 >(1454)(@origin.Pointer,@direction.Pointer,@distanceMultiplier,@ignoreEntity?.Pointer ?? IntPtr.Zero,(@fromVehicle ? 1 : 0),@lastEntity?.Pointer ?? IntPtr.Zero); return __sdkResult == IntPtr.Zero ? null : new CEntity(__sdkResult); }
    public static bool @ProcessLineOfSight(CVector @startPoint,CVector @endPoint,CColPoint @outColPoint,NativePointer<IntPtr> @outEntity,eWeaponType @weaponType,CEntity? @arg5,bool @buildings,bool @vehicles,bool @peds,bool @objects,bool @dummies,bool @arg11,bool @doIgnoreCameraCheck) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1455 >(1455)(@startPoint.Pointer,@endPoint.Pointer,@outColPoint.Pointer,@outEntity.Pointer,(int)@weaponType,@arg5?.Pointer ?? IntPtr.Zero,(@buildings ? 1 : 0),(@vehicles ? 1 : 0),(@peds ? 1 : 0),(@objects ? 1 : 0),(@dummies ? 1 : 0),(@arg11 ? 1 : 0),(@doIgnoreCameraCheck ? 1 : 0)); return __sdkResult != 0; }
}
