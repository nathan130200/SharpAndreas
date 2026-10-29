// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CTaskComplexEnterCar : CTaskComplex
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=80;
    public CTaskComplexEnterCar(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_pTargetVehicle")]
    public CVehicle? @TargetVehicle { get => SdkMemory.Read<IntPtr>(Pointer+12) == IntPtr.Zero ? null : new CVehicle(SdkMemory.Read<IntPtr>(Pointer+12)); set { SdkMemory.Write(Pointer+12,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_nTargetDoor")]
    public int @TargetDoor { get => SdkMemory.Read<int >(Pointer+20); set { SdkMemory.Write(Pointer+20,value); } }
    [NativeMember("m_nTargetDoorOppositeToFlag")]
    public int @TargetDoorOppositeToFlag { get => SdkMemory.Read<int >(Pointer+24); set { SdkMemory.Write(Pointer+24,value); } }
    [NativeMember("m_nTargetSeat")]
    public int @TargetSeat { get => SdkMemory.Read<int >(Pointer+28); set { SdkMemory.Write(Pointer+28,value); } }
    [NativeMember("m_nDraggedPedDownTime")]
    public int @DraggedPedDownTime { get => SdkMemory.Read<int >(Pointer+32); set { SdkMemory.Write(Pointer+32,value); } }
    [NativeMember("m_nMoveState")]
    public int @MoveState { get => SdkMemory.Read<int >(Pointer+36); set { SdkMemory.Write(Pointer+36,value); } }
    [NativeMember("m_nNumGettingInSet")]
    public byte @CountGettingInSet { get => SdkMemory.Read<byte >(Pointer+40); set { SdkMemory.Write(Pointer+40,value); } }
    [NativeMember("m_nCamMovementChoice")]
    public byte @CamMovementChoice { get => SdkMemory.Read<byte >(Pointer+41); set { SdkMemory.Write(Pointer+41,value); } }
    [NativeMember("m_vTargetDoorPos")]
    public CVector @TargetDoorPosition { get => new CVector(Pointer+44); set { SdkMemory.Copy(value.Pointer,Pointer+44,12); } }
    [NativeMember("m_pTaskUtilityLineUpPedWithCar")]
    public CTaskUtilityLineUpPedWithCar? @TaskUtilityLineUpPedWithCar { get => SdkMemory.Read<IntPtr>(Pointer+56) == IntPtr.Zero ? null : new CTaskUtilityLineUpPedWithCar(SdkMemory.Read<IntPtr>(Pointer+56)); set { SdkMemory.Write(Pointer+56,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_bIsAborting")]
    public bool @IsAborting { get => SdkMemory.Read<bool >(Pointer+60); set { SdkMemory.Write(Pointer+60,value); } }
    [NativeMember("m_pDraggedPed")]
    public CPed? @DraggedPed { get => SdkMemory.Read<IntPtr>(Pointer+64) == IntPtr.Zero ? null : new CPed(SdkMemory.Read<IntPtr>(Pointer+64)); set { SdkMemory.Write(Pointer+64,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_nDoorFlagsSet")]
    public byte @DoorFlagsSet { get => SdkMemory.Read<byte >(Pointer+68); set { SdkMemory.Write(Pointer+68,value); } }
    [NativeMember("m_fCruiseSpeed")]
    public float @CruiseSpeed { get => SdkMemory.Read<float >(Pointer+72); set { SdkMemory.Write(Pointer+72,value); } }
    [NativeMember("m_nEnterCarStartTime")]
    public int @EnterCarStartTime { get => SdkMemory.Read<int >(Pointer+76); set { SdkMemory.Write(Pointer+76,value); } }
    public void @InitializeAt(CVehicle? @pTargetVehicle,bool @bAsDriver,bool @bQuitAfterOpeningDoor,bool @bQuitAfterDraggingPedOut,bool @bCarryOnAfterFallingOff) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4012 >(4012)(Pointer,@pTargetVehicle?.Pointer ?? IntPtr.Zero,(@bAsDriver ? 1 : 0),(@bQuitAfterOpeningDoor ? 1 : 0),(@bQuitAfterDraggingPedOut ? 1 : 0),(@bCarryOnAfterFallingOff ? 1 : 0)); }
}
