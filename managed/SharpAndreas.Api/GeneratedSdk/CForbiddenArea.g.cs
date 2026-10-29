// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CForbiddenArea : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=28;
    public CForbiddenArea(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_fX1")]
    public float @X1 { get => SdkMemory.Read<float >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("m_fX2")]
    public float @X2 { get => SdkMemory.Read<float >(Pointer+4); set { SdkMemory.Write(Pointer+4,value); } }
    [NativeMember("m_fY1")]
    public float @Y1 { get => SdkMemory.Read<float >(Pointer+8); set { SdkMemory.Write(Pointer+8,value); } }
    [NativeMember("m_fY2")]
    public float @Y2 { get => SdkMemory.Read<float >(Pointer+12); set { SdkMemory.Write(Pointer+12,value); } }
    [NativeMember("m_fZ1")]
    public float @Z1 { get => SdkMemory.Read<float >(Pointer+16); set { SdkMemory.Write(Pointer+16,value); } }
    [NativeMember("m_fZ2")]
    public float @Z2 { get => SdkMemory.Read<float >(Pointer+20); set { SdkMemory.Write(Pointer+20,value); } }
    [NativeMember("m_bEnable")]
    public bool @Enable { get => SdkMemory.Read<bool >(Pointer+24); set { SdkMemory.Write(Pointer+24,value); } }
    [NativeMember("m_nType")]
    public byte @Type { get => SdkMemory.Read<byte >(Pointer+25); set { SdkMemory.Write(Pointer+25,value); } }
}
