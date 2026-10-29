// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CRegisteredShadow___unnamed__at_D__plugin_sdk_plugin_sa_game_sa_CShado_2bbce76088 : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=1;
    public CRegisteredShadow___unnamed__at_D__plugin_sdk_plugin_sa_game_sa_CShado_2bbce76088(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("bDrawOnWater")]
    public byte @DrawOnWater { get => (byte)SdkMemory.ReadBits(Pointer,0,1); set { SdkMemory.WriteBits(Pointer,0,1,unchecked((ulong)value)); } }
    [NativeMember("bIgnoreMapObjects")]
    public byte @IgnoreMapObjects { get => (byte)SdkMemory.ReadBits(Pointer,1,1); set { SdkMemory.WriteBits(Pointer,1,1,unchecked((ulong)value)); } }
    [NativeMember("bDrawOnBuildings")]
    public byte @DrawOnBuildings { get => (byte)SdkMemory.ReadBits(Pointer,2,1); set { SdkMemory.WriteBits(Pointer,2,1,unchecked((ulong)value)); } }
}
