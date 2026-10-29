// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class tSlotSaveDate : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=70;
    public tSlotSaveDate(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_sSavedGameDateAndTime")]
    public NativeArray<sbyte> @SSavedGameDateAndTime { get => new NativeArray<sbyte>(Pointer+0,70); }
}
