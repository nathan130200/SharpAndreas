// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CAEStreamingChannel : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=393368;
    public CAEStreamingChannel(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("base")]
    public CAEAudioChannel @Base { get => new CAEAudioChannel(Pointer+0); set { SdkMemory.Copy(value.Pointer,Pointer+0,96); } }
    [NativeMember("field_60")]
    public byte @Field60 { get => SdkMemory.Read<byte >(Pointer+96); set { SdkMemory.Write(Pointer+96,value); } }
    [NativeMember("field_61")]
    public byte @Field61 { get => SdkMemory.Read<byte >(Pointer+97); set { SdkMemory.Write(Pointer+97,value); } }
    [NativeMember("field_62")]
    public byte @Field62 { get => SdkMemory.Read<byte >(Pointer+98); set { SdkMemory.Write(Pointer+98,value); } }
    [NativeMember("field_63")]
    public byte @Field63 { get => SdkMemory.Read<byte >(Pointer+99); set { SdkMemory.Write(Pointer+99,value); } }
    [NativeMember("field_64")]
    public byte @Field64 { get => SdkMemory.Read<byte >(Pointer+100); set { SdkMemory.Write(Pointer+100,value); } }
    [NativeMember("m_bFxEnabled")]
    public byte @FxEnabled { get => SdkMemory.Read<byte >(Pointer+101); set { SdkMemory.Write(Pointer+101,value); } }
    [NativeMember("field_66")]
    public byte @Field66 { get => SdkMemory.Read<byte >(Pointer+102); set { SdkMemory.Write(Pointer+102,value); } }
    [NativeMember("field_67")]
    public byte @Field67 { get => SdkMemory.Read<byte >(Pointer+103); set { SdkMemory.Write(Pointer+103,value); } }
    [NativeMember("field_68")]
    public uint @Field68 { get => SdkMemory.Read<uint >(Pointer+104); set { SdkMemory.Write(Pointer+104,value); } }
    [NativeMember("field_6C")]
    public NativeArray<byte> @Field6C { get => new NativeArray<byte>(Pointer+108,393216); }
    [NativeMember("field_6006C")]
    public uint @Field6006C { get => SdkMemory.Read<uint >(Pointer+393324); set { SdkMemory.Write(Pointer+393324,value); } }
    [NativeMember("m_pStreamingDecoder")]
    public uint @StreamingDecoder { get => SdkMemory.Read<uint >(Pointer+393328); set { SdkMemory.Write(Pointer+393328,value); } }
    [NativeMember("field_60074")]
    public uint @Field60074 { get => SdkMemory.Read<uint >(Pointer+393332); set { SdkMemory.Write(Pointer+393332,value); } }
    [NativeMember("field_60078")]
    public uint @Field60078 { get => SdkMemory.Read<uint >(Pointer+393336); set { SdkMemory.Write(Pointer+393336,value); } }
    [NativeMember("field_6007C")]
    public NativeArray<byte> @Field6007C { get => new NativeArray<byte>(Pointer+393340,8); }
    [NativeMember("field_60084")]
    public uint @Field60084 { get => SdkMemory.Read<uint >(Pointer+393348); set { SdkMemory.Write(Pointer+393348,value); } }
    [NativeMember("field_60088")]
    public int @Field60088 { get => SdkMemory.Read<int >(Pointer+393352); set { SdkMemory.Write(Pointer+393352,value); } }
    [NativeMember("field_6008C")]
    public int @Field6008C { get => SdkMemory.Read<int >(Pointer+393356); set { SdkMemory.Write(Pointer+393356,value); } }
    [NativeMember("m_pSoundBuffer")]
    public NativePointer<IntPtr> @SoundBuffer { get => new NativePointer<IntPtr>(SdkMemory.Read<IntPtr>(Pointer+393360)); set { SdkMemory.Write(Pointer+393360,value.Pointer); } }
    [NativeMember("field_60094")]
    public uint @Field60094 { get => SdkMemory.Read<uint >(Pointer+393364); set { SdkMemory.Write(Pointer+393364,value); } }
}
