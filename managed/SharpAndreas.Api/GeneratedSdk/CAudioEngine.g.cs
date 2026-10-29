// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CAudioEngine : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=8152;
    public CAudioEngine(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("field_0")]
    public sbyte @Field0 { get => SdkMemory.Read<sbyte >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("field_1")]
    public sbyte @Field1 { get => SdkMemory.Read<sbyte >(Pointer+1); set { SdkMemory.Write(Pointer+1,value); } }
    [NativeMember("m_nCurrentRadiostationId")]
    public sbyte @CurrentRadiostationId { get => SdkMemory.Read<sbyte >(Pointer+2); set { SdkMemory.Write(Pointer+2,value); } }
    [NativeMember("field_3")]
    public sbyte @Field3 { get => SdkMemory.Read<sbyte >(Pointer+3); set { SdkMemory.Write(Pointer+3,value); } }
    [NativeMember("field_4")]
    public int @Field4 { get => SdkMemory.Read<int >(Pointer+4); set { SdkMemory.Write(Pointer+4,value); } }
    [NativeMember("field_8")]
    public NativeArray<sbyte> @Field8 { get => new NativeArray<sbyte>(Pointer+8,152); }
    [NativeMember("field_A0")]
    public sbyte @FieldA0 { get => SdkMemory.Read<sbyte >(Pointer+160); set { SdkMemory.Write(Pointer+160,value); } }
    [NativeMember("field_A1")]
    public NativeArray<sbyte> @FieldA1 { get => new NativeArray<sbyte>(Pointer+161,15); }
    [NativeMember("field_B0")]
    public sbyte @FieldB0 { get => SdkMemory.Read<sbyte >(Pointer+176); set { SdkMemory.Write(Pointer+176,value); } }
    [NativeMember("field_B1")]
    public NativeArray<sbyte> @FieldB1 { get => new NativeArray<sbyte>(Pointer+177,3); }
    [NativeMember("m_FrontendAudio")]
    public CAEFrontendAudioEntity @FrontendAudio { get => new CAEFrontendAudioEntity(Pointer+180); set { SdkMemory.Copy(value.Pointer,Pointer+180,156); } }
    [NativeMember("field_150")]
    public CAETwinLoopSoundEntity @Field150 { get => new CAETwinLoopSoundEntity(Pointer+336); set { SdkMemory.Copy(value.Pointer,Pointer+336,168); } }
    [NativeMember("field_1F8")]
    public CAETwinLoopSoundEntity @Field1F8 { get => new CAETwinLoopSoundEntity(Pointer+504); set { SdkMemory.Copy(value.Pointer,Pointer+504,168); } }
    [NativeMember("m_scriptAudio")]
    public CAEScriptAudioEntity @ScriptAudio { get => new CAEScriptAudioEntity(Pointer+672); set { SdkMemory.Copy(value.Pointer,Pointer+672,540); } }
    [NativeMember("m_collisionAudio")]
    public CAECollisionAudioEntity @CollisionAudio { get => new CAECollisionAudioEntity(Pointer+1212); set { SdkMemory.Copy(value.Pointer,Pointer+1212,6520); } }
    [NativeMember("m_pWeaponAudio")]
    public int @WeaponAudio { get => SdkMemory.Read<int >(Pointer+7732); set { SdkMemory.Write(Pointer+7732,value); } }
    [NativeMember("m_pedlessSpeechAudio")]
    public CAEPedlessSpeechAudioEntity @PedlessSpeechAudio { get => new CAEPedlessSpeechAudioEntity(Pointer+7736); set { SdkMemory.Copy(value.Pointer,Pointer+7736,256); } }
    [NativeMember("field_1F38")]
    public NativeArray<sbyte> @Field1F38 { get => new NativeArray<sbyte>(Pointer+7992,24); }
    [NativeMember("m_doorAudio")]
    public CAEDoorAudioEntity @DoorAudio { get => new CAEDoorAudioEntity(Pointer+8016); set { SdkMemory.Copy(value.Pointer,Pointer+8016,136); } }
    public void @Initialise() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D700 >(700)(Pointer); }
    public void @Restart() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D701 >(701)(Pointer); }
    public void @Shutdown() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D702 >(702)(Pointer); }
    public void @SetEffectsMasterVolume(sbyte @volume) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D703 >(703)(Pointer,@volume); }
    public void @SetMusicMasterVolume(sbyte @volume) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D704 >(704)(Pointer,@volume); }
    public void @SetBassEnhanceOnOff(bool @on) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D705 >(705)(Pointer,(@on ? 1 : 0)); }
    public void @SetRadioAutoRetuneOnOff(bool @on) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D706 >(706)(Pointer,(@on ? 1 : 0)); }
    public void @RetuneRadio(sbyte @stationId) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D707 >(707)(Pointer,@stationId); }
    public CReference? @ReportFrontendAudioEvent(int @id,float @volume,float @speed) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D708 >(708)(Pointer,@id,@volume,@speed); return __sdkResult == IntPtr.Zero ? null : new CReference(__sdkResult); }
    public void @ReportMissionAudioEvent(eAudioEvents @audioEvent,CVector? @coords) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D709 >(709)(Pointer,(int)@audioEvent,@coords?.Pointer ?? IntPtr.Zero); }
    public void @Service() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D710 >(710)(Pointer); }
    public void @ServiceLoadingTune(float @fade) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D711 >(711)(Pointer,@fade); }
    public void @StartRadio(int @radioStation,sbyte @arg) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D712 >(712)(Pointer,@radioStation,@arg); }
    public void @StopRadio(tVehicleAudioSettings? @settings,bool @arg) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D713 >(713)(Pointer,@settings?.Pointer ?? IntPtr.Zero,(@arg ? 1 : 0)); }
    public bool @IsRadioRetuneInProgress() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D714 >(714)(Pointer); return __sdkResult != 0; }
    public bool @IsLoadingTuneActive() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D715 >(715)(Pointer); return __sdkResult != 0; }
    public bool @IsRadioOn() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D716 >(716)(Pointer); return __sdkResult != 0; }
    public bool @IsAmbienceTrackActive() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D717 >(717)(Pointer); return __sdkResult != 0; }
    public bool @StartLoadingTune() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D718 >(718)(Pointer); return __sdkResult != 0; }
    public sbyte @GetCurrentRadioStationID() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D719 >(719)(Pointer); return __sdkResult; }
    public bool @IsVehicleRadioActive() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D720 >(720)(Pointer); return __sdkResult != 0; }
    public void @InitialisePostLoading() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D721 >(721)(Pointer); }
    public void @SetMusicFaderScalingFactor(float @value) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D722 >(722)(Pointer,@value); }
    public void @SetEffectsFaderScalingFactor(float @value) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D723 >(723)(Pointer,@value); }
}
