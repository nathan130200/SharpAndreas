// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class _rwPalQuantRGBABox : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=32;
    public _rwPalQuantRGBABox(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("col0")]
    public NativeArray<int> @Col0 { get => new NativeArray<int>(Pointer+0,4); }
    [NativeMember("col1")]
    public NativeArray<int> @Col1 { get => new NativeArray<int>(Pointer+16,4); }
}
