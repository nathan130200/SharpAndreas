// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class UpgradePosnDesc : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=32;
    public UpgradePosnDesc(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_vPosition")]
    public CVector @Position { get => new CVector(Pointer+0); set { SdkMemory.Copy(value.Pointer,Pointer+0,12); } }
    [NativeMember("m_qRotation")]
    public CQuaternion @QRotation { get => new CQuaternion(Pointer+12); set { SdkMemory.Copy(value.Pointer,Pointer+12,16); } }
    [NativeMember("m_nParentComponentId")]
    public int @ParentComponentId { get => SdkMemory.Read<int >(Pointer+28); set { SdkMemory.Write(Pointer+28,value); } }
}
