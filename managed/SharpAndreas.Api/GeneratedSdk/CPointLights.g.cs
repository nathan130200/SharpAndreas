// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CPointLights : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=1;
    public CPointLights(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("NumLights")]
    public static uint @CountLights { get => SdkMemory.Read<uint >(new IntPtr(0xC3F0D0)); set { SdkMemory.Write(new IntPtr(0xC3F0D0),value); } }
    [NativeMember("aLights")]
    public static CPointLight? @Lights { get => new IntPtr(0xC3F0E0) == IntPtr.Zero ? null : new CPointLight(new IntPtr(0xC3F0E0)); }
    [NativeMember("aCachedMapReadResults")]
    public static NativePointer<float> @CachedMapReadResults { get => new NativePointer<float>(new IntPtr(0xC3F050)); }
    [NativeMember("NextCachedValue")]
    public static uint @NextCachedValue { get => SdkMemory.Read<uint >(new IntPtr(0xC3F0D4)); set { SdkMemory.Write(new IntPtr(0xC3F0D4),value); } }
    [NativeMember("aCachedMapReads")]
    public static CVector? @CachedMapReads { get => new IntPtr(0xC3F6E0) == IntPtr.Zero ? null : new CVector(new IntPtr(0xC3F6E0)); }
    public static void @Init() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3393 >(3393)(); }
    public static float @GenerateLightsAffectingObject(CVector? @point,NativePointer<float> @totalLighting,CEntity? @entity) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3394 >(3394)(@point?.Pointer ?? IntPtr.Zero,@totalLighting.Pointer,@entity?.Pointer ?? IntPtr.Zero); return __sdkResult; }
    public static float @GetLightMultiplier(CVector? @point) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3395 >(3395)(@point?.Pointer ?? IntPtr.Zero); return __sdkResult; }
    public static void @RemoveLightsAffectingObject() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3396 >(3396)(); }
    public static bool @ProcessVerticalLineUsingCache(CVector @point,NativePointer<float> @outZ) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3397 >(3397)(@point.Pointer,@outZ.Pointer); return __sdkResult != 0; }
    public static void @AddLight(byte @lightType,CVector @point,CVector @direction,float @radius,float @red,float @green,float @blue,byte @fogType,bool @generateExtraShadows,CEntity? @entityAffected) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3398 >(3398)(@lightType,@point.Pointer,@direction.Pointer,@radius,@red,@green,@blue,@fogType,(@generateExtraShadows ? 1 : 0),@entityAffected?.Pointer ?? IntPtr.Zero); }
    public static void @RenderFogEffect() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3399 >(3399)(); }
}
