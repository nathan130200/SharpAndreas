// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CTaskSimpleCarSetPedOut : CTaskSimple
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=24;
    public CTaskSimpleCarSetPedOut(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_pTargetVehicle")]
    public CVehicle? @TargetVehicle { get => SdkMemory.Read<IntPtr>(Pointer+8) == IntPtr.Zero ? null : new CVehicle(SdkMemory.Read<IntPtr>(Pointer+8)); set { SdkMemory.Write(Pointer+8,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_nTargetDoor")]
    public int @TargetDoor { get => SdkMemory.Read<int >(Pointer+12); set { SdkMemory.Write(Pointer+12,value); } }
    [NativeMember("m_bSwitchOffEngine")]
    public bool @SwitchOffEngine { get => SdkMemory.Read<bool >(Pointer+16); set { SdkMemory.Write(Pointer+16,value); } }
    [NativeMember("m_bWarpingOutOfCar")]
    public bool @WarpingOutOfCar { get => SdkMemory.Read<bool >(Pointer+17); set { SdkMemory.Write(Pointer+17,value); } }
    [NativeMember("m_bFallingOutOfCar")]
    public bool @FallingOutOfCar { get => SdkMemory.Read<bool >(Pointer+18); set { SdkMemory.Write(Pointer+18,value); } }
    [NativeMember("m_bKnockedOffBike")]
    public bool @KnockedOffBike { get => SdkMemory.Read<bool >(Pointer+19); set { SdkMemory.Write(Pointer+19,value); } }
    [NativeMember("m_nDoorFlagsToClear")]
    public byte @DoorFlagsToClear { get => SdkMemory.Read<byte >(Pointer+20); set { SdkMemory.Write(Pointer+20,value); } }
    [NativeMember("m_nNumGettingInToClear")]
    public byte @CountGettingInToClear { get => SdkMemory.Read<byte >(Pointer+21); set { SdkMemory.Write(Pointer+21,value); } }
    public void @InitializeAt(CVehicle? @pTargetVehicle,int @nTargetDoor,bool @bSwitchOffEngine) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4040 >(4040)(Pointer,@pTargetVehicle?.Pointer ?? IntPtr.Zero,@nTargetDoor,(@bSwitchOffEngine ? 1 : 0)); }
}
