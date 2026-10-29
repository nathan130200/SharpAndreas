// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CCustomCarPlateMgr : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=1;
    public CCustomCarPlateMgr(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("pCharsetTex")]
    public static RwTexture? @CharsetTex { get => SdkMemory.Read<IntPtr>(new IntPtr(0xC3EF5C)) == IntPtr.Zero ? null : new RwTexture(SdkMemory.Read<IntPtr>(new IntPtr(0xC3EF5C))); set { SdkMemory.Write(new IntPtr(0xC3EF5C),value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("pPlatebackTexTab")]
    public static NativePointer<IntPtr> @PlatebackTexTab { get => new NativePointer<IntPtr>(new IntPtr(0xC3EF60)); }
    [NativeMember("pPalette1555Tab")]
    public static NativePointer<IntPtr> @Palette1555Tab { get => new NativePointer<IntPtr>(new IntPtr(0xC3EF6C)); }
    public static bool @Initialise() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2409 >(2409)(); return __sdkResult != 0; }
    public static bool @GeneratePlateText(NativePointer<sbyte> @plateTextBuf,int @length) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2410 >(2410)(@plateTextBuf.Pointer,@length); return __sdkResult != 0; }
    public static bool @Shutdown() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2411 >(2411)(); return __sdkResult != 0; }
    public static byte @GetMapRegionPlateDesign() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2412 >(2412)(); return __sdkResult; }
    public static bool @LoadPlatecharsetDat(NativePointer<sbyte> @filename,NativePointer<byte> @data,int @arg2,int @arg3) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2413 >(2413)(@filename.Pointer,@data.Pointer,@arg2,@arg3); return __sdkResult != 0; }
    public static RpMaterial? @SetupMaterialPlatebackTexture(RpMaterial? @material,byte @plateType) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2414 >(2414)(@material?.Pointer ?? IntPtr.Zero,@plateType); return __sdkResult == IntPtr.Zero ? null : new RpMaterial(__sdkResult); }
    public static RwTexture? @CreatePlateTexture(NativePointer<sbyte> @text,byte @plateType) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2415 >(2415)(@text.Pointer,@plateType); return __sdkResult == IntPtr.Zero ? null : new RwTexture(__sdkResult); }
    public static bool @SetupClumpAfterVehicleUpgrade(RpClump? @clump,RpMaterial? @plateMaterial,byte @plateType) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2416 >(2416)(@clump?.Pointer ?? IntPtr.Zero,@plateMaterial?.Pointer ?? IntPtr.Zero,@plateType); return __sdkResult != 0; }
    public static RpMaterial? @SetupMaterialPlateTexture(RpMaterial? @material,NativePointer<sbyte> @plateText,byte @plateType) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2417 >(2417)(@material?.Pointer ?? IntPtr.Zero,@plateText.Pointer,@plateType); return __sdkResult == IntPtr.Zero ? null : new RpMaterial(__sdkResult); }
    public static RpMaterial? @SetupClump(RpClump? @clump,NativePointer<sbyte> @plateText,byte @plateType) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2418 >(2418)(@clump?.Pointer ?? IntPtr.Zero,@plateText.Pointer,@plateType); return __sdkResult == IntPtr.Zero ? null : new RpMaterial(__sdkResult); }
}
