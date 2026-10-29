// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CBird : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=68;
    public CBird(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_vecPosn")]
    public CVector @Position { get => new CVector(Pointer+0); set { SdkMemory.Copy(value.Pointer,Pointer+0,12); } }
    [NativeMember("m_vecCurrentVelocity")]
    public CVector @CurrentVelocity { get => new CVector(Pointer+12); set { SdkMemory.Copy(value.Pointer,Pointer+12,12); } }
    [NativeMember("m_vecVelocity")]
    public CVector @Velocity { get => new CVector(Pointer+24); set { SdkMemory.Copy(value.Pointer,Pointer+24,12); } }
    [NativeMember("m_fAngle")]
    public float @Angle { get => SdkMemory.Read<float >(Pointer+36); set { SdkMemory.Write(Pointer+36,value); } }
    [NativeMember("field_28")]
    public int @Field28 { get => SdkMemory.Read<int >(Pointer+40); set { SdkMemory.Write(Pointer+40,value); } }
    [NativeMember("m_nWingSpeed")]
    public int @WingSpeed { get => SdkMemory.Read<int >(Pointer+44); set { SdkMemory.Write(Pointer+44,value); } }
    [NativeMember("m_fSize")]
    public float @Size { get => SdkMemory.Read<float >(Pointer+48); set { SdkMemory.Write(Pointer+48,value); } }
    [NativeMember("m_fMaxBirdDistance")]
    public float @MaxBirdDistance { get => SdkMemory.Read<float >(Pointer+52); set { SdkMemory.Write(Pointer+52,value); } }
    [NativeMember("field_38")]
    public sbyte @Field38 { get => SdkMemory.Read<sbyte >(Pointer+56); set { SdkMemory.Write(Pointer+56,value); } }
    [NativeMember("m_anPolyColors")]
    public NativeArray<sbyte> @PolyColors { get => new NativeArray<sbyte>(Pointer+57,6); }
    [NativeMember("m_bCreated")]
    public bool @Created { get => SdkMemory.Read<bool >(Pointer+63); set { SdkMemory.Write(Pointer+63,value); } }
    [NativeMember("m_bMustDoCurves")]
    public bool @MustDoCurves { get => SdkMemory.Read<bool >(Pointer+64); set { SdkMemory.Write(Pointer+64,value); } }
}
