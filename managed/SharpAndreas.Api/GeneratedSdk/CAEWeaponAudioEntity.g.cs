// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CAEWeaponAudioEntity : CAEAudioEntity
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=168;
    public CAEWeaponAudioEntity(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_bPlayedMiniGunFireSound")]
    public sbyte @PlayedMiniGunFireSound { get => SdkMemory.Read<sbyte >(Pointer+124); set { SdkMemory.Write(Pointer+124,value); } }
    [NativeMember("field_7D")]
    public sbyte @Field7D { get => SdkMemory.Read<sbyte >(Pointer+125); set { SdkMemory.Write(Pointer+125,value); } }
    [NativeMember("field_7E")]
    public sbyte @Field7E { get => SdkMemory.Read<sbyte >(Pointer+126); set { SdkMemory.Write(Pointer+126,value); } }
    [NativeMember("field_7F")]
    public sbyte @Field7F { get => SdkMemory.Read<sbyte >(Pointer+127); set { SdkMemory.Write(Pointer+127,value); } }
    [NativeMember("m_nChainsawSoundState")]
    public sbyte @ChainsawSoundState { get => SdkMemory.Read<sbyte >(Pointer+128); set { SdkMemory.Write(Pointer+128,value); } }
    [NativeMember("field_81")]
    public NativeArray<sbyte> @Field81 { get => new NativeArray<sbyte>(Pointer+129,3); }
    [NativeMember("m_dwFlameThrowerLastPlayedTime")]
    public int @FlameThrowerLastPlayedTime { get => SdkMemory.Read<int >(Pointer+132); set { SdkMemory.Write(Pointer+132,value); } }
    [NativeMember("m_dwSpraycanLastPlayedTime")]
    public int @SpraycanLastPlayedTime { get => SdkMemory.Read<int >(Pointer+136); set { SdkMemory.Write(Pointer+136,value); } }
    [NativeMember("m_dwExtinguisherLastPlayedTime")]
    public int @ExtinguisherLastPlayedTime { get => SdkMemory.Read<int >(Pointer+140); set { SdkMemory.Write(Pointer+140,value); } }
    [NativeMember("m_dwMiniGunFireSoundPlayedTime")]
    public int @MiniGunFireSoundPlayedTime { get => SdkMemory.Read<int >(Pointer+144); set { SdkMemory.Write(Pointer+144,value); } }
    [NativeMember("m_dwTimeChainsaw")]
    public int @TimeChainsaw { get => SdkMemory.Read<int >(Pointer+148); set { SdkMemory.Write(Pointer+148,value); } }
    [NativeMember("m_dwTimeLastFired")]
    public int @TimeLastFired { get => SdkMemory.Read<int >(Pointer+152); set { SdkMemory.Write(Pointer+152,value); } }
    [NativeMember("m_pSounds")]
    public CAESound? @Sounds { get => SdkMemory.Read<IntPtr>(Pointer+156) == IntPtr.Zero ? null : new CAESound(SdkMemory.Read<IntPtr>(Pointer+156)); set { SdkMemory.Write(Pointer+156,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_bActive")]
    public sbyte @Active { get => SdkMemory.Read<sbyte >(Pointer+160); set { SdkMemory.Write(Pointer+160,value); } }
    [NativeMember("field_A1")]
    public NativeArray<sbyte> @FieldA1 { get => new NativeArray<sbyte>(Pointer+161,3); }
    [NativeMember("m_pPed")]
    public CPed? @Ped { get => SdkMemory.Read<IntPtr>(Pointer+164) == IntPtr.Zero ? null : new CPed(SdkMemory.Read<IntPtr>(Pointer+164)); set { SdkMemory.Write(Pointer+164,value?.Pointer ?? IntPtr.Zero); } }
    public void @InitializeAt() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D568 >(568)(Pointer); }
    public void @WeaponReload(eWeaponType @weaptype,CPhysical? @entity,int @AudioEventId) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D569 >(569)(Pointer,(int)@weaptype,@entity?.Pointer ?? IntPtr.Zero,@AudioEventId); }
    public void @WeaponFire(eWeaponType @weaptype,CPhysical? @entity,int @AudioEventId) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D570 >(570)(Pointer,(int)@weaptype,@entity?.Pointer ?? IntPtr.Zero,@AudioEventId); }
    public void @Terminate() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D571 >(571)(Pointer); }
    public void @StopFlameThrowerIdleGasLoop() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D572 >(572)(Pointer); }
    public void @Reset() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D573 >(573)(Pointer); }
    public void @ReportStealthKill(eWeaponType @weaptype,CPhysical? @entity,int @AudioEventId) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D574 >(574)(Pointer,(int)@weaptype,@entity?.Pointer ?? IntPtr.Zero,@AudioEventId); }
    public void @ReportChainsawEvent(CPhysical? @entity,int @AudioEventId) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D575 >(575)(Pointer,@entity?.Pointer ?? IntPtr.Zero,@AudioEventId); }
    public void @PlayWeaponLoopSound(CPhysical? @arg0,short @sfxId,int @AudioEventId,float @audability,float @speed,int @finalEvent) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D576 >(576)(Pointer,@arg0?.Pointer ?? IntPtr.Zero,@sfxId,@AudioEventId,@audability,@speed,@finalEvent); }
    public void @PlayMiniGunStopSound(CPhysical? @entity) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D577 >(577)(Pointer,@entity?.Pointer ?? IntPtr.Zero); }
    public void @PlayMiniGunFireSounds(CPhysical? @entity,int @AudioEventId) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D578 >(578)(Pointer,@entity?.Pointer ?? IntPtr.Zero,@AudioEventId); }
    public void @PlayGunSounds(CPhysical? @entity,short @emptySfxId,short @farSfxId2,short @highPitchSfxId3,short @lowPitchSfxId4,short @echoSfxId5,int @nAudioEventId,float @volumeChange,float @speed1,float @speed2) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D579 >(579)(Pointer,@entity?.Pointer ?? IntPtr.Zero,@emptySfxId,@farSfxId2,@highPitchSfxId3,@lowPitchSfxId4,@echoSfxId5,@nAudioEventId,@volumeChange,@speed1,@speed2); }
    public void @PlayGoggleSound(short @sfxId,int @AudioEventId) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D580 >(580)(Pointer,@sfxId,@AudioEventId); }
    public void @PlayFlameThrowerSounds(CPhysical? @entity,short @sfx1,short @sfx2,int @AudioEventId,float @audability,float @speed) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D581 >(581)(Pointer,@entity?.Pointer ?? IntPtr.Zero,@sfx1,@sfx2,@AudioEventId,@audability,@speed); }
    public void @PlayFlameThrowerIdleGasLoop(CPhysical? @entity) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D582 >(582)(Pointer,@entity?.Pointer ?? IntPtr.Zero); }
    public void @PlayChainsawStopSound(CPhysical? @entity) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D583 >(583)(Pointer,@entity?.Pointer ?? IntPtr.Zero); }
    public void @PlayCameraSound(CPhysical? @entity,int @AudioEventId,float @audability) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D584 >(584)(Pointer,@entity?.Pointer ?? IntPtr.Zero,@AudioEventId,@audability); }
    public void @Initialise() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D585 >(585)(Pointer); }
}
