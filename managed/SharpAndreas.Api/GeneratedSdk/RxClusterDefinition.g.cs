// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class RxClusterDefinition : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=16;
    public RxClusterDefinition(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("name")]
    public NativePointer<sbyte> @Name { get => new NativePointer<sbyte>(SdkMemory.Read<IntPtr>(Pointer+0)); set { SdkMemory.Write(Pointer+0,value.Pointer); } }
    [NativeMember("defaultStride")]
    public uint @DefaultStride { get => SdkMemory.Read<uint >(Pointer+4); set { SdkMemory.Write(Pointer+4,value); } }
    [NativeMember("defaultAttributes")]
    public uint @DefaultAttributes { get => SdkMemory.Read<uint >(Pointer+8); set { SdkMemory.Write(Pointer+8,value); } }
    [NativeMember("attributeSet")]
    public NativePointer<sbyte> @AttributeSet { get => new NativePointer<sbyte>(SdkMemory.Read<IntPtr>(Pointer+12)); }
}
