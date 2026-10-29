// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class FxSystem_c : ListItem_c
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=260;
    public FxSystem_c(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_pBlueprint")]
    public NativePointer<IntPtr> @Blueprint { get => new NativePointer<IntPtr>(SdkMemory.Read<IntPtr>(Pointer+8)); set { SdkMemory.Write(Pointer+8,value.Pointer); } }
    [NativeMember("m_pParentMatrix")]
    public RwMatrixTag? @ParentMatrix { get => SdkMemory.Read<IntPtr>(Pointer+12) == IntPtr.Zero ? null : new RwMatrixTag(SdkMemory.Read<IntPtr>(Pointer+12)); set { SdkMemory.Write(Pointer+12,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_localMatrix")]
    public RwMatrixTag @LocalMatrix { get => new RwMatrixTag(Pointer+16); set { SdkMemory.Copy(value.Pointer,Pointer+16,64); } }
    [NativeMember("m_nPlayStatus")]
    public byte @PlayStatus { get => SdkMemory.Read<byte >(Pointer+80); set { SdkMemory.Write(Pointer+80,value); } }
    [NativeMember("m_nKillStatus")]
    public byte @KillStatus { get => SdkMemory.Read<byte >(Pointer+81); set { SdkMemory.Write(Pointer+81,value); } }
    [NativeMember("m_bConstTimeSet")]
    public byte @ConstTimeSet { get => SdkMemory.Read<byte >(Pointer+82); set { SdkMemory.Write(Pointer+82,value); } }
    [NativeMember("field_53")]
    public sbyte @Field53 { get => SdkMemory.Read<sbyte >(Pointer+83); set { SdkMemory.Write(Pointer+83,value); } }
    [NativeMember("field_54")]
    public int @Field54 { get => SdkMemory.Read<int >(Pointer+84); set { SdkMemory.Write(Pointer+84,value); } }
    [NativeMember("m_fCameraDistance")]
    public float @CameraDistance { get => SdkMemory.Read<float >(Pointer+88); set { SdkMemory.Write(Pointer+88,value); } }
    [NativeMember("m_nConstTime")]
    public ushort @ConstTime { get => SdkMemory.Read<ushort >(Pointer+92); set { SdkMemory.Write(Pointer+92,value); } }
    [NativeMember("m_nRateMult")]
    public ushort @RateMult { get => SdkMemory.Read<ushort >(Pointer+94); set { SdkMemory.Write(Pointer+94,value); } }
    [NativeMember("m_nTimeMult")]
    public ushort @TimeMult { get => SdkMemory.Read<ushort >(Pointer+96); set { SdkMemory.Write(Pointer+96,value); } }
    [NativeMember("m_nFlags")]
    public FxSystem_c___unnamed__at_D__plugin_sdk_plugin_sa_game_sa_FxSystem_c_h__a2c932bb3a @Flags { get => new FxSystem_c___unnamed__at_D__plugin_sdk_plugin_sa_game_sa_FxSystem_c_h__a2c932bb3a(Pointer+98); set { SdkMemory.Copy(value.Pointer,Pointer+98,1); } }
    [NativeMember("field_63")]
    public sbyte @Field63 { get => SdkMemory.Read<sbyte >(Pointer+99); set { SdkMemory.Write(Pointer+99,value); } }
    [NativeMember("fUnkRandom")]
    public float @UnkRandom { get => SdkMemory.Read<float >(Pointer+100); set { SdkMemory.Write(Pointer+100,value); } }
    [NativeMember("m_vecVelAdd")]
    public CVector @VelocityAdd { get => new CVector(Pointer+104); set { SdkMemory.Copy(value.Pointer,Pointer+104,12); } }
    [NativeMember("m_pBounding")]
    public NativePointer<IntPtr> @Bounding { get => new NativePointer<IntPtr>(SdkMemory.Read<IntPtr>(Pointer+116)); set { SdkMemory.Write(Pointer+116,value.Pointer); } }
    [NativeMember("m_pPrimsPtrList")]
    public NativePointer<IntPtr> @PrimsPointerList { get => new NativePointer<IntPtr>(SdkMemory.Read<IntPtr>(Pointer+120)); set { SdkMemory.Write(Pointer+120,value.Pointer); } }
    [NativeMember("m_fireAudio")]
    public NativeArray<sbyte> @FireAudio { get => new NativeArray<sbyte>(Pointer+124,136); }
    public CAEFireAudioEntity? @GetFireAudio() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D811 >(811)(Pointer); return __sdkResult == IntPtr.Zero ? null : new CAEFireAudioEntity(__sdkResult); }
    public void @InitializeAt() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D812 >(812)(Pointer); }
    public void @DestroyNative() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D813 >(813)(Pointer); }
    public void @Play() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D814 >(814)(Pointer); }
    public void @Pause() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D815 >(815)(Pointer); }
    public void @Stop() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D816 >(816)(Pointer); }
    public void @PlayAndKill() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D817 >(817)(Pointer); }
    public void @Kill() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D818 >(818)(Pointer); }
    public void @AttachToBone(CEntity? @entity,int @boneId) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D819 >(819)(Pointer,@entity?.Pointer ?? IntPtr.Zero,@boneId); }
    public void @AddParticle(RwV3d? @position,RwV3d? @velocity,float @arg2,FxPrtMult_c? @prtMult,float @arg4,float @brightness,float @arg6,byte @arg7) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D820 >(820)(Pointer,@position?.Pointer ?? IntPtr.Zero,@velocity?.Pointer ?? IntPtr.Zero,@arg2,@prtMult?.Pointer ?? IntPtr.Zero,@arg4,@brightness,@arg6,@arg7); }
    public void @AddParticle(RwMatrixTag? @transform,RwV3d? @position,float @arg2,FxPrtMult_c? @prtMult,float @arg4,float @arg5,float @arg6,byte @arg7) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D821 >(821)(Pointer,@transform?.Pointer ?? IntPtr.Zero,@position?.Pointer ?? IntPtr.Zero,@arg2,@prtMult?.Pointer ?? IntPtr.Zero,@arg4,@arg5,@arg6,@arg7); }
    public void @EnablePrim(int @primIndex,byte @enable) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D822 >(822)(Pointer,@primIndex,@enable); }
    public void @SetMatrix(RwMatrixTag? @matrix) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D823 >(823)(Pointer,@matrix?.Pointer ?? IntPtr.Zero); }
    public void @SetOffsetPos(RwV3d? @pos) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D824 >(824)(Pointer,@pos?.Pointer ?? IntPtr.Zero); }
    public void @AddOffsetPos(RwV3d? @pos) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D825 >(825)(Pointer,@pos?.Pointer ?? IntPtr.Zero); }
    public void @SetConstTime(byte @arg0,float @amount) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D826 >(826)(Pointer,@arg0,@amount); }
    public void @SetRateMult(float @mult) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D827 >(827)(Pointer,@mult); }
    public void @SetTimeMult(float @mult) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D828 >(828)(Pointer,@mult); }
    public void @SetVelAdd(RwV3d? @velAdd) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D829 >(829)(Pointer,@velAdd?.Pointer ?? IntPtr.Zero); }
    public bool @Init(FxSystemBP_c? @arg0,RwMatrixTag? @local,RwMatrixTag? @parent) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D830 >(830)(Pointer,@arg0?.Pointer ?? IntPtr.Zero,@local?.Pointer ?? IntPtr.Zero,@parent?.Pointer ?? IntPtr.Zero); return __sdkResult != 0; }
    public void @Exit() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D831 >(831)(Pointer); }
    public void @CopyParentMatrix() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D832 >(832)(Pointer); }
    public void @GetCompositeMatrix(RwMatrixTag? @out) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D833 >(833)(Pointer,@out?.Pointer ?? IntPtr.Zero); }
    public void @GetPlayStatus() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D834 >(834)(Pointer); }
    public void @SetLocalParticles(byte @enable) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D835 >(835)(Pointer,@enable); }
    public uint @ForAllParticles(NativeFunctionPointer<Callback_d641f6c044f5> @callback,NativePointer<IntPtr> @data) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D836 >(836)(Pointer,@callback.Pointer,@data.Pointer); return __sdkResult; }
    public static void @UpdateBoundingBoxCB(Particle_c? @particle,int @arg1,NativePointer<IntPtr> @data) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D837 >(837)(@particle?.Pointer ?? IntPtr.Zero,@arg1,@data.Pointer); }
    public void @GetBoundingBox(FxBox_c? @out) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D838 >(838)(Pointer,@out?.Pointer ?? IntPtr.Zero); }
    public bool @GetBoundingSphereWld(FxSphere_c? @out) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D839 >(839)(Pointer,@out?.Pointer ?? IntPtr.Zero); return __sdkResult != 0; }
    public bool @GetBoundingSphereLcl(FxSphere_c? @out) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D840 >(840)(Pointer,@out?.Pointer ?? IntPtr.Zero); return __sdkResult != 0; }
    public void @SetBoundingSphere(FxSphere_c? @bound) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D841 >(841)(Pointer,@bound?.Pointer ?? IntPtr.Zero); }
    public void @ResetBoundingSphere() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D842 >(842)(Pointer); }
    public void @SetZTestEnable(byte @enable) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D843 >(843)(Pointer,@enable); }
    public void @SetMustCreatePrts(byte @enable) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D844 >(844)(Pointer,@enable); }
    public void @DoFxAudio(CVector @posn) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D845 >(845)(Pointer,@posn.Pointer); }
    public bool @IsVisible() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D846 >(846)(Pointer); return __sdkResult != 0; }
    public bool @Update(RwCamera? @camera,float @timeDelta) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D847 >(847)(Pointer,@camera?.Pointer ?? IntPtr.Zero,@timeDelta); return __sdkResult != 0; }
}
