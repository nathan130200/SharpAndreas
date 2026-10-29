// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CPlaneTrails : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=1;
    public CPlaneTrails(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("aArray")]
    public static CPlaneTrail? @Array { get => new IntPtr(0xC713A8) == IntPtr.Zero ? null : new CPlaneTrail(new IntPtr(0xC713A8)); }
    public static void @Init() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3372 >(3372)(); }
    public static void @Update() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3373 >(3373)(); }
    public static void @RegisterPoint(CVector @point,uint @trailIndex) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3374 >(3374)(@point.Pointer,@trailIndex); }
}
