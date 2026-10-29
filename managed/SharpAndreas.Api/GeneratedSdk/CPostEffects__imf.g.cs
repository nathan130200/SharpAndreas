// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CPostEffects__imf : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=344;
    public CPostEffects__imf(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("screenZ")]
    public float @ScreenZ { get => SdkMemory.Read<float >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("recipCameraZ")]
    public float @RecipCameraZ { get => SdkMemory.Read<float >(Pointer+4); set { SdkMemory.Write(Pointer+4,value); } }
    [NativeMember("RasterDrawBuffer")]
    public RwRaster? @RasterDrawBuffer { get => SdkMemory.Read<IntPtr>(Pointer+8) == IntPtr.Zero ? null : new RwRaster(SdkMemory.Read<IntPtr>(Pointer+8)); set { SdkMemory.Write(Pointer+8,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("sizeDrawBufferX")]
    public int @SizeDrawBufferX { get => SdkMemory.Read<int >(Pointer+12); set { SdkMemory.Write(Pointer+12,value); } }
    [NativeMember("sizeDrawBufferY")]
    public int @SizeDrawBufferY { get => SdkMemory.Read<int >(Pointer+16); set { SdkMemory.Write(Pointer+16,value); } }
    [NativeMember("fFrontBufferU1")]
    public float @FrontBufferU1 { get => SdkMemory.Read<float >(Pointer+20); set { SdkMemory.Write(Pointer+20,value); } }
    [NativeMember("fFrontBufferV1")]
    public float @FrontBufferV1 { get => SdkMemory.Read<float >(Pointer+24); set { SdkMemory.Write(Pointer+24,value); } }
    [NativeMember("fFrontBufferU2")]
    public float @FrontBufferU2 { get => SdkMemory.Read<float >(Pointer+28); set { SdkMemory.Write(Pointer+28,value); } }
    [NativeMember("fFrontBufferV2")]
    public float @FrontBufferV2 { get => SdkMemory.Read<float >(Pointer+32); set { SdkMemory.Write(Pointer+32,value); } }
    [NativeMember("triangle")]
    public NativeObjectArray<RwD3D9Vertex> @Triangle { get => new NativeObjectArray<RwD3D9Vertex>(Pointer+36,3,28); }
    [NativeMember("uMinTri")]
    public float @MinTri { get => SdkMemory.Read<float >(Pointer+120); set { SdkMemory.Write(Pointer+120,value); } }
    [NativeMember("uMaxTri")]
    public float @MaxTri { get => SdkMemory.Read<float >(Pointer+124); set { SdkMemory.Write(Pointer+124,value); } }
    [NativeMember("vMinTri")]
    public float @MinTriValue { get => SdkMemory.Read<float >(Pointer+128); set { SdkMemory.Write(Pointer+128,value); } }
    [NativeMember("vMaxTri")]
    public float @MaxTriValue { get => SdkMemory.Read<float >(Pointer+132); set { SdkMemory.Write(Pointer+132,value); } }
    [NativeMember("quad")]
    public NativeObjectArray<RwD3D9Vertex> @Quad { get => new NativeObjectArray<RwD3D9Vertex>(Pointer+136,6,28); }
    [NativeMember("blendSrc")]
    public RwBlendFunction @BlendSrc { get => SdkMemory.Read<RwBlendFunction >(Pointer+304); set { SdkMemory.Write(Pointer+304,value); } }
    [NativeMember("blendDst")]
    public RwBlendFunction @BlendDst { get => SdkMemory.Read<RwBlendFunction >(Pointer+308); set { SdkMemory.Write(Pointer+308,value); } }
    [NativeMember("bFog")]
    public int @Fog { get => SdkMemory.Read<int >(Pointer+312); set { SdkMemory.Write(Pointer+312,value); } }
    [NativeMember("cullMode")]
    public RwCullMode @CullMode { get => SdkMemory.Read<RwCullMode >(Pointer+316); set { SdkMemory.Write(Pointer+316,value); } }
    [NativeMember("bZTest")]
    public int @ZTest { get => SdkMemory.Read<int >(Pointer+320); set { SdkMemory.Write(Pointer+320,value); } }
    [NativeMember("bZWrite")]
    public int @ZWrite { get => SdkMemory.Read<int >(Pointer+324); set { SdkMemory.Write(Pointer+324,value); } }
    [NativeMember("shadeMode")]
    public RwShadeMode @ShadeMode { get => SdkMemory.Read<RwShadeMode >(Pointer+328); set { SdkMemory.Write(Pointer+328,value); } }
    [NativeMember("bVertexAlpha")]
    public int @VertexAlpha { get => SdkMemory.Read<int >(Pointer+332); set { SdkMemory.Write(Pointer+332,value); } }
    [NativeMember("textureAddress")]
    public RwTextureAddressMode @TextureAddress { get => SdkMemory.Read<RwTextureAddressMode >(Pointer+336); set { SdkMemory.Write(Pointer+336,value); } }
    [NativeMember("textureFilter")]
    public RwTextureFilterMode @TextureFilter { get => SdkMemory.Read<RwTextureFilterMode >(Pointer+340); set { SdkMemory.Write(Pointer+340,value); } }
}
