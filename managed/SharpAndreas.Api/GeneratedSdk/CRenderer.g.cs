// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CRenderer : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=1;
    public CRenderer(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("ms_bRenderTunnels")]
    public static bool @RenderTunnels { get => SdkMemory.Read<bool >(new IntPtr(0xB745C0)); set { SdkMemory.Write(new IntPtr(0xB745C0),value); } }
    [NativeMember("ms_bRenderOutsideTunnels")]
    public static bool @RenderOutsideTunnels { get => SdkMemory.Read<bool >(new IntPtr(0xB745C1)); set { SdkMemory.Write(new IntPtr(0xB745C1),value); } }
    [NativeMember("ms_pLodDontRenderList")]
    public static tRenderListEntry? @LodDontRenderList { get => SdkMemory.Read<IntPtr>(new IntPtr(0xB745CC)) == IntPtr.Zero ? null : new tRenderListEntry(SdkMemory.Read<IntPtr>(new IntPtr(0xB745CC))); set { SdkMemory.Write(new IntPtr(0xB745CC),value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("ms_pLodRenderList")]
    public static tRenderListEntry? @LodRenderList { get => SdkMemory.Read<IntPtr>(new IntPtr(0xB745D0)) == IntPtr.Zero ? null : new tRenderListEntry(SdkMemory.Read<IntPtr>(new IntPtr(0xB745D0))); set { SdkMemory.Write(new IntPtr(0xB745D0),value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_pFirstPersonVehicle")]
    public static CVehicle? @FirstPersonVehicle { get => SdkMemory.Read<IntPtr>(new IntPtr(0xB745D4)) == IntPtr.Zero ? null : new CVehicle(SdkMemory.Read<IntPtr>(new IntPtr(0xB745D4))); set { SdkMemory.Write(new IntPtr(0xB745D4),value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("ms_aInVisibleEntityPtrs")]
    public static NativePointer<IntPtr> @InVisibleEntityPtrs { get => new NativePointer<IntPtr>(new IntPtr(0xB745D8)); }
    [NativeMember("ms_aVisibleSuperLodPtrs")]
    public static NativePointer<IntPtr> @VisibleSuperLodPtrs { get => new NativePointer<IntPtr>(new IntPtr(0xB74830)); }
    [NativeMember("ms_aVisibleLodPtrs")]
    public static NativePointer<IntPtr> @VisibleLodPtrs { get => new NativePointer<IntPtr>(new IntPtr(0xB748F8)); }
    [NativeMember("ms_aVisibleEntityPtrs")]
    public static NativePointer<IntPtr> @VisibleEntityPtrs { get => new NativePointer<IntPtr>(new IntPtr(0xB75898)); }
    [NativeMember("ms_nNoOfVisibleSuperLods")]
    public static uint @NoOfVisibleSuperLods { get => SdkMemory.Read<uint >(new IntPtr(0xB76838)); set { SdkMemory.Write(new IntPtr(0xB76838),value); } }
    [NativeMember("ms_nNoOfInVisibleEntities")]
    public static uint @NoOfInVisibleEntities { get => SdkMemory.Read<uint >(new IntPtr(0xB7683C)); set { SdkMemory.Write(new IntPtr(0xB7683C),value); } }
    [NativeMember("ms_nNoOfVisibleLods")]
    public static uint @NoOfVisibleLods { get => SdkMemory.Read<uint >(new IntPtr(0xB76840)); set { SdkMemory.Write(new IntPtr(0xB76840),value); } }
    [NativeMember("ms_nNoOfVisibleEntities")]
    public static uint @NoOfVisibleEntities { get => SdkMemory.Read<uint >(new IntPtr(0xB76844)); set { SdkMemory.Write(new IntPtr(0xB76844),value); } }
    [NativeMember("ms_fFarClipPlane")]
    public static float @FarClipPlane { get => SdkMemory.Read<float >(new IntPtr(0xB76848)); set { SdkMemory.Write(new IntPtr(0xB76848),value); } }
    [NativeMember("ms_fCameraHeading")]
    public static float @CameraHeading { get => SdkMemory.Read<float >(new IntPtr(0xB7684C)); set { SdkMemory.Write(new IntPtr(0xB7684C),value); } }
    [NativeMember("m_loadingPriority")]
    public static byte @LoadingPriority { get => SdkMemory.Read<byte >(new IntPtr(0xB76850)); set { SdkMemory.Write(new IntPtr(0xB76850),value); } }
    [NativeMember("ms_bInTheSky")]
    public static bool @InTheSky { get => SdkMemory.Read<bool >(new IntPtr(0xB76851)); set { SdkMemory.Write(new IntPtr(0xB76851),value); } }
    [NativeMember("ms_vecCameraPosition")]
    public static CVector @CameraPosition { get => new CVector(new IntPtr(0xB76870)); set { SdkMemory.Copy(value.Pointer,new IntPtr(0xB76870),12); } }
    [NativeMember("ms_lodDistScale")]
    public static float @LodDistanceScale { get => SdkMemory.Read<float >(new IntPtr(0x8CD800)); set { SdkMemory.Write(new IntPtr(0x8CD800),value); } }
    [NativeMember("ms_lowLodDistScale")]
    public static float @LowLodDistanceScale { get => SdkMemory.Read<float >(new IntPtr(0x8CD804)); set { SdkMemory.Write(new IntPtr(0x8CD804),value); } }
    public static void @Init() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3558 >(3558)(); }
    public static void @Shutdown() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3559 >(3559)(); }
    public static void @RenderFadingInEntities() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3560 >(3560)(); }
    public static void @RenderFadingInUnderwaterEntities() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3561 >(3561)(); }
    public static void @RenderOneRoad(CEntity? @entity) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3562 >(3562)(@entity?.Pointer ?? IntPtr.Zero); }
    public static void @RenderOneNonRoad(CEntity? @entity) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3563 >(3563)(@entity?.Pointer ?? IntPtr.Zero); }
    public static void @RemoveVehiclePedLights(CPhysical? @entity) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3564 >(3564)(@entity?.Pointer ?? IntPtr.Zero); }
    public static void @AddEntityToRenderList(CEntity? @entity,float @distance) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3565 >(3565)(@entity?.Pointer ?? IntPtr.Zero,@distance); }
    public static void @ScanSectorList_ListModels(int @sector_x,int @sector_y) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3566 >(3566)(@sector_x,@sector_y); }
    public static void @ScanSectorList_ListModelsVisible(int @sector_x,int @sector_y) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3567 >(3567)(@sector_x,@sector_y); }
    public static tRenderListEntry? @GetLodRenderListBase() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3568 >(3568)(); return __sdkResult == IntPtr.Zero ? null : new tRenderListEntry(__sdkResult); }
    public static tRenderListEntry? @GetLodDontRenderListBase() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3569 >(3569)(); return __sdkResult == IntPtr.Zero ? null : new tRenderListEntry(__sdkResult); }
    public static void @ResetLodRenderLists() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3570 >(3570)(); }
    public static void @AddToLodRenderList(CEntity? @entity,float @distance) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3571 >(3571)(@entity?.Pointer ?? IntPtr.Zero,@distance); }
    public static void @AddToLodDontRenderList(CEntity? @entity,float @distance) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3572 >(3572)(@entity?.Pointer ?? IntPtr.Zero,@distance); }
    public static void @ProcessLodRenderLists() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3573 >(3573)(); }
    public static void @PreRender() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3574 >(3574)(); }
    public static void @RenderRoads() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3575 >(3575)(); }
    public static void @RenderEverythingBarRoads() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3576 >(3576)(); }
    public static void @RenderFirstPersonVehicle() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3577 >(3577)(); }
    public static bool @SetupLightingForEntity(CEntity? @entity) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3578 >(3578)(@entity?.Pointer ?? IntPtr.Zero); return __sdkResult != 0; }
    public static int @SetupMapEntityVisibility(CEntity? @entity,CBaseModelInfo? @modelInfo,float @distance,bool @arg3) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3579 >(3579)(@entity?.Pointer ?? IntPtr.Zero,@modelInfo?.Pointer ?? IntPtr.Zero,@distance,(@arg3 ? 1 : 0)); return __sdkResult; }
    public static int @SetupEntityVisibility(CEntity? @entity,NativePointer<float> @outDistance) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3580 >(3580)(@entity?.Pointer ?? IntPtr.Zero,@outDistance.Pointer); return __sdkResult; }
    public static int @SetupBigBuildingVisibility(CEntity? @entity,NativePointer<float> @outDistance) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3581 >(3581)(@entity?.Pointer ?? IntPtr.Zero,@outDistance.Pointer); return __sdkResult; }
    public static void @ScanSectorList(int @sector_x,int @sector_y) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3582 >(3582)(@sector_x,@sector_y); }
    public static void @ScanBigBuildingList(int @sector_x,int @sector_y) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3583 >(3583)(@sector_x,@sector_y); }
    public static int @GetObjectsInFrustum(NativePointer<IntPtr> @outEntities,float @distance,RwMatrixTag? @transformMat) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3584 >(3584)(@outEntities.Pointer,@distance,@transformMat?.Pointer ?? IntPtr.Zero); return __sdkResult; }
    public static bool @ShouldModelBeStreamed(CEntity? @entity,CVector @origin,float @farClip) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3585 >(3585)(@entity?.Pointer ?? IntPtr.Zero,@origin.Pointer,@farClip); return __sdkResult != 0; }
    public static void @ScanWorld() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3586 >(3586)(); }
    public static void @ScanPtrList_RequestModels(CPtrList @ptrList) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3587 >(3587)(@ptrList.Pointer); }
    public static void @ConstructRenderList() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3588 >(3588)(); }
    public static void @ScanSectorList_RequestModels(int @sector_x,int @sector_y) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3589 >(3589)(@sector_x,@sector_y); }
    public static void @RequestObjectsInFrustum(RwMatrixTag? @transformMat,int @modelRequesFlags) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3590 >(3590)(@transformMat?.Pointer ?? IntPtr.Zero,@modelRequesFlags); }
    public static void @RequestObjectsInDirection(CVector @posn,float @angle,int @modelRequesFlags) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3591 >(3591)(@posn.Pointer,@angle,@modelRequesFlags); }
    public static void @SetupScanLists(int @sector_x,int @sector_y) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3592 >(3592)(@sector_x,@sector_y); }
}
