// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CAEAudioChannel : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=96;
    public CAEAudioChannel(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("vtable")]
    public NativePointer<IntPtr> @Vtable { get => new NativePointer<IntPtr>(SdkMemory.Read<IntPtr>(Pointer+0)); set { SdkMemory.Write(Pointer+0,value.Pointer); } }
    [NativeMember("m_pDirectSound")]
    public NativePointer<IntPtr> @DirectSound { get => new NativePointer<IntPtr>(SdkMemory.Read<IntPtr>(Pointer+4)); set { SdkMemory.Write(Pointer+4,value.Pointer); } }
    [NativeMember("m_pDirectSoundBuffer")]
    public NativePointer<IntPtr> @DirectSoundBuffer { get => new NativePointer<IntPtr>(SdkMemory.Read<IntPtr>(Pointer+8)); set { SdkMemory.Write(Pointer+8,value.Pointer); } }
    [NativeMember("m_pDirectSound3DBuffer")]
    public NativePointer<IntPtr> @DirectSound3DBuffer { get => new NativePointer<IntPtr>(SdkMemory.Read<IntPtr>(Pointer+12)); set { SdkMemory.Write(Pointer+12,value.Pointer); } }
    [NativeMember("gap10")]
    public NativeArray<byte> @Gap10 { get => new NativeArray<byte>(Pointer+16,24); }
    [NativeMember("m_nFlags")]
    public uint @Flags { get => SdkMemory.Read<uint >(Pointer+40); set { SdkMemory.Write(Pointer+40,value); } }
    [NativeMember("m_nLengthInBytes")]
    public int @LengthInBytes { get => SdkMemory.Read<int >(Pointer+44); set { SdkMemory.Write(Pointer+44,value); } }
    [NativeMember("field_30")]
    public int @Field30 { get => SdkMemory.Read<int >(Pointer+48); set { SdkMemory.Write(Pointer+48,value); } }
    [NativeMember("m_fVolume")]
    public float @Volume { get => SdkMemory.Read<float >(Pointer+52); set { SdkMemory.Write(Pointer+52,value); } }
    [NativeMember("field_38")]
    public byte @Field38 { get => SdkMemory.Read<byte >(Pointer+56); set { SdkMemory.Write(Pointer+56,value); } }
    [NativeMember("field_39")]
    public sbyte @Field39 { get => SdkMemory.Read<sbyte >(Pointer+57); set { SdkMemory.Write(Pointer+57,value); } }
    [NativeMember("field_3A")]
    public short @Field3A { get => SdkMemory.Read<short >(Pointer+58); set { SdkMemory.Write(Pointer+58,value); } }
    [NativeMember("m_nFrequency")]
    public uint @Frequency { get => SdkMemory.Read<uint >(Pointer+60); set { SdkMemory.Write(Pointer+60,value); } }
    [NativeMember("m_nOriginalFrequency")]
    public uint @OriginalFrequency { get => SdkMemory.Read<uint >(Pointer+64); set { SdkMemory.Write(Pointer+64,value); } }
    [NativeMember("m_bLooped")]
    public bool @Looped { get => SdkMemory.Read<bool >(Pointer+68); set { SdkMemory.Write(Pointer+68,value); } }
    [NativeMember("field_45")]
    public byte @Field45 { get => SdkMemory.Read<byte >(Pointer+69); set { SdkMemory.Write(Pointer+69,value); } }
    [NativeMember("field_46")]
    public NativeArray<byte> @Field46 { get => new NativeArray<byte>(Pointer+70,1); }
    [NativeMember("field_47")]
    public ushort @Field47 { get => SdkMemory.Read<ushort >(Pointer+72); set { SdkMemory.Write(Pointer+72,value); } }
    [NativeMember("field_49")]
    public ushort @Field49 { get => SdkMemory.Read<ushort >(Pointer+74); set { SdkMemory.Write(Pointer+74,value); } }
    [NativeMember("field_4B")]
    public uint @Field4B { get => SdkMemory.Read<uint >(Pointer+76); set { SdkMemory.Write(Pointer+76,value); } }
    [NativeMember("field_4F")]
    public uint @Field4F { get => SdkMemory.Read<uint >(Pointer+80); set { SdkMemory.Write(Pointer+80,value); } }
    [NativeMember("field_53")]
    public ushort @Field53 { get => SdkMemory.Read<ushort >(Pointer+84); set { SdkMemory.Write(Pointer+84,value); } }
    [NativeMember("m_nBitsPerSample")]
    public byte @BitsPerSample { get => SdkMemory.Read<byte >(Pointer+86); set { SdkMemory.Write(Pointer+86,value); } }
    [NativeMember("field_57")]
    public byte @Field57 { get => SdkMemory.Read<byte >(Pointer+87); set { SdkMemory.Write(Pointer+87,value); } }
    [NativeMember("field_59")]
    public NativeArray<sbyte> @Field59 { get => new NativeArray<sbyte>(Pointer+88,3); }
    [NativeMember("m_nBufferStatus")]
    public uint @BufferStatus { get => SdkMemory.Read<uint >(Pointer+92); set { SdkMemory.Write(Pointer+92,value); } }
}
