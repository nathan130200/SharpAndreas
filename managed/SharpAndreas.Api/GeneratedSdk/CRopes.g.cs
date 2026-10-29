// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CRopes : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=1;
    public CRopes(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("ms_bPlayerControlsCrane")]
    public static int @PlayerControlsCrane { get => SdkMemory.Read<int >(new IntPtr(0xB76898)); set { SdkMemory.Write(new IntPtr(0xB76898),value); } }
    [NativeMember("MAX_NUM_ROPES")]
    public static int @MAXCountROPES { get => SdkMemory.Read<int >(SdkBindings.Address(4653)); }
    [NativeMember("m_nRopeIdCreationCounter")]
    public static uint @RopeIdCreationCounter { get => SdkMemory.Read<uint >(new IntPtr(0xB781F8)); set { SdkMemory.Write(new IntPtr(0xB781F8),value); } }
    [NativeMember("ms_aRopes")]
    public static NativeObjectArray<CRope> @Ropes { get => new NativeObjectArray<CRope>(SdkBindings.Address(4654),8,808); }
    public static void @Init() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3617 >(3617)(); }
    public static void @Shutdown() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3618 >(3618)(); }
    public static void @Update() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3619 >(3619)(); }
    public static void @Render() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3620 >(3620)(); }
    public static bool @RegisterRope(uint @ropeId,uint @ropeType,CVector @startPos,bool @expires,byte @segmentCount,byte @flags,CEntity? @holder,uint @timeExpire) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3621 >(3621)(@ropeId,@ropeType,@startPos.Pointer,(@expires ? 1 : 0),@segmentCount,@flags,@holder?.Pointer ?? IntPtr.Zero,@timeExpire); return __sdkResult != 0; }
    public static float @FindPickupHeight(CEntity? @entity) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3622 >(3622)(@entity?.Pointer ?? IntPtr.Zero); return __sdkResult; }
    public static uint @FindRope(uint @ropeId) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3623 >(3623)(@ropeId); return __sdkResult; }
    public static bool @FindCoorsAlongRope(uint @ropeId,float @dist,CVector? @outPosn,CVector? @outSpeed) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3624 >(3624)(@ropeId,@dist,@outPosn?.Pointer ?? IntPtr.Zero,@outSpeed?.Pointer ?? IntPtr.Zero); return __sdkResult != 0; }
    public static uint @CreateRopeForSwatPed(CVector @startPos) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3625 >(3625)(@startPos.Pointer); return __sdkResult; }
    public static bool @IsCarriedByRope(CEntity? @entity) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3626 >(3626)(@entity?.Pointer ?? IntPtr.Zero); return __sdkResult != 0; }
    public static void @SetSpeedOfTopNode(uint @ropeId,CVector @dirSpeed) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3627 >(3627)(@ropeId,@dirSpeed.Pointer); }
}
