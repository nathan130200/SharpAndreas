// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CShopping__StatModifiers : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=4;
    public CShopping__StatModifiers(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("modifiers")]
    public NativeObjectArray<CShopping__StatModifiers___unnamed__at_D__plugin_sdk_plugin_sa_game_sa_0e51c89554> @Modifiers { get => new NativeObjectArray<CShopping__StatModifiers___unnamed__at_D__plugin_sdk_plugin_sa_game_sa_0e51c89554>(Pointer+0,2,2); }
}
