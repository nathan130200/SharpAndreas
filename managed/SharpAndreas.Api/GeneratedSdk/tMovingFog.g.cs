// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class tMovingFog : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=10236;
    public tMovingFog(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_bFogSlots")]
    public NativeArray<bool> @FogSlots { get => new NativeArray<bool>(Pointer+0,350); }
    [NativeMember("m_vecPosn")]
    public NativeObjectArray<CVector> @Position { get => new NativeObjectArray<CVector>(Pointer+352,350,12); }
    [NativeMember("m_fSize")]
    public NativeArray<float> @Size { get => new NativeArray<float>(Pointer+4552,350); }
    [NativeMember("m_fIntensity")]
    public NativeArray<float> @Intensity { get => new NativeArray<float>(Pointer+5952,350); }
    [NativeMember("m_fMaxIntensity")]
    public NativeArray<float> @MaxIntensity { get => new NativeArray<float>(Pointer+7352,350); }
    [NativeMember("m_vecWind")]
    public CVector @Wind { get => new CVector(Pointer+8752); set { SdkMemory.Copy(value.Pointer,Pointer+8752,12); } }
    [NativeMember("m_fSpeed")]
    public NativeArray<float> @Speed { get => new NativeArray<float>(Pointer+8764,350); }
    [NativeMember("field_27B4")]
    public NativeArray<int> @Field27B4 { get => new NativeArray<int>(Pointer+10164,12); }
    [NativeMember("m_nPrimIndices")]
    public NativeArray<uint> @PrimIndices { get => new NativeArray<uint>(Pointer+10212,6); }
}
