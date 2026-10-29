// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CAEStreamThread : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=80;
    public CAEStreamThread(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("hHandle")]
    public NativePointer<IntPtr> @HHandle { get => new NativePointer<IntPtr>(SdkMemory.Read<IntPtr>(Pointer+0)); set { SdkMemory.Write(Pointer+0,value.Pointer); } }
    [NativeMember("field_4")]
    public int @Field4 { get => SdkMemory.Read<int >(Pointer+4); set { SdkMemory.Write(Pointer+4,value); } }
    [NativeMember("m_pStreamingChannel")]
    public NativePointer<IntPtr> @StreamingChannel { get => new NativePointer<IntPtr>(SdkMemory.Read<IntPtr>(Pointer+8)); set { SdkMemory.Write(Pointer+8,value.Pointer); } }
    [NativeMember("m_pMp3TrackLoader")]
    public int @Mp3TrackLoader { get => SdkMemory.Read<int >(Pointer+12); set { SdkMemory.Write(Pointer+12,value); } }
    [NativeMember("m_bActive")]
    public sbyte @Active { get => SdkMemory.Read<sbyte >(Pointer+16); set { SdkMemory.Write(Pointer+16,value); } }
    [NativeMember("field_11")]
    public sbyte @Field11 { get => SdkMemory.Read<sbyte >(Pointer+17); set { SdkMemory.Write(Pointer+17,value); } }
    [NativeMember("field_12")]
    public byte @Field12 { get => SdkMemory.Read<byte >(Pointer+18); set { SdkMemory.Write(Pointer+18,value); } }
    [NativeMember("field_13")]
    public byte @Field13 { get => SdkMemory.Read<byte >(Pointer+19); set { SdkMemory.Write(Pointer+19,value); } }
    [NativeMember("field_14")]
    public byte @Field14 { get => SdkMemory.Read<byte >(Pointer+20); set { SdkMemory.Write(Pointer+20,value); } }
    [NativeMember("field_15")]
    public sbyte @Field15 { get => SdkMemory.Read<sbyte >(Pointer+21); set { SdkMemory.Write(Pointer+21,value); } }
    [NativeMember("m_bTrackStopped")]
    public sbyte @TrackStopped { get => SdkMemory.Read<sbyte >(Pointer+22); set { SdkMemory.Write(Pointer+22,value); } }
    [NativeMember("field_17")]
    public sbyte @Field17 { get => SdkMemory.Read<sbyte >(Pointer+23); set { SdkMemory.Write(Pointer+23,value); } }
    [NativeMember("field_18")]
    public int @Field18 { get => SdkMemory.Read<int >(Pointer+24); set { SdkMemory.Write(Pointer+24,value); } }
    [NativeMember("field_1C")]
    public uint @Field1C { get => SdkMemory.Read<uint >(Pointer+28); set { SdkMemory.Write(Pointer+28,value); } }
    [NativeMember("field_20")]
    public uint @Field20 { get => SdkMemory.Read<uint >(Pointer+32); set { SdkMemory.Write(Pointer+32,value); } }
    [NativeMember("field_24")]
    public byte @Field24 { get => SdkMemory.Read<byte >(Pointer+36); set { SdkMemory.Write(Pointer+36,value); } }
    [NativeMember("field_25")]
    public sbyte @Field25 { get => SdkMemory.Read<sbyte >(Pointer+37); set { SdkMemory.Write(Pointer+37,value); } }
    [NativeMember("field_26")]
    public sbyte @Field26 { get => SdkMemory.Read<sbyte >(Pointer+38); set { SdkMemory.Write(Pointer+38,value); } }
    [NativeMember("field_27")]
    public sbyte @Field27 { get => SdkMemory.Read<sbyte >(Pointer+39); set { SdkMemory.Write(Pointer+39,value); } }
    [NativeMember("field_28")]
    public int @Field28 { get => SdkMemory.Read<int >(Pointer+40); set { SdkMemory.Write(Pointer+40,value); } }
    [NativeMember("m_nTrackLenghtMs")]
    public int @TrackLenghtMs { get => SdkMemory.Read<int >(Pointer+44); set { SdkMemory.Write(Pointer+44,value); } }
    [NativeMember("m_nActiveTrackID")]
    public int @ActiveTrackID { get => SdkMemory.Read<int >(Pointer+48); set { SdkMemory.Write(Pointer+48,value); } }
    [NativeMember("m_nPlayingTrackID")]
    public int @PlayingTrackID { get => SdkMemory.Read<int >(Pointer+52); set { SdkMemory.Write(Pointer+52,value); } }
    [NativeMember("m_criticalSection")]
    public _RTL_CRITICAL_SECTION @CriticalSection { get => new _RTL_CRITICAL_SECTION(Pointer+56); set { SdkMemory.Copy(value.Pointer,Pointer+56,24); } }
    public bool @Initialise(NativePointer<IntPtr> @channel) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D250 >(250)(Pointer,@channel.Pointer); return __sdkResult != 0; }
    public int @GetActiveTrackID() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D251 >(251)(Pointer); return __sdkResult; }
}
