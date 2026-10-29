// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CObject : CPhysical
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=380;
    public CObject(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_pControlCodeList")]
    public NativePointer<IntPtr> @ControlCodeList { get => new NativePointer<IntPtr>(SdkMemory.Read<IntPtr>(Pointer+312)); set { SdkMemory.Write(Pointer+312,value.Pointer); } }
    [NativeMember("m_nObjectType")]
    public byte @ObjectType { get => SdkMemory.Read<byte >(Pointer+316); set { SdkMemory.Write(Pointer+316,value); } }
    [NativeMember("m_nBonusValue")]
    public byte @BonusValue { get => SdkMemory.Read<byte >(Pointer+317); set { SdkMemory.Write(Pointer+317,value); } }
    [NativeMember("m_wCostValue")]
    public ushort @CostValue { get => SdkMemory.Read<ushort >(Pointer+318); set { SdkMemory.Write(Pointer+318,value); } }
    [NativeMember("m_nObjectFlags")]
    public CObject___unnamed__at_D__plugin_sdk_plugin_sa_game_sa_CObject_h_28_5__bd57af263b @ObjectFlags { get => new CObject___unnamed__at_D__plugin_sdk_plugin_sa_game_sa_CObject_h_28_5__bd57af263b(Pointer+320); set { SdkMemory.Copy(value.Pointer,Pointer+320,4); } }
    [NativeMember("m_nColDamageEffect")]
    public byte @CollisionDamageEffect { get => SdkMemory.Read<byte >(Pointer+324); set { SdkMemory.Write(Pointer+324,value); } }
    [NativeMember("m_nStoredColDamageEffect")]
    public byte @StoredCollisionDamageEffect { get => SdkMemory.Read<byte >(Pointer+325); set { SdkMemory.Write(Pointer+325,value); } }
    [NativeMember("field_146")]
    public sbyte @Field146 { get => SdkMemory.Read<sbyte >(Pointer+326); set { SdkMemory.Write(Pointer+326,value); } }
    [NativeMember("m_nGarageDoorGarageIndex")]
    public sbyte @GarageDoorGarageIndex { get => SdkMemory.Read<sbyte >(Pointer+327); set { SdkMemory.Write(Pointer+327,value); } }
    [NativeMember("m_nLastWeaponDamage")]
    public byte @LastWeaponDamage { get => SdkMemory.Read<byte >(Pointer+328); set { SdkMemory.Write(Pointer+328,value); } }
    [NativeMember("m_nDayBrightness")]
    public byte @DayBrightness { get => (byte)SdkMemory.ReadBits(Pointer,2632,4); set { SdkMemory.WriteBits(Pointer,2632,4,unchecked((ulong)value)); } }
    [NativeMember("m_nNightBrightness")]
    public byte @NightBrightness { get => (byte)SdkMemory.ReadBits(Pointer,2636,4); set { SdkMemory.WriteBits(Pointer,2636,4,unchecked((ulong)value)); } }
    [NativeMember("m_nRefModelIndex")]
    public short @RefModelIndex { get => SdkMemory.Read<short >(Pointer+330); set { SdkMemory.Write(Pointer+330,value); } }
    [NativeMember("m_nCarColor")]
    public NativeArray<byte> @CarColor { get => new NativeArray<byte>(Pointer+332,4); }
    [NativeMember("m_dwRemovalTime")]
    public int @RemovalTime { get => SdkMemory.Read<int >(Pointer+336); set { SdkMemory.Write(Pointer+336,value); } }
    [NativeMember("m_fHealth")]
    public float @Health { get => SdkMemory.Read<float >(Pointer+340); set { SdkMemory.Write(Pointer+340,value); } }
    [NativeMember("m_fDoorStartAngle")]
    public float @DoorStartAngle { get => SdkMemory.Read<float >(Pointer+344); set { SdkMemory.Write(Pointer+344,value); } }
    [NativeMember("m_fScale")]
    public float @Scale { get => SdkMemory.Read<float >(Pointer+348); set { SdkMemory.Write(Pointer+348,value); } }
    [NativeMember("m_pObjectInfo")]
    public CObjectInfo? @ObjectInfo { get => SdkMemory.Read<IntPtr>(Pointer+352) == IntPtr.Zero ? null : new CObjectInfo(SdkMemory.Read<IntPtr>(Pointer+352)); set { SdkMemory.Write(Pointer+352,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_pFire")]
    public CFire? @Fire { get => SdkMemory.Read<IntPtr>(Pointer+356) == IntPtr.Zero ? null : new CFire(SdkMemory.Read<IntPtr>(Pointer+356)); set { SdkMemory.Write(Pointer+356,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_wScriptTriggerIndex")]
    public short @ScriptTriggerIndex { get => SdkMemory.Read<short >(Pointer+360); set { SdkMemory.Write(Pointer+360,value); } }
    [NativeMember("m_wRemapTxd")]
    public short @RemapTxd { get => SdkMemory.Read<short >(Pointer+362); set { SdkMemory.Write(Pointer+362,value); } }
    [NativeMember("m_pRemapTexture")]
    public RwTexture? @RemapTexture { get => SdkMemory.Read<IntPtr>(Pointer+364) == IntPtr.Zero ? null : new RwTexture(SdkMemory.Read<IntPtr>(Pointer+364)); set { SdkMemory.Write(Pointer+364,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_pDummyObject")]
    public CDummyObject? @DummyObject { get => SdkMemory.Read<IntPtr>(Pointer+368) == IntPtr.Zero ? null : new CDummyObject(SdkMemory.Read<IntPtr>(Pointer+368)); set { SdkMemory.Write(Pointer+368,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_dwBurnTime")]
    public int @BurnTime { get => SdkMemory.Read<int >(Pointer+372); set { SdkMemory.Write(Pointer+372,value); } }
    [NativeMember("m_fBurnDamage")]
    public float @BurnDamage { get => SdkMemory.Read<float >(Pointer+376); set { SdkMemory.Write(Pointer+376,value); } }
    public static NativePointer<IntPtr> @AllocateNative(uint @size) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2341 >(2341)(@size); return new NativePointer<IntPtr>(__sdkResult); }
    public static NativePointer<IntPtr> @AllocateNative(uint @size,int @poolRef) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2342 >(2342)(@size,@poolRef); return new NativePointer<IntPtr>(__sdkResult); }
    public static void @FreeNative(NativePointer<IntPtr> @data) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2343 >(2343)(@data.Pointer); }
    public void @InitializeAt() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2344 >(2344)(Pointer); }
    public void @InitializeAt(int @model,bool @create) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2345 >(2345)(Pointer,@model,(@create ? 1 : 0)); }
    public void @InitializeAt(CDummyObject? @dummy) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2346 >(2346)(Pointer,@dummy?.Pointer ?? IntPtr.Zero); }
    public void @DestroyNative() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2347 >(2347)(Pointer); }
    public void @SetIsStatic(bool @isStatic) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2348 >(2348)(Pointer,(@isStatic ? 1 : 0)); }
    public void @ProcessGarageDoorBehaviour() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2349 >(2349)(Pointer); }
    public bool @CanBeDeleted() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2350 >(2350)(Pointer); return __sdkResult != 0; }
    public void @SetRelatedDummy(CDummyObject? @relatedDummy) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2351 >(2351)(Pointer,@relatedDummy?.Pointer ?? IntPtr.Zero); }
    public bool @TryToExplode() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2352 >(2352)(Pointer); return __sdkResult != 0; }
    public void @SetObjectTargettable(byte @targetable) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2353 >(2353)(Pointer,@targetable); }
    public bool @CanBeTargetted() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2354 >(2354)(Pointer); return __sdkResult != 0; }
    public void @RefModelInfo(int @modelIndex) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2355 >(2355)(Pointer,@modelIndex); }
    public void @SetRemapTexture(RwTexture? @remapTexture,short @txdIndex) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2356 >(2356)(Pointer,@remapTexture?.Pointer ?? IntPtr.Zero,@txdIndex); }
    public float @GetRopeHeight() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2357 >(2357)(Pointer); return __sdkResult; }
    public void @SetRopeHeight(float @height) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2358 >(2358)(Pointer,@height); }
    public CEntity? @GetObjectCarriedWithRope() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2359 >(2359)(Pointer); return __sdkResult == IntPtr.Zero ? null : new CEntity(__sdkResult); }
    public void @ReleaseObjectCarriedWithRope() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2360 >(2360)(Pointer); }
    public void @AddToControlCodeList() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2361 >(2361)(Pointer); }
    public void @RemoveFromControlCodeList() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2362 >(2362)(Pointer); }
    public void @ResetDoorAngle() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2363 >(2363)(Pointer); }
    public void @LockDoor() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2364 >(2364)(Pointer); }
    public void @Init() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2365 >(2365)(Pointer); }
    public void @DoBurnEffect() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2366 >(2366)(Pointer); }
    public byte @GetLightingFromCollisionBelow() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2367 >(2367)(Pointer); return __sdkResult; }
    public void @ProcessSamSiteBehaviour() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2368 >(2368)(Pointer); }
    public void @ProcessTrainCrossingBehaviour() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2369 >(2369)(Pointer); }
    public void @ObjectDamage(float @damage,CVector? @fxOrigin,CVector? @fxDirection,CEntity? @damager,eWeaponType @weaponType) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2370 >(2370)(Pointer,@damage,@fxOrigin?.Pointer ?? IntPtr.Zero,@fxDirection?.Pointer ?? IntPtr.Zero,@damager?.Pointer ?? IntPtr.Zero,(int)@weaponType); }
    public void @Explode() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2371 >(2371)(Pointer); }
    public void @ObjectFireDamage(float @damage,CEntity? @damager) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2372 >(2372)(Pointer,@damage,@damager?.Pointer ?? IntPtr.Zero); }
    public void @GrabObjectToCarryWithRope(CPhysical? @attachTo) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2373 >(2373)(Pointer,@attachTo?.Pointer ?? IntPtr.Zero); }
    public bool @CanBeUsedToTakeCoverBehind() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2374 >(2374)(Pointer); return __sdkResult != 0; }
    public static CObject? @Create(int @modelIndex) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2375 >(2375)(@modelIndex); return __sdkResult == IntPtr.Zero ? null : new CObject(__sdkResult); }
    public static CObject? @Create(CDummyObject? @dummyObject) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2376 >(2376)(@dummyObject?.Pointer ?? IntPtr.Zero); return __sdkResult == IntPtr.Zero ? null : new CObject(__sdkResult); }
    public void @ProcessControlLogic() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2377 >(2377)(Pointer); }
    public static void @SetMatrixForTrainCrossing(CMatrix? @matrix,float @arg1) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2378 >(2378)(@matrix?.Pointer ?? IntPtr.Zero,@arg1); }
    public static void @TryToFreeUpTempObjects(int @numObjects) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2379 >(2379)(@numObjects); }
    public static void @DeleteAllTempObjects() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2380 >(2380)(); }
    public static void @DeleteAllMissionObjects() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2381 >(2381)(); }
    public static void @DeleteAllTempObjectsInArea(CVector @point,float @radius) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2382 >(2382)(@point.Pointer,@radius); }
}
