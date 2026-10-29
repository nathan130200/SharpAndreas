// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class tAtomicVisibilityPlugin : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=4;
    public tAtomicVisibilityPlugin(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_wModelId")]
    public short @ModelId { get => SdkMemory.Read<short >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("m_wFlags")]
    public ushort @Flags { get => SdkMemory.Read<ushort >(Pointer+2); set { SdkMemory.Write(Pointer+2,value); } }
}
