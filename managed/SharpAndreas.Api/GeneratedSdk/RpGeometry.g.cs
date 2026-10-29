// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class RpGeometry : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=96;
    public RpGeometry(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("object")]
    public RwObject @Object { get => new RwObject(Pointer+0); set { SdkMemory.Copy(value.Pointer,Pointer+0,8); } }
    [NativeMember("flags")]
    public uint @Flags { get => SdkMemory.Read<uint >(Pointer+8); set { SdkMemory.Write(Pointer+8,value); } }
    [NativeMember("lockedSinceLastInst")]
    public ushort @LockedSinceLastInst { get => SdkMemory.Read<ushort >(Pointer+12); set { SdkMemory.Write(Pointer+12,value); } }
    [NativeMember("refCount")]
    public short @RefCount { get => SdkMemory.Read<short >(Pointer+14); set { SdkMemory.Write(Pointer+14,value); } }
    [NativeMember("numTriangles")]
    public int @CountTriangles { get => SdkMemory.Read<int >(Pointer+16); set { SdkMemory.Write(Pointer+16,value); } }
    [NativeMember("numVertices")]
    public int @CountVertices { get => SdkMemory.Read<int >(Pointer+20); set { SdkMemory.Write(Pointer+20,value); } }
    [NativeMember("numMorphTargets")]
    public int @CountMorphTargets { get => SdkMemory.Read<int >(Pointer+24); set { SdkMemory.Write(Pointer+24,value); } }
    [NativeMember("numTexCoordSets")]
    public int @CountTexCoordinateSets { get => SdkMemory.Read<int >(Pointer+28); set { SdkMemory.Write(Pointer+28,value); } }
    [NativeMember("matList")]
    public RpMaterialList @List { get => new RpMaterialList(Pointer+32); set { SdkMemory.Copy(value.Pointer,Pointer+32,12); } }
    [NativeMember("triangles")]
    public RpTriangle? @Triangles { get => SdkMemory.Read<IntPtr>(Pointer+44) == IntPtr.Zero ? null : new RpTriangle(SdkMemory.Read<IntPtr>(Pointer+44)); set { SdkMemory.Write(Pointer+44,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("preLitLum")]
    public RwRGBA? @PreLitLum { get => SdkMemory.Read<IntPtr>(Pointer+48) == IntPtr.Zero ? null : new RwRGBA(SdkMemory.Read<IntPtr>(Pointer+48)); set { SdkMemory.Write(Pointer+48,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("texCoords")]
    public NativeArray<IntPtr> @TexCoordinates { get => new NativeArray<IntPtr>(Pointer+52,8); }
    [NativeMember("mesh")]
    public RpMeshHeader? @Mesh { get => SdkMemory.Read<IntPtr>(Pointer+84) == IntPtr.Zero ? null : new RpMeshHeader(SdkMemory.Read<IntPtr>(Pointer+84)); set { SdkMemory.Write(Pointer+84,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("repEntry")]
    public RwResEntry? @RepEntry { get => SdkMemory.Read<IntPtr>(Pointer+88) == IntPtr.Zero ? null : new RwResEntry(SdkMemory.Read<IntPtr>(Pointer+88)); set { SdkMemory.Write(Pointer+88,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("morphTarget")]
    public RpMorphTarget? @MorphTarget { get => SdkMemory.Read<IntPtr>(Pointer+92) == IntPtr.Zero ? null : new RpMorphTarget(SdkMemory.Read<IntPtr>(Pointer+92)); set { SdkMemory.Write(Pointer+92,value?.Pointer ?? IntPtr.Zero); } }
}
