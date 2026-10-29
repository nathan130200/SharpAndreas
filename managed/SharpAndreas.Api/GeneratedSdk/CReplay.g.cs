// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CReplay : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=1;
    public CReplay(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("Mode")]
    public static sbyte @Mode { get => SdkMemory.Read<sbyte >(new IntPtr(0xA43088)); set { SdkMemory.Write(new IntPtr(0xA43088),value); } }
}
