// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class tRadioStationTracking : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=44;
    public tRadioStationTracking(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("TrackingPeriodsMs")]
    public NativeArray<int> @TrackingPeriodsMs { get => new NativeArray<int>(Pointer+0,3); }
    [NativeMember("GameTimeWhenStartedMs")]
    public int @GameTimeWhenStartedMs { get => SdkMemory.Read<int >(Pointer+12); set { SdkMemory.Write(Pointer+12,value); } }
    [NativeMember("GameTimeWhenStoppedMs")]
    public int @GameTimeWhenStoppedMs { get => SdkMemory.Read<int >(Pointer+16); set { SdkMemory.Write(Pointer+16,value); } }
    [NativeMember("OldPlayTimeMs")]
    public int @OldPlayTimeMs { get => SdkMemory.Read<int >(Pointer+20); set { SdkMemory.Write(Pointer+20,value); } }
    [NativeMember("OldTrackIDs")]
    public NativeArray<int> @OldTrackIDs { get => new NativeArray<int>(Pointer+24,3); }
    [NativeMember("OldTrackTypes")]
    public NativeArray<sbyte> @OldTrackTypes { get => new NativeArray<sbyte>(Pointer+36,3); }
    [NativeMember("GameClockDaysWhenStopped")]
    public sbyte @GameClockDaysWhenStopped { get => SdkMemory.Read<sbyte >(Pointer+39); set { SdkMemory.Write(Pointer+39,value); } }
    [NativeMember("GameClockHoursWhenStopped")]
    public sbyte @GameClockHoursWhenStopped { get => SdkMemory.Read<sbyte >(Pointer+40); set { SdkMemory.Write(Pointer+40,value); } }
}
