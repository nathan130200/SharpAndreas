// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CAnimBlendAssociation : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=60;
    public CAnimBlendAssociation(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("vtable")]
    public NativePointer<IntPtr> @Vtable { get => new NativePointer<IntPtr>(SdkMemory.Read<IntPtr>(Pointer+0)); set { SdkMemory.Write(Pointer+0,value.Pointer); } }
    [NativeMember("m_link")]
    public RwLLLink @Link { get => new RwLLLink(Pointer+4); set { SdkMemory.Copy(value.Pointer,Pointer+4,8); } }
    [NativeMember("m_nNumBlendNodes")]
    public ushort @CountBlendNodes { get => SdkMemory.Read<ushort >(Pointer+12); set { SdkMemory.Write(Pointer+12,value); } }
    [NativeMember("m_nAnimGroup")]
    public ushort @AnimationGroup { get => SdkMemory.Read<ushort >(Pointer+14); set { SdkMemory.Write(Pointer+14,value); } }
    [NativeMember("m_pNodeArray")]
    public CAnimBlendNode? @NodeArray { get => SdkMemory.Read<IntPtr>(Pointer+16) == IntPtr.Zero ? null : new CAnimBlendNode(SdkMemory.Read<IntPtr>(Pointer+16)); set { SdkMemory.Write(Pointer+16,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_pHierarchy")]
    public CAnimBlendHierarchy? @Hierarchy { get => SdkMemory.Read<IntPtr>(Pointer+20) == IntPtr.Zero ? null : new CAnimBlendHierarchy(SdkMemory.Read<IntPtr>(Pointer+20)); set { SdkMemory.Write(Pointer+20,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_fBlendAmount")]
    public float @BlendAmount { get => SdkMemory.Read<float >(Pointer+24); set { SdkMemory.Write(Pointer+24,value); } }
    [NativeMember("m_fBlendDelta")]
    public float @BlendDelta { get => SdkMemory.Read<float >(Pointer+28); set { SdkMemory.Write(Pointer+28,value); } }
    [NativeMember("m_fCurrentTime")]
    public float @CurrentTime { get => SdkMemory.Read<float >(Pointer+32); set { SdkMemory.Write(Pointer+32,value); } }
    [NativeMember("m_fSpeed")]
    public float @Speed { get => SdkMemory.Read<float >(Pointer+36); set { SdkMemory.Write(Pointer+36,value); } }
    [NativeMember("fTimeStep")]
    public float @TimeStep { get => SdkMemory.Read<float >(Pointer+40); set { SdkMemory.Write(Pointer+40,value); } }
    [NativeMember("m_nAnimId")]
    public short @AnimationId { get => SdkMemory.Read<short >(Pointer+44); set { SdkMemory.Write(Pointer+44,value); } }
    [NativeMember("m_nCallbackType")]
    public eAnimBlendCallbackType @CallbackType { get => SdkMemory.Read<eAnimBlendCallbackType >(Pointer+48); set { SdkMemory.Write(Pointer+48,value); } }
    [NativeMember("m_pCallbackFunc")]
    public NativeFunctionPointer<Callback_800a1c9306b9> @CallbackFunc { get => new NativeFunctionPointer<Callback_800a1c9306b9>(SdkMemory.Read<IntPtr>(Pointer+52)); set { SdkMemory.Write(Pointer+52,value.Pointer); } }
    [NativeMember("m_pCallbackData")]
    public NativePointer<IntPtr> @CallbackData { get => new NativePointer<IntPtr>(SdkMemory.Read<IntPtr>(Pointer+56)); set { SdkMemory.Write(Pointer+56,value.Pointer); } }
    public void @DestroyNative() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D591 >(591)(Pointer); }
    public void @AllocateAnimBlendNodeArray(int @count) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D592 >(592)(Pointer,@count); }
    public void @FreeAnimBlendNodeArray() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D593 >(593)(Pointer); }
    public CAnimBlendNode? @GetNode(int @nodeIndex) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D594 >(594)(Pointer,@nodeIndex); return __sdkResult == IntPtr.Zero ? null : new CAnimBlendNode(__sdkResult); }
    public void @Init(RpClump? @clump,CAnimBlendHierarchy? @hierarchy) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D595 >(595)(Pointer,@clump?.Pointer ?? IntPtr.Zero,@hierarchy?.Pointer ?? IntPtr.Zero); }
    public void @Init(CAnimBlendAssociation @source) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D596 >(596)(Pointer,@source.Pointer); }
    public void @Init(CAnimBlendStaticAssociation @source) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D597 >(597)(Pointer,@source.Pointer); }
    public void @ReferenceAnimBlock() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D598 >(598)(Pointer); }
    public void @SetBlend(float @blendAmount,float @blendDelta) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D599 >(599)(Pointer,@blendAmount,@blendDelta); }
    public void @SetBlendTo(float @blendAmount,float @blendDelta) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D600 >(600)(Pointer,@blendAmount,@blendDelta); }
    public void @SetCurrentTime(float @currentTime) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D601 >(601)(Pointer,@currentTime); }
    public void @SetDeleteCallback(NativeFunctionPointer<Callback_800a1c9306b9> @callback,NativePointer<IntPtr> @data) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D602 >(602)(Pointer,@callback.Pointer,@data.Pointer); }
    public void @SetFinishCallback(NativeFunctionPointer<Callback_800a1c9306b9> @callback,NativePointer<IntPtr> @data) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D603 >(603)(Pointer,@callback.Pointer,@data.Pointer); }
    public void @Start(float @currentTime) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D604 >(604)(Pointer,@currentTime); }
    public void @SyncAnimation(CAnimBlendAssociation? @syncWith) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D605 >(605)(Pointer,@syncWith?.Pointer ?? IntPtr.Zero); }
    public bool @UpdateBlend(float @blendDeltaMult) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D606 >(606)(Pointer,@blendDeltaMult); return __sdkResult != 0; }
    public bool @UpdateTime(float @unused1,float @unused2) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D607 >(607)(Pointer,@unused1,@unused2); return __sdkResult != 0; }
    public void @UpdateTimeStep(float @speedMult,float @timeMult) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D608 >(608)(Pointer,@speedMult,@timeMult); }
}
