// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CCutsceneObject : CObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=412;
    public CCutsceneObject(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_pAttachmentObject")]
    public CObject? @AttachmentObject { get => SdkMemory.Read<IntPtr>(Pointer+384) == IntPtr.Zero ? null : new CObject(SdkMemory.Read<IntPtr>(Pointer+384)); set { SdkMemory.Write(Pointer+384,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_vWorldPosition")]
    public CVector @WorldPosition { get => new CVector(Pointer+388); set { SdkMemory.Copy(value.Pointer,Pointer+388,12); } }
    [NativeMember("m_vForce")]
    public CVector @Force { get => new CVector(Pointer+400); set { SdkMemory.Copy(value.Pointer,Pointer+400,12); } }
}
