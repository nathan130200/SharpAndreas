// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CSprite : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=1;
    public CSprite(System.IntPtr pointer) : base(pointer) {}
    public static void @RenderOneXLUSprite(float @x,float @y,float @z,float @halfWidth,float @halfHeight,byte @red,byte @green,byte @blue,short @alpha,float @rhw,byte @intensity,byte @udir,byte @vdir) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3793 >(3793)(@x,@y,@z,@halfWidth,@halfHeight,@red,@green,@blue,@alpha,@rhw,@intensity,@udir,@vdir); }
    public static void @FlushSpriteBuffer() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3794 >(3794)(); }
    public static void @InitSpriteBuffer() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3795 >(3795)(); }
    public static void @RenderBufferedOneXLUSprite_Rotate_2Colours(float @x,float @y,float @z,float @w,float @h,byte @r1,byte @g1,byte @b1,byte @r2,byte @g2,byte @b2,float @cx,float @cy,float @recipz,float @rotation,byte @a) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3796 >(3796)(@x,@y,@z,@w,@h,@r1,@g1,@b1,@r2,@g2,@b2,@cx,@cy,@recipz,@rotation,@a); }
    public static void @RenderBufferedOneXLUSprite_Rotate_Aspect(float @x,float @y,float @z,float @w,float @h,byte @r,byte @g,byte @b,short @intens,float @recipz,float @rotation,byte @a) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3797 >(3797)(@x,@y,@z,@w,@h,@r,@g,@b,@intens,@recipz,@rotation,@a); }
    public static bool @CalcScreenCoors(RwV3d @posn,RwV3d? @out,NativePointer<float> @w,NativePointer<float> @h,bool @checkMaxVisible,bool @checkMinVisible) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3798 >(3798)(@posn.Pointer,@out?.Pointer ?? IntPtr.Zero,@w.Pointer,@h.Pointer,(@checkMaxVisible ? 1 : 0),(@checkMinVisible ? 1 : 0)); return __sdkResult != 0; }
}
