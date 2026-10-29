// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class tBinaryIplFile : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=76;
    public tBinaryIplFile(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("fourcc")]
    public NativeArray<sbyte> @Fourcc { get => new NativeArray<sbyte>(Pointer+0,4); }
    [NativeMember("numInstances")]
    public ushort @CountInstances { get => SdkMemory.Read<ushort >(Pointer+4); set { SdkMemory.Write(Pointer+4,value); } }
    [NativeMember("numCarGenerators")]
    public ushort @CountCarGenerators { get => SdkMemory.Read<ushort >(Pointer+20); set { SdkMemory.Write(Pointer+20,value); } }
    [NativeMember("instancesOffset")]
    public uint @InstancesOffset { get => SdkMemory.Read<uint >(Pointer+28); set { SdkMemory.Write(Pointer+28,value); } }
    [NativeMember("carGeneratorsOffset")]
    public uint @CarGeneratorsOffset { get => SdkMemory.Read<uint >(Pointer+60); set { SdkMemory.Write(Pointer+60,value); } }
}
