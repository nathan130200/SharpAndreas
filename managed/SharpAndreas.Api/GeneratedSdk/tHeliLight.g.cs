// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class tHeliLight : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=76;
    public tHeliLight(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_vecOrigin")]
    public CVector @Origin { get => new CVector(Pointer+0); set { SdkMemory.Copy(value.Pointer,Pointer+0,12); } }
    [NativeMember("m_vecTarget")]
    public CVector @Target { get => new CVector(Pointer+12); set { SdkMemory.Copy(value.Pointer,Pointer+12,12); } }
    [NativeMember("m_fTargetRadius")]
    public float @TargetRadius { get => SdkMemory.Read<float >(Pointer+24); set { SdkMemory.Write(Pointer+24,value); } }
    [NativeMember("m_fPower")]
    public float @Power { get => SdkMemory.Read<float >(Pointer+28); set { SdkMemory.Write(Pointer+28,value); } }
    [NativeMember("m_nCoronaIndex")]
    public int @CoronaIndex { get => SdkMemory.Read<int >(Pointer+32); set { SdkMemory.Write(Pointer+32,value); } }
    [NativeMember("field_24")]
    public bool @Field24 { get => SdkMemory.Read<bool >(Pointer+36); set { SdkMemory.Write(Pointer+36,value); } }
    [NativeMember("m_bDrawShadow")]
    public bool @DrawShadow { get => SdkMemory.Read<bool >(Pointer+37); set { SdkMemory.Write(Pointer+37,value); } }
    [NativeMember("_pad")]
    public NativeArray<sbyte> @Pad { get => new NativeArray<sbyte>(Pointer+38,2); }
    [NativeMember("field_28")]
    public NativeObjectArray<CVector> @Field28 { get => new NativeObjectArray<CVector>(Pointer+40,3,12); }
}
