// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CEntity : CPlaceable
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=56;
    public CEntity(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("bUsesCollision")]
    public bool @UsesCollision { get => SdkMemory.ReadBits(Pointer,224,1) != 0; set { SdkMemory.WriteBits(Pointer,224,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bCollisionProcessed")]
    public bool @CollisionProcessed { get => SdkMemory.ReadBits(Pointer,225,1) != 0; set { SdkMemory.WriteBits(Pointer,225,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bIsStatic")]
    public bool @IsStatic { get => SdkMemory.ReadBits(Pointer,226,1) != 0; set { SdkMemory.WriteBits(Pointer,226,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bHasContacted")]
    public bool @HasContacted { get => SdkMemory.ReadBits(Pointer,227,1) != 0; set { SdkMemory.WriteBits(Pointer,227,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bIsStuck")]
    public bool @IsStuck { get => SdkMemory.ReadBits(Pointer,228,1) != 0; set { SdkMemory.WriteBits(Pointer,228,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bIsInSafePosition")]
    public bool @IsInSafePosition { get => SdkMemory.ReadBits(Pointer,229,1) != 0; set { SdkMemory.WriteBits(Pointer,229,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bWasPostponed")]
    public bool @WasPostponed { get => SdkMemory.ReadBits(Pointer,230,1) != 0; set { SdkMemory.WriteBits(Pointer,230,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bIsVisible")]
    public bool @IsVisibleValue { get => SdkMemory.ReadBits(Pointer,231,1) != 0; set { SdkMemory.WriteBits(Pointer,231,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bIsBIGBuilding")]
    public bool @IsBIGBuilding { get => SdkMemory.ReadBits(Pointer,232,1) != 0; set { SdkMemory.WriteBits(Pointer,232,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bRenderDamaged")]
    public bool @RenderDamaged { get => SdkMemory.ReadBits(Pointer,233,1) != 0; set { SdkMemory.WriteBits(Pointer,233,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bStreamingDontDelete")]
    public bool @StreamingDontDelete { get => SdkMemory.ReadBits(Pointer,234,1) != 0; set { SdkMemory.WriteBits(Pointer,234,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bRemoveFromWorld")]
    public bool @RemoveFromWorld { get => SdkMemory.ReadBits(Pointer,235,1) != 0; set { SdkMemory.WriteBits(Pointer,235,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bHasHitWall")]
    public bool @HasHitWall { get => SdkMemory.ReadBits(Pointer,236,1) != 0; set { SdkMemory.WriteBits(Pointer,236,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bImBeingRendered")]
    public bool @ImBeingRendered { get => SdkMemory.ReadBits(Pointer,237,1) != 0; set { SdkMemory.WriteBits(Pointer,237,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bDrawLast")]
    public bool @DrawLast { get => SdkMemory.ReadBits(Pointer,238,1) != 0; set { SdkMemory.WriteBits(Pointer,238,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bDistanceFade")]
    public bool @DistanceFade { get => SdkMemory.ReadBits(Pointer,239,1) != 0; set { SdkMemory.WriteBits(Pointer,239,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bDontCastShadowsOn")]
    public bool @DontCastShadowsOn { get => SdkMemory.ReadBits(Pointer,240,1) != 0; set { SdkMemory.WriteBits(Pointer,240,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bOffscreen")]
    public bool @Offscreen { get => SdkMemory.ReadBits(Pointer,241,1) != 0; set { SdkMemory.WriteBits(Pointer,241,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bIsStaticWaitingForCollision")]
    public bool @IsStaticWaitingForCollision { get => SdkMemory.ReadBits(Pointer,242,1) != 0; set { SdkMemory.WriteBits(Pointer,242,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bDontStream")]
    public bool @DontStream { get => SdkMemory.ReadBits(Pointer,243,1) != 0; set { SdkMemory.WriteBits(Pointer,243,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bUnderwater")]
    public bool @Underwater { get => SdkMemory.ReadBits(Pointer,244,1) != 0; set { SdkMemory.WriteBits(Pointer,244,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bHasPreRenderEffects")]
    public bool @HasPreRenderEffectsValue { get => SdkMemory.ReadBits(Pointer,245,1) != 0; set { SdkMemory.WriteBits(Pointer,245,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bIsTempBuilding")]
    public bool @IsTempBuilding { get => SdkMemory.ReadBits(Pointer,246,1) != 0; set { SdkMemory.WriteBits(Pointer,246,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bDontUpdateHierarchy")]
    public bool @DontUpdateHierarchy { get => SdkMemory.ReadBits(Pointer,247,1) != 0; set { SdkMemory.WriteBits(Pointer,247,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bHasRoadsignText")]
    public bool @HasRoadsignText { get => SdkMemory.ReadBits(Pointer,248,1) != 0; set { SdkMemory.WriteBits(Pointer,248,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bDisplayedSuperLowLOD")]
    public bool @DisplayedSuperLowLOD { get => SdkMemory.ReadBits(Pointer,249,1) != 0; set { SdkMemory.WriteBits(Pointer,249,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bIsProcObject")]
    public bool @IsProcObject { get => SdkMemory.ReadBits(Pointer,250,1) != 0; set { SdkMemory.WriteBits(Pointer,250,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bBackfaceCulled")]
    public bool @BackfaceCulled { get => SdkMemory.ReadBits(Pointer,251,1) != 0; set { SdkMemory.WriteBits(Pointer,251,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bLightObject")]
    public bool @LightObject { get => SdkMemory.ReadBits(Pointer,252,1) != 0; set { SdkMemory.WriteBits(Pointer,252,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bUnimportantStream")]
    public bool @UnimportantStream { get => SdkMemory.ReadBits(Pointer,253,1) != 0; set { SdkMemory.WriteBits(Pointer,253,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bTunnel")]
    public bool @Tunnel { get => SdkMemory.ReadBits(Pointer,254,1) != 0; set { SdkMemory.WriteBits(Pointer,254,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bTunnelTransition")]
    public bool @TunnelTransition { get => SdkMemory.ReadBits(Pointer,255,1) != 0; set { SdkMemory.WriteBits(Pointer,255,1,(value ? 1UL : 0UL)); } }
    [NativeMember("m_nRandomSeed")]
    public ushort @RandomSeed { get => SdkMemory.Read<ushort >(Pointer+32); set { SdkMemory.Write(Pointer+32,value); } }
    [NativeMember("m_nModelIndex")]
    public short @ModelIndex { get => SdkMemory.Read<short >(Pointer+34); set { SdkMemory.Write(Pointer+34,value); } }
    [NativeMember("m_pReferences")]
    public CReference? @References { get => SdkMemory.Read<IntPtr>(Pointer+36) == IntPtr.Zero ? null : new CReference(SdkMemory.Read<IntPtr>(Pointer+36)); set { SdkMemory.Write(Pointer+36,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_pStreamingLink")]
    public NativePointer<IntPtr> @StreamingLink { get => new NativePointer<IntPtr>(SdkMemory.Read<IntPtr>(Pointer+40)); set { SdkMemory.Write(Pointer+40,value.Pointer); } }
    [NativeMember("m_nScanCode")]
    public short @ScanCode { get => SdkMemory.Read<short >(Pointer+44); set { SdkMemory.Write(Pointer+44,value); } }
    [NativeMember("m_nIplIndex")]
    public sbyte @IplIndex { get => SdkMemory.Read<sbyte >(Pointer+46); set { SdkMemory.Write(Pointer+46,value); } }
    [NativeMember("m_nAreaCode")]
    public byte @AreaCode { get => SdkMemory.Read<byte >(Pointer+47); set { SdkMemory.Write(Pointer+47,value); } }
    [NativeMember("m_nNumLodChildren")]
    public byte @CountLodChildren { get => SdkMemory.Read<byte >(Pointer+52); set { SdkMemory.Write(Pointer+52,value); } }
    [NativeMember("m_nNumLodChildrenRendered")]
    public byte @CountLodChildrenRendered { get => SdkMemory.Read<byte >(Pointer+53); set { SdkMemory.Write(Pointer+53,value); } }
    [NativeMember("m_nType")]
    public eEntityType @Type { get => (eEntityType)SdkMemory.ReadBits(Pointer,432,3); set { SdkMemory.WriteBits(Pointer,432,3,unchecked((ulong)value)); } }
    [NativeMember("m_nStatus")]
    public eEntityStatus @Status { get => (eEntityStatus)SdkMemory.ReadBits(Pointer,435,5); set { SdkMemory.WriteBits(Pointer,435,5,unchecked((ulong)value)); } }
    public void @Add(CRect @rect) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D506 >(506)(Pointer,@rect.Pointer); }
    public void @Add() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D507 >(507)(Pointer); }
    public void @Remove() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D508 >(508)(Pointer); }
    public void @SetIsStatic(bool @isStatic) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D509 >(509)(Pointer,(@isStatic ? 1 : 0)); }
    public void @SetModelIndex(uint @index) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D510 >(510)(Pointer,@index); }
    public void @SetModelIndexNoCreate(uint @index) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D511 >(511)(Pointer,@index); }
    public void @CreateRwObject() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D512 >(512)(Pointer); }
    public void @DeleteRwObject() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D513 >(513)(Pointer); }
    public CRect @GetBoundRect() { Game.CheckThread(); var result=NativeObject.AllocateStorage<CRect >(16); try { SdkBindings.Get<GeneratedDelegates.D514 >(514)(Pointer,result.Pointer); return result; } catch { result.Dispose(); throw; } }
    public void @ProcessControl() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D515 >(515)(Pointer); }
    public void @ProcessCollision() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D516 >(516)(Pointer); }
    public void @ProcessShift() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D517 >(517)(Pointer); }
    public bool @TestCollision() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D518 >(518)(Pointer); return __sdkResult != 0; }
    public void @Teleport(CVector @destination,bool @resetRotation) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D519 >(519)(Pointer,@destination.Pointer,(@resetRotation ? 1 : 0)); }
    public void @SpecialEntityPreCollisionStuff(CEntity? @colEntity,bool @unk1,NativePointer<byte> @unk2,NativePointer<byte> @unk3,NativePointer<byte> @unk4,NativePointer<byte> @unk5) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D520 >(520)(Pointer,@colEntity?.Pointer ?? IntPtr.Zero,(@unk1 ? 1 : 0),@unk2.Pointer,@unk3.Pointer,@unk4.Pointer,@unk5.Pointer); }
    public void @SpecialEntityCalcCollisionSteps(NativePointer<byte> @unk1,NativePointer<byte> @unk2) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D521 >(521)(Pointer,@unk1.Pointer,@unk2.Pointer); }
    public void @PreRender() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D522 >(522)(Pointer); }
    public void @Render() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D523 >(523)(Pointer); }
    public bool @SetupLighting() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D524 >(524)(Pointer); return __sdkResult != 0; }
    public void @RemoveLighting(bool @bReset) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D525 >(525)(Pointer,(@bReset ? 1 : 0)); }
    public void @FlagToDestroyWhenNextProcessed() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D526 >(526)(Pointer); }
    public void @UpdateRwFrame() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D527 >(527)(Pointer); }
    public void @UpdateRwMatrix() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D528 >(528)(Pointer); }
    public void @UpdateRpHAnim() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D529 >(529)(Pointer); }
    public bool @HasPreRenderEffects() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D530 >(530)(Pointer); return __sdkResult != 0; }
    public bool @DoesNotCollideWithFlyers() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D531 >(531)(Pointer); return __sdkResult != 0; }
    public void @ModifyMatrixForPoleInWind() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D532 >(532)(Pointer); }
    public bool @LivesInThisNonOverlapSector(int @sectorX,int @sectorY) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D533 >(533)(Pointer,@sectorX,@sectorY); return __sdkResult != 0; }
    public void @SetupBigBuilding() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D534 >(534)(Pointer); }
    public void @ModifyMatrixForCrane() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D535 >(535)(Pointer); }
    public void @PreRenderForGlassWindow() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D536 >(536)(Pointer); }
    public void @SetRwObjectAlpha(int @alpha) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D537 >(537)(Pointer,@alpha); }
    public CVector @FindTriggerPointCoors(int @triggerIndex) { Game.CheckThread(); var result=NativeObject.AllocateStorage<CVector >(12); try { SdkBindings.Get<GeneratedDelegates.D538 >(538)(Pointer,@triggerIndex,result.Pointer); return result; } catch { result.Dispose(); throw; } }
    public C2dEffect? @GetRandom2dEffect(int @effectType,byte @arg1) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D539 >(539)(Pointer,@effectType,@arg1); return __sdkResult == IntPtr.Zero ? null : new C2dEffect(__sdkResult); }
    public CVector @TransformFromObjectSpace(CVector @offset) { Game.CheckThread(); var result=NativeObject.AllocateStorage<CVector >(12); try { SdkBindings.Get<GeneratedDelegates.D540 >(540)(Pointer,@offset.Pointer,result.Pointer); return result; } catch { result.Dispose(); throw; } }
    public void @TransformFromObjectSpace(CVector @outPosn,CVector @offset) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D541 >(541)(Pointer,@outPosn.Pointer,@offset.Pointer); }
    public void @CreateEffects() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D542 >(542)(Pointer); }
    public void @DestroyEffects() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D543 >(543)(Pointer); }
    public void @AttachToRwObject(RwObject? @object,bool @updateEntityMatrix) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D544 >(544)(Pointer,@object?.Pointer ?? IntPtr.Zero,(@updateEntityMatrix ? 1 : 0)); }
    public void @DetachFromRwObject() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D545 >(545)(Pointer); }
    public CVector @GetBoundCentre() { Game.CheckThread(); var result=NativeObject.AllocateStorage<CVector >(12); try { SdkBindings.Get<GeneratedDelegates.D546 >(546)(Pointer,result.Pointer); return result; } catch { result.Dispose(); throw; } }
    public void @GetBoundCentre(CVector @outCentre) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D547 >(547)(Pointer,@outCentre.Pointer); }
    public void @RenderEffects() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D548 >(548)(Pointer); }
    public bool @GetIsTouching(CEntity? @entity) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D549 >(549)(Pointer,@entity?.Pointer ?? IntPtr.Zero); return __sdkResult != 0; }
    public bool @GetIsTouching(CVector @centre,float @radius) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D550 >(550)(Pointer,@centre.Pointer,@radius); return __sdkResult != 0; }
    public bool @GetIsOnScreen() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D551 >(551)(Pointer); return __sdkResult != 0; }
    public bool @GetIsBoundingBoxOnScreen() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D552 >(552)(Pointer); return __sdkResult != 0; }
    public void @ModifyMatrixForTreeInWind() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D553 >(553)(Pointer); }
    public void @ModifyMatrixForBannerInWind() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D554 >(554)(Pointer); }
    public CColModel? @GetColModel() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D555 >(555)(Pointer); return __sdkResult == IntPtr.Zero ? null : new CColModel(__sdkResult); }
    public void @CalculateBBProjection(CVector? @arg0,CVector? @arg1,CVector? @arg2,CVector? @arg3) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D556 >(556)(Pointer,@arg0?.Pointer ?? IntPtr.Zero,@arg1?.Pointer ?? IntPtr.Zero,@arg2?.Pointer ?? IntPtr.Zero,@arg3?.Pointer ?? IntPtr.Zero); }
    public void @UpdateAnim() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D557 >(557)(Pointer); }
    public bool @IsVisible() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D558 >(558)(Pointer); return __sdkResult != 0; }
    public float @GetDistanceFromCentreOfMassToBaseOfModel() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D559 >(559)(Pointer); return __sdkResult; }
    public void @CleanUpOldReference(NativePointer<IntPtr> @entity) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D560 >(560)(Pointer,@entity.Pointer); }
    public void @ResolveReferences() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D561 >(561)(Pointer); }
    public void @PruneReferences() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D562 >(562)(Pointer); }
    public void @RegisterReference(NativePointer<IntPtr> @entity) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D563 >(563)(Pointer,@entity.Pointer); }
    public void @ProcessLightsForEntity() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D564 >(564)(Pointer); }
    public void @RemoveEscalatorsForEntity() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D565 >(565)(Pointer); }
    public bool @IsEntityOccluded() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D566 >(566)(Pointer); return __sdkResult != 0; }
    public float @GetBoundRadius() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D567 >(567)(Pointer); return __sdkResult; }
}
