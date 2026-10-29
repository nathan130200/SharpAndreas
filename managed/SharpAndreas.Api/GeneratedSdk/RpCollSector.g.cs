// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class RpCollSector : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=8;
    public RpCollSector(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("type")]
    public byte @Type { get => SdkMemory.Read<byte >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("contents")]
    public byte @Contents { get => SdkMemory.Read<byte >(Pointer+1); set { SdkMemory.Write(Pointer+1,value); } }
    [NativeMember("index")]
    public ushort @Index { get => SdkMemory.Read<ushort >(Pointer+2); set { SdkMemory.Write(Pointer+2,value); } }
    [NativeMember("value")]
    public float @Value { get => SdkMemory.Read<float >(Pointer+4); set { SdkMemory.Write(Pointer+4,value); } }
}
