// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CRect : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=16;
    public CRect(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("left")]
    public float @Left { get => SdkMemory.Read<float >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("bottom")]
    public float @Bottom { get => SdkMemory.Read<float >(Pointer+4); set { SdkMemory.Write(Pointer+4,value); } }
    [NativeMember("right")]
    public float @Right { get => SdkMemory.Read<float >(Pointer+8); set { SdkMemory.Write(Pointer+8,value); } }
    [NativeMember("top")]
    public float @Top { get => SdkMemory.Read<float >(Pointer+12); set { SdkMemory.Write(Pointer+12,value); } }
    public void @InitializeAt(float @x1,float @y1,float @x2,float @y2) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D304 >(304)(Pointer,@x1,@y1,@x2,@y2); }
    public void @InitializeAt() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D305 >(305)(Pointer); }
    public bool @IsFlipped() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D306 >(306)(Pointer); return __sdkResult != 0; }
    public void @Restrict(CRect @restriction) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D307 >(307)(Pointer,@restriction.Pointer); }
    public void @Resize(float @resizeX,float @resizeY) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D308 >(308)(Pointer,@resizeX,@resizeY); }
    public bool @IsPointInside(CVector2D @point) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D309 >(309)(Pointer,@point.Pointer); return __sdkResult != 0; }
    public bool @IsCircleInside(CVector2D @circleCenter,float @circleRadius) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D310 >(310)(Pointer,@circleCenter.Pointer,@circleRadius); return __sdkResult != 0; }
    public void @SetFromCenter(float @x,float @y,float @size) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D311 >(311)(Pointer,@x,@y,@size); }
    public void @GetCenter(NativePointer<float> @x,NativePointer<float> @y) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D312 >(312)(Pointer,@x.Pointer,@y.Pointer); }
    public void @StretchToPoint(float @x,float @y) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D313 >(313)(Pointer,@x,@y); }
    public void @Grow(float @l,float @r,float @t,float @b) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D314 >(314)(Pointer,@l,@r,@t,@b); }
    public void @Translate(float @x,float @y) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D315 >(315)(Pointer,@x,@y); }
}
