// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CVehicleModelInfo : CClumpModelInfo
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=776;
    public CVehicleModelInfo(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_pPlateMaterial")]
    public RpMaterial? @PlateMaterial { get => SdkMemory.Read<IntPtr>(Pointer+36) == IntPtr.Zero ? null : new RpMaterial(SdkMemory.Read<IntPtr>(Pointer+36)); set { SdkMemory.Write(Pointer+36,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_szPlateText")]
    public NativeArray<sbyte> @PlateText { get => new NativeArray<sbyte>(Pointer+40,8); }
    [NativeMember("field_30")]
    public sbyte @Field30 { get => SdkMemory.Read<sbyte >(Pointer+48); set { SdkMemory.Write(Pointer+48,value); } }
    [NativeMember("m_nPlateType")]
    public byte @PlateType { get => SdkMemory.Read<byte >(Pointer+49); set { SdkMemory.Write(Pointer+49,value); } }
    [NativeMember("m_szGameName")]
    public NativeArray<sbyte> @GameName { get => new NativeArray<sbyte>(Pointer+50,8); }
    [NativeMember("m_nVehicleType")]
    public eVehicleType @VehicleType { get => SdkMemory.Read<eVehicleType >(Pointer+60); set { SdkMemory.Write(Pointer+60,value); } }
    [NativeMember("m_fWheelSizeFront")]
    public float @WheelSizeFront { get => SdkMemory.Read<float >(Pointer+64); set { SdkMemory.Write(Pointer+64,value); } }
    [NativeMember("m_fWheelSizeRear")]
    public float @WheelSizeRear { get => SdkMemory.Read<float >(Pointer+68); set { SdkMemory.Write(Pointer+68,value); } }
    [NativeMember("m_nWheelModelIndex")]
    public short @WheelModelIndex { get => SdkMemory.Read<short >(Pointer+72); set { SdkMemory.Write(Pointer+72,value); } }
    [NativeMember("m_nHandlingId")]
    public ushort @HandlingId { get => SdkMemory.Read<ushort >(Pointer+74); set { SdkMemory.Write(Pointer+74,value); } }
    [NativeMember("m_nNumDoors")]
    public byte @CountDoors { get => SdkMemory.Read<byte >(Pointer+76); set { SdkMemory.Write(Pointer+76,value); } }
    [NativeMember("m_nVehicleClass")]
    public byte @VehicleClass { get => SdkMemory.Read<byte >(Pointer+77); set { SdkMemory.Write(Pointer+77,value); } }
    [NativeMember("m_nFlags")]
    public byte @Flags { get => SdkMemory.Read<byte >(Pointer+78); set { SdkMemory.Write(Pointer+78,value); } }
    [NativeMember("m_nWheelUpgradeClass")]
    public byte @WheelUpgradeClass { get => SdkMemory.Read<byte >(Pointer+79); set { SdkMemory.Write(Pointer+79,value); } }
    [NativeMember("m_nTimesUsed")]
    public byte @TimesUsed { get => SdkMemory.Read<byte >(Pointer+80); set { SdkMemory.Write(Pointer+80,value); } }
    [NativeMember("field_51")]
    public sbyte @Field51 { get => SdkMemory.Read<sbyte >(Pointer+81); set { SdkMemory.Write(Pointer+81,value); } }
    [NativeMember("m_nFrq")]
    public ushort @Frq { get => SdkMemory.Read<ushort >(Pointer+82); set { SdkMemory.Write(Pointer+82,value); } }
    [NativeMember("m_fBikeSteerAngle")]
    public float @BikeSteerAngle { get => SdkMemory.Read<float >(Pointer+88); set { SdkMemory.Write(Pointer+88,value); } }
    [NativeMember("m_pVehicleStruct")]
    public CVehicleModelInfo__CVehicleStructure? @VehicleStruct { get => SdkMemory.Read<IntPtr>(Pointer+92) == IntPtr.Zero ? null : new CVehicleModelInfo__CVehicleStructure(SdkMemory.Read<IntPtr>(Pointer+92)); set { SdkMemory.Write(Pointer+92,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("field_60")]
    public NativeArray<sbyte> @Field60 { get => new NativeArray<sbyte>(Pointer+96,464); }
    [NativeMember("m_apDirtMaterials")]
    public NativeArray<IntPtr> @DirtMaterials { get => new NativeArray<IntPtr>(Pointer+560,32); }
    [NativeMember("m_anPrimaryColors")]
    public NativeArray<byte> @PrimaryColors { get => new NativeArray<byte>(Pointer+688,8); }
    [NativeMember("m_anSecondaryColors")]
    public NativeArray<byte> @SecondaryColors { get => new NativeArray<byte>(Pointer+696,8); }
    [NativeMember("m_anTertiaryColors")]
    public NativeArray<byte> @TertiaryColors { get => new NativeArray<byte>(Pointer+704,8); }
    [NativeMember("m_anQuaternaryColors")]
    public NativeArray<byte> @QuaternaryColors { get => new NativeArray<byte>(Pointer+712,8); }
    [NativeMember("m_nNumColorVariations")]
    public byte @CountColorVariations { get => SdkMemory.Read<byte >(Pointer+720); set { SdkMemory.Write(Pointer+720,value); } }
    [NativeMember("m_nLastColorVariation")]
    public byte @LastColorVariation { get => SdkMemory.Read<byte >(Pointer+721); set { SdkMemory.Write(Pointer+721,value); } }
    [NativeMember("m_nCurrentPrimaryColor")]
    public byte @CurrentPrimaryColor { get => SdkMemory.Read<byte >(Pointer+722); set { SdkMemory.Write(Pointer+722,value); } }
    [NativeMember("m_nCurrentSecondaryColor")]
    public byte @CurrentSecondaryColor { get => SdkMemory.Read<byte >(Pointer+723); set { SdkMemory.Write(Pointer+723,value); } }
    [NativeMember("m_nCurrentTertiaryColor")]
    public byte @CurrentTertiaryColor { get => SdkMemory.Read<byte >(Pointer+724); set { SdkMemory.Write(Pointer+724,value); } }
    [NativeMember("m_nCurrentQuaternaryColor")]
    public byte @CurrentQuaternaryColor { get => SdkMemory.Read<byte >(Pointer+725); set { SdkMemory.Write(Pointer+725,value); } }
    [NativeMember("m_anUpgrades")]
    public NativeArray<short> @Upgrades { get => new NativeArray<short>(Pointer+726,18); }
    [NativeMember("m_anRemapTxds")]
    public NativeArray<short> @RemapTxds { get => new NativeArray<short>(Pointer+762,4); }
    [NativeMember("m_pAnimBlock")]
    public CAnimBlock? @AnimationBlock { get => SdkMemory.Read<IntPtr>(Pointer+772) == IntPtr.Zero ? null : new CAnimBlock(SdkMemory.Read<IntPtr>(Pointer+772)); set { SdkMemory.Write(Pointer+772,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("ms_pRemapTexture")]
    public static RwTexture? @RemapTexture { get => SdkMemory.Read<IntPtr>(new IntPtr(0xB4E47C)) == IntPtr.Zero ? null : new RwTexture(SdkMemory.Read<IntPtr>(new IntPtr(0xB4E47C))); set { SdkMemory.Write(new IntPtr(0xB4E47C),value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("ms_pLightsTexture")]
    public static RwTexture? @LightsTexture { get => SdkMemory.Read<IntPtr>(new IntPtr(0xB4E68C)) == IntPtr.Zero ? null : new RwTexture(SdkMemory.Read<IntPtr>(new IntPtr(0xB4E68C))); set { SdkMemory.Write(new IntPtr(0xB4E68C),value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("ms_pLightsOnTexture")]
    public static RwTexture? @LightsOnTexture { get => SdkMemory.Read<IntPtr>(new IntPtr(0xB4E690)) == IntPtr.Zero ? null : new RwTexture(SdkMemory.Read<IntPtr>(new IntPtr(0xB4E690))); set { SdkMemory.Write(new IntPtr(0xB4E690),value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("ms_pWhiteTexture")]
    public static RwTexture? @WhiteTexture { get => SdkMemory.Read<IntPtr>(new IntPtr(0xB4E3EC)) == IntPtr.Zero ? null : new RwTexture(SdkMemory.Read<IntPtr>(new IntPtr(0xB4E3EC))); set { SdkMemory.Write(new IntPtr(0xB4E3EC),value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("ms_pVehicleTxd")]
    public static RwTexDictionary? @VehicleTxd { get => SdkMemory.Read<IntPtr>(new IntPtr(0xB4E688)) == IntPtr.Zero ? null : new RwTexDictionary(SdkMemory.Read<IntPtr>(new IntPtr(0xB4E688))); set { SdkMemory.Write(new IntPtr(0xB4E688),value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("ms_currentCol")]
    public static NativePointer<byte> @CurrentCollision { get => new NativePointer<byte>(new IntPtr(0xB4E3F0)); }
    [NativeMember("ms_lightsOn")]
    public static NativePointer<sbyte> @LightsOn { get => new NativePointer<sbyte>(new IntPtr(0xB4E3E8)); }
    [NativeMember("ms_compsUsed")]
    public static NativePointer<sbyte> @CompsUsed { get => new NativePointer<sbyte>(new IntPtr(0xB4E478)); }
    [NativeMember("ms_compsToUse")]
    public static NativePointer<sbyte> @CompsToUse { get => new NativePointer<sbyte>(new IntPtr(0x8A6458)); }
    [NativeMember("ms_vehicleColourTable")]
    public static CRGBA? @VehicleColorTable { get => new IntPtr(0xB4E480) == IntPtr.Zero ? null : new CRGBA(new IntPtr(0xB4E480)); }
    public static void @ShutdownLightTexture() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D419 >(419)(); }
    public static RwTexture? @FindTextureCB(NativePointer<sbyte> @name) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D420 >(420)(@name.Pointer); return __sdkResult == IntPtr.Zero ? null : new RwTexture(__sdkResult); }
    public static void @UseCommonVehicleTexDicationary() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D421 >(421)(); }
    public static void @StopUsingCommonVehicleTexDicationary() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D422 >(422)(); }
    public static RpAtomic? @MoveObjectsCB(RwObject? @object,NativePointer<IntPtr> @data) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D423 >(423)(@object?.Pointer ?? IntPtr.Zero,@data.Pointer); return __sdkResult == IntPtr.Zero ? null : new RpAtomic(__sdkResult); }
    public static RpAtomic? @HideDamagedAtomicCB(RpAtomic? @atomic,NativePointer<IntPtr> @data) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D424 >(424)(@atomic?.Pointer ?? IntPtr.Zero,@data.Pointer); return __sdkResult == IntPtr.Zero ? null : new RpAtomic(__sdkResult); }
    public static RpAtomic? @HideAllComponentsAtomicCB(RpAtomic? @atomic,NativePointer<IntPtr> @data) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D425 >(425)(@atomic?.Pointer ?? IntPtr.Zero,@data.Pointer); return __sdkResult == IntPtr.Zero ? null : new RpAtomic(__sdkResult); }
    public static RpMaterial? @HasAlphaMaterialCB(RpMaterial? @material,NativePointer<IntPtr> @data) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D426 >(426)(@material?.Pointer ?? IntPtr.Zero,@data.Pointer); return __sdkResult == IntPtr.Zero ? null : new RpMaterial(__sdkResult); }
    public static RpAtomic? @SetAtomicRendererCB(RpAtomic? @atomic,NativePointer<IntPtr> @data) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D427 >(427)(@atomic?.Pointer ?? IntPtr.Zero,@data.Pointer); return __sdkResult == IntPtr.Zero ? null : new RpAtomic(__sdkResult); }
    public static RpAtomic? @SetAtomicRendererCB_RealHeli(RpAtomic? @atomic,NativePointer<IntPtr> @data) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D428 >(428)(@atomic?.Pointer ?? IntPtr.Zero,@data.Pointer); return __sdkResult == IntPtr.Zero ? null : new RpAtomic(__sdkResult); }
    public static RpAtomic? @SetAtomicRendererCB_Plane(RpAtomic? @atomic,NativePointer<IntPtr> @data) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D429 >(429)(@atomic?.Pointer ?? IntPtr.Zero,@data.Pointer); return __sdkResult == IntPtr.Zero ? null : new RpAtomic(__sdkResult); }
    public static RpAtomic? @SetAtomicRendererCB_Boat(RpAtomic? @atomic,NativePointer<IntPtr> @data) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D430 >(430)(@atomic?.Pointer ?? IntPtr.Zero,@data.Pointer); return __sdkResult == IntPtr.Zero ? null : new RpAtomic(__sdkResult); }
    public static RpAtomic? @SetAtomicRendererCB_Heli(RpAtomic? @atomic,NativePointer<IntPtr> @data) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D431 >(431)(@atomic?.Pointer ?? IntPtr.Zero,@data.Pointer); return __sdkResult == IntPtr.Zero ? null : new RpAtomic(__sdkResult); }
    public static RpAtomic? @SetAtomicRendererCB_Train(RpAtomic? @atomic,NativePointer<IntPtr> @data) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D432 >(432)(@atomic?.Pointer ?? IntPtr.Zero,@data.Pointer); return __sdkResult == IntPtr.Zero ? null : new RpAtomic(__sdkResult); }
    public void @SetAtomicRenderCallbacks() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D433 >(433)(Pointer); }
    public static RwObject? @SetAtomicFlagCB(RwObject? @object,NativePointer<IntPtr> @data) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D434 >(434)(@object?.Pointer ?? IntPtr.Zero,@data.Pointer); return __sdkResult == IntPtr.Zero ? null : new RwObject(__sdkResult); }
    public static RwObject? @ClearAtomicFlagCB(RwObject? @object,NativePointer<IntPtr> @data) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D435 >(435)(@object?.Pointer ?? IntPtr.Zero,@data.Pointer); return __sdkResult == IntPtr.Zero ? null : new RwObject(__sdkResult); }
    public void @SetVehicleComponentFlags(RwFrame? @component,uint @flags) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D436 >(436)(Pointer,@component?.Pointer ?? IntPtr.Zero,@flags); }
    public void @GetWheelPosn(int @wheel,CVector @outVec,bool @local) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D437 >(437)(Pointer,@wheel,@outVec.Pointer,(@local ? 1 : 0)); }
    public bool @GetOriginalCompPosition(CVector @outVec,int @component) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D438 >(438)(Pointer,@outVec.Pointer,@component); return __sdkResult != 0; }
    public int @ChooseComponent() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D439 >(439)(Pointer); return __sdkResult; }
    public int @ChooseSecondComponent() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D440 >(440)(Pointer); return __sdkResult; }
    public bool @IsUpgradeAvailable(VehicleUpgradePosn @upgrade) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D441 >(441)(Pointer,(int)@upgrade); return __sdkResult != 0; }
    public RpMaterial? @SetEditableMaterialsCB(RpMaterial? @material,NativePointer<IntPtr> @data) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D442 >(442)(Pointer,@material?.Pointer ?? IntPtr.Zero,@data.Pointer); return __sdkResult == IntPtr.Zero ? null : new RpMaterial(__sdkResult); }
    public RpAtomic? @SetEditableMaterialsCB(RpAtomic? @atomic,NativePointer<IntPtr> @data) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D443 >(443)(Pointer,@atomic?.Pointer ?? IntPtr.Zero,@data.Pointer); return __sdkResult == IntPtr.Zero ? null : new RpAtomic(__sdkResult); }
    public void @SetEditableMaterials(RpClump? @clump) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D444 >(444)(Pointer,@clump?.Pointer ?? IntPtr.Zero); }
    public void @ResetEditableMaterials(RpClump? @clump) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D445 >(445)(Pointer,@clump?.Pointer ?? IntPtr.Zero); }
    public void @SetVehicleColour(byte @prim,byte @sec,byte @tert,byte @quat) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D446 >(446)(Pointer,@prim,@sec,@tert,@quat); }
    public void @ChooseVehicleColour(NativePointer<byte> @prim,NativePointer<byte> @sec,NativePointer<byte> @tert,NativePointer<byte> @quat,int @variationShift) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D447 >(447)(Pointer,@prim.Pointer,@sec.Pointer,@tert.Pointer,@quat.Pointer,@variationShift); }
    public int @GetNumRemaps() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D448 >(448)(Pointer); return __sdkResult; }
    public void @AddRemap(int @txd) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D449 >(449)(Pointer,@txd); }
    public static void @AddWheelUpgrade(int @wheelSetNumber,int @modelId) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D450 >(450)(@wheelSetNumber,@modelId); }
    public static int @GetNumWheelUpgrades(int @wheelSetNumber) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D451 >(451)(@wheelSetNumber); return __sdkResult; }
    public static void @GetWheelUpgrade(int @wheelSetNumber,int @wheelUpgradeNumber) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D452 >(452)(@wheelSetNumber,@wheelUpgradeNumber); }
    public static void @DeleteVehicleColourTextures() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D453 >(453)(); }
    public static void @LoadEnvironmentMaps() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D454 >(454)(); }
    public static void @ShutdownEnvironmentMaps() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D455 >(455)(); }
    public static RpMaterial? @GetMatFXEffectMaterialCB(RpMaterial? @material,NativePointer<IntPtr> @data) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D456 >(456)(@material?.Pointer ?? IntPtr.Zero,@data.Pointer); return __sdkResult == IntPtr.Zero ? null : new RpMaterial(__sdkResult); }
    public static RpMaterial? @SetEnvironmentMapCB(RpMaterial? @material,NativePointer<IntPtr> @data) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D457 >(457)(@material?.Pointer ?? IntPtr.Zero,@data.Pointer); return __sdkResult == IntPtr.Zero ? null : new RpMaterial(__sdkResult); }
    public static RpMaterial? @SetEnvMapCoeffCB(RpMaterial? @material,NativePointer<IntPtr> @data) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D458 >(458)(@material?.Pointer ?? IntPtr.Zero,@data.Pointer); return __sdkResult == IntPtr.Zero ? null : new RpMaterial(__sdkResult); }
    public static RpAtomic? @SetRenderPipelinesCB(RpAtomic? @atomic,NativePointer<IntPtr> @data) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D459 >(459)(@atomic?.Pointer ?? IntPtr.Zero,@data.Pointer); return __sdkResult == IntPtr.Zero ? null : new RpAtomic(__sdkResult); }
    public void @SetRenderPipelines() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D460 >(460)(Pointer); }
    public NativePointer<sbyte> @GetCustomCarPlateText() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D461 >(461)(Pointer); return new NativePointer<sbyte>(__sdkResult); }
    public void @SetCustomCarPlateText(NativePointer<sbyte> @text) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D462 >(462)(Pointer,@text.Pointer); }
    public static int @GetMaximumNumberOfPassengersFromNumberOfDoors(int @modelId) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D463 >(463)(@modelId); return __sdkResult; }
    public void @ReduceMaterialsInVehicle() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D464 >(464)(Pointer); }
    public void @SetupLightFlags(CVehicle? @vehicle) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D465 >(465)(Pointer,@vehicle?.Pointer ?? IntPtr.Zero); }
    public static RwFrame? @CollapseFramesCB(RwFrame? @frame,NativePointer<IntPtr> @data) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D466 >(466)(@frame?.Pointer ?? IntPtr.Zero,@data.Pointer); return __sdkResult == IntPtr.Zero ? null : new RwFrame(__sdkResult); }
    public void @PreprocessHierarchy() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D467 >(467)(Pointer); }
    public static RpAtomic? @SetEnvironmentMapAtomicCB(RpAtomic? @atomic,NativePointer<IntPtr> @data) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D468 >(468)(@atomic?.Pointer ?? IntPtr.Zero,@data.Pointer); return __sdkResult == IntPtr.Zero ? null : new RpAtomic(__sdkResult); }
    public static RpAtomic? @SetEnvMapCoeffAtomicCB(RpAtomic? @atomic,NativePointer<IntPtr> @data) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D469 >(469)(@atomic?.Pointer ?? IntPtr.Zero,@data.Pointer); return __sdkResult == IntPtr.Zero ? null : new RpAtomic(__sdkResult); }
    public void @SetCarCustomPlate() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D470 >(470)(Pointer); }
    public void @DisableEnvMap() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D471 >(471)(Pointer); }
    public void @SetEnvMapCoeff(float @coeff) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D472 >(472)(Pointer,@coeff); }
    public int @GetNumDoors() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D473 >(473)(Pointer); return __sdkResult; }
}
