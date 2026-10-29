// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CTrain___unnamed__at_D__plugin_sdk_plugin_sa_game_sa_CTrain_h_55_5__08fafcda5c : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=2;
    public CTrain___unnamed__at_D__plugin_sdk_plugin_sa_game_sa_CTrain_h_55_5__08fafcda5c(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("b01")]
    public byte @B01 { get => (byte)SdkMemory.ReadBits(Pointer,0,1); set { SdkMemory.WriteBits(Pointer,0,1,unchecked((ulong)value)); } }
    [NativeMember("bStoppedAtStation")]
    public byte @StoppedAtStation { get => (byte)SdkMemory.ReadBits(Pointer,1,1); set { SdkMemory.WriteBits(Pointer,1,1,unchecked((ulong)value)); } }
    [NativeMember("bPassengersCanEnterAndLeave")]
    public byte @PassengersCanEnterAndLeave { get => (byte)SdkMemory.ReadBits(Pointer,2,1); set { SdkMemory.WriteBits(Pointer,2,1,unchecked((ulong)value)); } }
    [NativeMember("bIsFrontCarriage")]
    public byte @IsFrontCarriage { get => (byte)SdkMemory.ReadBits(Pointer,3,1); set { SdkMemory.WriteBits(Pointer,3,1,unchecked((ulong)value)); } }
    [NativeMember("bIsLastCarriage")]
    public byte @IsLastCarriage { get => (byte)SdkMemory.ReadBits(Pointer,4,1); set { SdkMemory.WriteBits(Pointer,4,1,unchecked((ulong)value)); } }
    [NativeMember("bMissionTrain")]
    public byte @MissionTrain { get => (byte)SdkMemory.ReadBits(Pointer,5,1); set { SdkMemory.WriteBits(Pointer,5,1,unchecked((ulong)value)); } }
    [NativeMember("bClockwiseDirection")]
    public byte @ClockwiseDirection { get => (byte)SdkMemory.ReadBits(Pointer,6,1); set { SdkMemory.WriteBits(Pointer,6,1,unchecked((ulong)value)); } }
    [NativeMember("bStopsAtStations")]
    public byte @StopsAtStations { get => (byte)SdkMemory.ReadBits(Pointer,7,1); set { SdkMemory.WriteBits(Pointer,7,1,unchecked((ulong)value)); } }
    [NativeMember("bNotOnARailRoad")]
    public byte @NotOnARailRoad { get => (byte)SdkMemory.ReadBits(Pointer,8,1); set { SdkMemory.WriteBits(Pointer,8,1,unchecked((ulong)value)); } }
    [NativeMember("bForceSlowDown")]
    public byte @ForceSlowDown { get => (byte)SdkMemory.ReadBits(Pointer,9,1); set { SdkMemory.WriteBits(Pointer,9,1,unchecked((ulong)value)); } }
    [NativeMember("bIsStreakModel")]
    public byte @IsStreakModel { get => (byte)SdkMemory.ReadBits(Pointer,10,1); set { SdkMemory.WriteBits(Pointer,10,1,unchecked((ulong)value)); } }
}
