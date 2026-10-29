// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class RwRaster : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=52;
    public RwRaster(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("parent")]
    public RwRaster? @Parent { get => SdkMemory.Read<IntPtr>(Pointer+0) == IntPtr.Zero ? null : new RwRaster(SdkMemory.Read<IntPtr>(Pointer+0)); set { SdkMemory.Write(Pointer+0,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("cpPixels")]
    public NativePointer<byte> @CpPixels { get => new NativePointer<byte>(SdkMemory.Read<IntPtr>(Pointer+4)); set { SdkMemory.Write(Pointer+4,value.Pointer); } }
    [NativeMember("palette")]
    public NativePointer<byte> @Palette { get => new NativePointer<byte>(SdkMemory.Read<IntPtr>(Pointer+8)); set { SdkMemory.Write(Pointer+8,value.Pointer); } }
    [NativeMember("width")]
    public int @Width { get => SdkMemory.Read<int >(Pointer+12); set { SdkMemory.Write(Pointer+12,value); } }
    [NativeMember("height")]
    public int @Height { get => SdkMemory.Read<int >(Pointer+16); set { SdkMemory.Write(Pointer+16,value); } }
    [NativeMember("depth")]
    public int @Depth { get => SdkMemory.Read<int >(Pointer+20); set { SdkMemory.Write(Pointer+20,value); } }
    [NativeMember("stride")]
    public int @Stride { get => SdkMemory.Read<int >(Pointer+24); set { SdkMemory.Write(Pointer+24,value); } }
    [NativeMember("nOffsetX")]
    public short @OffsetX { get => SdkMemory.Read<short >(Pointer+28); set { SdkMemory.Write(Pointer+28,value); } }
    [NativeMember("nOffsetY")]
    public short @OffsetY { get => SdkMemory.Read<short >(Pointer+30); set { SdkMemory.Write(Pointer+30,value); } }
    [NativeMember("cType")]
    public byte @Type { get => SdkMemory.Read<byte >(Pointer+32); set { SdkMemory.Write(Pointer+32,value); } }
    [NativeMember("cFlags")]
    public byte @Flags { get => SdkMemory.Read<byte >(Pointer+33); set { SdkMemory.Write(Pointer+33,value); } }
    [NativeMember("privateFlags")]
    public byte @PrivateFlags { get => SdkMemory.Read<byte >(Pointer+34); set { SdkMemory.Write(Pointer+34,value); } }
    [NativeMember("cFormat")]
    public byte @Format { get => SdkMemory.Read<byte >(Pointer+35); set { SdkMemory.Write(Pointer+35,value); } }
    [NativeMember("originalPixels")]
    public NativePointer<byte> @OriginalPixels { get => new NativePointer<byte>(SdkMemory.Read<IntPtr>(Pointer+36)); set { SdkMemory.Write(Pointer+36,value.Pointer); } }
    [NativeMember("originalWidth")]
    public int @OriginalWidth { get => SdkMemory.Read<int >(Pointer+40); set { SdkMemory.Write(Pointer+40,value); } }
    [NativeMember("originalHeight")]
    public int @OriginalHeight { get => SdkMemory.Read<int >(Pointer+44); set { SdkMemory.Write(Pointer+44,value); } }
    [NativeMember("originalStride")]
    public int @OriginalStride { get => SdkMemory.Read<int >(Pointer+48); set { SdkMemory.Write(Pointer+48,value); } }
}
