// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class RwSplitFixed : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=4;
    public RwSplitFixed(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("fractional")]
    public ushort @Fractional { get => SdkMemory.Read<ushort >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("integral")]
    public short @Integral { get => SdkMemory.Read<short >(Pointer+2); set { SdkMemory.Write(Pointer+2,value); } }
}
