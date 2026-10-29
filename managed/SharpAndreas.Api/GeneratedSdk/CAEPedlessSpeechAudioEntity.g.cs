// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CAEPedlessSpeechAudioEntity : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=256;
    public CAEPedlessSpeechAudioEntity(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("pedSpeech")]
    public CAEPedSpeechAudioEntity @PedSpeech { get => new CAEPedSpeechAudioEntity(Pointer+0); set { SdkMemory.Copy(value.Pointer,Pointer+0,256); } }
}
