// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class tPickupMessage : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=36;
    public tPickupMessage(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("x")]
    public float @X { get => SdkMemory.Read<float >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("y")]
    public float @Y { get => SdkMemory.Read<float >(Pointer+4); set { SdkMemory.Write(Pointer+4,value); } }
    [NativeMember("z")]
    public float @Z { get => SdkMemory.Read<float >(Pointer+8); set { SdkMemory.Write(Pointer+8,value); } }
    [NativeMember("width")]
    public float @Width { get => SdkMemory.Read<float >(Pointer+12); set { SdkMemory.Write(Pointer+12,value); } }
    [NativeMember("height")]
    public float @Height { get => SdkMemory.Read<float >(Pointer+16); set { SdkMemory.Write(Pointer+16,value); } }
    [NativeMember("color")]
    public CRGBA @Color { get => new CRGBA(Pointer+20); set { SdkMemory.Copy(value.Pointer,Pointer+20,4); } }
    [NativeMember("flags")]
    public byte @Flags { get => SdkMemory.Read<byte >(Pointer+24); set { SdkMemory.Write(Pointer+24,value); } }
    [NativeMember("field_19")]
    public sbyte @Field19 { get => SdkMemory.Read<sbyte >(Pointer+25); set { SdkMemory.Write(Pointer+25,value); } }
    [NativeMember("price")]
    public uint @Price { get => SdkMemory.Read<uint >(Pointer+28); set { SdkMemory.Write(Pointer+28,value); } }
    [NativeMember("messageText")]
    public NativePointer<sbyte> @MessageText { get => new NativePointer<sbyte>(SdkMemory.Read<IntPtr>(Pointer+32)); set { SdkMemory.Write(Pointer+32,value.Pointer); } }
}
