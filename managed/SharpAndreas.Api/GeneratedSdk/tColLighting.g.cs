// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class tColLighting : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=1;
    public tColLighting(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("day")]
    public byte @Day { get => (byte)SdkMemory.ReadBits(Pointer,0,4); set { SdkMemory.WriteBits(Pointer,0,4,unchecked((ulong)value)); } }
    [NativeMember("night")]
    public byte @Night { get => (byte)SdkMemory.ReadBits(Pointer,4,4); set { SdkMemory.WriteBits(Pointer,4,4,unchecked((ulong)value)); } }
}
