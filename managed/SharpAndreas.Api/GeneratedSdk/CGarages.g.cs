// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CGarages : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=1;
    public CGarages(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("MessageIDString")]
    public static NativePointer<sbyte> @MessageIDString { get => new NativePointer<sbyte>(new IntPtr(0x96C014)); }
    [NativeMember("MessageNumberInString")]
    public static int @MessageNumberInString { get => SdkMemory.Read<int >(new IntPtr(0x96C010)); set { SdkMemory.Write(new IntPtr(0x96C010),value); } }
    [NativeMember("MessageNumberInString2")]
    public static int @MessageNumberInString2 { get => SdkMemory.Read<int >(new IntPtr(0x96C00C)); set { SdkMemory.Write(new IntPtr(0x96C00C),value); } }
    public static bool @Load() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2890 >(2890)(); return __sdkResult != 0; }
    public static bool @Save() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2891 >(2891)(); return __sdkResult != 0; }
}
