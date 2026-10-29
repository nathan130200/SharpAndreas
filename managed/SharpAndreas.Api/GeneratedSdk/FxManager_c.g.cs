// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class FxManager_c : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=184;
    public FxManager_c(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_fxSystemBPList")]
    public TList_c_FxSystemBP_c__73b921ad30 @FxSystemBPList { get => new TList_c_FxSystemBP_c__73b921ad30(Pointer+0); set { SdkMemory.Copy(value.Pointer,Pointer+0,12); } }
    [NativeMember("m_fxSystemList")]
    public TList_c_FxSystem_c__bb02b332f4 @FxSystemList { get => new TList_c_FxSystem_c__bb02b332f4(Pointer+12); set { SdkMemory.Copy(value.Pointer,Pointer+12,12); } }
    [NativeMember("m_pFxEmitters")]
    public FxEmitterPrt_c? @FxEmitters { get => SdkMemory.Read<IntPtr>(Pointer+24) == IntPtr.Zero ? null : new FxEmitterPrt_c(SdkMemory.Read<IntPtr>(Pointer+24)); set { SdkMemory.Write(Pointer+24,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_fxEmitterPrtList")]
    public TList_c_FxEmitterPrt_c__f1d4821037 @FxEmitterPrtList { get => new TList_c_FxEmitterPrt_c__f1d4821037(Pointer+28); set { SdkMemory.Copy(value.Pointer,Pointer+28,12); } }
    [NativeMember("m_nFxTxdIndex")]
    public int @FxTxdIndex { get => SdkMemory.Read<int >(Pointer+40); set { SdkMemory.Write(Pointer+40,value); } }
    [NativeMember("m_pWindDir")]
    public RwV3d? @WindDirection { get => SdkMemory.Read<IntPtr>(Pointer+44) == IntPtr.Zero ? null : new RwV3d(SdkMemory.Read<IntPtr>(Pointer+44)); set { SdkMemory.Write(Pointer+44,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_pfWindSpeed")]
    public NativePointer<float> @PfWindSpeed { get => new NativePointer<float>(SdkMemory.Read<IntPtr>(Pointer+48)); set { SdkMemory.Write(Pointer+48,value.Pointer); } }
    [NativeMember("m_frustum")]
    public FxFrustumInfo_c @Frustum { get => new FxFrustumInfo_c(Pointer+52); set { SdkMemory.Copy(value.Pointer,Pointer+52,84); } }
    [NativeMember("m_nCurrentMatrix")]
    public uint @CurrentMatrix { get => SdkMemory.Read<uint >(Pointer+136); set { SdkMemory.Write(Pointer+136,value); } }
    [NativeMember("m_apMatrices")]
    public NativeArray<IntPtr> @Matrices { get => new NativeArray<IntPtr>(Pointer+140,8); }
    [NativeMember("m_pool")]
    public FxMemoryPool_c @Pool { get => new FxMemoryPool_c(Pointer+172); set { SdkMemory.Copy(value.Pointer,Pointer+172,12); } }
    public void @InitializeAt() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4537 >(4537)(Pointer); }
    public void @DestroyNative() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4538 >(4538)(Pointer); }
    public FxFrustumInfo_c? @GetFrustumInfo() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4539 >(4539)(Pointer); return __sdkResult == IntPtr.Zero ? null : new FxFrustumInfo_c(__sdkResult); }
    public void @CalcFrustumInfo(RwCamera? @camera) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4540 >(4540)(Pointer,@camera?.Pointer ?? IntPtr.Zero); }
    public void @Render(RwCamera? @camera,byte @arg1) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4541 >(4541)(Pointer,@camera?.Pointer ?? IntPtr.Zero,@arg1); }
    public FxSystemBP_c? @FindFxSystemBP(NativePointer<sbyte> @name) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4542 >(4542)(Pointer,@name.Pointer); return __sdkResult == IntPtr.Zero ? null : new FxSystemBP_c(__sdkResult); }
    public void @ReturnParticle(FxEmitterPrt_c? @emitter) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4543 >(4543)(Pointer,@emitter?.Pointer ?? IntPtr.Zero); }
    public FxEmitterPrt_c? @GetParticle(sbyte @arg0) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4544 >(4544)(Pointer,@arg0); return __sdkResult == IntPtr.Zero ? null : new FxEmitterPrt_c(__sdkResult); }
    public void @SetWindData(RwV3d? @dir,NativePointer<float> @speed) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4545 >(4545)(Pointer,@dir?.Pointer ?? IntPtr.Zero,@speed.Pointer); }
    public void @FreeUpParticle() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4546 >(4546)(Pointer); }
    public RwMatrixTag? @FxRwMatrixCreate() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4547 >(4547)(Pointer); return __sdkResult == IntPtr.Zero ? null : new RwMatrixTag(__sdkResult); }
    public void @FxRwMatrixDestroy(RwMatrixTag? @matrix) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4548 >(4548)(Pointer,@matrix?.Pointer ?? IntPtr.Zero); }
    public bool @ShouldCreate(FxSystemBP_c? @bpSystem,RwMatrixTag? @transform,RwMatrixTag? @objectMatrix,byte @ignoreBoundingChecks) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4549 >(4549)(Pointer,@bpSystem?.Pointer ?? IntPtr.Zero,@transform?.Pointer ?? IntPtr.Zero,@objectMatrix?.Pointer ?? IntPtr.Zero,@ignoreBoundingChecks); return __sdkResult != 0; }
    public FxSystem_c? @CreateFxSystem(FxSystemBP_c? @bpSystem,RwMatrixTag? @transform,RwMatrixTag? @objectMatrix,byte @ignoreBoundingChecks) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4550 >(4550)(Pointer,@bpSystem?.Pointer ?? IntPtr.Zero,@transform?.Pointer ?? IntPtr.Zero,@objectMatrix?.Pointer ?? IntPtr.Zero,@ignoreBoundingChecks); return __sdkResult == IntPtr.Zero ? null : new FxSystem_c(__sdkResult); }
    public FxSystem_c? @CreateFxSystem(FxSystemBP_c? @bpSystem,RwV3d? @position,RwMatrixTag? @objectMatrix,byte @ignoreBoundingChecks) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4551 >(4551)(Pointer,@bpSystem?.Pointer ?? IntPtr.Zero,@position?.Pointer ?? IntPtr.Zero,@objectMatrix?.Pointer ?? IntPtr.Zero,@ignoreBoundingChecks); return __sdkResult == IntPtr.Zero ? null : new FxSystem_c(__sdkResult); }
    public void @DestroyFxSystem(FxSystem_c? @system) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4552 >(4552)(Pointer,@system?.Pointer ?? IntPtr.Zero); }
    public void @DestroyAllFxSystems() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4553 >(4553)(Pointer); }
    public bool @Init() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4554 >(4554)(Pointer); return __sdkResult != 0; }
    public void @Exit() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4555 >(4555)(Pointer); }
    public void @Update(RwCamera? @arg0,float @timeDelta) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4556 >(4556)(Pointer,@arg0?.Pointer ?? IntPtr.Zero,@timeDelta); }
    public void @UnloadFxProject() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4557 >(4557)(Pointer); }
    public FxSystem_c? @CreateFxSystem(NativePointer<sbyte> @name,RwMatrixTag? @transform,RwMatrixTag? @objectMatrix,byte @ignoreBoundingChecks) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4558 >(4558)(Pointer,@name.Pointer,@transform?.Pointer ?? IntPtr.Zero,@objectMatrix?.Pointer ?? IntPtr.Zero,@ignoreBoundingChecks); return __sdkResult == IntPtr.Zero ? null : new FxSystem_c(__sdkResult); }
    public FxSystem_c? @CreateFxSystem(NativePointer<sbyte> @name,RwV3d? @position,RwMatrixTag? @objectMatrix,byte @ignoreBoundingChecks) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4559 >(4559)(Pointer,@name.Pointer,@position?.Pointer ?? IntPtr.Zero,@objectMatrix?.Pointer ?? IntPtr.Zero,@ignoreBoundingChecks); return __sdkResult == IntPtr.Zero ? null : new FxSystem_c(__sdkResult); }
    public FxSystemBP_c? @LoadFxSystemBP(NativePointer<sbyte> @filename,int @file) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4560 >(4560)(Pointer,@filename.Pointer,@file); return __sdkResult == IntPtr.Zero ? null : new FxSystemBP_c(__sdkResult); }
    public bool @LoadFxProject(NativePointer<sbyte> @filename) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4561 >(4561)(Pointer,@filename.Pointer); return __sdkResult != 0; }
}
