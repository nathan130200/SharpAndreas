// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class tBrightLight : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=56;
    public tBrightLight(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_vecPosition")]
    public CVector @Position { get => new CVector(Pointer+0); set { SdkMemory.Copy(value.Pointer,Pointer+0,12); } }
    [NativeMember("m_vecRight")]
    public CVector @Right { get => new CVector(Pointer+12); set { SdkMemory.Copy(value.Pointer,Pointer+12,12); } }
    [NativeMember("m_vecTop")]
    public CVector @Top { get => new CVector(Pointer+24); set { SdkMemory.Copy(value.Pointer,Pointer+24,12); } }
    [NativeMember("m_vecAt")]
    public CVector @At { get => new CVector(Pointer+36); set { SdkMemory.Copy(value.Pointer,Pointer+36,12); } }
    [NativeMember("m_fDistanceToCamera")]
    public float @DistanceToCamera { get => SdkMemory.Read<float >(Pointer+48); set { SdkMemory.Write(Pointer+48,value); } }
    [NativeMember("m_nColor")]
    public byte @Color { get => SdkMemory.Read<byte >(Pointer+52); set { SdkMemory.Write(Pointer+52,value); } }
    [NativeMember("field_35")]
    public sbyte @Field35 { get => SdkMemory.Read<sbyte >(Pointer+53); set { SdkMemory.Write(Pointer+53,value); } }
    [NativeMember("field_36")]
    public sbyte @Field36 { get => SdkMemory.Read<sbyte >(Pointer+54); set { SdkMemory.Write(Pointer+54,value); } }
    [NativeMember("field_37")]
    public sbyte @Field37 { get => SdkMemory.Read<sbyte >(Pointer+55); set { SdkMemory.Write(Pointer+55,value); } }
}
