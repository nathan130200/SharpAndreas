// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CPlantMgr : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=1;
    public CPlantMgr(System.IntPtr pointer) : base(pointer) {}
    public static void @UpdateAmbientColor() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3375 >(3375)(); }
    public static float @CalculateWindBending() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3376 >(3376)(); return __sdkResult; }
    public static void @SetPlantFriendlyFlagInAtomicMI(CAtomicModelInfo? @mi) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3377 >(3377)(@mi?.Pointer ?? IntPtr.Zero); }
    public static void @Shutdown() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3378 >(3378)(); }
    public static void @Render() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3379 >(3379)(); }
    public static void @_ProcessEntryCollisionDataSections_RemoveLocTris(CPlantColEntEntry? @col,CVector @camPos,int @triProcessSkipMask,int @colStartIndex,int @colEndIndex) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3380 >(3380)(@col?.Pointer ?? IntPtr.Zero,@camPos.Pointer,@triProcessSkipMask,@colStartIndex,@colEndIndex); }
    public static void @_ColEntityCache_Update(CVector @camPos,byte @quickUpdate) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3381 >(3381)(@camPos.Pointer,@quickUpdate); }
    public static void @_ProcessEntryCollisionDataSections_AddLocTris(CPlantColEntEntry? @col,CVector @camPos,int @processSkipMask,int @colStartIndex,int @colEndIndex) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3382 >(3382)(@col?.Pointer ?? IntPtr.Zero,@camPos.Pointer,@processSkipMask,@colStartIndex,@colEndIndex); }
    public static void @_ProcessEntryCollisionDataSections(CPlantColEntEntry? @col,CVector @camPos,int @processSkipMask) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3383 >(3383)(@col?.Pointer ?? IntPtr.Zero,@camPos.Pointer,@processSkipMask); }
    public static void @_UpdateLocTris(CVector @camPos,int @processSkipMask) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3384 >(3384)(@camPos.Pointer,@processSkipMask); }
    public static void @PreUpdateOnceForNewCameraPos(CVector @camPos) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3385 >(3385)(@camPos.Pointer); }
    public static void @Update(CVector @camPos) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3386 >(3386)(@camPos.Pointer); }
    public static bool @ReloadConfig() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3387 >(3387)(); return __sdkResult != 0; }
    public static bool @Initialise() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3388 >(3388)(); return __sdkResult != 0; }
}
