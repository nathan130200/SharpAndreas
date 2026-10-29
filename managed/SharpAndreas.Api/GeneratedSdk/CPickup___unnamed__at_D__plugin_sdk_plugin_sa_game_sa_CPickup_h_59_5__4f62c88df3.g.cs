// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CPickup___unnamed__at_D__plugin_sdk_plugin_sa_game_sa_CPickup_h_59_5__4f62c88df3 : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=1;
    public CPickup___unnamed__at_D__plugin_sdk_plugin_sa_game_sa_CPickup_h_59_5__4f62c88df3(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("bDisabled")]
    public byte @Disabled { get => (byte)SdkMemory.ReadBits(Pointer,0,1); set { SdkMemory.WriteBits(Pointer,0,1,unchecked((ulong)value)); } }
    [NativeMember("bEmpty")]
    public byte @Empty { get => (byte)SdkMemory.ReadBits(Pointer,1,1); set { SdkMemory.WriteBits(Pointer,1,1,unchecked((ulong)value)); } }
    [NativeMember("bHelpMessageDisplayed")]
    public byte @HelpMessageDisplayed { get => (byte)SdkMemory.ReadBits(Pointer,2,1); set { SdkMemory.WriteBits(Pointer,2,1,unchecked((ulong)value)); } }
    [NativeMember("bVisible")]
    public byte @Visible { get => (byte)SdkMemory.ReadBits(Pointer,3,1); set { SdkMemory.WriteBits(Pointer,3,1,unchecked((ulong)value)); } }
    [NativeMember("nPropertyTextIndex")]
    public byte @PropertyTextIndex { get => (byte)SdkMemory.ReadBits(Pointer,4,3); set { SdkMemory.WriteBits(Pointer,4,3,unchecked((ulong)value)); } }
}
