// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class RwDevice : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=56;
    public RwDevice(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("gammaCorrection")]
    public float @GammaCorrection { get => SdkMemory.Read<float >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("fpSystem")]
    public NativeFunctionPointer<Callback_21f1a0ad86e2> @FpSystem { get => new NativeFunctionPointer<Callback_21f1a0ad86e2>(SdkMemory.Read<IntPtr>(Pointer+4)); set { SdkMemory.Write(Pointer+4,value.Pointer); } }
    [NativeMember("zBufferNear")]
    public float @ZBufferNear { get => SdkMemory.Read<float >(Pointer+8); set { SdkMemory.Write(Pointer+8,value); } }
    [NativeMember("zBufferFar")]
    public float @ZBufferFar { get => SdkMemory.Read<float >(Pointer+12); set { SdkMemory.Write(Pointer+12,value); } }
    [NativeMember("fpRenderStateSet")]
    public NativeFunctionPointer<Callback_a037ab43a2f3> @FpRenderStateSet { get => new NativeFunctionPointer<Callback_a037ab43a2f3>(SdkMemory.Read<IntPtr>(Pointer+16)); set { SdkMemory.Write(Pointer+16,value.Pointer); } }
    [NativeMember("fpRenderStateGet")]
    public NativeFunctionPointer<Callback_a037ab43a2f3> @FpRenderStateGet { get => new NativeFunctionPointer<Callback_a037ab43a2f3>(SdkMemory.Read<IntPtr>(Pointer+20)); set { SdkMemory.Write(Pointer+20,value.Pointer); } }
    [NativeMember("fpIm2DRenderLine")]
    public NativeFunctionPointer<Callback_c3e5d708fa34> @FpIm2DRenderLine { get => new NativeFunctionPointer<Callback_c3e5d708fa34>(SdkMemory.Read<IntPtr>(Pointer+24)); set { SdkMemory.Write(Pointer+24,value.Pointer); } }
    [NativeMember("fpIm2DRenderTriangle")]
    public NativeFunctionPointer<Callback_c7ac7ba29e6d> @FpIm2DRenderTriangle { get => new NativeFunctionPointer<Callback_c7ac7ba29e6d>(SdkMemory.Read<IntPtr>(Pointer+28)); set { SdkMemory.Write(Pointer+28,value.Pointer); } }
    [NativeMember("fpIm2DRenderPrimitive")]
    public NativeFunctionPointer<Callback_38a24e730cc3> @FpIm2DRenderPrimitive { get => new NativeFunctionPointer<Callback_38a24e730cc3>(SdkMemory.Read<IntPtr>(Pointer+32)); set { SdkMemory.Write(Pointer+32,value.Pointer); } }
    [NativeMember("fpIm2DRenderIndexedPrimitive")]
    public NativeFunctionPointer<Callback_f14435496212> @FpIm2DRenderIndexedPrimitive { get => new NativeFunctionPointer<Callback_f14435496212>(SdkMemory.Read<IntPtr>(Pointer+36)); set { SdkMemory.Write(Pointer+36,value.Pointer); } }
    [NativeMember("fpIm3DRenderLine")]
    public NativeFunctionPointer<Callback_1d716d0e326b> @FpIm3DRenderLine { get => new NativeFunctionPointer<Callback_1d716d0e326b>(SdkMemory.Read<IntPtr>(Pointer+40)); set { SdkMemory.Write(Pointer+40,value.Pointer); } }
    [NativeMember("fpIm3DRenderTriangle")]
    public NativeFunctionPointer<Callback_bfb5e72c8a95> @FpIm3DRenderTriangle { get => new NativeFunctionPointer<Callback_bfb5e72c8a95>(SdkMemory.Read<IntPtr>(Pointer+44)); set { SdkMemory.Write(Pointer+44,value.Pointer); } }
    [NativeMember("fpIm3DRenderPrimitive")]
    public NativeFunctionPointer<Callback_ac860136500f> @FpIm3DRenderPrimitive { get => new NativeFunctionPointer<Callback_ac860136500f>(SdkMemory.Read<IntPtr>(Pointer+48)); set { SdkMemory.Write(Pointer+48,value.Pointer); } }
    [NativeMember("fpIm3DRenderIndexedPrimitive")]
    public NativeFunctionPointer<Callback_b0f0db4488ea> @FpIm3DRenderIndexedPrimitive { get => new NativeFunctionPointer<Callback_b0f0db4488ea>(SdkMemory.Read<IntPtr>(Pointer+52)); set { SdkMemory.Write(Pointer+52,value.Pointer); } }
}
