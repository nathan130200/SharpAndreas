// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class tSlotFileName : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=260;
    public tSlotFileName(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_sSavedGameName")]
    public NativeArray<sbyte> @SSavedGameName { get => new NativeArray<sbyte>(Pointer+0,260); }
}
