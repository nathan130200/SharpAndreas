// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class RpTriStripData : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=12;
    public RpTriStripData(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("ignoreWinding")]
    public int @IgnoreWinding { get => SdkMemory.Read<int >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("stripCB")]
    public NativeFunctionPointer<Callback_07a61bcc9185> @StripCB { get => new NativeFunctionPointer<Callback_07a61bcc9185>(SdkMemory.Read<IntPtr>(Pointer+4)); set { SdkMemory.Write(Pointer+4,value.Pointer); } }
    [NativeMember("data")]
    public NativePointer<IntPtr> @Data { get => new NativePointer<IntPtr>(SdkMemory.Read<IntPtr>(Pointer+8)); set { SdkMemory.Write(Pointer+8,value.Pointer); } }
}
