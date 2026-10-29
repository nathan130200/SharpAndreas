// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class RwLLLink : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=8;
    public RwLLLink(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("next")]
    public RwLLLink? @Next { get => SdkMemory.Read<IntPtr>(Pointer+0) == IntPtr.Zero ? null : new RwLLLink(SdkMemory.Read<IntPtr>(Pointer+0)); set { SdkMemory.Write(Pointer+0,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("prev")]
    public RwLLLink? @Prev { get => SdkMemory.Read<IntPtr>(Pointer+4) == IntPtr.Zero ? null : new RwLLLink(SdkMemory.Read<IntPtr>(Pointer+4)); set { SdkMemory.Write(Pointer+4,value?.Pointer ?? IntPtr.Zero); } }
}
