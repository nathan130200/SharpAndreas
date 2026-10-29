// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CVisibilityPlugins : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=1;
    public CVisibilityPlugins(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("ms_atomicPluginOffset")]
    public static int @AtomicPluginOffset { get => SdkMemory.Read<int >(new IntPtr(0x8D608C)); set { SdkMemory.Write(new IntPtr(0x8D608C),value); } }
    [NativeMember("m_alphaList")]
    public static CLinkList_CVisibilityPlugins__AlphaObjectInfo__3ad57f5111 @AlphaList { get => new CLinkList_CVisibilityPlugins__AlphaObjectInfo__3ad57f5111(new IntPtr(0xC88070)); set { SdkMemory.Copy(value.Pointer,new IntPtr(0xC88070),-2); } }
    [NativeMember("m_alphaEntityList")]
    public static CLinkList_CVisibilityPlugins__AlphaObjectInfo__3ad57f5111 @AlphaEntityList { get => new CLinkList_CVisibilityPlugins__AlphaObjectInfo__3ad57f5111(new IntPtr(0xC88120)); set { SdkMemory.Copy(value.Pointer,new IntPtr(0xC88120),-2); } }
    [NativeMember("m_alphaBoatAtomicList")]
    public static CLinkList_CVisibilityPlugins__AlphaObjectInfo__3ad57f5111 @AlphaBoatAtomicList { get => new CLinkList_CVisibilityPlugins__AlphaObjectInfo__3ad57f5111(new IntPtr(0xC880C8)); set { SdkMemory.Copy(value.Pointer,new IntPtr(0xC880C8),-2); } }
    [NativeMember("m_alphaUnderwaterEntityList")]
    public static CLinkList_CVisibilityPlugins__AlphaObjectInfo__3ad57f5111 @AlphaUnderwaterEntityList { get => new CLinkList_CVisibilityPlugins__AlphaObjectInfo__3ad57f5111(new IntPtr(0xC88178)); set { SdkMemory.Copy(value.Pointer,new IntPtr(0xC88178),-2); } }
    [NativeMember("m_alphaReallyDrawLastList")]
    public static CLinkList_CVisibilityPlugins__AlphaObjectInfo__3ad57f5111 @AlphaReallyDrawLastList { get => new CLinkList_CVisibilityPlugins__AlphaObjectInfo__3ad57f5111(new IntPtr(0xC881D0)); set { SdkMemory.Copy(value.Pointer,new IntPtr(0xC881D0),-2); } }
    [NativeMember("ms_weaponPedsForPC")]
    public static CLinkList_CPed____476b2db6ea @WeaponPedsForPC { get => new CLinkList_CPed____476b2db6ea(new IntPtr(0xC88224)); set { SdkMemory.Copy(value.Pointer,new IntPtr(0xC88224),-2); } }
    [NativeMember("ms_pCamera")]
    public static RwCamera? @Camera { get => SdkMemory.Read<IntPtr>(new IntPtr(0xC8804C)) == IntPtr.Zero ? null : new RwCamera(SdkMemory.Read<IntPtr>(new IntPtr(0xC8804C))); set { SdkMemory.Write(new IntPtr(0xC8804C),value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("ms_pCameraPosn")]
    public static RwV3d? @CameraPosition { get => SdkMemory.Read<IntPtr>(new IntPtr(0xC88050)) == IntPtr.Zero ? null : new RwV3d(SdkMemory.Read<IntPtr>(new IntPtr(0xC88050))); set { SdkMemory.Write(new IntPtr(0xC88050),value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("ms_cullCompsDist")]
    public static float @CullCompsDistance { get => SdkMemory.Read<float >(new IntPtr(0x0C8802C)); set { SdkMemory.Write(new IntPtr(0x0C8802C),value); } }
    [NativeMember("ms_cullBigCompsDist")]
    public static float @CullBigCompsDistance { get => SdkMemory.Read<float >(new IntPtr(0x0C88028)); set { SdkMemory.Write(new IntPtr(0x0C88028),value); } }
    [NativeMember("ms_vehicleLod0RenderMultiPassDist")]
    public static float @VehicleLod0RenderMultiPassDistance { get => SdkMemory.Read<float >(new IntPtr(0xC88044)); set { SdkMemory.Write(new IntPtr(0xC88044),value); } }
    [NativeMember("ms_vehicleLod0Dist")]
    public static float @VehicleLod0Distance { get => SdkMemory.Read<float >(new IntPtr(0xC88040)); set { SdkMemory.Write(new IntPtr(0xC88040),value); } }
    [NativeMember("ms_vehicleLod1Dist")]
    public static float @VehicleLod1Distance { get => SdkMemory.Read<float >(new IntPtr(0xC8803C)); set { SdkMemory.Write(new IntPtr(0xC8803C),value); } }
    [NativeMember("ms_bigVehicleLod0Dist")]
    public static float @BigVehicleLod0Distance { get => SdkMemory.Read<float >(new IntPtr(0xC88038)); set { SdkMemory.Write(new IntPtr(0xC88038),value); } }
    [NativeMember("ms_pedLodDist")]
    public static float @PedLodDistance { get => SdkMemory.Read<float >(new IntPtr(0xC88034)); set { SdkMemory.Write(new IntPtr(0xC88034),value); } }
    [NativeMember("ms_pedFadeDist")]
    public static float @PedFadeDistance { get => SdkMemory.Read<float >(new IntPtr(0xC88030)); set { SdkMemory.Write(new IntPtr(0xC88030),value); } }
    [NativeMember("gVehicleDistanceFromCamera")]
    public static float @GVehicleDistanceFromCamera { get => SdkMemory.Read<float >(new IntPtr(0xC88024)); set { SdkMemory.Write(new IntPtr(0xC88024),value); } }
    [NativeMember("gVehicleAngleToCamera")]
    public static float @GVehicleAngleToCamera { get => SdkMemory.Read<float >(new IntPtr(0xC88020)); set { SdkMemory.Write(new IntPtr(0xC88020),value); } }
    public static void @AtomicConstructor(NativePointer<IntPtr> @object) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4284 >(4284)(@object.Pointer); }
    public static void @AtomicCopyConstructor(NativePointer<IntPtr> @object,NativePointer<IntPtr> @originalObject) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4285 >(4285)(@object.Pointer,@originalObject.Pointer); }
    public static NativePointer<IntPtr> @AtomicDestructor(NativePointer<IntPtr> @object) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4286 >(4286)(@object.Pointer); return new NativePointer<IntPtr>(__sdkResult); }
    public static int @CalculateFadingAtomicAlpha(CBaseModelInfo? @pBaseModelInfo,CEntity? @pEntity,float @arg3) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4287 >(4287)(@pBaseModelInfo?.Pointer ?? IntPtr.Zero,@pEntity?.Pointer ?? IntPtr.Zero,@arg3); return __sdkResult; }
    public static void @ClearAtomicFlag(RpAtomic? @pRpAtomic,int @flag) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4288 >(4288)(@pRpAtomic?.Pointer ?? IntPtr.Zero,@flag); }
    public static void @ClearAtomicFlag(RpAtomic? @pRpAtomic,ushort @flag) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4289 >(4289)(@pRpAtomic?.Pointer ?? IntPtr.Zero,@flag); }
    public static void @ClearClumpForAllAtomicsFlag(RpClump? @pRpClump,int @flag) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4290 >(4290)(@pRpClump?.Pointer ?? IntPtr.Zero,@flag); }
    public static void @ClumpConstructor(NativePointer<IntPtr> @object) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4291 >(4291)(@object.Pointer); }
    public static void @ClumpCopyConstructor(NativePointer<IntPtr> @object,NativePointer<IntPtr> @originalObject) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4292 >(4292)(@object.Pointer,@originalObject.Pointer); }
    public static NativePointer<IntPtr> @ClumpDestructor(NativePointer<IntPtr> @object) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4293 >(4293)(@object.Pointer); return new NativePointer<IntPtr>(__sdkResult); }
    public static int @DefaultVisibilityCB() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4294 >(4294)(); return __sdkResult; }
    public static void @FrameConstructor(NativePointer<IntPtr> @object) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4295 >(4295)(@object.Pointer); }
    public static void @FrameCopyConstructor(NativePointer<IntPtr> @object,NativePointer<IntPtr> @originalObject) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4296 >(4296)(@object.Pointer,@originalObject.Pointer); }
    public static NativePointer<IntPtr> @FrameDestructor(NativePointer<IntPtr> @arg0,int @arg1,int @arg2) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4297 >(4297)(@arg0.Pointer,@arg1,@arg2); return new NativePointer<IntPtr>(__sdkResult); }
    public static bool @FrustumSphereCB(RpClump? @pRpClump) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4298 >(4298)(@pRpClump?.Pointer ?? IntPtr.Zero); return __sdkResult != 0; }
    public static short @GetAtomicId(RpAtomic? @pRpAtomic) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4299 >(4299)(@pRpAtomic?.Pointer ?? IntPtr.Zero); return __sdkResult; }
    public static CAtomicModelInfo? @GetAtomicModelInfo(RpAtomic? @pRpAtomic) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4300 >(4300)(@pRpAtomic?.Pointer ?? IntPtr.Zero); return __sdkResult == IntPtr.Zero ? null : new CAtomicModelInfo(__sdkResult); }
    public static int @GetClumpAlpha(RpClump? @pRpClump) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4301 >(4301)(@pRpClump?.Pointer ?? IntPtr.Zero); return __sdkResult; }
    public static CClumpModelInfo? @GetClumpModelInfo(RpClump? @pRpClump) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4302 >(4302)(@pRpClump?.Pointer ?? IntPtr.Zero); return __sdkResult == IntPtr.Zero ? null : new CClumpModelInfo(__sdkResult); }
    public static float @GetDistanceSquaredFromCamera(RwFrame? @pRwFrame) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4303 >(4303)(@pRwFrame?.Pointer ?? IntPtr.Zero); return __sdkResult; }
    public static float @GetDistanceSquaredFromCamera(RwV3d? @pRwV3d) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4304 >(4304)(@pRwV3d?.Pointer ?? IntPtr.Zero); return __sdkResult; }
    public static float @GetDotProductWithCameraVector(RwMatrixTag? @atomicMat,RwMatrixTag? @rootMat,uint @flags) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4305 >(4305)(@atomicMat?.Pointer ?? IntPtr.Zero,@rootMat?.Pointer ?? IntPtr.Zero,@flags); return __sdkResult; }
    public static int @GetFrameHierarchyId(RwFrame? @pRwFrame) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4306 >(4306)(@pRwFrame?.Pointer ?? IntPtr.Zero); return __sdkResult; }
    public static short @GetModelInfoIndex(RpAtomic? @pRpAtomic) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4307 >(4307)(@pRpAtomic?.Pointer ?? IntPtr.Zero); return __sdkResult; }
    public static short @GetUserValue(RpAtomic? @pRpAtomic) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4308 >(4308)(@pRpAtomic?.Pointer ?? IntPtr.Zero); return __sdkResult; }
    public static void @InitAlphaAtomicList() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4309 >(4309)(); }
    public static void @InitAlphaEntityList() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4310 >(4310)(); }
    public static void @Initialise() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4311 >(4311)(); }
    public static bool @InsertAtomicIntoReallyDrawLastList(RpAtomic? @pRpAtomic,float @arg2) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4312 >(4312)(@pRpAtomic?.Pointer ?? IntPtr.Zero,@arg2); return __sdkResult != 0; }
    public static bool @InsertEntityIntoReallyDrawLastList(CEntity? @pEntity,float @arg2) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4313 >(4313)(@pEntity?.Pointer ?? IntPtr.Zero,@arg2); return __sdkResult != 0; }
    public static bool @InsertEntityIntoSortedList(CEntity? @pEntity,float @distance) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4314 >(4314)(@pEntity?.Pointer ?? IntPtr.Zero,@distance); return __sdkResult != 0; }
    public static bool @IsAtomicVisible(RpAtomic? @pRpAtomic) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4315 >(4315)(@pRpAtomic?.Pointer ?? IntPtr.Zero); return __sdkResult != 0; }
    public static bool @IsClumpVisible(RpClump? @pRpClump) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4316 >(4316)(@pRpClump?.Pointer ?? IntPtr.Zero); return __sdkResult != 0; }
    public static bool @PluginAttach() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4317 >(4317)(); return __sdkResult != 0; }
    public static void @RenderAlphaAtomic(RpAtomic? @pRpAtomic,int @dwAlpha) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4318 >(4318)(@pRpAtomic?.Pointer ?? IntPtr.Zero,@dwAlpha); }
    public static void @RenderAlphaAtomics() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4319 >(4319)(); }
    public static void @RenderAtomicWithAlphaCB(RpAtomic? @pRpAtomic,NativePointer<IntPtr> @pData) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4320 >(4320)(@pRpAtomic?.Pointer ?? IntPtr.Zero,@pData.Pointer); }
    public static void @RenderBoatAlphaAtomics() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4321 >(4321)(); }
    public static void @RenderEntity(NativePointer<IntPtr> @entity,bool @unused,float @arg3) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4322 >(4322)(@entity.Pointer,(@unused ? 1 : 0),@arg3); }
    public static void @RenderFadingAtomic(CBaseModelInfo? @pBaseModelInfo,RpAtomic? @pRpAtomic,int @dwAlpha) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4323 >(4323)(@pBaseModelInfo?.Pointer ?? IntPtr.Zero,@pRpAtomic?.Pointer ?? IntPtr.Zero,@dwAlpha); }
    public static void @RenderFadingClump(CBaseModelInfo? @pBaseModelInfo,RpClump? @pRpClump,int @dwAlpha) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4324 >(4324)(@pBaseModelInfo?.Pointer ?? IntPtr.Zero,@pRpClump?.Pointer ?? IntPtr.Zero,@dwAlpha); }
    public static void @RenderFadingClumpCB(RpAtomic? @pRpAtomic) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4325 >(4325)(@pRpAtomic?.Pointer ?? IntPtr.Zero); }
    public static void @RenderFadingEntities() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4326 >(4326)(); }
    public static void @RenderFadingUnderwaterEntities() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4327 >(4327)(); }
    public static void @RenderHeliRotorAlphaCB(RpAtomic? @pRpAtomic) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4328 >(4328)(@pRpAtomic?.Pointer ?? IntPtr.Zero); }
    public static void @RenderHeliTailRotorAlphaCB(RpAtomic? @pRpAtomic) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4329 >(4329)(@pRpAtomic?.Pointer ?? IntPtr.Zero); }
    public static void @RenderObjNormalAtomic(RpAtomic? @pRpAtomic) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4330 >(4330)(@pRpAtomic?.Pointer ?? IntPtr.Zero); }
    public static void @RenderOrderedList(CLinkList_CVisibilityPlugins__AlphaObjectInfo__3ad57f5111 @AlphaObjectInfoList) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4331 >(4331)(@AlphaObjectInfoList.Pointer); }
    public static void @RenderPedCB(RpAtomic? @pRpAtomic) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4332 >(4332)(@pRpAtomic?.Pointer ?? IntPtr.Zero); }
    public static void @RenderPlayerCB(RpAtomic? @pRpAtomic) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4333 >(4333)(@pRpAtomic?.Pointer ?? IntPtr.Zero); }
    public static void @RenderReallyDrawLastObjects() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4334 >(4334)(); }
    public static void @RenderTrainHiDetailAlphaCB(RpAtomic? @pRpAtomic) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4335 >(4335)(@pRpAtomic?.Pointer ?? IntPtr.Zero); }
    public static void @RenderTrainHiDetailCB(RpAtomic? @pRpAtomic) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4336 >(4336)(@pRpAtomic?.Pointer ?? IntPtr.Zero); }
    public static void @RenderVehicleHiDetailAlphaCB(RpAtomic? @pRpAtomic) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4337 >(4337)(@pRpAtomic?.Pointer ?? IntPtr.Zero); }
    public static void @RenderVehicleHiDetailAlphaCB_BigVehicle(RpAtomic? @pRpAtomic) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4338 >(4338)(@pRpAtomic?.Pointer ?? IntPtr.Zero); }
    public static void @RenderVehicleHiDetailAlphaCB_Boat(RpAtomic? @pRpAtomic) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4339 >(4339)(@pRpAtomic?.Pointer ?? IntPtr.Zero); }
    public static void @RenderVehicleHiDetailCB(RpAtomic? @pRpAtomic) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4340 >(4340)(@pRpAtomic?.Pointer ?? IntPtr.Zero); }
    public static void @RenderVehicleHiDetailCB_BigVehicle(RpAtomic? @pRpAtomic) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4341 >(4341)(@pRpAtomic?.Pointer ?? IntPtr.Zero); }
    public static void @RenderVehicleHiDetailCB_Boat(RpAtomic? @pRpAtomic) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4342 >(4342)(@pRpAtomic?.Pointer ?? IntPtr.Zero); }
    public static void @RenderVehicleLoDetailCB_Boat(RpAtomic? @pRpAtomic) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4343 >(4343)(@pRpAtomic?.Pointer ?? IntPtr.Zero); }
    public static void @RenderVehicleReallyLowDetailCB(RpAtomic? @pRpAtomic) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4344 >(4344)(@pRpAtomic?.Pointer ?? IntPtr.Zero); }
    public static void @RenderVehicleReallyLowDetailCB_BigVehicle(RpAtomic? @pRpAtomic) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4345 >(4345)(@pRpAtomic?.Pointer ?? IntPtr.Zero); }
    public static void @RenderWeaponCB(RpAtomic? @pRpAtomic) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4346 >(4346)(@pRpAtomic?.Pointer ?? IntPtr.Zero); }
    public static void @RenderWeaponPedsForPC() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4347 >(4347)(); }
    public static void @SetAtomicFlag(RpAtomic? @pRpAtomic,int @flag) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4348 >(4348)(@pRpAtomic?.Pointer ?? IntPtr.Zero,@flag); }
    public static void @SetAtomicFlag(RpAtomic? @pRpAtomic,ushort @flag) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4349 >(4349)(@pRpAtomic?.Pointer ?? IntPtr.Zero,@flag); }
    public static void @SetAtomicId(RpAtomic? @pRpAtomic,int @id) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4350 >(4350)(@pRpAtomic?.Pointer ?? IntPtr.Zero,@id); }
    public static void @SetAtomicRenderCallback(RpAtomic? @pRpAtomic,NativeFunctionPointer<Callback_573b9d07bfff> @renderCB) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4351 >(4351)(@pRpAtomic?.Pointer ?? IntPtr.Zero,@renderCB.Pointer); }
    public static void @SetClumpAlpha(RpClump? @pRpClump,int @dwAlpha) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4352 >(4352)(@pRpClump?.Pointer ?? IntPtr.Zero,@dwAlpha); }
    public static void @SetClumpModelInfo(RpClump? @pRpClump,CClumpModelInfo? @pClumpModelInfo) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4353 >(4353)(@pRpClump?.Pointer ?? IntPtr.Zero,@pClumpModelInfo?.Pointer ?? IntPtr.Zero); }
    public static void @SetFrameHierarchyId(RwFrame? @pRwFrame,int @id) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4354 >(4354)(@pRwFrame?.Pointer ?? IntPtr.Zero,@id); }
    public static void @SetRenderWareCamera(RwCamera? @pRwCamera) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4355 >(4355)(@pRwCamera?.Pointer ?? IntPtr.Zero); }
    public static void @SetUserValue(RpAtomic? @pRpAtomic,ushort @value) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4356 >(4356)(@pRpAtomic?.Pointer ?? IntPtr.Zero,@value); }
    public static void @SetupVehicleVariables(RpClump? @pRpClump) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4357 >(4357)(@pRpClump?.Pointer ?? IntPtr.Zero); }
    public static void @Shutdown() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4358 >(4358)(); }
    public static bool @VehicleVisibilityCB(RpClump? @pRpClump) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4359 >(4359)(@pRpClump?.Pointer ?? IntPtr.Zero); return __sdkResult != 0; }
    public static bool @VehicleVisibilityCB_BigVehicle(RpClump? @pRpClump) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4360 >(4360)(@pRpClump?.Pointer ?? IntPtr.Zero); return __sdkResult != 0; }
}
