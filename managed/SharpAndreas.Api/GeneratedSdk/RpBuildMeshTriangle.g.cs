// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class RpBuildMeshTriangle : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=20;
    public RpBuildMeshTriangle(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("vertIndex")]
    public NativeArray<ushort> @VertIndex { get => new NativeArray<ushort>(Pointer+0,3); }
    [NativeMember("material")]
    public RpMaterial? @Material { get => SdkMemory.Read<IntPtr>(Pointer+8) == IntPtr.Zero ? null : new RpMaterial(SdkMemory.Read<IntPtr>(Pointer+8)); set { SdkMemory.Write(Pointer+8,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("matIndex")]
    public ushort @Index { get => SdkMemory.Read<ushort >(Pointer+12); set { SdkMemory.Write(Pointer+12,value); } }
    [NativeMember("textureIndex")]
    public ushort @TextureIndex { get => SdkMemory.Read<ushort >(Pointer+14); set { SdkMemory.Write(Pointer+14,value); } }
    [NativeMember("rasterIndex")]
    public ushort @RasterIndex { get => SdkMemory.Read<ushort >(Pointer+16); set { SdkMemory.Write(Pointer+16,value); } }
    [NativeMember("pipelineIndex")]
    public ushort @PipelineIndex { get => SdkMemory.Read<ushort >(Pointer+18); set { SdkMemory.Write(Pointer+18,value); } }
}
