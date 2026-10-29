// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class BreakTri_t : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=72;
    public BreakTri_t(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_verts")]
    public NativeObjectArray<RwV3d> @Verts { get => new NativeObjectArray<RwV3d>(Pointer+0,3,12); }
    [NativeMember("m_texCoords")]
    public NativeObjectArray<RwTexCoords> @TexCoordinates { get => new NativeObjectArray<RwTexCoords>(Pointer+36,3,8); }
    [NativeMember("m_col")]
    public NativeObjectArray<RwRGBA> @Collision { get => new NativeObjectArray<RwRGBA>(Pointer+60,3,4); }
}
