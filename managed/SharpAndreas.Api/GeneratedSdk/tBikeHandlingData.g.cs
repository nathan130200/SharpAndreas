// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class tBikeHandlingData : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=64;
    public tBikeHandlingData(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_nVehicleId")]
    public int @VehicleId { get => SdkMemory.Read<int >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("m_fLeanFwdCOM")]
    public float @LeanFwdCOM { get => SdkMemory.Read<float >(Pointer+4); set { SdkMemory.Write(Pointer+4,value); } }
    [NativeMember("m_fLeanFwdForce")]
    public float @LeanFwdForce { get => SdkMemory.Read<float >(Pointer+8); set { SdkMemory.Write(Pointer+8,value); } }
    [NativeMember("m_fLeanBakCOM")]
    public float @LeanBakCOM { get => SdkMemory.Read<float >(Pointer+12); set { SdkMemory.Write(Pointer+12,value); } }
    [NativeMember("m_fLeanBakForce")]
    public float @LeanBakForce { get => SdkMemory.Read<float >(Pointer+16); set { SdkMemory.Write(Pointer+16,value); } }
    [NativeMember("m_fMaxLean")]
    public float @MaxLean { get => SdkMemory.Read<float >(Pointer+20); set { SdkMemory.Write(Pointer+20,value); } }
    [NativeMember("m_fFullAnimLean")]
    public float @FullAnimationLean { get => SdkMemory.Read<float >(Pointer+24); set { SdkMemory.Write(Pointer+24,value); } }
    [NativeMember("m_fDesLean")]
    public float @DesLean { get => SdkMemory.Read<float >(Pointer+28); set { SdkMemory.Write(Pointer+28,value); } }
    [NativeMember("m_fSpeedSteer")]
    public float @SpeedSteer { get => SdkMemory.Read<float >(Pointer+32); set { SdkMemory.Write(Pointer+32,value); } }
    [NativeMember("m_fSlipSteer")]
    public float @SlipSteer { get => SdkMemory.Read<float >(Pointer+36); set { SdkMemory.Write(Pointer+36,value); } }
    [NativeMember("m_fNoPlayerCOMz")]
    public float @NoPlayerCOMz { get => SdkMemory.Read<float >(Pointer+40); set { SdkMemory.Write(Pointer+40,value); } }
    [NativeMember("m_fWheelieAng")]
    public float @WheelieAng { get => SdkMemory.Read<float >(Pointer+44); set { SdkMemory.Write(Pointer+44,value); } }
    [NativeMember("m_fStoppieAng")]
    public float @StoppieAng { get => SdkMemory.Read<float >(Pointer+48); set { SdkMemory.Write(Pointer+48,value); } }
    [NativeMember("m_fWheelieSteer")]
    public float @WheelieSteer { get => SdkMemory.Read<float >(Pointer+52); set { SdkMemory.Write(Pointer+52,value); } }
    [NativeMember("m_fWheelieStabMult")]
    public float @WheelieStabMult { get => SdkMemory.Read<float >(Pointer+56); set { SdkMemory.Write(Pointer+56,value); } }
    [NativeMember("m_fStoppieStabMult")]
    public float @StoppieStabMult { get => SdkMemory.Read<float >(Pointer+60); set { SdkMemory.Write(Pointer+60,value); } }
}
