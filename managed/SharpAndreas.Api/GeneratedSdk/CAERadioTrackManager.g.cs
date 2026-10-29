// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CAERadioTrackManager : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=880;
    public CAERadioTrackManager(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_bStationChangePending")]
    public byte @StationChangePending { get => SdkMemory.Read<byte >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("m_bDisplayNewStationName")]
    public byte @DisplayNewStationName { get => SdkMemory.Read<byte >(Pointer+1); set { SdkMemory.Write(Pointer+1,value); } }
    [NativeMember("m_bReadyToRetune")]
    public byte @ReadyToRetune { get => SdkMemory.Read<byte >(Pointer+2); set { SdkMemory.Write(Pointer+2,value); } }
    [NativeMember("m_bPlayRadioDuringPause")]
    public byte @PlayRadioDuringPause { get => SdkMemory.Read<byte >(Pointer+3); set { SdkMemory.Write(Pointer+3,value); } }
    [NativeMember("m_bUseBassEnhance")]
    public byte @UseBassEnhance { get => SdkMemory.Read<byte >(Pointer+4); set { SdkMemory.Write(Pointer+4,value); } }
    [NativeMember("m_bPausedLastFrame")]
    public byte @PausedLastFrame { get => SdkMemory.Read<byte >(Pointer+5); set { SdkMemory.Write(Pointer+5,value); } }
    [NativeMember("m_bRetuneStartedThisFrame")]
    public byte @RetuneStartedThisFrame { get => SdkMemory.Read<byte >(Pointer+6); set { SdkMemory.Write(Pointer+6,value); } }
    [NativeMember("m_bUseRadioAutoRetune")]
    public byte @UseRadioAutoRetune { get => SdkMemory.Read<byte >(Pointer+7); set { SdkMemory.Write(Pointer+7,value); } }
    [NativeMember("m_nTracksSinceLastAdvertOrDJList")]
    public NativeArray<sbyte> @TracksSinceLastAdvertOrDJList { get => new NativeArray<sbyte>(Pointer+8,14); }
    [NativeMember("m_nLastVehicleExitGameClockDays")]
    public sbyte @LastVehicleExitGameClockDays { get => SdkMemory.Read<sbyte >(Pointer+22); set { SdkMemory.Write(Pointer+22,value); } }
    [NativeMember("m_nLastVehicleExitGameClockHours")]
    public sbyte @LastVehicleExitGameClockHours { get => SdkMemory.Read<sbyte >(Pointer+23); set { SdkMemory.Write(Pointer+23,value); } }
    [NativeMember("m_nStationListenTimes")]
    public NativeArray<int> @StationListenTimes { get => new NativeArray<int>(Pointer+24,14); }
    [NativeMember("m_nLastRetuneTimeMs")]
    public uint @LastRetuneTimeMs { get => SdkMemory.Read<uint >(Pointer+80); set { SdkMemory.Write(Pointer+80,value); } }
    [NativeMember("m_nStationNameDisplayEndTimeMs")]
    public uint @StationNameDisplayEndTimeMs { get => SdkMemory.Read<uint >(Pointer+84); set { SdkMemory.Write(Pointer+84,value); } }
    [NativeMember("m_nLastVehicleExitTimeMs")]
    public uint @LastVehicleExitTimeMs { get => SdkMemory.Read<uint >(Pointer+88); set { SdkMemory.Write(Pointer+88,value); } }
    [NativeMember("m_nRetuneTimeMs")]
    public uint @RetuneTimeMs { get => SdkMemory.Read<uint >(Pointer+92); set { SdkMemory.Write(Pointer+92,value); } }
    [NativeMember("m_nLastPlayStartTimeMs")]
    public uint @LastPlayStartTimeMs { get => SdkMemory.Read<uint >(Pointer+96); set { SdkMemory.Write(Pointer+96,value); } }
    [NativeMember("m_nHardwareClientHandle")]
    public int @HardwareClientHandle { get => SdkMemory.Read<int >(Pointer+100); set { SdkMemory.Write(Pointer+100,value); } }
    [NativeMember("m_nRadioStatus")]
    public int @RadioStatus { get => SdkMemory.Read<int >(Pointer+104); set { SdkMemory.Write(Pointer+104,value); } }
    [NativeMember("m_nRetunesPending")]
    public int @RetunesPending { get => SdkMemory.Read<int >(Pointer+108); set { SdkMemory.Write(Pointer+108,value); } }
    [NativeMember("m_nPreviousRetunesPending")]
    public int @PreviousRetunesPending { get => SdkMemory.Read<int >(Pointer+112); set { SdkMemory.Write(Pointer+112,value); } }
    [NativeMember("m_nLastVehicleStationID")]
    public int @LastVehicleStationID { get => SdkMemory.Read<int >(Pointer+116); set { SdkMemory.Write(Pointer+116,value); } }
    [NativeMember("m_nRetuneStationID")]
    public int @RetuneStationID { get => SdkMemory.Read<int >(Pointer+120); set { SdkMemory.Write(Pointer+120,value); } }
    [NativeMember("m_nScriptRetuneStationID")]
    public int @ScriptRetuneStationID { get => SdkMemory.Read<int >(Pointer+124); set { SdkMemory.Write(Pointer+124,value); } }
    [NativeMember("m_fDialogueRadioDuckingVolume")]
    public float @DialogueRadioDuckingVolume { get => SdkMemory.Read<float >(Pointer+128); set { SdkMemory.Write(Pointer+128,value); } }
    [NativeMember("m_fDialogueRadioDuckingReleaseStep")]
    public float @DialogueRadioDuckingReleaseStep { get => SdkMemory.Read<float >(Pointer+132); set { SdkMemory.Write(Pointer+132,value); } }
    [NativeMember("m_RequestedSettings")]
    public tRadioSettings @RequestedSettings { get => new tRadioSettings(Pointer+136); set { SdkMemory.Copy(value.Pointer,Pointer+136,60); } }
    [NativeMember("m_ActiveSettings")]
    public tRadioSettings @ActiveSettings { get => new tRadioSettings(Pointer+196); set { SdkMemory.Copy(value.Pointer,Pointer+196,60); } }
    [NativeMember("m_StationTrackingList")]
    public NativeObjectArray<tRadioStationTracking> @StationTrackingList { get => new NativeObjectArray<tRadioStationTracking>(Pointer+256,14,44); }
    [NativeMember("m_numInvalidTracks")]
    public uint @CountInvalidTracks { get => SdkMemory.Read<uint >(Pointer+872); set { SdkMemory.Write(Pointer+872,value); } }
    [NativeMember("m_lastRadioMode")]
    public sbyte @LastRadioMode { get => SdkMemory.Read<sbyte >(Pointer+876); set { SdkMemory.Write(Pointer+876,value); } }
    [NativeMember("m_nMusicTrackIndexHistory")]
    public static tMusicTrackHistory? @MusicTrackIndexHistory { get => new IntPtr(0xB62B40) == IntPtr.Zero ? null : new tMusicTrackHistory(new IntPtr(0xB62B40)); }
    public bool @IsVehicleRadioActive() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D266 >(266)(Pointer); return __sdkResult != 0; }
    public NativePointer<sbyte> @GetRadioStationName(sbyte @id) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D267 >(267)(Pointer,@id); return new NativePointer<sbyte>(__sdkResult); }
    public void @StartRadio(int @stationId,float @bass,int @arg,sbyte @unused) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D268 >(268)(Pointer,@stationId,@bass,@arg,@unused); }
    public void @StopRadio(tVehicleAudioSettings? @settings,sbyte @arg) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D269 >(269)(Pointer,@settings?.Pointer ?? IntPtr.Zero,@arg); }
    public static void @Load() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D270 >(270)(); }
    public static void @Save() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D271 >(271)(); }
}
