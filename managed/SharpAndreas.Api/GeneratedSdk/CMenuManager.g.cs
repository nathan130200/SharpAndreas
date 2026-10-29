// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CMenuManager : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=7032;
    public CMenuManager(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_nStatsScrollDir")]
    public sbyte @StatsScrollDirection { get => SdkMemory.Read<sbyte >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("field_1")]
    public NativeArray<sbyte> @Field1 { get => new NativeArray<sbyte>(Pointer+1,3); }
    [NativeMember("m_fStatsScrollSpeed")]
    public float @StatsScrollSpeed { get => SdkMemory.Read<float >(Pointer+4); set { SdkMemory.Write(Pointer+4,value); } }
    [NativeMember("field_8")]
    public sbyte @Field8 { get => SdkMemory.Read<sbyte >(Pointer+8); set { SdkMemory.Write(Pointer+8,value); } }
    [NativeMember("field_9")]
    public NativeArray<sbyte> @Field9 { get => new NativeArray<sbyte>(Pointer+9,23); }
    [NativeMember("m_bPrefsUseVibration")]
    public bool @PrefsUseVibration { get => SdkMemory.Read<bool >(Pointer+32); set { SdkMemory.Write(Pointer+32,value); } }
    [NativeMember("m_bPrefsShowHud")]
    public bool @PrefsShowHud { get => SdkMemory.Read<bool >(Pointer+33); set { SdkMemory.Write(Pointer+33,value); } }
    [NativeMember("field_22")]
    public NativeArray<sbyte> @Field22 { get => new NativeArray<sbyte>(Pointer+34,2); }
    [NativeMember("m_nPrefsRadarMode")]
    public int @PrefsRadarMode { get => SdkMemory.Read<int >(Pointer+36); set { SdkMemory.Write(Pointer+36,value); } }
    [NativeMember("field_28")]
    public int @Field28 { get => SdkMemory.Read<int >(Pointer+40); set { SdkMemory.Write(Pointer+40,value); } }
    [NativeMember("m_nTargetBlipIndex")]
    public int @TargetBlipIndex { get => SdkMemory.Read<int >(Pointer+44); set { SdkMemory.Write(Pointer+44,value); } }
    [NativeMember("n_nMenuSystemPanelId")]
    public sbyte @NMenuSystemPanelId { get => SdkMemory.Read<sbyte >(Pointer+48); set { SdkMemory.Write(Pointer+48,value); } }
    [NativeMember("field_31")]
    public sbyte @Field31 { get => SdkMemory.Read<sbyte >(Pointer+49); set { SdkMemory.Write(Pointer+49,value); } }
    [NativeMember("m_bShutDownFrontEndRequested")]
    public bool @ShutDownFrontEndRequested { get => SdkMemory.Read<bool >(Pointer+50); set { SdkMemory.Write(Pointer+50,value); } }
    [NativeMember("m_bStartUpFrontEndRequested")]
    public bool @StartUpFrontEndRequested { get => SdkMemory.Read<bool >(Pointer+51); set { SdkMemory.Write(Pointer+51,value); } }
    [NativeMember("m_bMenuAccessWidescreen")]
    public bool @MenuAccessWidescreen { get => SdkMemory.Read<bool >(Pointer+52); set { SdkMemory.Write(Pointer+52,value); } }
    [NativeMember("field_35")]
    public sbyte @Field35 { get => SdkMemory.Read<sbyte >(Pointer+53); set { SdkMemory.Write(Pointer+53,value); } }
    [NativeMember("field_36")]
    public NativeArray<sbyte> @Field36 { get => new NativeArray<sbyte>(Pointer+54,2); }
    [NativeMember("m_nKeyPressedCode")]
    public int @KeyPressedCode { get => SdkMemory.Read<int >(Pointer+56); set { SdkMemory.Write(Pointer+56,value); } }
    [NativeMember("m_nPrefsBrightness")]
    public int @PrefsBrightness { get => SdkMemory.Read<int >(Pointer+60); set { SdkMemory.Write(Pointer+60,value); } }
    [NativeMember("m_fPrefsLOD")]
    public float @PrefsLOD { get => SdkMemory.Read<float >(Pointer+64); set { SdkMemory.Write(Pointer+64,value); } }
    [NativeMember("m_bPrefsShowSubtitles")]
    public bool @PrefsShowSubtitles { get => SdkMemory.Read<bool >(Pointer+68); set { SdkMemory.Write(Pointer+68,value); } }
    [NativeMember("m_bPrefsShowLocations")]
    public bool @PrefsShowLocations { get => SdkMemory.Read<bool >(Pointer+69); set { SdkMemory.Write(Pointer+69,value); } }
    [NativeMember("m_bPrefsShowContacts")]
    public bool @PrefsShowContacts { get => SdkMemory.Read<bool >(Pointer+70); set { SdkMemory.Write(Pointer+70,value); } }
    [NativeMember("m_bPrefsShowMission")]
    public bool @PrefsShowMission { get => SdkMemory.Read<bool >(Pointer+71); set { SdkMemory.Write(Pointer+71,value); } }
    [NativeMember("m_bPrefsShowOther")]
    public bool @PrefsShowOther { get => SdkMemory.Read<bool >(Pointer+72); set { SdkMemory.Write(Pointer+72,value); } }
    [NativeMember("m_bPrefsShowGangArea")]
    public bool @PrefsShowGangArea { get => SdkMemory.Read<bool >(Pointer+73); set { SdkMemory.Write(Pointer+73,value); } }
    [NativeMember("m_bPrefsShowLegends")]
    public bool @PrefsShowLegends { get => SdkMemory.Read<bool >(Pointer+74); set { SdkMemory.Write(Pointer+74,value); } }
    [NativeMember("m_bPrefsUseWideScreen")]
    public bool @PrefsUseWideScreen { get => SdkMemory.Read<bool >(Pointer+75); set { SdkMemory.Write(Pointer+75,value); } }
    [NativeMember("m_bPrefsVsync")]
    public bool @PrefsVsync { get => SdkMemory.Read<bool >(Pointer+76); set { SdkMemory.Write(Pointer+76,value); } }
    [NativeMember("m_bPrefsRadioAutoSelect")]
    public bool @PrefsRadioAutoSelect { get => SdkMemory.Read<bool >(Pointer+77); set { SdkMemory.Write(Pointer+77,value); } }
    [NativeMember("field_4E")]
    public sbyte @Field4E { get => SdkMemory.Read<sbyte >(Pointer+78); set { SdkMemory.Write(Pointer+78,value); } }
    [NativeMember("m_nPrefsSfxVolume")]
    public sbyte @PrefsSfxVolume { get => SdkMemory.Read<sbyte >(Pointer+79); set { SdkMemory.Write(Pointer+79,value); } }
    [NativeMember("m_nPrefsMusicVolume")]
    public sbyte @PrefsMusicVolume { get => SdkMemory.Read<sbyte >(Pointer+80); set { SdkMemory.Write(Pointer+80,value); } }
    [NativeMember("m_bPrefsRadioEq")]
    public bool @PrefsRadioEq { get => SdkMemory.Read<bool >(Pointer+81); set { SdkMemory.Write(Pointer+81,value); } }
    [NativeMember("m_nPrefsRadioStation")]
    public sbyte @PrefsRadioStation { get => SdkMemory.Read<sbyte >(Pointer+82); set { SdkMemory.Write(Pointer+82,value); } }
    [NativeMember("m_bRecheckNumPhotos")]
    public sbyte @RecheckCountPhotos { get => SdkMemory.Read<sbyte >(Pointer+83); set { SdkMemory.Write(Pointer+83,value); } }
    [NativeMember("m_nCurrentMenuEntry")]
    public int @CurrentMenuEntry { get => SdkMemory.Read<int >(Pointer+84); set { SdkMemory.Write(Pointer+84,value); } }
    [NativeMember("m_bQuitGameNoCD")]
    public bool @QuitGameNoCD { get => SdkMemory.Read<bool >(Pointer+88); set { SdkMemory.Write(Pointer+88,value); } }
    [NativeMember("m_bDrawRadarOrMap")]
    public bool @DrawRadarOrMap { get => SdkMemory.Read<bool >(Pointer+89); set { SdkMemory.Write(Pointer+89,value); } }
    [NativeMember("m_bAllowNavigation")]
    public bool @AllowNavigation { get => SdkMemory.Read<bool >(Pointer+90); set { SdkMemory.Write(Pointer+90,value); } }
    [NativeMember("m_bStreamingDone")]
    public bool @StreamingDone { get => SdkMemory.Read<bool >(Pointer+91); set { SdkMemory.Write(Pointer+91,value); } }
    [NativeMember("m_bMenuActive")]
    public bool @MenuActive { get => SdkMemory.Read<bool >(Pointer+92); set { SdkMemory.Write(Pointer+92,value); } }
    [NativeMember("m_bWantToRestart")]
    public bool @WantToRestart { get => SdkMemory.Read<bool >(Pointer+93); set { SdkMemory.Write(Pointer+93,value); } }
    [NativeMember("m_bFirstTime")]
    public bool @FirstTime { get => SdkMemory.Read<bool >(Pointer+94); set { SdkMemory.Write(Pointer+94,value); } }
    [NativeMember("m_bSaveMenuActive")]
    public bool @SaveMenuActive { get => SdkMemory.Read<bool >(Pointer+95); set { SdkMemory.Write(Pointer+95,value); } }
    [NativeMember("m_bWantToLoad")]
    public bool @WantToLoad { get => SdkMemory.Read<bool >(Pointer+96); set { SdkMemory.Write(Pointer+96,value); } }
    [NativeMember("field_61")]
    public NativeArray<sbyte> @Field61 { get => new NativeArray<sbyte>(Pointer+97,3); }
    [NativeMember("m_fMapZoom")]
    public float @MapZoom { get => SdkMemory.Read<float >(Pointer+100); set { SdkMemory.Write(Pointer+100,value); } }
    [NativeMember("m_fMapBaseX")]
    public float @MapBaseX { get => SdkMemory.Read<float >(Pointer+104); set { SdkMemory.Write(Pointer+104,value); } }
    [NativeMember("m_fMapBaseY")]
    public float @MapBaseY { get => SdkMemory.Read<float >(Pointer+108); set { SdkMemory.Write(Pointer+108,value); } }
    [NativeMember("m_vMousePos")]
    public CVector2D @MousePosition { get => new CVector2D(Pointer+112); set { SdkMemory.Copy(value.Pointer,Pointer+112,8); } }
    [NativeMember("m_bStandardInput")]
    public bool @StandardInput { get => SdkMemory.Read<bool >(Pointer+120); set { SdkMemory.Write(Pointer+120,value); } }
    [NativeMember("field_79")]
    public NativeArray<sbyte> @Field79 { get => new NativeArray<sbyte>(Pointer+121,3); }
    [NativeMember("m_nTitleLanguage")]
    public int @TitleLanguage { get => SdkMemory.Read<int >(Pointer+124); set { SdkMemory.Write(Pointer+124,value); } }
    [NativeMember("m_nTextLanguage")]
    public int @TextLanguage { get => SdkMemory.Read<int >(Pointer+128); set { SdkMemory.Write(Pointer+128,value); } }
    [NativeMember("m_nPrefsLanguage")]
    public sbyte @PrefsLanguage { get => SdkMemory.Read<sbyte >(Pointer+132); set { SdkMemory.Write(Pointer+132,value); } }
    [NativeMember("m_nPrefsPrevLanguage")]
    public sbyte @PrefsPrevLanguage { get => SdkMemory.Read<sbyte >(Pointer+133); set { SdkMemory.Write(Pointer+133,value); } }
    [NativeMember("field_86")]
    public NativeArray<sbyte> @Field86 { get => new NativeArray<sbyte>(Pointer+134,2); }
    [NativeMember("field_88")]
    public int @Field88 { get => SdkMemory.Read<int >(Pointer+136); set { SdkMemory.Write(Pointer+136,value); } }
    [NativeMember("m_bLanguageLoaded")]
    public bool @LanguageLoaded { get => SdkMemory.Read<bool >(Pointer+140); set { SdkMemory.Write(Pointer+140,value); } }
    [NativeMember("field_8D")]
    public NativeArray<sbyte> @Field8D { get => new NativeArray<sbyte>(Pointer+141,3); }
    [NativeMember("field_90")]
    public int @Field90 { get => SdkMemory.Read<int >(Pointer+144); set { SdkMemory.Write(Pointer+144,value); } }
    [NativeMember("field_94")]
    public int @Field94 { get => SdkMemory.Read<int >(Pointer+148); set { SdkMemory.Write(Pointer+148,value); } }
    [NativeMember("m_pJPegBuffer")]
    public NativePointer<sbyte> @JPegBuffer { get => new NativePointer<sbyte>(SdkMemory.Read<IntPtr>(Pointer+152)); set { SdkMemory.Write(Pointer+152,value.Pointer); } }
    [NativeMember("field_9C")]
    public NativeArray<sbyte> @Field9C { get => new NativeArray<sbyte>(Pointer+156,16); }
    [NativeMember("field_AC")]
    public int @FieldAC { get => SdkMemory.Read<int >(Pointer+172); set { SdkMemory.Write(Pointer+172,value); } }
    [NativeMember("m_nPrefsRadioMode")]
    public sbyte @PrefsRadioMode { get => SdkMemory.Read<sbyte >(Pointer+176); set { SdkMemory.Write(Pointer+176,value); } }
    [NativeMember("m_bPrefsInvertPadX1")]
    public bool @PrefsInvertPadX1 { get => SdkMemory.Read<bool >(Pointer+177); set { SdkMemory.Write(Pointer+177,value); } }
    [NativeMember("m_bPrefsInvertPadY1")]
    public bool @PrefsInvertPadY1 { get => SdkMemory.Read<bool >(Pointer+178); set { SdkMemory.Write(Pointer+178,value); } }
    [NativeMember("m_bPrefsInvertPadX2")]
    public bool @PrefsInvertPadX2 { get => SdkMemory.Read<bool >(Pointer+179); set { SdkMemory.Write(Pointer+179,value); } }
    [NativeMember("m_bPrefsInvertPadY2")]
    public bool @PrefsInvertPadY2 { get => SdkMemory.Read<bool >(Pointer+180); set { SdkMemory.Write(Pointer+180,value); } }
    [NativeMember("m_bPrefsSwapPadAxis1")]
    public bool @PrefsSwapPadAxis1 { get => SdkMemory.Read<bool >(Pointer+181); set { SdkMemory.Write(Pointer+181,value); } }
    [NativeMember("m_bPrefsSwapPadAxis2")]
    public bool @PrefsSwapPadAxis2 { get => SdkMemory.Read<bool >(Pointer+182); set { SdkMemory.Write(Pointer+182,value); } }
    [NativeMember("m_bInVehicleControlsScreen")]
    public bool @InVehicleControlsScreen { get => SdkMemory.Read<bool >(Pointer+183); set { SdkMemory.Write(Pointer+183,value); } }
    [NativeMember("m_bShowMouse")]
    public bool @ShowMouse { get => SdkMemory.Read<bool >(Pointer+184); set { SdkMemory.Write(Pointer+184,value); } }
    [NativeMember("field_B9")]
    public NativeArray<sbyte> @FieldB9 { get => new NativeArray<sbyte>(Pointer+185,3); }
    [NativeMember("m_nMousePosX")]
    public int @MousePositionX { get => SdkMemory.Read<int >(Pointer+188); set { SdkMemory.Write(Pointer+188,value); } }
    [NativeMember("m_nMousePosY")]
    public int @MousePositionY { get => SdkMemory.Read<int >(Pointer+192); set { SdkMemory.Write(Pointer+192,value); } }
    [NativeMember("m_bPrefsMipMapping")]
    public bool @PrefsMipMapping { get => SdkMemory.Read<bool >(Pointer+196); set { SdkMemory.Write(Pointer+196,value); } }
    [NativeMember("m_bPrefsTracksAutoScan")]
    public bool @PrefsTracksAutoScan { get => SdkMemory.Read<bool >(Pointer+197); set { SdkMemory.Write(Pointer+197,value); } }
    [NativeMember("field_C6")]
    public short @FieldC6 { get => SdkMemory.Read<short >(Pointer+198); set { SdkMemory.Write(Pointer+198,value); } }
    [NativeMember("m_nPrefsAntiAliasing")]
    public int @PrefsAntiAliasing { get => SdkMemory.Read<int >(Pointer+200); set { SdkMemory.Write(Pointer+200,value); } }
    [NativeMember("m_nPrefsAntiAliasingDisp")]
    public int @PrefsAntiAliasingDisp { get => SdkMemory.Read<int >(Pointer+204); set { SdkMemory.Write(Pointer+204,value); } }
    [NativeMember("m_nController")]
    public sbyte @Controller { get => SdkMemory.Read<sbyte >(Pointer+208); set { SdkMemory.Write(Pointer+208,value); } }
    [NativeMember("field_D1")]
    public NativeArray<sbyte> @FieldD1 { get => new NativeArray<sbyte>(Pointer+209,3); }
    [NativeMember("m_nPrefsVideoMode")]
    public int @PrefsVideoMode { get => SdkMemory.Read<int >(Pointer+212); set { SdkMemory.Write(Pointer+212,value); } }
    [NativeMember("m_nDisplayVideoMode")]
    public int @DisplayVideoMode { get => SdkMemory.Read<int >(Pointer+216); set { SdkMemory.Write(Pointer+216,value); } }
    [NativeMember("field_DC")]
    public int @FieldDC { get => SdkMemory.Read<int >(Pointer+220); set { SdkMemory.Write(Pointer+220,value); } }
    [NativeMember("m_nMouseTempPosX")]
    public int @MouseTempPositionX { get => SdkMemory.Read<int >(Pointer+224); set { SdkMemory.Write(Pointer+224,value); } }
    [NativeMember("m_nMouseTempPosY")]
    public int @MouseTempPositionY { get => SdkMemory.Read<int >(Pointer+228); set { SdkMemory.Write(Pointer+228,value); } }
    [NativeMember("m_bPrefsSavePhotos")]
    public bool @PrefsSavePhotos { get => SdkMemory.Read<bool >(Pointer+232); set { SdkMemory.Write(Pointer+232,value); } }
    [NativeMember("m_bGameNotLoaded")]
    public bool @GameNotLoaded { get => SdkMemory.Read<bool >(Pointer+233); set { SdkMemory.Write(Pointer+233,value); } }
    [NativeMember("m_nPlayerNumber")]
    public sbyte @PlayerNumber { get => SdkMemory.Read<sbyte >(Pointer+234); set { SdkMemory.Write(Pointer+234,value); } }
    [NativeMember("m_bReinitLanguageSettings")]
    public bool @ReinitLanguageSettings { get => SdkMemory.Read<bool >(Pointer+235); set { SdkMemory.Write(Pointer+235,value); } }
    [NativeMember("field_EC")]
    public int @FieldEC { get => SdkMemory.Read<int >(Pointer+236); set { SdkMemory.Write(Pointer+236,value); } }
    [NativeMember("pControlEdit")]
    public NativePointer<int> @ControlEdit { get => new NativePointer<int>(SdkMemory.Read<IntPtr>(Pointer+240)); set { SdkMemory.Write(Pointer+240,value.Pointer); } }
    [NativeMember("m_bOnlySaveMenu")]
    public bool @OnlySaveMenu { get => SdkMemory.Read<bool >(Pointer+244); set { SdkMemory.Write(Pointer+244,value); } }
    [NativeMember("field_F5")]
    public NativeArray<sbyte> @FieldF5 { get => new NativeArray<sbyte>(Pointer+245,3); }
    [NativeMember("FrontEndSprites")]
    public NativeObjectArray<CSprite2d> @FrontEndSprites { get => new NativeObjectArray<CSprite2d>(Pointer+248,25,4); }
    [NativeMember("m_bTexturesLoaded")]
    public bool @TexturesLoaded { get => SdkMemory.Read<bool >(Pointer+348); set { SdkMemory.Write(Pointer+348,value); } }
    [NativeMember("m_nCurrentMenuPage")]
    public sbyte @CurrentMenuPage { get => SdkMemory.Read<sbyte >(Pointer+349); set { SdkMemory.Write(Pointer+349,value); } }
    [NativeMember("m_nPreviousMenuPage")]
    public sbyte @PreviousMenuPage { get => SdkMemory.Read<sbyte >(Pointer+350); set { SdkMemory.Write(Pointer+350,value); } }
    [NativeMember("m_nSelectedSaveGame")]
    public sbyte @SelectedSaveGame { get => SdkMemory.Read<sbyte >(Pointer+351); set { SdkMemory.Write(Pointer+351,value); } }
    [NativeMember("m_nSelectedMissionPack")]
    public sbyte @SelectedMissionPack { get => SdkMemory.Read<sbyte >(Pointer+352); set { SdkMemory.Write(Pointer+352,value); } }
    [NativeMember("m_MissionPacks")]
    public NativeObjectArray<CMenuManager__MissionPackStruct> @MissionPacks { get => new NativeObjectArray<CMenuManager__MissionPackStruct>(Pointer+353,25,261); }
    [NativeMember("m_bChangeVideoMode")]
    public bool @ChangeVideoMode { get => SdkMemory.Read<bool >(Pointer+6878); set { SdkMemory.Write(Pointer+6878,value); } }
    [NativeMember("field_1ADF")]
    public sbyte @Field1ADF { get => SdkMemory.Read<sbyte >(Pointer+6879); set { SdkMemory.Write(Pointer+6879,value); } }
    [NativeMember("field_1AE0")]
    public int @Field1AE0 { get => SdkMemory.Read<int >(Pointer+6880); set { SdkMemory.Write(Pointer+6880,value); } }
    [NativeMember("field_1AE4")]
    public int @Field1AE4 { get => SdkMemory.Read<int >(Pointer+6884); set { SdkMemory.Write(Pointer+6884,value); } }
    [NativeMember("field_1AE8")]
    public sbyte @Field1AE8 { get => SdkMemory.Read<sbyte >(Pointer+6888); set { SdkMemory.Write(Pointer+6888,value); } }
    [NativeMember("m_bAudioRetuneInProgress")]
    public bool @AudioRetuneInProgress { get => SdkMemory.Read<bool >(Pointer+6889); set { SdkMemory.Write(Pointer+6889,value); } }
    [NativeMember("field_1AEA")]
    public sbyte @Field1AEA { get => SdkMemory.Read<sbyte >(Pointer+6890); set { SdkMemory.Write(Pointer+6890,value); } }
    [NativeMember("m_bScanningUserTracks")]
    public bool @ScanningUserTracks { get => SdkMemory.Read<bool >(Pointer+6891); set { SdkMemory.Write(Pointer+6891,value); } }
    [NativeMember("m_nHelperTextFadingAlpha")]
    public int @HelperTextFadingAlpha { get => SdkMemory.Read<int >(Pointer+6892); set { SdkMemory.Write(Pointer+6892,value); } }
    [NativeMember("field_1AF0")]
    public sbyte @Field1AF0 { get => SdkMemory.Read<sbyte >(Pointer+6896); set { SdkMemory.Write(Pointer+6896,value); } }
    [NativeMember("field_1AF1")]
    public sbyte @Field1AF1 { get => SdkMemory.Read<sbyte >(Pointer+6897); set { SdkMemory.Write(Pointer+6897,value); } }
    [NativeMember("field_1AF2")]
    public sbyte @Field1AF2 { get => SdkMemory.Read<sbyte >(Pointer+6898); set { SdkMemory.Write(Pointer+6898,value); } }
    [NativeMember("field_1AF3")]
    public sbyte @Field1AF3 { get => SdkMemory.Read<sbyte >(Pointer+6899); set { SdkMemory.Write(Pointer+6899,value); } }
    [NativeMember("field_1AF4")]
    public int @Field1AF4 { get => SdkMemory.Read<int >(Pointer+6900); set { SdkMemory.Write(Pointer+6900,value); } }
    [NativeMember("m_nMouseOldPosX")]
    public int @MouseOldPositionX { get => SdkMemory.Read<int >(Pointer+6904); set { SdkMemory.Write(Pointer+6904,value); } }
    [NativeMember("m_nMouseOldPosY")]
    public int @MouseOldPositionY { get => SdkMemory.Read<int >(Pointer+6908); set { SdkMemory.Write(Pointer+6908,value); } }
    [NativeMember("m_nHoverOption")]
    public int @HoverOption { get => SdkMemory.Read<int >(Pointer+6912); set { SdkMemory.Write(Pointer+6912,value); } }
    [NativeMember("field_1B04")]
    public int @Field1B04 { get => SdkMemory.Read<int >(Pointer+6916); set { SdkMemory.Write(Pointer+6916,value); } }
    [NativeMember("field_1B08")]
    public sbyte @Field1B08 { get => SdkMemory.Read<sbyte >(Pointer+6920); set { SdkMemory.Write(Pointer+6920,value); } }
    [NativeMember("field_1B09")]
    public sbyte @Field1B09 { get => SdkMemory.Read<sbyte >(Pointer+6921); set { SdkMemory.Write(Pointer+6921,value); } }
    [NativeMember("field_1B0A")]
    public sbyte @Field1B0A { get => SdkMemory.Read<sbyte >(Pointer+6922); set { SdkMemory.Write(Pointer+6922,value); } }
    [NativeMember("field_1B0B")]
    public sbyte @Field1B0B { get => SdkMemory.Read<sbyte >(Pointer+6923); set { SdkMemory.Write(Pointer+6923,value); } }
    [NativeMember("field_1B0C")]
    public int @Field1B0C { get => SdkMemory.Read<int >(Pointer+6924); set { SdkMemory.Write(Pointer+6924,value); } }
    [NativeMember("field_1B10")]
    public sbyte @Field1B10 { get => SdkMemory.Read<sbyte >(Pointer+6928); set { SdkMemory.Write(Pointer+6928,value); } }
    [NativeMember("field_1B11")]
    public sbyte @Field1B11 { get => SdkMemory.Read<sbyte >(Pointer+6929); set { SdkMemory.Write(Pointer+6929,value); } }
    [NativeMember("field_1B12")]
    public sbyte @Field1B12 { get => SdkMemory.Read<sbyte >(Pointer+6930); set { SdkMemory.Write(Pointer+6930,value); } }
    [NativeMember("field_1B13")]
    public sbyte @Field1B13 { get => SdkMemory.Read<sbyte >(Pointer+6931); set { SdkMemory.Write(Pointer+6931,value); } }
    [NativeMember("field_1B14")]
    public sbyte @Field1B14 { get => SdkMemory.Read<sbyte >(Pointer+6932); set { SdkMemory.Write(Pointer+6932,value); } }
    [NativeMember("field_1B15")]
    public sbyte @Field1B15 { get => SdkMemory.Read<sbyte >(Pointer+6933); set { SdkMemory.Write(Pointer+6933,value); } }
    [NativeMember("field_1B16")]
    public sbyte @Field1B16 { get => SdkMemory.Read<sbyte >(Pointer+6934); set { SdkMemory.Write(Pointer+6934,value); } }
    [NativeMember("field_1B17")]
    public sbyte @Field1B17 { get => SdkMemory.Read<sbyte >(Pointer+6935); set { SdkMemory.Write(Pointer+6935,value); } }
    [NativeMember("m_nHelperTextIndex")]
    public int @HelperTextIndex { get => SdkMemory.Read<int >(Pointer+6936); set { SdkMemory.Write(Pointer+6936,value); } }
    [NativeMember("field_1B1C")]
    public int @Field1B1C { get => SdkMemory.Read<int >(Pointer+6940); set { SdkMemory.Write(Pointer+6940,value); } }
    [NativeMember("m_nTexturesRound")]
    public byte @TexturesRound { get => SdkMemory.Read<byte >(Pointer+6944); set { SdkMemory.Write(Pointer+6944,value); } }
    [NativeMember("m_nNumberOfMenuOptions")]
    public byte @NumberOfMenuOptions { get => SdkMemory.Read<byte >(Pointer+6945); set { SdkMemory.Write(Pointer+6945,value); } }
    [NativeMember("field_1B22")]
    public short @Field1B22 { get => SdkMemory.Read<short >(Pointer+6946); set { SdkMemory.Write(Pointer+6946,value); } }
    [NativeMember("m_nStatBarPerformanceTimer")]
    public int @StatBarPerformanceTimer { get => SdkMemory.Read<int >(Pointer+6948); set { SdkMemory.Write(Pointer+6948,value); } }
    [NativeMember("m_bUpdateMap")]
    public bool @UpdateMap { get => SdkMemory.Read<bool >(Pointer+6952); set { SdkMemory.Write(Pointer+6952,value); } }
    [NativeMember("field_1B29")]
    public sbyte @Field1B29 { get => SdkMemory.Read<sbyte >(Pointer+6953); set { SdkMemory.Write(Pointer+6953,value); } }
    [NativeMember("field_1B2A")]
    public short @Field1B2A { get => SdkMemory.Read<short >(Pointer+6954); set { SdkMemory.Write(Pointer+6954,value); } }
    [NativeMember("m_nMapTimer")]
    public int @MapTimer { get => SdkMemory.Read<int >(Pointer+6956); set { SdkMemory.Write(Pointer+6956,value); } }
    [NativeMember("m_nBriefHistoryTimer")]
    public int @BriefHistoryTimer { get => SdkMemory.Read<int >(Pointer+6960); set { SdkMemory.Write(Pointer+6960,value); } }
    [NativeMember("m_nSavedPlayerControlsDisabledFlag")]
    public short @SavedPlayerControlsDisabledFlag { get => SdkMemory.Read<short >(Pointer+6964); set { SdkMemory.Write(Pointer+6964,value); } }
    [NativeMember("field_1B36")]
    public short @Field1B36 { get => SdkMemory.Read<short >(Pointer+6966); set { SdkMemory.Write(Pointer+6966,value); } }
    [NativeMember("field_1B38")]
    public int @Field1B38 { get => SdkMemory.Read<int >(Pointer+6968); set { SdkMemory.Write(Pointer+6968,value); } }
    [NativeMember("field_1B3C")]
    public sbyte @Field1B3C { get => SdkMemory.Read<sbyte >(Pointer+6972); set { SdkMemory.Write(Pointer+6972,value); } }
    [NativeMember("field_1B3D")]
    public sbyte @Field1B3D { get => SdkMemory.Read<sbyte >(Pointer+6973); set { SdkMemory.Write(Pointer+6973,value); } }
    [NativeMember("field_1B3E")]
    public sbyte @Field1B3E { get => SdkMemory.Read<sbyte >(Pointer+6974); set { SdkMemory.Write(Pointer+6974,value); } }
    [NativeMember("field_1B3F")]
    public sbyte @Field1B3F { get => SdkMemory.Read<sbyte >(Pointer+6975); set { SdkMemory.Write(Pointer+6975,value); } }
    [NativeMember("field_1B40")]
    public int @Field1B40 { get => SdkMemory.Read<int >(Pointer+6976); set { SdkMemory.Write(Pointer+6976,value); } }
    [NativeMember("m_bExitMenu")]
    public bool @ExitMenu { get => SdkMemory.Read<bool >(Pointer+6980); set { SdkMemory.Write(Pointer+6980,value); } }
    [NativeMember("field_1B45")]
    public sbyte @Field1B45 { get => SdkMemory.Read<sbyte >(Pointer+6981); set { SdkMemory.Write(Pointer+6981,value); } }
    [NativeMember("field_1B46")]
    public short @Field1B46 { get => SdkMemory.Read<short >(Pointer+6982); set { SdkMemory.Write(Pointer+6982,value); } }
    [NativeMember("field_1B48")]
    public int @Field1B48 { get => SdkMemory.Read<int >(Pointer+6984); set { SdkMemory.Write(Pointer+6984,value); } }
    [NativeMember("field_1B4C")]
    public int @Field1B4C { get => SdkMemory.Read<int >(Pointer+6988); set { SdkMemory.Write(Pointer+6988,value); } }
    [NativeMember("m_nBackgroundSprite")]
    public sbyte @BackgroundSprite { get => SdkMemory.Read<sbyte >(Pointer+6992); set { SdkMemory.Write(Pointer+6992,value); } }
    [NativeMember("field_1B51")]
    public sbyte @Field1B51 { get => SdkMemory.Read<sbyte >(Pointer+6993); set { SdkMemory.Write(Pointer+6993,value); } }
    [NativeMember("field_1B52")]
    public short @Field1B52 { get => SdkMemory.Read<short >(Pointer+6994); set { SdkMemory.Write(Pointer+6994,value); } }
    [NativeMember("field_1B54")]
    public int @Field1B54 { get => SdkMemory.Read<int >(Pointer+6996); set { SdkMemory.Write(Pointer+6996,value); } }
    [NativeMember("m_nHelperTextFadingTimer")]
    public int @HelperTextFadingTimer { get => SdkMemory.Read<int >(Pointer+7000); set { SdkMemory.Write(Pointer+7000,value); } }
    [NativeMember("field_1B5C")]
    public sbyte @Field1B5C { get => SdkMemory.Read<sbyte >(Pointer+7004); set { SdkMemory.Write(Pointer+7004,value); } }
    [NativeMember("field_1B5D")]
    public sbyte @Field1B5D { get => SdkMemory.Read<sbyte >(Pointer+7005); set { SdkMemory.Write(Pointer+7005,value); } }
    [NativeMember("field_1B5E")]
    public short @Field1B5E { get => SdkMemory.Read<short >(Pointer+7006); set { SdkMemory.Write(Pointer+7006,value); } }
    [NativeMember("field_1B60")]
    public int @Field1B60 { get => SdkMemory.Read<int >(Pointer+7008); set { SdkMemory.Write(Pointer+7008,value); } }
    [NativeMember("field_1B64")]
    public int @Field1B64 { get => SdkMemory.Read<int >(Pointer+7012); set { SdkMemory.Write(Pointer+7012,value); } }
    [NativeMember("m_nTimeSlideLeftMove")]
    public int @TimeSlideLeftMove { get => SdkMemory.Read<int >(Pointer+7016); set { SdkMemory.Write(Pointer+7016,value); } }
    [NativeMember("m_nTimeSlideRightMove")]
    public int @TimeSlideRightMove { get => SdkMemory.Read<int >(Pointer+7020); set { SdkMemory.Write(Pointer+7020,value); } }
    [NativeMember("field_1B70")]
    public int @Field1B70 { get => SdkMemory.Read<int >(Pointer+7024); set { SdkMemory.Write(Pointer+7024,value); } }
    [NativeMember("field_1B74")]
    public int @Field1B74 { get => SdkMemory.Read<int >(Pointer+7028); set { SdkMemory.Write(Pointer+7028,value); } }
    [NativeMember("nLastMenuPage")]
    public static int @LastMenuPage { get => SdkMemory.Read<int >(new IntPtr(0x8CDFF0)); set { SdkMemory.Write(new IntPtr(0x8CDFF0),value); } }
    [NativeMember("bInvertMouseX")]
    public static bool @InvertMouseX { get => SdkMemory.Read<bool >(new IntPtr(0xBA6744)); set { SdkMemory.Write(new IntPtr(0xBA6744),value); } }
    [NativeMember("bInvertMouseY")]
    public static bool @InvertMouseY { get => SdkMemory.Read<bool >(new IntPtr(0xBA6745)); set { SdkMemory.Write(new IntPtr(0xBA6745),value); } }
    public void @InitializeAt() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3068 >(3068)(Pointer); }
    public void @DestroyNative() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3069 >(3069)(Pointer); }
    public sbyte @AdditionalOptionInput(sbyte @input,sbyte @enter) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3070 >(3070)(Pointer,@input,@enter); return __sdkResult; }
    public void @CentreMousePointer() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3071 >(3071)(Pointer); }
    public bool @CheckCodesForControls(int @code) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3072 >(3072)(Pointer,@code); return __sdkResult != 0; }
    public bool @CheckFrontEndDownInput() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3073 >(3073)(Pointer); return __sdkResult != 0; }
    public bool @CheckFrontEndLeftInput() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3074 >(3074)(Pointer); return __sdkResult != 0; }
    public bool @CheckFrontEndRightInput() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3075 >(3075)(Pointer); return __sdkResult != 0; }
    public bool @CheckFrontEndUpInput() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3076 >(3076)(Pointer); return __sdkResult != 0; }
    public bool @CheckHover(float @x1,float @x2,float @y1,float @y2) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3077 >(3077)(Pointer,@x1,@x2,@y1,@y2); return __sdkResult != 0; }
    public bool @CheckMissionPackValidMenu() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3078 >(3078)(Pointer); return __sdkResult != 0; }
    public bool @CheckRedefineControlInput() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3079 >(3079)(Pointer); return __sdkResult != 0; }
    public void @CheckSliderMovement(float @input) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3080 >(3080)(Pointer,@input); }
    public void @DisplayHelperText(NativePointer<sbyte> @text) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3081 >(3081)(Pointer,@text.Pointer); }
    public int @DisplaySlider(float @posX,float @posY,float @beginHeight,float @endHeight,float @distBetweenRects,float @filledAmount,CRGBA @colour) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3082 >(3082)(Pointer,@posX,@posY,@beginHeight,@endHeight,@distBetweenRects,@filledAmount,@colour.Pointer); return __sdkResult; }
    public int @DoSettingsBeforeStartingAGame() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3083 >(3083)(Pointer); return __sdkResult; }
    public sbyte @DrawBackground() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3084 >(3084)(Pointer); return __sdkResult; }
    public sbyte @DrawControllerScreenExtraText(int @unk) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3085 >(3085)(Pointer,@unk); return __sdkResult; }
    public sbyte @DrawControllerSetupScreen() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3086 >(3086)(Pointer); return __sdkResult; }
    public void @DrawFrontEnd() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3087 >(3087)(Pointer); }
    public void @DrawQuitGameScreen(int @unused) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3088 >(3088)(Pointer,@unused); }
    public void @DrawStandardMenu(bool @header) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3089 >(3089)(Pointer,(@header ? 1 : 0)); }
    public void @DrawWindow(CRect @coords,NativePointer<sbyte> @pKey,byte @nColour,CRGBA @backColor,bool @Unused,bool @bBackground) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3090 >(3090)(Pointer,@coords.Pointer,@pKey.Pointer,@nColour,@backColor.Pointer,(@Unused ? 1 : 0),(@bBackground ? 1 : 0)); }
    public void @DrawWindowedText(float @x1,float @y1,float @x2,float @y2,NativePointer<sbyte> @gxt,int @align) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3091 >(3091)(Pointer,@x1,@y1,@x2,@y2,@gxt.Pointer,@align); }
    public byte @GetNumberOfMenuOptions() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3092 >(3092)(Pointer); return __sdkResult; }
    public bool @HasLanguageChanged() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3093 >(3093)(Pointer); return __sdkResult != 0; }
    public void @Initialise() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3094 >(3094)(Pointer); }
    public void @InitialiseChangedLanguageSettings(bool @reInitControls) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3095 >(3095)(Pointer,(@reInitControls ? 1 : 0)); }
    public int @JumpToGenericMessageScreen(sbyte @screen,NativePointer<sbyte> @header,NativePointer<sbyte> @action) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3096 >(3096)(Pointer,@screen,@header.Pointer,@action.Pointer); return __sdkResult; }
    public void @LoadAllTextures() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3097 >(3097)(Pointer); }
    public void @LoadSettings() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3098 >(3098)(Pointer); }
    public void @MessageScreen(NativePointer<sbyte> @message,CRGBA @col,bool @frame) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3099 >(3099)(Pointer,@message.Pointer,@col.Pointer,(@frame ? 1 : 0)); }
    public float @PrintBriefs() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3100 >(3100)(Pointer); return __sdkResult; }
    public sbyte @PrintMap() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3101 >(3101)(Pointer); return __sdkResult; }
    public sbyte @PrintRadioStationList() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3102 >(3102)(Pointer); return __sdkResult; }
    public sbyte @PrintStats() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3103 >(3103)(Pointer); return __sdkResult; }
    public int @Process() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3104 >(3104)(Pointer); return __sdkResult; }
    public void @ProcessFileActions() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3105 >(3105)(Pointer); }
    public void @ProcessMenuOptions(sbyte @input,NativePointer<sbyte> @exit,sbyte @enter) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3106 >(3106)(Pointer,@input,@exit.Pointer,@enter); }
    public void @ProcessMissionPackNewGame() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3107 >(3107)(Pointer); }
    public sbyte @ProcessPCMenuOptions(sbyte @input,sbyte @enter) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3108 >(3108)(Pointer,@input,@enter); return __sdkResult; }
    public void @ProcessStreaming(bool @all) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3109 >(3109)(Pointer,(@all ? 1 : 0)); }
    public void @ProcessUserInput(sbyte @down,sbyte @up,sbyte @enter,sbyte @exit,sbyte @input) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3110 >(3110)(Pointer,@down,@up,@enter,@exit,@input); }
    public sbyte @RedefineScreenUserInput(int @enter,int @exit) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3111 >(3111)(Pointer,@enter,@exit); return __sdkResult; }
    public void @ResetHelperText() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3112 >(3112)(Pointer); }
    public void @SaveLoadFileError_SetUpErrorScreen() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3113 >(3113)(Pointer); }
    public void @SaveSettings() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3114 >(3114)(Pointer); }
    public int @SaveStatsToFile() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3115 >(3115)(Pointer); return __sdkResult; }
    public void @ScrollRadioStations(sbyte @input) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3116 >(3116)(Pointer,@input); }
    public sbyte @SetDefaultPreferences(sbyte @page) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3117 >(3117)(Pointer,@page); return __sdkResult; }
    public void @SetFrontEndRenderStates() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3118 >(3118)(Pointer); }
    public int @SetHelperText(int @index) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3119 >(3119)(Pointer,@index); return __sdkResult; }
    public void @SmallMessageScreen(NativePointer<sbyte> @message) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3120 >(3120)(Pointer,@message.Pointer); }
    public float @StretchX(float @x) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3121 >(3121)(Pointer,@x); return __sdkResult; }
    public float @StretchY(float @y) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3122 >(3122)(Pointer,@y); return __sdkResult; }
    public void @SwapTexturesRound(bool @force) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3123 >(3123)(Pointer,(@force ? 1 : 0)); }
    public void @SwitchMenuOnAndOff() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3124 >(3124)(Pointer); }
    public sbyte @SwitchToNewScreen(sbyte @page) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3125 >(3125)(Pointer,@page); return __sdkResult; }
    public void @UnloadTextures() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3126 >(3126)(Pointer); }
    public void @UserInput() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3127 >(3127)(Pointer); }
    public void @RequestFrontEndShutDown() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3128 >(3128)(Pointer); }
    public void @RequestFrontEndStartUp() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3129 >(3129)(Pointer); }
}
