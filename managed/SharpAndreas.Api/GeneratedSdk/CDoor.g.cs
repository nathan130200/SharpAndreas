// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CDoor : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=24;
    public CDoor(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_fOpenAngle")]
    public float @OpenAngle { get => SdkMemory.Read<float >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("m_fClosedAngle")]
    public float @ClosedAngle { get => SdkMemory.Read<float >(Pointer+4); set { SdkMemory.Write(Pointer+4,value); } }
    [NativeMember("m_nDirn")]
    public short @Dirn { get => SdkMemory.Read<short >(Pointer+8); set { SdkMemory.Write(Pointer+8,value); } }
    [NativeMember("m_nAxis")]
    public byte @Axis { get => SdkMemory.Read<byte >(Pointer+10); set { SdkMemory.Write(Pointer+10,value); } }
    [NativeMember("m_nDoorState")]
    public eDoorState @DoorState { get => SdkMemory.Read<eDoorState >(Pointer+11); set { SdkMemory.Write(Pointer+11,value); } }
    [NativeMember("m_fAngle")]
    public float @Angle { get => SdkMemory.Read<float >(Pointer+12); set { SdkMemory.Write(Pointer+12,value); } }
    [NativeMember("m_fPrevAngle")]
    public float @PrevAngle { get => SdkMemory.Read<float >(Pointer+16); set { SdkMemory.Write(Pointer+16,value); } }
    [NativeMember("m_fAngVel")]
    public float @AngVelocity { get => SdkMemory.Read<float >(Pointer+20); set { SdkMemory.Write(Pointer+20,value); } }
    [NativeMember("DOOR_SPEED_MAX_CAPPED")]
    public static float @DOORSPEEDMAXCAPPED { get => SdkMemory.Read<float >(new IntPtr(0x8D3950)); set { SdkMemory.Write(new IntPtr(0x8D3950),value); } }
    public bool @Process(CVehicle? @vehicle,CVector @arg1,CVector @arg2,CVector @arg3) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D754 >(754)(Pointer,@vehicle?.Pointer ?? IntPtr.Zero,@arg1.Pointer,@arg2.Pointer,@arg3.Pointer); return __sdkResult != 0; }
    public bool @ProcessImpact(CVehicle? @vehicle,CVector @arg1,CVector @arg2,CVector @arg3) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D755 >(755)(Pointer,@vehicle?.Pointer ?? IntPtr.Zero,@arg1.Pointer,@arg2.Pointer,@arg3.Pointer); return __sdkResult != 0; }
    public void @Open(float @openRatio) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D756 >(756)(Pointer,@openRatio); }
    public float @GetAngleOpenRatio() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D757 >(757)(Pointer); return __sdkResult; }
    public bool @IsClosed() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D758 >(758)(Pointer); return __sdkResult != 0; }
    public bool @IsFullyOpen() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D759 >(759)(Pointer); return __sdkResult != 0; }
}
