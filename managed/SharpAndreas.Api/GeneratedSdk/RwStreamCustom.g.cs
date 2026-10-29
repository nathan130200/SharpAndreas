// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class RwStreamCustom : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=20;
    public RwStreamCustom(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("sfnclose")]
    public NativeFunctionPointer<Callback_153508986290> @Sfnclose { get => new NativeFunctionPointer<Callback_153508986290>(SdkMemory.Read<IntPtr>(Pointer+0)); set { SdkMemory.Write(Pointer+0,value.Pointer); } }
    [NativeMember("sfnread")]
    public NativeFunctionPointer<Callback_3ca1031f12e4> @Sfnread { get => new NativeFunctionPointer<Callback_3ca1031f12e4>(SdkMemory.Read<IntPtr>(Pointer+4)); set { SdkMemory.Write(Pointer+4,value.Pointer); } }
    [NativeMember("sfnwrite")]
    public NativeFunctionPointer<Callback_5092702a9790> @Sfnwrite { get => new NativeFunctionPointer<Callback_5092702a9790>(SdkMemory.Read<IntPtr>(Pointer+8)); set { SdkMemory.Write(Pointer+8,value.Pointer); } }
    [NativeMember("sfnskip")]
    public NativeFunctionPointer<Callback_80167218d411> @Sfnskip { get => new NativeFunctionPointer<Callback_80167218d411>(SdkMemory.Read<IntPtr>(Pointer+12)); set { SdkMemory.Write(Pointer+12,value.Pointer); } }
    [NativeMember("data")]
    public NativePointer<IntPtr> @Data { get => new NativePointer<IntPtr>(SdkMemory.Read<IntPtr>(Pointer+16)); set { SdkMemory.Write(Pointer+16,value.Pointer); } }
}
