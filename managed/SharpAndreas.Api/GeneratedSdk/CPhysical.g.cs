// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CPhysical : CEntity
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=312;
    public CPhysical(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("field_38")]
    public int @Field38 { get => SdkMemory.Read<int >(Pointer+56); set { SdkMemory.Write(Pointer+56,value); } }
    [NativeMember("m_nLastCollisionTime")]
    public uint @LastCollisionTime { get => SdkMemory.Read<uint >(Pointer+60); set { SdkMemory.Write(Pointer+60,value); } }
    [NativeMember("bIsHeavy")]
    public bool @IsHeavy { get => SdkMemory.ReadBits(Pointer,512,1) != 0; set { SdkMemory.WriteBits(Pointer,512,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bApplyGravity")]
    public bool @ApplyGravityValue { get => SdkMemory.ReadBits(Pointer,513,1) != 0; set { SdkMemory.WriteBits(Pointer,513,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bDisableCollisionForce")]
    public bool @DisableCollisionForce { get => SdkMemory.ReadBits(Pointer,514,1) != 0; set { SdkMemory.WriteBits(Pointer,514,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bCollidable")]
    public bool @Collidable { get => SdkMemory.ReadBits(Pointer,515,1) != 0; set { SdkMemory.WriteBits(Pointer,515,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bDisableTurnForce")]
    public bool @DisableTurnForce { get => SdkMemory.ReadBits(Pointer,516,1) != 0; set { SdkMemory.WriteBits(Pointer,516,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bDisableMoveForce")]
    public bool @DisableMoveForce { get => SdkMemory.ReadBits(Pointer,517,1) != 0; set { SdkMemory.WriteBits(Pointer,517,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bInfiniteMass")]
    public bool @InfiniteMass { get => SdkMemory.ReadBits(Pointer,518,1) != 0; set { SdkMemory.WriteBits(Pointer,518,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bDisableZ")]
    public bool @DisableZ { get => SdkMemory.ReadBits(Pointer,519,1) != 0; set { SdkMemory.WriteBits(Pointer,519,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bSubmergedInWater")]
    public bool @SubmergedInWater { get => SdkMemory.ReadBits(Pointer,520,1) != 0; set { SdkMemory.WriteBits(Pointer,520,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bOnSolidSurface")]
    public bool @OnSolidSurface { get => SdkMemory.ReadBits(Pointer,521,1) != 0; set { SdkMemory.WriteBits(Pointer,521,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bBroken")]
    public bool @Broken { get => SdkMemory.ReadBits(Pointer,522,1) != 0; set { SdkMemory.WriteBits(Pointer,522,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bProcessCollisionEvenIfStationary")]
    public bool @ProcessCollisionEvenIfStationary { get => SdkMemory.ReadBits(Pointer,523,1) != 0; set { SdkMemory.WriteBits(Pointer,523,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bSkipLineCol")]
    public bool @SkipLineCollision { get => SdkMemory.ReadBits(Pointer,524,1) != 0; set { SdkMemory.WriteBits(Pointer,524,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bDontApplySpeed")]
    public bool @DontApplySpeed { get => SdkMemory.ReadBits(Pointer,525,1) != 0; set { SdkMemory.WriteBits(Pointer,525,1,(value ? 1UL : 0UL)); } }
    [NativeMember("b15")]
    public bool @B15 { get => SdkMemory.ReadBits(Pointer,526,1) != 0; set { SdkMemory.WriteBits(Pointer,526,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bProcessingShift")]
    public bool @ProcessingShift { get => SdkMemory.ReadBits(Pointer,527,1) != 0; set { SdkMemory.WriteBits(Pointer,527,1,(value ? 1UL : 0UL)); } }
    [NativeMember("b17")]
    public bool @B17 { get => SdkMemory.ReadBits(Pointer,528,1) != 0; set { SdkMemory.WriteBits(Pointer,528,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bDisableSimpleCollision")]
    public bool @DisableSimpleCollision { get => SdkMemory.ReadBits(Pointer,529,1) != 0; set { SdkMemory.WriteBits(Pointer,529,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bBulletProof")]
    public bool @BulletProof { get => SdkMemory.ReadBits(Pointer,530,1) != 0; set { SdkMemory.WriteBits(Pointer,530,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bFireProof")]
    public bool @FireProof { get => SdkMemory.ReadBits(Pointer,531,1) != 0; set { SdkMemory.WriteBits(Pointer,531,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bCollisionProof")]
    public bool @CollisionProof { get => SdkMemory.ReadBits(Pointer,532,1) != 0; set { SdkMemory.WriteBits(Pointer,532,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bMeleeProof")]
    public bool @MeleeProof { get => SdkMemory.ReadBits(Pointer,533,1) != 0; set { SdkMemory.WriteBits(Pointer,533,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bInvulnerable")]
    public bool @Invulnerable { get => SdkMemory.ReadBits(Pointer,534,1) != 0; set { SdkMemory.WriteBits(Pointer,534,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bExplosionProof")]
    public bool @ExplosionProof { get => SdkMemory.ReadBits(Pointer,535,1) != 0; set { SdkMemory.WriteBits(Pointer,535,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bDontCollideWithFlyers")]
    public bool @DontCollideWithFlyers { get => SdkMemory.ReadBits(Pointer,536,1) != 0; set { SdkMemory.WriteBits(Pointer,536,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bAttachedToEntity")]
    public bool @AttachedToEntity { get => SdkMemory.ReadBits(Pointer,537,1) != 0; set { SdkMemory.WriteBits(Pointer,537,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bAddMovingCollisionSpeed")]
    public bool @AddMovingCollisionSpeed { get => SdkMemory.ReadBits(Pointer,538,1) != 0; set { SdkMemory.WriteBits(Pointer,538,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bTouchingWater")]
    public bool @TouchingWater { get => SdkMemory.ReadBits(Pointer,539,1) != 0; set { SdkMemory.WriteBits(Pointer,539,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bCanBeCollidedWith")]
    public bool @CanBeCollidedWith { get => SdkMemory.ReadBits(Pointer,540,1) != 0; set { SdkMemory.WriteBits(Pointer,540,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bDestroyed")]
    public bool @Destroyed { get => SdkMemory.ReadBits(Pointer,541,1) != 0; set { SdkMemory.WriteBits(Pointer,541,1,(value ? 1UL : 0UL)); } }
    [NativeMember("b31")]
    public bool @B31 { get => SdkMemory.ReadBits(Pointer,542,1) != 0; set { SdkMemory.WriteBits(Pointer,542,1,(value ? 1UL : 0UL)); } }
    [NativeMember("b32")]
    public bool @B32 { get => SdkMemory.ReadBits(Pointer,543,1) != 0; set { SdkMemory.WriteBits(Pointer,543,1,(value ? 1UL : 0UL)); } }
    [NativeMember("m_vecMoveSpeed")]
    public CVector @MoveSpeed { get => new CVector(Pointer+68); set { SdkMemory.Copy(value.Pointer,Pointer+68,12); } }
    [NativeMember("m_vecTurnSpeed")]
    public CVector @TurnSpeed { get => new CVector(Pointer+80); set { SdkMemory.Copy(value.Pointer,Pointer+80,12); } }
    [NativeMember("m_vecFrictionMoveSpeed")]
    public CVector @FrictionMoveSpeed { get => new CVector(Pointer+92); set { SdkMemory.Copy(value.Pointer,Pointer+92,12); } }
    [NativeMember("m_vecFrictionTurnSpeed")]
    public CVector @FrictionTurnSpeed { get => new CVector(Pointer+104); set { SdkMemory.Copy(value.Pointer,Pointer+104,12); } }
    [NativeMember("m_vecForce")]
    public CVector @Force { get => new CVector(Pointer+116); set { SdkMemory.Copy(value.Pointer,Pointer+116,12); } }
    [NativeMember("m_vecTorque")]
    public CVector @Torque { get => new CVector(Pointer+128); set { SdkMemory.Copy(value.Pointer,Pointer+128,12); } }
    [NativeMember("m_fMass")]
    public float @Mass { get => SdkMemory.Read<float >(Pointer+140); set { SdkMemory.Write(Pointer+140,value); } }
    [NativeMember("m_fTurnMass")]
    public float @TurnMass { get => SdkMemory.Read<float >(Pointer+144); set { SdkMemory.Write(Pointer+144,value); } }
    [NativeMember("m_fVelocityFrequency")]
    public float @VelocityFrequency { get => SdkMemory.Read<float >(Pointer+148); set { SdkMemory.Write(Pointer+148,value); } }
    [NativeMember("m_fAirResistance")]
    public float @AirResistance { get => SdkMemory.Read<float >(Pointer+152); set { SdkMemory.Write(Pointer+152,value); } }
    [NativeMember("m_fElasticity")]
    public float @Elasticity { get => SdkMemory.Read<float >(Pointer+156); set { SdkMemory.Write(Pointer+156,value); } }
    [NativeMember("m_fBuoyancyConstant")]
    public float @BuoyancyConstant { get => SdkMemory.Read<float >(Pointer+160); set { SdkMemory.Write(Pointer+160,value); } }
    [NativeMember("m_vecCentreOfMass")]
    public CVector @CentreOfMass { get => new CVector(Pointer+164); set { SdkMemory.Copy(value.Pointer,Pointer+164,12); } }
    [NativeMember("m_pCollisionList")]
    public NativePointer<IntPtr> @CollisionList { get => new NativePointer<IntPtr>(SdkMemory.Read<IntPtr>(Pointer+176)); set { SdkMemory.Write(Pointer+176,value.Pointer); } }
    [NativeMember("m_pMovingList")]
    public NativePointer<IntPtr> @MovingList { get => new NativePointer<IntPtr>(SdkMemory.Read<IntPtr>(Pointer+180)); set { SdkMemory.Write(Pointer+180,value.Pointer); } }
    [NativeMember("m_nFakePhysics")]
    public sbyte @FakePhysics { get => SdkMemory.Read<sbyte >(Pointer+184); set { SdkMemory.Write(Pointer+184,value); } }
    [NativeMember("m_nNumEntitiesCollided")]
    public byte @CountEntitiesCollided { get => SdkMemory.Read<byte >(Pointer+185); set { SdkMemory.Write(Pointer+185,value); } }
    [NativeMember("m_nContactSurface")]
    public byte @ContactSurface { get => SdkMemory.Read<byte >(Pointer+186); set { SdkMemory.Write(Pointer+186,value); } }
    [NativeMember("field_BB")]
    public sbyte @FieldBB { get => SdkMemory.Read<sbyte >(Pointer+187); set { SdkMemory.Write(Pointer+187,value); } }
    [NativeMember("m_apCollidedEntities")]
    public NativeArray<IntPtr> @CollidedEntities { get => new NativeArray<IntPtr>(Pointer+188,6); }
    [NativeMember("m_fMovingSpeed")]
    public float @MovingSpeed { get => SdkMemory.Read<float >(Pointer+212); set { SdkMemory.Write(Pointer+212,value); } }
    [NativeMember("m_fDamageIntensity")]
    public float @DamageIntensity { get => SdkMemory.Read<float >(Pointer+216); set { SdkMemory.Write(Pointer+216,value); } }
    [NativeMember("m_pDamageEntity")]
    public CEntity? @DamageEntity { get => SdkMemory.Read<IntPtr>(Pointer+220) == IntPtr.Zero ? null : new CEntity(SdkMemory.Read<IntPtr>(Pointer+220)); set { SdkMemory.Write(Pointer+220,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_vecLastCollisionImpactVelocity")]
    public CVector @LastCollisionImpactVelocity { get => new CVector(Pointer+224); set { SdkMemory.Copy(value.Pointer,Pointer+224,12); } }
    [NativeMember("m_vecLastCollisionPosn")]
    public CVector @LastCollisionPosition { get => new CVector(Pointer+236); set { SdkMemory.Copy(value.Pointer,Pointer+236,12); } }
    [NativeMember("m_nPieceType")]
    public ushort @PieceType { get => SdkMemory.Read<ushort >(Pointer+248); set { SdkMemory.Write(Pointer+248,value); } }
    [NativeMember("field_FA")]
    public short @FieldFA { get => SdkMemory.Read<short >(Pointer+250); set { SdkMemory.Write(Pointer+250,value); } }
    [NativeMember("m_pAttachedTo")]
    public CPhysical? @AttachedTo { get => SdkMemory.Read<IntPtr>(Pointer+252) == IntPtr.Zero ? null : new CPhysical(SdkMemory.Read<IntPtr>(Pointer+252)); set { SdkMemory.Write(Pointer+252,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_vecAttachOffset")]
    public CVector @AttachOffset { get => new CVector(Pointer+256); set { SdkMemory.Copy(value.Pointer,Pointer+256,12); } }
    [NativeMember("m_vecAttachedEntityPosn")]
    public CVector @AttachedEntityPosition { get => new CVector(Pointer+268); set { SdkMemory.Copy(value.Pointer,Pointer+268,12); } }
    [NativeMember("m_qAttachedEntityRotation")]
    public CQuaternion @QAttachedEntityRotation { get => new CQuaternion(Pointer+280); set { SdkMemory.Copy(value.Pointer,Pointer+280,16); } }
    [NativeMember("m_pEntityIgnoredCollision")]
    public CEntity? @EntityIgnoredCollision { get => SdkMemory.Read<IntPtr>(Pointer+296) == IntPtr.Zero ? null : new CEntity(SdkMemory.Read<IntPtr>(Pointer+296)); set { SdkMemory.Write(Pointer+296,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_fContactSurfaceBrightness")]
    public float @ContactSurfaceBrightness { get => SdkMemory.Read<float >(Pointer+300); set { SdkMemory.Write(Pointer+300,value); } }
    [NativeMember("m_fDynamicLighting")]
    public float @DynamicLighting { get => SdkMemory.Read<float >(Pointer+304); set { SdkMemory.Write(Pointer+304,value); } }
    [NativeMember("m_pShadowData")]
    public CRealTimeShadow? @ShadowData { get => SdkMemory.Read<IntPtr>(Pointer+308) == IntPtr.Zero ? null : new CRealTimeShadow(SdkMemory.Read<IntPtr>(Pointer+308)); set { SdkMemory.Write(Pointer+308,value?.Pointer ?? IntPtr.Zero); } }
    public void @ProcessEntityCollision(CEntity? @entity,CColPoint? @point) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D895 >(895)(Pointer,@entity?.Pointer ?? IntPtr.Zero,@point?.Pointer ?? IntPtr.Zero); }
    public void @RemoveAndAdd() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D896 >(896)(Pointer); }
    public void @AddToMovingList() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D897 >(897)(Pointer); }
    public void @RemoveFromMovingList() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D898 >(898)(Pointer); }
    public void @SetDamagedPieceRecord(float @damageIntensity,CEntity? @damagingEntity,CColPoint @colPoint,float @distanceMult) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D899 >(899)(Pointer,@damageIntensity,@damagingEntity?.Pointer ?? IntPtr.Zero,@colPoint.Pointer,@distanceMult); }
    public void @ApplyMoveForce(CVector @force) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D900 >(900)(Pointer,@force.Pointer); }
    public void @ApplyTurnForce(CVector @dir,CVector @velocity) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D901 >(901)(Pointer,@dir.Pointer,@velocity.Pointer); }
    public void @ApplyForce(CVector @dir,CVector @velocity,bool @bUpdateTurnSpeed) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D902 >(902)(Pointer,@dir.Pointer,@velocity.Pointer,(@bUpdateTurnSpeed ? 1 : 0)); }
    public CVector @GetSpeed(CVector @direction) { Game.CheckThread(); var result=NativeObject.AllocateStorage<CVector >(12); try { SdkBindings.Get<GeneratedDelegates.D903 >(903)(Pointer,@direction.Pointer,result.Pointer); return result; } catch { result.Dispose(); throw; } }
    public void @ApplyMoveSpeed() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D904 >(904)(Pointer); }
    public void @ApplyTurnSpeed() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D905 >(905)(Pointer); }
    public void @ApplyGravity() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D906 >(906)(Pointer); }
    public void @ApplyFrictionMoveForce(CVector @moveForce) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D907 >(907)(Pointer,@moveForce.Pointer); }
    public void @ApplyFrictionTurnForce(CVector @posn,CVector @velocity) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D908 >(908)(Pointer,@posn.Pointer,@velocity.Pointer); }
    public void @ApplyFrictionForce(CVector @posn,CVector @velocity) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D909 >(909)(Pointer,@posn.Pointer,@velocity.Pointer); }
    public void @SkipPhysics() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D910 >(910)(Pointer); }
    public void @AddCollisionRecord(CEntity? @collidedEntity) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D911 >(911)(Pointer,@collidedEntity?.Pointer ?? IntPtr.Zero); }
    public bool @GetHasCollidedWith(CEntity? @entity) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D912 >(912)(Pointer,@entity?.Pointer ?? IntPtr.Zero); return __sdkResult != 0; }
    public bool @GetHasCollidedWithAnyObject() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D913 >(913)(Pointer); return __sdkResult != 0; }
    public bool @ApplyCollision(CEntity? @entity,CColPoint @colPoint,NativePointer<float> @outDamageIntensity) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D914 >(914)(Pointer,@entity?.Pointer ?? IntPtr.Zero,@colPoint.Pointer,@outDamageIntensity.Pointer); return __sdkResult != 0; }
    public bool @ApplySoftCollision(CEntity? @entity,CColPoint @colPoint,NativePointer<float> @outDamageIntensity) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D915 >(915)(Pointer,@entity?.Pointer ?? IntPtr.Zero,@colPoint.Pointer,@outDamageIntensity.Pointer); return __sdkResult != 0; }
    public bool @ApplySpringCollision(float @arg0,CVector @arg1,CVector @arg2,float @arg3,float @arg4,NativePointer<float> @arg5) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D916 >(916)(Pointer,@arg0,@arg1.Pointer,@arg2.Pointer,@arg3,@arg4,@arg5.Pointer); return __sdkResult != 0; }
    public bool @ApplySpringCollisionAlt(float @arg0,CVector @arg1,CVector @arg2,float @arg3,float @arg4,CVector @arg5,NativePointer<float> @arg6) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D917 >(917)(Pointer,@arg0,@arg1.Pointer,@arg2.Pointer,@arg3,@arg4,@arg5.Pointer,@arg6.Pointer); return __sdkResult != 0; }
    public bool @ApplySpringDampening(float @arg0,float @arg1,CVector @arg2,CVector @arg3,CVector @arg4) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D918 >(918)(Pointer,@arg0,@arg1,@arg2.Pointer,@arg3.Pointer,@arg4.Pointer); return __sdkResult != 0; }
    public bool @ApplySpringDampeningOld(float @arg0,float @arg1,CVector @arg2,CVector @arg3,CVector @arg4) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D919 >(919)(Pointer,@arg0,@arg1,@arg2.Pointer,@arg3.Pointer,@arg4.Pointer); return __sdkResult != 0; }
    public void @RemoveRefsToEntity(CEntity? @entity) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D920 >(920)(Pointer,@entity?.Pointer ?? IntPtr.Zero); }
    public void @DettachEntityFromEntity(float @x,float @y,float @z,bool @useCollision) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D921 >(921)(Pointer,@x,@y,@z,(@useCollision ? 1 : 0)); }
    public void @DettachAutoAttachedEntity() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D922 >(922)(Pointer); }
    public float @GetLightingFromCol(bool @flag) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D923 >(923)(Pointer,(@flag ? 1 : 0)); return __sdkResult; }
    public float @GetLightingTotal() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D924 >(924)(Pointer); return __sdkResult; }
    public bool @CanPhysicalBeDamaged(eWeaponType @weapon,NativePointer<bool> @bDamagedDueToFireOrExplosionOrBullet) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D925 >(925)(Pointer,(int)@weapon,@bDamagedDueToFireOrExplosionOrBullet.Pointer); return __sdkResult != 0; }
    public void @ApplyAirResistance() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D926 >(926)(Pointer); }
    public bool @ApplyCollisionAlt(CPhysical? @entity,CColPoint @colPoint,NativePointer<float> @arg2,CVector @arg3,CVector @arg4) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D927 >(927)(Pointer,@entity?.Pointer ?? IntPtr.Zero,@colPoint.Pointer,@arg2.Pointer,@arg3.Pointer,@arg4.Pointer); return __sdkResult != 0; }
    public bool @ApplyFriction(float @friction,CColPoint @colPoint) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D928 >(928)(Pointer,@friction,@colPoint.Pointer); return __sdkResult != 0; }
    public bool @ApplyFriction(CPhysical? @physical,float @friction,CColPoint @colPoint) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D929 >(929)(Pointer,@physical?.Pointer ?? IntPtr.Zero,@friction,@colPoint.Pointer); return __sdkResult != 0; }
    public bool @ProcessShiftSectorList(int @sectorX,int @sectorY) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D930 >(930)(Pointer,@sectorX,@sectorY); return __sdkResult != 0; }
    public static void @PlacePhysicalRelativeToOtherPhysical(CPhysical? @physical1,CPhysical? @physical2,CVector @offset) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D931 >(931)(@physical1?.Pointer ?? IntPtr.Zero,@physical2?.Pointer ?? IntPtr.Zero,@offset.Pointer); }
    public float @ApplyScriptCollision(CVector @arg0,float @arg1,float @arg2,CVector? @arg3) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D932 >(932)(Pointer,@arg0.Pointer,@arg1,@arg2,@arg3?.Pointer ?? IntPtr.Zero); return __sdkResult; }
    public void @PositionAttachedEntity() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D933 >(933)(Pointer); }
    public void @ApplySpeed() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D934 >(934)(Pointer); }
    public void @UnsetIsInSafePosition() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D935 >(935)(Pointer); }
    public void @ApplyFriction() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D936 >(936)(Pointer); }
    public bool @ApplyCollision(CPhysical? @physical,CColPoint @colPoint,NativePointer<float> @arg2,NativePointer<float> @arg3) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D937 >(937)(Pointer,@physical?.Pointer ?? IntPtr.Zero,@colPoint.Pointer,@arg2.Pointer,@arg3.Pointer); return __sdkResult != 0; }
    public bool @ApplySoftCollision(CPhysical? @physical,CColPoint @colPoint,NativePointer<float> @arg2,NativePointer<float> @arg3) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D938 >(938)(Pointer,@physical?.Pointer ?? IntPtr.Zero,@colPoint.Pointer,@arg2.Pointer,@arg3.Pointer); return __sdkResult != 0; }
    public bool @ProcessCollisionSectorList(int @sectorX,int @sectorY) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D939 >(939)(Pointer,@sectorX,@sectorY); return __sdkResult != 0; }
    public bool @ProcessCollisionSectorList_SimpleCar(CRepeatSector? @sector) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D940 >(940)(Pointer,@sector?.Pointer ?? IntPtr.Zero); return __sdkResult != 0; }
    public void @AttachEntityToEntity(CEntity? @entity,CVector @offset,CVector @rotation) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D941 >(941)(Pointer,@entity?.Pointer ?? IntPtr.Zero,@offset.Pointer,@rotation.Pointer); }
    public void @AttachEntityToEntity(CEntity? @entity,CVector? @offset,RtQuat? @rotation) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D942 >(942)(Pointer,@entity?.Pointer ?? IntPtr.Zero,@offset?.Pointer ?? IntPtr.Zero,@rotation?.Pointer ?? IntPtr.Zero); }
    public bool @CheckCollision() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D943 >(943)(Pointer); return __sdkResult != 0; }
    public bool @CheckCollision_SimpleCar() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D944 >(944)(Pointer); return __sdkResult != 0; }
}
