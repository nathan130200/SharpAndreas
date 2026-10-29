// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CAnimBlendClumpData : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=20;
    public CAnimBlendClumpData(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_associationsList")]
    public RwLinkList @AssociationsList { get => new RwLinkList(Pointer+0); set { SdkMemory.Copy(value.Pointer,Pointer+0,8); } }
    [NativeMember("m_nNumFrames")]
    public int @CountFrames { get => SdkMemory.Read<int >(Pointer+8); set { SdkMemory.Write(Pointer+8,value); } }
    [NativeMember("m_pvecPedPosition")]
    public CVector? @PvecPedPosition { get => SdkMemory.Read<IntPtr>(Pointer+12) == IntPtr.Zero ? null : new CVector(SdkMemory.Read<IntPtr>(Pointer+12)); set { SdkMemory.Write(Pointer+12,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_pFrames")]
    public AnimBlendFrameData? @Frames { get => SdkMemory.Read<IntPtr>(Pointer+16) == IntPtr.Zero ? null : new AnimBlendFrameData(SdkMemory.Read<IntPtr>(Pointer+16)); set { SdkMemory.Write(Pointer+16,value?.Pointer ?? IntPtr.Zero); } }
    public void @InitializeAt() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D621 >(621)(Pointer); }
    public void @DestroyNative() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D622 >(622)(Pointer); }
    public void @ForAllFrames(NativeFunctionPointer<Callback_c81b88467b2d> @callback,NativePointer<IntPtr> @data) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D623 >(623)(Pointer,@callback.Pointer,@data.Pointer); }
    public void @ForAllFramesInSPR(NativeFunctionPointer<Callback_c81b88467b2d> @callback,NativePointer<IntPtr> @data,uint @a3) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D624 >(624)(Pointer,@callback.Pointer,@data.Pointer,@a3); }
    public void @LoadFramesIntoSPR() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D625 >(625)(Pointer); }
    public void @SetNumberOfBones(int @numBones) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D626 >(626)(Pointer,@numBones); }
}
