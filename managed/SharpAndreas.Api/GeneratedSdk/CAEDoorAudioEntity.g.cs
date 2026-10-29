// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CAEDoorAudioEntity : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=136;
    public CAEDoorAudioEntity(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("audio")]
    public CAEAudioEntity @Audio { get => new CAEAudioEntity(Pointer+0); set { SdkMemory.Copy(value.Pointer,Pointer+0,124); } }
    [NativeMember("m_nTime")]
    public uint @Time { get => SdkMemory.Read<uint >(Pointer+124); set { SdkMemory.Write(Pointer+124,value); } }
    [NativeMember("field_80")]
    public uint @Field80 { get => SdkMemory.Read<uint >(Pointer+128); set { SdkMemory.Write(Pointer+128,value); } }
    [NativeMember("field_84")]
    public uint @Field84 { get => SdkMemory.Read<uint >(Pointer+132); set { SdkMemory.Write(Pointer+132,value); } }
}
