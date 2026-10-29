// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class tStreamingFileDesc : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=48;
    public tStreamingFileDesc(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_szName")]
    public NativeArray<sbyte> @Name { get => new NativeArray<sbyte>(Pointer+0,40); }
    [NativeMember("bNotPlayerImg")]
    public bool @NotPlayerImg { get => SdkMemory.Read<bool >(Pointer+40); set { SdkMemory.Write(Pointer+40,value); } }
    [NativeMember("__pad")]
    public NativeArray<sbyte> @Pad { get => new NativeArray<sbyte>(Pointer+41,3); }
    [NativeMember("m_StreamHandle")]
    public int @StreamHandle { get => SdkMemory.Read<int >(Pointer+44); set { SdkMemory.Write(Pointer+44,value); } }
}
