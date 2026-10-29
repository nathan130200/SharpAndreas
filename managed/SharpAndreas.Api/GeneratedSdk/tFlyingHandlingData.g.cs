// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class tFlyingHandlingData : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=88;
    public tFlyingHandlingData(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_nVehicleId")]
    public int @VehicleId { get => SdkMemory.Read<int >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("m_fThrust")]
    public float @Thrust { get => SdkMemory.Read<float >(Pointer+4); set { SdkMemory.Write(Pointer+4,value); } }
    [NativeMember("m_fThrustFallOff")]
    public float @ThrustFallOff { get => SdkMemory.Read<float >(Pointer+8); set { SdkMemory.Write(Pointer+8,value); } }
    [NativeMember("m_fYaw")]
    public float @Yaw { get => SdkMemory.Read<float >(Pointer+12); set { SdkMemory.Write(Pointer+12,value); } }
    [NativeMember("m_fYawStab")]
    public float @YawStab { get => SdkMemory.Read<float >(Pointer+16); set { SdkMemory.Write(Pointer+16,value); } }
    [NativeMember("m_fSideSlip")]
    public float @SideSlip { get => SdkMemory.Read<float >(Pointer+20); set { SdkMemory.Write(Pointer+20,value); } }
    [NativeMember("m_fRoll")]
    public float @Roll { get => SdkMemory.Read<float >(Pointer+24); set { SdkMemory.Write(Pointer+24,value); } }
    [NativeMember("m_fRollStab")]
    public float @RollStab { get => SdkMemory.Read<float >(Pointer+28); set { SdkMemory.Write(Pointer+28,value); } }
    [NativeMember("m_fPitch")]
    public float @Pitch { get => SdkMemory.Read<float >(Pointer+32); set { SdkMemory.Write(Pointer+32,value); } }
    [NativeMember("m_fPitchStab")]
    public float @PitchStab { get => SdkMemory.Read<float >(Pointer+36); set { SdkMemory.Write(Pointer+36,value); } }
    [NativeMember("m_fFormLift")]
    public float @FormLift { get => SdkMemory.Read<float >(Pointer+40); set { SdkMemory.Write(Pointer+40,value); } }
    [NativeMember("m_fAttackLift")]
    public float @AttackLift { get => SdkMemory.Read<float >(Pointer+44); set { SdkMemory.Write(Pointer+44,value); } }
    [NativeMember("m_fGearUpR")]
    public float @GearUpR { get => SdkMemory.Read<float >(Pointer+48); set { SdkMemory.Write(Pointer+48,value); } }
    [NativeMember("m_fGearDownL")]
    public float @GearDownL { get => SdkMemory.Read<float >(Pointer+52); set { SdkMemory.Write(Pointer+52,value); } }
    [NativeMember("m_fWindMult")]
    public float @WindMult { get => SdkMemory.Read<float >(Pointer+56); set { SdkMemory.Write(Pointer+56,value); } }
    [NativeMember("m_fMoveRes")]
    public float @MoveRes { get => SdkMemory.Read<float >(Pointer+60); set { SdkMemory.Write(Pointer+60,value); } }
    [NativeMember("m_vecTurnRes")]
    public CVector @TurnRes { get => new CVector(Pointer+64); set { SdkMemory.Copy(value.Pointer,Pointer+64,12); } }
    [NativeMember("m_vecSpeedRes")]
    public CVector @SpeedRes { get => new CVector(Pointer+76); set { SdkMemory.Copy(value.Pointer,Pointer+76,12); } }
}
