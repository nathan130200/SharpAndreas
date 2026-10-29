// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class rwResources : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=40;
    public rwResources(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("maxSize")]
    public int @MaxSize { get => SdkMemory.Read<int >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("currentSize")]
    public int @CurrentSize { get => SdkMemory.Read<int >(Pointer+4); set { SdkMemory.Write(Pointer+4,value); } }
    [NativeMember("reusageSize")]
    public int @ReusageSize { get => SdkMemory.Read<int >(Pointer+8); set { SdkMemory.Write(Pointer+8,value); } }
    [NativeMember("memHeap")]
    public NativePointer<IntPtr> @MemHeap { get => new NativePointer<IntPtr>(SdkMemory.Read<IntPtr>(Pointer+12)); set { SdkMemory.Write(Pointer+12,value.Pointer); } }
    [NativeMember("entriesA")]
    public RwLinkList @EntriesA { get => new RwLinkList(Pointer+16); set { SdkMemory.Copy(value.Pointer,Pointer+16,8); } }
    [NativeMember("entriesB")]
    public RwLinkList @EntriesB { get => new RwLinkList(Pointer+24); set { SdkMemory.Copy(value.Pointer,Pointer+24,8); } }
    [NativeMember("freeEntries")]
    public RwLinkList? @FreeEntries { get => SdkMemory.Read<IntPtr>(Pointer+32) == IntPtr.Zero ? null : new RwLinkList(SdkMemory.Read<IntPtr>(Pointer+32)); set { SdkMemory.Write(Pointer+32,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("usedEntries")]
    public RwLinkList? @UsedEntries { get => SdkMemory.Read<IntPtr>(Pointer+36) == IntPtr.Zero ? null : new RwLinkList(SdkMemory.Read<IntPtr>(Pointer+36)); set { SdkMemory.Write(Pointer+36,value?.Pointer ?? IntPtr.Zero); } }
}
