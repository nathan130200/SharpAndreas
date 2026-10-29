// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class tScriptRoadBlocks : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=28;
    public tScriptRoadBlocks(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("cornerA")]
    public CVector @CornerA { get => new CVector(Pointer+0); set { SdkMemory.Copy(value.Pointer,Pointer+0,12); } }
    [NativeMember("cornerB")]
    public CVector @CornerB { get => new CVector(Pointer+12); set { SdkMemory.Copy(value.Pointer,Pointer+12,12); } }
    [NativeMember("m_nActive")]
    public sbyte @Active { get => SdkMemory.Read<sbyte >(Pointer+24); set { SdkMemory.Write(Pointer+24,value); } }
    [NativeMember("m_bIsCreated")]
    public sbyte @IsCreated { get => SdkMemory.Read<sbyte >(Pointer+25); set { SdkMemory.Write(Pointer+25,value); } }
    [NativeMember("type")]
    public sbyte @Type { get => SdkMemory.Read<sbyte >(Pointer+26); set { SdkMemory.Write(Pointer+26,value); } }
    [NativeMember("field_1B")]
    public sbyte @Field1B { get => SdkMemory.Read<sbyte >(Pointer+27); set { SdkMemory.Write(Pointer+27,value); } }
}
