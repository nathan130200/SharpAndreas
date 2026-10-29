// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CGangs : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=1;
    public CGangs(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("GangAttackWithCops")]
    public static NativeArray<bool> @GangAttackWithCops { get => new NativeArray<bool>(new IntPtr(0xC091DC),16); }
    [NativeMember("Gang")]
    public static NativeObjectArray<CGangInfo> @Gang { get => new NativeObjectArray<CGangInfo>(new IntPtr(0xC091F0),10,16); }
    public static int @ChooseGangPedModel(short @gangID) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2780 >(2780)(@gangID); return __sdkResult; }
    public static bool @GetWillAttackPlayerWithCops(ePedType @gangID) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2781 >(2781)((int)@gangID); return __sdkResult != 0; }
    public static void @Initialise() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2782 >(2782)(); }
    public static void @Load() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2783 >(2783)(); }
    public static void @Save() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2784 >(2784)(); }
    public static void @SetGangPedModelOverride(short @gangID,sbyte @PedModelOverride) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2785 >(2785)(@gangID,@PedModelOverride); }
    public static void @SetGangWeapons(short @gangID,int @weapID1,int @weapID2,int @weapID3) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2786 >(2786)(@gangID,@weapID1,@weapID2,@weapID3); }
    public static void @SetWillAttackPlayerWithCops(ePedType @gangID,bool @bAttackPlayerWithCops) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2787 >(2787)((int)@gangID,(@bAttackPlayerWithCops ? 1 : 0)); }
}
