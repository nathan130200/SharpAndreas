// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class AnimBlendFrameData : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=24;
    public AnimBlendFrameData(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_nFlags")]
    public uint @Flags { get => SdkMemory.Read<uint >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("m_vecOffset")]
    public CVector @Offset { get => new CVector(Pointer+4); set { SdkMemory.Copy(value.Pointer,Pointer+4,12); } }
    [NativeMember("m_pIFrame")]
    public IFrame? @IFrame { get => SdkMemory.Read<IntPtr>(Pointer+16) == IntPtr.Zero ? null : new IFrame(SdkMemory.Read<IntPtr>(Pointer+16)); set { SdkMemory.Write(Pointer+16,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_nNodeId")]
    public uint @NodeId { get => SdkMemory.Read<uint >(Pointer+20); set { SdkMemory.Write(Pointer+20,value); } }
}
