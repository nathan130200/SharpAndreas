// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CEntryExitManager : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=1;
    public CEntryExitManager(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("ms_entryExitStack")]
    public static NativeArray<IntPtr> @EntryExitStack { get => new NativeArray<IntPtr>(new IntPtr(0x96A720),4); }
    [NativeMember("ms_bBurglaryHousesEnabled")]
    public static bool @BurglaryHousesEnabled { get => SdkMemory.Read<bool >(new IntPtr(0x96A730)); set { SdkMemory.Write(new IntPtr(0x96A730),value); } }
    [NativeMember("ms_oldAreaCode")]
    public static int @OldAreaCode { get => SdkMemory.Read<int >(new IntPtr(0x96A734)); set { SdkMemory.Write(new IntPtr(0x96A734),value); } }
    [NativeMember("ms_visibleEntityList")]
    public static NativeArray<IntPtr> @VisibleEntityList { get => new NativeArray<IntPtr>(new IntPtr(0x96A738),32); }
    [NativeMember("ms_entryExitStackPosn")]
    public static int @EntryExitStackPosition { get => SdkMemory.Read<int >(new IntPtr(0x96A7C4)); set { SdkMemory.Write(new IntPtr(0x96A7C4),value); } }
    [NativeMember("ms_bDisabled")]
    public static bool @Disabled { get => SdkMemory.Read<bool >(new IntPtr(0x96A7C8)); set { SdkMemory.Write(new IntPtr(0x96A7C8),value); } }
    [NativeMember("ms_exitEnterState")]
    public static int @ExitEnterState { get => SdkMemory.Read<int >(new IntPtr(0x96A7CC)); set { SdkMemory.Write(new IntPtr(0x96A7CC),value); } }
    [NativeMember("mp_QuadTree")]
    public static CQuadTreeNode? @MpQuadTree { get => SdkMemory.Read<IntPtr>(new IntPtr(0x96A7D0)) == IntPtr.Zero ? null : new CQuadTreeNode(SdkMemory.Read<IntPtr>(new IntPtr(0x96A7D0))); set { SdkMemory.Write(new IntPtr(0x96A7D0),value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("mp_Active")]
    public static CEntryExit? @MpActive { get => SdkMemory.Read<IntPtr>(new IntPtr(0x96A7D4)) == IntPtr.Zero ? null : new CEntryExit(SdkMemory.Read<IntPtr>(new IntPtr(0x96A7D4))); set { SdkMemory.Write(new IntPtr(0x96A7D4),value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("mp_poolEntryExits")]
    public static CPool_CEntryExit__b09ccd2407? @MpPoolEntryExits { get => SdkMemory.Read<IntPtr>(new IntPtr(0x96A7D8)) == IntPtr.Zero ? null : new CPool_CEntryExit__b09ccd2407(SdkMemory.Read<IntPtr>(new IntPtr(0x96A7D8))); set { SdkMemory.Write(new IntPtr(0x96A7D8),value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("ms_numVisibleEntities")]
    public static uint @CountVisibleEntities { get => SdkMemory.Read<uint >(new IntPtr(0x96A7DC)); set { SdkMemory.Write(new IntPtr(0x96A7DC),value); } }
    public static void @AddEntryExitToStack(CEntryExit? @a1) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2502 >(2502)(@a1?.Pointer ?? IntPtr.Zero); }
    public static int @AddOne(float @entranceX,float @entranceY,float @entranceZ,float @entranceAngle,float @entranceRangeX,float @entranceRangeY,int @unused,float @exitX,float @exitY,float @exitZ,float @exitAngle,int @area,int @flags,int @skyColor,int @timeOn,int @timeOff,int @numberOfPeds,NativePointer<sbyte> @name) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2503 >(2503)(@entranceX,@entranceY,@entranceZ,@entranceAngle,@entranceRangeX,@entranceRangeY,@unused,@exitX,@exitY,@exitZ,@exitAngle,@area,@flags,@skyColor,@timeOn,@timeOff,@numberOfPeds,@name.Pointer); return __sdkResult; }
    public static void @DeleteOne(int @index) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2504 >(2504)(@index); }
    public static void @EnableBurglaryHouses(bool @enable) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2505 >(2505)((@enable ? 1 : 0)); }
    public static CEntity? @FindNearestDoor(CEntryExit @entryExit,float @range) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2506 >(2506)(@entryExit.Pointer,@range); return __sdkResult == IntPtr.Zero ? null : new CEntity(__sdkResult); }
    public static int @FindNearestEntryExit(CVector2D @position,float @range,int @ignoreArea) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2507 >(2507)(@position.Pointer,@range,@ignoreArea); return __sdkResult; }
    public static CEntryExit? @GetEntryExit(int @index) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2508 >(2508)(@index); return __sdkResult == IntPtr.Zero ? null : new CEntryExit(__sdkResult); }
    public static int @GetEntryExitIndex(NativePointer<sbyte> @name,ushort @enabledFlags,ushort @disabledFlags) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2509 >(2509)(@name.Pointer,@enabledFlags,@disabledFlags); return __sdkResult; }
    public static void @GetPositionRelativeToOutsideWorld(CVector @positionInOut) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2510 >(2510)(@positionInOut.Pointer); }
    public static void @GotoEntryExit(CEntryExit? @entryExit) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2511 >(2511)(@entryExit?.Pointer ?? IntPtr.Zero); }
    public static void @GotoEntryExitVC(NativePointer<sbyte> @name) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2512 >(2512)(@name.Pointer); }
    public static void @GotoNextEntryExit() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2513 >(2513)(); }
    public static void @GotoPreviousEntryExit() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2514 >(2514)(); }
    public static void @Init() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2515 >(2515)(); }
    public static void @LinkEntryExit(CEntryExit? @entryExit) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2516 >(2516)(@entryExit?.Pointer ?? IntPtr.Zero); }
    public static bool @Load() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2517 >(2517)(); return __sdkResult != 0; }
    public static void @PostEntryExitsCreation() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2518 >(2518)(); }
    public static void @ResetAreaCodeForVisibleObjects() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2519 >(2519)(); }
    public static bool @Save() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2520 >(2520)(); return __sdkResult != 0; }
    public static void @SetAreaCodeForVisibleObjects() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2521 >(2521)(); }
    public static void @SetEnabled(int @index,bool @enable) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2522 >(2522)(@index,(@enable ? 1 : 0)); }
    public static void @SetEnabledByName(NativePointer<sbyte> @name,bool @enable) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2523 >(2523)(@name.Pointer,(@enable ? 1 : 0)); }
    public static void @SetEntryExitFlag(NativePointer<sbyte> @name,uint @flag,bool @enable) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2524 >(2524)(@name.Pointer,@flag,(@enable ? 1 : 0)); }
    public static void @SetEntryExitFlagWithIndex(int @index,uint @flag,bool @enable) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2525 >(2525)(@index,@flag,(@enable ? 1 : 0)); }
    public static void @Shutdown() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2526 >(2526)(); }
    public static void @ShutdownForRestart() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2527 >(2527)(); }
    public static void @Update() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2528 >(2528)(); }
    public static bool @WeAreInInteriorTransition() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2529 >(2529)(); return __sdkResult != 0; }
}
