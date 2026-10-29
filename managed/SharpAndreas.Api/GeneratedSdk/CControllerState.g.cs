// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CControllerState : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=48;
    public CControllerState(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("LeftStickX")]
    public short @LeftStickX { get => SdkMemory.Read<short >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("LeftStickY")]
    public short @LeftStickY { get => SdkMemory.Read<short >(Pointer+2); set { SdkMemory.Write(Pointer+2,value); } }
    [NativeMember("RightStickX")]
    public short @RightStickX { get => SdkMemory.Read<short >(Pointer+4); set { SdkMemory.Write(Pointer+4,value); } }
    [NativeMember("RightStickY")]
    public short @RightStickY { get => SdkMemory.Read<short >(Pointer+6); set { SdkMemory.Write(Pointer+6,value); } }
    [NativeMember("LeftShoulder1")]
    public short @LeftShoulder1 { get => SdkMemory.Read<short >(Pointer+8); set { SdkMemory.Write(Pointer+8,value); } }
    [NativeMember("LeftShoulder2")]
    public short @LeftShoulder2 { get => SdkMemory.Read<short >(Pointer+10); set { SdkMemory.Write(Pointer+10,value); } }
    [NativeMember("RightShoulder1")]
    public short @RightShoulder1 { get => SdkMemory.Read<short >(Pointer+12); set { SdkMemory.Write(Pointer+12,value); } }
    [NativeMember("RightShoulder2")]
    public short @RightShoulder2 { get => SdkMemory.Read<short >(Pointer+14); set { SdkMemory.Write(Pointer+14,value); } }
    [NativeMember("DPadUp")]
    public short @DPadUp { get => SdkMemory.Read<short >(Pointer+16); set { SdkMemory.Write(Pointer+16,value); } }
    [NativeMember("DPadDown")]
    public short @DPadDown { get => SdkMemory.Read<short >(Pointer+18); set { SdkMemory.Write(Pointer+18,value); } }
    [NativeMember("DPadLeft")]
    public short @DPadLeft { get => SdkMemory.Read<short >(Pointer+20); set { SdkMemory.Write(Pointer+20,value); } }
    [NativeMember("DPadRight")]
    public short @DPadRight { get => SdkMemory.Read<short >(Pointer+22); set { SdkMemory.Write(Pointer+22,value); } }
    [NativeMember("Start")]
    public short @Start { get => SdkMemory.Read<short >(Pointer+24); set { SdkMemory.Write(Pointer+24,value); } }
    [NativeMember("Select")]
    public short @Select { get => SdkMemory.Read<short >(Pointer+26); set { SdkMemory.Write(Pointer+26,value); } }
    [NativeMember("ButtonSquare")]
    public short @ButtonSquare { get => SdkMemory.Read<short >(Pointer+28); set { SdkMemory.Write(Pointer+28,value); } }
    [NativeMember("ButtonTriangle")]
    public short @ButtonTriangle { get => SdkMemory.Read<short >(Pointer+30); set { SdkMemory.Write(Pointer+30,value); } }
    [NativeMember("ButtonCross")]
    public short @ButtonCross { get => SdkMemory.Read<short >(Pointer+32); set { SdkMemory.Write(Pointer+32,value); } }
    [NativeMember("ButtonCircle")]
    public short @ButtonCircle { get => SdkMemory.Read<short >(Pointer+34); set { SdkMemory.Write(Pointer+34,value); } }
    [NativeMember("ShockButtonL")]
    public short @ShockButtonL { get => SdkMemory.Read<short >(Pointer+36); set { SdkMemory.Write(Pointer+36,value); } }
    [NativeMember("ShockButtonR")]
    public short @ShockButtonR { get => SdkMemory.Read<short >(Pointer+38); set { SdkMemory.Write(Pointer+38,value); } }
    [NativeMember("m_bChatIndicated")]
    public short @ChatIndicated { get => SdkMemory.Read<short >(Pointer+40); set { SdkMemory.Write(Pointer+40,value); } }
    [NativeMember("m_bPedWalk")]
    public short @PedWalk { get => SdkMemory.Read<short >(Pointer+42); set { SdkMemory.Write(Pointer+42,value); } }
    [NativeMember("m_bVehicleMouseLook")]
    public short @VehicleMouseLook { get => SdkMemory.Read<short >(Pointer+44); set { SdkMemory.Write(Pointer+44,value); } }
    [NativeMember("m_bRadioTrackSkip")]
    public short @RadioTrackSkip { get => SdkMemory.Read<short >(Pointer+46); set { SdkMemory.Write(Pointer+46,value); } }
}
