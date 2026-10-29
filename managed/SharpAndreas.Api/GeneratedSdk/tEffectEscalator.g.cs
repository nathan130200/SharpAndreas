// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class tEffectEscalator : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=40;
    public tEffectEscalator(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_vecBottom")]
    public RwV3d @Bottom { get => new RwV3d(Pointer+0); set { SdkMemory.Copy(value.Pointer,Pointer+0,12); } }
    [NativeMember("m_vecTop")]
    public RwV3d @Top { get => new RwV3d(Pointer+12); set { SdkMemory.Copy(value.Pointer,Pointer+12,12); } }
    [NativeMember("m_vecEnd")]
    public RwV3d @End { get => new RwV3d(Pointer+24); set { SdkMemory.Copy(value.Pointer,Pointer+24,12); } }
    [NativeMember("m_nDirection")]
    public byte @Direction { get => SdkMemory.Read<byte >(Pointer+36); set { SdkMemory.Write(Pointer+36,value); } }
}
