// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class tBoatHandlingData : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=60;
    public tBoatHandlingData(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_nVehicleId")]
    public int @VehicleId { get => SdkMemory.Read<int >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("m_fThrustY")]
    public float @ThrustY { get => SdkMemory.Read<float >(Pointer+4); set { SdkMemory.Write(Pointer+4,value); } }
    [NativeMember("m_fThrustZ")]
    public float @ThrustZ { get => SdkMemory.Read<float >(Pointer+8); set { SdkMemory.Write(Pointer+8,value); } }
    [NativeMember("m_fThrustAppZ")]
    public float @ThrustAppZ { get => SdkMemory.Read<float >(Pointer+12); set { SdkMemory.Write(Pointer+12,value); } }
    [NativeMember("m_fAqPlaneForce")]
    public float @AqPlaneForce { get => SdkMemory.Read<float >(Pointer+16); set { SdkMemory.Write(Pointer+16,value); } }
    [NativeMember("m_fAqPlaneLimit")]
    public float @AqPlaneLimit { get => SdkMemory.Read<float >(Pointer+20); set { SdkMemory.Write(Pointer+20,value); } }
    [NativeMember("m_fAqPlaneOffset")]
    public float @AqPlaneOffset { get => SdkMemory.Read<float >(Pointer+24); set { SdkMemory.Write(Pointer+24,value); } }
    [NativeMember("m_fWaveAudioMult")]
    public float @WaveAudioMult { get => SdkMemory.Read<float >(Pointer+28); set { SdkMemory.Write(Pointer+28,value); } }
    [NativeMember("m_fLookLRBehindCamHeight")]
    public float @LookLRBehindCamHeight { get => SdkMemory.Read<float >(Pointer+32); set { SdkMemory.Write(Pointer+32,value); } }
    [NativeMember("m_vecMoveRes")]
    public CVector @MoveRes { get => new CVector(Pointer+36); set { SdkMemory.Copy(value.Pointer,Pointer+36,12); } }
    [NativeMember("m_vecTurnRes")]
    public CVector @TurnRes { get => new CVector(Pointer+48); set { SdkMemory.Copy(value.Pointer,Pointer+48,12); } }
}
