// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CCarPathLink : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=14;
    public CCarPathLink(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_vecPosn")]
    public CompressedVector2D @Position { get => new CompressedVector2D(Pointer+0); set { SdkMemory.Copy(value.Pointer,Pointer+0,4); } }
    [NativeMember("m_address")]
    public CNodeAddress @Address { get => new CNodeAddress(Pointer+4); set { SdkMemory.Copy(value.Pointer,Pointer+4,4); } }
    [NativeMember("m_nDirX")]
    public sbyte @DirectionX { get => SdkMemory.Read<sbyte >(Pointer+8); set { SdkMemory.Write(Pointer+8,value); } }
    [NativeMember("m_nDirY")]
    public sbyte @DirectionY { get => SdkMemory.Read<sbyte >(Pointer+9); set { SdkMemory.Write(Pointer+9,value); } }
    [NativeMember("m_nPathNodeWidth")]
    public sbyte @PathNodeWidth { get => SdkMemory.Read<sbyte >(Pointer+10); set { SdkMemory.Write(Pointer+10,value); } }
    [NativeMember("m_nNumLeftLanes")]
    public byte @CountLeftLanes { get => (byte)SdkMemory.ReadBits(Pointer,88,3); set { SdkMemory.WriteBits(Pointer,88,3,unchecked((ulong)value)); } }
    [NativeMember("m_nNumRightLanes")]
    public byte @CountRightLanes { get => (byte)SdkMemory.ReadBits(Pointer,91,3); set { SdkMemory.WriteBits(Pointer,91,3,unchecked((ulong)value)); } }
    [NativeMember("m_bTrafficLightDirection")]
    public byte @TrafficLightDirection { get => (byte)SdkMemory.ReadBits(Pointer,94,1); set { SdkMemory.WriteBits(Pointer,94,1,unchecked((ulong)value)); } }
    [NativeMember("unk1")]
    public byte @Unk1 { get => (byte)SdkMemory.ReadBits(Pointer,95,1); set { SdkMemory.WriteBits(Pointer,95,1,unchecked((ulong)value)); } }
    [NativeMember("m_nTrafficLightState")]
    public byte @TrafficLightState { get => (byte)SdkMemory.ReadBits(Pointer,96,2); set { SdkMemory.WriteBits(Pointer,96,2,unchecked((ulong)value)); } }
    [NativeMember("m_bTrainCrossing")]
    public byte @TrainCrossing { get => (byte)SdkMemory.ReadBits(Pointer,98,1); set { SdkMemory.WriteBits(Pointer,98,1,unchecked((ulong)value)); } }
    public float @OneWayLaneOffset() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D784 >(784)(Pointer); return __sdkResult; }
}
