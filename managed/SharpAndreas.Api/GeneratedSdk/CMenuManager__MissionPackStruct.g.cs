// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CMenuManager__MissionPackStruct : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=261;
    public CMenuManager__MissionPackStruct(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("id")]
    public byte @Id { get => SdkMemory.Read<byte >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("name")]
    public NativeArray<sbyte> @Name { get => new NativeArray<sbyte>(Pointer+1,260); }
}
