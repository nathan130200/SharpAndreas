// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CFont : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=1;
    public CFont(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("Sprite")]
    public static CSprite2d? @Sprite { get => new IntPtr(0xC71AD0) == IntPtr.Zero ? null : new CSprite2d(new IntPtr(0xC71AD0)); }
    [NativeMember("ButtonSprite")]
    public static CSprite2d? @ButtonSprite { get => new IntPtr(0xC71AD8) == IntPtr.Zero ? null : new CSprite2d(new IntPtr(0xC71AD8)); }
    [NativeMember("m_nExtraFontSymbolId")]
    public static byte @ExtraFontSymbolId { get => SdkMemory.Read<byte >(new IntPtr(0xC71A54)); set { SdkMemory.Write(new IntPtr(0xC71A54),value); } }
    [NativeMember("m_bNewLine")]
    public static bool @NewLine { get => SdkMemory.Read<bool >(new IntPtr(0xC71A55)); set { SdkMemory.Write(new IntPtr(0xC71A55),value); } }
    [NativeMember("m_Color")]
    public static CRGBA? @Color { get => new IntPtr(0xC71A60) == IntPtr.Zero ? null : new CRGBA(new IntPtr(0xC71A60)); }
    [NativeMember("m_Scale")]
    public static CVector2D? @Scale { get => new IntPtr(0xC71A64) == IntPtr.Zero ? null : new CVector2D(new IntPtr(0xC71A64)); }
    [NativeMember("m_fSlant")]
    public static float @Slant { get => SdkMemory.Read<float >(new IntPtr(0xC71A6C)); set { SdkMemory.Write(new IntPtr(0xC71A6C),value); } }
    [NativeMember("m_fSlantRefPoint")]
    public static CVector2D? @SlantRefPoint { get => new IntPtr(0xC71A70) == IntPtr.Zero ? null : new CVector2D(new IntPtr(0xC71A70)); }
    [NativeMember("m_bFontJustify")]
    public static bool @FontJustify { get => SdkMemory.Read<bool >(new IntPtr(0xC71A78)); set { SdkMemory.Write(new IntPtr(0xC71A78),value); } }
    [NativeMember("m_bFontCentreAlign")]
    public static bool @FontCentreAlign { get => SdkMemory.Read<bool >(new IntPtr(0xC71A79)); set { SdkMemory.Write(new IntPtr(0xC71A79),value); } }
    [NativeMember("m_bFontRightAlign")]
    public static bool @FontRightAlign { get => SdkMemory.Read<bool >(new IntPtr(0xC71A7A)); set { SdkMemory.Write(new IntPtr(0xC71A7A),value); } }
    [NativeMember("m_bFontBackground")]
    public static bool @FontBackground { get => SdkMemory.Read<bool >(new IntPtr(0xC71A7B)); set { SdkMemory.Write(new IntPtr(0xC71A7B),value); } }
    [NativeMember("m_bEnlargeBackgroundBox")]
    public static bool @EnlargeBackgroundBox { get => SdkMemory.Read<bool >(new IntPtr(0xC71A7C)); set { SdkMemory.Write(new IntPtr(0xC71A7C),value); } }
    [NativeMember("m_bFontPropOn")]
    public static bool @FontPropOn { get => SdkMemory.Read<bool >(new IntPtr(0xC71A7D)); set { SdkMemory.Write(new IntPtr(0xC71A7D),value); } }
    [NativeMember("m_bFontIsBlip")]
    public static bool @FontIsBlip { get => SdkMemory.Read<bool >(new IntPtr(0xC71A7E)); set { SdkMemory.Write(new IntPtr(0xC71A7E),value); } }
    [NativeMember("m_dwFontAlpha")]
    public static uint @FontAlpha { get => SdkMemory.Read<uint >(new IntPtr(0xC71A80)); }
    [NativeMember("m_FontBackgroundColor")]
    public static CRGBA? @FontBackgroundColor { get => new IntPtr(0xC71A84) == IntPtr.Zero ? null : new CRGBA(new IntPtr(0xC71A84)); }
    [NativeMember("m_fWrapx")]
    public static float @Wrapx { get => SdkMemory.Read<float >(new IntPtr(0xC71A88)); set { SdkMemory.Write(new IntPtr(0xC71A88),value); } }
    [NativeMember("m_fFontCentreSize")]
    public static float @FontCentreSize { get => SdkMemory.Read<float >(new IntPtr(0xC71A8C)); set { SdkMemory.Write(new IntPtr(0xC71A8C),value); } }
    [NativeMember("m_fRightJustifyWrap")]
    public static float @RightJustifyWrap { get => SdkMemory.Read<float >(new IntPtr(0xC71A90)); set { SdkMemory.Write(new IntPtr(0xC71A90),value); } }
    [NativeMember("m_FontTextureId")]
    public static byte @FontTextureId { get => SdkMemory.Read<byte >(new IntPtr(0xC71A94)); set { SdkMemory.Write(new IntPtr(0xC71A94),value); } }
    [NativeMember("m_FontStyle")]
    public static byte @FontStyle { get => SdkMemory.Read<byte >(new IntPtr(0xC71A95)); set { SdkMemory.Write(new IntPtr(0xC71A95),value); } }
    [NativeMember("m_nFontShadow")]
    public static byte @FontShadow { get => SdkMemory.Read<byte >(new IntPtr(0xC71A96)); set { SdkMemory.Write(new IntPtr(0xC71A96),value); } }
    [NativeMember("m_FontDropColor")]
    public static CRGBA? @FontDropColor { get => new IntPtr(0xC71A97) == IntPtr.Zero ? null : new CRGBA(new IntPtr(0xC71A97)); }
    [NativeMember("m_nFontOutlineSize")]
    public static byte @FontOutlineSize { get => SdkMemory.Read<byte >(new IntPtr(0xC71A9B)); set { SdkMemory.Write(new IntPtr(0xC71A9B),value); } }
    [NativeMember("m_nFontOutline")]
    public static byte @FontOutline { get => SdkMemory.Read<byte >(new IntPtr(0xC71A9C)); set { SdkMemory.Write(new IntPtr(0xC71A9C),value); } }
    [NativeMember("RenderState")]
    public static CFontRenderState @RenderState { get => new CFontRenderState(new IntPtr(0xC71AA0)); set { SdkMemory.Copy(value.Pointer,new IntPtr(0xC71AA0),48); } }
    public static void @Initialise() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2669 >(2669)(); }
    public static void @Shutdown() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2670 >(2670)(); }
    public static void @PrintChar(float @x,float @y,sbyte @character) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2671 >(2671)(@x,@y,@character); }
    public static NativePointer<sbyte> @ParseToken(NativePointer<sbyte> @text,CRGBA @color,bool @isBlip,NativePointer<sbyte> @tag) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2672 >(2672)(@text.Pointer,@color.Pointer,(@isBlip ? 1 : 0),@tag.Pointer); return new NativePointer<sbyte>(__sdkResult); }
    public static void @SetScale(float @w,float @h) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2673 >(2673)(@w,@h); }
    public static void @SetScaleForCurrentlanguage(float @w,float @h) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2674 >(2674)(@w,@h); }
    public static void @SetSlantRefPoint(float @x,float @y) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2675 >(2675)(@x,@y); }
    public static void @SetSlant(float @value) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2676 >(2676)(@value); }
    public static void @SetColor(CRGBA @color) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2677 >(2677)(@color.Pointer); }
    public static void @SetFontStyle(short @style) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2678 >(2678)(@style); }
    public static void @SetWrapx(float @value) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2679 >(2679)(@value); }
    public static void @SetCentreSize(float @value) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2680 >(2680)(@value); }
    public static void @SetRightJustifyWrap(float @value) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2681 >(2681)(@value); }
    public static void @SetAlphaFade(float @alpha) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2682 >(2682)(@alpha); }
    public static void @SetDropColor(CRGBA @color) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2683 >(2683)(@color.Pointer); }
    public static void @SetDropShadowPosition(short @value) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2684 >(2684)(@value); }
    public static void @SetEdge(short @value) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2685 >(2685)(@value); }
    public static void @SetProportional(bool @on) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2686 >(2686)((@on ? 1 : 0)); }
    public static void @SetBackground(bool @enable,bool @includeWrap) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2687 >(2687)((@enable ? 1 : 0),(@includeWrap ? 1 : 0)); }
    public static void @SetBackgroundColor(CRGBA @color) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2688 >(2688)(@color.Pointer); }
    public static void @SetJustify(bool @on) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2689 >(2689)((@on ? 1 : 0)); }
    public static void @SetOrientation(eFontAlignment @alignment) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2690 >(2690)((int)@alignment); }
    public static void @InitPerFrame() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2691 >(2691)(); }
    public static void @RenderFontBuffer() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2692 >(2692)(); }
    public static float @GetStringWidth(NativePointer<sbyte> @string,bool @spaces,bool @scriptValues) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2693 >(2693)(@string.Pointer,(@spaces ? 1 : 0),(@scriptValues ? 1 : 0)); return __sdkResult; }
    public static void @DrawFonts() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2694 >(2694)(); }
    public static short @ProcessCurrentString(bool @print,float @x,float @y,NativePointer<sbyte> @text) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2695 >(2695)((@print ? 1 : 0),@x,@y,@text.Pointer); return __sdkResult; }
    public static short @GetNumberLines(float @x,float @y,NativePointer<sbyte> @text) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2696 >(2696)(@x,@y,@text.Pointer); return __sdkResult; }
    public static short @ProcessStringToDisplay(float @x,float @y,NativePointer<sbyte> @text) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2697 >(2697)(@x,@y,@text.Pointer); return __sdkResult; }
    public static void @GetTextRect(CRect? @rect,float @x,float @y,NativePointer<sbyte> @text) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2698 >(2698)(@rect?.Pointer ?? IntPtr.Zero,@x,@y,@text.Pointer); }
    public static void @PrintString(float @x,float @y,NativePointer<sbyte> @text) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2699 >(2699)(@x,@y,@text.Pointer); }
    public static void @PrintStringFromBottom(float @x,float @y,NativePointer<sbyte> @text) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2700 >(2700)(@x,@y,@text.Pointer); }
}
