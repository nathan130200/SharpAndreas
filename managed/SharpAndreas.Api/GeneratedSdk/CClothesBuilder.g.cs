// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CClothesBuilder : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=1;
    public CClothesBuilder(System.IntPtr pointer) : base(pointer) {}
    public static void @BlendTextures(RwTexture? @texture1,RwTexture? @texture2,RwTexture? @texture3,float @factorA,float @factorB,float @factorC,int @arg7,RwTexture? @texture4) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2122 >(2122)(@texture1?.Pointer ?? IntPtr.Zero,@texture2?.Pointer ?? IntPtr.Zero,@texture3?.Pointer ?? IntPtr.Zero,@factorA,@factorB,@factorC,@arg7,@texture4?.Pointer ?? IntPtr.Zero); }
    public static void @BlendTextures(RwTexture? @texture1,RwTexture? @texture2,RwTexture? @texture3,float @factorA,float @factorB,float @factorC) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2123 >(2123)(@texture1?.Pointer ?? IntPtr.Zero,@texture2?.Pointer ?? IntPtr.Zero,@texture3?.Pointer ?? IntPtr.Zero,@factorA,@factorB,@factorC); }
    public static void @BlendTextures(RwTexture? @texture1,RwTexture? @texture2,float @arg3,float @arg4) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2124 >(2124)(@texture1?.Pointer ?? IntPtr.Zero,@texture2?.Pointer ?? IntPtr.Zero,@arg3,@arg4); }
    public static void @BuildBoneIndexConversionTable(NativePointer<byte> @arg1,RpHAnimHierarchy? @arg2,int @arg3) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2125 >(2125)(@arg1.Pointer,@arg2?.Pointer ?? IntPtr.Zero,@arg3); }
    public static void @ConstructGeometryAndSkinArrays(RpHAnimHierarchy? @arg1,NativePointer<IntPtr> @arg2,NativePointer<IntPtr> @arg3,NativePointer<IntPtr> @arg4,uint @arg5,NativePointer<IntPtr> @arg6,NativePointer<IntPtr> @arg7) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2126 >(2126)(@arg1?.Pointer ?? IntPtr.Zero,@arg2.Pointer,@arg3.Pointer,@arg4.Pointer,@arg5,@arg6.Pointer,@arg7.Pointer); }
    public static void @ConstructGeometryArray(NativePointer<IntPtr> @arg1,NativePointer<uint> @arg2,float @arg3,float @arg4,float @arg5) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2127 >(2127)(@arg1.Pointer,@arg2.Pointer,@arg3,@arg4,@arg5); }
    public static void @ConstructTextures(RwTexDictionary? @dict,NativePointer<uint> @hashes,float @factorA,float @factorB,float @factorC) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2128 >(2128)(@dict?.Pointer ?? IntPtr.Zero,@hashes.Pointer,@factorA,@factorB,@factorC); }
    public static RwTexture? @CopyTexture(RwTexture? @texture) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2129 >(2129)(@texture?.Pointer ?? IntPtr.Zero); return __sdkResult == IntPtr.Zero ? null : new RwTexture(__sdkResult); }
    public static RpClump? @CreateSkinnedClump(RpClump? @clump,RwTexDictionary? @dict,CPedClothesDesc @newclothes,CPedClothesDesc? @oldclothes,bool @bCutscenePlayer) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2130 >(2130)(@clump?.Pointer ?? IntPtr.Zero,@dict?.Pointer ?? IntPtr.Zero,@newclothes.Pointer,@oldclothes?.Pointer ?? IntPtr.Zero,(@bCutscenePlayer ? 1 : 0)); return __sdkResult == IntPtr.Zero ? null : new RpClump(__sdkResult); }
    public static void @DestroySkinArrays(RwMatrixWeights? @arg1,NativePointer<uint> @arg2) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2131 >(2131)(@arg1?.Pointer ?? IntPtr.Zero,@arg2.Pointer); }
    public static int @FindNearestColour(RwRGBA? @color) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2132 >(2132)(@color?.Pointer ?? IntPtr.Zero); return __sdkResult; }
    public static void @InitPaletteOctTree(int @numColors) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2133 >(2133)(@numColors); }
    public static void @LoadCdDirectory() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2134 >(2134)(); }
    public static void @PlaceTextureOnTopOfTexture(RwTexture? @texture1,RwTexture? @texture2) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2135 >(2135)(@texture1?.Pointer ?? IntPtr.Zero,@texture2?.Pointer ?? IntPtr.Zero); }
    public static void @PreprocessClothesDesc(CPedClothesDesc @arg1,bool @arg2) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2136 >(2136)(@arg1.Pointer,(@arg2 ? 1 : 0)); }
    public static void @ReducePaletteSize(RwTexture? @texture,int @numColorsToReduce) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2137 >(2137)(@texture?.Pointer ?? IntPtr.Zero,@numColorsToReduce); }
    public static void @ReleaseGeometry(int @numToRelease) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2138 >(2138)(@numToRelease); }
    public void @RequestGeometry(int @modelid,uint @crc) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2139 >(2139)(Pointer,@modelid,@crc); }
    public static void @StoreBoneArray(RpClump? @clump,int @arg2) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2140 >(2140)(@clump?.Pointer ?? IntPtr.Zero,@arg2); }
    public static RpGeometry? @BlendGeometry(RpClump? @clump,NativePointer<sbyte> @arg2,NativePointer<sbyte> @arg3,NativePointer<sbyte> @arg4,float @arg5,float @arg6,float @arg7) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2141 >(2141)(@clump?.Pointer ?? IntPtr.Zero,@arg2.Pointer,@arg3.Pointer,@arg4.Pointer,@arg5,@arg6,@arg7); return __sdkResult == IntPtr.Zero ? null : new RpGeometry(__sdkResult); }
    public static RpGeometry? @BlendGeometry(RpClump? @clump,NativePointer<sbyte> @arg2,NativePointer<sbyte> @arg3,float @arg4,float @arg5) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2142 >(2142)(@clump?.Pointer ?? IntPtr.Zero,@arg2.Pointer,@arg3.Pointer,@arg4,@arg5); return __sdkResult == IntPtr.Zero ? null : new RpGeometry(__sdkResult); }
    public static RpGeometry? @CopyGeometry(RpClump? @clump,NativePointer<sbyte> @arg2,NativePointer<sbyte> @arg3) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2143 >(2143)(@clump?.Pointer ?? IntPtr.Zero,@arg2.Pointer,@arg3.Pointer); return __sdkResult == IntPtr.Zero ? null : new RpGeometry(__sdkResult); }
    public static void @ShutdownPaletteOctTree() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2144 >(2144)(); }
    public static void @ReducePaletteOctTree(int @numColorsToReduce) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2145 >(2145)(@numColorsToReduce); }
    public static bool @AddColour(RwRGBA? @color) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2146 >(2146)(@color?.Pointer ?? IntPtr.Zero); return __sdkResult != 0; }
    public static void @FillPalette(RwRGBA? @color) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2147 >(2147)(@color?.Pointer ?? IntPtr.Zero); }
}
