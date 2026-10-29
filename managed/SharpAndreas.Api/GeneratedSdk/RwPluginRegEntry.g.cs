// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class RwPluginRegEntry : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=60;
    public RwPluginRegEntry(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("offset")]
    public int @Offset { get => SdkMemory.Read<int >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("size")]
    public int @Size { get => SdkMemory.Read<int >(Pointer+4); set { SdkMemory.Write(Pointer+4,value); } }
    [NativeMember("pluginID")]
    public uint @PluginID { get => SdkMemory.Read<uint >(Pointer+8); set { SdkMemory.Write(Pointer+8,value); } }
    [NativeMember("readCB")]
    public NativeFunctionPointer<Callback_0b9b6a90ed1d> @ReadCB { get => new NativeFunctionPointer<Callback_0b9b6a90ed1d>(SdkMemory.Read<IntPtr>(Pointer+12)); set { SdkMemory.Write(Pointer+12,value.Pointer); } }
    [NativeMember("writeCB")]
    public NativeFunctionPointer<Callback_46d51c85b91f> @WriteCB { get => new NativeFunctionPointer<Callback_46d51c85b91f>(SdkMemory.Read<IntPtr>(Pointer+16)); set { SdkMemory.Write(Pointer+16,value.Pointer); } }
    [NativeMember("getSizeCB")]
    public NativeFunctionPointer<Callback_ecd7b6eb345b> @GetSizeCB { get => new NativeFunctionPointer<Callback_ecd7b6eb345b>(SdkMemory.Read<IntPtr>(Pointer+20)); set { SdkMemory.Write(Pointer+20,value.Pointer); } }
    [NativeMember("alwaysCB")]
    public NativeFunctionPointer<Callback_e1dc64c68e2a> @AlwaysCB { get => new NativeFunctionPointer<Callback_e1dc64c68e2a>(SdkMemory.Read<IntPtr>(Pointer+24)); set { SdkMemory.Write(Pointer+24,value.Pointer); } }
    [NativeMember("rightsCB")]
    public NativeFunctionPointer<Callback_58d6c755ae65> @RightsCB { get => new NativeFunctionPointer<Callback_58d6c755ae65>(SdkMemory.Read<IntPtr>(Pointer+28)); set { SdkMemory.Write(Pointer+28,value.Pointer); } }
    [NativeMember("constructCB")]
    public NativeFunctionPointer<Callback_93035bda2af2> @ConstructCB { get => new NativeFunctionPointer<Callback_93035bda2af2>(SdkMemory.Read<IntPtr>(Pointer+32)); set { SdkMemory.Write(Pointer+32,value.Pointer); } }
    [NativeMember("destructCB")]
    public NativeFunctionPointer<Callback_93035bda2af2> @DestructCB { get => new NativeFunctionPointer<Callback_93035bda2af2>(SdkMemory.Read<IntPtr>(Pointer+36)); set { SdkMemory.Write(Pointer+36,value.Pointer); } }
    [NativeMember("copyCB")]
    public NativeFunctionPointer<Callback_e3fa16b16571> @CopyCB { get => new NativeFunctionPointer<Callback_e3fa16b16571>(SdkMemory.Read<IntPtr>(Pointer+40)); set { SdkMemory.Write(Pointer+40,value.Pointer); } }
    [NativeMember("errStrCB")]
    public NativeFunctionPointer<Callback_0e04dcbaa433> @ErrStrCB { get => new NativeFunctionPointer<Callback_0e04dcbaa433>(SdkMemory.Read<IntPtr>(Pointer+44)); set { SdkMemory.Write(Pointer+44,value.Pointer); } }
    [NativeMember("nextRegEntry")]
    public RwPluginRegEntry? @NextRegEntry { get => SdkMemory.Read<IntPtr>(Pointer+48) == IntPtr.Zero ? null : new RwPluginRegEntry(SdkMemory.Read<IntPtr>(Pointer+48)); set { SdkMemory.Write(Pointer+48,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("prevRegEntry")]
    public RwPluginRegEntry? @PrevRegEntry { get => SdkMemory.Read<IntPtr>(Pointer+52) == IntPtr.Zero ? null : new RwPluginRegEntry(SdkMemory.Read<IntPtr>(Pointer+52)); set { SdkMemory.Write(Pointer+52,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("parentRegistry")]
    public RwPluginRegistry? @ParentRegistry { get => SdkMemory.Read<IntPtr>(Pointer+56) == IntPtr.Zero ? null : new RwPluginRegistry(SdkMemory.Read<IntPtr>(Pointer+56)); set { SdkMemory.Write(Pointer+56,value?.Pointer ?? IntPtr.Zero); } }
}
