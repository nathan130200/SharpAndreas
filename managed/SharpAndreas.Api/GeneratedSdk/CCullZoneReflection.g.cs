// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CCullZoneReflection : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=24;
    public CCullZoneReflection(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("zoneDef")]
    public CZoneDef @ZoneDef { get => new CZoneDef(Pointer+0); set { SdkMemory.Copy(value.Pointer,Pointer+0,16); } }
    [NativeMember("cm")]
    public float @Cm { get => SdkMemory.Read<float >(Pointer+16); set { SdkMemory.Write(Pointer+16,value); } }
    [NativeMember("vx")]
    public sbyte @Vx { get => SdkMemory.Read<sbyte >(Pointer+20); set { SdkMemory.Write(Pointer+20,value); } }
    [NativeMember("vy")]
    public sbyte @Vy { get => SdkMemory.Read<sbyte >(Pointer+21); set { SdkMemory.Write(Pointer+21,value); } }
    [NativeMember("vz")]
    public sbyte @Vz { get => SdkMemory.Read<sbyte >(Pointer+22); set { SdkMemory.Write(Pointer+22,value); } }
    [NativeMember("flags")]
    public byte @Flags { get => SdkMemory.Read<byte >(Pointer+23); set { SdkMemory.Write(Pointer+23,value); } }
}
