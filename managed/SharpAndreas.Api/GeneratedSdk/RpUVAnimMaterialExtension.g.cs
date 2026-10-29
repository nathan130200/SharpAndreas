// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class RpUVAnimMaterialExtension : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=40;
    public RpUVAnimMaterialExtension(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("uv")]
    public NativeArray<IntPtr> @Uv { get => new NativeArray<IntPtr>(Pointer+0,2); }
    [NativeMember("interp")]
    public NativeArray<IntPtr> @Interp { get => new NativeArray<IntPtr>(Pointer+8,8); }
}
