// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CMotionBlurStreaks : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=1;
    public CMotionBlurStreaks(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("aStreaks")]
    public static CRegisteredMotionBlurStreak? @Streaks { get => new IntPtr(0xC7CA08) == IntPtr.Zero ? null : new CRegisteredMotionBlurStreak(new IntPtr(0xC7CA08)); }
    public static void @Update() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3210 >(3210)(); }
    public static void @Render() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3211 >(3211)(); }
    public static void @RegisterStreak(uint @id,byte @red,byte @green,byte @blue,CVector @leftPoint,CVector @rightPoint) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3212 >(3212)(@id,@red,@green,@blue,@leftPoint.Pointer,@rightPoint.Pointer); }
    public static void @Init() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3213 >(3213)(); }
}
