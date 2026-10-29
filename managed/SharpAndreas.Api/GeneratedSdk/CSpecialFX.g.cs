// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CSpecialFX : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=1;
    public CSpecialFX(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("bVideoCam")]
    public static bool @VideoCam { get => SdkMemory.Read<bool >(new IntPtr(0xC7C70C)); set { SdkMemory.Write(new IntPtr(0xC7C70C),value); } }
    [NativeMember("bLiftCam")]
    public static bool @LiftCam { get => SdkMemory.Read<bool >(new IntPtr(0xC7C70D)); set { SdkMemory.Write(new IntPtr(0xC7C70D),value); } }
    [NativeMember("SnapShotFrames")]
    public static uint @SnapShotFrames { get => SdkMemory.Read<uint >(new IntPtr(0xC7C710)); set { SdkMemory.Write(new IntPtr(0xC7C710),value); } }
    [NativeMember("bSnapShotActive")]
    public static bool @SnapShotActive { get => SdkMemory.Read<bool >(new IntPtr(0xC7C714)); set { SdkMemory.Write(new IntPtr(0xC7C714),value); } }
    public static void @AddWeaponStreak(int @weaponType) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3782 >(3782)(@weaponType); }
    public static void @Init() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3783 >(3783)(); }
    public static void @Render() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3784 >(3784)(); }
    public static void @Render2DFXs() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3785 >(3785)(); }
    public static void @ReplayStarted() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3786 >(3786)(); }
    public static void @Shutdown() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3787 >(3787)(); }
    public static void @Update() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3788 >(3788)(); }
}
