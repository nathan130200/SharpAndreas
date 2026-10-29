// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class tVolumetricClouds : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=5800;
    public tVolumetricClouds(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_bSlots")]
    public NativeArray<sbyte> @Slots { get => new NativeArray<sbyte>(Pointer+0,180); }
    [NativeMember("m_bInsideVisibilityRange")]
    public NativeArray<sbyte> @InsideVisibilityRange { get => new NativeArray<sbyte>(Pointer+180,180); }
    [NativeMember("field_168")]
    public NativeObjectArray<CVector> @Field168 { get => new NativeObjectArray<CVector>(Pointer+360,180,12); }
    [NativeMember("field_9D8")]
    public NativeObjectArray<CVector> @Field9D8 { get => new NativeObjectArray<CVector>(Pointer+2520,180,12); }
    [NativeMember("m_nHeight")]
    public NativeArray<int> @Height { get => new NativeArray<int>(Pointer+4680,180); }
    [NativeMember("m_pTex")]
    public RwTexture? @Tex { get => SdkMemory.Read<IntPtr>(Pointer+5400) == IntPtr.Zero ? null : new RwTexture(SdkMemory.Read<IntPtr>(Pointer+5400)); set { SdkMemory.Write(Pointer+5400,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_vecCloudsSpace")]
    public NativeObjectArray<CVector> @CloudsSpace { get => new NativeObjectArray<CVector>(Pointer+5404,3,12); }
    [NativeMember("m_fCloudXCoords")]
    public NativeArray<float> @CloudXCoords { get => new NativeArray<float>(Pointer+5440,18); }
    [NativeMember("m_fCloudYCoords")]
    public NativeArray<float> @CloudYCoords { get => new NativeArray<float>(Pointer+5512,18); }
    [NativeMember("m_fCloudZCoords")]
    public NativeArray<float> @CloudZCoords { get => new NativeArray<float>(Pointer+5584,18); }
    [NativeMember("m_fCloudUCoords")]
    public NativeArray<float> @CloudUCoords { get => new NativeArray<float>(Pointer+5656,18); }
    [NativeMember("m_fCloudVCoords")]
    public NativeArray<float> @CloudVCoords { get => new NativeArray<float>(Pointer+5728,18); }
}
