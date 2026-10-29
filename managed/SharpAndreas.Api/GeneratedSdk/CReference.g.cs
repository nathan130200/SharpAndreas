// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CReference : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=8;
    public CReference(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_pNext")]
    public CReference? @Next { get => SdkMemory.Read<IntPtr>(Pointer+0) == IntPtr.Zero ? null : new CReference(SdkMemory.Read<IntPtr>(Pointer+0)); set { SdkMemory.Write(Pointer+0,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_ppEntity")]
    public NativePointer<IntPtr> @PpEntity { get => new NativePointer<IntPtr>(SdkMemory.Read<IntPtr>(Pointer+4)); set { SdkMemory.Write(Pointer+4,value.Pointer); } }
}
