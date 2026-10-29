// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CStreaming : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=1;
    public CStreaming(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("ms_memoryAvailable")]
    public static uint @MemoryAvailable { get => SdkMemory.Read<uint >(new IntPtr(0x8A5A80)); set { SdkMemory.Write(new IntPtr(0x8A5A80),value); } }
    [NativeMember("desiredNumVehiclesLoaded")]
    public static uint @DesiredCountVehiclesLoaded { get => SdkMemory.Read<uint >(new IntPtr(0x8A5A84)); set { SdkMemory.Write(new IntPtr(0x8A5A84),value); } }
    [NativeMember("ms_bLoadVehiclesInLoadScene")]
    public static bool @LoadVehiclesInLoadScene { get => SdkMemory.Read<bool >(new IntPtr(0x8A5A88)); set { SdkMemory.Write(new IntPtr(0x8A5A88),value); } }
    [NativeMember("ms_aDefaultCopCarModel")]
    public static NativePointer<int> @DefaultCopCarModel { get => new NativePointer<int>(new IntPtr(0x8A5A8C)); }
    [NativeMember("ms_DefaultCopBikeModel")]
    public static int @DefaultCopBikeModel { get => SdkMemory.Read<int >(new IntPtr(0x8A5A9C)); set { SdkMemory.Write(new IntPtr(0x8A5A9C),value); } }
    [NativeMember("ms_aDefaultCopModel")]
    public static NativePointer<int> @DefaultCopModel { get => new NativePointer<int>(new IntPtr(0x8A5AA0)); }
    [NativeMember("ms_DefaultCopBikerModel")]
    public static int @DefaultCopBikerModel { get => SdkMemory.Read<int >(new IntPtr(0x8A5AB0)); set { SdkMemory.Write(new IntPtr(0x8A5AB0),value); } }
    [NativeMember("ms_aDefaultAmbulanceModel")]
    public static NativePointer<int> @DefaultAmbulanceModel { get => new NativePointer<int>(new IntPtr(0x8A5AB4)); }
    [NativeMember("ms_aDefaultMedicModel")]
    public static NativePointer<int> @DefaultMedicModel { get => new NativePointer<int>(new IntPtr(0x8A5AC4)); }
    [NativeMember("ms_aDefaultFireEngineModel")]
    public static NativePointer<int> @DefaultFireEngineModel { get => new NativePointer<int>(new IntPtr(0x8A5AD4)); }
    [NativeMember("ms_aDefaultFiremanModel")]
    public static NativePointer<int> @DefaultFiremanModel { get => new NativePointer<int>(new IntPtr(0x8A5AE4)); }
    [NativeMember("ms_aDefaultCabDriverModel")]
    public static NativePointer<int> @DefaultCabDriverModel { get => new NativePointer<int>(new IntPtr(0x8A5AF4)); }
    [NativeMember("ms_pExtraObjectsDir")]
    public static CDirectory? @ExtraObjectsDirection { get => SdkMemory.Read<IntPtr>(new IntPtr(0x8E48D0)) == IntPtr.Zero ? null : new CDirectory(SdkMemory.Read<IntPtr>(new IntPtr(0x8E48D0))); set { SdkMemory.Write(new IntPtr(0x8E48D0),value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("ms_files")]
    public static tStreamingFileDesc? @Files { get => new IntPtr(0x8E48D8) == IntPtr.Zero ? null : new tStreamingFileDesc(new IntPtr(0x8E48D8)); }
    [NativeMember("ms_bLoadingBigModel")]
    public static bool @LoadingBigModel { get => SdkMemory.Read<bool >(new IntPtr(0x8E4A58)); set { SdkMemory.Write(new IntPtr(0x8E4A58),value); } }
    [NativeMember("ms_channel")]
    public static tStreamingChannel? @Channel { get => new IntPtr(0x8E4A60) == IntPtr.Zero ? null : new tStreamingChannel(new IntPtr(0x8E4A60)); }
    [NativeMember("ms_channelError")]
    public static int @ChannelError { get => SdkMemory.Read<int >(new IntPtr(0x8E4B90)); set { SdkMemory.Write(new IntPtr(0x8E4B90),value); } }
    [NativeMember("m_bHarvesterModelsRequested")]
    public static bool @HarvesterModelsRequested { get => SdkMemory.Read<bool >(new IntPtr(0x8E4B9C)); set { SdkMemory.Write(new IntPtr(0x8E4B9C),value); } }
    [NativeMember("m_bStreamHarvesterModelsThisFrame")]
    public static bool @StreamHarvesterModelsThisFrame { get => SdkMemory.Read<bool >(new IntPtr(0x8E4B9D)); set { SdkMemory.Write(new IntPtr(0x8E4B9D),value); } }
    [NativeMember("ms_numPriorityRequests")]
    public static uint @CountPriorityRequests { get => SdkMemory.Read<uint >(new IntPtr(0x8E4BA0)); set { SdkMemory.Write(new IntPtr(0x8E4BA0),value); } }
    [NativeMember("ms_lastCullZone")]
    public static int @LastCullZone { get => SdkMemory.Read<int >(new IntPtr(0x8E4BA4)); set { SdkMemory.Write(new IntPtr(0x8E4BA4),value); } }
    [NativeMember("ms_loadedGangCars")]
    public static ushort @LoadedGangCars { get => SdkMemory.Read<ushort >(new IntPtr(0x8E4BA8)); set { SdkMemory.Write(new IntPtr(0x8E4BA8),value); } }
    [NativeMember("ms_loadedGangs")]
    public static ushort @LoadedGangs { get => SdkMemory.Read<ushort >(new IntPtr(0x8E4BAC)); set { SdkMemory.Write(new IntPtr(0x8E4BAC),value); } }
    [NativeMember("ms_numPedsLoaded")]
    public static uint @CountPedsLoaded { get => SdkMemory.Read<uint >(new IntPtr(0x8E4BB0)); set { SdkMemory.Write(new IntPtr(0x8E4BB0),value); } }
    [NativeMember("ms_pedsLoaded")]
    public static NativePointer<IntPtr> @PedsLoaded { get => new NativePointer<IntPtr>(new IntPtr(0x8E4C00)); }
    [NativeMember("ms_currentZoneType")]
    public static int @CurrentZoneType { get => SdkMemory.Read<int >(new IntPtr(0x8E4C20)); set { SdkMemory.Write(new IntPtr(0x8E4C20),value); } }
    [NativeMember("ms_vehiclesLoaded")]
    public static CLoadedCarGroup @VehiclesLoaded { get => new CLoadedCarGroup(new IntPtr(0x8E4C24)); set { SdkMemory.Copy(value.Pointer,new IntPtr(0x8E4C24),46); } }
    [NativeMember("ms_pEndRequestedList")]
    public static CStreamingInfo? @EndRequestedList { get => SdkMemory.Read<IntPtr>(new IntPtr(0x8E4C54)) == IntPtr.Zero ? null : new CStreamingInfo(SdkMemory.Read<IntPtr>(new IntPtr(0x8E4C54))); set { SdkMemory.Write(new IntPtr(0x8E4C54),value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("ms_pStartRequestedList")]
    public static CStreamingInfo? @StartRequestedList { get => SdkMemory.Read<IntPtr>(new IntPtr(0x8E4C58)) == IntPtr.Zero ? null : new CStreamingInfo(SdkMemory.Read<IntPtr>(new IntPtr(0x8E4C58))); set { SdkMemory.Write(new IntPtr(0x8E4C58),value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("ms_pEndLoadedList")]
    public static CStreamingInfo? @EndLoadedList { get => SdkMemory.Read<IntPtr>(new IntPtr(0x8E4C5C)) == IntPtr.Zero ? null : new CStreamingInfo(SdkMemory.Read<IntPtr>(new IntPtr(0x8E4C5C))); set { SdkMemory.Write(new IntPtr(0x8E4C5C),value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("ms_startLoadedList")]
    public static CStreamingInfo? @StartLoadedList { get => SdkMemory.Read<IntPtr>(new IntPtr(0x8E4C60)) == IntPtr.Zero ? null : new CStreamingInfo(SdkMemory.Read<IntPtr>(new IntPtr(0x8E4C60))); set { SdkMemory.Write(new IntPtr(0x8E4C60),value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("ms_lastImageRead")]
    public static int @LastImageRead { get => SdkMemory.Read<int >(new IntPtr(0x8E4C64)); set { SdkMemory.Write(new IntPtr(0x8E4C64),value); } }
    [NativeMember("ms_imageOffsets")]
    public static NativePointer<int> @ImageOffsets { get => new NativePointer<int>(new IntPtr(0x8E4C8C)); }
    [NativeMember("ms_bEnableRequestListPurge")]
    public static bool @EnableRequestListPurge { get => SdkMemory.Read<bool >(new IntPtr(0x8E4CA4)); set { SdkMemory.Write(new IntPtr(0x8E4CA4),value); } }
    [NativeMember("ms_streamingBufferSize")]
    public static uint @StreamingBufferSize { get => SdkMemory.Read<uint >(new IntPtr(0x8E4CA8)); set { SdkMemory.Write(new IntPtr(0x8E4CA8),value); } }
    [NativeMember("ms_pStreamingBuffer")]
    public static NativePointer<sbyte> @StreamingBuffer { get => new NativePointer<sbyte>(SdkMemory.Read<IntPtr>(new IntPtr(0x8E4CAC))); set { SdkMemory.Write(new IntPtr(0x8E4CAC),value.Pointer); } }
    [NativeMember("ms_memoryUsed")]
    public static uint @MemoryUsed { get => SdkMemory.Read<uint >(new IntPtr(0x8E4CB4)); set { SdkMemory.Write(new IntPtr(0x8E4CB4),value); } }
    [NativeMember("ms_numModelsRequested")]
    public static uint @CountModelsRequested { get => SdkMemory.Read<uint >(new IntPtr(0x8E4CB8)); set { SdkMemory.Write(new IntPtr(0x8E4CB8),value); } }
    [NativeMember("ms_aInfoForModel")]
    public static CStreamingInfo? @InfoForModel { get => SdkMemory.Read<IntPtr>(SdkBindings.Address(4655)) == IntPtr.Zero ? null : new CStreamingInfo(SdkMemory.Read<IntPtr>(SdkBindings.Address(4655))); }
    [NativeMember("ms_disableStreaming")]
    public static bool @DisableStreaming { get => SdkMemory.Read<bool >(new IntPtr(0x9654B0)); set { SdkMemory.Write(new IntPtr(0x9654B0),value); } }
    [NativeMember("ms_bIsInitialised")]
    public static int @IsInitialisedValue { get => SdkMemory.Read<int >(new IntPtr(0x9654B8)); set { SdkMemory.Write(new IntPtr(0x9654B8),value); } }
    [NativeMember("m_bBoatsNeeded")]
    public static bool @BoatsNeeded { get => SdkMemory.Read<bool >(new IntPtr(0x9654BC)); set { SdkMemory.Write(new IntPtr(0x9654BC),value); } }
    [NativeMember("m_bLoadingScene")]
    public static bool @LoadingScene { get => SdkMemory.Read<bool >(new IntPtr(0x9654BD)); set { SdkMemory.Write(new IntPtr(0x9654BD),value); } }
    [NativeMember("m_bCopBikeLoaded")]
    public static bool @CopBikeLoaded { get => SdkMemory.Read<bool >(new IntPtr(0x9654BE)); set { SdkMemory.Write(new IntPtr(0x9654BE),value); } }
    [NativeMember("m_bDisableCopBikes")]
    public static bool @DisableCopBikesValue { get => SdkMemory.Read<bool >(new IntPtr(0x9654BF)); set { SdkMemory.Write(new IntPtr(0x9654BF),value); } }
    [NativeMember("ms_rwObjectInstances")]
    public static CLinkList_CEntity____0cb08b2217 @ObjectInstances { get => new CLinkList_CEntity____0cb08b2217(new IntPtr(0x9654F0)); set { SdkMemory.Copy(value.Pointer,new IntPtr(0x9654F0),-2); } }
    public static NativePointer<IntPtr> @AddEntity(CEntity? @a2) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3873 >(3873)(@a2?.Pointer ?? IntPtr.Zero); return new NativePointer<IntPtr>(__sdkResult); }
    public static int @AddImageToList(NativePointer<sbyte> @lpFileName,bool @bNotPlayerImg) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3874 >(3874)(@lpFileName.Pointer,(@bNotPlayerImg ? 1 : 0)); return __sdkResult; }
    public static void @AddLodsToRequestList(CVector? @Posn,uint @Streamingflags) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3875 >(3875)(@Posn?.Pointer ?? IntPtr.Zero,@Streamingflags); }
    public static void @AddModelsToRequestList(CVector? @posn,uint @StreamingFlags) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3876 >(3876)(@posn?.Pointer ?? IntPtr.Zero,@StreamingFlags); }
    public static bool @AddToLoadedVehiclesList(int @modelID) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3877 >(3877)(@modelID); return __sdkResult != 0; }
    public static bool @AreAnimsUsedByRequestedModels(int @AnimFileIndex) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3878 >(3878)(@AnimFileIndex); return __sdkResult != 0; }
    public static bool @AreTexturesUsedByRequestedModels(int @txdIndex) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3879 >(3879)(@txdIndex); return __sdkResult != 0; }
    public static void @ClearFlagForAll(uint @eStreamingFlag) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3880 >(3880)(@eStreamingFlag); }
    public static void @ClearSlots(int @NumOfSlots) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3881 >(3881)(@NumOfSlots); }
    public static sbyte @ConvertBufferToObject(NativePointer<sbyte> @pFileContect,int @index,int @ChannelIndex) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3882 >(3882)(@pFileContect.Pointer,@index,@ChannelIndex); return __sdkResult; }
    public static void @DeleteAllRwObjects() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3883 >(3883)(); }
    public static bool @DeleteLeastUsedEntityRwObject(bool @bNotOnScreen,uint @StreamingFlags) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3884 >(3884)((@bNotOnScreen ? 1 : 0),@StreamingFlags); return __sdkResult != 0; }
    public static void @DeleteRwObjectsAfterDeath(CVector? @PlayerPosn) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3885 >(3885)(@PlayerPosn?.Pointer ?? IntPtr.Zero); }
    public static void @DeleteRwObjectsBehindCamera(int @memoryToCleanInBytes) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3886 >(3886)(@memoryToCleanInBytes); }
    public static bool @DeleteRwObjectsBehindCameraInSectorList(CPtrList? @List,int @memoryToCleanInBytes) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3887 >(3887)(@List?.Pointer ?? IntPtr.Zero,@memoryToCleanInBytes); return __sdkResult != 0; }
    public static void @DeleteRwObjectsInSectorList(CPtrList? @PtrList,int @arg2,int @arg3) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3888 >(3888)(@PtrList?.Pointer ?? IntPtr.Zero,@arg2,@arg3); }
    public static sbyte @DeleteRwObjectsNotInFrustumInSectorList(CPtrList? @List,int @memoryToCleanInBytes) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3889 >(3889)(@List?.Pointer ?? IntPtr.Zero,@memoryToCleanInBytes); return __sdkResult; }
    public static void @DisableCopBikes(bool @bDisable) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3890 >(3890)((@bDisable ? 1 : 0)); }
    public static int @FindMIPedSlotForInterior(int @RandFactor) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3891 >(3891)(@RandFactor); return __sdkResult; }
    public static bool @FinishLoadingLargeFile(NativePointer<sbyte> @FileName,int @modelIndex) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3892 >(3892)(@FileName.Pointer,@modelIndex); return __sdkResult != 0; }
    public static bool @FlushChannels() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3893 >(3893)(); return __sdkResult != 0; }
    public static bool @FlushRequestList() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3894 >(3894)(); return __sdkResult != 0; }
    public static void @ForceLayerToRead(int @arg1) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3895 >(3895)(@arg1); }
    public static int @GetDefaultCabDriverModel() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3896 >(3896)(); return __sdkResult; }
    public static int @GetDefaultCopCarModel(uint @bIncludeCopBike) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3897 >(3897)(@bIncludeCopBike); return __sdkResult; }
    public static int @GetDefaultCopModel() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3898 >(3898)(); return __sdkResult; }
    public static int @GetDefaultFiremanModel() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3899 >(3899)(); return __sdkResult; }
    public static int @GetDefaultMedicModel() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3900 >(3900)(); return __sdkResult; }
    public static int @GetDiscInDrive() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3901 >(3901)(); return __sdkResult; }
    public static int @GetNextFileOnCd(int @pos,bool @bNotPriority) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3902 >(3902)(@pos,(@bNotPriority ? 1 : 0)); return __sdkResult; }
    public static bool @HasModelLoaded(int @modelIndex) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3903 >(3903)(@modelIndex); return __sdkResult != 0; }
    public static bool @HasSpecialCharLoaded(int @slot) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3904 >(3904)(@slot); return __sdkResult != 0; }
    public static bool @HasVehicleUpgradeLoaded(int @ModelIndex) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3905 >(3905)(@ModelIndex); return __sdkResult != 0; }
    public static void @IHaveUsedStreamingMemory() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3906 >(3906)(); }
    public static void @ImGonnaUseStreamingMemory() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3907 >(3907)(); }
    public static void @Init() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3908 >(3908)(); }
    public static void @Init2() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3909 >(3909)(); }
    public static void @InitImageList() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3910 >(3910)(); }
    public static void @InstanceLoadedModels(CVector? @posn) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3911 >(3911)(@posn?.Pointer ?? IntPtr.Zero); }
    public static bool @IsCarModelNeededInCurrentZone(int @VehicleModelIndex) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3912 >(3912)(@VehicleModelIndex); return __sdkResult != 0; }
    public static bool @IsInitialised() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3913 >(3913)(); return __sdkResult != 0; }
    public static bool @IsObjectInCdImage(int @ModelInex) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3914 >(3914)(@ModelInex); return __sdkResult != 0; }
    public static bool @IsVeryBusy() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3915 >(3915)(); return __sdkResult != 0; }
    public static void @Load() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3916 >(3916)(); }
    public static void @LoadAllRequestedModels(bool @bOnlyPriorityRequests) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3917 >(3917)((@bOnlyPriorityRequests ? 1 : 0)); }
    public static void @LoadCdDirectory(NativePointer<sbyte> @ArchiveName,int @archiveID) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3918 >(3918)(@ArchiveName.Pointer,@archiveID); }
    public static void @LoadCdDirectory() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3919 >(3919)(); }
    public static void @LoadInitialPeds() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3920 >(3920)(); }
    public static void @LoadInitialVehicles() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3921 >(3921)(); }
    public static void @LoadInitialWeapons() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3922 >(3922)(); }
    public static void @LoadRequestedModels() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3923 >(3923)(); }
    public static void @LoadScene(CVector? @Posn) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3924 >(3924)(@Posn?.Pointer ?? IntPtr.Zero); }
    public static void @LoadSceneCollision(CVector? @Posn) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3925 >(3925)(@Posn?.Pointer ?? IntPtr.Zero); }
    public static void @LoadZoneVehicle(CVector? @posn) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3926 >(3926)(@posn?.Pointer ?? IntPtr.Zero); }
    public static void @MakeSpaceFor(int @memoryToCleanInBytes) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3927 >(3927)(@memoryToCleanInBytes); }
    public static void @PossiblyStreamCarOutAfterCreation(int @modelId) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3928 >(3928)(@modelId); }
    public static void @ProcessEntitiesInSectorList(CPtrList? @list,float @posn_x,float @posn_y,float @min_posn_x,float @min_posn_y,float @max_posn_x,float @max_posn_y,float @distance,uint @Streamingflags) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3929 >(3929)(@list?.Pointer ?? IntPtr.Zero,@posn_x,@posn_y,@min_posn_x,@min_posn_y,@max_posn_x,@max_posn_y,@distance,@Streamingflags); }
    public static void @ProcessEntitiesInSectorList(CPtrList? @list,uint @streamingFlags) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3930 >(3930)(@list?.Pointer ?? IntPtr.Zero,@streamingFlags); }
    public static bool @ProcessLoadingChannel(int @channelIndex) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3931 >(3931)(@channelIndex); return __sdkResult != 0; }
    public static void @PurgeRequestList() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3932 >(3932)(); }
    public static uint @ReInit() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3933 >(3933)(); return __sdkResult; }
    public static void @ReadIniFile() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3934 >(3934)(); }
    public static void @ReclassifyLoadedCars() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3935 >(3935)(); }
    public static void @RemoveAllUnusedModels() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3936 >(3936)(); }
    public static void @RemoveBigBuildings() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3937 >(3937)(); }
    public static void @RemoveBuildingsNotInArea(int @AreaCode) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3938 >(3938)(@AreaCode); }
    public static void @RemoveCarModel(int @modelIndex) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3939 >(3939)(@modelIndex); }
    public static void @RemoveCurrentZonesModels() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3940 >(3940)(); }
    public static void @RemoveDodgyPedsFromRandomSlots() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3941 >(3941)(); }
    public static void @RemoveEntity(CLink_CEntity____5bd3ea959f? @streamingLink) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3942 >(3942)(@streamingLink?.Pointer ?? IntPtr.Zero); }
    public static void @RemoveInappropriatePedModels() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3943 >(3943)(); }
    public static bool @RemoveLeastUsedModel(uint @StreamingFlags) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3944 >(3944)(@StreamingFlags); return __sdkResult != 0; }
    public static bool @RemoveLoadedVehicle() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3945 >(3945)(); return __sdkResult != 0; }
    public static bool @RemoveLoadedZoneModel() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3946 >(3946)(); return __sdkResult != 0; }
    public static void @RemoveModel(int @Modelindex) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3947 >(3947)(@Modelindex); }
    public static uint @RemoveUnusedModelsInLoadedList() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3948 >(3948)(); return __sdkResult; }
    public static void @RenderEntity(CLink_CEntity____5bd3ea959f? @streamingLink) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3949 >(3949)(@streamingLink?.Pointer ?? IntPtr.Zero); }
    public static void @RequestBigBuildings(CVector? @posn) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3950 >(3950)(@posn?.Pointer ?? IntPtr.Zero); }
    public static void @RequestFile(int @index,int @offset,int @size,int @imgId,int @streamingFlags) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3951 >(3951)(@index,@offset,@size,@imgId,@streamingFlags); }
    public static void @RequestFilesInChannel(int @channelId) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3952 >(3952)(@channelId); }
    public static void @RequestModel(int @dwModelId,int @Streamingflags) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3953 >(3953)(@dwModelId,@Streamingflags); }
    public static void @RequestModelStream(int @streamNum) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3954 >(3954)(@streamNum); }
    public static void @RequestPlayerSection(int @modelIndex,NativePointer<sbyte> @string,int @streamingFlags) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3955 >(3955)(@modelIndex,@string.Pointer,@streamingFlags); }
    public static void @RequestSpecialChar(int @slot,NativePointer<sbyte> @Name,int @streamingFlags) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3956 >(3956)(@slot,@Name.Pointer,@streamingFlags); }
    public static void @RequestSpecialModel(int @slot,NativePointer<sbyte> @name,int @StreamingFlags) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3957 >(3957)(@slot,@name.Pointer,@StreamingFlags); }
    public static void @RequestTxdModel(int @TxdModelID,int @Streamingflags) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3958 >(3958)(@TxdModelID,@Streamingflags); }
    public static void @RequestVehicleUpgrade(int @modelIndex,int @StreamingFlags) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3959 >(3959)(@modelIndex,@StreamingFlags); }
    public static void @RetryLoadFile(int @streamNum) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3960 >(3960)(@streamNum); }
    public static void @Save() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3961 >(3961)(); }
    public static void @SetLoadVehiclesInLoadScene(bool @bEnable) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3962 >(3962)((@bEnable ? 1 : 0)); }
    public static void @SetMissionDoesntRequireAnim(int @slot) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3963 >(3963)(@slot); }
    public static void @SetMissionDoesntRequireModel(int @modelIndex) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3964 >(3964)(@modelIndex); }
    public static void @SetMissionDoesntRequireSpecialChar(int @slot) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3965 >(3965)(@slot); }
    public static void @SetModelIsDeletable(int @modelIndex) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3966 >(3966)(@modelIndex); }
    public static void @SetModelTxdIsDeletable(int @modelIndex) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3967 >(3967)(@modelIndex); }
    public static void @SetSpecialCharIsDeletable(int @slot) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3968 >(3968)(@slot); }
    public static void @Shutdown() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3969 >(3969)(); }
    public static void @StartRenderEntities() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3970 >(3970)(); }
    public static bool @StreamAmbulanceAndMedic(bool @bStreamForAccident) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3971 >(3971)((@bStreamForAccident ? 1 : 0)); return __sdkResult != 0; }
    public static void @StreamCopModels(int @townID) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3972 >(3972)(@townID); }
    public static bool @StreamFireEngineAndFireman(bool @bStreamForFire) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3973 >(3973)((@bStreamForFire ? 1 : 0)); return __sdkResult != 0; }
    public static void @StreamOneNewCar() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3974 >(3974)(); }
    public static void @StreamPedsForInterior(int @interiorType) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3975 >(3975)(@interiorType); }
    public static void @StreamPedsIntoRandomSlots(NativePointer<int> @pModelID) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3976 >(3976)(@pModelID.Pointer); }
    public static void @StreamVehiclesAndPeds() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3977 >(3977)(); }
    public static void @StreamVehiclesAndPeds_Always(CVector? @posn) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3978 >(3978)(@posn?.Pointer ?? IntPtr.Zero); }
    public static void @StreamZoneModels(CVector? @posn) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3979 >(3979)(@posn?.Pointer ?? IntPtr.Zero); }
    public static void @StreamZoneModels_Gangs(CVector? @unused) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3980 >(3980)(@unused?.Pointer ?? IntPtr.Zero); }
    public static void @Update() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3981 >(3981)(); }
    public static void @UpdateForAnimViewer() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3982 >(3982)(); }
    public static bool @WeAreTryingToPhaseVehicleOut(int @modelIndex) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3983 >(3983)(@modelIndex); return __sdkResult != 0; }
}
