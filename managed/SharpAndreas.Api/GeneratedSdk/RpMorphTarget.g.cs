// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class RpMorphTarget : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=28;
    public RpMorphTarget(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("parentGeom")]
    public RpGeometry? @ParentGeom { get => SdkMemory.Read<IntPtr>(Pointer+0) == IntPtr.Zero ? null : new RpGeometry(SdkMemory.Read<IntPtr>(Pointer+0)); set { SdkMemory.Write(Pointer+0,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("boundingSphere")]
    public RwSphere @BoundingSphere { get => new RwSphere(Pointer+4); set { SdkMemory.Copy(value.Pointer,Pointer+4,16); } }
    [NativeMember("verts")]
    public RwV3d? @Verts { get => SdkMemory.Read<IntPtr>(Pointer+20) == IntPtr.Zero ? null : new RwV3d(SdkMemory.Read<IntPtr>(Pointer+20)); set { SdkMemory.Write(Pointer+20,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("normals")]
    public RwV3d? @Normals { get => SdkMemory.Read<IntPtr>(Pointer+24) == IntPtr.Zero ? null : new RwV3d(SdkMemory.Read<IntPtr>(Pointer+24)); set { SdkMemory.Write(Pointer+24,value?.Pointer ?? IntPtr.Zero); } }
}
