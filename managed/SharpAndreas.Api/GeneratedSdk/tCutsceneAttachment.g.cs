// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class tCutsceneAttachment : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=12;
    public tCutsceneAttachment(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_nCutscenePedObjectId")]
    public int @CutscenePedObjectId { get => SdkMemory.Read<int >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("m_nCutsceneAttachmentObjectId")]
    public int @CutsceneAttachmentObjectId { get => SdkMemory.Read<int >(Pointer+4); set { SdkMemory.Write(Pointer+4,value); } }
    [NativeMember("m_nBoneId")]
    public int @BoneId { get => SdkMemory.Read<int >(Pointer+8); set { SdkMemory.Write(Pointer+8,value); } }
}
