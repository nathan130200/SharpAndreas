// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CLocalisation : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=1;
    public CLocalisation(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("nastyGame")]
    public static bool @NastyGame { get => SdkMemory.Read<bool >(new IntPtr(0xB9B7EC)); set { SdkMemory.Write(new IntPtr(0xB9B7EC),value); } }
    [NativeMember("germanGame")]
    public static bool @GermanGameValue { get => SdkMemory.Read<bool >(new IntPtr(0xB9B7ED)); set { SdkMemory.Write(new IntPtr(0xB9B7ED),value); } }
    [NativeMember("frenchGame")]
    public static bool @FrenchGameValue { get => SdkMemory.Read<bool >(new IntPtr(0xB9B7EE)); set { SdkMemory.Write(new IntPtr(0xB9B7EE),value); } }
    public static void @Initialise() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3050 >(3050)(); }
    public static void @SetNormalGame() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3051 >(3051)(); }
    public static void @SetFrenchGame() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3052 >(3052)(); }
    public static void @SetGermanGame() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3053 >(3053)(); }
    public static bool @GermanGame() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3054 >(3054)(); return __sdkResult != 0; }
    public static bool @FrenchGame() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3055 >(3055)(); return __sdkResult != 0; }
    public static bool @Metric() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3056 >(3056)(); return __sdkResult != 0; }
    public static bool @Blood() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3057 >(3057)(); return __sdkResult != 0; }
    public static bool @Porn() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3058 >(3058)(); return __sdkResult != 0; }
    public static bool @ScreamsFromKills() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3059 >(3059)(); return __sdkResult != 0; }
    public static bool @Prostitutes() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3060 >(3060)(); return __sdkResult != 0; }
    public static bool @KickingWhenDown() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3061 >(3061)(); return __sdkResult != 0; }
    public static bool @ShootLimbs() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3062 >(3062)(); return __sdkResult != 0; }
    public static bool @KnockDownPeds() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3063 >(3063)(); return __sdkResult != 0; }
    public static bool @KillFrenzy() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3064 >(3064)(); return __sdkResult != 0; }
    public static bool @StealFromDeadPed() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3065 >(3065)(); return __sdkResult != 0; }
    public static bool @KillPeds() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3066 >(3066)(); return __sdkResult != 0; }
    public static bool @PedsOnFire() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3067 >(3067)(); return __sdkResult != 0; }
}
