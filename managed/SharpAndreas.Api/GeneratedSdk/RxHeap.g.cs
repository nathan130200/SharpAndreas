// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class RxHeap : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=28;
    public RxHeap(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("superBlockSize")]
    public uint @SuperBlockSize { get => SdkMemory.Read<uint >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("head")]
    public rxHeapSuperBlockDescriptor? @Head { get => SdkMemory.Read<IntPtr>(Pointer+4) == IntPtr.Zero ? null : new rxHeapSuperBlockDescriptor(SdkMemory.Read<IntPtr>(Pointer+4)); set { SdkMemory.Write(Pointer+4,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("headBlock")]
    public rxHeapBlockHeader? @HeadBlock { get => SdkMemory.Read<IntPtr>(Pointer+8) == IntPtr.Zero ? null : new rxHeapBlockHeader(SdkMemory.Read<IntPtr>(Pointer+8)); set { SdkMemory.Write(Pointer+8,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("freeBlocks")]
    public rxHeapFreeBlock? @FreeBlocks { get => SdkMemory.Read<IntPtr>(Pointer+12) == IntPtr.Zero ? null : new rxHeapFreeBlock(SdkMemory.Read<IntPtr>(Pointer+12)); set { SdkMemory.Write(Pointer+12,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("entriesAlloced")]
    public uint @EntriesAlloced { get => SdkMemory.Read<uint >(Pointer+16); set { SdkMemory.Write(Pointer+16,value); } }
    [NativeMember("entriesUsed")]
    public uint @EntriesUsed { get => SdkMemory.Read<uint >(Pointer+20); set { SdkMemory.Write(Pointer+20,value); } }
    [NativeMember("dirty")]
    public int @Dirty { get => SdkMemory.Read<int >(Pointer+24); set { SdkMemory.Write(Pointer+24,value); } }
}
