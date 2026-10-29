// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class RwFileFunctions : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=44;
    public RwFileFunctions(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("rwfexist")]
    public NativeFunctionPointer<Callback_b187cf6bf517> @Rwfexist { get => new NativeFunctionPointer<Callback_b187cf6bf517>(SdkMemory.Read<IntPtr>(Pointer+0)); set { SdkMemory.Write(Pointer+0,value.Pointer); } }
    [NativeMember("rwfopen")]
    public NativeFunctionPointer<Callback_a9d25326eb57> @Rwfopen { get => new NativeFunctionPointer<Callback_a9d25326eb57>(SdkMemory.Read<IntPtr>(Pointer+4)); set { SdkMemory.Write(Pointer+4,value.Pointer); } }
    [NativeMember("rwfclose")]
    public NativeFunctionPointer<Callback_153508986290> @Rwfclose { get => new NativeFunctionPointer<Callback_153508986290>(SdkMemory.Read<IntPtr>(Pointer+8)); set { SdkMemory.Write(Pointer+8,value.Pointer); } }
    [NativeMember("rwfread")]
    public NativeFunctionPointer<Callback_ed3e373c33c0> @Rwfread { get => new NativeFunctionPointer<Callback_ed3e373c33c0>(SdkMemory.Read<IntPtr>(Pointer+12)); set { SdkMemory.Write(Pointer+12,value.Pointer); } }
    [NativeMember("rwfwrite")]
    public NativeFunctionPointer<Callback_7880ef26106f> @Rwfwrite { get => new NativeFunctionPointer<Callback_7880ef26106f>(SdkMemory.Read<IntPtr>(Pointer+16)); set { SdkMemory.Write(Pointer+16,value.Pointer); } }
    [NativeMember("rwfgets")]
    public NativeFunctionPointer<Callback_7ee29ba0b6ea> @Rwfgets { get => new NativeFunctionPointer<Callback_7ee29ba0b6ea>(SdkMemory.Read<IntPtr>(Pointer+20)); set { SdkMemory.Write(Pointer+20,value.Pointer); } }
    [NativeMember("rwfputs")]
    public NativeFunctionPointer<Callback_5116de01d495> @Rwfputs { get => new NativeFunctionPointer<Callback_5116de01d495>(SdkMemory.Read<IntPtr>(Pointer+24)); set { SdkMemory.Write(Pointer+24,value.Pointer); } }
    [NativeMember("rwfeof")]
    public NativeFunctionPointer<Callback_153508986290> @Rwfeof { get => new NativeFunctionPointer<Callback_153508986290>(SdkMemory.Read<IntPtr>(Pointer+28)); set { SdkMemory.Write(Pointer+28,value.Pointer); } }
    [NativeMember("rwfseek")]
    public NativeFunctionPointer<Callback_47aa624b3e32> @Rwfseek { get => new NativeFunctionPointer<Callback_47aa624b3e32>(SdkMemory.Read<IntPtr>(Pointer+32)); set { SdkMemory.Write(Pointer+32,value.Pointer); } }
    [NativeMember("rwfflush")]
    public NativeFunctionPointer<Callback_153508986290> @Rwfflush { get => new NativeFunctionPointer<Callback_153508986290>(SdkMemory.Read<IntPtr>(Pointer+36)); set { SdkMemory.Write(Pointer+36,value.Pointer); } }
    [NativeMember("rwftell")]
    public NativeFunctionPointer<Callback_153508986290> @Rwftell { get => new NativeFunctionPointer<Callback_153508986290>(SdkMemory.Read<IntPtr>(Pointer+40)); set { SdkMemory.Write(Pointer+40,value.Pointer); } }
}
