// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CAESound : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=116;
    public CAESound(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_nBankSlotId")]
    public short @BankSlotId { get => SdkMemory.Read<short >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("m_nSoundIdInSlot")]
    public short @SoundIdInSlot { get => SdkMemory.Read<short >(Pointer+2); set { SdkMemory.Write(Pointer+2,value); } }
    [NativeMember("m_pBaseAudio")]
    public CAEAudioEntity? @BaseAudio { get => SdkMemory.Read<IntPtr>(Pointer+4) == IntPtr.Zero ? null : new CAEAudioEntity(SdkMemory.Read<IntPtr>(Pointer+4)); set { SdkMemory.Write(Pointer+4,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_pPhysicalEntity")]
    public CEntity? @PhysicalEntity { get => SdkMemory.Read<IntPtr>(Pointer+8) == IntPtr.Zero ? null : new CEntity(SdkMemory.Read<IntPtr>(Pointer+8)); set { SdkMemory.Write(Pointer+8,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_nEvent")]
    public uint @Event { get => SdkMemory.Read<uint >(Pointer+12); set { SdkMemory.Write(Pointer+12,value); } }
    [NativeMember("m_fMaxVolume")]
    public float @MaxVolume { get => SdkMemory.Read<float >(Pointer+16); set { SdkMemory.Write(Pointer+16,value); } }
    [NativeMember("m_fVolume")]
    public float @Volume { get => SdkMemory.Read<float >(Pointer+20); set { SdkMemory.Write(Pointer+20,value); } }
    [NativeMember("m_fSoundDistance")]
    public float @SoundDistance { get => SdkMemory.Read<float >(Pointer+24); set { SdkMemory.Write(Pointer+24,value); } }
    [NativeMember("m_fSpeed")]
    public float @Speed { get => SdkMemory.Read<float >(Pointer+28); set { SdkMemory.Write(Pointer+28,value); } }
    [NativeMember("field_20")]
    public float @Field20 { get => SdkMemory.Read<float >(Pointer+32); set { SdkMemory.Write(Pointer+32,value); } }
    [NativeMember("m_vecCurrPosn")]
    public CVector @CurrPosition { get => new CVector(Pointer+36); set { SdkMemory.Copy(value.Pointer,Pointer+36,12); } }
    [NativeMember("m_vecPrevPosn")]
    public CVector @PrevPosition { get => new CVector(Pointer+48); set { SdkMemory.Copy(value.Pointer,Pointer+48,12); } }
    [NativeMember("m_nLastFrameUpdate")]
    public int @LastFrameUpdate { get => SdkMemory.Read<int >(Pointer+60); set { SdkMemory.Write(Pointer+60,value); } }
    [NativeMember("m_nCurrTimeUpdate")]
    public int @CurrTimeUpdate { get => SdkMemory.Read<int >(Pointer+64); set { SdkMemory.Write(Pointer+64,value); } }
    [NativeMember("m_nPrevTimeUpdate")]
    public int @PrevTimeUpdate { get => SdkMemory.Read<int >(Pointer+68); set { SdkMemory.Write(Pointer+68,value); } }
    [NativeMember("m_fCurrCamDist")]
    public float @CurrCamDistance { get => SdkMemory.Read<float >(Pointer+72); set { SdkMemory.Write(Pointer+72,value); } }
    [NativeMember("m_fPrevCamDist")]
    public float @PrevCamDistance { get => SdkMemory.Read<float >(Pointer+76); set { SdkMemory.Write(Pointer+76,value); } }
    [NativeMember("m_fTimeScale")]
    public float @TimeScale { get => SdkMemory.Read<float >(Pointer+80); set { SdkMemory.Write(Pointer+80,value); } }
    [NativeMember("field_54")]
    public sbyte @Field54 { get => SdkMemory.Read<sbyte >(Pointer+84); set { SdkMemory.Write(Pointer+84,value); } }
    [NativeMember("field_55")]
    public sbyte @Field55 { get => SdkMemory.Read<sbyte >(Pointer+85); set { SdkMemory.Write(Pointer+85,value); } }
    [NativeMember("m_nIsUsed")]
    public ushort @IsUsed { get => SdkMemory.Read<ushort >(Pointer+88); set { SdkMemory.Write(Pointer+88,value); } }
    [NativeMember("field_5A")]
    public short @Field5A { get => SdkMemory.Read<short >(Pointer+90); set { SdkMemory.Write(Pointer+90,value); } }
    [NativeMember("m_nCurrentPlayPosition")]
    public short @CurrentPlayPosition { get => SdkMemory.Read<short >(Pointer+92); set { SdkMemory.Write(Pointer+92,value); } }
    [NativeMember("field_5E")]
    public short @Field5E { get => SdkMemory.Read<short >(Pointer+94); set { SdkMemory.Write(Pointer+94,value); } }
    [NativeMember("m_fFinalVolume")]
    public float @FinalVolume { get => SdkMemory.Read<float >(Pointer+96); set { SdkMemory.Write(Pointer+96,value); } }
    [NativeMember("m_fFrequency")]
    public float @Frequency { get => SdkMemory.Read<float >(Pointer+100); set { SdkMemory.Write(Pointer+100,value); } }
    [NativeMember("m_nPlayingState")]
    public short @PlayingState { get => SdkMemory.Read<short >(Pointer+104); set { SdkMemory.Write(Pointer+104,value); } }
    [NativeMember("field_6A")]
    public NativeArray<sbyte> @Field6A { get => new NativeArray<sbyte>(Pointer+106,2); }
    [NativeMember("m_fSoundHeadRoom")]
    public float @SoundHeadRoom { get => SdkMemory.Read<float >(Pointer+108); set { SdkMemory.Write(Pointer+108,value); } }
    [NativeMember("m_nSoundLength")]
    public short @SoundLength { get => SdkMemory.Read<short >(Pointer+112); set { SdkMemory.Write(Pointer+112,value); } }
    [NativeMember("field_72")]
    public short @Field72 { get => SdkMemory.Read<short >(Pointer+114); set { SdkMemory.Write(Pointer+114,value); } }
    public void @InitializeAt() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D215 >(215)(Pointer); }
    public void @InitializeAt(CAESound @sound) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D216 >(216)(Pointer,@sound.Pointer); }
    public void @InitializeAt(short @bankSlotId,short @sfxId,CAEAudioEntity? @baseAudio,CVector @posn,float @volume,float @maxDistance,float @speed,float @timeScale,byte @arg9,ushort @environmentFlags,float @arg11) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D217 >(217)(Pointer,@bankSlotId,@sfxId,@baseAudio?.Pointer ?? IntPtr.Zero,@posn.Pointer,@volume,@maxDistance,@speed,@timeScale,@arg9,@environmentFlags,@arg11); }
    public void @DestroyNative() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D218 >(218)(Pointer); }
    public void @AssignNative(CAESound @sound) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D219 >(219)(Pointer,@sound.Pointer); }
    public void @UnregisterWithPhysicalEntity() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D220 >(220)(Pointer); }
    public void @StopSound() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D221 >(221)(Pointer); }
    public bool @GetUncancellable() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D222 >(222)(Pointer); return __sdkResult != 0; }
    public bool @GetFrontEnd() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D223 >(223)(Pointer); return __sdkResult != 0; }
    public bool @GetRequestUpdates() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D224 >(224)(Pointer); return __sdkResult != 0; }
    public bool @GetUnpausable() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D225 >(225)(Pointer); return __sdkResult != 0; }
    public bool @GetPlayPhysically() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D226 >(226)(Pointer); return __sdkResult != 0; }
    public bool @GetStartPercentage() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D227 >(227)(Pointer); return __sdkResult != 0; }
    public bool @GetMusicMastered() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D228 >(228)(Pointer); return __sdkResult != 0; }
    public bool @GetLifespanTiedToPhysicalEntity() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D229 >(229)(Pointer); return __sdkResult != 0; }
    public bool @GetUnduckable() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D230 >(230)(Pointer); return __sdkResult != 0; }
    public bool @GetUncompressable() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D231 >(231)(Pointer); return __sdkResult != 0; }
    public bool @GetRolledOff() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D232 >(232)(Pointer); return __sdkResult != 0; }
    public bool @GetSmoothDucking() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D233 >(233)(Pointer); return __sdkResult != 0; }
    public bool @GetForcedFront() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D234 >(234)(Pointer); return __sdkResult != 0; }
    public void @SetIndividualEnvironment(ushort @environment,ushort @state) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D235 >(235)(Pointer,@environment,@state); }
    public void @UpdatePlayTime(short @arg1,short @arg2,short @arg3) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D236 >(236)(Pointer,@arg1,@arg2,@arg3); }
    public void @GetRelativePosition(CVector? @outPosn) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D237 >(237)(Pointer,@outPosn?.Pointer ?? IntPtr.Zero); }
    public void @CalculateFrequency() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D238 >(238)(Pointer); }
    public void @UpdateFrequency() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D239 >(239)(Pointer); }
    public float @GetRelativePlaybackFrequencyWithDoppler() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D240 >(240)(Pointer); return __sdkResult; }
    public float @GetSlowMoFrequencyScalingFactor() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D241 >(241)(Pointer); return __sdkResult; }
    public void @NewVPSLentry() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D242 >(242)(Pointer); }
    public void @RegisterWithPhysicalEntity(CEntity? @entity) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D243 >(243)(Pointer,@entity?.Pointer ?? IntPtr.Zero); }
    public void @StopSoundAndForget() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D244 >(244)(Pointer); }
    public void @SetPosition(CVector @posn) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D245 >(245)(Pointer,@posn.Pointer); }
    public void @CalculateVolume() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D246 >(246)(Pointer); }
    public void @Initialise(short @bankSlotId,short @sfxId,CAEAudioEntity? @baseAudio,CVector @posn,float @volume,float @maxDistance,float @speed,float @timeScale,byte @arg9,ushort @environmentFlags,float @arg11,short @currPlayPosn) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D247 >(247)(Pointer,@bankSlotId,@sfxId,@baseAudio?.Pointer ?? IntPtr.Zero,@posn.Pointer,@volume,@maxDistance,@speed,@timeScale,@arg9,@environmentFlags,@arg11,@currPlayPosn); }
    public void @UpdateParameters(short @arg1) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D248 >(248)(Pointer,@arg1); }
}
