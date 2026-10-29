// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CTimeModelInfo : CAtomicModelInfo
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=36;
    public CTimeModelInfo(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_timeInfo")]
    public tTimeInfo @TimeInfo { get => new tTimeInfo(Pointer+32); set { SdkMemory.Copy(value.Pointer,Pointer+32,4); } }
    public void @FindOtherTimeModel(NativePointer<sbyte> @modelName) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D406 >(406)(Pointer,@modelName.Pointer); }
}
