// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CGamma : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=16;
    public CGamma(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("field_0")]
    public uint @Field0 { get => SdkMemory.Read<uint >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("field_4")]
    public float @Field4 { get => SdkMemory.Read<float >(Pointer+4); set { SdkMemory.Write(Pointer+4,value); } }
    [NativeMember("field_8")]
    public float @Field8 { get => SdkMemory.Read<float >(Pointer+8); set { SdkMemory.Write(Pointer+8,value); } }
    [NativeMember("field_C")]
    public float @FieldC { get => SdkMemory.Read<float >(Pointer+12); set { SdkMemory.Write(Pointer+12,value); } }
    public void @SetGamma(float @arg1,sbyte @arg2) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2779 >(2779)(Pointer,@arg1,@arg2); }
}
