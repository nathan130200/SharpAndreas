// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CStuntJumpManager : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=1;
    public CStuntJumpManager(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("mp_poolStuntJumps")]
    public static CPool_CStuntJump__a70ba0d11f? @MpPoolStuntJumps { get => SdkMemory.Read<IntPtr>(new IntPtr(0xA9A888)) == IntPtr.Zero ? null : new CPool_CStuntJump__a70ba0d11f(SdkMemory.Read<IntPtr>(new IntPtr(0xA9A888))); set { SdkMemory.Write(new IntPtr(0xA9A888),value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("mp_Active")]
    public static CStuntJump? @MpActive { get => SdkMemory.Read<IntPtr>(new IntPtr(0xA9A88C)) == IntPtr.Zero ? null : new CStuntJump(SdkMemory.Read<IntPtr>(new IntPtr(0xA9A88C))); set { SdkMemory.Write(new IntPtr(0xA9A88C),value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_bActive")]
    public static bool @Active { get => SdkMemory.Read<bool >(new IntPtr(0xA9A890)); set { SdkMemory.Write(new IntPtr(0xA9A890),value); } }
    [NativeMember("m_bHitReward")]
    public static bool @HitReward { get => SdkMemory.Read<bool >(new IntPtr(0xA9A891)); set { SdkMemory.Write(new IntPtr(0xA9A891),value); } }
    [NativeMember("m_iTimer")]
    public static uint @ITimer { get => SdkMemory.Read<uint >(new IntPtr(0xA9A894)); set { SdkMemory.Write(new IntPtr(0xA9A894),value); } }
    [NativeMember("m_jumpState")]
    public static eJumpState @JumpState { get => SdkMemory.Read<eJumpState >(new IntPtr(0xA9A898)); set { SdkMemory.Write(new IntPtr(0xA9A898),value); } }
    [NativeMember("m_iNumJumps")]
    public static int @ICountJumps { get => SdkMemory.Read<int >(new IntPtr(0xA9A89C)); set { SdkMemory.Write(new IntPtr(0xA9A89C),value); } }
    [NativeMember("m_iNumCompleted")]
    public static uint @ICountCompleted { get => SdkMemory.Read<uint >(new IntPtr(0xA9A8A0)); set { SdkMemory.Write(new IntPtr(0xA9A8A0),value); } }
    public static bool @Save() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3993 >(3993)(); return __sdkResult != 0; }
    public static bool @Load() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3994 >(3994)(); return __sdkResult != 0; }
}
