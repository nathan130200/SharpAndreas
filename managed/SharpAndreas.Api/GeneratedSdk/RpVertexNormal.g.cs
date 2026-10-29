// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class RpVertexNormal : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=4;
    public RpVertexNormal(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("x")]
    public sbyte @X { get => SdkMemory.Read<sbyte >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("y")]
    public sbyte @Y { get => SdkMemory.Read<sbyte >(Pointer+1); set { SdkMemory.Write(Pointer+1,value); } }
    [NativeMember("z")]
    public sbyte @Z { get => SdkMemory.Read<sbyte >(Pointer+2); set { SdkMemory.Write(Pointer+2,value); } }
    [NativeMember("pad")]
    public byte @Pad { get => SdkMemory.Read<byte >(Pointer+3); set { SdkMemory.Write(Pointer+3,value); } }
}
