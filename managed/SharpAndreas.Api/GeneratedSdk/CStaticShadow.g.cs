// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CStaticShadow : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=64;
    public CStaticShadow(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_nId")]
    public uint @Id { get => SdkMemory.Read<uint >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("m_pPolyBunch")]
    public CPolyBunch? @PolyBunch { get => SdkMemory.Read<IntPtr>(Pointer+4) == IntPtr.Zero ? null : new CPolyBunch(SdkMemory.Read<IntPtr>(Pointer+4)); set { SdkMemory.Write(Pointer+4,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_nTimeCreated")]
    public uint @TimeCreated { get => SdkMemory.Read<uint >(Pointer+8); set { SdkMemory.Write(Pointer+8,value); } }
    [NativeMember("m_vecPosn")]
    public CVector @Position { get => new CVector(Pointer+12); set { SdkMemory.Copy(value.Pointer,Pointer+12,12); } }
    [NativeMember("m_fFrontX")]
    public float @FrontX { get => SdkMemory.Read<float >(Pointer+24); set { SdkMemory.Write(Pointer+24,value); } }
    [NativeMember("m_fFrontY")]
    public float @FrontY { get => SdkMemory.Read<float >(Pointer+28); set { SdkMemory.Write(Pointer+28,value); } }
    [NativeMember("m_fSideX")]
    public float @SideX { get => SdkMemory.Read<float >(Pointer+32); set { SdkMemory.Write(Pointer+32,value); } }
    [NativeMember("m_fSideY")]
    public float @SideY { get => SdkMemory.Read<float >(Pointer+36); set { SdkMemory.Write(Pointer+36,value); } }
    [NativeMember("m_fZDistance")]
    public float @ZDistance { get => SdkMemory.Read<float >(Pointer+40); set { SdkMemory.Write(Pointer+40,value); } }
    [NativeMember("m_fScale")]
    public float @Scale { get => SdkMemory.Read<float >(Pointer+44); set { SdkMemory.Write(Pointer+44,value); } }
    [NativeMember("m_pTexture")]
    public RwTexture? @Texture { get => SdkMemory.Read<IntPtr>(Pointer+48) == IntPtr.Zero ? null : new RwTexture(SdkMemory.Read<IntPtr>(Pointer+48)); set { SdkMemory.Write(Pointer+48,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_nIntensity")]
    public ushort @Intensity { get => SdkMemory.Read<ushort >(Pointer+52); set { SdkMemory.Write(Pointer+52,value); } }
    [NativeMember("m_nType")]
    public byte @Type { get => SdkMemory.Read<byte >(Pointer+54); set { SdkMemory.Write(Pointer+54,value); } }
    [NativeMember("m_nRed")]
    public byte @Red { get => SdkMemory.Read<byte >(Pointer+55); set { SdkMemory.Write(Pointer+55,value); } }
    [NativeMember("m_nGreen")]
    public byte @Green { get => SdkMemory.Read<byte >(Pointer+56); set { SdkMemory.Write(Pointer+56,value); } }
    [NativeMember("m_nBlue")]
    public byte @Blue { get => SdkMemory.Read<byte >(Pointer+57); set { SdkMemory.Write(Pointer+57,value); } }
    [NativeMember("m_bJustCreated")]
    public sbyte @JustCreated { get => SdkMemory.Read<sbyte >(Pointer+58); set { SdkMemory.Write(Pointer+58,value); } }
    [NativeMember("m_bRendered")]
    public sbyte @Rendered { get => SdkMemory.Read<sbyte >(Pointer+59); set { SdkMemory.Write(Pointer+59,value); } }
    [NativeMember("m_bTemporaryShadow")]
    public sbyte @TemporaryShadow { get => SdkMemory.Read<sbyte >(Pointer+60); set { SdkMemory.Write(Pointer+60,value); } }
    public void @Free() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3742 >(3742)(Pointer); }
}
