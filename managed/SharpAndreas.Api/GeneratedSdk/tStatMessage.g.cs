// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class tStatMessage : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=16;
    public tStatMessage(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("stat_num")]
    public short @StatCount { get => SdkMemory.Read<short >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("displayed")]
    public bool @Displayed { get => SdkMemory.Read<bool >(Pointer+2); set { SdkMemory.Write(Pointer+2,value); } }
    [NativeMember("condition")]
    public byte @Condition { get => SdkMemory.Read<byte >(Pointer+3); set { SdkMemory.Write(Pointer+3,value); } }
    [NativeMember("value")]
    public float @Value { get => SdkMemory.Read<float >(Pointer+4); set { SdkMemory.Write(Pointer+4,value); } }
    [NativeMember("text_id")]
    public NativeArray<sbyte> @TextId { get => new NativeArray<sbyte>(Pointer+8,8); }
}
