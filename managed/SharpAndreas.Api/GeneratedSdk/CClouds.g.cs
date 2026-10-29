// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CClouds : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=1;
    public CClouds(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_fVolumetricCloudDensity")]
    public static float @VolumetricCloudDensity { get => SdkMemory.Read<float >(new IntPtr(0x8D5388)); set { SdkMemory.Write(new IntPtr(0x8D5388),value); } }
    [NativeMember("m_bVolumetricCloudHeightSwitch")]
    public static bool @VolumetricCloudHeightSwitch { get => SdkMemory.Read<bool >(new IntPtr(0x8D538C)); set { SdkMemory.Write(new IntPtr(0x8D538C),value); } }
    [NativeMember("m_fVolumetricCloudWindMoveFactor")]
    public static float @VolumetricCloudWindMoveFactor { get => SdkMemory.Read<float >(new IntPtr(0x8D5390)); set { SdkMemory.Write(new IntPtr(0x8D5390),value); } }
    [NativeMember("m_fVolumetricCloudMaxDistance")]
    public static float @VolumetricCloudMaxDistance { get => SdkMemory.Read<float >(new IntPtr(0xC6AA58)); set { SdkMemory.Write(new IntPtr(0xC6AA58),value); } }
    [NativeMember("m_VolumetricCloudsUsedNum")]
    public static uint @VolumetricCloudsUsedCount { get => SdkMemory.Read<uint >(new IntPtr(0xC6AA5C)); set { SdkMemory.Write(new IntPtr(0xC6AA5C),value); } }
    [NativeMember("ms_cameraRoll")]
    public static float @CameraRoll { get => SdkMemory.Read<float >(new IntPtr(0xC6AA64)); set { SdkMemory.Write(new IntPtr(0xC6AA64),value); } }
    [NativeMember("IndividualRotation")]
    public static int @IndividualRotation { get => SdkMemory.Read<int >(new IntPtr(0xC6AA6C)); set { SdkMemory.Write(new IntPtr(0xC6AA6C),value); } }
    [NativeMember("CloudRotation")]
    public static float @CloudRotation { get => SdkMemory.Read<float >(new IntPtr(0xC6AA70)); set { SdkMemory.Write(new IntPtr(0xC6AA70),value); } }
    [NativeMember("ms_vc")]
    public static tVolumetricClouds @Vc { get => new tVolumetricClouds(new IntPtr(0xC6AAB0)); set { SdkMemory.Copy(value.Pointer,new IntPtr(0xC6AAB0),5800); } }
    [NativeMember("ms_mf")]
    public static tMovingFog @Mf { get => new tMovingFog(new IntPtr(0xC6C158)); set { SdkMemory.Copy(value.Pointer,new IntPtr(0xC6C158),10236); } }
    [NativeMember("PlayerCoords")]
    public static CVector @PlayerCoordinates { get => new CVector(new IntPtr(0xC6E958)); set { SdkMemory.Copy(value.Pointer,new IntPtr(0xC6E958),12); } }
    [NativeMember("CameraCoors")]
    public static CVector @CameraCoors { get => new CVector(new IntPtr(0xC6E964)); set { SdkMemory.Copy(value.Pointer,new IntPtr(0xC6E964),12); } }
    public static void @Shutdown() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2148 >(2148)(); }
    public static void @Update() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2149 >(2149)(); }
    public static void @SetUpOneSkyPoly(CVector @vert1pos,CVector @vert2pos,CVector @vert3pos,CVector @vert4pos,byte @topRed,byte @topGreen,byte @topBlue,byte @bottomRed,byte @bottomGreen,byte @bottomBlue) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2150 >(2150)(@vert1pos.Pointer,@vert2pos.Pointer,@vert3pos.Pointer,@vert4pos.Pointer,@topRed,@topGreen,@topBlue,@bottomRed,@bottomGreen,@bottomBlue); }
    public static void @VolumetricCloudsInit() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2151 >(2151)(); }
    public static int @VolumetricClouds_GetFirstFreeSlot() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2152 >(2152)(); return __sdkResult; }
    public static void @VolumetricClouds_Delete(int @vcSlotIndex) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2153 >(2153)(@vcSlotIndex); }
    public static float @VolumetricCloudsGetMaxDistance() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2154 >(2154)(); return __sdkResult; }
    public static void @MovingFogInit() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2155 >(2155)(); }
    public static float @MovingFog_GetFXIntensity() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2156 >(2156)(); return __sdkResult; }
    public static CVector @MovingFog_GetWind() { Game.CheckThread(); var result=NativeObject.AllocateStorage<CVector >(12); try { SdkBindings.Get<GeneratedDelegates.D2157 >(2157)(result.Pointer); return result; } catch { result.Dispose(); throw; } }
    public static int @MovingFog_GetFirstFreeSlot() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2158 >(2158)(); return __sdkResult; }
    public static void @MovingFog_Delete(int @fogSlotIndex) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2159 >(2159)(@fogSlotIndex); }
    public static void @MovingFog_Create(CVector? @posn) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2160 >(2160)(@posn?.Pointer ?? IntPtr.Zero); }
    public static void @Init() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2161 >(2161)(); }
    public static void @Render() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2162 >(2162)(); }
    public static void @RenderSkyPolys() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2163 >(2163)(); }
    public static void @RenderBottomFromHeight() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2164 >(2164)(); }
    public static void @VolumetricClouds_Create(CVector? @posn) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2165 >(2165)(@posn?.Pointer ?? IntPtr.Zero); }
    public static void @VolumetricCloudsRender() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2166 >(2166)(); }
    public static void @MovingFog_Update() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2167 >(2167)(); }
    public static void @MovingFogRender() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2168 >(2168)(); }
}
