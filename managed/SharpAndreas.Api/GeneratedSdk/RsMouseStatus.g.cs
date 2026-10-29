// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class RsMouseStatus : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=24;
    public RsMouseStatus(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("pos")]
    public RwV2d @Position { get => new RwV2d(Pointer+0); set { SdkMemory.Copy(value.Pointer,Pointer+0,8); } }
    [NativeMember("delta")]
    public RwV2d @Delta { get => new RwV2d(Pointer+8); set { SdkMemory.Copy(value.Pointer,Pointer+8,8); } }
    [NativeMember("shift")]
    public int @Shift { get => SdkMemory.Read<int >(Pointer+16); set { SdkMemory.Write(Pointer+16,value); } }
    [NativeMember("control")]
    public int @Control { get => SdkMemory.Read<int >(Pointer+20); set { SdkMemory.Write(Pointer+20,value); } }
}
