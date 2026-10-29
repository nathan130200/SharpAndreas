// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CRealTimeShadow : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=76;
    public CRealTimeShadow(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_pOwner")]
    public CPhysical? @Owner { get => SdkMemory.Read<IntPtr>(Pointer+0) == IntPtr.Zero ? null : new CPhysical(SdkMemory.Read<IntPtr>(Pointer+0)); set { SdkMemory.Write(Pointer+0,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_bCreated")]
    public bool @Created { get => SdkMemory.Read<bool >(Pointer+4); set { SdkMemory.Write(Pointer+4,value); } }
    [NativeMember("m_nIntensity")]
    public byte @Intensity { get => SdkMemory.Read<byte >(Pointer+5); set { SdkMemory.Write(Pointer+5,value); } }
    [NativeMember("m_camera")]
    public CShadowCamera @Camera { get => new CShadowCamera(Pointer+8); set { SdkMemory.Copy(value.Pointer,Pointer+8,8); } }
    [NativeMember("m_bBlurred")]
    public bool @Blurred { get => SdkMemory.Read<bool >(Pointer+16); set { SdkMemory.Write(Pointer+16,value); } }
    [NativeMember("m_blurCamera")]
    public CShadowCamera @BlurCamera { get => new CShadowCamera(Pointer+20); set { SdkMemory.Copy(value.Pointer,Pointer+20,8); } }
    [NativeMember("m_nBlurPasses")]
    public uint @BlurPasses { get => SdkMemory.Read<uint >(Pointer+28); set { SdkMemory.Write(Pointer+28,value); } }
    [NativeMember("m_bDrawMoreBlur")]
    public bool @DrawMoreBlur { get => SdkMemory.Read<bool >(Pointer+32); set { SdkMemory.Write(Pointer+32,value); } }
    [NativeMember("m_nRwObjectType")]
    public uint @RenderWareObjectType { get => SdkMemory.Read<uint >(Pointer+36); set { SdkMemory.Write(Pointer+36,value); } }
    [NativeMember("m_pLight")]
    public RpLight? @Light { get => SdkMemory.Read<IntPtr>(Pointer+40) == IntPtr.Zero ? null : new RpLight(SdkMemory.Read<IntPtr>(Pointer+40)); set { SdkMemory.Write(Pointer+40,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_boundingSphere")]
    public CSphere @BoundingSphere { get => new CSphere(Pointer+44); set { SdkMemory.Copy(value.Pointer,Pointer+44,16); } }
    [NativeMember("m_baseSphere")]
    public CSphere @BaseSphere { get => new CSphere(Pointer+60); set { SdkMemory.Copy(value.Pointer,Pointer+60,16); } }
    public void @InitializeAt() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D872 >(872)(Pointer); }
    public void @DestroyNative() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D873 >(873)(Pointer); }
    public RwFrame? @SetLightProperties(float @angle,float @_unused_param,bool @setLight) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D874 >(874)(Pointer,@angle,@_unused_param,(@setLight ? 1 : 0)); return __sdkResult == IntPtr.Zero ? null : new RwFrame(__sdkResult); }
    public void @Destroy() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D875 >(875)(Pointer); }
    public CShadowCamera? @GetShadowCamera() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D876 >(876)(Pointer); return __sdkResult == IntPtr.Zero ? null : new CShadowCamera(__sdkResult); }
    public RwTexture? @GetShadowRwTexture() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D877 >(877)(Pointer); return __sdkResult == IntPtr.Zero ? null : new RwTexture(__sdkResult); }
    public void @DrawBorderAroundTexture(RwRGBA @color) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D878 >(878)(Pointer,@color.Pointer); }
    public bool @Create(bool @isBlurred,int @blurPasses,bool @drawMoreBlur) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D879 >(879)(Pointer,(@isBlurred ? 1 : 0),@blurPasses,(@drawMoreBlur ? 1 : 0)); return __sdkResult != 0; }
    public bool @SetupForThisEntity(CPhysical? @owner) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D880 >(880)(Pointer,@owner?.Pointer ?? IntPtr.Zero); return __sdkResult != 0; }
    public RwTexture? @Update() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D881 >(881)(Pointer); return __sdkResult == IntPtr.Zero ? null : new RwTexture(__sdkResult); }
}
