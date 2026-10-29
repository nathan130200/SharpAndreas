// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class RwMemoryFunctions : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=16;
    public RwMemoryFunctions(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("rwmalloc")]
    public NativeFunctionPointer<Callback_7924e3630557> @Rwmalloc { get => new NativeFunctionPointer<Callback_7924e3630557>(SdkMemory.Read<IntPtr>(Pointer+0)); set { SdkMemory.Write(Pointer+0,value.Pointer); } }
    [NativeMember("rwfree")]
    public NativeFunctionPointer<Callback_4128a8474a05> @Rwfree { get => new NativeFunctionPointer<Callback_4128a8474a05>(SdkMemory.Read<IntPtr>(Pointer+4)); set { SdkMemory.Write(Pointer+4,value.Pointer); } }
    [NativeMember("rwrealloc")]
    public NativeFunctionPointer<Callback_b7e3e9835ef5> @Rwrealloc { get => new NativeFunctionPointer<Callback_b7e3e9835ef5>(SdkMemory.Read<IntPtr>(Pointer+8)); set { SdkMemory.Write(Pointer+8,value.Pointer); } }
    [NativeMember("rwcalloc")]
    public NativeFunctionPointer<Callback_151741d75961> @Rwcalloc { get => new NativeFunctionPointer<Callback_151741d75961>(SdkMemory.Read<IntPtr>(Pointer+12)); set { SdkMemory.Write(Pointer+12,value.Pointer); } }
}
