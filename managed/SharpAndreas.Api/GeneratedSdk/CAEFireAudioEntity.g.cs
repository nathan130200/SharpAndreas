// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CAEFireAudioEntity : CAEAudioEntity
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=136;
    public CAEFireAudioEntity(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("field_7C")]
    public CAESound? @Field7C { get => SdkMemory.Read<IntPtr>(Pointer+124) == IntPtr.Zero ? null : new CAESound(SdkMemory.Read<IntPtr>(Pointer+124)); set { SdkMemory.Write(Pointer+124,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("field_80")]
    public CAESound? @Field80 { get => SdkMemory.Read<IntPtr>(Pointer+128) == IntPtr.Zero ? null : new CAESound(SdkMemory.Read<IntPtr>(Pointer+128)); set { SdkMemory.Write(Pointer+128,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("field_84")]
    public FxSystem_c? @Field84 { get => SdkMemory.Read<IntPtr>(Pointer+132) == IntPtr.Zero ? null : new FxSystem_c(SdkMemory.Read<IntPtr>(Pointer+132)); set { SdkMemory.Write(Pointer+132,value?.Pointer ?? IntPtr.Zero); } }
}
