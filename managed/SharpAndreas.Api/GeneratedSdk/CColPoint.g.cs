// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CColPoint : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=44;
    public CColPoint(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_vecPoint")]
    public CVector @Point { get => new CVector(Pointer+0); set { SdkMemory.Copy(value.Pointer,Pointer+0,12); } }
    [NativeMember("field_C")]
    public float @FieldC { get => SdkMemory.Read<float >(Pointer+12); set { SdkMemory.Write(Pointer+12,value); } }
    [NativeMember("m_vecNormal")]
    public CVector @Normal { get => new CVector(Pointer+16); set { SdkMemory.Copy(value.Pointer,Pointer+16,12); } }
    [NativeMember("field_1C")]
    public float @Field1C { get => SdkMemory.Read<float >(Pointer+28); set { SdkMemory.Write(Pointer+28,value); } }
    [NativeMember("m_nSurfaceTypeA")]
    public byte @SurfaceTypeA { get => SdkMemory.Read<byte >(Pointer+32); set { SdkMemory.Write(Pointer+32,value); } }
    [NativeMember("m_nPieceTypeA")]
    public byte @PieceTypeA { get => SdkMemory.Read<byte >(Pointer+33); set { SdkMemory.Write(Pointer+33,value); } }
    [NativeMember("m_nLightingA")]
    public tColLighting @LightingA { get => new tColLighting(Pointer+34); set { SdkMemory.Copy(value.Pointer,Pointer+34,1); } }
    [NativeMember("m_nSurfaceTypeB")]
    public byte @SurfaceTypeB { get => SdkMemory.Read<byte >(Pointer+36); set { SdkMemory.Write(Pointer+36,value); } }
    [NativeMember("m_nPieceTypeB")]
    public byte @PieceTypeB { get => SdkMemory.Read<byte >(Pointer+37); set { SdkMemory.Write(Pointer+37,value); } }
    [NativeMember("m_nLightingB")]
    public tColLighting @LightingB { get => new tColLighting(Pointer+38); set { SdkMemory.Copy(value.Pointer,Pointer+38,1); } }
    [NativeMember("m_fDepth")]
    public float @Depth { get => SdkMemory.Read<float >(Pointer+40); set { SdkMemory.Write(Pointer+40,value); } }
    public void @AssignNative(CColPoint @right) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D727 >(727)(Pointer,@right.Pointer); }
}
