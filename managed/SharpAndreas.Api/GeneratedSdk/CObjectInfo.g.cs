// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CObjectInfo : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=80;
    public CObjectInfo(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_fMass")]
    public float @Mass { get => SdkMemory.Read<float >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("m_fTurnMass")]
    public float @TurnMass { get => SdkMemory.Read<float >(Pointer+4); set { SdkMemory.Write(Pointer+4,value); } }
    [NativeMember("m_fAirResistance")]
    public float @AirResistance { get => SdkMemory.Read<float >(Pointer+8); set { SdkMemory.Write(Pointer+8,value); } }
    [NativeMember("m_fElasticity")]
    public float @Elasticity { get => SdkMemory.Read<float >(Pointer+12); set { SdkMemory.Write(Pointer+12,value); } }
    [NativeMember("m_fBuoyancyConstant")]
    public float @BuoyancyConstant { get => SdkMemory.Read<float >(Pointer+16); set { SdkMemory.Write(Pointer+16,value); } }
    [NativeMember("m_fUprootLimit")]
    public float @UprootLimit { get => SdkMemory.Read<float >(Pointer+20); set { SdkMemory.Write(Pointer+20,value); } }
    [NativeMember("m_fColDamageMultiplier")]
    public float @CollisionDamageMultiplier { get => SdkMemory.Read<float >(Pointer+24); set { SdkMemory.Write(Pointer+24,value); } }
    [NativeMember("m_nColDamageEffect")]
    public byte @CollisionDamageEffect { get => SdkMemory.Read<byte >(Pointer+28); set { SdkMemory.Write(Pointer+28,value); } }
    [NativeMember("m_nSpecialColResponseCase")]
    public byte @SpecialCollisionResponseCase { get => SdkMemory.Read<byte >(Pointer+29); set { SdkMemory.Write(Pointer+29,value); } }
    [NativeMember("m_nCameraAvoidObject")]
    public byte @CameraAvoidObject { get => SdkMemory.Read<byte >(Pointer+30); set { SdkMemory.Write(Pointer+30,value); } }
    [NativeMember("m_bCausesExplosion")]
    public byte @CausesExplosion { get => SdkMemory.Read<byte >(Pointer+31); set { SdkMemory.Write(Pointer+31,value); } }
    [NativeMember("m_nFxType")]
    public byte @FxType { get => SdkMemory.Read<byte >(Pointer+32); set { SdkMemory.Write(Pointer+32,value); } }
    [NativeMember("m_vFxOffset")]
    public CVector @FxOffset { get => new CVector(Pointer+36); set { SdkMemory.Copy(value.Pointer,Pointer+36,12); } }
    [NativeMember("m_pFxSystem")]
    public FxSystemBP_c? @FxSystem { get => SdkMemory.Read<IntPtr>(Pointer+48) == IntPtr.Zero ? null : new FxSystemBP_c(SdkMemory.Read<IntPtr>(Pointer+48)); set { SdkMemory.Write(Pointer+48,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_fSmashMultiplier")]
    public float @SmashMultiplier { get => SdkMemory.Read<float >(Pointer+52); set { SdkMemory.Write(Pointer+52,value); } }
    [NativeMember("m_vecBreakVelocity")]
    public CVector @BreakVelocity { get => new CVector(Pointer+56); set { SdkMemory.Copy(value.Pointer,Pointer+56,12); } }
    [NativeMember("m_fBreakVelocityRand")]
    public float @BreakVelocityRand { get => SdkMemory.Read<float >(Pointer+68); set { SdkMemory.Write(Pointer+68,value); } }
    [NativeMember("m_nGunBreakMode")]
    public uint @GunBreakMode { get => SdkMemory.Read<uint >(Pointer+72); set { SdkMemory.Write(Pointer+72,value); } }
    [NativeMember("m_nSparksOnImpact")]
    public uint @SparksOnImpact { get => SdkMemory.Read<uint >(Pointer+76); set { SdkMemory.Write(Pointer+76,value); } }
}
