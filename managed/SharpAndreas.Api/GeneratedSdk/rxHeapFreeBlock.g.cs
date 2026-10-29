// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class rxHeapFreeBlock : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=8;
    public rxHeapFreeBlock(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("size")]
    public uint @Size { get => SdkMemory.Read<uint >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("ptr")]
    public rxHeapBlockHeader? @PointerValue { get => SdkMemory.Read<IntPtr>(Pointer+4) == IntPtr.Zero ? null : new rxHeapBlockHeader(SdkMemory.Read<IntPtr>(Pointer+4)); set { SdkMemory.Write(Pointer+4,value?.Pointer ?? IntPtr.Zero); } }
}
