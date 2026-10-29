// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class rxHeapBlockHeader : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=32;
    public rxHeapBlockHeader(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("prev")]
    public rxHeapBlockHeader? @Prev { get => SdkMemory.Read<IntPtr>(Pointer+0) == IntPtr.Zero ? null : new rxHeapBlockHeader(SdkMemory.Read<IntPtr>(Pointer+0)); set { SdkMemory.Write(Pointer+0,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("next")]
    public rxHeapBlockHeader? @Next { get => SdkMemory.Read<IntPtr>(Pointer+4) == IntPtr.Zero ? null : new rxHeapBlockHeader(SdkMemory.Read<IntPtr>(Pointer+4)); set { SdkMemory.Write(Pointer+4,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("size")]
    public uint @Size { get => SdkMemory.Read<uint >(Pointer+8); set { SdkMemory.Write(Pointer+8,value); } }
    [NativeMember("freeEntry")]
    public rxHeapFreeBlock? @FreeEntry { get => SdkMemory.Read<IntPtr>(Pointer+12) == IntPtr.Zero ? null : new rxHeapFreeBlock(SdkMemory.Read<IntPtr>(Pointer+12)); set { SdkMemory.Write(Pointer+12,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("pad")]
    public NativeArray<uint> @Pad { get => new NativeArray<uint>(Pointer+16,4); }
}
