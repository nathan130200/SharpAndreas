// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class tStreamingChannel : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=152;
    public tStreamingChannel(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("modelIds")]
    public NativeArray<int> @ModelIds { get => new NativeArray<int>(Pointer+0,16); }
    [NativeMember("field_40")]
    public NativeArray<int> @Field40 { get => new NativeArray<int>(Pointer+64,16); }
    [NativeMember("m_nStreamStatus")]
    public eStreamStatus @StreamStatus { get => SdkMemory.Read<eStreamStatus >(Pointer+128); set { SdkMemory.Write(Pointer+128,value); } }
    [NativeMember("field_84")]
    public int @Field84 { get => SdkMemory.Read<int >(Pointer+132); set { SdkMemory.Write(Pointer+132,value); } }
    [NativeMember("field_88")]
    public int @Field88 { get => SdkMemory.Read<int >(Pointer+136); set { SdkMemory.Write(Pointer+136,value); } }
    [NativeMember("field_8C")]
    public int @Field8C { get => SdkMemory.Read<int >(Pointer+140); set { SdkMemory.Write(Pointer+140,value); } }
    [NativeMember("field_90")]
    public int @Field90 { get => SdkMemory.Read<int >(Pointer+144); set { SdkMemory.Write(Pointer+144,value); } }
    [NativeMember("m_nCdStreamStatus")]
    public int @CdStreamStatus { get => SdkMemory.Read<int >(Pointer+148); set { SdkMemory.Write(Pointer+148,value); } }
}
