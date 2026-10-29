// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CRenPar : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=16;
    public CRenPar(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("z")]
    public float @Z { get => SdkMemory.Read<float >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("bigWaves")]
    public float @BigWaves { get => SdkMemory.Read<float >(Pointer+4); set { SdkMemory.Write(Pointer+4,value); } }
    [NativeMember("smallWaves")]
    public float @SmallWaves { get => SdkMemory.Read<float >(Pointer+8); set { SdkMemory.Write(Pointer+8,value); } }
    [NativeMember("flowX")]
    public sbyte @FlowX { get => SdkMemory.Read<sbyte >(Pointer+12); set { SdkMemory.Write(Pointer+12,value); } }
    [NativeMember("flowY")]
    public sbyte @FlowY { get => SdkMemory.Read<sbyte >(Pointer+13); set { SdkMemory.Write(Pointer+13,value); } }
}
