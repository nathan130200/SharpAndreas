// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CAEFrontendAudioEntity : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=156;
    public CAEFrontendAudioEntity(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("audio")]
    public CAEAudioEntity @Audio { get => new CAEAudioEntity(Pointer+0); set { SdkMemory.Copy(value.Pointer,Pointer+0,124); } }
    [NativeMember("byte7C")]
    public byte @Byte7C { get => SdkMemory.Read<byte >(Pointer+124); set { SdkMemory.Write(Pointer+124,value); } }
    [NativeMember("byte7D")]
    public byte @Byte7D { get => SdkMemory.Read<byte >(Pointer+125); set { SdkMemory.Write(Pointer+125,value); } }
    [NativeMember("f7E")]
    public NativeArray<byte> @F7E { get => new NativeArray<byte>(Pointer+126,2); }
    [NativeMember("m_nNumBulletSounds")]
    public ushort @CountBulletSounds { get => SdkMemory.Read<ushort >(Pointer+128); set { SdkMemory.Write(Pointer+128,value); } }
    [NativeMember("bankId")]
    public ushort @BankId { get => SdkMemory.Read<ushort >(Pointer+130); set { SdkMemory.Write(Pointer+130,value); } }
    [NativeMember("m_dwLastFrameGeneral")]
    public uint @LastFrameGeneral { get => SdkMemory.Read<uint >(Pointer+132); set { SdkMemory.Write(Pointer+132,value); } }
    [NativeMember("m_dwLastFrameMissionComplete")]
    public uint @LastFrameMissionComplete { get => SdkMemory.Read<uint >(Pointer+136); set { SdkMemory.Write(Pointer+136,value); } }
    [NativeMember("m_dwLastFrameBulletPass")]
    public uint @LastFrameBulletPass { get => SdkMemory.Read<uint >(Pointer+140); set { SdkMemory.Write(Pointer+140,value); } }
    [NativeMember("m_dwLastTimeCarRespray")]
    public uint @LastTimeCarRespray { get => SdkMemory.Read<uint >(Pointer+144); set { SdkMemory.Write(Pointer+144,value); } }
    [NativeMember("dword94")]
    public uint @Dword94 { get => SdkMemory.Read<uint >(Pointer+148); set { SdkMemory.Write(Pointer+148,value); } }
    [NativeMember("dword98")]
    public uint @Dword98 { get => SdkMemory.Read<uint >(Pointer+152); set { SdkMemory.Write(Pointer+152,value); } }
}
