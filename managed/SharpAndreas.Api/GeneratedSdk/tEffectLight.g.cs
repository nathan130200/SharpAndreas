// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class tEffectLight : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=48;
    public tEffectLight(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_color")]
    public RwRGBA @Color { get => new RwRGBA(Pointer+0); set { SdkMemory.Copy(value.Pointer,Pointer+0,4); } }
    [NativeMember("m_fCoronaFarClip")]
    public float @CoronaFarClip { get => SdkMemory.Read<float >(Pointer+4); set { SdkMemory.Write(Pointer+4,value); } }
    [NativeMember("m_fPointlightRange")]
    public float @PointlightRange { get => SdkMemory.Read<float >(Pointer+8); set { SdkMemory.Write(Pointer+8,value); } }
    [NativeMember("m_fCoronaSize")]
    public float @CoronaSize { get => SdkMemory.Read<float >(Pointer+12); set { SdkMemory.Write(Pointer+12,value); } }
    [NativeMember("m_fShadowSize")]
    public float @ShadowSize { get => SdkMemory.Read<float >(Pointer+16); set { SdkMemory.Write(Pointer+16,value); } }
    [NativeMember("m_nFlags")]
    public ushort @Flags { get => SdkMemory.Read<ushort >(Pointer+20); set { SdkMemory.Write(Pointer+20,value); } }
    [NativeMember("m_nCoronaFlashType")]
    public byte @CoronaFlashType { get => SdkMemory.Read<byte >(Pointer+22); set { SdkMemory.Write(Pointer+22,value); } }
    [NativeMember("m_bCoronaEnableReflection")]
    public bool @CoronaEnableReflection { get => SdkMemory.Read<bool >(Pointer+23); set { SdkMemory.Write(Pointer+23,value); } }
    [NativeMember("m_nCoronaFlareType")]
    public byte @CoronaFlareType { get => SdkMemory.Read<byte >(Pointer+24); set { SdkMemory.Write(Pointer+24,value); } }
    [NativeMember("m_nShadowColorMultiplier")]
    public byte @ShadowColorMultiplier { get => SdkMemory.Read<byte >(Pointer+25); set { SdkMemory.Write(Pointer+25,value); } }
    [NativeMember("m_nShadowZDistance")]
    public sbyte @ShadowZDistance { get => SdkMemory.Read<sbyte >(Pointer+26); set { SdkMemory.Write(Pointer+26,value); } }
    [NativeMember("offsetX")]
    public sbyte @OffsetX { get => SdkMemory.Read<sbyte >(Pointer+27); set { SdkMemory.Write(Pointer+27,value); } }
    [NativeMember("offsetY")]
    public sbyte @OffsetY { get => SdkMemory.Read<sbyte >(Pointer+28); set { SdkMemory.Write(Pointer+28,value); } }
    [NativeMember("offsetZ")]
    public sbyte @OffsetZ { get => SdkMemory.Read<sbyte >(Pointer+29); set { SdkMemory.Write(Pointer+29,value); } }
    [NativeMember("m_pCoronaTex")]
    public RwTexture? @CoronaTex { get => SdkMemory.Read<IntPtr>(Pointer+32) == IntPtr.Zero ? null : new RwTexture(SdkMemory.Read<IntPtr>(Pointer+32)); set { SdkMemory.Write(Pointer+32,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_pShadowTex")]
    public RwTexture? @ShadowTex { get => SdkMemory.Read<IntPtr>(Pointer+36) == IntPtr.Zero ? null : new RwTexture(SdkMemory.Read<IntPtr>(Pointer+36)); set { SdkMemory.Write(Pointer+36,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("field_38")]
    public int @Field38 { get => SdkMemory.Read<int >(Pointer+40); set { SdkMemory.Write(Pointer+40,value); } }
    [NativeMember("field_3C")]
    public int @Field3C { get => SdkMemory.Read<int >(Pointer+44); set { SdkMemory.Write(Pointer+44,value); } }
}
