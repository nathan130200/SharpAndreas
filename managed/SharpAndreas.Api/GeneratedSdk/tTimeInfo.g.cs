// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class tTimeInfo : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=4;
    public tTimeInfo(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_nTimeOn")]
    public byte @TimeOn { get => SdkMemory.Read<byte >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("m_nTimeOff")]
    public byte @TimeOff { get => SdkMemory.Read<byte >(Pointer+1); set { SdkMemory.Write(Pointer+1,value); } }
    [NativeMember("m_wOtherTimeModel")]
    public short @OtherTimeModel { get => SdkMemory.Read<short >(Pointer+2); set { SdkMemory.Write(Pointer+2,value); } }
}
