// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CBoat___unnamed__at_D__plugin_sdk_plugin_sa_game_sa_CBoat_h_36_5__fe2e85b57c : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=1;
    public CBoat___unnamed__at_D__plugin_sdk_plugin_sa_game_sa_CBoat_h_36_5__fe2e85b57c(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("bOnWater")]
    public byte @OnWater { get => (byte)SdkMemory.ReadBits(Pointer,0,1); set { SdkMemory.WriteBits(Pointer,0,1,unchecked((ulong)value)); } }
    [NativeMember("bMovingOnWater")]
    public byte @MovingOnWater { get => (byte)SdkMemory.ReadBits(Pointer,1,1); set { SdkMemory.WriteBits(Pointer,1,1,unchecked((ulong)value)); } }
    [NativeMember("bAnchored")]
    public byte @Anchored { get => (byte)SdkMemory.ReadBits(Pointer,2,1); set { SdkMemory.WriteBits(Pointer,2,1,unchecked((ulong)value)); } }
}
