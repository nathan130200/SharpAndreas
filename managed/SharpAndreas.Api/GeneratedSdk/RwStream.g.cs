// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class RwStream : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=36;
    public RwStream(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("type")]
    public RwStreamType @Type { get => SdkMemory.Read<RwStreamType >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("accessType")]
    public RwStreamAccessType @AccessType { get => SdkMemory.Read<RwStreamAccessType >(Pointer+4); set { SdkMemory.Write(Pointer+4,value); } }
    [NativeMember("position")]
    public int @Position { get => SdkMemory.Read<int >(Pointer+8); set { SdkMemory.Write(Pointer+8,value); } }
    [NativeMember("Type")]
    public RwStreamUnion @TypeValue { get => new RwStreamUnion(Pointer+12); set { SdkMemory.Copy(value.Pointer,Pointer+12,20); } }
    [NativeMember("rwOwned")]
    public int @Owned { get => SdkMemory.Read<int >(Pointer+32); set { SdkMemory.Write(Pointer+32,value); } }
}
