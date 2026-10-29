// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CWaterLevel : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=1;
    public CWaterLevel(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_nNumOfWaterTriangles")]
    public static int @CountOfWaterTriangles { get => SdkMemory.Read<int >(new IntPtr(0xC22884)); set { SdkMemory.Write(new IntPtr(0xC22884),value); } }
    [NativeMember("m_nNumOfWaterQuads")]
    public static int @CountOfWaterQuads { get => SdkMemory.Read<int >(new IntPtr(0xC22888)); set { SdkMemory.Write(new IntPtr(0xC22888),value); } }
    [NativeMember("m_nNumOfWaterVertices")]
    public static int @CountOfWaterVertices { get => SdkMemory.Read<int >(new IntPtr(0xC2288C)); set { SdkMemory.Write(new IntPtr(0xC2288C),value); } }
    [NativeMember("m_nWaterConfiguration")]
    public static int @WaterConfiguration { get => SdkMemory.Read<int >(new IntPtr(0xC228A0)); set { SdkMemory.Write(new IntPtr(0xC228A0),value); } }
    [NativeMember("m_nNumWaterZonePolys")]
    public static int @CountWaterZonePolys { get => SdkMemory.Read<int >(new IntPtr(0xC215F0)); set { SdkMemory.Write(new IntPtr(0xC215F0),value); } }
    [NativeMember("m_aVertices")]
    public static NativeObjectArray<CWaterVertex> @Vertices { get => new NativeObjectArray<CWaterVertex>(new IntPtr(0xC22910),1021,20); }
    public static void @AddWaveToResult(float @x,float @y,NativePointer<float> @pWaterZ,float @BigWavesAmpl,float @SmallWavesAmpl,CVector? @pNormal) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4361 >(4361)(@x,@y,@pWaterZ.Pointer,@BigWavesAmpl,@SmallWavesAmpl,@pNormal?.Pointer ?? IntPtr.Zero); }
    public static void @AddWaveToResult(int @x,int @y,NativePointer<float> @pWaterZ,float @BigWavesAmpl,float @SmallWavesAmpl) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4362 >(4362)(@x,@y,@pWaterZ.Pointer,@BigWavesAmpl,@SmallWavesAmpl); }
    public static void @BlockHit(int @BlockX,int @BlockY) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4363 >(4363)(@BlockX,@BlockY); }
    public static void @CalculateWavesOnlyForCoordinate(int @X,int @Y,float @BigWavesAmpl,float @SmallWavesAmpl,NativePointer<float> @pResultHeight) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4364 >(4364)(@X,@Y,@BigWavesAmpl,@SmallWavesAmpl,@pResultHeight.Pointer); }
    public static void @ChangeWaterConfiguration(int @NewWaterConfig) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4365 >(4365)(@NewWaterConfig); }
    public static CObject? @CreateBeachToy(CVector? @pos,eBeachToy @beachToy) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4366 >(4366)(@pos?.Pointer ?? IntPtr.Zero,(int)@beachToy); return __sdkResult == IntPtr.Zero ? null : new CObject(__sdkResult); }
    public static void @FindNearestWaterAndItsFlow() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4367 >(4367)(); }
    public static bool @GetWaterLevel(float @x,float @y,float @z,NativePointer<float> @pWaterZ,bool @bForceResult,CVector? @pNormal) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4368 >(4368)(@x,@y,@z,@pWaterZ.Pointer,(@bForceResult ? 1 : 0),@pNormal?.Pointer ?? IntPtr.Zero); return __sdkResult != 0; }
    public static bool @GetWaterLevelNoWaves(float @x,float @y,float @z,NativePointer<float> @pWaterZ) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4369 >(4369)(@x,@y,@z,@pWaterZ.Pointer); return __sdkResult != 0; }
    public static void @PreRenderWater() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4370 >(4370)(); }
    public static void @RenderAndEmptyRenderBuffer() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4371 >(4371)(); }
    public static void @RenderTransparentWater() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4372 >(4372)(); }
    public static void @RenderWater() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4373 >(4373)(); }
    public static void @RenderWaterFog() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4374 >(4374)(); }
    public static void @ScanThroughBlocks() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4375 >(4375)(); }
    public static void @SetCameraRange() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4376 >(4376)(); }
    public static void @WaterLevelInitialise() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4377 >(4377)(); }
    public static void @Shutdown() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4378 >(4378)(); }
}
