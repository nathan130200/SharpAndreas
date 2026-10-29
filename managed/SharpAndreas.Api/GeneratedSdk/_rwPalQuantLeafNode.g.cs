// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class _rwPalQuantLeafNode : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=28;
    public _rwPalQuantLeafNode(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("weight")]
    public float @Weight { get => SdkMemory.Read<float >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("ac")]
    public RwRGBAReal @Ac { get => new RwRGBAReal(Pointer+4); set { SdkMemory.Copy(value.Pointer,Pointer+4,16); } }
    [NativeMember("var")]
    public float @Variable { get => SdkMemory.Read<float >(Pointer+20); set { SdkMemory.Write(Pointer+20,value); } }
    [NativeMember("palIndex")]
    public byte @PalIndex { get => SdkMemory.Read<byte >(Pointer+24); set { SdkMemory.Write(Pointer+24,value); } }
}
