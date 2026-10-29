// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class RpHAnimFrameExtension : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=8;
    public RpHAnimFrameExtension(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("id")]
    public int @Id { get => SdkMemory.Read<int >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("hierarchy")]
    public RpHAnimHierarchy? @Hierarchy { get => SdkMemory.Read<IntPtr>(Pointer+4) == IntPtr.Zero ? null : new RpHAnimHierarchy(SdkMemory.Read<IntPtr>(Pointer+4)); set { SdkMemory.Write(Pointer+4,value?.Pointer ?? IntPtr.Zero); } }
}
