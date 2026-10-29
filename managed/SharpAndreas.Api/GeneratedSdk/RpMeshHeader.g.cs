// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class RpMeshHeader : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=16;
    public RpMeshHeader(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("flags")]
    public uint @Flags { get => SdkMemory.Read<uint >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("numMeshes")]
    public ushort @CountMeshes { get => SdkMemory.Read<ushort >(Pointer+4); set { SdkMemory.Write(Pointer+4,value); } }
    [NativeMember("serialNum")]
    public ushort @SerialCount { get => SdkMemory.Read<ushort >(Pointer+6); set { SdkMemory.Write(Pointer+6,value); } }
    [NativeMember("totalIndicesInMesh")]
    public uint @TotalIndicesInMesh { get => SdkMemory.Read<uint >(Pointer+8); set { SdkMemory.Write(Pointer+8,value); } }
    [NativeMember("firstMeshOffset")]
    public uint @FirstMeshOffset { get => SdkMemory.Read<uint >(Pointer+12); set { SdkMemory.Write(Pointer+12,value); } }
}
