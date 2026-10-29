// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CPlayerInfo : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=400;
    public CPlayerInfo(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_pPed")]
    public CPlayerPed? @Ped { get => SdkMemory.Read<IntPtr>(Pointer+0) == IntPtr.Zero ? null : new CPlayerPed(SdkMemory.Read<IntPtr>(Pointer+0)); set { SdkMemory.Write(Pointer+0,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_PlayerData")]
    public CPlayerData @PlayerData { get => new CPlayerData(Pointer+4); set { SdkMemory.Copy(value.Pointer,Pointer+4,172); } }
    [NativeMember("m_pRemoteVehicle")]
    public CVehicle? @RemoteVehicle { get => SdkMemory.Read<IntPtr>(Pointer+176) == IntPtr.Zero ? null : new CVehicle(SdkMemory.Read<IntPtr>(Pointer+176)); set { SdkMemory.Write(Pointer+176,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_pSpecCar")]
    public CVehicle? @SpecCar { get => SdkMemory.Read<IntPtr>(Pointer+180) == IntPtr.Zero ? null : new CVehicle(SdkMemory.Read<IntPtr>(Pointer+180)); set { SdkMemory.Write(Pointer+180,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_nMoney")]
    public int @Money { get => SdkMemory.Read<int >(Pointer+184); set { SdkMemory.Write(Pointer+184,value); } }
    [NativeMember("m_nDisplayMoney")]
    public int @DisplayMoney { get => SdkMemory.Read<int >(Pointer+188); set { SdkMemory.Write(Pointer+188,value); } }
    [NativeMember("m_nCollectablesPickedUp")]
    public uint @CollectablesPickedUp { get => SdkMemory.Read<uint >(Pointer+192); set { SdkMemory.Write(Pointer+192,value); } }
    [NativeMember("m_nTotalNumCollectables")]
    public uint @TotalCountCollectables { get => SdkMemory.Read<uint >(Pointer+196); set { SdkMemory.Write(Pointer+196,value); } }
    [NativeMember("m_nLastBumpPlayerCarTimer")]
    public uint @LastBumpPlayerCarTimer { get => SdkMemory.Read<uint >(Pointer+200); set { SdkMemory.Write(Pointer+200,value); } }
    [NativeMember("m_nTaxiTimer")]
    public uint @TaxiTimer { get => SdkMemory.Read<uint >(Pointer+204); set { SdkMemory.Write(Pointer+204,value); } }
    [NativeMember("m_nVehicleTimeCounter")]
    public uint @VehicleTimeCounter { get => SdkMemory.Read<uint >(Pointer+208); set { SdkMemory.Write(Pointer+208,value); } }
    [NativeMember("m_bTaxiTimerScore")]
    public bool @TaxiTimerScore { get => SdkMemory.Read<bool >(Pointer+212); set { SdkMemory.Write(Pointer+212,value); } }
    [NativeMember("m_bTryingToExitCar")]
    public bool @TryingToExitCar { get => SdkMemory.Read<bool >(Pointer+213); set { SdkMemory.Write(Pointer+213,value); } }
    [NativeMember("m_pLastTargetVehicle")]
    public CVehicle? @LastTargetVehicle { get => SdkMemory.Read<IntPtr>(Pointer+216) == IntPtr.Zero ? null : new CVehicle(SdkMemory.Read<IntPtr>(Pointer+216)); set { SdkMemory.Write(Pointer+216,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_nPlayerState")]
    public byte @PlayerState { get => SdkMemory.Read<byte >(Pointer+220); set { SdkMemory.Write(Pointer+220,value); } }
    [NativeMember("m_bAfterRemoteVehicleExplosion")]
    public bool @AfterRemoteVehicleExplosion { get => SdkMemory.Read<bool >(Pointer+221); set { SdkMemory.Write(Pointer+221,value); } }
    [NativeMember("m_bCreateRemoteVehicleExplosion")]
    public bool @CreateRemoteVehicleExplosion { get => SdkMemory.Read<bool >(Pointer+222); set { SdkMemory.Write(Pointer+222,value); } }
    [NativeMember("m_bFadeAfterRemoteVehicleExplosion")]
    public bool @FadeAfterRemoteVehicleExplosion { get => SdkMemory.Read<bool >(Pointer+223); set { SdkMemory.Write(Pointer+223,value); } }
    [NativeMember("m_nTimeOfRemoteVehicleExplosion")]
    public uint @TimeOfRemoteVehicleExplosion { get => SdkMemory.Read<uint >(Pointer+224); set { SdkMemory.Write(Pointer+224,value); } }
    [NativeMember("m_nLastTimeEnergyLost")]
    public uint @LastTimeEnergyLost { get => SdkMemory.Read<uint >(Pointer+228); set { SdkMemory.Write(Pointer+228,value); } }
    [NativeMember("m_nLastTimeArmourLost")]
    public uint @LastTimeArmourLost { get => SdkMemory.Read<uint >(Pointer+232); set { SdkMemory.Write(Pointer+232,value); } }
    [NativeMember("m_nLastTimeBigGunFired")]
    public uint @LastTimeBigGunFired { get => SdkMemory.Read<uint >(Pointer+236); set { SdkMemory.Write(Pointer+236,value); } }
    [NativeMember("m_nTimesUpsideDownInARow")]
    public uint @TimesUpsideDownInARow { get => SdkMemory.Read<uint >(Pointer+240); set { SdkMemory.Write(Pointer+240,value); } }
    [NativeMember("m_nTimesStuckInARow")]
    public uint @TimesStuckInARow { get => SdkMemory.Read<uint >(Pointer+244); set { SdkMemory.Write(Pointer+244,value); } }
    [NativeMember("m_nCarTwoWheelCounter")]
    public uint @CarTwoWheelCounter { get => SdkMemory.Read<uint >(Pointer+248); set { SdkMemory.Write(Pointer+248,value); } }
    [NativeMember("m_fCarTwoWheelDist")]
    public float @CarTwoWheelDistance { get => SdkMemory.Read<float >(Pointer+252); set { SdkMemory.Write(Pointer+252,value); } }
    [NativeMember("m_nCarLess3WheelCounter")]
    public uint @CarLess3WheelCounter { get => SdkMemory.Read<uint >(Pointer+256); set { SdkMemory.Write(Pointer+256,value); } }
    [NativeMember("m_nBikeRearWheelCounter")]
    public uint @BikeRearWheelCounter { get => SdkMemory.Read<uint >(Pointer+260); set { SdkMemory.Write(Pointer+260,value); } }
    [NativeMember("m_fBikeRearWheelDist")]
    public float @BikeRearWheelDistance { get => SdkMemory.Read<float >(Pointer+264); set { SdkMemory.Write(Pointer+264,value); } }
    [NativeMember("m_nBikeFrontWheelCounter")]
    public uint @BikeFrontWheelCounter { get => SdkMemory.Read<uint >(Pointer+268); set { SdkMemory.Write(Pointer+268,value); } }
    [NativeMember("m_fBikeFrontWheelDist")]
    public float @BikeFrontWheelDistance { get => SdkMemory.Read<float >(Pointer+272); set { SdkMemory.Write(Pointer+272,value); } }
    [NativeMember("m_nTempBufferCounter")]
    public uint @TempBufferCounter { get => SdkMemory.Read<uint >(Pointer+276); set { SdkMemory.Write(Pointer+276,value); } }
    [NativeMember("m_nBestCarTwoWheelsTimeMs")]
    public uint @BestCarTwoWheelsTimeMs { get => SdkMemory.Read<uint >(Pointer+280); set { SdkMemory.Write(Pointer+280,value); } }
    [NativeMember("m_fBestCarTwoWheelsDistM")]
    public float @BestCarTwoWheelsDistanceM { get => SdkMemory.Read<float >(Pointer+284); set { SdkMemory.Write(Pointer+284,value); } }
    [NativeMember("m_nBestBikeWheelieTimeMs")]
    public uint @BestBikeWheelieTimeMs { get => SdkMemory.Read<uint >(Pointer+288); set { SdkMemory.Write(Pointer+288,value); } }
    [NativeMember("m_fBestBikeWheelieDistM")]
    public float @BestBikeWheelieDistanceM { get => SdkMemory.Read<float >(Pointer+292); set { SdkMemory.Write(Pointer+292,value); } }
    [NativeMember("m_nBestBikeStoppieTimeMs")]
    public uint @BestBikeStoppieTimeMs { get => SdkMemory.Read<uint >(Pointer+296); set { SdkMemory.Write(Pointer+296,value); } }
    [NativeMember("m_fBestBikeStoppieDistM")]
    public float @BestBikeStoppieDistanceM { get => SdkMemory.Read<float >(Pointer+300); set { SdkMemory.Write(Pointer+300,value); } }
    [NativeMember("m_nCarDensityForCurrentZone")]
    public ushort @CarDensityForCurrentZone { get => SdkMemory.Read<ushort >(Pointer+304); set { SdkMemory.Write(Pointer+304,value); } }
    [NativeMember("m_fRoadDensityAroundPlayer")]
    public float @RoadDensityAroundPlayer { get => SdkMemory.Read<float >(Pointer+308); set { SdkMemory.Write(Pointer+308,value); } }
    [NativeMember("m_nTimeOfLastCarExplosionCaused")]
    public uint @TimeOfLastCarExplosionCaused { get => SdkMemory.Read<uint >(Pointer+312); set { SdkMemory.Write(Pointer+312,value); } }
    [NativeMember("m_nExplosionMultiplier")]
    public uint @ExplosionMultiplier { get => SdkMemory.Read<uint >(Pointer+316); set { SdkMemory.Write(Pointer+316,value); } }
    [NativeMember("m_nHavocCaused")]
    public uint @HavocCaused { get => SdkMemory.Read<uint >(Pointer+320); set { SdkMemory.Write(Pointer+320,value); } }
    [NativeMember("m_nNumHoursDidntEat")]
    public ushort @CountHoursDidntEat { get => SdkMemory.Read<ushort >(Pointer+324); set { SdkMemory.Write(Pointer+324,value); } }
    [NativeMember("m_fCurrentChaseValue")]
    public float @CurrentChaseValue { get => SdkMemory.Read<float >(Pointer+328); set { SdkMemory.Write(Pointer+328,value); } }
    [NativeMember("m_bDoesNotGetTired")]
    public bool @DoesNotGetTired { get => SdkMemory.Read<bool >(Pointer+332); set { SdkMemory.Write(Pointer+332,value); } }
    [NativeMember("m_bFastReload")]
    public bool @FastReload { get => SdkMemory.Read<bool >(Pointer+333); set { SdkMemory.Write(Pointer+333,value); } }
    [NativeMember("m_bFireProof")]
    public bool @FireProof { get => SdkMemory.Read<bool >(Pointer+334); set { SdkMemory.Write(Pointer+334,value); } }
    [NativeMember("m_nMaxHealth")]
    public byte @MaxHealth { get => SdkMemory.Read<byte >(Pointer+335); set { SdkMemory.Write(Pointer+335,value); } }
    [NativeMember("m_nMaxArmour")]
    public byte @MaxArmour { get => SdkMemory.Read<byte >(Pointer+336); set { SdkMemory.Write(Pointer+336,value); } }
    [NativeMember("m_bGetOutOfJailFree")]
    public bool @GetOutOfJailFree { get => SdkMemory.Read<bool >(Pointer+337); set { SdkMemory.Write(Pointer+337,value); } }
    [NativeMember("m_bGetOutOfHospitalFree")]
    public bool @GetOutOfHospitalFree { get => SdkMemory.Read<bool >(Pointer+338); set { SdkMemory.Write(Pointer+338,value); } }
    [NativeMember("m_bCanDoDriveBy")]
    public bool @CanDoDriveBy { get => SdkMemory.Read<bool >(Pointer+339); set { SdkMemory.Write(Pointer+339,value); } }
    [NativeMember("m_nBustedAudioStatus")]
    public byte @BustedAudioStatus { get => SdkMemory.Read<byte >(Pointer+340); set { SdkMemory.Write(Pointer+340,value); } }
    [NativeMember("m_nLastBustMessageNumber")]
    public ushort @LastBustMessageNumber { get => SdkMemory.Read<ushort >(Pointer+342); set { SdkMemory.Write(Pointer+342,value); } }
    [NativeMember("m_nCrosshairActivated")]
    public uint @CrosshairActivated { get => SdkMemory.Read<uint >(Pointer+344); set { SdkMemory.Write(Pointer+344,value); } }
    [NativeMember("m_vecCrosshairTarget")]
    public CVector2D @CrosshairTarget { get => new CVector2D(Pointer+348); set { SdkMemory.Copy(value.Pointer,Pointer+348,8); } }
    [NativeMember("m_szSkinName")]
    public NativeArray<sbyte> @SkinName { get => new NativeArray<sbyte>(Pointer+356,32); }
    [NativeMember("m_pSkinTexture")]
    public RwTexture? @SkinTexture { get => SdkMemory.Read<IntPtr>(Pointer+388) == IntPtr.Zero ? null : new RwTexture(SdkMemory.Read<IntPtr>(Pointer+388)); set { SdkMemory.Write(Pointer+388,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_bParachuteReferenced")]
    public bool @ParachuteReferenced { get => SdkMemory.Read<bool >(Pointer+392); set { SdkMemory.Write(Pointer+392,value); } }
    [NativeMember("m_nRequireParachuteTimer")]
    public uint @RequireParachuteTimer { get => SdkMemory.Read<uint >(Pointer+396); set { SdkMemory.Write(Pointer+396,value); } }
    public void @InitializeAt() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3389 >(3389)(Pointer); }
    public void @MakePlayerSafe(bool @safe,float @radius) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3390 >(3390)(Pointer,(@safe ? 1 : 0),@radius); }
    public bool @Load() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3391 >(3391)(Pointer); return __sdkResult != 0; }
    public bool @Save() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3392 >(3392)(Pointer); return __sdkResult != 0; }
}
