// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CPointLight : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=48;
    public CPointLight(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_vecPosn")]
    public CVector @Position { get => new CVector(Pointer+0); set { SdkMemory.Copy(value.Pointer,Pointer+0,12); } }
    [NativeMember("m_vecDirection")]
    public CVector @Direction { get => new CVector(Pointer+12); set { SdkMemory.Copy(value.Pointer,Pointer+12,12); } }
    [NativeMember("m_fRange")]
    public float @Range { get => SdkMemory.Read<float >(Pointer+24); set { SdkMemory.Write(Pointer+24,value); } }
    [NativeMember("m_fColorRed")]
    public float @ColorRed { get => SdkMemory.Read<float >(Pointer+28); set { SdkMemory.Write(Pointer+28,value); } }
    [NativeMember("m_fColorGreen")]
    public float @ColorGreen { get => SdkMemory.Read<float >(Pointer+32); set { SdkMemory.Write(Pointer+32,value); } }
    [NativeMember("m_fColorBlue")]
    public float @ColorBlue { get => SdkMemory.Read<float >(Pointer+36); set { SdkMemory.Write(Pointer+36,value); } }
    [NativeMember("m_pEntityToLight")]
    public CEntity? @EntityToLight { get => SdkMemory.Read<IntPtr>(Pointer+40) == IntPtr.Zero ? null : new CEntity(SdkMemory.Read<IntPtr>(Pointer+40)); set { SdkMemory.Write(Pointer+40,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_nType")]
    public ePointLightType @Type { get => SdkMemory.Read<ePointLightType >(Pointer+44); set { SdkMemory.Write(Pointer+44,value); } }
    [NativeMember("m_nFogType")]
    public byte @FogType { get => SdkMemory.Read<byte >(Pointer+45); set { SdkMemory.Write(Pointer+45,value); } }
    [NativeMember("m_bGenerateShadows")]
    public bool @GenerateShadows { get => SdkMemory.Read<bool >(Pointer+46); set { SdkMemory.Write(Pointer+46,value); } }
}
