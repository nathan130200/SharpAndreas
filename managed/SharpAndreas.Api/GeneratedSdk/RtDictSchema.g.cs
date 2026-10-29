// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class RtDictSchema : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=52;
    public RtDictSchema(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("name")]
    public NativePointer<sbyte> @Name { get => new NativePointer<sbyte>(SdkMemory.Read<IntPtr>(Pointer+0)); }
    [NativeMember("dictChunkType")]
    public uint @DictChunkType { get => SdkMemory.Read<uint >(Pointer+4); set { SdkMemory.Write(Pointer+4,value); } }
    [NativeMember("entryChunkType")]
    public uint @EntryChunkType { get => SdkMemory.Read<uint >(Pointer+8); set { SdkMemory.Write(Pointer+8,value); } }
    [NativeMember("compatibilityVersion")]
    public uint @CompatibilityVersion { get => SdkMemory.Read<uint >(Pointer+12); set { SdkMemory.Write(Pointer+12,value); } }
    [NativeMember("dictionaries")]
    public RwSList? @Dictionaries { get => SdkMemory.Read<IntPtr>(Pointer+16) == IntPtr.Zero ? null : new RwSList(SdkMemory.Read<IntPtr>(Pointer+16)); set { SdkMemory.Write(Pointer+16,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("current")]
    public RtDict? @Current { get => SdkMemory.Read<IntPtr>(Pointer+20) == IntPtr.Zero ? null : new RtDict(SdkMemory.Read<IntPtr>(Pointer+20)); set { SdkMemory.Write(Pointer+20,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("addRefCB")]
    public NativeFunctionPointer<Callback_0e04dcbaa433> @AddRefCB { get => new NativeFunctionPointer<Callback_0e04dcbaa433>(SdkMemory.Read<IntPtr>(Pointer+24)); set { SdkMemory.Write(Pointer+24,value.Pointer); } }
    [NativeMember("destroyCB")]
    public NativeFunctionPointer<Callback_153508986290> @DestroyCB { get => new NativeFunctionPointer<Callback_153508986290>(SdkMemory.Read<IntPtr>(Pointer+28)); set { SdkMemory.Write(Pointer+28,value.Pointer); } }
    [NativeMember("getNameCB")]
    public NativeFunctionPointer<Callback_e009a650ac13> @GetNameCB { get => new NativeFunctionPointer<Callback_e009a650ac13>(SdkMemory.Read<IntPtr>(Pointer+32)); set { SdkMemory.Write(Pointer+32,value.Pointer); } }
    [NativeMember("streamGetSizeCB")]
    public NativeFunctionPointer<Callback_c4c8f47517e6> @StreamGetSizeCB { get => new NativeFunctionPointer<Callback_c4c8f47517e6>(SdkMemory.Read<IntPtr>(Pointer+36)); set { SdkMemory.Write(Pointer+36,value.Pointer); } }
    [NativeMember("streamReadCB")]
    public NativeFunctionPointer<Callback_59a70066f027> @StreamReadCB { get => new NativeFunctionPointer<Callback_59a70066f027>(SdkMemory.Read<IntPtr>(Pointer+40)); set { SdkMemory.Write(Pointer+40,value.Pointer); } }
    [NativeMember("streamReadCompatibilityCB")]
    public NativeFunctionPointer<Callback_6102cd92e127> @StreamReadCompatibilityCB { get => new NativeFunctionPointer<Callback_6102cd92e127>(SdkMemory.Read<IntPtr>(Pointer+44)); set { SdkMemory.Write(Pointer+44,value.Pointer); } }
    [NativeMember("streamWriteCB")]
    public NativeFunctionPointer<Callback_6de103fbe10b> @StreamWriteCB { get => new NativeFunctionPointer<Callback_6de103fbe10b>(SdkMemory.Read<IntPtr>(Pointer+48)); set { SdkMemory.Write(Pointer+48,value.Pointer); } }
}
