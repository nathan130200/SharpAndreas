// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CRepeatSector : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=12;
    public CRepeatSector(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_lists")]
    public NativeObjectArray<CPtrListDoubleLink> @Lists { get => new NativeObjectArray<CPtrListDoubleLink>(Pointer+0,3,4); }
}
