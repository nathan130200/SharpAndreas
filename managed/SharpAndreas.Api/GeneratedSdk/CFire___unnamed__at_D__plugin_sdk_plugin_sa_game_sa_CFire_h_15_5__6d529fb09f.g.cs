// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CFire___unnamed__at_D__plugin_sdk_plugin_sa_game_sa_CFire_h_15_5__6d529fb09f : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=1;
    public CFire___unnamed__at_D__plugin_sdk_plugin_sa_game_sa_CFire_h_15_5__6d529fb09f(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("bActive")]
    public byte @Active { get => (byte)SdkMemory.ReadBits(Pointer,0,1); set { SdkMemory.WriteBits(Pointer,0,1,unchecked((ulong)value)); } }
    [NativeMember("bCreatedByScript")]
    public byte @CreatedByScript { get => (byte)SdkMemory.ReadBits(Pointer,1,1); set { SdkMemory.WriteBits(Pointer,1,1,unchecked((ulong)value)); } }
    [NativeMember("bMakesNoise")]
    public byte @MakesNoise { get => (byte)SdkMemory.ReadBits(Pointer,2,1); set { SdkMemory.WriteBits(Pointer,2,1,unchecked((ulong)value)); } }
    [NativeMember("bBeingExtinguished")]
    public byte @BeingExtinguished { get => (byte)SdkMemory.ReadBits(Pointer,3,1); set { SdkMemory.WriteBits(Pointer,3,1,unchecked((ulong)value)); } }
    [NativeMember("bFirstGeneration")]
    public byte @FirstGeneration { get => (byte)SdkMemory.ReadBits(Pointer,4,1); set { SdkMemory.WriteBits(Pointer,4,1,unchecked((ulong)value)); } }
}
