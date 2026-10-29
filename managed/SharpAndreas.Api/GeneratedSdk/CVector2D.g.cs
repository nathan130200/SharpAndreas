// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CVector2D : RwV2d
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=8;
    public CVector2D(System.IntPtr pointer) : base(pointer) {}
    public void @InitializeAt() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D53 >(53)(Pointer); }
    public void @InitializeAt(float @value) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D54 >(54)(Pointer,@value); }
    public void @InitializeAt(float @x,float @y) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D55 >(55)(Pointer,@x,@y); }
    public void @InitializeAt(CVector2D @src) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D56 >(56)(Pointer,@src.Pointer); }
    public void @InitializeAt(RwV2d @src) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D57 >(57)(Pointer,@src.Pointer); }
    public void @Reset() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D58 >(58)(Pointer); }
    public void @Set(float @value) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D59 >(59)(Pointer,@value); }
    public void @Set(float @x,float @y) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D60 >(60)(Pointer,@x,@y); }
    public void @AssignNative(CVector2D @src) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D61 >(61)(Pointer,@src.Pointer); }
    public void @From3D(CVector @src) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D62 >(62)(Pointer,@src.Pointer); }
    public void @FromSum(CVector2D @left,CVector2D @right) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D63 >(63)(Pointer,@left.Pointer,@right.Pointer); }
    public void @FromDiff(CVector2D @left,CVector2D @right) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D64 >(64)(Pointer,@left.Pointer,@right.Pointer); }
    public void @FromLerp(CVector2D @begin,CVector2D @end,float @progress) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D65 >(65)(Pointer,@begin.Pointer,@end.Pointer,@progress); }
    public CVector @To3D() { Game.CheckThread(); var result=NativeObject.AllocateStorage<CVector >(12); try { SdkBindings.Get<GeneratedDelegates.D66 >(66)(Pointer,result.Pointer); return result; } catch { result.Dispose(); throw; } }
    public bool @Operator_operator__(CVector2D @other) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D67 >(67)(Pointer,@other.Pointer); return __sdkResult != 0; }
    public bool @Operator_operator____baabeefd(CVector2D @other) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D68 >(68)(Pointer,@other.Pointer); return __sdkResult != 0; }
    public CVector2D @SubtractNative() { Game.CheckThread(); var result=NativeObject.AllocateStorage<CVector2D >(8); try { SdkBindings.Get<GeneratedDelegates.D69 >(69)(Pointer,result.Pointer); return result; } catch { result.Dispose(); throw; } }
    public float @Distance(CVector2D @other) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D70 >(70)(Pointer,@other.Pointer); return __sdkResult; }
    public float @Dot(CVector2D @other) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D71 >(71)(Pointer,@other.Pointer); return __sdkResult; }
    public float @Cross(CVector2D @other) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D72 >(72)(Pointer,@other.Pointer); return __sdkResult; }
    public float @Heading() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D73 >(73)(Pointer); return __sdkResult; }
    public float @Magnitude() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D74 >(74)(Pointer); return __sdkResult; }
    public float @MagnitudeSqr() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D75 >(75)(Pointer); return __sdkResult; }
    public CVector2D @Normalized() { Game.CheckThread(); var result=NativeObject.AllocateStorage<CVector2D >(8); try { SdkBindings.Get<GeneratedDelegates.D76 >(76)(Pointer,result.Pointer); return result; } catch { result.Dispose(); throw; } }
    public bool @IsNormalized() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D77 >(77)(Pointer); return __sdkResult != 0; }
    public bool @IsZero() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D78 >(78)(Pointer); return __sdkResult != 0; }
    public void @AddAssignNative(float @value) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D79 >(79)(Pointer,@value); }
    public void @AddAssignNative(CVector2D @other) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D80 >(80)(Pointer,@other.Pointer); }
    public void @SubtractAssignNative(float @value) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D81 >(81)(Pointer,@value); }
    public void @SubtractAssignNative(CVector2D @other) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D82 >(82)(Pointer,@other.Pointer); }
    public void @MultiplyAssignNative(float @multiplier) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D83 >(83)(Pointer,@multiplier); }
    public void @DivideAssignNative(float @divisor) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D84 >(84)(Pointer,@divisor); }
    public void @Normalize() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D85 >(85)(Pointer); }
    public float @NormalizeAndMag() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D86 >(86)(Pointer); return __sdkResult; }
    public static CVector2D @Sum(CVector2D @left,CVector2D @right) { Game.CheckThread(); var result=NativeObject.AllocateStorage<CVector2D >(8); try { SdkBindings.Get<GeneratedDelegates.D87 >(87)(@left.Pointer,@right.Pointer,result.Pointer); return result; } catch { result.Dispose(); throw; } }
    public static CVector2D @Diff(CVector2D @left,CVector2D @right) { Game.CheckThread(); var result=NativeObject.AllocateStorage<CVector2D >(8); try { SdkBindings.Get<GeneratedDelegates.D88 >(88)(@left.Pointer,@right.Pointer,result.Pointer); return result; } catch { result.Dispose(); throw; } }
    public static float @Distance(CVector2D @left,CVector2D @right) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D89 >(89)(@left.Pointer,@right.Pointer); return __sdkResult; }
    public static CVector2D @Lerp(CVector2D @begin,CVector2D @end,float @progress) { Game.CheckThread(); var result=NativeObject.AllocateStorage<CVector2D >(8); try { SdkBindings.Get<GeneratedDelegates.D90 >(90)(@begin.Pointer,@end.Pointer,@progress,result.Pointer); return result; } catch { result.Dispose(); throw; } }
    public static float @Dot(CVector2D @left,CVector2D @right) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D91 >(91)(@left.Pointer,@right.Pointer); return __sdkResult; }
    public static float @Cross(CVector2D @left,CVector2D @right) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D92 >(92)(@left.Pointer,@right.Pointer); return __sdkResult; }
}
