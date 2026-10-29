// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CCutsceneMgr : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=1;
    public CCutsceneMgr(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("ms_useCutsceneShadows")]
    public static bool @UseCutsceneShadows { get => SdkMemory.Read<bool >(new IntPtr(0x8AC158)); set { SdkMemory.Write(new IntPtr(0x8AC158),value); } }
    [NativeMember("numPlayerWeaponsToRestore")]
    public static uint @CountPlayerWeaponsToRestore { get => SdkMemory.Read<uint >(new IntPtr(0xB5EB58)); set { SdkMemory.Write(new IntPtr(0xB5EB58),value); } }
    [NativeMember("playerWeaponsToRestore_Ammo")]
    public static NativePointer<uint> @PlayerWeaponsToRestoreAmmo { get => new NativePointer<uint>(new IntPtr(0xB5EB5C)); }
    [NativeMember("playerWeaponsToRestore_Type")]
    public static NativePointer<uint> @PlayerWeaponsToRestoreType { get => new NativePointer<uint>(new IntPtr(0xB5EB90)); }
    [NativeMember("ms_cAppendAnimName")]
    public static NativeArray<sbyte> @AppendAnimationName { get => new NativeArray<sbyte>(new IntPtr(0xB5EBC8),32); }
    [NativeMember("ms_cAppendObjectName")]
    public static NativeArray<sbyte> @AppendObjectName { get => new NativeArray<sbyte>(new IntPtr(0xB5F208),32); }
    [NativeMember("ms_pCutsceneDir")]
    public static CDirectory? @CutsceneDirection { get => new IntPtr(0xB5F848) == IntPtr.Zero ? null : new CDirectory(new IntPtr(0xB5F848)); }
    [NativeMember("ms_cutsceneLoadStatus")]
    public static uint @CutsceneLoadStatus { get => SdkMemory.Read<uint >(new IntPtr(0xB5F84C)); set { SdkMemory.Write(new IntPtr(0xB5F84C),value); } }
    [NativeMember("ms_animLoaded")]
    public static bool @AnimationLoaded { get => SdkMemory.Read<bool >(new IntPtr(0xB5F850)); set { SdkMemory.Write(new IntPtr(0xB5F850),value); } }
    [NativeMember("ms_running")]
    public static bool @Running { get => SdkMemory.Read<bool >(new IntPtr(0xB5F851)); set { SdkMemory.Write(new IntPtr(0xB5F851),value); } }
    [NativeMember("ms_cutsceneProcessing")]
    public static bool @CutsceneProcessing { get => SdkMemory.Read<bool >(new IntPtr(0xB5F852)); set { SdkMemory.Write(new IntPtr(0xB5F852),value); } }
    [NativeMember("ms_useLodMultiplier")]
    public static bool @UseLodMultiplier { get => SdkMemory.Read<bool >(new IntPtr(0xB5F853)); set { SdkMemory.Write(new IntPtr(0xB5F853),value); } }
    [NativeMember("ms_wasCutsceneSkipped")]
    public static bool @WasCutsceneSkipped { get => SdkMemory.Read<bool >(new IntPtr(0xB5F854)); set { SdkMemory.Write(new IntPtr(0xB5F854),value); } }
    [NativeMember("ms_hasFileInfo")]
    public static bool @HasFileInfo { get => SdkMemory.Read<bool >(new IntPtr(0xB5F855)); set { SdkMemory.Write(new IntPtr(0xB5F855),value); } }
    [NativeMember("ms_numAppendObjectNames")]
    public static uint @CountAppendObjectNames { get => SdkMemory.Read<uint >(new IntPtr(0xB5F858)); set { SdkMemory.Write(new IntPtr(0xB5F858),value); } }
    [NativeMember("restoreEverythingAfterCutscene")]
    public static bool @RestoreEverythingAfterCutscene { get => SdkMemory.Read<bool >(new IntPtr(0xB5F85C)); set { SdkMemory.Write(new IntPtr(0xB5F85C),value); } }
    [NativeMember("m_fPrevCarDensity")]
    public static float @PrevCarDensity { get => SdkMemory.Read<float >(new IntPtr(0xBC1D68)); set { SdkMemory.Write(new IntPtr(0xBC1D68),value); } }
    [NativeMember("m_fPrevPedDensity")]
    public static float @PrevPedDensity { get => SdkMemory.Read<float >(new IntPtr(0xBC1D6C)); set { SdkMemory.Write(new IntPtr(0xBC1D6C),value); } }
    [NativeMember("ms_pParticleEffects")]
    public static tCutsceneParticleEffect? @ParticleEffects { get => new IntPtr(0xBC1D70) == IntPtr.Zero ? null : new tCutsceneParticleEffect(new IntPtr(0xBC1D70)); }
    [NativeMember("ms_crToHideItems")]
    public static tCutsceneRemoval? @CrToHideItems { get => new IntPtr(0xBC20D0) == IntPtr.Zero ? null : new tCutsceneRemoval(new IntPtr(0xBC20D0)); }
    [NativeMember("ms_pHiddenEntities")]
    public static NativePointer<IntPtr> @HiddenEntities { get => new NativePointer<IntPtr>(new IntPtr(0xBC2968)); }
    [NativeMember("ms_numAttachObjectToBones")]
    public static uint @CountAttachObjectToBones { get => SdkMemory.Read<uint >(new IntPtr(0xBC2A30)); set { SdkMemory.Write(new IntPtr(0xBC2A30),value); } }
    [NativeMember("ms_bRepeatObject")]
    public static NativePointer<bool> @RepeatObject { get => new NativePointer<bool>(new IntPtr(0xBC2A34)); }
    [NativeMember("ms_iAttachObjectToBone")]
    public static tCutsceneAttachment? @IAttachObjectToBone { get => new IntPtr(0xBC2A68) == IntPtr.Zero ? null : new tCutsceneAttachment(new IntPtr(0xBC2A68)); }
    [NativeMember("ms_aUncompressedCutsceneAnims")]
    public static NativeArray<sbyte> @UncompressedCutsceneAnims { get => new NativeArray<sbyte>(new IntPtr(0xBC2CC0),32); }
    [NativeMember("ms_iTextDuration")]
    public static NativePointer<int> @ITextDuration { get => new NativePointer<int>(new IntPtr(0xBC2DC0)); }
    [NativeMember("ms_iTextStartTime")]
    public static NativePointer<int> @ITextStartTime { get => new NativePointer<int>(new IntPtr(0xBC2EC0)); }
    [NativeMember("ms_cTextOutput")]
    public static NativeArray<sbyte> @TextOutput { get => new NativeArray<sbyte>(new IntPtr(0xBC2FC0),8); }
    [NativeMember("ms_iModelIndex")]
    public static NativePointer<int> @IModelIndex { get => new NativePointer<int>(new IntPtr(0xBC31C0)); }
    [NativeMember("ms_cLoadAnimName")]
    public static NativeArray<sbyte> @LoadAnimationName { get => new NativeArray<sbyte>(new IntPtr(0xBC3288),32); }
    [NativeMember("ms_cLoadObjectName")]
    public static NativeArray<sbyte> @LoadObjectName { get => new NativeArray<sbyte>(new IntPtr(0xBC38C8),32); }
    [NativeMember("ms_cutsceneTimer")]
    public static float @CutsceneTimer { get => SdkMemory.Read<float >(new IntPtr(0xBC3F08)); set { SdkMemory.Write(new IntPtr(0xBC3F08),value); } }
    [NativeMember("ms_cutsceneName")]
    public static NativePointer<sbyte> @CutsceneName { get => new NativePointer<sbyte>(new IntPtr(0xBC3F0C)); }
    [NativeMember("ms_pCutsceneObjects")]
    public static NativePointer<IntPtr> @CutsceneObjects { get => new NativePointer<IntPtr>(new IntPtr(0xBC3F18)); }
    [NativeMember("ms_cutscenePlayStatus")]
    public static uint @CutscenePlayStatus { get => SdkMemory.Read<uint >(new IntPtr(0xBC3FE0)); set { SdkMemory.Write(new IntPtr(0xBC3FE0),value); } }
    [NativeMember("ms_numCutsceneObjs")]
    public static uint @CountCutsceneObjects { get => SdkMemory.Read<uint >(new IntPtr(0xBC3FE4)); set { SdkMemory.Write(new IntPtr(0xBC3FE4),value); } }
    [NativeMember("ms_numLoadObjectNames")]
    public static uint @CountLoadObjectNames { get => SdkMemory.Read<uint >(new IntPtr(0xBC3FE8)); set { SdkMemory.Write(new IntPtr(0xBC3FE8),value); } }
    [NativeMember("ms_numTextOutput")]
    public static uint @CountTextOutput { get => SdkMemory.Read<uint >(new IntPtr(0xBC3FEC)); set { SdkMemory.Write(new IntPtr(0xBC3FEC),value); } }
    [NativeMember("ms_currTextOutput")]
    public static uint @CurrTextOutput { get => SdkMemory.Read<uint >(new IntPtr(0xBC3FF0)); set { SdkMemory.Write(new IntPtr(0xBC3FF0),value); } }
    [NativeMember("ms_numUncompressedCutsceneAnims")]
    public static uint @CountUncompressedCutsceneAnims { get => SdkMemory.Read<uint >(new IntPtr(0xBC3FF4)); set { SdkMemory.Write(new IntPtr(0xBC3FF4),value); } }
    [NativeMember("ms_iNumHiddenEntities")]
    public static uint @ICountHiddenEntities { get => SdkMemory.Read<uint >(new IntPtr(0xBC3FF8)); set { SdkMemory.Write(new IntPtr(0xBC3FF8),value); } }
    [NativeMember("ms_iNumParticleEffects")]
    public static uint @ICountParticleEffects { get => SdkMemory.Read<uint >(new IntPtr(0xBC3FFC)); set { SdkMemory.Write(new IntPtr(0xBC3FFC),value); } }
    [NativeMember("m_PrevExtraColour")]
    public static uint @PrevExtraColor { get => SdkMemory.Read<uint >(new IntPtr(0xBC4000)); set { SdkMemory.Write(new IntPtr(0xBC4000),value); } }
    [NativeMember("m_PrevExtraColourOn")]
    public static bool @PrevExtraColorOn { get => SdkMemory.Read<bool >(new IntPtr(0xBC4004)); set { SdkMemory.Write(new IntPtr(0xBC4004),value); } }
    [NativeMember("dataFileLoaded")]
    public static bool @DataFileLoaded { get => SdkMemory.Read<bool >(new IntPtr(0xBC4006)); set { SdkMemory.Write(new IntPtr(0xBC4006),value); } }
    [NativeMember("ms_cutsceneAssociations")]
    public static CAnimBlendAssocGroup @CutsceneAssociations { get => new CAnimBlendAssocGroup(new IntPtr(0xBC4020)); set { SdkMemory.Copy(value.Pointer,new IntPtr(0xBC4020),20); } }
    [NativeMember("ms_cutsceneOffset")]
    public static CVector @CutsceneOffset { get => new CVector(new IntPtr(0xBC4034)); set { SdkMemory.Copy(value.Pointer,new IntPtr(0xBC4034),12); } }
    public static int @AddCutsceneHead(CObject? @object,int @arg1) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2429 >(2429)(@object?.Pointer ?? IntPtr.Zero,@arg1); return __sdkResult; }
    public static void @AppendToNextCutscene(NativePointer<sbyte> @objectName,NativePointer<sbyte> @animName) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2430 >(2430)(@objectName.Pointer,@animName.Pointer); }
    public static void @AttachObjectToBone(CObject? @attachment,CObject? @object,int @boneId) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2431 >(2431)(@attachment?.Pointer ?? IntPtr.Zero,@object?.Pointer ?? IntPtr.Zero,@boneId); }
    public static void @AttachObjectToFrame(CObject? @attachment,CEntity? @object,NativePointer<sbyte> @frameName) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2432 >(2432)(@attachment?.Pointer ?? IntPtr.Zero,@object?.Pointer ?? IntPtr.Zero,@frameName.Pointer); }
    public static void @AttachObjectToParent(CObject? @attachment,CEntity? @object) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2433 >(2433)(@attachment?.Pointer ?? IntPtr.Zero,@object?.Pointer ?? IntPtr.Zero); }
    public static void @BuildCutscenePlayer() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2434 >(2434)(); }
    public static CCutsceneObject? @CreateCutsceneObject(int @modelId) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2435 >(2435)(@modelId); return __sdkResult == IntPtr.Zero ? null : new CCutsceneObject(__sdkResult); }
    public static void @DeleteCutsceneData() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2436 >(2436)(); }
    public static void @DeleteCutsceneData_overlay() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2437 >(2437)(); }
    public static void @FinishCutscene() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2438 >(2438)(); }
    public static long @GetCutsceneTimeInMilleseconds() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2439 >(2439)(); return __sdkResult; }
    public static bool @HasCutsceneFinished() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2440 >(2440)(); return __sdkResult != 0; }
    public static void @HideRequestedObjects() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2441 >(2441)(); }
    public static void @Initialise() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2442 >(2442)(); }
    public static void @IsCutsceneSkipButtonBeingPressed() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2443 >(2443)(); }
    public static void @LoadAnimationUncompressed(NativePointer<sbyte> @animName) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2444 >(2444)(@animName.Pointer); }
    public static void @LoadCutsceneData(NativePointer<sbyte> @cutsceneName) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2445 >(2445)(@cutsceneName.Pointer); }
    public static void @LoadCutsceneData_loading() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2446 >(2446)(); }
    public static void @LoadCutsceneData_overlay(NativePointer<sbyte> @cutsceneName) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2447 >(2447)(@cutsceneName.Pointer); }
    public static void @LoadCutsceneData_postload() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2448 >(2448)(); }
    public static void @LoadCutsceneData_preload() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2449 >(2449)(); }
    public static void @LoadEverythingBecauseCutsceneDeletedAllOfIt() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2450 >(2450)(); }
    public static void @RemoveCutscenePlayer() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2451 >(2451)(); }
    public static void @RemoveEverythingBecauseCutsceneDoesntFitInMemory() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2452 >(2452)(); }
    public static void @SetCutsceneAnim(NativePointer<sbyte> @animName,CObject? @object) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2453 >(2453)(@animName.Pointer,@object?.Pointer ?? IntPtr.Zero); }
    public static void @SetCutsceneAnimToLoop(NativePointer<sbyte> @animName) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2454 >(2454)(@animName.Pointer); }
    public static void @SetHeadAnim(NativePointer<sbyte> @animName,CObject? @headObject) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2455 >(2455)(@animName.Pointer,@headObject?.Pointer ?? IntPtr.Zero); }
    public static void @SetupCutsceneToStart() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2456 >(2456)(); }
    public static void @Shutdown() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2457 >(2457)(); }
    public static void @SkipCutscene() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2458 >(2458)(); }
    public static void @StartCutscene() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2459 >(2459)(); }
    public static void @Update() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2460 >(2460)(); }
    public static void @Update_overlay() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2461 >(2461)(); }
}
