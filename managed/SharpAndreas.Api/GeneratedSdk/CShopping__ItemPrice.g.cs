// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CShopping__ItemPrice : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=24;
    public CShopping__ItemPrice(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("key")]
    public uint @Key { get => SdkMemory.Read<uint >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("price")]
    public uint @Price { get => SdkMemory.Read<uint >(Pointer+4); set { SdkMemory.Write(Pointer+4,value); } }
    [NativeMember("nameTag")]
    public NativeArray<sbyte> @NameTag { get => new NativeArray<sbyte>(Pointer+16,8); }
}
