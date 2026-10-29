// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class FxPrimBP_c : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=64;
    public FxPrimBP_c(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("field_4")]
    public sbyte @Field4 { get => SdkMemory.Read<sbyte >(Pointer+4); set { SdkMemory.Write(Pointer+4,value); } }
    [NativeMember("m_nSrcBlendId")]
    public byte @SrcBlendId { get => SdkMemory.Read<byte >(Pointer+5); set { SdkMemory.Write(Pointer+5,value); } }
    [NativeMember("m_nDstBlendId")]
    public byte @DstBlendId { get => SdkMemory.Read<byte >(Pointer+6); set { SdkMemory.Write(Pointer+6,value); } }
    [NativeMember("m_nAlphaOn")]
    public byte @AlphaOn { get => SdkMemory.Read<byte >(Pointer+7); set { SdkMemory.Write(Pointer+7,value); } }
    [NativeMember("m_pMatrixBuffered")]
    public NativePointer<IntPtr> @MatrixBuffered { get => new NativePointer<IntPtr>(SdkMemory.Read<IntPtr>(Pointer+8)); set { SdkMemory.Write(Pointer+8,value.Pointer); } }
    [NativeMember("m_apTextures")]
    public NativeArray<IntPtr> @Textures { get => new NativeArray<IntPtr>(Pointer+12,4); }
    [NativeMember("field_1C")]
    public int @Field1C { get => SdkMemory.Read<int >(Pointer+28); set { SdkMemory.Write(Pointer+28,value); } }
    [NativeMember("m_emitterPrts")]
    public List_c @EmitterPrts { get => new List_c(Pointer+32); set { SdkMemory.Copy(value.Pointer,Pointer+32,12); } }
    [NativeMember("m_fxInfoManager")]
    public FxInfoManager_c @FxInfoManager { get => new FxInfoManager_c(Pointer+44); set { SdkMemory.Copy(value.Pointer,Pointer+44,20); } }
    public void @DestroyNative() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4598 >(4598)(Pointer); }
}
