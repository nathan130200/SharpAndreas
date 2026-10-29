// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CPools : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=1;
    public CPools(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("ms_pPedPool")]
    public static CPool_CPed__CCopPed__d77fc80151? @PedPool { get => SdkMemory.Read<IntPtr>(new IntPtr(0xB74490)) == IntPtr.Zero ? null : new CPool_CPed__CCopPed__d77fc80151(SdkMemory.Read<IntPtr>(new IntPtr(0xB74490))); set { SdkMemory.Write(new IntPtr(0xB74490),value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("ms_pVehiclePool")]
    public static CPool_CVehicle__CHeli__9049900219? @VehiclePool { get => SdkMemory.Read<IntPtr>(new IntPtr(0xB74494)) == IntPtr.Zero ? null : new CPool_CVehicle__CHeli__9049900219(SdkMemory.Read<IntPtr>(new IntPtr(0xB74494))); set { SdkMemory.Write(new IntPtr(0xB74494),value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("ms_pBuildingPool")]
    public static CPool_CBuilding__3e46ed39ad? @BuildingPool { get => SdkMemory.Read<IntPtr>(new IntPtr(0xB74498)) == IntPtr.Zero ? null : new CPool_CBuilding__3e46ed39ad(SdkMemory.Read<IntPtr>(new IntPtr(0xB74498))); set { SdkMemory.Write(new IntPtr(0xB74498),value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("ms_pObjectPool")]
    public static CPool_CObject__CCutsceneObject__38d8847ca5? @ObjectPool { get => SdkMemory.Read<IntPtr>(new IntPtr(0xB7449C)) == IntPtr.Zero ? null : new CPool_CObject__CCutsceneObject__38d8847ca5(SdkMemory.Read<IntPtr>(new IntPtr(0xB7449C))); set { SdkMemory.Write(new IntPtr(0xB7449C),value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("ms_pDummyPool")]
    public static CPool_CDummy__db27ce33c5? @DummyPool { get => SdkMemory.Read<IntPtr>(new IntPtr(0xB744A0)) == IntPtr.Zero ? null : new CPool_CDummy__db27ce33c5(SdkMemory.Read<IntPtr>(new IntPtr(0xB744A0))); set { SdkMemory.Write(new IntPtr(0xB744A0),value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("ms_pColModelPool")]
    public static CPool_CColModel__b1f156114c? @CollisionModelPool { get => SdkMemory.Read<IntPtr>(new IntPtr(0xB744A4)) == IntPtr.Zero ? null : new CPool_CColModel__b1f156114c(SdkMemory.Read<IntPtr>(new IntPtr(0xB744A4))); set { SdkMemory.Write(new IntPtr(0xB744A4),value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("ms_pTaskPool")]
    public static CPool_CTask__char_128___3d29e1ebe4? @TaskPool { get => SdkMemory.Read<IntPtr>(new IntPtr(0xB744A8)) == IntPtr.Zero ? null : new CPool_CTask__char_128___3d29e1ebe4(SdkMemory.Read<IntPtr>(new IntPtr(0xB744A8))); set { SdkMemory.Write(new IntPtr(0xB744A8),value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("ms_pPedIntelligencePool")]
    public static CPool_CPedIntelligence__464a47c450? @PedIntelligencePool { get => SdkMemory.Read<IntPtr>(new IntPtr(0xB744C0)) == IntPtr.Zero ? null : new CPool_CPedIntelligence__464a47c450(SdkMemory.Read<IntPtr>(new IntPtr(0xB744C0))); set { SdkMemory.Write(new IntPtr(0xB744C0),value?.Pointer ?? IntPtr.Zero); } }
    public static int @CheckBuildingAtomics() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3400 >(3400)(); return __sdkResult; }
    public static void @CheckPoolsEmpty() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3401 >(3401)(); }
    public static CObject? @GetObject(int @handle) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3402 >(3402)(@handle); return __sdkResult == IntPtr.Zero ? null : new CObject(__sdkResult); }
    public static int @GetObjectRef(CObject? @object) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3403 >(3403)(@object?.Pointer ?? IntPtr.Zero); return __sdkResult; }
    public static CPed? @GetPed(int @handle) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3404 >(3404)(@handle); return __sdkResult == IntPtr.Zero ? null : new CPed(__sdkResult); }
    public static int @GetPedRef(CPed? @ped) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3405 >(3405)(@ped?.Pointer ?? IntPtr.Zero); return __sdkResult; }
    public static CVehicle? @GetVehicle(int @handle) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3406 >(3406)(@handle); return __sdkResult == IntPtr.Zero ? null : new CVehicle(__sdkResult); }
    public static int @GetVehicleRef(CVehicle? @vehicle) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3407 >(3407)(@vehicle?.Pointer ?? IntPtr.Zero); return __sdkResult; }
    public static void @Initialise() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3408 >(3408)(); }
    public static bool @Load() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3409 >(3409)(); return __sdkResult != 0; }
    public static bool @LoadObjectPool() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3410 >(3410)(); return __sdkResult != 0; }
    public static bool @LoadPedPool() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3411 >(3411)(); return __sdkResult != 0; }
    public static bool @LoadVehiclePool() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3412 >(3412)(); return __sdkResult != 0; }
    public static void @MakeSureSlotInObjectPoolIsEmpty(int @slot) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3413 >(3413)(@slot); }
    public static bool @Save() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3414 >(3414)(); return __sdkResult != 0; }
    public static bool @SaveObjectPool() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3415 >(3415)(); return __sdkResult != 0; }
    public static bool @SavePedPool() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3416 >(3416)(); return __sdkResult != 0; }
    public static bool @SaveVehiclePool() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3417 >(3417)(); return __sdkResult != 0; }
    public static void @ShutDown() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3418 >(3418)(); }
}
