// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CEntryExit : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=60;
    public CEntryExit(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_szName")]
    public NativeArray<sbyte> @Name { get => new NativeArray<sbyte>(Pointer+0,8); }
    [NativeMember("m_recEntrance")]
    public CRect @RecEntrance { get => new CRect(Pointer+8); set { SdkMemory.Copy(value.Pointer,Pointer+8,16); } }
    [NativeMember("m_fEntranceZ")]
    public float @EntranceZ { get => SdkMemory.Read<float >(Pointer+24); set { SdkMemory.Write(Pointer+24,value); } }
    [NativeMember("m_fEntranceAngle")]
    public float @EntranceAngle { get => SdkMemory.Read<float >(Pointer+28); set { SdkMemory.Write(Pointer+28,value); } }
    [NativeMember("m_vecExitPos")]
    public CVector @ExitPosition { get => new CVector(Pointer+32); set { SdkMemory.Copy(value.Pointer,Pointer+32,12); } }
    [NativeMember("m_fExitAngle")]
    public float @ExitAngle { get => SdkMemory.Read<float >(Pointer+44); set { SdkMemory.Write(Pointer+44,value); } }
    [NativeMember("m_nFlags")]
    public CEntryExit___unnamed__at_D__plugin_sdk_plugin_sa_game_sa_CEntryExit_h__5360072982 @Flags { get => new CEntryExit___unnamed__at_D__plugin_sdk_plugin_sa_game_sa_CEntryExit_h__5360072982(Pointer+48); set { SdkMemory.Copy(value.Pointer,Pointer+48,2); } }
    [NativeMember("m_nArea")]
    public byte @Area { get => SdkMemory.Read<byte >(Pointer+50); set { SdkMemory.Write(Pointer+50,value); } }
    [NativeMember("m_nSkyColor")]
    public byte @SkyColor { get => SdkMemory.Read<byte >(Pointer+51); set { SdkMemory.Write(Pointer+51,value); } }
    [NativeMember("m_nTimeOn")]
    public byte @TimeOn { get => SdkMemory.Read<byte >(Pointer+52); set { SdkMemory.Write(Pointer+52,value); } }
    [NativeMember("m_nTimeOff")]
    public byte @TimeOff { get => SdkMemory.Read<byte >(Pointer+53); set { SdkMemory.Write(Pointer+53,value); } }
    [NativeMember("m_nNumberOfPeds")]
    public byte @NumberOfPeds { get => SdkMemory.Read<byte >(Pointer+54); set { SdkMemory.Write(Pointer+54,value); } }
    [NativeMember("m_pLink")]
    public CEntryExit? @Link { get => SdkMemory.Read<IntPtr>(Pointer+56) == IntPtr.Zero ? null : new CEntryExit(SdkMemory.Read<IntPtr>(Pointer+56)); set { SdkMemory.Write(Pointer+56,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("ms_bWarping")]
    public static bool @Warping { get => SdkMemory.Read<bool >(new IntPtr(0x96A7B8)); set { SdkMemory.Write(new IntPtr(0x96A7B8),value); } }
    [NativeMember("ms_pDoor")]
    public static CObject? @Door { get => SdkMemory.Read<IntPtr>(new IntPtr(0x96A7BC)) == IntPtr.Zero ? null : new CObject(SdkMemory.Read<IntPtr>(new IntPtr(0x96A7BC))); set { SdkMemory.Write(new IntPtr(0x96A7BC),value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("ms_spawnPoint")]
    public static CEntryExit? @SpawnPoint { get => SdkMemory.Read<IntPtr>(new IntPtr(0x96A7C0)) == IntPtr.Zero ? null : new CEntryExit(SdkMemory.Read<IntPtr>(new IntPtr(0x96A7C0))); set { SdkMemory.Write(new IntPtr(0x96A7C0),value?.Pointer ?? IntPtr.Zero); } }
    public void @GenerateAmbientPeds(CVector @position) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2493 >(2493)(Pointer,@position.Pointer); }
    public NativePointer<sbyte> @GetEntryExitToDisplayNameOf() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2494 >(2494)(Pointer); return new NativePointer<sbyte>(__sdkResult); }
    public void @GetPositionRelativeToOutsideWorld(CVector @positionInOut) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2495 >(2495)(Pointer,@positionInOut.Pointer); }
    public bool @IsInArea(CVector @position) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2496 >(2496)(Pointer,@position.Pointer); return __sdkResult != 0; }
    public void @RequestAmbientPeds() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2497 >(2497)(Pointer); }
    public void @RequestObjectsInFrustum() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2498 >(2498)(Pointer); }
    public bool @TransitionFinished(CPed? @player) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2499 >(2499)(Pointer,@player?.Pointer ?? IntPtr.Zero); return __sdkResult != 0; }
    public bool @TransitionStarted(CPed? @player) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2500 >(2500)(Pointer,@player?.Pointer ?? IntPtr.Zero); return __sdkResult != 0; }
    public void @WarpGangWithPlayer(CPed? @player) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2501 >(2501)(Pointer,@player?.Pointer ?? IntPtr.Zero); }
}
