// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CVector : RwV3d
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=12;
    public CVector(System.IntPtr pointer) : base(pointer) {}
    public void @InitializeAt() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1 >(1)(Pointer); }
    public void @InitializeAt(float @value) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2 >(2)(Pointer,@value); }
    public void @InitializeAt(float @x,float @y,float @z) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3 >(3)(Pointer,@x,@y,@z); }
    public void @InitializeAt(CVector @src) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4 >(4)(Pointer,@src.Pointer); }
    public void @InitializeAt(RwV3d @src) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D5 >(5)(Pointer,@src.Pointer); }
    public void @InitializeAt(CVector2D @xy,float @z) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D6 >(6)(Pointer,@xy.Pointer,@z); }
    public void @Reset() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D7 >(7)(Pointer); }
    public void @Set(float @value) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D8 >(8)(Pointer,@value); }
    public void @Set(float @x,float @y,float @z) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D9 >(9)(Pointer,@x,@y,@z); }
    public void @AssignNative(CVector @src) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D10 >(10)(Pointer,@src.Pointer); }
    public void @From2D(CVector2D @xy,float @z) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D11 >(11)(Pointer,@xy.Pointer,@z); }
    public void @FromSum(CVector @left,CVector @right) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D12 >(12)(Pointer,@left.Pointer,@right.Pointer); }
    public void @FromDiff(CVector @left,CVector @right) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D13 >(13)(Pointer,@left.Pointer,@right.Pointer); }
    public void @FromLerp(CVector @begin,CVector @end,float @progress) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D14 >(14)(Pointer,@begin.Pointer,@end.Pointer,@progress); }
    public void @FromCross(CVector @left,CVector @right) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D15 >(15)(Pointer,@left.Pointer,@right.Pointer); }
    public void @FromMultiply(CMatrix @matrix,CVector @point) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D16 >(16)(Pointer,@matrix.Pointer,@point.Pointer); }
    public void @FromMultiply3x3(CMatrix @matrix,CVector @vector) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D17 >(17)(Pointer,@matrix.Pointer,@vector.Pointer); }
    public CVector2D @To2D() { Game.CheckThread(); var result=NativeObject.AllocateStorage<CVector2D >(8); try { SdkBindings.Get<GeneratedDelegates.D18 >(18)(Pointer,result.Pointer); return result; } catch { result.Dispose(); throw; } }
    public bool @Operator_operator__(CVector @other) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D19 >(19)(Pointer,@other.Pointer); return __sdkResult != 0; }
    public bool @Operator_operator____a1b86427(CVector @other) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D20 >(20)(Pointer,@other.Pointer); return __sdkResult != 0; }
    public CVector @SubtractNative() { Game.CheckThread(); var result=NativeObject.AllocateStorage<CVector >(12); try { SdkBindings.Get<GeneratedDelegates.D21 >(21)(Pointer,result.Pointer); return result; } catch { result.Dispose(); throw; } }
    public float @Distance(CVector @other) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D22 >(22)(Pointer,@other.Pointer); return __sdkResult; }
    public float @Distance2D(CVector @other) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D23 >(23)(Pointer,@other.Pointer); return __sdkResult; }
    public float @Distance2D(CVector2D @other) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D24 >(24)(Pointer,@other.Pointer); return __sdkResult; }
    public float @Dot(CVector @other) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D25 >(25)(Pointer,@other.Pointer); return __sdkResult; }
    public CVector @Cross(CVector @other) { Game.CheckThread(); var result=NativeObject.AllocateStorage<CVector >(12); try { SdkBindings.Get<GeneratedDelegates.D26 >(26)(Pointer,@other.Pointer,result.Pointer); return result; } catch { result.Dispose(); throw; } }
    public float @Heading() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D27 >(27)(Pointer); return __sdkResult; }
    public float @Magnitude() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D28 >(28)(Pointer); return __sdkResult; }
    public float @MagnitudeSqr() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D29 >(29)(Pointer); return __sdkResult; }
    public float @Magnitude2D() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D30 >(30)(Pointer); return __sdkResult; }
    public float @MagnitudeSqr2D() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D31 >(31)(Pointer); return __sdkResult; }
    public CVector @Normalized() { Game.CheckThread(); var result=NativeObject.AllocateStorage<CVector >(12); try { SdkBindings.Get<GeneratedDelegates.D32 >(32)(Pointer,result.Pointer); return result; } catch { result.Dispose(); throw; } }
    public bool @IsNormalized() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D33 >(33)(Pointer); return __sdkResult != 0; }
    public bool @IsZero() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D34 >(34)(Pointer); return __sdkResult != 0; }
    public void @AddAssignNative(float @value) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D35 >(35)(Pointer,@value); }
    public void @AddAssignNative(CVector @other) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D36 >(36)(Pointer,@other.Pointer); }
    public void @SubtractAssignNative(float @value) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D37 >(37)(Pointer,@value); }
    public void @SubtractAssignNative(CVector @other) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D38 >(38)(Pointer,@other.Pointer); }
    public void @MultiplyAssignNative(float @multiplier) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D39 >(39)(Pointer,@multiplier); }
    public void @DivideAssignNative(float @divisor) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D40 >(40)(Pointer,@divisor); }
    public void @Normalize() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D41 >(41)(Pointer); }
    public float @NormalizeAndMag() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D42 >(42)(Pointer); return __sdkResult; }
    public static CVector @Sum(CVector @left,CVector @right) { Game.CheckThread(); var result=NativeObject.AllocateStorage<CVector >(12); try { SdkBindings.Get<GeneratedDelegates.D43 >(43)(@left.Pointer,@right.Pointer,result.Pointer); return result; } catch { result.Dispose(); throw; } }
    public static CVector @Diff(CVector @left,CVector @right) { Game.CheckThread(); var result=NativeObject.AllocateStorage<CVector >(12); try { SdkBindings.Get<GeneratedDelegates.D44 >(44)(@left.Pointer,@right.Pointer,result.Pointer); return result; } catch { result.Dispose(); throw; } }
    public static float @Distance(CVector @left,CVector @right) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D45 >(45)(@left.Pointer,@right.Pointer); return __sdkResult; }
    public static float @Distance2D(CVector @left,CVector @right) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D46 >(46)(@left.Pointer,@right.Pointer); return __sdkResult; }
    public static float @Distance2D(CVector @left,CVector2D @right) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D47 >(47)(@left.Pointer,@right.Pointer); return __sdkResult; }
    public static CVector @Lerp(CVector @begin,CVector @end,float @progress) { Game.CheckThread(); var result=NativeObject.AllocateStorage<CVector >(12); try { SdkBindings.Get<GeneratedDelegates.D48 >(48)(@begin.Pointer,@end.Pointer,@progress,result.Pointer); return result; } catch { result.Dispose(); throw; } }
    public static float @Dot(CVector @left,CVector @right) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D49 >(49)(@left.Pointer,@right.Pointer); return __sdkResult; }
    public static CVector @Cross(CVector @left,CVector @right) { Game.CheckThread(); var result=NativeObject.AllocateStorage<CVector >(12); try { SdkBindings.Get<GeneratedDelegates.D50 >(50)(@left.Pointer,@right.Pointer,result.Pointer); return result; } catch { result.Dispose(); throw; } }
    public static CVector @Multiply(CMatrix @matrix,CVector @point) { Game.CheckThread(); var result=NativeObject.AllocateStorage<CVector >(12); try { SdkBindings.Get<GeneratedDelegates.D51 >(51)(@matrix.Pointer,@point.Pointer,result.Pointer); return result; } catch { result.Dispose(); throw; } }
    public static CVector @Multiply3x3(CMatrix @matrix,CVector @vector) { Game.CheckThread(); var result=NativeObject.AllocateStorage<CVector >(12); try { SdkBindings.Get<GeneratedDelegates.D52 >(52)(@matrix.Pointer,@vector.Pointer,result.Pointer); return result; } catch { result.Dispose(); throw; } }
}
