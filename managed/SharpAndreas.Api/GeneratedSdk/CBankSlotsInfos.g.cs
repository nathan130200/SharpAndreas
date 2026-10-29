// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CBankSlotsInfos : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=216900;
    public CBankSlotsInfos(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_aInfos")]
    public NativeObjectArray<CBankSlotInfo> @Infos { get => new NativeObjectArray<CBankSlotInfo>(Pointer+0,45,4820); }
}
