// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class tRadioSettings : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=60;
    public tRadioSettings(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("TrackIDs")]
    public NativeArray<int> @TrackIDs { get => new NativeArray<int>(Pointer+0,5); }
    [NativeMember("PlayingTrackID")]
    public int @PlayingTrackID { get => SdkMemory.Read<int >(Pointer+20); set { SdkMemory.Write(Pointer+20,value); } }
    [NativeMember("PreviousTrackID")]
    public int @PreviousTrackID { get => SdkMemory.Read<int >(Pointer+24); set { SdkMemory.Write(Pointer+24,value); } }
    [NativeMember("PlayTime")]
    public int @PlayTime { get => SdkMemory.Read<int >(Pointer+28); set { SdkMemory.Write(Pointer+28,value); } }
    [NativeMember("TrackLengthMs")]
    public int @TrackLengthMs { get => SdkMemory.Read<int >(Pointer+32); set { SdkMemory.Write(Pointer+32,value); } }
    [NativeMember("TrackFlags")]
    public byte @TrackFlags { get => SdkMemory.Read<byte >(Pointer+36); set { SdkMemory.Write(Pointer+36,value); } }
    [NativeMember("StationID")]
    public sbyte @StationID { get => SdkMemory.Read<sbyte >(Pointer+37); set { SdkMemory.Write(Pointer+37,value); } }
    [NativeMember("BassSetting")]
    public sbyte @BassSetting { get => SdkMemory.Read<sbyte >(Pointer+38); set { SdkMemory.Write(Pointer+38,value); } }
    [NativeMember("_pad27")]
    public sbyte @Pad27 { get => SdkMemory.Read<sbyte >(Pointer+39); set { SdkMemory.Write(Pointer+39,value); } }
    [NativeMember("BassFactor")]
    public float @BassFactor { get => SdkMemory.Read<float >(Pointer+40); set { SdkMemory.Write(Pointer+40,value); } }
    [NativeMember("TrackTypes")]
    public NativeArray<sbyte> @TrackTypes { get => new NativeArray<sbyte>(Pointer+44,5); }
    [NativeMember("PlayingTrackType")]
    public sbyte @PlayingTrackType { get => SdkMemory.Read<sbyte >(Pointer+49); set { SdkMemory.Write(Pointer+49,value); } }
    [NativeMember("PreviousTrackType")]
    public sbyte @PreviousTrackType { get => SdkMemory.Read<sbyte >(Pointer+50); set { SdkMemory.Write(Pointer+50,value); } }
    [NativeMember("MusicTrackIndices")]
    public NativeArray<sbyte> @MusicTrackIndices { get => new NativeArray<sbyte>(Pointer+51,5); }
    [NativeMember("PlayingTrackMusicTrackIndex")]
    public sbyte @PlayingTrackMusicTrackIndex { get => SdkMemory.Read<sbyte >(Pointer+56); set { SdkMemory.Write(Pointer+56,value); } }
    [NativeMember("PreviousMusicTrackIndex")]
    public sbyte @PreviousMusicTrackIndex { get => SdkMemory.Read<sbyte >(Pointer+57); set { SdkMemory.Write(Pointer+57,value); } }
    [NativeMember("_pad")]
    public NativeArray<sbyte> @Pad { get => new NativeArray<sbyte>(Pointer+58,2); }
}
