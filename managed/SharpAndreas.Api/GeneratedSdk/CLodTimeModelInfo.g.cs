// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CLodTimeModelInfo : CLodAtomicModelInfo
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=40;
    public CLodTimeModelInfo(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_lodTimeInfo")]
    public tTimeInfo @LodTimeInfo { get => new tTimeInfo(Pointer+36); set { SdkMemory.Copy(value.Pointer,Pointer+36,4); } }
}
