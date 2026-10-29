// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CEventScanner : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=212;
    public CEventScanner(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("field_0")]
    public int @Field0 { get => SdkMemory.Read<int >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("field_4")]
    public CTaskTimer @Field4 { get => new CTaskTimer(Pointer+4); set { SdkMemory.Copy(value.Pointer,Pointer+4,12); } }
    [NativeMember("field_10")]
    public CTaskTimer @Field10 { get => new CTaskTimer(Pointer+16); set { SdkMemory.Copy(value.Pointer,Pointer+16,12); } }
    [NativeMember("m_attractorScanner")]
    public CAttractorScanner @AttractorScanner { get => new CAttractorScanner(Pointer+28); set { SdkMemory.Copy(value.Pointer,Pointer+28,144); } }
    [NativeMember("field_AC")]
    public CTaskTimer @FieldAC { get => new CTaskTimer(Pointer+172); set { SdkMemory.Copy(value.Pointer,Pointer+172,12); } }
    [NativeMember("field_B8")]
    public sbyte @FieldB8 { get => SdkMemory.Read<sbyte >(Pointer+184); set { SdkMemory.Write(Pointer+184,value); } }
    [NativeMember("field_B9")]
    public sbyte @FieldB9 { get => SdkMemory.Read<sbyte >(Pointer+185); set { SdkMemory.Write(Pointer+185,value); } }
    [NativeMember("field_BA")]
    public sbyte @FieldBA { get => SdkMemory.Read<sbyte >(Pointer+186); set { SdkMemory.Write(Pointer+186,value); } }
    [NativeMember("field_BB")]
    public sbyte @FieldBB { get => SdkMemory.Read<sbyte >(Pointer+187); set { SdkMemory.Write(Pointer+187,value); } }
    [NativeMember("field_BC")]
    public CTaskTimer @FieldBC { get => new CTaskTimer(Pointer+188); set { SdkMemory.Copy(value.Pointer,Pointer+188,12); } }
    [NativeMember("field_C8")]
    public CTaskTimer @FieldC8 { get => new CTaskTimer(Pointer+200); set { SdkMemory.Copy(value.Pointer,Pointer+200,12); } }
}
