// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CEntityScanner : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=80;
    public CEntityScanner(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("field_4")]
    public int @Field4 { get => SdkMemory.Read<int >(Pointer+4); set { SdkMemory.Write(Pointer+4,value); } }
    [NativeMember("m_nCount")]
    public uint @Count { get => SdkMemory.Read<uint >(Pointer+8); set { SdkMemory.Write(Pointer+8,value); } }
    [NativeMember("m_apEntities")]
    public NativeArray<IntPtr> @Entities { get => new NativeArray<IntPtr>(Pointer+12,16); }
    [NativeMember("field_4C")]
    public int @Field4C { get => SdkMemory.Read<int >(Pointer+76); set { SdkMemory.Write(Pointer+76,value); } }
}
