// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class RwStringFunctions : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=68;
    public RwStringFunctions(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("vecSprintf")]
    public NativeFunctionPointer<Callback_6f2c269335d8> @Sprintf { get => new NativeFunctionPointer<Callback_6f2c269335d8>(SdkMemory.Read<IntPtr>(Pointer+0)); set { SdkMemory.Write(Pointer+0,value.Pointer); } }
    [NativeMember("vecVsprintf")]
    public NativeFunctionPointer<Callback_76774c316162> @Vsprintf { get => new NativeFunctionPointer<Callback_76774c316162>(SdkMemory.Read<IntPtr>(Pointer+4)); set { SdkMemory.Write(Pointer+4,value.Pointer); } }
    [NativeMember("vecStrcpy")]
    public NativeFunctionPointer<Callback_e17ca143d4fb> @Strcpy { get => new NativeFunctionPointer<Callback_e17ca143d4fb>(SdkMemory.Read<IntPtr>(Pointer+8)); set { SdkMemory.Write(Pointer+8,value.Pointer); } }
    [NativeMember("vecStrncpy")]
    public NativeFunctionPointer<Callback_a4aca5814462> @Strncpy { get => new NativeFunctionPointer<Callback_a4aca5814462>(SdkMemory.Read<IntPtr>(Pointer+12)); set { SdkMemory.Write(Pointer+12,value.Pointer); } }
    [NativeMember("vecStrcat")]
    public NativeFunctionPointer<Callback_e17ca143d4fb> @Strcat { get => new NativeFunctionPointer<Callback_e17ca143d4fb>(SdkMemory.Read<IntPtr>(Pointer+16)); set { SdkMemory.Write(Pointer+16,value.Pointer); } }
    [NativeMember("vecStrncat")]
    public NativeFunctionPointer<Callback_a4aca5814462> @Strncat { get => new NativeFunctionPointer<Callback_a4aca5814462>(SdkMemory.Read<IntPtr>(Pointer+20)); set { SdkMemory.Write(Pointer+20,value.Pointer); } }
    [NativeMember("vecStrrchr")]
    public NativeFunctionPointer<Callback_9a0c3e1678e3> @Strrchr { get => new NativeFunctionPointer<Callback_9a0c3e1678e3>(SdkMemory.Read<IntPtr>(Pointer+24)); set { SdkMemory.Write(Pointer+24,value.Pointer); } }
    [NativeMember("vecStrchr")]
    public NativeFunctionPointer<Callback_9a0c3e1678e3> @Strchr { get => new NativeFunctionPointer<Callback_9a0c3e1678e3>(SdkMemory.Read<IntPtr>(Pointer+28)); set { SdkMemory.Write(Pointer+28,value.Pointer); } }
    [NativeMember("vecStrstr")]
    public NativeFunctionPointer<Callback_7cd6f50bfc65> @Strstr { get => new NativeFunctionPointer<Callback_7cd6f50bfc65>(SdkMemory.Read<IntPtr>(Pointer+32)); set { SdkMemory.Write(Pointer+32,value.Pointer); } }
    [NativeMember("vecStrcmp")]
    public NativeFunctionPointer<Callback_575778a13fa9> @Strcmp { get => new NativeFunctionPointer<Callback_575778a13fa9>(SdkMemory.Read<IntPtr>(Pointer+36)); set { SdkMemory.Write(Pointer+36,value.Pointer); } }
    [NativeMember("vecStrncmp")]
    public NativeFunctionPointer<Callback_21bc0da70774> @Strncmp { get => new NativeFunctionPointer<Callback_21bc0da70774>(SdkMemory.Read<IntPtr>(Pointer+40)); set { SdkMemory.Write(Pointer+40,value.Pointer); } }
    [NativeMember("vecStricmp")]
    public NativeFunctionPointer<Callback_575778a13fa9> @Stricmp { get => new NativeFunctionPointer<Callback_575778a13fa9>(SdkMemory.Read<IntPtr>(Pointer+44)); set { SdkMemory.Write(Pointer+44,value.Pointer); } }
    [NativeMember("vecStrlen")]
    public NativeFunctionPointer<Callback_9d265e12e988> @Strlen { get => new NativeFunctionPointer<Callback_9d265e12e988>(SdkMemory.Read<IntPtr>(Pointer+48)); set { SdkMemory.Write(Pointer+48,value.Pointer); } }
    [NativeMember("vecStrupr")]
    public NativeFunctionPointer<Callback_2d80cc8a1968> @Strupr { get => new NativeFunctionPointer<Callback_2d80cc8a1968>(SdkMemory.Read<IntPtr>(Pointer+52)); set { SdkMemory.Write(Pointer+52,value.Pointer); } }
    [NativeMember("vecStrlwr")]
    public NativeFunctionPointer<Callback_2d80cc8a1968> @Strlwr { get => new NativeFunctionPointer<Callback_2d80cc8a1968>(SdkMemory.Read<IntPtr>(Pointer+56)); set { SdkMemory.Write(Pointer+56,value.Pointer); } }
    [NativeMember("vecStrtok")]
    public NativeFunctionPointer<Callback_e17ca143d4fb> @Strtok { get => new NativeFunctionPointer<Callback_e17ca143d4fb>(SdkMemory.Read<IntPtr>(Pointer+60)); set { SdkMemory.Write(Pointer+60,value.Pointer); } }
    [NativeMember("vecSscanf")]
    public NativeFunctionPointer<Callback_0b9edc65c6dc> @Sscanf { get => new NativeFunctionPointer<Callback_0b9edc65c6dc>(SdkMemory.Read<IntPtr>(Pointer+64)); set { SdkMemory.Write(Pointer+64,value.Pointer); } }
}
