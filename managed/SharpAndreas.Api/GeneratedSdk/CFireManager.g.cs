// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CFireManager : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=2404;
    public CFireManager(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_aFires")]
    public NativeObjectArray<CFire> @Fires { get => new NativeObjectArray<CFire>(Pointer+0,60,40); }
    [NativeMember("m_nMaxFireGenerationsAllowed")]
    public uint @MaxFireGenerationsAllowed { get => SdkMemory.Read<uint >(Pointer+2400); set { SdkMemory.Write(Pointer+2400,value); } }
    public void @InitializeAt() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2609 >(2609)(Pointer); }
    public void @DestroyNative() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2610 >(2610)(Pointer); }
    public void @Init() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2611 >(2611)(Pointer); }
    public uint @GetNumOfNonScriptFires() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2612 >(2612)(Pointer); return __sdkResult; }
    public CFire? @FindNearestFire(CVector @position,bool @notBeingExtinguished,bool @notScript) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2613 >(2613)(Pointer,@position.Pointer,(@notBeingExtinguished ? 1 : 0),(@notScript ? 1 : 0)); return __sdkResult == IntPtr.Zero ? null : new CFire(__sdkResult); }
    public bool @PlentyFiresAvailable() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2614 >(2614)(Pointer); return __sdkResult != 0; }
    public void @ExtinguishPoint(CVector @point,float @range) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2615 >(2615)(Pointer,@point.Pointer,@range); }
    public bool @ExtinguishPointWithWater(CVector @point,float @range,float @fireSizeMp) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2616 >(2616)(Pointer,@point.Pointer,@range,@fireSizeMp); return __sdkResult != 0; }
    public bool @IsScriptFireExtinguished(short @fireIndex) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2617 >(2617)(Pointer,@fireIndex); return __sdkResult != 0; }
    public void @RemoveScriptFire(short @fireIndex) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2618 >(2618)(Pointer,@fireIndex); }
    public void @RemoveAllScriptFires() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2619 >(2619)(Pointer); }
    public void @ClearAllScriptFireFlags() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2620 >(2620)(Pointer); }
    public void @SetScriptFireAudio(short @fireIndex,bool @enable) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2621 >(2621)(Pointer,@fireIndex,(@enable ? 1 : 0)); }
    public CVector? @GetScriptFireCoords(short @fireIndex) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2622 >(2622)(Pointer,@fireIndex); return __sdkResult == IntPtr.Zero ? null : new CVector(__sdkResult); }
    public uint @GetNumFiresInRange(CVector? @point,float @range) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2623 >(2623)(Pointer,@point?.Pointer ?? IntPtr.Zero,@range); return __sdkResult; }
    public uint @GetNumFiresInArea(float @cornerA_x,float @cornerA_y,float @cornerA_z,float @cornerB_x,float @cornerB_y,float @cornerB_z) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2624 >(2624)(Pointer,@cornerA_x,@cornerA_y,@cornerA_z,@cornerB_x,@cornerB_y,@cornerB_z); return __sdkResult; }
    public void @DestroyAllFxSystems() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2625 >(2625)(Pointer); }
    public void @CreateAllFxSystems() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2626 >(2626)(Pointer); }
    public void @Shutdown() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2627 >(2627)(Pointer); }
    public void @GetNextFreeFire(byte @bAllowDeletingOldFire) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2628 >(2628)(Pointer,@bAllowDeletingOldFire); }
    public CFire? @StartFire(CVector @point,float @size,byte @arg2,CEntity? @creator,uint @time,sbyte @numGenerations,byte @arg6) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2629 >(2629)(Pointer,@point.Pointer,@size,@arg2,@creator?.Pointer ?? IntPtr.Zero,@time,@numGenerations,@arg6); return __sdkResult == IntPtr.Zero ? null : new CFire(__sdkResult); }
    public CFire? @StartFire(CEntity? @target,CEntity? @creator,float @size,byte @arg3,uint @time,sbyte @numGenerations) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2630 >(2630)(Pointer,@target?.Pointer ?? IntPtr.Zero,@creator?.Pointer ?? IntPtr.Zero,@size,@arg3,@time,@numGenerations); return __sdkResult == IntPtr.Zero ? null : new CFire(__sdkResult); }
    public int @StartScriptFire(CVector @point,CEntity? @target,float @arg2,byte @arg3,sbyte @numGenerations,int @size) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2631 >(2631)(Pointer,@point.Pointer,@target?.Pointer ?? IntPtr.Zero,@arg2,@arg3,@numGenerations,@size); return __sdkResult; }
    public void @Update() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2632 >(2632)(Pointer); }
}
