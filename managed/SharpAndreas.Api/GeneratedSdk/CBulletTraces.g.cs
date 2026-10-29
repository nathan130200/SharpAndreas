// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CBulletTraces : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=1;
    public CBulletTraces(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("aTraces")]
    public static CBulletTrace? @Traces { get => new IntPtr(0xC7C748) == IntPtr.Zero ? null : new CBulletTrace(new IntPtr(0xC7C748)); }
    public static void @AddTrace(CVector? @start,CVector? @end,int @weaponType,CEntity? @entity) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1243 >(1243)(@start?.Pointer ?? IntPtr.Zero,@end?.Pointer ?? IntPtr.Zero,@weaponType,@entity?.Pointer ?? IntPtr.Zero); }
    public static void @AddTrace(CVector? @start,CVector? @end,float @radius,uint @time,byte @transparency) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1244 >(1244)(@start?.Pointer ?? IntPtr.Zero,@end?.Pointer ?? IntPtr.Zero,@radius,@time,@transparency); }
    public static void @Render() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1245 >(1245)(); }
    public static void @Update() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1246 >(1246)(); }
    public static void @Init() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1247 >(1247)(); }
}
