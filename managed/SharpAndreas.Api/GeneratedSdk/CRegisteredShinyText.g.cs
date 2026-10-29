// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CRegisteredShinyText : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=88;
    public CRegisteredShinyText(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_vecCornerAA")]
    public CVector @CornerAA { get => new CVector(Pointer+0); set { SdkMemory.Copy(value.Pointer,Pointer+0,12); } }
    [NativeMember("m_vecCornerAB")]
    public CVector @CornerAB { get => new CVector(Pointer+12); set { SdkMemory.Copy(value.Pointer,Pointer+12,12); } }
    [NativeMember("m_vecCornerBA")]
    public CVector @CornerBA { get => new CVector(Pointer+24); set { SdkMemory.Copy(value.Pointer,Pointer+24,12); } }
    [NativeMember("m_vecCornerBB")]
    public CVector @CornerBB { get => new CVector(Pointer+36); set { SdkMemory.Copy(value.Pointer,Pointer+36,12); } }
    [NativeMember("m_texCoorsAA")]
    public RwTexCoords @TexCoorsAA { get => new RwTexCoords(Pointer+48); set { SdkMemory.Copy(value.Pointer,Pointer+48,8); } }
    [NativeMember("m_texCoorsAB")]
    public RwTexCoords @TexCoorsAB { get => new RwTexCoords(Pointer+56); set { SdkMemory.Copy(value.Pointer,Pointer+56,8); } }
    [NativeMember("m_texCoorsBA")]
    public RwTexCoords @TexCoorsBA { get => new RwTexCoords(Pointer+64); set { SdkMemory.Copy(value.Pointer,Pointer+64,8); } }
    [NativeMember("m_texCoorsBB")]
    public RwTexCoords @TexCoorsBB { get => new RwTexCoords(Pointer+72); set { SdkMemory.Copy(value.Pointer,Pointer+72,8); } }
    [NativeMember("m_fDistanceToCamera")]
    public float @DistanceToCamera { get => SdkMemory.Read<float >(Pointer+80); set { SdkMemory.Write(Pointer+80,value); } }
    [NativeMember("m_color")]
    public RwRGBA @Color { get => new RwRGBA(Pointer+84); set { SdkMemory.Copy(value.Pointer,Pointer+84,4); } }
}
