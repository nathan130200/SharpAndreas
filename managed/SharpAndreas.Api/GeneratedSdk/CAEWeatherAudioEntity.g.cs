// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CAEWeatherAudioEntity : CAEAudioEntity
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=128;
    public CAEWeatherAudioEntity(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_nThunderFrequencyVariationCounter")]
    public byte @ThunderFrequencyVariationCounter { get => SdkMemory.Read<byte >(Pointer+124); set { SdkMemory.Write(Pointer+124,value); } }
}
