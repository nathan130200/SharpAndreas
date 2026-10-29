// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class RwRGBA : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=4;
    public RwRGBA(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("red")]
    public byte @Red { get => SdkMemory.Read<byte >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("green")]
    public byte @Green { get => SdkMemory.Read<byte >(Pointer+1); set { SdkMemory.Write(Pointer+1,value); } }
    [NativeMember("blue")]
    public byte @Blue { get => SdkMemory.Read<byte >(Pointer+2); set { SdkMemory.Write(Pointer+2,value); } }
    [NativeMember("alpha")]
    public byte @Alpha { get => SdkMemory.Read<byte >(Pointer+3); set { SdkMemory.Write(Pointer+3,value); } }
}
