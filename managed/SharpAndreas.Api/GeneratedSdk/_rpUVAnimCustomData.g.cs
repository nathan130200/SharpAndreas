// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class _rpUVAnimCustomData : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=68;
    public _rpUVAnimCustomData(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("name")]
    public NativeArray<sbyte> @Name { get => new NativeArray<sbyte>(Pointer+0,32); }
    [NativeMember("nodeToUVChannelMap")]
    public NativeArray<uint> @NodeToUVChannelMap { get => new NativeArray<uint>(Pointer+32,8); }
    [NativeMember("refCount")]
    public uint @RefCount { get => SdkMemory.Read<uint >(Pointer+64); set { SdkMemory.Write(Pointer+64,value); } }
}
