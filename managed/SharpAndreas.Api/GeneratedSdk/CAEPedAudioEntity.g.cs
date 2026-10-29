// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CAEPedAudioEntity : CAEAudioEntity
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=348;
    public CAEPedAudioEntity(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("field_7C")]
    public sbyte @Field7C { get => SdkMemory.Read<sbyte >(Pointer+124); set { SdkMemory.Write(Pointer+124,value); } }
    [NativeMember("field_7D")]
    public sbyte @Field7D { get => SdkMemory.Read<sbyte >(Pointer+125); set { SdkMemory.Write(Pointer+125,value); } }
    [NativeMember("field_7E")]
    public short @Field7E { get => SdkMemory.Read<short >(Pointer+126); set { SdkMemory.Write(Pointer+126,value); } }
    [NativeMember("field_80")]
    public int @Field80 { get => SdkMemory.Read<int >(Pointer+128); set { SdkMemory.Write(Pointer+128,value); } }
    [NativeMember("field_84")]
    public float @Field84 { get => SdkMemory.Read<float >(Pointer+132); set { SdkMemory.Write(Pointer+132,value); } }
    [NativeMember("field_88")]
    public float @Field88 { get => SdkMemory.Read<float >(Pointer+136); set { SdkMemory.Write(Pointer+136,value); } }
    [NativeMember("field_8C")]
    public NativeArray<sbyte> @Field8C { get => new NativeArray<sbyte>(Pointer+140,8); }
    [NativeMember("m_pPed")]
    public CPed? @Ped { get => SdkMemory.Read<IntPtr>(Pointer+148) == IntPtr.Zero ? null : new CPed(SdkMemory.Read<IntPtr>(Pointer+148)); set { SdkMemory.Write(Pointer+148,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("field_98")]
    public sbyte @Field98 { get => SdkMemory.Read<sbyte >(Pointer+152); set { SdkMemory.Write(Pointer+152,value); } }
    [NativeMember("field_99")]
    public NativeArray<sbyte> @Field99 { get => new NativeArray<sbyte>(Pointer+153,3); }
    [NativeMember("field_9C")]
    public CAESound? @Field9C { get => SdkMemory.Read<IntPtr>(Pointer+156) == IntPtr.Zero ? null : new CAESound(SdkMemory.Read<IntPtr>(Pointer+156)); set { SdkMemory.Write(Pointer+156,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("field_A0")]
    public int @FieldA0 { get => SdkMemory.Read<int >(Pointer+160); set { SdkMemory.Write(Pointer+160,value); } }
    [NativeMember("field_A4")]
    public CAESound? @FieldA4 { get => SdkMemory.Read<IntPtr>(Pointer+164) == IntPtr.Zero ? null : new CAESound(SdkMemory.Read<IntPtr>(Pointer+164)); set { SdkMemory.Write(Pointer+164,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("TwinLoopSoundEntity")]
    public CAETwinLoopSoundEntity @TwinLoopSoundEntity { get => new CAETwinLoopSoundEntity(Pointer+168); set { SdkMemory.Copy(value.Pointer,Pointer+168,168); } }
    [NativeMember("field_150")]
    public CAESound? @Field150 { get => SdkMemory.Read<IntPtr>(Pointer+336) == IntPtr.Zero ? null : new CAESound(SdkMemory.Read<IntPtr>(Pointer+336)); set { SdkMemory.Write(Pointer+336,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("field_154")]
    public float @Field154 { get => SdkMemory.Read<float >(Pointer+340); set { SdkMemory.Write(Pointer+340,value); } }
    [NativeMember("field_158")]
    public float @Field158 { get => SdkMemory.Read<float >(Pointer+344); set { SdkMemory.Write(Pointer+344,value); } }
}
