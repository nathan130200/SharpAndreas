// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CRegisteredShadow : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=52;
    public CRegisteredShadow(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_vecPosn")]
    public CVector @Position { get => new CVector(Pointer+0); set { SdkMemory.Copy(value.Pointer,Pointer+0,12); } }
    [NativeMember("m_fFrontX")]
    public float @FrontX { get => SdkMemory.Read<float >(Pointer+12); set { SdkMemory.Write(Pointer+12,value); } }
    [NativeMember("m_fFrontY")]
    public float @FrontY { get => SdkMemory.Read<float >(Pointer+16); set { SdkMemory.Write(Pointer+16,value); } }
    [NativeMember("m_fSideX")]
    public float @SideX { get => SdkMemory.Read<float >(Pointer+20); set { SdkMemory.Write(Pointer+20,value); } }
    [NativeMember("m_fSideY")]
    public float @SideY { get => SdkMemory.Read<float >(Pointer+24); set { SdkMemory.Write(Pointer+24,value); } }
    [NativeMember("m_fZDistance")]
    public float @ZDistance { get => SdkMemory.Read<float >(Pointer+28); set { SdkMemory.Write(Pointer+28,value); } }
    [NativeMember("m_fScale")]
    public float @Scale { get => SdkMemory.Read<float >(Pointer+32); set { SdkMemory.Write(Pointer+32,value); } }
    [NativeMember("m_pTexture")]
    public RwTexture? @Texture { get => SdkMemory.Read<IntPtr>(Pointer+36) == IntPtr.Zero ? null : new RwTexture(SdkMemory.Read<IntPtr>(Pointer+36)); set { SdkMemory.Write(Pointer+36,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_pRTShadow")]
    public CRealTimeShadow? @RTShadow { get => SdkMemory.Read<IntPtr>(Pointer+40) == IntPtr.Zero ? null : new CRealTimeShadow(SdkMemory.Read<IntPtr>(Pointer+40)); set { SdkMemory.Write(Pointer+40,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_nIntensity")]
    public ushort @Intensity { get => SdkMemory.Read<ushort >(Pointer+44); set { SdkMemory.Write(Pointer+44,value); } }
    [NativeMember("m_nType")]
    public byte @Type { get => SdkMemory.Read<byte >(Pointer+46); set { SdkMemory.Write(Pointer+46,value); } }
    [NativeMember("m_nRed")]
    public byte @Red { get => SdkMemory.Read<byte >(Pointer+47); set { SdkMemory.Write(Pointer+47,value); } }
    [NativeMember("m_nGreen")]
    public byte @Green { get => SdkMemory.Read<byte >(Pointer+48); set { SdkMemory.Write(Pointer+48,value); } }
    [NativeMember("m_nBlue")]
    public byte @Blue { get => SdkMemory.Read<byte >(Pointer+49); set { SdkMemory.Write(Pointer+49,value); } }
    [NativeMember("m_nFlags")]
    public CRegisteredShadow___unnamed__at_D__plugin_sdk_plugin_sa_game_sa_CShado_2bbce76088 @Flags { get => new CRegisteredShadow___unnamed__at_D__plugin_sdk_plugin_sa_game_sa_CShado_2bbce76088(Pointer+50); set { SdkMemory.Copy(value.Pointer,Pointer+50,1); } }
}
