// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CQuaternion : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=16;
    public CQuaternion(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("imag")]
    public CVector @Imag { get => new CVector(Pointer+0); set { SdkMemory.Copy(value.Pointer,Pointer+0,12); } }
    [NativeMember("real")]
    public float @Real { get => SdkMemory.Read<float >(Pointer+12); set { SdkMemory.Write(Pointer+12,value); } }
    public void @Get(RwMatrixTag? @out) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D121 >(121)(Pointer,@out?.Pointer ?? IntPtr.Zero); }
    public void @Get(NativePointer<float> @x,NativePointer<float> @y,NativePointer<float> @z) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D122 >(122)(Pointer,@x.Pointer,@y.Pointer,@z.Pointer); }
    public void @Get(RwV3d? @axis,NativePointer<float> @angle) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D123 >(123)(Pointer,@axis?.Pointer ?? IntPtr.Zero,@angle.Pointer); }
    public void @Multiply(CQuaternion @a,CQuaternion @b) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D124 >(124)(Pointer,@a.Pointer,@b.Pointer); }
    public void @Slerp(CQuaternion @from,CQuaternion @to,float @halftheta,float @sintheta_inv,float @t) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D125 >(125)(Pointer,@from.Pointer,@to.Pointer,@halftheta,@sintheta_inv,@t); }
    public void @Set(RwMatrixTag @m) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D126 >(126)(Pointer,@m.Pointer); }
    public void @Set(float @x,float @y,float @z) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D127 >(127)(Pointer,@x,@y,@z); }
    public void @Set(RwV3d? @axis,float @angle) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D128 >(128)(Pointer,@axis?.Pointer ?? IntPtr.Zero,@angle); }
    public void @Slerp(CQuaternion @from,CQuaternion @to,float @t) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D129 >(129)(Pointer,@from.Pointer,@to.Pointer,@t); }
    public void @Conjugate() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D130 >(130)(Pointer); }
    public float @GetLengthSquared() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D131 >(131)(Pointer); return __sdkResult; }
    public void @AddAssignNative(CQuaternion @right) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D132 >(132)(Pointer,@right.Pointer); }
    public void @SubtractAssignNative(CQuaternion @right) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D133 >(133)(Pointer,@right.Pointer); }
    public void @AssignNative(CQuaternion @right) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D134 >(134)(Pointer,@right.Pointer); }
    public void @MultiplyAssignNative(float @multiplier) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D135 >(135)(Pointer,@multiplier); }
    public void @Scale(float @multiplier) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D136 >(136)(Pointer,@multiplier); }
    public void @Copy(CQuaternion @from) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D137 >(137)(Pointer,@from.Pointer); }
    public void @Dot(CQuaternion @a) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D138 >(138)(Pointer,@a.Pointer); }
    public void @Normalise() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D139 >(139)(Pointer); }
}
