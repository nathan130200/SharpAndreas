// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CAEScriptAudioEntity : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=540;
    public CAEScriptAudioEntity(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("audio")]
    public CAEAudioEntity @Audio { get => new CAEAudioEntity(Pointer+0); set { SdkMemory.Copy(value.Pointer,Pointer+0,124); } }
    [NativeMember("field_7C")]
    public sbyte @Field7C { get => SdkMemory.Read<sbyte >(Pointer+124); set { SdkMemory.Write(Pointer+124,value); } }
    [NativeMember("field_7D")]
    public sbyte @Field7D { get => SdkMemory.Read<sbyte >(Pointer+125); set { SdkMemory.Write(Pointer+125,value); } }
    [NativeMember("field_7E")]
    public sbyte @Field7E { get => SdkMemory.Read<sbyte >(Pointer+126); set { SdkMemory.Write(Pointer+126,value); } }
    [NativeMember("m_dwLastTimeHornPlayed")]
    public int @LastTimeHornPlayed { get => SdkMemory.Read<int >(Pointer+128); set { SdkMemory.Write(Pointer+128,value); } }
    [NativeMember("field_84")]
    public int @Field84 { get => SdkMemory.Read<int >(Pointer+132); set { SdkMemory.Write(Pointer+132,value); } }
    [NativeMember("field_88")]
    public float @Field88 { get => SdkMemory.Read<float >(Pointer+136); set { SdkMemory.Write(Pointer+136,value); } }
    [NativeMember("field_8C")]
    public float @Field8C { get => SdkMemory.Read<float >(Pointer+140); set { SdkMemory.Write(Pointer+140,value); } }
    [NativeMember("wavLinks")]
    public NativeObjectArray<CAudioLink> @WavLinks { get => new NativeObjectArray<CAudioLink>(Pointer+144,4,32); }
    [NativeMember("field_110")]
    public int @Field110 { get => SdkMemory.Read<int >(Pointer+272); set { SdkMemory.Write(Pointer+272,value); } }
    [NativeMember("field_114")]
    public CAEDoorAudioEntity @Field114 { get => new CAEDoorAudioEntity(Pointer+276); set { SdkMemory.Copy(value.Pointer,Pointer+276,136); } }
    [NativeMember("m_explosionAudio")]
    public CAEExplosionAudioEntity @ExplosionAudio { get => new CAEExplosionAudioEntity(Pointer+412); set { SdkMemory.Copy(value.Pointer,Pointer+412,128); } }
}
