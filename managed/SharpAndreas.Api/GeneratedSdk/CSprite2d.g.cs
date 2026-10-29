// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CSprite2d : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=4;
    public CSprite2d(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_pTexture")]
    public RwTexture? @Texture { get => SdkMemory.Read<IntPtr>(Pointer+0) == IntPtr.Zero ? null : new RwTexture(SdkMemory.Read<IntPtr>(Pointer+0)); set { SdkMemory.Write(Pointer+0,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("nextBufferIndex")]
    public static uint @NextBufferIndex { get => SdkMemory.Read<uint >(new IntPtr(0xC80458)); set { SdkMemory.Write(new IntPtr(0xC80458),value); } }
    [NativeMember("nextBufferVertex")]
    public static uint @NextBufferVertex { get => SdkMemory.Read<uint >(new IntPtr(0xC8045C)); set { SdkMemory.Write(new IntPtr(0xC8045C),value); } }
    [NativeMember("NearScreenZ")]
    public static float @NearScreenZ { get => SdkMemory.Read<float >(new IntPtr(0xC80460)); set { SdkMemory.Write(new IntPtr(0xC80460),value); } }
    [NativeMember("RecipNearClip")]
    public static float @RecipNearClip { get => SdkMemory.Read<float >(new IntPtr(0xC80464)); set { SdkMemory.Write(new IntPtr(0xC80464),value); } }
    [NativeMember("maVertices")]
    public static RwD3D9Vertex? @MaVertices { get => new IntPtr(0xC80468) == IntPtr.Zero ? null : new RwD3D9Vertex(new IntPtr(0xC80468)); }
    public void @InitializeAt() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2633 >(2633)(Pointer); }
    public void @Delete() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2634 >(2634)(Pointer); }
    public void @SetTexture(NativePointer<sbyte> @name) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2635 >(2635)(Pointer,@name.Pointer); }
    public void @SetTexture(NativePointer<sbyte> @name,NativePointer<sbyte> @maskName) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2636 >(2636)(Pointer,@name.Pointer,@maskName.Pointer); }
    public void @SetAddressingUV(RwTextureAddressMode @modeU,RwTextureAddressMode @modeV) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2637 >(2637)(Pointer,(int)@modeU,(int)@modeV); }
    public void @SetAddressing(RwTextureAddressMode @modeUV) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2638 >(2638)(Pointer,(int)@modeUV); }
    public void @SetRenderState() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2639 >(2639)(Pointer); }
    public void @Draw(float @x,float @y,float @width,float @height,CRGBA @color) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2640 >(2640)(Pointer,@x,@y,@width,@height,@color.Pointer); }
    public void @Draw(CRect @posn,CRGBA @color) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2641 >(2641)(Pointer,@posn.Pointer,@color.Pointer); }
    public void @DrawWithBilinearOffset(CRect @posn,CRGBA @color) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2642 >(2642)(Pointer,@posn.Pointer,@color.Pointer); }
    public void @Draw(CRect @posn,CRGBA @color,float @u1,float @v1,float @u2,float @v2,float @u3,float @v3,float @u4,float @v4) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2643 >(2643)(Pointer,@posn.Pointer,@color.Pointer,@u1,@v1,@u2,@v2,@u3,@v3,@u4,@v4); }
    public void @Draw(CRect @posn,CRGBA @color1,CRGBA @color2,CRGBA @color3,CRGBA @color4) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2644 >(2644)(Pointer,@posn.Pointer,@color1.Pointer,@color2.Pointer,@color3.Pointer,@color4.Pointer); }
    public void @Draw(float @x1,float @y1,float @x2,float @y2,float @x3,float @y3,float @x4,float @y4,CRGBA @color) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2645 >(2645)(Pointer,@x1,@y1,@x2,@y2,@x3,@y3,@x4,@y4,@color.Pointer); }
    public static void @SetRecipNearClip() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2646 >(2646)(); }
    public static void @InitPerFrame() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2647 >(2647)(); }
    public static bool @IsVertexBufferEmpty() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2648 >(2648)(); return __sdkResult != 0; }
    public static bool @IsVertexBufferFull() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2649 >(2649)(); return __sdkResult != 0; }
    public static void @RenderVertexBuffer() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2650 >(2650)(); }
    public static void @SetVertices(CRect @posn,CRGBA @color1,CRGBA @color2,CRGBA @color3,CRGBA @color4) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2651 >(2651)(@posn.Pointer,@color1.Pointer,@color2.Pointer,@color3.Pointer,@color4.Pointer); }
    public static void @SetVertices(float @x1,float @y1,float @x2,float @y2,float @x3,float @y3,float @x4,float @y4,CRGBA @color1,CRGBA @color2,CRGBA @color3,CRGBA @color4) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2652 >(2652)(@x1,@y1,@x2,@y2,@x3,@y3,@x4,@y4,@color1.Pointer,@color2.Pointer,@color3.Pointer,@color4.Pointer); }
    public static void @SetVertices(CRect @posn,CRGBA @color1,CRGBA @color2,CRGBA @color3,CRGBA @color4,float @u1,float @v1,float @u2,float @v2,float @u3,float @v3,float @u4,float @v4) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2653 >(2653)(@posn.Pointer,@color1.Pointer,@color2.Pointer,@color3.Pointer,@color4.Pointer,@u1,@v1,@u2,@v2,@u3,@v3,@u4,@v4); }
    public static void @SetVertices(int @numVerts,NativePointer<float> @posn,NativePointer<float> @texCoors,CRGBA @color) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2654 >(2654)(@numVerts,@posn.Pointer,@texCoors.Pointer,@color.Pointer); }
    public static void @SetVertices(int @numVerts,NativePointer<float> @posn,CRGBA? @color) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2655 >(2655)(@numVerts,@posn.Pointer,@color?.Pointer ?? IntPtr.Zero); }
    public static void @SetMaskVertices(int @numVerts,NativePointer<float> @posn,float @depth) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2656 >(2656)(@numVerts,@posn.Pointer,@depth); }
    public static void @SetVertices(RwD3D9Vertex? @vertices,CRect @posn,CRGBA @color1,CRGBA @color2,CRGBA @color3,CRGBA @color4,float @u1,float @v1,float @u2,float @v2,float @u3,float @v3,float @u4,float @v4) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2657 >(2657)(@vertices?.Pointer ?? IntPtr.Zero,@posn.Pointer,@color1.Pointer,@color2.Pointer,@color3.Pointer,@color4.Pointer,@u1,@v1,@u2,@v2,@u3,@v3,@u4,@v4); }
    public static void @DrawRect(CRect @posn,CRGBA @color) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2658 >(2658)(@posn.Pointer,@color.Pointer); }
    public static void @DrawTxRect(CRect @posn,CRGBA @color) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2659 >(2659)(@posn.Pointer,@color.Pointer); }
    public static void @DrawRect(CRect @posn,CRGBA @color1,CRGBA @color2,CRGBA @color3,CRGBA @color4) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2660 >(2660)(@posn.Pointer,@color1.Pointer,@color2.Pointer,@color3.Pointer,@color4.Pointer); }
    public static void @DrawRectXLU(CRect @posn,CRGBA @color1,CRGBA @color2,CRGBA @color3,CRGBA @color4) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2661 >(2661)(@posn.Pointer,@color1.Pointer,@color2.Pointer,@color3.Pointer,@color4.Pointer); }
    public static void @DrawAnyRect(float @x1,float @y1,float @x2,float @y2,float @x3,float @y3,float @x4,float @y4,CRGBA @color1,CRGBA @color2,CRGBA @color3,CRGBA @color4) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2662 >(2662)(@x1,@y1,@x2,@y2,@x3,@y3,@x4,@y4,@color1.Pointer,@color2.Pointer,@color3.Pointer,@color4.Pointer); }
    public static void @DrawCircleAtNearClip(CVector2D @posn,float @size,CRGBA @color,int @angle) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2663 >(2663)(@posn.Pointer,@size,@color.Pointer,@angle); }
    public static void @SetVerticesForSniper(CRect @posn,CRGBA @color1,CRGBA @color2,CRGBA @color3,CRGBA @color4) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2664 >(2664)(@posn.Pointer,@color1.Pointer,@color2.Pointer,@color3.Pointer,@color4.Pointer); }
    public static void @OffsetTexCoordForBilinearFiltering(float @width,float @height) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2665 >(2665)(@width,@height); }
    public static void @AddToBuffer(CRect @posn,CRGBA @color,float @u1,float @v1,float @u2,float @v2,float @u3,float @v3,float @u4,float @v4) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2666 >(2666)(@posn.Pointer,@color.Pointer,@u1,@v1,@u2,@v2,@u3,@v3,@u4,@v4); }
    public static void @Draw2DPolygon(float @x1,float @y1,float @x2,float @y2,float @x3,float @y3,float @x4,float @y4,CRGBA @color) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2667 >(2667)(@x1,@y1,@x2,@y2,@x3,@y3,@x4,@y4,@color.Pointer); }
    public static void @DrawBarChart(float @x,float @y,ushort @width,byte @height,float @progress,sbyte @progressAdd,byte @drawPercentage,byte @drawBlackBorder,CRGBA @color,CRGBA @addColor) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2668 >(2668)(@x,@y,@width,@height,@progress,@progressAdd,@drawPercentage,@drawBlackBorder,@color.Pointer,@addColor.Pointer); }
}
