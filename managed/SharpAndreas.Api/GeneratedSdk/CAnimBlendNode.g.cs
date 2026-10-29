// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CAnimBlendNode : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=24;
    public CAnimBlendNode(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("field_0")]
    public float @Field0 { get => SdkMemory.Read<float >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("field_4")]
    public float @Field4 { get => SdkMemory.Read<float >(Pointer+4); set { SdkMemory.Write(Pointer+4,value); } }
    [NativeMember("field_8")]
    public short @Field8 { get => SdkMemory.Read<short >(Pointer+8); set { SdkMemory.Write(Pointer+8,value); } }
    [NativeMember("field_A")]
    public short @FieldA { get => SdkMemory.Read<short >(Pointer+10); set { SdkMemory.Write(Pointer+10,value); } }
    [NativeMember("field_C")]
    public float @FieldC { get => SdkMemory.Read<float >(Pointer+12); set { SdkMemory.Write(Pointer+12,value); } }
    [NativeMember("field_10")]
    public int @Field10 { get => SdkMemory.Read<int >(Pointer+16); set { SdkMemory.Write(Pointer+16,value); } }
    [NativeMember("m_pAnimBlendAssociation")]
    public NativePointer<IntPtr> @AnimationBlendAssociation { get => new NativePointer<IntPtr>(SdkMemory.Read<IntPtr>(Pointer+20)); set { SdkMemory.Write(Pointer+20,value.Pointer); } }
    public void @CalcDeltas() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D648 >(648)(Pointer); }
    public void @CalcDeltasCompressed() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D649 >(649)(Pointer); }
    public bool @FindKeyFrame(float @arg1) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D650 >(650)(Pointer,@arg1); return __sdkResult != 0; }
    public void @GetCurrentTranslation(CVector @Vector,float @arg2) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D651 >(651)(Pointer,@Vector.Pointer,@arg2); }
    public void @GetCurrentTranslationCompressed(CVector @Vector,float @arg2) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D652 >(652)(Pointer,@Vector.Pointer,@arg2); }
    public void @GetEndTranslation(CVector @Vector,float @arg2) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D653 >(653)(Pointer,@Vector.Pointer,@arg2); }
    public void @GetEndTranslationCompressed(CVector @Vector,float @arg2) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D654 >(654)(Pointer,@Vector.Pointer,@arg2); }
    public void @Init() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D655 >(655)(Pointer); }
    public bool @NextKeyFrame() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D656 >(656)(Pointer); return __sdkResult != 0; }
    public bool @NextKeyFrameCompressed() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D657 >(657)(Pointer); return __sdkResult != 0; }
    public bool @NextKeyFrameNoCalc() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D658 >(658)(Pointer); return __sdkResult != 0; }
    public bool @SetupKeyFrameCompressed() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D659 >(659)(Pointer); return __sdkResult != 0; }
    public bool @Update(CVector @Vector,CQuaternion @Qauternion,float @arg3) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D660 >(660)(Pointer,@Vector.Pointer,@Qauternion.Pointer,@arg3); return __sdkResult != 0; }
    public bool @UpdateCompressed(CVector @Vector,CQuaternion @Quaternion,float @arg3) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D661 >(661)(Pointer,@Vector.Pointer,@Quaternion.Pointer,@arg3); return __sdkResult != 0; }
}
