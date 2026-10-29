// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class FxSystem_c___unnamed__at_D__plugin_sdk_plugin_sa_game_sa_FxSystem_c_h__a2c932bb3a : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=1;
    public FxSystem_c___unnamed__at_D__plugin_sdk_plugin_sa_game_sa_FxSystem_c_h__a2c932bb3a(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("bOwnedParentMatrix")]
    public byte @OwnedParentMatrix { get => (byte)SdkMemory.ReadBits(Pointer,0,1); set { SdkMemory.WriteBits(Pointer,0,1,unchecked((ulong)value)); } }
    [NativeMember("bLocalParticles")]
    public byte @LocalParticles { get => (byte)SdkMemory.ReadBits(Pointer,1,1); set { SdkMemory.WriteBits(Pointer,1,1,unchecked((ulong)value)); } }
    [NativeMember("bZTestEnabled")]
    public byte @ZTestEnabled { get => (byte)SdkMemory.ReadBits(Pointer,2,1); set { SdkMemory.WriteBits(Pointer,2,1,unchecked((ulong)value)); } }
    [NativeMember("bUnknown4")]
    public byte @Unknown4 { get => (byte)SdkMemory.ReadBits(Pointer,3,1); set { SdkMemory.WriteBits(Pointer,3,1,unchecked((ulong)value)); } }
    [NativeMember("bUnknown5")]
    public byte @Unknown5 { get => (byte)SdkMemory.ReadBits(Pointer,4,1); set { SdkMemory.WriteBits(Pointer,4,1,unchecked((ulong)value)); } }
    [NativeMember("bMustCreatePtrs")]
    public byte @MustCreatePtrs { get => (byte)SdkMemory.ReadBits(Pointer,5,1); set { SdkMemory.WriteBits(Pointer,5,1,unchecked((ulong)value)); } }
}
