// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CKeyGen : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=1;
    public CKeyGen(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("keyTable")]
    public static NativePointer<uint> @KeyTable { get => new NativePointer<uint>(new IntPtr(0x8CD068)); }
    public static uint @GetKey(NativePointer<sbyte> @str,int @size) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3018 >(3018)(@str.Pointer,@size); return __sdkResult; }
    public static uint @GetKey(NativePointer<sbyte> @str) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3019 >(3019)(@str.Pointer); return __sdkResult; }
    public static uint @GetUppercaseKey(NativePointer<sbyte> @str) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3020 >(3020)(@str.Pointer); return __sdkResult; }
    public static uint @AppendStringToKey(uint @key,NativePointer<sbyte> @str) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3021 >(3021)(@key,@str.Pointer); return __sdkResult; }
}
