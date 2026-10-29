// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CTaskSimpleCarSetPedInAsPassenger : CTaskSimple
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=32;
    public CTaskSimpleCarSetPedInAsPassenger(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_bIsFinished")]
    public bool @IsFinished { get => SdkMemory.Read<bool >(Pointer+8); set { SdkMemory.Write(Pointer+8,value); } }
    [NativeMember("m_pAnim")]
    public CAnimBlendAssociation? @Animation { get => SdkMemory.Read<IntPtr>(Pointer+12) == IntPtr.Zero ? null : new CAnimBlendAssociation(SdkMemory.Read<IntPtr>(Pointer+12)); set { SdkMemory.Write(Pointer+12,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_pTargetVehicle")]
    public CVehicle? @TargetVehicle { get => SdkMemory.Read<IntPtr>(Pointer+16) == IntPtr.Zero ? null : new CVehicle(SdkMemory.Read<IntPtr>(Pointer+16)); set { SdkMemory.Write(Pointer+16,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_iTargetDoor")]
    public int @ITargetDoor { get => SdkMemory.Read<int >(Pointer+20); set { SdkMemory.Write(Pointer+20,value); } }
    [NativeMember("m_pUtility")]
    public CTaskUtilityLineUpPedWithCar? @Utility { get => SdkMemory.Read<IntPtr>(Pointer+24) == IntPtr.Zero ? null : new CTaskUtilityLineUpPedWithCar(SdkMemory.Read<IntPtr>(Pointer+24)); set { SdkMemory.Write(Pointer+24,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_bWarpingInToCar")]
    public bool @WarpingInToCar { get => SdkMemory.Read<bool >(Pointer+28); set { SdkMemory.Write(Pointer+28,value); } }
    [NativeMember("m_nDoorFlagsToClear")]
    public byte @DoorFlagsToClear { get => SdkMemory.Read<byte >(Pointer+29); set { SdkMemory.Write(Pointer+29,value); } }
    [NativeMember("m_nNumGettingInToClear")]
    public byte @CountGettingInToClear { get => SdkMemory.Read<byte >(Pointer+30); set { SdkMemory.Write(Pointer+30,value); } }
    public void @InitializeAt(CVehicle? @pTargetVehicle,int @nTargetDoor,CTaskUtilityLineUpPedWithCar? @pUtility) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4039 >(4039)(Pointer,@pTargetVehicle?.Pointer ?? IntPtr.Zero,@nTargetDoor,@pUtility?.Pointer ?? IntPtr.Zero); }
}
