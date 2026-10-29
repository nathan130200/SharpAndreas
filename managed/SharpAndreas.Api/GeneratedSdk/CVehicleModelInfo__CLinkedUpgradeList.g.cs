// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CVehicleModelInfo__CLinkedUpgradeList : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=124;
    public CVehicleModelInfo__CLinkedUpgradeList(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_anUpgrade1")]
    public NativeArray<short> @Upgrade1 { get => new NativeArray<short>(Pointer+0,30); }
    [NativeMember("m_anUpgrade2")]
    public NativeArray<short> @Upgrade2 { get => new NativeArray<short>(Pointer+60,30); }
    [NativeMember("m_nLinksCount")]
    public uint @LinksCount { get => SdkMemory.Read<uint >(Pointer+120); set { SdkMemory.Write(Pointer+120,value); } }
}
