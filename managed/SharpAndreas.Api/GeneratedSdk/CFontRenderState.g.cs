// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CFontRenderState : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=48;
    public CFontRenderState(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("id")]
    public int @Id { get => SdkMemory.Read<int >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("x")]
    public float @X { get => SdkMemory.Read<float >(Pointer+4); set { SdkMemory.Write(Pointer+4,value); } }
    [NativeMember("y")]
    public float @Y { get => SdkMemory.Read<float >(Pointer+8); set { SdkMemory.Write(Pointer+8,value); } }
    [NativeMember("ScaleX")]
    public float @ScaleX { get => SdkMemory.Read<float >(Pointer+12); set { SdkMemory.Write(Pointer+12,value); } }
    [NativeMember("ScaleY")]
    public float @ScaleY { get => SdkMemory.Read<float >(Pointer+16); set { SdkMemory.Write(Pointer+16,value); } }
    [NativeMember("Colour")]
    public CRGBA @Color { get => new CRGBA(Pointer+20); set { SdkMemory.Copy(value.Pointer,Pointer+20,4); } }
    [NativeMember("PixelsToAdd")]
    public float @PixelsToAdd { get => SdkMemory.Read<float >(Pointer+24); set { SdkMemory.Write(Pointer+24,value); } }
    [NativeMember("Slope")]
    public float @Slope { get => SdkMemory.Read<float >(Pointer+28); set { SdkMemory.Write(Pointer+28,value); } }
    [NativeMember("SlopeRefX")]
    public float @SlopeRefX { get => SdkMemory.Read<float >(Pointer+32); set { SdkMemory.Write(Pointer+32,value); } }
    [NativeMember("SlopeRefY")]
    public float @SlopeRefY { get => SdkMemory.Read<float >(Pointer+36); set { SdkMemory.Write(Pointer+36,value); } }
    [NativeMember("Shadow")]
    public byte @Shadow { get => SdkMemory.Read<byte >(Pointer+40); set { SdkMemory.Write(Pointer+40,value); } }
    [NativeMember("ExtraFont")]
    public byte @ExtraFont { get => SdkMemory.Read<byte >(Pointer+41); set { SdkMemory.Write(Pointer+41,value); } }
    [NativeMember("Proportional")]
    public byte @Proportional { get => SdkMemory.Read<byte >(Pointer+42); set { SdkMemory.Write(Pointer+42,value); } }
    [NativeMember("Style")]
    public short @Style { get => SdkMemory.Read<short >(Pointer+44); set { SdkMemory.Write(Pointer+44,value); } }
    [NativeMember("EdgeAmount")]
    public sbyte @EdgeAmount { get => SdkMemory.Read<sbyte >(Pointer+46); set { SdkMemory.Write(Pointer+46,value); } }
}
