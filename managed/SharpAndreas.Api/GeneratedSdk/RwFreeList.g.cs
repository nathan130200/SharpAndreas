// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class RwFreeList : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=36;
    public RwFreeList(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("entrySize")]
    public uint @EntrySize { get => SdkMemory.Read<uint >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("entriesPerBlock")]
    public uint @EntriesPerBlock { get => SdkMemory.Read<uint >(Pointer+4); set { SdkMemory.Write(Pointer+4,value); } }
    [NativeMember("heapSize")]
    public uint @HeapSize { get => SdkMemory.Read<uint >(Pointer+8); set { SdkMemory.Write(Pointer+8,value); } }
    [NativeMember("alignment")]
    public uint @Alignment { get => SdkMemory.Read<uint >(Pointer+12); set { SdkMemory.Write(Pointer+12,value); } }
    [NativeMember("blockList")]
    public RwLinkList @BlockList { get => new RwLinkList(Pointer+16); set { SdkMemory.Copy(value.Pointer,Pointer+16,8); } }
    [NativeMember("flags")]
    public uint @Flags { get => SdkMemory.Read<uint >(Pointer+24); set { SdkMemory.Write(Pointer+24,value); } }
    [NativeMember("link")]
    public RwLLLink @Link { get => new RwLLLink(Pointer+28); set { SdkMemory.Copy(value.Pointer,Pointer+28,8); } }
}
