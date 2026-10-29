// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class tMissionCleanupEntity : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=8;
    public tMissionCleanupEntity(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("type")]
    public sbyte @Type { get => SdkMemory.Read<sbyte >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("__pad")]
    public NativeArray<sbyte> @Pad { get => new NativeArray<sbyte>(Pointer+1,3); }
    [NativeMember("handle")]
    public int @Handle { get => SdkMemory.Read<int >(Pointer+4); set { SdkMemory.Write(Pointer+4,value); } }
}
