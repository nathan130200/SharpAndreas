// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class RwVideoMode : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=24;
    public RwVideoMode(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("width")]
    public int @Width { get => SdkMemory.Read<int >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("height")]
    public int @Height { get => SdkMemory.Read<int >(Pointer+4); set { SdkMemory.Write(Pointer+4,value); } }
    [NativeMember("depth")]
    public int @Depth { get => SdkMemory.Read<int >(Pointer+8); set { SdkMemory.Write(Pointer+8,value); } }
    [NativeMember("flags")]
    public RwVideoModeFlag @Flags { get => SdkMemory.Read<RwVideoModeFlag >(Pointer+12); set { SdkMemory.Write(Pointer+12,value); } }
    [NativeMember("refRate")]
    public int @RefRate { get => SdkMemory.Read<int >(Pointer+16); set { SdkMemory.Write(Pointer+16,value); } }
    [NativeMember("format")]
    public int @Format { get => SdkMemory.Read<int >(Pointer+20); set { SdkMemory.Write(Pointer+20,value); } }
}
