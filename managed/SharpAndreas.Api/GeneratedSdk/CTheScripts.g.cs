// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CTheScripts : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=1;
    public CTheScripts(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("DbgFlag")]
    public static bool @DbgFlag { get => SdkMemory.Read<bool >(new IntPtr(0x859CF8)); set { SdkMemory.Write(new IntPtr(0x859CF8),value); } }
    [NativeMember("SwitchJumpTable")]
    public static tScriptSwitchCase? @SwitchJumpTable { get => new IntPtr(0xA43CF8) == IntPtr.Zero ? null : new tScriptSwitchCase(new IntPtr(0xA43CF8)); }
    [NativeMember("NumberOfEntriesInSwitchTable")]
    public static ushort @NumberOfEntriesInSwitchTable { get => SdkMemory.Read<ushort >(new IntPtr(0xA43F50)); set { SdkMemory.Write(new IntPtr(0xA43F50),value); } }
    [NativeMember("SwitchDefaultAddress")]
    public static NativePointer<IntPtr> @SwitchDefaultAddress { get => new NativePointer<IntPtr>(SdkMemory.Read<IntPtr>(new IntPtr(0xA43F54))); set { SdkMemory.Write(new IntPtr(0xA43F54),value.Pointer); } }
    [NativeMember("SwitchDefaultExists")]
    public static bool @SwitchDefaultExists { get => SdkMemory.Read<bool >(new IntPtr(0xA43F58)); set { SdkMemory.Write(new IntPtr(0xA43F58),value); } }
    [NativeMember("ValueToCheckInSwitchStatement")]
    public static int @ValueToCheckInSwitchStatement { get => SdkMemory.Read<int >(new IntPtr(0xA43F5C)); set { SdkMemory.Write(new IntPtr(0xA43F5C),value); } }
    [NativeMember("NumberOfEntriesStillToReadForSwitch")]
    public static ushort @NumberOfEntriesStillToReadForSwitch { get => SdkMemory.Read<ushort >(new IntPtr(0xA43F60)); set { SdkMemory.Write(new IntPtr(0xA43F60),value); } }
    [NativeMember("ScriptSequenceTaskArray")]
    public static tScriptSequence? @ScriptSequenceTaskArray { get => new IntPtr(0xA43F68) == IntPtr.Zero ? null : new tScriptSequence(new IntPtr(0xA43F68)); }
    [NativeMember("NumberOfScriptCheckpoints")]
    public static ushort @NumberOfScriptCheckpoints { get => SdkMemory.Read<ushort >(new IntPtr(0xA44068)); set { SdkMemory.Write(new IntPtr(0xA44068),value); } }
    [NativeMember("ScriptCheckpointArray")]
    public static tScriptCheckpoint? @ScriptCheckpointArray { get => new IntPtr(0xA44070) == IntPtr.Zero ? null : new tScriptCheckpoint(new IntPtr(0xA44070)); }
    [NativeMember("ScriptEffectSystemArray")]
    public static tScriptEffectSystem? @ScriptEffectSystemArray { get => new IntPtr(0xA44110) == IntPtr.Zero ? null : new tScriptEffectSystem(new IntPtr(0xA44110)); }
    [NativeMember("CardStackPosition")]
    public static short @CardStackPosition { get => SdkMemory.Read<short >(new IntPtr(0xA44210)); set { SdkMemory.Write(new IntPtr(0xA44210),value); } }
    [NativeMember("CardStack")]
    public static NativePointer<short> @CardStack { get => new NativePointer<short>(new IntPtr(0xA44218)); }
    [NativeMember("bDrawSubtitlesBeforeFade")]
    public static bool @DrawSubtitlesBeforeFade { get => SdkMemory.Read<bool >(new IntPtr(0xA44488)); set { SdkMemory.Write(new IntPtr(0xA44488),value); } }
    [NativeMember("bDrawOddJobTitleBeforeFade")]
    public static bool @DrawOddJobTitleBeforeFade { get => SdkMemory.Read<bool >(new IntPtr(0xA44489)); set { SdkMemory.Write(new IntPtr(0xA44489),value); } }
    [NativeMember("bScriptHasFadedOut")]
    public static bool @ScriptHasFadedOut { get => SdkMemory.Read<bool >(new IntPtr(0xA4448A)); set { SdkMemory.Write(new IntPtr(0xA4448A),value); } }
    [NativeMember("bAddNextMessageToPreviousBriefs")]
    public static bool @AddNextMessageToPreviousBriefs { get => SdkMemory.Read<bool >(new IntPtr(0xA4448B)); set { SdkMemory.Write(new IntPtr(0xA4448B),value); } }
    [NativeMember("ForceRandomCarModel")]
    public static int @ForceRandomCarModel { get => SdkMemory.Read<int >(new IntPtr(0xA4448C)); set { SdkMemory.Write(new IntPtr(0xA4448C),value); } }
    [NativeMember("bDrawCrossHair")]
    public static bool @DrawCrossHair { get => SdkMemory.Read<bool >(new IntPtr(0xA44490)); set { SdkMemory.Write(new IntPtr(0xA44490),value); } }
    [NativeMember("bEnableCraneRelease")]
    public static bool @EnableCraneRelease { get => SdkMemory.Read<bool >(new IntPtr(0xA44494)); set { SdkMemory.Write(new IntPtr(0xA44494),value); } }
    [NativeMember("bEnableCraneLower")]
    public static bool @EnableCraneLower { get => SdkMemory.Read<bool >(new IntPtr(0xA44495)); set { SdkMemory.Write(new IntPtr(0xA44495),value); } }
    [NativeMember("bEnableCraneRaise")]
    public static bool @EnableCraneRaise { get => SdkMemory.Read<bool >(new IntPtr(0xA44496)); set { SdkMemory.Write(new IntPtr(0xA44496),value); } }
    [NativeMember("fCameraHeadingStepWhenPlayerIsAttached")]
    public static float @CameraHeadingStepWhenPlayerIsAttached { get => SdkMemory.Read<float >(new IntPtr(0xA44498)); set { SdkMemory.Write(new IntPtr(0xA44498),value); } }
    [NativeMember("fCameraHeadingWhenPlayerIsAttached")]
    public static float @CameraHeadingWhenPlayerIsAttached { get => SdkMemory.Read<float >(new IntPtr(0xA4449C)); set { SdkMemory.Write(new IntPtr(0xA4449C),value); } }
    [NativeMember("bDisplayHud")]
    public static bool @DisplayHud { get => SdkMemory.Read<bool >(new IntPtr(0xA444A0)); set { SdkMemory.Write(new IntPtr(0xA444A0),value); } }
    [NativeMember("HideAllFrontEndMapBlips")]
    public static bool @HideAllFrontEndMapBlips { get => SdkMemory.Read<bool >(new IntPtr(0xA444A1)); set { SdkMemory.Write(new IntPtr(0xA444A1),value); } }
    [NativeMember("RadarShowBlipOnAllLevels")]
    public static bool @RadarShowBlipOnAllLevels { get => SdkMemory.Read<bool >(new IntPtr(0xA444A2)); set { SdkMemory.Write(new IntPtr(0xA444A2),value); } }
    [NativeMember("RadarZoomValue")]
    public static byte @RadarZoomValue { get => SdkMemory.Read<byte >(new IntPtr(0xA444A3)); set { SdkMemory.Write(new IntPtr(0xA444A3),value); } }
    [NativeMember("bPlayerIsOffTheMap")]
    public static bool @PlayerIsOffTheMap { get => SdkMemory.Read<bool >(new IntPtr(0xA444A4)); set { SdkMemory.Write(new IntPtr(0xA444A4),value); } }
    [NativeMember("RiotIntensity")]
    public static sbyte @RiotIntensity { get => SdkMemory.Read<sbyte >(new IntPtr(0xA444A5)); set { SdkMemory.Write(new IntPtr(0xA444A5),value); } }
    [NativeMember("bPlayerHasMetDebbieHarry")]
    public static bool @PlayerHasMetDebbieHarry { get => SdkMemory.Read<bool >(new IntPtr(0xA444A6)); set { SdkMemory.Write(new IntPtr(0xA444A6),value); } }
    [NativeMember("bDisplayNonMiniGameHelpMessages")]
    public static bool @DisplayNonMiniGameHelpMessages { get => SdkMemory.Read<bool >(new IntPtr(0xA444A7)); set { SdkMemory.Write(new IntPtr(0xA444A7),value); } }
    [NativeMember("bMiniGameInProgress")]
    public static bool @MiniGameInProgress { get => SdkMemory.Read<bool >(new IntPtr(0xA444A8)); set { SdkMemory.Write(new IntPtr(0xA444A8),value); } }
    [NativeMember("ScriptPickupCycleIndex")]
    public static int @ScriptPickupCycleIndex { get => SdkMemory.Read<int >(new IntPtr(0xA444AC)); set { SdkMemory.Write(new IntPtr(0xA444AC),value); } }
    [NativeMember("FailCurrentMission")]
    public static sbyte @FailCurrentMission { get => SdkMemory.Read<sbyte >(new IntPtr(0xA444B0)); set { SdkMemory.Write(new IntPtr(0xA444B0),value); } }
    [NativeMember("bAlreadyRunningAMissionScript")]
    public static bool @AlreadyRunningAMissionScript { get => SdkMemory.Read<bool >(new IntPtr(0xA444B1)); set { SdkMemory.Write(new IntPtr(0xA444B1),value); } }
    [NativeMember("LargestNumberOfMissionScriptLocalVariables")]
    public static uint @LargestNumberOfMissionScriptLocalVariables { get => SdkMemory.Read<uint >(new IntPtr(0xA444B4)); set { SdkMemory.Write(new IntPtr(0xA444B4),value); } }
    [NativeMember("NumberOfExclusiveMissionScripts")]
    public static ushort @NumberOfExclusiveMissionScripts { get => SdkMemory.Read<ushort >(new IntPtr(0xA444B8)); set { SdkMemory.Write(new IntPtr(0xA444B8),value); } }
    [NativeMember("NumberOfMissionScripts")]
    public static ushort @NumberOfMissionScripts { get => SdkMemory.Read<ushort >(new IntPtr(0xA444BC)); set { SdkMemory.Write(new IntPtr(0xA444BC),value); } }
    [NativeMember("LargestMissionScriptSize")]
    public static uint @LargestMissionScriptSize { get => SdkMemory.Read<uint >(new IntPtr(0xA444C0)); set { SdkMemory.Write(new IntPtr(0xA444C0),value); } }
    [NativeMember("MainScriptSize")]
    public static uint @MainScriptSize { get => SdkMemory.Read<uint >(new IntPtr(0xA444C4)); set { SdkMemory.Write(new IntPtr(0xA444C4),value); } }
    [NativeMember("MultiScriptArray")]
    public static NativeArray<int> @MultiScriptArray { get => new NativeArray<int>(new IntPtr(0xA444C8),200); }
    [NativeMember("bUsingAMultiScriptFile")]
    public static bool @UsingAMultiScriptFile { get => SdkMemory.Read<bool >(new IntPtr(0xA447E8)); set { SdkMemory.Write(new IntPtr(0xA447E8),value); } }
    [NativeMember("StoreVehicleIndex")]
    public static int @StoreVehicleIndex { get => SdkMemory.Read<int >(new IntPtr(0xA447EC)); set { SdkMemory.Write(new IntPtr(0xA447EC),value); } }
    [NativeMember("StoreVehicleWasRandom")]
    public static bool @StoreVehicleWasRandom { get => SdkMemory.Read<bool >(new IntPtr(0xA447F0)); set { SdkMemory.Write(new IntPtr(0xA447F0),value); } }
    [NativeMember("CommandsExecuted")]
    public static ushort @CommandsExecuted { get => SdkMemory.Read<ushort >(new IntPtr(0xA447F4)); set { SdkMemory.Write(new IntPtr(0xA447F4),value); } }
    [NativeMember("ScriptsUpdated")]
    public static ushort @ScriptsUpdated { get => SdkMemory.Read<ushort >(new IntPtr(0xA447F8)); set { SdkMemory.Write(new IntPtr(0xA447F8),value); } }
    [NativeMember("ScriptConnectLodsObjects")]
    public static NativePointer<int> @ScriptConnectLodsObjects { get => new NativePointer<int>(new IntPtr(0xA44800)); }
    [NativeMember("ScriptAttachedAnimGroups")]
    public static tScriptAttachedAnimGroup? @ScriptAttachedAnimationGroups { get => new IntPtr(0xA44850) == IntPtr.Zero ? null : new tScriptAttachedAnimGroup(new IntPtr(0xA44850)); }
    [NativeMember("VehicleModelsBlockedByScript")]
    public static NativePointer<int> @VehicleModelsBlockedByScript { get => new NativePointer<int>(new IntPtr(0xA448F0)); }
    [NativeMember("SuppressedVehicleModels")]
    public static NativePointer<int> @SuppressedVehicleModels { get => new NativePointer<int>(new IntPtr(0xA44940)); }
    [NativeMember("InvisibilitySettingArray")]
    public static NativePointer<IntPtr> @InvisibilitySettingArray { get => new NativePointer<IntPtr>(new IntPtr(0xA449E0)); }
    [NativeMember("BuildingSwapArray")]
    public static tBuildingSwap? @BuildingSwapArray { get => new IntPtr(0xA44A30) == IntPtr.Zero ? null : new tBuildingSwap(new IntPtr(0xA44A30)); }
    [NativeMember("MessageWidth")]
    public static ushort @MessageWidth { get => SdkMemory.Read<ushort >(new IntPtr(0xA44B60)); set { SdkMemory.Write(new IntPtr(0xA44B60),value); } }
    [NativeMember("MessageCentre")]
    public static ushort @MessageCentre { get => SdkMemory.Read<ushort >(new IntPtr(0xA44B64)); set { SdkMemory.Write(new IntPtr(0xA44B64),value); } }
    [NativeMember("bUseMessageFormatting")]
    public static bool @UseMessageFormatting { get => SdkMemory.Read<bool >(new IntPtr(0xA44B66)); set { SdkMemory.Write(new IntPtr(0xA44B66),value); } }
    [NativeMember("NumberOfUsedObjects")]
    public static ushort @NumberOfUsedObjects { get => SdkMemory.Read<ushort >(new IntPtr(0xA44B6C)); set { SdkMemory.Write(new IntPtr(0xA44B6C),value); } }
    [NativeMember("UsedObjectArray")]
    public static tUsedObject? @UsedObjectArray { get => new IntPtr(0xA44B70) == IntPtr.Zero ? null : new tUsedObject(new IntPtr(0xA44B70)); }
    [NativeMember("LastRandomPedId")]
    public static int @LastRandomPedId { get => SdkMemory.Read<int >(new IntPtr(0xA476A4)); set { SdkMemory.Write(new IntPtr(0xA476A4),value); } }
    [NativeMember("LastMissionPassedTime")]
    public static uint @LastMissionPassedTime { get => SdkMemory.Read<uint >(new IntPtr(0xA476A8)); set { SdkMemory.Write(new IntPtr(0xA476A8),value); } }
    [NativeMember("OnAMissionFlag")]
    public static int @OnAMissionFlag { get => SdkMemory.Read<int >(new IntPtr(0xA476AC)); set { SdkMemory.Write(new IntPtr(0xA476AC),value); } }
    [NativeMember("EntitiesWaitingForScriptBrain")]
    public static CEntity? @EntitiesWaitingForScriptBrain { get => SdkMemory.Read<IntPtr>(new IntPtr(0xA476B0)) == IntPtr.Zero ? null : new CEntity(SdkMemory.Read<IntPtr>(new IntPtr(0xA476B0))); set { SdkMemory.Write(new IntPtr(0xA476B0),value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("StreamedScripts")]
    public static CStreamedScripts @StreamedScripts { get => new CStreamedScripts(new IntPtr(0xA47B60)); set { SdkMemory.Copy(value.Pointer,new IntPtr(0xA47B60),2632); } }
    [NativeMember("ScriptResourceManager")]
    public static CScriptResourceManager @ScriptResourceManager { get => new CScriptResourceManager(new IntPtr(0xA485A8)); set { SdkMemory.Copy(value.Pointer,new IntPtr(0xA485A8),900); } }
    [NativeMember("UpsideDownCars")]
    public static CUpsideDownCarCheck @UpsideDownCars { get => new CUpsideDownCarCheck(new IntPtr(0xA4892C)); set { SdkMemory.Copy(value.Pointer,new IntPtr(0xA4892C),48); } }
    [NativeMember("LocalVariablesForCurrentMission")]
    public static tScriptParam? @LocalVariablesForCurrentMission { get => new IntPtr(0xA48960) == IntPtr.Zero ? null : new tScriptParam(new IntPtr(0xA48960)); }
    [NativeMember("ScriptSpace")]
    public static NativePointer<sbyte> @ScriptSpace { get => new NativePointer<sbyte>(new IntPtr(0xA49960)); }
    [NativeMember("MissionBlock")]
    public static NativePointer<sbyte> @MissionBlock { get => new NativePointer<sbyte>(new IntPtr(0xA7A6A0)); }
    [NativeMember("pIdleScripts")]
    public static CRunningScript? @IdleScripts { get => SdkMemory.Read<IntPtr>(new IntPtr(0xA8B428)) == IntPtr.Zero ? null : new CRunningScript(SdkMemory.Read<IntPtr>(new IntPtr(0xA8B428))); set { SdkMemory.Write(new IntPtr(0xA8B428),value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("pActiveScripts")]
    public static CRunningScript? @ActiveScripts { get => SdkMemory.Read<IntPtr>(new IntPtr(0xA8B42C)) == IntPtr.Zero ? null : new CRunningScript(SdkMemory.Read<IntPtr>(new IntPtr(0xA8B42C))); set { SdkMemory.Write(new IntPtr(0xA8B42C),value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("ScriptsArray")]
    public static CRunningScript? @ScriptsArray { get => new IntPtr(0xA8B430) == IntPtr.Zero ? null : new CRunningScript(new IntPtr(0xA8B430)); }
    [NativeMember("NumberOfScriptSearchLights")]
    public static ushort @NumberOfScriptSearchLights { get => SdkMemory.Read<ushort >(new IntPtr(0xA90830)); set { SdkMemory.Write(new IntPtr(0xA90830),value); } }
    [NativeMember("MissionCleanUp")]
    public static CMissionCleanup @MissionCleanUp { get => new CMissionCleanup(new IntPtr(0xA90850)); set { SdkMemory.Copy(value.Pointer,new IntPtr(0xA90850),604); } }
    [NativeMember("StuckCars")]
    public static CStuckCarCheck @StuckCars { get => new CStuckCarCheck(new IntPtr(0xA90AB0)); set { SdkMemory.Copy(value.Pointer,new IntPtr(0xA90AB0),576); } }
    [NativeMember("ScriptsForBrains")]
    public static CScriptsForBrains @ScriptsForBrains { get => new CScriptsForBrains(new IntPtr(0xA90CF0)); set { SdkMemory.Copy(value.Pointer,new IntPtr(0xA90CF0),1400); } }
    [NativeMember("ScriptSphereArray")]
    public static tScriptSphere? @ScriptSphereArray { get => new IntPtr(0xA91268) == IntPtr.Zero ? null : new tScriptSphere(new IntPtr(0xA91268)); }
    [NativeMember("ScriptSearchLightArray")]
    public static tScriptSearchlight? @ScriptSearchLightArray { get => new IntPtr(0xA94D68) == IntPtr.Zero ? null : new tScriptSearchlight(new IntPtr(0xA94D68)); }
    [NativeMember("UseTextCommands")]
    public static eUseTextCommandState @UseTextCommands { get => SdkMemory.Read<eUseTextCommandState >(new IntPtr(0xA44B67)); set { SdkMemory.Write(new IntPtr(0xA44B67),value); } }
    [NativeMember("NumberOfIntroTextLinesThisFrame")]
    public static ushort @NumberOfIntroTextLinesThisFrame { get => SdkMemory.Read<ushort >(new IntPtr(0xA44B68)); set { SdkMemory.Write(new IntPtr(0xA44B68),value); } }
    [NativeMember("IntroTextLines")]
    public static NativeObjectArray<tScriptText> @IntroTextLines { get => new NativeObjectArray<tScriptText>(new IntPtr(0xA913E8),96,68); }
    [NativeMember("NumberOfIntroRectanglesThisFrame")]
    public static ushort @NumberOfIntroRectanglesThisFrame { get => SdkMemory.Read<ushort >(new IntPtr(0xA44B5C)); set { SdkMemory.Write(new IntPtr(0xA44B5C),value); } }
    [NativeMember("IntroRectangles")]
    public static NativeObjectArray<tScriptRectangle> @IntroRectangles { get => new NativeObjectArray<tScriptRectangle>(new IntPtr(0xA92D68),128,60); }
    [NativeMember("ScriptSprites")]
    public static NativeObjectArray<CSprite2d> @ScriptSprites { get => new NativeObjectArray<CSprite2d>(new IntPtr(0xA94B68),128,4); }
    public static int @AddScriptCheckpoint(float @at_X,float @at_Y,float @at_Z,float @PointTo_X,float @PointTo_Y,float @PointTo_Z,float @radius,int @type) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4087 >(4087)(@at_X,@at_Y,@at_Z,@PointTo_X,@PointTo_Y,@PointTo_Z,@radius,@type); return __sdkResult; }
    public static int @AddScriptEffectSystem(FxSystem_c? @a1) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4088 >(4088)(@a1?.Pointer ?? IntPtr.Zero); return __sdkResult; }
    public static int @AddScriptSearchLight(float @startX,float @startY,float @startZ,CEntity? @entity,float @targetX,float @targetY,float @targetZ,float @targetRadius,float @baseRadius) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4089 >(4089)(@startX,@startY,@startZ,@entity?.Pointer ?? IntPtr.Zero,@targetX,@targetY,@targetZ,@targetRadius,@baseRadius); return __sdkResult; }
    public static uint @AddScriptSphere(uint @id,CVector @posn,float @radius) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4090 >(4090)(@id,@posn.Pointer,@radius); return __sdkResult; }
    public static void @AddToBuildingSwapArray(CBuilding? @a1,int @newModelId,int @oldModelId) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4091 >(4091)(@a1?.Pointer ?? IntPtr.Zero,@newModelId,@oldModelId); }
    public static void @AddToInvisibilitySwapArray(CEntity? @a2,bool @bVisible) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4092 >(4092)(@a2?.Pointer ?? IntPtr.Zero,(@bVisible ? 1 : 0)); }
    public static void @AddToListOfConnectedLodObjects(CObject? @pObject1,CObject? @pObject2) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4093 >(4093)(@pObject1?.Pointer ?? IntPtr.Zero,@pObject2?.Pointer ?? IntPtr.Zero); }
    public static void @AddToListOfSpecialAnimGroupsAttachedToCharModels(int @modelid,NativePointer<sbyte> @ifpName) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4094 >(4094)(@modelid,@ifpName.Pointer); }
    public static double @AddToSwitchJumpTable(int @switchValue,int @switchLabelLocalAddress) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4095 >(4095)(@switchValue,@switchLabelLocalAddress); return __sdkResult; }
    public static void @AddToVehicleModelsBlockedByScript(int @modelindex) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4096 >(4096)(@modelindex); }
    public static void @AddToWaitingForScriptBrainArray(CEntity? @pEntity,short @arg2) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4097 >(4097)(@pEntity?.Pointer ?? IntPtr.Zero,@arg2); }
    public static void @AttachSearchlightToSearchlightObject(int @searchlightid,CObject? @tower,CObject? @housing,CObject? @bulb,float @offsetX,float @offsetY,float @offsetZ) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4098 >(4098)(@searchlightid,@tower?.Pointer ?? IntPtr.Zero,@housing?.Pointer ?? IntPtr.Zero,@bulb?.Pointer ?? IntPtr.Zero,@offsetX,@offsetY,@offsetZ); }
    public static sbyte @CheckStreamedScriptVersion(RwStream? @arg1,NativePointer<sbyte> @arg2) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4099 >(4099)(@arg1?.Pointer ?? IntPtr.Zero,@arg2.Pointer); return __sdkResult; }
    public static void @CleanUpThisObject(CObject? @pObject) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4100 >(4100)(@pObject?.Pointer ?? IntPtr.Zero); }
    public static void @CleanUpThisPed(CPed? @ped) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4101 >(4101)(@ped?.Pointer ?? IntPtr.Zero); }
    public static void @CleanUpThisVehicle(CVehicle? @pVehicle) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4102 >(4102)(@pVehicle?.Pointer ?? IntPtr.Zero); }
    public static void @ClearAllSuppressedCarModels() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4103 >(4103)(); }
    public static void @ClearAllVehicleModelsBlockedByScript() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4104 >(4104)(); }
    public static void @ClearSpaceForMissionEntity(CVector @pos,CEntity? @pEntity) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4105 >(4105)(@pos.Pointer,@pEntity?.Pointer ?? IntPtr.Zero); }
    public static void @DoScriptSetupAfterPoolsHaveLoaded() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4106 >(4106)(); }
    public static void @DrawDebugAngledSquare(float @x1,float @y1,float @x2,float @y2,float @x3,float @y3,float @x4,float @y4) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4107 >(4107)(@x1,@y1,@x2,@y2,@x3,@y3,@x4,@y4); }
    public static void @DrawDebugCube(float @x1,float @y1,float @x2,float @y2) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4108 >(4108)(@x1,@y1,@x2,@y2); }
    public static void @DrawScriptSpheres() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4109 >(4109)(); }
    public static void @DrawScriptSpritesAndRectangles(sbyte @bDrawBeforeFade) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4110 >(4110)(@bDrawBeforeFade); }
    public static int @GetActualScriptThingIndex(int @index,byte @type) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4111 >(4111)(@index,@type); return __sdkResult; }
    public static uint @GetNewUniqueScriptThingIndex(uint @index,sbyte @type) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4112 >(4112)(@index,@type); return __sdkResult; }
    public static int @GetScriptIndexFromPointer(CRunningScript? @thread) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4113 >(4113)(@thread?.Pointer ?? IntPtr.Zero); return __sdkResult; }
    public static uint @GetUniqueScriptThingIndex(int @playergroup,byte @type) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4114 >(4114)(@playergroup,@type); return __sdkResult; }
    public static bool @HasVehicleModelBeenBlockedByScript(int @modelindex) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4115 >(4115)(@modelindex); return __sdkResult != 0; }
    public static void @HighlightImportantAngledArea(uint @markerid,float @from_X,float @from_Y,float @to_X,float @to_Y,float @angledTo_X,float @angledTo_Y,float @angledFrom_X,float @angledFrom_Y,float @height) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4116 >(4116)(@markerid,@from_X,@from_Y,@to_X,@to_Y,@angledTo_X,@angledTo_Y,@angledFrom_X,@angledFrom_Y,@height); }
    public static void @HighlightImportantArea(int @markerid,float @from_X,float @from_Y,float @to_X,float @to_Y,float @height) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4117 >(4117)(@markerid,@from_X,@from_Y,@to_X,@to_Y,@height); }
    public static void @Init() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4118 >(4118)(); }
    public static void @InitialiseAllConnectLodObjects() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4119 >(4119)(); }
    public static void @InitialiseConnectLodObjects(ushort @a1) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4120 >(4120)(@a1); }
    public static void @InitialiseSpecialAnimGroup(ushort @a1) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4121 >(4121)(@a1); }
    public static void @InitialiseSpecialAnimGroupsAttachedToCharModels() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4122 >(4122)(); }
    public static bool @IsEntityWithinAnySearchLight(CEntity? @pEntity,NativePointer<int> @pIndex) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4123 >(4123)(@pEntity?.Pointer ?? IntPtr.Zero,@pIndex.Pointer); return __sdkResult != 0; }
    public static bool @IsEntityWithinSearchLight(uint @index,CEntity? @pEntity) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4124 >(4124)(@index,@pEntity?.Pointer ?? IntPtr.Zero); return __sdkResult != 0; }
    public static bool @IsPedStopped(CPed? @ped) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4125 >(4125)(@ped?.Pointer ?? IntPtr.Zero); return __sdkResult != 0; }
    public static bool @IsPlayerOnAMission() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4126 >(4126)(); return __sdkResult != 0; }
    public static bool @IsPointWithinSearchLight(CVector? @pointPosn,int @index) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4127 >(4127)(@pointPosn?.Pointer ?? IntPtr.Zero,@index); return __sdkResult != 0; }
    public static bool @IsVehicleStopped(CVehicle? @pVehicle) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4128 >(4128)(@pVehicle?.Pointer ?? IntPtr.Zero); return __sdkResult != 0; }
    public static void @Load() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4129 >(4129)(); }
    public static void @MoveSearchLightBetweenTwoPoints(int @index,float @x1,float @y1,float @z1,float @x2,float @y2,float @z2,float @pathSpeed) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4130 >(4130)(@index,@x1,@y1,@z1,@x2,@y2,@z2,@pathSpeed); }
    public static void @MoveSearchLightToEntity(int @index,CEntity? @pEntity,float @pathSpeed) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4131 >(4131)(@index,@pEntity?.Pointer ?? IntPtr.Zero,@pathSpeed); }
    public static void @MoveSearchLightToPointAndStop(int @index,float @x,float @y,float @z,float @pathSpeed) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4132 >(4132)(@index,@x,@y,@z,@pathSpeed); }
    public static void @PrintListSizes() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4133 >(4133)(); }
    public static void @Process() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4134 >(4134)(); }
    public static void @ProcessAllSearchLights() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4135 >(4135)(); }
    public static void @ProcessWaitingForScriptBrainArray() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4136 >(4136)(); }
    public static void @ReadMultiScriptFileOffsetsFromScript() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4137 >(4137)(); }
    public static void @ReadObjectNamesFromScript() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4138 >(4138)(); }
    public static void @ReinitialiseSwitchStatementData() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4139 >(4139)(); }
    public static void @RemoveFromVehicleModelsBlockedByScript(int @modelindex) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4140 >(4140)(@modelindex); }
    public static int @RemoveFromWaitingForScriptBrainArray(CEntity? @a1,short @modelIndex) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4141 >(4141)(@a1?.Pointer ?? IntPtr.Zero,@modelIndex); return __sdkResult; }
    public static void @RemoveScriptCheckpoint(int @arg1) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4142 >(4142)(@arg1); }
    public static void @RemoveScriptEffectSystem(int @arg1) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4143 >(4143)(@arg1); }
    public static void @RemoveScriptSearchLight(uint @index) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4144 >(4144)(@index); }
    public static void @RemoveScriptSphere(int @index) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4145 >(4145)(@index); }
    public static void @RemoveScriptTextureDictionary() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4146 >(4146)(); }
    public static void @RemoveThisPed(CPed? @ped) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4147 >(4147)(@ped?.Pointer ?? IntPtr.Zero); }
    public static void @RenderAllSearchLights() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4148 >(4148)(); }
    public static void @Save() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4149 >(4149)(); }
    public static bool @ScriptAttachAnimGroupToCharModel(int @modelId,NativePointer<sbyte> @ifpName) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4150 >(4150)(@modelId,@ifpName.Pointer); return __sdkResult != 0; }
    public static void @ScriptConnectLodsFunction(int @objecthandle1,int @objecthandle2) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4151 >(4151)(@objecthandle1,@objecthandle2); }
    public static void @ScriptDebugCircle2D(float @x,float @y,float @width,float @height,CRGBA @color) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4152 >(4152)(@x,@y,@width,@height,@color.Pointer); }
    public static CRunningScript? @StartNewScript(NativePointer<byte> @startIP) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4153 >(4153)(@startIP.Pointer); return __sdkResult == IntPtr.Zero ? null : new CRunningScript(__sdkResult); }
    public static int @StartNewScript(NativePointer<byte> @startIP,ushort @index) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4154 >(4154)(@startIP.Pointer,@index); return __sdkResult; }
    public static void @StartTestScript() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4155 >(4155)(); }
    public static void @UndoBuildingSwaps() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4156 >(4156)(); }
    public static void @UndoEntityInvisibilitySettings() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4157 >(4157)(); }
    public static void @UpdateObjectIndices() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4158 >(4158)(); }
    public static void @UseSwitchJumpTable(NativePointer<int> @pSwitchLabelAddress) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4159 >(4159)(@pSwitchLabelAddress.Pointer); }
    public static void @WipeLocalVariableMemoryForMissionScript() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4160 >(4160)(); }
}
