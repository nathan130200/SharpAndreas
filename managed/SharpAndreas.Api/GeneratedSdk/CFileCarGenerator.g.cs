// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CFileCarGenerator : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=46;
    public CFileCarGenerator(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_vecPosn")]
    public CVector @Position { get => new CVector(Pointer+0); set { SdkMemory.Copy(value.Pointer,Pointer+0,12); } }
    [NativeMember("m_fAngle")]
    public float @Angle { get => SdkMemory.Read<float >(Pointer+12); set { SdkMemory.Write(Pointer+12,value); } }
    [NativeMember("m_nModelId")]
    public uint @ModelId { get => SdkMemory.Read<uint >(Pointer+16); set { SdkMemory.Write(Pointer+16,value); } }
    [NativeMember("m_nColor1")]
    public ushort @Color1 { get => SdkMemory.Read<ushort >(Pointer+20); set { SdkMemory.Write(Pointer+20,value); } }
    [NativeMember("m_nColor2")]
    public ushort @Color2 { get => SdkMemory.Read<ushort >(Pointer+24); set { SdkMemory.Write(Pointer+24,value); } }
    [NativeMember("m_nFlags")]
    public byte @Flags { get => SdkMemory.Read<byte >(Pointer+28); set { SdkMemory.Write(Pointer+28,value); } }
    [NativeMember("m_nAlarm")]
    public byte @Alarm { get => SdkMemory.Read<byte >(Pointer+32); set { SdkMemory.Write(Pointer+32,value); } }
    [NativeMember("m_nDoorLock")]
    public byte @DoorLock { get => SdkMemory.Read<byte >(Pointer+36); set { SdkMemory.Write(Pointer+36,value); } }
    [NativeMember("m_nMinDelay")]
    public ushort @MinDelay { get => SdkMemory.Read<ushort >(Pointer+40); set { SdkMemory.Write(Pointer+40,value); } }
    [NativeMember("m_nMaxDelay")]
    public ushort @MaxDelay { get => SdkMemory.Read<ushort >(Pointer+44); set { SdkMemory.Write(Pointer+44,value); } }
}
