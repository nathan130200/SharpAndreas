// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class RwStreamFile : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=4;
    public RwStreamFile(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("fpFile")]
    public NativePointer<IntPtr> @FpFile { get => new NativePointer<IntPtr>(SdkMemory.Read<IntPtr>(Pointer+0)); set { SdkMemory.Write(Pointer+0,value.Pointer); } }
    [NativeMember("constfpFile")]
    public NativePointer<IntPtr> @ConstfpFile { get => new NativePointer<IntPtr>(SdkMemory.Read<IntPtr>(Pointer+0)); }
}
