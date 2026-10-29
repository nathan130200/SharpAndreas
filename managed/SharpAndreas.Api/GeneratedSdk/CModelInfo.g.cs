// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CModelInfo : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=1;
    public CModelInfo(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("ms_modelInfoPtrs")]
    public static NativePointer<IntPtr> @ModelInfoPtrs { get => new NativePointer<IntPtr>(SdkMemory.Read<IntPtr>(new IntPtr(0x40CD67))); }
    [NativeMember("ms_modelInfoCount")]
    public static int @ModelInfoCount { get => SdkMemory.Read<int >(new IntPtr(0x40CD58)); }
    public static void @Initialise() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D474 >(474)(); }
    public static void @ReInit2dEffects() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D475 >(475)(); }
    public static void @ShutDown() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D476 >(476)(); }
    public static CAtomicModelInfo? @AddAtomicModel(int @modelId) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D477 >(477)(@modelId); return __sdkResult == IntPtr.Zero ? null : new CAtomicModelInfo(__sdkResult); }
    public static CDamageAtomicModelInfo? @AddDamageAtomicModel(int @modelId) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D478 >(478)(@modelId); return __sdkResult == IntPtr.Zero ? null : new CDamageAtomicModelInfo(__sdkResult); }
    public static CLodAtomicModelInfo? @AddLodAtomicModel(int @modelId) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D479 >(479)(@modelId); return __sdkResult == IntPtr.Zero ? null : new CLodAtomicModelInfo(__sdkResult); }
    public static CTimeModelInfo? @AddTimeModel(int @modelId) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D480 >(480)(@modelId); return __sdkResult == IntPtr.Zero ? null : new CTimeModelInfo(__sdkResult); }
    public static CLodTimeModelInfo? @AddLodTimeModel(int @modelId) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D481 >(481)(@modelId); return __sdkResult == IntPtr.Zero ? null : new CLodTimeModelInfo(__sdkResult); }
    public static CWeaponModelInfo? @AddWeaponModel(int @modelId) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D482 >(482)(@modelId); return __sdkResult == IntPtr.Zero ? null : new CWeaponModelInfo(__sdkResult); }
    public static CClumpModelInfo? @AddClumpModel(int @modelId) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D483 >(483)(@modelId); return __sdkResult == IntPtr.Zero ? null : new CClumpModelInfo(__sdkResult); }
    public static CVehicleModelInfo? @AddVehicleModel(int @modelId) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D484 >(484)(@modelId); return __sdkResult == IntPtr.Zero ? null : new CVehicleModelInfo(__sdkResult); }
    public static CPedModelInfo? @AddPedModel(int @modelId) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D485 >(485)(@modelId); return __sdkResult == IntPtr.Zero ? null : new CPedModelInfo(__sdkResult); }
    public static NativePointer<int> @Get2dEffectStore() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D486 >(486)(); return new NativePointer<int>(__sdkResult); }
    public static CBaseModelInfo? @GetModelInfo(int @modelId) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D487 >(487)(@modelId); return __sdkResult == IntPtr.Zero ? null : new CBaseModelInfo(__sdkResult); }
    public static CBaseModelInfo? @GetModelInfo(NativePointer<sbyte> @name,NativePointer<int> @modelId) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D488 >(488)(@name.Pointer,@modelId.Pointer); return __sdkResult == IntPtr.Zero ? null : new CBaseModelInfo(__sdkResult); }
    public static CBaseModelInfo? @GetModelInfo(NativePointer<sbyte> @name,int @minmodelId,int @maxInedx) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D489 >(489)(@name.Pointer,@minmodelId,@maxInedx); return __sdkResult == IntPtr.Zero ? null : new CBaseModelInfo(__sdkResult); }
    public static CBaseModelInfo? @GetModelInfoFromHashKey(uint @arg0,NativePointer<int> @modelId) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D490 >(490)(@arg0,@modelId.Pointer); return __sdkResult == IntPtr.Zero ? null : new CBaseModelInfo(__sdkResult); }
    public static CBaseModelInfo? @GetModelInfoUInt16(NativePointer<sbyte> @name,NativePointer<int> @modelId) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D491 >(491)(@name.Pointer,@modelId.Pointer); return __sdkResult == IntPtr.Zero ? null : new CBaseModelInfo(__sdkResult); }
    public static int @FindNextModel(eModelInfoType @type,int @startModelId,bool @searchForward,bool @warpAround) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D492 >(492)((int)@type,@startModelId,(@searchForward ? 1 : 0),(@warpAround ? 1 : 0)); return __sdkResult; }
    public static bool @IsPedModel(int @modelId) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D493 >(493)(@modelId); return __sdkResult != 0; }
    public static bool @IsVehicleModel(int @modelId) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D494 >(494)(@modelId); return __sdkResult != 0; }
    public static eVehicleType @GetVehicleModelType(int @modelId) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D495 >(495)(@modelId); return (eVehicleType)__sdkResult; }
    public static bool @IsBikeModel(int @modelId) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D496 >(496)(@modelId); return __sdkResult != 0; }
    public static bool @IsBmxModel(int @modelId) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D497 >(497)(@modelId); return __sdkResult != 0; }
    public static bool @IsBoatModel(int @modelId) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D498 >(498)(@modelId); return __sdkResult != 0; }
    public static bool @IsCarModel(int @modelId) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D499 >(499)(@modelId); return __sdkResult != 0; }
    public static bool @IsHeliModel(int @modelId) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D500 >(500)(@modelId); return __sdkResult != 0; }
    public static bool @IsMonsterTruckModel(int @modelId) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D501 >(501)(@modelId); return __sdkResult != 0; }
    public static bool @IsPlaneModel(int @modelId) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D502 >(502)(@modelId); return __sdkResult != 0; }
    public static bool @IsQuadBikeModel(int @modelId) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D503 >(503)(@modelId); return __sdkResult != 0; }
    public static bool @IsTrailerModel(int @modelId) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D504 >(504)(@modelId); return __sdkResult != 0; }
    public static bool @IsTrainModel(int @modelId) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D505 >(505)(@modelId); return __sdkResult != 0; }
}
