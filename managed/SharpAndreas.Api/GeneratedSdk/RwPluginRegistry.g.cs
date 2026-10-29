// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class RwPluginRegistry : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=24;
    public RwPluginRegistry(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("sizeOfStruct")]
    public int @SizeOfStruct { get => SdkMemory.Read<int >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("origSizeOfStruct")]
    public int @OrigSizeOfStruct { get => SdkMemory.Read<int >(Pointer+4); set { SdkMemory.Write(Pointer+4,value); } }
    [NativeMember("maxSizeOfStruct")]
    public int @MaxSizeOfStruct { get => SdkMemory.Read<int >(Pointer+8); set { SdkMemory.Write(Pointer+8,value); } }
    [NativeMember("staticAlloc")]
    public int @StaticAlloc { get => SdkMemory.Read<int >(Pointer+12); set { SdkMemory.Write(Pointer+12,value); } }
    [NativeMember("firstRegEntry")]
    public RwPluginRegEntry? @FirstRegEntry { get => SdkMemory.Read<IntPtr>(Pointer+16) == IntPtr.Zero ? null : new RwPluginRegEntry(SdkMemory.Read<IntPtr>(Pointer+16)); set { SdkMemory.Write(Pointer+16,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("lastRegEntry")]
    public RwPluginRegEntry? @LastRegEntry { get => SdkMemory.Read<IntPtr>(Pointer+20) == IntPtr.Zero ? null : new RwPluginRegEntry(SdkMemory.Read<IntPtr>(Pointer+20)); set { SdkMemory.Write(Pointer+20,value?.Pointer ?? IntPtr.Zero); } }
}
