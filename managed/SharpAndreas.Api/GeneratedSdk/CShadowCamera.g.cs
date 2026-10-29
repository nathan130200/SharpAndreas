// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CShadowCamera : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=8;
    public CShadowCamera(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_pRwCamera")]
    public RwCamera? @RenderWareCamera { get => SdkMemory.Read<IntPtr>(Pointer+0) == IntPtr.Zero ? null : new RwCamera(SdkMemory.Read<IntPtr>(Pointer+0)); set { SdkMemory.Write(Pointer+0,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_pRwRenderTexture")]
    public RwTexture? @RenderWareRenderTexture { get => SdkMemory.Read<IntPtr>(Pointer+4) == IntPtr.Zero ? null : new RwTexture(SdkMemory.Read<IntPtr>(Pointer+4)); set { SdkMemory.Write(Pointer+4,value?.Pointer ?? IntPtr.Zero); } }
    public void @InitializeAt() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D854 >(854)(Pointer); }
    public void @DestroyNative() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D855 >(855)(Pointer); }
    public void @CreateTexture() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D856 >(856)(Pointer); }
    public RwCamera? @SetFrustum(float @viewWindow) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D857 >(857)(Pointer,@viewWindow); return __sdkResult == IntPtr.Zero ? null : new RwCamera(__sdkResult); }
    public RwCamera? @SetLight(RpLight? @light) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D858 >(858)(Pointer,@light?.Pointer ?? IntPtr.Zero); return __sdkResult == IntPtr.Zero ? null : new RwCamera(__sdkResult); }
    public RwCamera? @SetCenter(RwV3d? @center) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D859 >(859)(Pointer,@center?.Pointer ?? IntPtr.Zero); return __sdkResult == IntPtr.Zero ? null : new RwCamera(__sdkResult); }
    public void @InvertRaster() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D860 >(860)(Pointer); }
    public RwRaster? @GetRwRenderRaster() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D861 >(861)(Pointer); return __sdkResult == IntPtr.Zero ? null : new RwRaster(__sdkResult); }
    public RwTexture? @GetRwRenderTexture() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D862 >(862)(Pointer); return __sdkResult == IntPtr.Zero ? null : new RwTexture(__sdkResult); }
    public RwRaster? @DrawOutlineBorder(RwRGBA @color) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D863 >(863)(Pointer,@color.Pointer); return __sdkResult == IntPtr.Zero ? null : new RwRaster(__sdkResult); }
    public RwCamera? @Create(int @rasterSize) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D864 >(864)(Pointer,@rasterSize); return __sdkResult == IntPtr.Zero ? null : new RwCamera(__sdkResult); }
    public RwCamera? @Update(RpClump? @object) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D865 >(865)(Pointer,@object?.Pointer ?? IntPtr.Zero); return __sdkResult == IntPtr.Zero ? null : new RwCamera(__sdkResult); }
    public RwCamera? @Update(RpAtomic? @object) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D866 >(866)(Pointer,@object?.Pointer ?? IntPtr.Zero); return __sdkResult == IntPtr.Zero ? null : new RwCamera(__sdkResult); }
    public void @MakeGradientRaster() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D867 >(867)(Pointer); }
    public RwImage? @CreateRwImage() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D868 >(868)(Pointer); return __sdkResult == IntPtr.Zero ? null : new RwImage(__sdkResult); }
    public RwRaster? @DrawBlurInRect(RwRect? @rect) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D869 >(869)(Pointer,@rect?.Pointer ?? IntPtr.Zero); return __sdkResult == IntPtr.Zero ? null : new RwRaster(__sdkResult); }
    public void @RasterResample(RwRaster? @raster) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D870 >(870)(Pointer,@raster?.Pointer ?? IntPtr.Zero); }
    public void @RasterBlur(RwRaster? @raster,int @numPasses) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D871 >(871)(Pointer,@raster?.Pointer ?? IntPtr.Zero,@numPasses); }
}
