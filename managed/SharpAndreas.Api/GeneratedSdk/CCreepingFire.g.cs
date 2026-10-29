// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CCreepingFire : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=1;
    public CCreepingFire(System.IntPtr pointer) : base(pointer) {}
    public static bool @TryToStartFireAtCoors(CVector @posn,sbyte @numGenerations,bool @arg2,bool @scriptFire,float @zDistance) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2320 >(2320)(@posn.Pointer,@numGenerations,(@arg2 ? 1 : 0),(@scriptFire ? 1 : 0),@zDistance); return __sdkResult != 0; }
    public static void @SetReadyToBurn() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2321 >(2321)(); }
    public static void @Update() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2322 >(2322)(); }
}
