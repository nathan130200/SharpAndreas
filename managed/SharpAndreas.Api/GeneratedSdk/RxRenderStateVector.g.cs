// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class RxRenderStateVector : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=44;
    public RxRenderStateVector(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("Flags")]
    public uint @Flags { get => SdkMemory.Read<uint >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("ShadeMode")]
    public RwShadeMode @ShadeMode { get => SdkMemory.Read<RwShadeMode >(Pointer+4); set { SdkMemory.Write(Pointer+4,value); } }
    [NativeMember("SrcBlend")]
    public RwBlendFunction @SrcBlend { get => SdkMemory.Read<RwBlendFunction >(Pointer+8); set { SdkMemory.Write(Pointer+8,value); } }
    [NativeMember("DestBlend")]
    public RwBlendFunction @DestBlend { get => SdkMemory.Read<RwBlendFunction >(Pointer+12); set { SdkMemory.Write(Pointer+12,value); } }
    [NativeMember("TextureRaster")]
    public RwRaster? @TextureRaster { get => SdkMemory.Read<IntPtr>(Pointer+16) == IntPtr.Zero ? null : new RwRaster(SdkMemory.Read<IntPtr>(Pointer+16)); set { SdkMemory.Write(Pointer+16,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("AddressModeU")]
    public RwTextureAddressMode @AddressModeU { get => SdkMemory.Read<RwTextureAddressMode >(Pointer+20); set { SdkMemory.Write(Pointer+20,value); } }
    [NativeMember("AddressModeV")]
    public RwTextureAddressMode @AddressModeV { get => SdkMemory.Read<RwTextureAddressMode >(Pointer+24); set { SdkMemory.Write(Pointer+24,value); } }
    [NativeMember("FilterMode")]
    public RwTextureFilterMode @FilterMode { get => SdkMemory.Read<RwTextureFilterMode >(Pointer+28); set { SdkMemory.Write(Pointer+28,value); } }
    [NativeMember("BorderColor")]
    public RwRGBA @BorderColor { get => new RwRGBA(Pointer+32); set { SdkMemory.Copy(value.Pointer,Pointer+32,4); } }
    [NativeMember("FogType")]
    public RwFogType @FogType { get => SdkMemory.Read<RwFogType >(Pointer+36); set { SdkMemory.Write(Pointer+36,value); } }
    [NativeMember("FogColor")]
    public RwRGBA @FogColor { get => new RwRGBA(Pointer+40); set { SdkMemory.Copy(value.Pointer,Pointer+40,4); } }
}
