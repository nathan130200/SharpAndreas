// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CObjectData : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=1;
    public CObjectData(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("ms_aObjectInfo")]
    public static CObjectInfo? @ObjectInfo { get => new IntPtr(0xBB4A90) == IntPtr.Zero ? null : new CObjectInfo(new IntPtr(0xBB4A90)); }
}
