// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class tMusicTrackHistory : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=20;
    public tMusicTrackHistory(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_indices")]
    public NativeArray<sbyte> @Indices { get => new NativeArray<sbyte>(Pointer+0,20); }
}
