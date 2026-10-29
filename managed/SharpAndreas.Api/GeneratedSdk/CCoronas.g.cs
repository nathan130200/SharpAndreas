// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CCoronas : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=1;
    public CCoronas(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("SunScreenX")]
    public static float @SunScreenX { get => SdkMemory.Read<float >(new IntPtr(0xC3E028)); set { SdkMemory.Write(new IntPtr(0xC3E028),value); } }
    [NativeMember("SunScreenY")]
    public static float @SunScreenY { get => SdkMemory.Read<float >(new IntPtr(0xC3E02C)); set { SdkMemory.Write(new IntPtr(0xC3E02C),value); } }
    [NativeMember("SunBlockedByClouds")]
    public static bool @SunBlockedByClouds { get => SdkMemory.Read<bool >(new IntPtr(0xC3E030)); set { SdkMemory.Write(new IntPtr(0xC3E030),value); } }
    [NativeMember("bChangeBrightnessImmediately")]
    public static int @ChangeBrightnessImmediately { get => SdkMemory.Read<int >(new IntPtr(0xC3E034)); set { SdkMemory.Write(new IntPtr(0xC3E034),value); } }
    [NativeMember("NumCoronas")]
    public static uint @CountCoronas { get => SdkMemory.Read<uint >(new IntPtr(0xC3E038)); set { SdkMemory.Write(new IntPtr(0xC3E038),value); } }
    [NativeMember("LightsMult")]
    public static float @LightsMult { get => SdkMemory.Read<float >(new IntPtr(0x8D4B5C)); set { SdkMemory.Write(new IntPtr(0x8D4B5C),value); } }
    [NativeMember("MoonSize")]
    public static uint @MoonSize { get => SdkMemory.Read<uint >(new IntPtr(0x8D4B60)); set { SdkMemory.Write(new IntPtr(0x8D4B60),value); } }
    [NativeMember("aCoronas")]
    public static CRegisteredCorona? @Coronas { get => new IntPtr(0xC3E058) == IntPtr.Zero ? null : new CRegisteredCorona(new IntPtr(0xC3E058)); }
    public static void @Init() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2285 >(2285)(); }
    public static void @Shutdown() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2286 >(2286)(); }
    public static void @Update() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2287 >(2287)(); }
    public static void @Render() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2288 >(2288)(); }
    public static void @RenderReflections() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2289 >(2289)(); }
    public static void @RenderSunReflection() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2290 >(2290)(); }
    public static void @RegisterCorona(uint @id,CEntity? @attachTo,byte @red,byte @green,byte @blue,byte @alpha,CVector @posn,float @radius,float @farClip,RwTexture? @texture,eCoronaFlareType @flaretype,bool @enableReflection,bool @checkObstacles,int @_param_not_used,float @angle,bool @longDistance,float @nearClip,byte @fadeState,float @fadeSpeed,bool @onlyFromBelow,bool @reflectionDelay) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2291 >(2291)(@id,@attachTo?.Pointer ?? IntPtr.Zero,@red,@green,@blue,@alpha,@posn.Pointer,@radius,@farClip,@texture?.Pointer ?? IntPtr.Zero,(int)@flaretype,(@enableReflection ? 1 : 0),(@checkObstacles ? 1 : 0),@_param_not_used,@angle,(@longDistance ? 1 : 0),@nearClip,@fadeState,@fadeSpeed,(@onlyFromBelow ? 1 : 0),(@reflectionDelay ? 1 : 0)); }
    public static void @RegisterCorona(uint @id,CEntity? @attachTo,byte @red,byte @green,byte @blue,byte @alpha,CVector @posn,float @radius,float @farClip,eCoronaType @coronaType,eCoronaFlareType @flaretype,bool @enableReflection,bool @checkObstacles,int @_param_not_used,float @angle,bool @longDistance,float @nearClip,byte @fadeState,float @fadeSpeed,bool @onlyFromBelow,bool @reflectionDelay) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2292 >(2292)(@id,@attachTo?.Pointer ?? IntPtr.Zero,@red,@green,@blue,@alpha,@posn.Pointer,@radius,@farClip,(int)@coronaType,(int)@flaretype,(@enableReflection ? 1 : 0),(@checkObstacles ? 1 : 0),@_param_not_used,@angle,(@longDistance ? 1 : 0),@nearClip,@fadeState,@fadeSpeed,(@onlyFromBelow ? 1 : 0),(@reflectionDelay ? 1 : 0)); }
    public static void @UpdateCoronaCoors(uint @id,CVector @posn,float @farClip,float @angle) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2293 >(2293)(@id,@posn.Pointer,@farClip,@angle); }
    public static void @DoSunAndMoon() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2294 >(2294)(); }
}
