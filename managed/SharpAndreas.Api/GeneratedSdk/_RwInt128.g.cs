// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class _RwInt128 : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=16;
    public _RwInt128(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("bottom")]
    public ulong @Bottom { get => SdkMemory.Read<ulong >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("top")]
    public long @Top { get => SdkMemory.Read<long >(Pointer+8); set { SdkMemory.Write(Pointer+8,value); } }
}
