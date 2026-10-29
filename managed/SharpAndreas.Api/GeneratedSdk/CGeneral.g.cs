// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CGeneral : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=1;
    public CGeneral(System.IntPtr pointer) : base(pointer) {}
    public static float @LimitAngle(float @angle) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2892 >(2892)(@angle); return __sdkResult; }
    public static float @LimitRadianAngle(float @angle) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2893 >(2893)(@angle); return __sdkResult; }
    public static float @GetRadianAngleBetweenPoints(float @x1,float @y1,float @x2,float @y2) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2894 >(2894)(@x1,@y1,@x2,@y2); return __sdkResult; }
    public static float @GetATanOfXY(float @x,float @y) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2895 >(2895)(@x,@y); return __sdkResult; }
    public static byte @GetNodeHeadingFromVector(float @x,float @y) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2896 >(2896)(@x,@y); return __sdkResult; }
    public static bool @SolveQuadratic(float @a,float @b,float @c,NativePointer<float> @x1,NativePointer<float> @x2) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2897 >(2897)(@a,@b,@c,@x1.Pointer,@x2.Pointer); return __sdkResult != 0; }
    public static float @GetAngleBetweenPoints(float @x1,float @y1,float @x2,float @y2) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2898 >(2898)(@x1,@y1,@x2,@y2); return __sdkResult; }
    public static uint @GetRandomNumberInRange(int @min,int @max) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2899 >(2899)(@min,@max); return __sdkResult; }
    public static float @GetRandomNumberInRange(float @min,float @max) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2900 >(2900)(@min,@max); return __sdkResult; }
    public static uint @GetRandomNumber() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2901 >(2901)(); return __sdkResult; }
    public static void @CamShakeNoPos(CCamera? @camera,float @strength) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2902 >(2902)(@camera?.Pointer ?? IntPtr.Zero,@strength); }
}
