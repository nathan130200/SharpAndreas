// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CTaskComplexLeaveCar : CTaskComplex
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=52;
    public CTaskComplexLeaveCar(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_pTargetVehicle")]
    public CVehicle? @TargetVehicle { get => SdkMemory.Read<IntPtr>(Pointer+12) == IntPtr.Zero ? null : new CVehicle(SdkMemory.Read<IntPtr>(Pointer+12)); set { SdkMemory.Write(Pointer+12,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_nTargetDoor")]
    public int @TargetDoor { get => SdkMemory.Read<int >(Pointer+16); set { SdkMemory.Write(Pointer+16,value); } }
    [NativeMember("m_nDelayTime")]
    public int @DelayTime { get => SdkMemory.Read<int >(Pointer+20); set { SdkMemory.Write(Pointer+20,value); } }
    [NativeMember("m_bSensibleLeaveCar")]
    public bool @SensibleLeaveCar { get => SdkMemory.Read<bool >(Pointer+24); set { SdkMemory.Write(Pointer+24,value); } }
    [NativeMember("m_bForceGetOut")]
    public bool @ForceGetOut { get => SdkMemory.Read<bool >(Pointer+25); set { SdkMemory.Write(Pointer+25,value); } }
    [NativeMember("m_bDie")]
    public bool @Die { get => SdkMemory.Read<bool >(Pointer+26); set { SdkMemory.Write(Pointer+26,value); } }
    [NativeMember("m_pTaskUtilityLineUpPedWithCa")]
    public CTaskUtilityLineUpPedWithCar? @TaskUtilityLineUpPedWithCa { get => SdkMemory.Read<IntPtr>(Pointer+28) == IntPtr.Zero ? null : new CTaskUtilityLineUpPedWithCar(SdkMemory.Read<IntPtr>(Pointer+28)); set { SdkMemory.Write(Pointer+28,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_nDoorFlagsSet")]
    public byte @DoorFlagsSet { get => SdkMemory.Read<byte >(Pointer+32); set { SdkMemory.Write(Pointer+32,value); } }
    [NativeMember("m_nNumGettingInSet")]
    public byte @CountGettingInSet { get => SdkMemory.Read<byte >(Pointer+33); set { SdkMemory.Write(Pointer+33,value); } }
    [NativeMember("m_nDieAnimID")]
    public int @DieAnimationID { get => SdkMemory.Read<int >(Pointer+36); set { SdkMemory.Write(Pointer+36,value); } }
    [NativeMember("m_fDieAnimBlendDelta")]
    public float @DieAnimationBlendDelta { get => SdkMemory.Read<float >(Pointer+40); set { SdkMemory.Write(Pointer+40,value); } }
    [NativeMember("m_fDieAnimSpeed")]
    public float @DieAnimationSpeed { get => SdkMemory.Read<float >(Pointer+44); set { SdkMemory.Write(Pointer+44,value); } }
    [NativeMember("m_bIsInAir")]
    public bool @IsInAir { get => SdkMemory.Read<bool >(Pointer+48); set { SdkMemory.Write(Pointer+48,value); } }
    public void @InitializeAt(CVehicle? @pTargetVehicle,int @nTargetDoor,int @nDelayTime,bool @bSensibleLeaveCar,bool @bForceGetOut) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4019 >(4019)(Pointer,@pTargetVehicle?.Pointer ?? IntPtr.Zero,@nTargetDoor,@nDelayTime,(@bSensibleLeaveCar ? 1 : 0),(@bForceGetOut ? 1 : 0)); }
}
