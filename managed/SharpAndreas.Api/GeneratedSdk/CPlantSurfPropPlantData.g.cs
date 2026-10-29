// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CPlantSurfPropPlantData : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=40;
    public CPlantSurfPropPlantData(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_nModelID")]
    public ushort @ModelID { get => SdkMemory.Read<ushort >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("m_nTextureID")]
    public ushort @TextureID { get => SdkMemory.Read<ushort >(Pointer+2); set { SdkMemory.Write(Pointer+2,value); } }
    [NativeMember("m_rgbaColor")]
    public RwRGBA @RgbaColor { get => new RwRGBA(Pointer+4); set { SdkMemory.Copy(value.Pointer,Pointer+4,4); } }
    [NativeMember("m_nIntensity")]
    public byte @Intensity { get => SdkMemory.Read<byte >(Pointer+8); set { SdkMemory.Write(Pointer+8,value); } }
    [NativeMember("m_nIntensityVar")]
    public byte @IntensityVariable { get => SdkMemory.Read<byte >(Pointer+9); set { SdkMemory.Write(Pointer+9,value); } }
    [NativeMember("m_fScaleXY")]
    public float @ScaleXY { get => SdkMemory.Read<float >(Pointer+12); set { SdkMemory.Write(Pointer+12,value); } }
    [NativeMember("m_fScaleZ")]
    public float @ScaleZ { get => SdkMemory.Read<float >(Pointer+16); set { SdkMemory.Write(Pointer+16,value); } }
    [NativeMember("m_fScaleVarXY")]
    public float @ScaleVariableXY { get => SdkMemory.Read<float >(Pointer+20); set { SdkMemory.Write(Pointer+20,value); } }
    [NativeMember("m_fScaleVarZ")]
    public float @ScaleVariableZ { get => SdkMemory.Read<float >(Pointer+24); set { SdkMemory.Write(Pointer+24,value); } }
    [NativeMember("m_fDensity")]
    public float @Density { get => SdkMemory.Read<float >(Pointer+28); set { SdkMemory.Write(Pointer+28,value); } }
    [NativeMember("m_fWindBendScale")]
    public float @WindBendScale { get => SdkMemory.Read<float >(Pointer+32); set { SdkMemory.Write(Pointer+32,value); } }
    [NativeMember("m_fWindBendVar")]
    public float @WindBendVariable { get => SdkMemory.Read<float >(Pointer+36); set { SdkMemory.Write(Pointer+36,value); } }
}
