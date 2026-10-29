// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CSector : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=8;
    public CSector(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_buildingList")]
    public CPtrListSingleLink @BuildingList { get => new CPtrListSingleLink(Pointer+0); set { SdkMemory.Copy(value.Pointer,Pointer+0,4); } }
    [NativeMember("m_dummyList")]
    public CPtrListDoubleLink @DummyList { get => new CPtrListDoubleLink(Pointer+4); set { SdkMemory.Copy(value.Pointer,Pointer+4,4); } }
}
