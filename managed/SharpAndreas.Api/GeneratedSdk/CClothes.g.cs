// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CClothes : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=1;
    public CClothes(System.IntPtr pointer) : base(pointer) {}
    public static void @ConstructPedModel(uint @modelid,CPedClothesDesc @newclothes,CPedClothesDesc? @oldclothes,bool @bCutscenePlayer) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2111 >(2111)(@modelid,@newclothes.Pointer,@oldclothes?.Pointer ?? IntPtr.Zero,(@bCutscenePlayer ? 1 : 0)); }
    public static void @RequestMotionGroupAnims() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2112 >(2112)(); }
    public static void @RebuildPlayerIfNeeded(CPlayerPed? @player) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2113 >(2113)(@player?.Pointer ?? IntPtr.Zero); }
    public static void @RebuildPlayer(CPlayerPed? @player,bool @bIgnoreFatAndMuscle) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2114 >(2114)(@player?.Pointer ?? IntPtr.Zero,(@bIgnoreFatAndMuscle ? 1 : 0)); }
    public static void @RebuildCutscenePlayer(CPlayerPed? @player,int @modelid) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2115 >(2115)(@player?.Pointer ?? IntPtr.Zero,@modelid); }
    public static void @LoadClothesFile() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2116 >(2116)(); }
    public static void @Init() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2117 >(2117)(); }
    public static eClothesModelPart @GetTextureDependency(int @eClothesTexturePart) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2118 >(2118)(@eClothesTexturePart); return (eClothesModelPart)__sdkResult; }
    public static int @GetPlayerMotionGroupToLoad() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2119 >(2119)(); return __sdkResult; }
    public static eClothesTexturePart @GetDependentTexture(int @eClothesModelPart) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2120 >(2120)(@eClothesModelPart); return (eClothesTexturePart)__sdkResult; }
    public static int @GetDefaultPlayerMotionGroup() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2121 >(2121)(); return __sdkResult; }
}
