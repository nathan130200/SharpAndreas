// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class Fx_c : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=112;
    public Fx_c(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_pPrtBlood")]
    public FxSystem_c? @PrtBlood { get => SdkMemory.Read<IntPtr>(Pointer+0) == IntPtr.Zero ? null : new FxSystem_c(SdkMemory.Read<IntPtr>(Pointer+0)); set { SdkMemory.Write(Pointer+0,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_pPrtBoatsplash")]
    public FxSystem_c? @PrtBoatsplash { get => SdkMemory.Read<IntPtr>(Pointer+4) == IntPtr.Zero ? null : new FxSystem_c(SdkMemory.Read<IntPtr>(Pointer+4)); set { SdkMemory.Write(Pointer+4,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_pPrtBubble")]
    public FxSystem_c? @PrtBubble { get => SdkMemory.Read<IntPtr>(Pointer+8) == IntPtr.Zero ? null : new FxSystem_c(SdkMemory.Read<IntPtr>(Pointer+8)); set { SdkMemory.Write(Pointer+8,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_pPrtCardebris")]
    public FxSystem_c? @PrtCardebris { get => SdkMemory.Read<IntPtr>(Pointer+12) == IntPtr.Zero ? null : new FxSystem_c(SdkMemory.Read<IntPtr>(Pointer+12)); set { SdkMemory.Write(Pointer+12,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_pPrtCollisionsmoke")]
    public FxSystem_c? @PrtCollisionsmoke { get => SdkMemory.Read<IntPtr>(Pointer+16) == IntPtr.Zero ? null : new FxSystem_c(SdkMemory.Read<IntPtr>(Pointer+16)); set { SdkMemory.Write(Pointer+16,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_pPrtGunshell")]
    public FxSystem_c? @PrtGunshell { get => SdkMemory.Read<IntPtr>(Pointer+20) == IntPtr.Zero ? null : new FxSystem_c(SdkMemory.Read<IntPtr>(Pointer+20)); set { SdkMemory.Write(Pointer+20,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_pPrtSand")]
    public FxSystem_c? @PrtSand { get => SdkMemory.Read<IntPtr>(Pointer+24) == IntPtr.Zero ? null : new FxSystem_c(SdkMemory.Read<IntPtr>(Pointer+24)); set { SdkMemory.Write(Pointer+24,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_pPrtSand2")]
    public FxSystem_c? @PrtSand2 { get => SdkMemory.Read<IntPtr>(Pointer+28) == IntPtr.Zero ? null : new FxSystem_c(SdkMemory.Read<IntPtr>(Pointer+28)); set { SdkMemory.Write(Pointer+28,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_pPrtSmoke_huge")]
    public FxSystem_c? @PrtSmokeHuge { get => SdkMemory.Read<IntPtr>(Pointer+32) == IntPtr.Zero ? null : new FxSystem_c(SdkMemory.Read<IntPtr>(Pointer+32)); set { SdkMemory.Write(Pointer+32,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_pPrtSmokeII3expand")]
    public FxSystem_c? @PrtSmokeII3expand { get => SdkMemory.Read<IntPtr>(Pointer+36) == IntPtr.Zero ? null : new FxSystem_c(SdkMemory.Read<IntPtr>(Pointer+36)); set { SdkMemory.Write(Pointer+36,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_pPrtSpark")]
    public FxSystem_c? @PrtSpark { get => SdkMemory.Read<IntPtr>(Pointer+40) == IntPtr.Zero ? null : new FxSystem_c(SdkMemory.Read<IntPtr>(Pointer+40)); set { SdkMemory.Write(Pointer+40,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_pPrtSpark2")]
    public FxSystem_c? @PrtSpark2 { get => SdkMemory.Read<IntPtr>(Pointer+44) == IntPtr.Zero ? null : new FxSystem_c(SdkMemory.Read<IntPtr>(Pointer+44)); set { SdkMemory.Write(Pointer+44,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_pPrtSplash")]
    public FxSystem_c? @PrtSplash { get => SdkMemory.Read<IntPtr>(Pointer+48) == IntPtr.Zero ? null : new FxSystem_c(SdkMemory.Read<IntPtr>(Pointer+48)); set { SdkMemory.Write(Pointer+48,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_pPrtWake")]
    public FxSystem_c? @PrtWake { get => SdkMemory.Read<IntPtr>(Pointer+52) == IntPtr.Zero ? null : new FxSystem_c(SdkMemory.Read<IntPtr>(Pointer+52)); set { SdkMemory.Write(Pointer+52,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_pPrtWatersplash")]
    public FxSystem_c? @PrtWatersplash { get => SdkMemory.Read<IntPtr>(Pointer+56) == IntPtr.Zero ? null : new FxSystem_c(SdkMemory.Read<IntPtr>(Pointer+56)); set { SdkMemory.Write(Pointer+56,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_pPrtWheeldirt")]
    public FxSystem_c? @PrtWheeldirt { get => SdkMemory.Read<IntPtr>(Pointer+60) == IntPtr.Zero ? null : new FxSystem_c(SdkMemory.Read<IntPtr>(Pointer+60)); set { SdkMemory.Write(Pointer+60,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_pPrtGlass")]
    public FxSystem_c? @PrtGlass { get => SdkMemory.Read<IntPtr>(Pointer+64) == IntPtr.Zero ? null : new FxSystem_c(SdkMemory.Read<IntPtr>(Pointer+64)); set { SdkMemory.Write(Pointer+64,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_entityFxList")]
    public TList_c_ListItem_c__4249979743 @EntityFxList { get => new TList_c_ListItem_c__4249979743(Pointer+68); set { SdkMemory.Copy(value.Pointer,Pointer+68,12); } }
    [NativeMember("m_nBloodPoolsCount")]
    public uint @BloodPoolsCount { get => SdkMemory.Read<uint >(Pointer+80); set { SdkMemory.Write(Pointer+80,value); } }
    [NativeMember("m_fxQuality")]
    public FxQuality_e @FxQuality { get => SdkMemory.Read<FxQuality_e >(Pointer+84); set { SdkMemory.Write(Pointer+84,value); } }
    [NativeMember("m_nVerticesCount2")]
    public uint @VerticesCount2 { get => SdkMemory.Read<uint >(Pointer+88); set { SdkMemory.Write(Pointer+88,value); } }
    [NativeMember("m_nVerticesCount")]
    public uint @VerticesCount { get => SdkMemory.Read<uint >(Pointer+92); set { SdkMemory.Write(Pointer+92,value); } }
    [NativeMember("m_nTransformRenderFlags")]
    public uint @TransformRenderFlags { get => SdkMemory.Read<uint >(Pointer+96); set { SdkMemory.Write(Pointer+96,value); } }
    [NativeMember("m_pRasterToRender")]
    public RwRaster? @RasterToRender { get => SdkMemory.Read<IntPtr>(Pointer+100) == IntPtr.Zero ? null : new RwRaster(SdkMemory.Read<IntPtr>(Pointer+100)); set { SdkMemory.Write(Pointer+100,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_pTransformLTM")]
    public RwMatrixTag? @TransformLTM { get => SdkMemory.Read<IntPtr>(Pointer+104) == IntPtr.Zero ? null : new RwMatrixTag(SdkMemory.Read<IntPtr>(Pointer+104)); set { SdkMemory.Write(Pointer+104,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_pVerts")]
    public NativePointer<IntPtr> @Verts { get => new NativePointer<IntPtr>(SdkMemory.Read<IntPtr>(Pointer+108)); set { SdkMemory.Write(Pointer+108,value.Pointer); } }
    public void @InitializeAt() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4562 >(4562)(Pointer); }
    public void @DestroyNative() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4563 >(4563)(Pointer); }
    public void @Update(RwCamera? @camera,float @timeDelta) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4564 >(4564)(Pointer,@camera?.Pointer ?? IntPtr.Zero,@timeDelta); }
    public void @Render(RwCamera? @camera,byte @arg1) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4565 >(4565)(Pointer,@camera?.Pointer ?? IntPtr.Zero,@arg1); }
    public void @InitStaticSystems() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4566 >(4566)(Pointer); }
    public void @ExitStaticSystems() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4567 >(4567)(Pointer); }
    public void @CreateMatFromVec(RwMatrixTag? @out,CVector? @origin,CVector? @direction) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4568 >(4568)(Pointer,@out?.Pointer ?? IntPtr.Zero,@origin?.Pointer ?? IntPtr.Zero,@direction?.Pointer ?? IntPtr.Zero); }
    public void @SetFxQuality(FxQuality_e @quality) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4569 >(4569)(Pointer,(int)@quality); }
    public FxQuality_e @GetFxQuality() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4570 >(4570)(Pointer); return (FxQuality_e)__sdkResult; }
    public void @InitEntitySystems() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4571 >(4571)(Pointer); }
    public bool @Init() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4572 >(4572)(Pointer); return __sdkResult != 0; }
    public void @Reset() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4573 >(4573)(Pointer); }
    public void @AddBlood(CVector @origin,CVector @direction,int @amount,float @arg3) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4574 >(4574)(Pointer,@origin.Pointer,@direction.Pointer,@amount,@arg3); }
    public void @AddWood(CVector @origin,CVector @direction,int @amount,float @arg3) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4575 >(4575)(Pointer,@origin.Pointer,@direction.Pointer,@amount,@arg3); }
    public void @AddSparks(CVector @origin,CVector @direction,float @force,int @amount,CVector @across,byte @sparksType,float @spread,float @life) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4576 >(4576)(Pointer,@origin.Pointer,@direction.Pointer,@force,@amount,@across.Pointer,@sparksType,@spread,@life); }
    public void @AddTyreBurst(CVector @position,CVector @velocity) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4577 >(4577)(Pointer,@position.Pointer,@velocity.Pointer); }
    public void @AddBulletImpact(CVector @position,CVector @direction,int @bulletFxType,int @amount,float @arg4) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4578 >(4578)(Pointer,@position.Pointer,@direction.Pointer,@bulletFxType,@amount,@arg4); }
    public void @AddPunchImpact(CVector @position,CVector @velocity,int @arg2) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4579 >(4579)(Pointer,@position.Pointer,@velocity.Pointer,@arg2); }
    public void @AddDebris(CVector @position,RwRGBA @color,float @scale,int @amount) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4580 >(4580)(Pointer,@position.Pointer,@color.Pointer,@scale,@amount); }
    public void @AddGlass(CVector @position,RwRGBA @color,float @scale,int @amount) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4581 >(4581)(Pointer,@position.Pointer,@color.Pointer,@scale,@amount); }
    public void @AddWheelSpray(CVehicle? @vehicle,CVector @position,byte @arg2,byte @arg3,float @arg4) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4582 >(4582)(Pointer,@vehicle?.Pointer ?? IntPtr.Zero,@position.Pointer,@arg2,@arg3,@arg4); }
    public void @AddWheelGrass(CVehicle? @vehicle,CVector @position,byte @arg2,float @arg3) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4583 >(4583)(Pointer,@vehicle?.Pointer ?? IntPtr.Zero,@position.Pointer,@arg2,@arg3); }
    public void @AddWheelGravel(CVehicle? @vehicle,CVector @position,byte @arg2,float @arg3) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4584 >(4584)(Pointer,@vehicle?.Pointer ?? IntPtr.Zero,@position.Pointer,@arg2,@arg3); }
    public void @AddWheelMud(CVehicle? @vehicle,CVector @position,byte @arg2,float @arg3) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4585 >(4585)(Pointer,@vehicle?.Pointer ?? IntPtr.Zero,@position.Pointer,@arg2,@arg3); }
    public void @AddWheelSand(CVehicle? @vehicle,CVector @position,byte @arg2,float @arg3) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4586 >(4586)(Pointer,@vehicle?.Pointer ?? IntPtr.Zero,@position.Pointer,@arg2,@arg3); }
    public void @AddWheelDust(CVehicle? @vehicle,CVector @position,byte @arg2,float @arg3) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4587 >(4587)(Pointer,@vehicle?.Pointer ?? IntPtr.Zero,@position.Pointer,@arg2,@arg3); }
    public void @TriggerWaterHydrant(CVector @position) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4588 >(4588)(Pointer,@position.Pointer); }
    public void @TriggerGunshot(CEntity? @entity,CVector @origin,CVector @target,bool @doGunflash) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4589 >(4589)(Pointer,@entity?.Pointer ?? IntPtr.Zero,@origin.Pointer,@target.Pointer,(@doGunflash ? 1 : 0)); }
    public void @TriggerTankFire(CVector @origin,CVector @target) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4590 >(4590)(Pointer,@origin.Pointer,@target.Pointer); }
    public void @TriggerWaterSplash(CVector @position) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4591 >(4591)(Pointer,@position.Pointer); }
    public void @TriggerBulletSplash(CVector @position) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4592 >(4592)(Pointer,@position.Pointer); }
    public void @TriggerFootSplash(CVector @position) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4593 >(4593)(Pointer,@position.Pointer); }
    public void @CreateEntityFx(CEntity? @entity,NativePointer<sbyte> @fxName,RwV3d? @position,RwMatrixTag? @transform) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4594 >(4594)(Pointer,@entity?.Pointer ?? IntPtr.Zero,@fxName.Pointer,@position?.Pointer ?? IntPtr.Zero,@transform?.Pointer ?? IntPtr.Zero); }
    public void @DestroyEntityFx(CEntity? @entity) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4595 >(4595)(Pointer,@entity?.Pointer ?? IntPtr.Zero); }
    public void @ExitEntitySystems() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4596 >(4596)(Pointer); }
    public void @Exit() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4597 >(4597)(Pointer); }
}
