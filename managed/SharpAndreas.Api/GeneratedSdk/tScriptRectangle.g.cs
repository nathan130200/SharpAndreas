// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class tScriptRectangle : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=60;
    public tScriptRectangle(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("type")]
    public eScriptRectangleType @Type { get => SdkMemory.Read<eScriptRectangleType >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("drawBeforeFade")]
    public bool @DrawBeforeFade { get => SdkMemory.Read<bool >(Pointer+4); set { SdkMemory.Write(Pointer+4,value); } }
    [NativeMember("_pad_5")]
    public sbyte @Pad5 { get => SdkMemory.Read<sbyte >(Pointer+5); set { SdkMemory.Write(Pointer+5,value); } }
    [NativeMember("spriteIdx")]
    public short @SpriteIndex { get => SdkMemory.Read<short >(Pointer+6); set { SdkMemory.Write(Pointer+6,value); } }
    [NativeMember("rect")]
    public CRect @Rect { get => new CRect(Pointer+8); set { SdkMemory.Copy(value.Pointer,Pointer+8,16); } }
    [NativeMember("angle")]
    public float @Angle { get => SdkMemory.Read<float >(Pointer+24); set { SdkMemory.Write(Pointer+24,value); } }
    [NativeMember("color")]
    public CRGBA @Color { get => new CRGBA(Pointer+28); set { SdkMemory.Copy(value.Pointer,Pointer+28,4); } }
    [NativeMember("title")]
    public NativeArray<sbyte> @Title { get => new NativeArray<sbyte>(Pointer+32,8); }
    [NativeMember("_pad_28")]
    public sbyte @Pad28 { get => SdkMemory.Read<sbyte >(Pointer+40); set { SdkMemory.Write(Pointer+40,value); } }
    [NativeMember("_pad_29")]
    public sbyte @Pad29 { get => SdkMemory.Read<sbyte >(Pointer+41); set { SdkMemory.Write(Pointer+41,value); } }
    [NativeMember("message")]
    public NativeArray<sbyte> @Message { get => new NativeArray<sbyte>(Pointer+42,8); }
    [NativeMember("_pad_32")]
    public sbyte @Pad32 { get => SdkMemory.Read<sbyte >(Pointer+50); set { SdkMemory.Write(Pointer+50,value); } }
    [NativeMember("_pad_33")]
    public sbyte @Pad33 { get => SdkMemory.Read<sbyte >(Pointer+51); set { SdkMemory.Write(Pointer+51,value); } }
    [NativeMember("alignment")]
    public eFontAlignment @Alignment { get => SdkMemory.Read<eFontAlignment >(Pointer+52); set { SdkMemory.Write(Pointer+52,value); } }
    [NativeMember("_pad_36")]
    public sbyte @Pad36 { get => SdkMemory.Read<sbyte >(Pointer+53); set { SdkMemory.Write(Pointer+53,value); } }
    [NativeMember("_pad_37")]
    public sbyte @Pad37 { get => SdkMemory.Read<sbyte >(Pointer+54); set { SdkMemory.Write(Pointer+54,value); } }
    [NativeMember("_pad_38")]
    public sbyte @Pad38 { get => SdkMemory.Read<sbyte >(Pointer+55); set { SdkMemory.Write(Pointer+55,value); } }
    [NativeMember("textboxStyle")]
    public int @TextboxStyle { get => SdkMemory.Read<int >(Pointer+56); set { SdkMemory.Write(Pointer+56,value); } }
}
