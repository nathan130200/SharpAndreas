// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CPad : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=308;
    public CPad(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("NewState")]
    public CControllerState @NewState { get => new CControllerState(Pointer+0); set { SdkMemory.Copy(value.Pointer,Pointer+0,48); } }
    [NativeMember("OldState")]
    public CControllerState @OldState { get => new CControllerState(Pointer+48); set { SdkMemory.Copy(value.Pointer,Pointer+48,48); } }
    [NativeMember("SteeringLeftRightBuffer")]
    public NativeArray<short> @SteeringLeftRightBuffer { get => new NativeArray<short>(Pointer+96,10); }
    [NativeMember("DrunkDrivingBufferUsed")]
    public int @DrunkDrivingBufferUsed { get => SdkMemory.Read<int >(Pointer+116); set { SdkMemory.Write(Pointer+116,value); } }
    [NativeMember("PCTempKeyState")]
    public CControllerState @PCTempKeyState { get => new CControllerState(Pointer+120); set { SdkMemory.Copy(value.Pointer,Pointer+120,48); } }
    [NativeMember("PCTempJoyState")]
    public CControllerState @PCTempJoyState { get => new CControllerState(Pointer+168); set { SdkMemory.Copy(value.Pointer,Pointer+168,48); } }
    [NativeMember("PCTempMouseState")]
    public CControllerState @PCTempMouseState { get => new CControllerState(Pointer+216); set { SdkMemory.Copy(value.Pointer,Pointer+216,48); } }
    [NativeMember("Phase")]
    public sbyte @Phase { get => SdkMemory.Read<sbyte >(Pointer+264); set { SdkMemory.Write(Pointer+264,value); } }
    [NativeMember("Mode")]
    public short @Mode { get => SdkMemory.Read<short >(Pointer+266); set { SdkMemory.Write(Pointer+266,value); } }
    [NativeMember("ShakeDur")]
    public short @ShakeDur { get => SdkMemory.Read<short >(Pointer+268); set { SdkMemory.Write(Pointer+268,value); } }
    [NativeMember("ShakeFreq")]
    public sbyte @ShakeFreq { get => SdkMemory.Read<sbyte >(Pointer+272); set { SdkMemory.Write(Pointer+272,value); } }
    [NativeMember("bHornHistory")]
    public NativeArray<sbyte> @HornHistory { get => new NativeArray<sbyte>(Pointer+273,5); }
    [NativeMember("iCurrHornHistory")]
    public sbyte @ICurrHornHistory { get => SdkMemory.Read<sbyte >(Pointer+278); set { SdkMemory.Write(Pointer+278,value); } }
    [NativeMember("JustOutOfFrontEnd")]
    public sbyte @JustOutOfFrontEnd { get => SdkMemory.Read<sbyte >(Pointer+279); set { SdkMemory.Write(Pointer+279,value); } }
    [NativeMember("bApplyBrakes")]
    public sbyte @ApplyBrakes { get => SdkMemory.Read<sbyte >(Pointer+280); set { SdkMemory.Write(Pointer+280,value); } }
    [NativeMember("bDisablePlayerEnterCar")]
    public sbyte @DisablePlayerEnterCar { get => SdkMemory.Read<sbyte >(Pointer+281); set { SdkMemory.Write(Pointer+281,value); } }
    [NativeMember("bDisablePlayerDuck")]
    public sbyte @DisablePlayerDuck { get => SdkMemory.Read<sbyte >(Pointer+282); set { SdkMemory.Write(Pointer+282,value); } }
    [NativeMember("bDisablePlayerFireWeapon")]
    public sbyte @DisablePlayerFireWeapon { get => SdkMemory.Read<sbyte >(Pointer+283); set { SdkMemory.Write(Pointer+283,value); } }
    [NativeMember("bDisablePlayerFireWeaponWithL1")]
    public sbyte @DisablePlayerFireWeaponWithL1 { get => SdkMemory.Read<sbyte >(Pointer+284); set { SdkMemory.Write(Pointer+284,value); } }
    [NativeMember("bDisablePlayerCycleWeapon")]
    public sbyte @DisablePlayerCycleWeapon { get => SdkMemory.Read<sbyte >(Pointer+285); set { SdkMemory.Write(Pointer+285,value); } }
    [NativeMember("bDisablePlayerJump")]
    public sbyte @DisablePlayerJump { get => SdkMemory.Read<sbyte >(Pointer+286); set { SdkMemory.Write(Pointer+286,value); } }
    [NativeMember("bDisablePlayerDisplayVitalStats")]
    public sbyte @DisablePlayerDisplayVitalStats { get => SdkMemory.Read<sbyte >(Pointer+287); set { SdkMemory.Write(Pointer+287,value); } }
    [NativeMember("LastTimeTouched")]
    public int @LastTimeTouched { get => SdkMemory.Read<int >(Pointer+288); set { SdkMemory.Write(Pointer+288,value); } }
    [NativeMember("AverageWeapon")]
    public int @AverageWeapon { get => SdkMemory.Read<int >(Pointer+292); set { SdkMemory.Write(Pointer+292,value); } }
    [NativeMember("AverageEntries")]
    public int @AverageEntries { get => SdkMemory.Read<int >(Pointer+296); set { SdkMemory.Write(Pointer+296,value); } }
    [NativeMember("NoShakeBeforeThis")]
    public int @NoShakeBeforeThis { get => SdkMemory.Read<int >(Pointer+300); set { SdkMemory.Write(Pointer+300,value); } }
    [NativeMember("NoShakeFreq")]
    public sbyte @NoShakeFreq { get => SdkMemory.Read<sbyte >(Pointer+304); set { SdkMemory.Write(Pointer+304,value); } }
    [NativeMember("PCTempMouseControllerState")]
    public static CMouseControllerState @PCTempMouseControllerState { get => new CMouseControllerState(new IntPtr(0xB73404)); set { SdkMemory.Copy(value.Pointer,new IntPtr(0xB73404),20); } }
    [NativeMember("NewMouseControllerState")]
    public static CMouseControllerState @NewMouseControllerState { get => new CMouseControllerState(new IntPtr(0xB73418)); set { SdkMemory.Copy(value.Pointer,new IntPtr(0xB73418),20); } }
    [NativeMember("OldMouseControllerState")]
    public static CMouseControllerState @OldMouseControllerState { get => new CMouseControllerState(new IntPtr(0xB7342C)); set { SdkMemory.Copy(value.Pointer,new IntPtr(0xB7342C),20); } }
    [NativeMember("NewKeyState")]
    public static CKeyboardState @NewKeyState { get => new CKeyboardState(new IntPtr(0xB73190)); set { SdkMemory.Copy(value.Pointer,new IntPtr(0xB73190),624); } }
    [NativeMember("OldKeyState")]
    public static CKeyboardState @OldKeyState { get => new CKeyboardState(new IntPtr(0xB72F20)); set { SdkMemory.Copy(value.Pointer,new IntPtr(0xB72F20),624); } }
    public void @InitializeAt() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1991 >(1991)(Pointer); }
    public void @UpdateMouse() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1992 >(1992)(Pointer); }
    public void @ReconcileTwoControllersInput(CControllerState @controllerA,CControllerState @controllerB) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1993 >(1993)(Pointer,@controllerA.Pointer,@controllerB.Pointer); }
    public void @SetDrunkInputDelay(int @delay) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1994 >(1994)(Pointer,@delay); }
    public void @StartShake(short @time,byte @frequency,uint @arg2) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1995 >(1995)(Pointer,@time,@frequency,@arg2); }
    public void @StartShake_Distance(short @time,byte @frequency,float @x,float @y,float @z) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1996 >(1996)(Pointer,@time,@frequency,@x,@y,@z); }
    public void @StartShake_Train(float @x,float @y) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1997 >(1997)(Pointer,@x,@y); }
    public void @ProcessPCSpecificStuff() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1998 >(1998)(Pointer); }
    public void @StopShaking(short @arg0) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1999 >(1999)(Pointer,@arg0); }
    public static CPad? @GetPad(int @padNumber) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2000 >(2000)(@padNumber); return __sdkResult == IntPtr.Zero ? null : new CPad(__sdkResult); }
    public short @GetSteeringLeftRight() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2001 >(2001)(Pointer); return __sdkResult; }
    public short @GetSteeringUpDown() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2002 >(2002)(Pointer); return __sdkResult; }
    public short @GetPedWalkLeftRight() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2003 >(2003)(Pointer); return __sdkResult; }
    public short @GetPedWalkUpDown() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2004 >(2004)(Pointer); return __sdkResult; }
    public bool @GetLookLeft() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2005 >(2005)(Pointer); return __sdkResult != 0; }
    public bool @GetLookRight() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2006 >(2006)(Pointer); return __sdkResult != 0; }
    public bool @GetLookBehindForCar() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2007 >(2007)(Pointer); return __sdkResult != 0; }
    public bool @GetLookBehindForPed() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2008 >(2008)(Pointer); return __sdkResult != 0; }
    public bool @GetHorn() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2009 >(2009)(Pointer); return __sdkResult != 0; }
    public bool @HornJustDown() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2010 >(2010)(Pointer); return __sdkResult != 0; }
    public bool @GetHydraulicJump() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2011 >(2011)(Pointer); return __sdkResult != 0; }
    public short @GetCarGunFired() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2012 >(2012)(Pointer); return __sdkResult; }
    public short @CarGunJustDown() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2013 >(2013)(Pointer); return __sdkResult; }
    public short @GetHandBrake() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2014 >(2014)(Pointer); return __sdkResult; }
    public short @GetBrake() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2015 >(2015)(Pointer); return __sdkResult; }
    public bool @GetExitVehicle() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2016 >(2016)(Pointer); return __sdkResult != 0; }
    public bool @ExitVehicleJustDown() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2017 >(2017)(Pointer); return __sdkResult != 0; }
    public byte @GetMeleeAttack(bool @checkButtonCircleStateOnly) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2018 >(2018)(Pointer,(@checkButtonCircleStateOnly ? 1 : 0)); return __sdkResult; }
    public byte @MeleeAttackJustDown() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2019 >(2019)(Pointer); return __sdkResult; }
    public short @GetAccelerate() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2020 >(2020)(Pointer); return __sdkResult; }
    public bool @GetAccelerateJustDown() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2021 >(2021)(Pointer); return __sdkResult != 0; }
    public bool @NextStationJustUp() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2022 >(2022)(Pointer); return __sdkResult != 0; }
    public bool @LastStationJustUp() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2023 >(2023)(Pointer); return __sdkResult != 0; }
    public bool @CycleWeaponLeftJustDown() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2024 >(2024)(Pointer); return __sdkResult != 0; }
    public bool @CycleWeaponRightJustDown() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2025 >(2025)(Pointer); return __sdkResult != 0; }
    public bool @GetTarget() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2026 >(2026)(Pointer); return __sdkResult != 0; }
    public bool @GetDuck() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2027 >(2027)(Pointer); return __sdkResult != 0; }
    public bool @DuckJustDown() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2028 >(2028)(Pointer); return __sdkResult != 0; }
    public bool @GetJump() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2029 >(2029)(Pointer); return __sdkResult != 0; }
    public bool @JumpJustDown() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2030 >(2030)(Pointer); return __sdkResult != 0; }
    public bool @GetSprint() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2031 >(2031)(Pointer); return __sdkResult != 0; }
    public bool @SprintJustDown() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2032 >(2032)(Pointer); return __sdkResult != 0; }
    public bool @ShiftTargetLeftJustDown() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2033 >(2033)(Pointer); return __sdkResult != 0; }
    public bool @ShiftTargetRightJustDown() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2034 >(2034)(Pointer); return __sdkResult != 0; }
    public short @GetDisplayVitalStats(CPed? @ped) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2035 >(2035)(Pointer,@ped?.Pointer ?? IntPtr.Zero); return __sdkResult; }
    public bool @CollectPickupJustDown() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2036 >(2036)(Pointer); return __sdkResult != 0; }
    public bool @GetForceCameraBehindPlayer() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2037 >(2037)(Pointer); return __sdkResult != 0; }
    public bool @SniperZoomIn() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2038 >(2038)(Pointer); return __sdkResult != 0; }
    public bool @SniperZoomOut() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2039 >(2039)(Pointer); return __sdkResult != 0; }
    public bool @GetGroupControlForward() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2040 >(2040)(Pointer); return __sdkResult != 0; }
    public bool @GetGroupControlBack() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2041 >(2041)(Pointer); return __sdkResult != 0; }
    public bool @ConversationYesJustDown() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2042 >(2042)(Pointer); return __sdkResult != 0; }
    public bool @ConversationNoJustDown() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2043 >(2043)(Pointer); return __sdkResult != 0; }
    public bool @GroupControlForwardJustDown() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2044 >(2044)(Pointer); return __sdkResult != 0; }
    public bool @GroupControlBackJustDown() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2045 >(2045)(Pointer); return __sdkResult != 0; }
    public void @Clear(bool @enablePlayerControls,bool @resetPhase) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2046 >(2046)(Pointer,(@enablePlayerControls ? 1 : 0),(@resetPhase ? 1 : 0)); }
    public static void @UpdatePads() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2047 >(2047)(); }
    public static void @ClearMouseHistory() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2048 >(2048)(); }
}
