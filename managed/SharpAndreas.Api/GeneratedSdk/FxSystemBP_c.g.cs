// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class FxSystemBP_c : ListItem_c
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=36;
    public FxSystemBP_c(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_nNameKey")]
    public uint @NameKey { get => SdkMemory.Read<uint >(Pointer+8); set { SdkMemory.Write(Pointer+8,value); } }
    [NativeMember("m_fLength")]
    public float @Length { get => SdkMemory.Read<float >(Pointer+12); set { SdkMemory.Write(Pointer+12,value); } }
    [NativeMember("m_fLoopIntervalMin")]
    public float @LoopIntervalMin { get => SdkMemory.Read<float >(Pointer+16); set { SdkMemory.Write(Pointer+16,value); } }
    [NativeMember("m_fLoopLength")]
    public float @LoopLength { get => SdkMemory.Read<float >(Pointer+20); set { SdkMemory.Write(Pointer+20,value); } }
    [NativeMember("m_nCullDist")]
    public short @CullDistance { get => SdkMemory.Read<short >(Pointer+24); set { SdkMemory.Write(Pointer+24,value); } }
    [NativeMember("m_nPlayMode")]
    public byte @PlayMode { get => SdkMemory.Read<byte >(Pointer+26); set { SdkMemory.Write(Pointer+26,value); } }
    [NativeMember("m_nNumEmitters")]
    public byte @CountEmitters { get => SdkMemory.Read<byte >(Pointer+27); set { SdkMemory.Write(Pointer+27,value); } }
    [NativeMember("m_emittersList")]
    public NativePointer<IntPtr> @EmittersList { get => new NativePointer<IntPtr>(SdkMemory.Read<IntPtr>(Pointer+28)); set { SdkMemory.Write(Pointer+28,value.Pointer); } }
    [NativeMember("m_pBoundingSphere")]
    public FxSphere_c? @BoundingSphere { get => SdkMemory.Read<IntPtr>(Pointer+32) == IntPtr.Zero ? null : new FxSphere_c(SdkMemory.Read<IntPtr>(Pointer+32)); set { SdkMemory.Write(Pointer+32,value?.Pointer ?? IntPtr.Zero); } }
    public void @InitializeAt() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4527 >(4527)(Pointer); }
    public void @DestroyNative() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4528 >(4528)(Pointer); }
    public static NativePointer<IntPtr> @AllocateNative(uint @size) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4529 >(4529)(@size); return new NativePointer<IntPtr>(__sdkResult); }
    public void @Unload() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4530 >(4530)(Pointer); }
    public uint @Update(float @arg0) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4531 >(4531)(Pointer,@arg0); return __sdkResult; }
    public void @Render(RwCamera? @camera,float @arg1,byte @arg2) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4532 >(4532)(Pointer,@camera?.Pointer ?? IntPtr.Zero,@arg1,@arg2); }
    public bool @FreePrtFromSystem(FxSystem_c? @system) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4533 >(4533)(Pointer,@system?.Pointer ?? IntPtr.Zero); return __sdkResult != 0; }
    public FxSphere_c? @GetBoundingSphere() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4534 >(4534)(Pointer); return __sdkResult == IntPtr.Zero ? null : new FxSphere_c(__sdkResult); }
    public void @SetBoundingSphere(RwV3d? @center,float @radius) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4535 >(4535)(Pointer,@center?.Pointer ?? IntPtr.Zero,@radius); }
    public void @Load(NativePointer<sbyte> @filename,int @file,int @version) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4536 >(4536)(Pointer,@filename.Pointer,@file,@version); }
}
