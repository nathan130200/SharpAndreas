// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CGangInfo : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=16;
    public CGangInfo(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_nPedModelOverride")]
    public sbyte @PedModelOverride { get => SdkMemory.Read<sbyte >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("m_nGangWeapons")]
    public NativeArray<int> @GangWeapons { get => new NativeArray<int>(Pointer+4,3); }
}
