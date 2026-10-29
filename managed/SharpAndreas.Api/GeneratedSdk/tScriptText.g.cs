// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class tScriptText : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=68;
    public tScriptText(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("letterWidth")]
    public float @LetterWidth { get => SdkMemory.Read<float >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("letterHeight")]
    public float @LetterHeight { get => SdkMemory.Read<float >(Pointer+4); set { SdkMemory.Write(Pointer+4,value); } }
    [NativeMember("color")]
    public CRGBA @Color { get => new CRGBA(Pointer+8); set { SdkMemory.Copy(value.Pointer,Pointer+8,4); } }
    [NativeMember("justify")]
    public bool @Justify { get => SdkMemory.Read<bool >(Pointer+12); set { SdkMemory.Write(Pointer+12,value); } }
    [NativeMember("centered")]
    public bool @Centered { get => SdkMemory.Read<bool >(Pointer+13); set { SdkMemory.Write(Pointer+13,value); } }
    [NativeMember("withBackground")]
    public bool @WithBackground { get => SdkMemory.Read<bool >(Pointer+14); set { SdkMemory.Write(Pointer+14,value); } }
    [NativeMember("_pad")]
    public sbyte @Pad { get => SdkMemory.Read<sbyte >(Pointer+15); set { SdkMemory.Write(Pointer+15,value); } }
    [NativeMember("wrapWidth")]
    public float @WrapWidth { get => SdkMemory.Read<float >(Pointer+16); set { SdkMemory.Write(Pointer+16,value); } }
    [NativeMember("centerWidth")]
    public float @CenterWidth { get => SdkMemory.Read<float >(Pointer+20); set { SdkMemory.Write(Pointer+20,value); } }
    [NativeMember("backgroundBoxColor")]
    public CRGBA @BackgroundBoxColor { get => new CRGBA(Pointer+24); set { SdkMemory.Copy(value.Pointer,Pointer+24,4); } }
    [NativeMember("proportional")]
    public bool @Proportional { get => SdkMemory.Read<bool >(Pointer+28); set { SdkMemory.Write(Pointer+28,value); } }
    [NativeMember("backgroundColor")]
    public CRGBA @BackgroundColor { get => new CRGBA(Pointer+29); set { SdkMemory.Copy(value.Pointer,Pointer+29,4); } }
    [NativeMember("shadowType")]
    public sbyte @ShadowType { get => SdkMemory.Read<sbyte >(Pointer+33); set { SdkMemory.Write(Pointer+33,value); } }
    [NativeMember("outlineType")]
    public sbyte @OutlineType { get => SdkMemory.Read<sbyte >(Pointer+34); set { SdkMemory.Write(Pointer+34,value); } }
    [NativeMember("drawBeforeFade")]
    public bool @DrawBeforeFade { get => SdkMemory.Read<bool >(Pointer+35); set { SdkMemory.Write(Pointer+35,value); } }
    [NativeMember("rightJustify")]
    public bool @RightJustify { get => SdkMemory.Read<bool >(Pointer+36); set { SdkMemory.Write(Pointer+36,value); } }
    [NativeMember("_pad_25")]
    public sbyte @Pad25 { get => SdkMemory.Read<sbyte >(Pointer+37); set { SdkMemory.Write(Pointer+37,value); } }
    [NativeMember("_pad_26")]
    public sbyte @Pad26 { get => SdkMemory.Read<sbyte >(Pointer+38); set { SdkMemory.Write(Pointer+38,value); } }
    [NativeMember("_pad_27")]
    public sbyte @Pad27 { get => SdkMemory.Read<sbyte >(Pointer+39); set { SdkMemory.Write(Pointer+39,value); } }
    [NativeMember("font")]
    public int @Font { get => SdkMemory.Read<int >(Pointer+40); set { SdkMemory.Write(Pointer+40,value); } }
    [NativeMember("xPosition")]
    public float @XPosition { get => SdkMemory.Read<float >(Pointer+44); set { SdkMemory.Write(Pointer+44,value); } }
    [NativeMember("yPosition")]
    public float @YPosition { get => SdkMemory.Read<float >(Pointer+48); set { SdkMemory.Write(Pointer+48,value); } }
    [NativeMember("text")]
    public NativeArray<sbyte> @Text { get => new NativeArray<sbyte>(Pointer+52,8); }
    [NativeMember("param1")]
    public int @Param1 { get => SdkMemory.Read<int >(Pointer+60); set { SdkMemory.Write(Pointer+60,value); } }
    [NativeMember("param2")]
    public int @Param2 { get => SdkMemory.Read<int >(Pointer+64); set { SdkMemory.Write(Pointer+64,value); } }
}
