// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CShopping__StatModifiers___unnamed__at_D__plugin_sdk_plugin_sa_game_sa_0e51c89554 : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=2;
    public CShopping__StatModifiers___unnamed__at_D__plugin_sdk_plugin_sa_game_sa_0e51c89554(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("statIndex")]
    public sbyte @StatIndex { get => SdkMemory.Read<sbyte >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("change")]
    public sbyte @Change { get => SdkMemory.Read<sbyte >(Pointer+1); set { SdkMemory.Write(Pointer+1,value); } }
}
