// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class rxHeapSuperBlockDescriptor : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=12;
    public rxHeapSuperBlockDescriptor(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("start")]
    public NativePointer<IntPtr> @Start { get => new NativePointer<IntPtr>(SdkMemory.Read<IntPtr>(Pointer+0)); set { SdkMemory.Write(Pointer+0,value.Pointer); } }
    [NativeMember("size")]
    public uint @Size { get => SdkMemory.Read<uint >(Pointer+4); set { SdkMemory.Write(Pointer+4,value); } }
    [NativeMember("next")]
    public rxHeapSuperBlockDescriptor? @Next { get => SdkMemory.Read<IntPtr>(Pointer+8) == IntPtr.Zero ? null : new rxHeapSuperBlockDescriptor(SdkMemory.Read<IntPtr>(Pointer+8)); set { SdkMemory.Write(Pointer+8,value?.Pointer ?? IntPtr.Zero); } }
}
