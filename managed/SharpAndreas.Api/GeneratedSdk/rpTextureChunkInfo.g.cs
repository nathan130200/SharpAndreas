// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class rpTextureChunkInfo : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=12;
    public rpTextureChunkInfo(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("filtering")]
    public RwTextureFilterMode @Filtering { get => SdkMemory.Read<RwTextureFilterMode >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("addressingU")]
    public RwTextureAddressMode @AddressingU { get => SdkMemory.Read<RwTextureAddressMode >(Pointer+4); set { SdkMemory.Write(Pointer+4,value); } }
    [NativeMember("addressingV")]
    public RwTextureAddressMode @AddressingV { get => SdkMemory.Read<RwTextureAddressMode >(Pointer+8); set { SdkMemory.Write(Pointer+8,value); } }
}
