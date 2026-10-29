// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CBankLkup : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=12;
    public CBankLkup(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_nPakFileNumber")]
    public sbyte @PakFileNumber { get => SdkMemory.Read<sbyte >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("__pad0")]
    public NativeArray<sbyte> @Pad0 { get => new NativeArray<sbyte>(Pointer+1,3); }
    [NativeMember("m_nOffset")]
    public int @Offset { get => SdkMemory.Read<int >(Pointer+4); set { SdkMemory.Write(Pointer+4,value); } }
    [NativeMember("m_nLength")]
    public int @Length { get => SdkMemory.Read<int >(Pointer+8); set { SdkMemory.Write(Pointer+8,value); } }
}
