// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CWanted : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=668;
    public CWanted(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_nChaosLevel")]
    public uint @ChaosLevel { get => SdkMemory.Read<uint >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("m_nChaosLevelBeforeParole")]
    public uint @ChaosLevelBeforeParole { get => SdkMemory.Read<uint >(Pointer+4); set { SdkMemory.Write(Pointer+4,value); } }
    [NativeMember("m_nLastTimeWantedDecreased")]
    public uint @LastTimeWantedDecreased { get => SdkMemory.Read<uint >(Pointer+8); set { SdkMemory.Write(Pointer+8,value); } }
    [NativeMember("m_nLastTimeWantedLevelChanged")]
    public uint @LastTimeWantedLevelChanged { get => SdkMemory.Read<uint >(Pointer+12); set { SdkMemory.Write(Pointer+12,value); } }
    [NativeMember("m_nTimeOfParole")]
    public uint @TimeOfParole { get => SdkMemory.Read<uint >(Pointer+16); set { SdkMemory.Write(Pointer+16,value); } }
    [NativeMember("m_fMultiplier")]
    public float @Multiplier { get => SdkMemory.Read<float >(Pointer+20); set { SdkMemory.Write(Pointer+20,value); } }
    [NativeMember("m_nCopsInPursuit")]
    public byte @CopsInPursuit { get => SdkMemory.Read<byte >(Pointer+24); set { SdkMemory.Write(Pointer+24,value); } }
    [NativeMember("m_nMaxCopsInPursuit")]
    public byte @MaxCopsInPursuit { get => SdkMemory.Read<byte >(Pointer+25); set { SdkMemory.Write(Pointer+25,value); } }
    [NativeMember("m_nMaxCopCarsInPursuit")]
    public byte @MaxCopCarsInPursuit { get => SdkMemory.Read<byte >(Pointer+26); set { SdkMemory.Write(Pointer+26,value); } }
    [NativeMember("m_nCopsBeatingSuspect")]
    public byte @CopsBeatingSuspect { get => SdkMemory.Read<byte >(Pointer+27); set { SdkMemory.Write(Pointer+27,value); } }
    [NativeMember("m_nChanceOnRoadBlock")]
    public ushort @ChanceOnRoadBlock { get => SdkMemory.Read<ushort >(Pointer+28); set { SdkMemory.Write(Pointer+28,value); } }
    [NativeMember("m_bPoliceBackOff")]
    public byte @PoliceBackOff { get => (byte)SdkMemory.ReadBits(Pointer,240,1); set { SdkMemory.WriteBits(Pointer,240,1,unchecked((ulong)value)); } }
    [NativeMember("m_bPoliceBackOffGarage")]
    public byte @PoliceBackOffGarage { get => (byte)SdkMemory.ReadBits(Pointer,241,1); set { SdkMemory.WriteBits(Pointer,241,1,unchecked((ulong)value)); } }
    [NativeMember("m_bEverybodyBackOff")]
    public byte @EverybodyBackOff { get => (byte)SdkMemory.ReadBits(Pointer,242,1); set { SdkMemory.WriteBits(Pointer,242,1,unchecked((ulong)value)); } }
    [NativeMember("m_bSwatRequired")]
    public byte @SwatRequired { get => (byte)SdkMemory.ReadBits(Pointer,243,1); set { SdkMemory.WriteBits(Pointer,243,1,unchecked((ulong)value)); } }
    [NativeMember("m_bFbiRequired")]
    public byte @FbiRequired { get => (byte)SdkMemory.ReadBits(Pointer,244,1); set { SdkMemory.WriteBits(Pointer,244,1,unchecked((ulong)value)); } }
    [NativeMember("m_bArmyRequired")]
    public byte @ArmyRequired { get => (byte)SdkMemory.ReadBits(Pointer,245,1); set { SdkMemory.WriteBits(Pointer,245,1,unchecked((ulong)value)); } }
    [NativeMember("m_nCurrentChaseTime")]
    public uint @CurrentChaseTime { get => SdkMemory.Read<uint >(Pointer+32); set { SdkMemory.Write(Pointer+32,value); } }
    [NativeMember("m_nCurrentChaseTimeCounter")]
    public uint @CurrentChaseTimeCounter { get => SdkMemory.Read<uint >(Pointer+36); set { SdkMemory.Write(Pointer+36,value); } }
    [NativeMember("m_nTimeCounting")]
    public uint @TimeCounting { get => SdkMemory.Read<uint >(Pointer+40); set { SdkMemory.Write(Pointer+40,value); } }
    [NativeMember("m_nWantedLevel")]
    public uint @WantedLevel { get => SdkMemory.Read<uint >(Pointer+44); set { SdkMemory.Write(Pointer+44,value); } }
    [NativeMember("m_nWantedLevelBeforeParole")]
    public uint @WantedLevelBeforeParole { get => SdkMemory.Read<uint >(Pointer+48); set { SdkMemory.Write(Pointer+48,value); } }
    [NativeMember("m_CrimesBeingQd")]
    public NativeObjectArray<CCrimeBeingQd> @CrimesBeingQd { get => new NativeObjectArray<CCrimeBeingQd>(Pointer+52,16,28); }
    [NativeMember("m_pCopsInPursuit")]
    public NativeArray<IntPtr> @CopsInPursuitValue { get => new NativeArray<IntPtr>(Pointer+500,10); }
    [NativeMember("m_PoliceScannerAudio")]
    public CAEPoliceScannerAudioEntity @PoliceScannerAudio { get => new CAEPoliceScannerAudioEntity(Pointer+540); set { SdkMemory.Copy(value.Pointer,Pointer+540,124); } }
    [NativeMember("m_bLeavePlayerAlone")]
    public bool @LeavePlayerAlone { get => SdkMemory.Read<bool >(Pointer+664); set { SdkMemory.Write(Pointer+664,value); } }
    [NativeMember("MaximumWantedLevel")]
    public static uint @MaximumWantedLevel { get => SdkMemory.Read<uint >(new IntPtr(0x8CDEE4)); set { SdkMemory.Write(new IntPtr(0x8CDEE4),value); } }
    [NativeMember("nMaximumWantedLevel")]
    public static uint @MaximumWantedLevelValue { get => SdkMemory.Read<uint >(new IntPtr(0x8CDEE8)); set { SdkMemory.Write(new IntPtr(0x8CDEE8),value); } }
    [NativeMember("bUseNewsHeliInAdditionToPolice")]
    public static bool @UseNewsHeliInAdditionToPolice { get => SdkMemory.Read<bool >(new IntPtr(0xB7CB8C)); set { SdkMemory.Write(new IntPtr(0xB7CB8C),value); } }
    public static void @InitialiseStaticVariables() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1374 >(1374)(); }
    public void @UpdateWantedLevel() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1375 >(1375)(Pointer); }
    public static void @SetMaximumWantedLevel(int @level) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1376 >(1376)(@level); }
    public bool @AreMiamiViceRequired() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1377 >(1377)(Pointer); return __sdkResult != 0; }
    public bool @AreSwatRequired() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1378 >(1378)(Pointer); return __sdkResult != 0; }
    public bool @AreFbiRequired() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1379 >(1379)(Pointer); return __sdkResult != 0; }
    public bool @AreArmyRequired() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1380 >(1380)(Pointer); return __sdkResult != 0; }
    public int @NumOfHelisRequired() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1381 >(1381)(Pointer); return __sdkResult; }
    public static void @ResetPolicePursuit() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1382 >(1382)(); }
    public void @ClearQdCrimes() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1383 >(1383)(Pointer); }
    public bool @AddCrimeToQ(eCrimeType @crimeType,int @crimeId,CVector @posn,bool @bAlreadyReported,bool @bPoliceDontReallyCare) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1384 >(1384)(Pointer,(int)@crimeType,@crimeId,@posn.Pointer,(@bAlreadyReported ? 1 : 0),(@bPoliceDontReallyCare ? 1 : 0)); return __sdkResult != 0; }
    public void @ReportCrimeNow(eCrimeType @crimeType,CVector @posn,bool @bPoliceDontReallyCare) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1385 >(1385)(Pointer,(int)@crimeType,@posn.Pointer,(@bPoliceDontReallyCare ? 1 : 0)); }
    public static void @RemovePursuitCop(CCopPed? @cop,NativePointer<IntPtr> @copsArray,NativePointer<byte> @copsCounter) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1386 >(1386)(@cop?.Pointer ?? IntPtr.Zero,@copsArray.Pointer,@copsCounter.Pointer); }
    public bool @IsInPursuit(CCopPed? @cop) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1387 >(1387)(Pointer,@cop?.Pointer ?? IntPtr.Zero); return __sdkResult != 0; }
    public static void @UpdateEachFrame() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1388 >(1388)(); }
    public void @Initialise() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1389 >(1389)(Pointer); }
    public void @Reset() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1390 >(1390)(Pointer); }
    public void @RegisterCrime(eCrimeType @crimeType,CVector @posn,uint @crimeId,bool @bPoliceDontReallyCare) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1391 >(1391)(Pointer,(int)@crimeType,@posn.Pointer,@crimeId,(@bPoliceDontReallyCare ? 1 : 0)); }
    public void @RegisterCrime_Immediately(eCrimeType @crimeType,CVector @posn,uint @crimeId,bool @bPoliceDontReallyCare) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1392 >(1392)(Pointer,(int)@crimeType,@posn.Pointer,@crimeId,(@bPoliceDontReallyCare ? 1 : 0)); }
    public void @SetWantedLevel(int @level) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1393 >(1393)(Pointer,@level); }
    public void @CheatWantedLevel(int @level) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1394 >(1394)(Pointer,@level); }
    public void @SetWantedLevelNoDrop(int @level) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1395 >(1395)(Pointer,@level); }
    public void @ClearWantedLevelAndGoOnParole() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1396 >(1396)(Pointer); }
    public static int @WorkOutPolicePresence(CVector @posn,float @radius) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1397 >(1397)(@posn.Pointer,@radius); return __sdkResult; }
    public void @UpdateCrimesQ() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1398 >(1398)(Pointer); }
    public bool @IsClosestCop(CPed? @ped,int @numCopsToCheck) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1399 >(1399)(Pointer,@ped?.Pointer ?? IntPtr.Zero,@numCopsToCheck); return __sdkResult != 0; }
    public static CCopPed? @ComputePursuitCopToDisplace(CCopPed? @cop,NativePointer<IntPtr> @copsArray) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1400 >(1400)(@cop?.Pointer ?? IntPtr.Zero,@copsArray.Pointer); return __sdkResult == IntPtr.Zero ? null : new CCopPed(__sdkResult); }
    public void @RemovePursuitCop(CCopPed? @cop) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1401 >(1401)(Pointer,@cop?.Pointer ?? IntPtr.Zero); }
    public void @RemoveExcessPursuitCops() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1402 >(1402)(Pointer); }
    public void @Update() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1403 >(1403)(Pointer); }
    public static bool @CanCopJoinPursuit(CCopPed? @cop,byte @maxCopsCount,NativePointer<IntPtr> @copsArray,NativePointer<byte> @copsCounter) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1404 >(1404)(@cop?.Pointer ?? IntPtr.Zero,@maxCopsCount,@copsArray.Pointer,@copsCounter.Pointer); return __sdkResult != 0; }
    public bool @CanCopJoinPursuit(CCopPed? @cop) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1405 >(1405)(Pointer,@cop?.Pointer ?? IntPtr.Zero); return __sdkResult != 0; }
    public bool @SetPursuitCop(CCopPed? @cop) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1406 >(1406)(Pointer,@cop?.Pointer ?? IntPtr.Zero); return __sdkResult != 0; }
}
