// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class tPreviousBrief : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=32;
    public tPreviousBrief(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_pText")]
    public NativePointer<sbyte> @Text { get => new NativePointer<sbyte>(SdkMemory.Read<IntPtr>(Pointer+0)); set { SdkMemory.Write(Pointer+0,value.Pointer); } }
    [NativeMember("m_nNumber")]
    public NativeArray<int> @Number { get => new NativeArray<int>(Pointer+4,6); }
    [NativeMember("m_pString")]
    public NativePointer<sbyte> @String { get => new NativePointer<sbyte>(SdkMemory.Read<IntPtr>(Pointer+28)); set { SdkMemory.Write(Pointer+28,value.Pointer); } }
}
