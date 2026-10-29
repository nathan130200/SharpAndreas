// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CMatrix : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=72;
    public CMatrix(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("right")]
    public CVector @Right { get => new CVector(Pointer+0); set { SdkMemory.Copy(value.Pointer,Pointer+0,12); } }
    [NativeMember("flags")]
    public uint @Flags { get => SdkMemory.Read<uint >(Pointer+12); set { SdkMemory.Write(Pointer+12,value); } }
    [NativeMember("up")]
    public CVector @Up { get => new CVector(Pointer+16); set { SdkMemory.Copy(value.Pointer,Pointer+16,12); } }
    [NativeMember("pad1")]
    public uint @Pad1 { get => SdkMemory.Read<uint >(Pointer+28); set { SdkMemory.Write(Pointer+28,value); } }
    [NativeMember("at")]
    public CVector @At { get => new CVector(Pointer+32); set { SdkMemory.Copy(value.Pointer,Pointer+32,12); } }
    [NativeMember("pad2")]
    public uint @Pad2 { get => SdkMemory.Read<uint >(Pointer+44); set { SdkMemory.Write(Pointer+44,value); } }
    [NativeMember("pos")]
    public CVector @Position { get => new CVector(Pointer+48); set { SdkMemory.Copy(value.Pointer,Pointer+48,12); } }
    [NativeMember("pad3")]
    public uint @Pad3 { get => SdkMemory.Read<uint >(Pointer+60); set { SdkMemory.Write(Pointer+60,value); } }
    [NativeMember("m_pAttachMatrix")]
    public RwMatrixTag? @AttachMatrix { get => SdkMemory.Read<IntPtr>(Pointer+64) == IntPtr.Zero ? null : new RwMatrixTag(SdkMemory.Read<IntPtr>(Pointer+64)); set { SdkMemory.Write(Pointer+64,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_bOwnsAttachedMatrix")]
    public bool @OwnsAttachedMatrix { get => SdkMemory.Read<bool >(Pointer+68); set { SdkMemory.Write(Pointer+68,value); } }
    public void @InitializeAt() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D140 >(140)(Pointer); }
    public void @InitializeAt(CMatrix @matrix) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D141 >(141)(Pointer,@matrix.Pointer); }
    public void @InitializeAt(RwMatrixTag? @matrix,bool @temporary) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D142 >(142)(Pointer,@matrix?.Pointer ?? IntPtr.Zero,(@temporary ? 1 : 0)); }
    public void @DestroyNative() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D143 >(143)(Pointer); }
    public void @Attach(RwMatrixTag? @matrix,bool @temporary) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D144 >(144)(Pointer,@matrix?.Pointer ?? IntPtr.Zero,(@temporary ? 1 : 0)); }
    public void @Detach() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D145 >(145)(Pointer); }
    public void @CopyOnlyMatrix(CMatrix @matrix) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D146 >(146)(Pointer,@matrix.Pointer); }
    public void @Update() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D147 >(147)(Pointer); }
    public void @UpdateRW() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D148 >(148)(Pointer); }
    public void @UpdateRW(RwMatrixTag? @matrix) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D149 >(149)(Pointer,@matrix?.Pointer ?? IntPtr.Zero); }
    public void @SetUnity() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D150 >(150)(Pointer); }
    public void @ResetOrientation() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D151 >(151)(Pointer); }
    public void @SetScale(float @scale) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D152 >(152)(Pointer,@scale); }
    public void @SetScale(float @x,float @y,float @z) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D153 >(153)(Pointer,@x,@y,@z); }
    public void @SetTranslateOnly(float @x,float @y,float @z) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D154 >(154)(Pointer,@x,@y,@z); }
    public void @SetTranslate(float @x,float @y,float @z) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D155 >(155)(Pointer,@x,@y,@z); }
    public void @SetRotateXOnly(float @angle) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D156 >(156)(Pointer,@angle); }
    public void @SetRotateYOnly(float @angle) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D157 >(157)(Pointer,@angle); }
    public void @SetRotateZOnly(float @angle) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D158 >(158)(Pointer,@angle); }
    public void @SetRotateX(float @angle) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D159 >(159)(Pointer,@angle); }
    public void @SetRotateY(float @angle) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D160 >(160)(Pointer,@angle); }
    public void @SetRotateZ(float @angle) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D161 >(161)(Pointer,@angle); }
    public void @SetRotate(float @x,float @y,float @z) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D162 >(162)(Pointer,@x,@y,@z); }
    public void @RotateX(float @angle) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D163 >(163)(Pointer,@angle); }
    public void @RotateY(float @angle) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D164 >(164)(Pointer,@angle); }
    public void @RotateZ(float @angle) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D165 >(165)(Pointer,@angle); }
    public void @Rotate(float @x,float @y,float @z) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D166 >(166)(Pointer,@x,@y,@z); }
    public void @Translate(float @x,float @y,float @z) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D167 >(167)(Pointer,@x,@y,@z); }
    public void @Reorthogonalise() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D168 >(168)(Pointer); }
    public void @CopyToRwMatrix(RwMatrixTag? @matrix) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D169 >(169)(Pointer,@matrix?.Pointer ?? IntPtr.Zero); }
    public void @SetRotate(CQuaternion @quat) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D170 >(170)(Pointer,@quat.Pointer); }
    public void @Scale(float @scale) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D171 >(171)(Pointer,@scale); }
    public void @Scale(float @x,float @y,float @z) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D172 >(172)(Pointer,@x,@y,@z); }
    public void @AssignNative(CMatrix @rvalue) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D173 >(173)(Pointer,@rvalue.Pointer); }
    public void @AddAssignNative(CMatrix @rvalue) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D174 >(174)(Pointer,@rvalue.Pointer); }
    public void @MultiplyAssignNative(CMatrix @rvalue) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D175 >(175)(Pointer,@rvalue.Pointer); }
    public CVector @GetRight() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D176 >(176)(Pointer); return new CVector(__sdkResult); }
    public CVector @GetRight__43e39d01() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D177 >(177)(Pointer); return new CVector(__sdkResult); }
    public CVector @GetForward() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D178 >(178)(Pointer); return new CVector(__sdkResult); }
    public CVector @GetForward__d4fa0be7() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D179 >(179)(Pointer); return new CVector(__sdkResult); }
    public CVector @GetUp() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D180 >(180)(Pointer); return new CVector(__sdkResult); }
    public CVector @GetUp__49f229ec() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D181 >(181)(Pointer); return new CVector(__sdkResult); }
    public CVector @GetPosition() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D182 >(182)(Pointer); return new CVector(__sdkResult); }
    public CVector @GetPosition__6f181df3() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D183 >(183)(Pointer); return new CVector(__sdkResult); }
}
