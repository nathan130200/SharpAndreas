// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class tEffectEnEx : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=48;
    public tEffectEnEx(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_fEnterAngle")]
    public float @EnterAngle { get => SdkMemory.Read<float >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("m_vecSize")]
    public RwV3d @Size { get => new RwV3d(Pointer+4); set { SdkMemory.Copy(value.Pointer,Pointer+4,12); } }
    [NativeMember("m_vecExitPosn")]
    public RwV3d @ExitPosition { get => new RwV3d(Pointer+16); set { SdkMemory.Copy(value.Pointer,Pointer+16,12); } }
    [NativeMember("m_fExitAngle")]
    public float @ExitAngle { get => SdkMemory.Read<float >(Pointer+28); set { SdkMemory.Write(Pointer+28,value); } }
    [NativeMember("m_nInteriorId")]
    public short @InteriorId { get => SdkMemory.Read<short >(Pointer+32); set { SdkMemory.Write(Pointer+32,value); } }
    [NativeMember("m_nFlags1")]
    public byte @Flags1 { get => SdkMemory.Read<byte >(Pointer+34); set { SdkMemory.Write(Pointer+34,value); } }
    [NativeMember("m_nSkyColor")]
    public byte @SkyColor { get => SdkMemory.Read<byte >(Pointer+35); set { SdkMemory.Write(Pointer+35,value); } }
    [NativeMember("m_szInteriorName")]
    public NativeArray<sbyte> @InteriorName { get => new NativeArray<sbyte>(Pointer+36,8); }
    [NativeMember("m_nTimeOn")]
    public byte @TimeOn { get => SdkMemory.Read<byte >(Pointer+44); set { SdkMemory.Write(Pointer+44,value); } }
    [NativeMember("m_nTimeOff")]
    public byte @TimeOff { get => SdkMemory.Read<byte >(Pointer+45); set { SdkMemory.Write(Pointer+45,value); } }
    [NativeMember("m_nFlags2")]
    public byte @Flags2 { get => SdkMemory.Read<byte >(Pointer+46); set { SdkMemory.Write(Pointer+46,value); } }
}
