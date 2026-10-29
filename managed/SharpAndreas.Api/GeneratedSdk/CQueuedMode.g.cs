// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CQueuedMode : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=12;
    public CQueuedMode(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_nMode")]
    public ushort @Mode { get => SdkMemory.Read<ushort >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("m_fDuration")]
    public float @Duration { get => SdkMemory.Read<float >(Pointer+4); set { SdkMemory.Write(Pointer+4,value); } }
    [NativeMember("m_nMinZoom")]
    public ushort @MinZoom { get => SdkMemory.Read<ushort >(Pointer+8); set { SdkMemory.Write(Pointer+8,value); } }
    [NativeMember("m_nMaxZoom")]
    public ushort @MaxZoom { get => SdkMemory.Read<ushort >(Pointer+10); set { SdkMemory.Write(Pointer+10,value); } }
}
