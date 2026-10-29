// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CCollisionData___unnamed__at_D__plugin_sdk_plugin_sa_game_sa_CCollisio_3fbeec9a34 : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=1;
    public CCollisionData___unnamed__at_D__plugin_sdk_plugin_sa_game_sa_CCollisio_3fbeec9a34(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("bUsesDisks")]
    public byte @UsesDisks { get => (byte)SdkMemory.ReadBits(Pointer,0,1); set { SdkMemory.WriteBits(Pointer,0,1,unchecked((ulong)value)); } }
    [NativeMember("bNotEmpty")]
    public byte @NotEmpty { get => (byte)SdkMemory.ReadBits(Pointer,1,1); set { SdkMemory.WriteBits(Pointer,1,1,unchecked((ulong)value)); } }
    [NativeMember("b03")]
    public byte @B03 { get => (byte)SdkMemory.ReadBits(Pointer,2,1); set { SdkMemory.WriteBits(Pointer,2,1,unchecked((ulong)value)); } }
    [NativeMember("bHasFaceGroups")]
    public byte @HasFaceGroups { get => (byte)SdkMemory.ReadBits(Pointer,3,1); set { SdkMemory.WriteBits(Pointer,3,1,unchecked((ulong)value)); } }
    [NativeMember("bHasShadow")]
    public byte @HasShadow { get => (byte)SdkMemory.ReadBits(Pointer,4,1); set { SdkMemory.WriteBits(Pointer,4,1,unchecked((ulong)value)); } }
}
