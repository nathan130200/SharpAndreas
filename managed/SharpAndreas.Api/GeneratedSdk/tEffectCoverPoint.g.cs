// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class tEffectCoverPoint : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=12;
    public tEffectCoverPoint(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_vecDirection")]
    public RwV2d @Direction { get => new RwV2d(Pointer+0); set { SdkMemory.Copy(value.Pointer,Pointer+0,8); } }
    [NativeMember("m_nType")]
    public byte @Type { get => SdkMemory.Read<byte >(Pointer+8); set { SdkMemory.Write(Pointer+8,value); } }
}
