// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class RwMatrixTag : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=64;
    public RwMatrixTag(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("right")]
    public RwV3d @Right { get => new RwV3d(Pointer+0); set { SdkMemory.Copy(value.Pointer,Pointer+0,12); } }
    [NativeMember("flags")]
    public uint @Flags { get => SdkMemory.Read<uint >(Pointer+12); set { SdkMemory.Write(Pointer+12,value); } }
    [NativeMember("up")]
    public RwV3d @Up { get => new RwV3d(Pointer+16); set { SdkMemory.Copy(value.Pointer,Pointer+16,12); } }
    [NativeMember("pad1")]
    public uint @Pad1 { get => SdkMemory.Read<uint >(Pointer+28); set { SdkMemory.Write(Pointer+28,value); } }
    [NativeMember("at")]
    public RwV3d @At { get => new RwV3d(Pointer+32); set { SdkMemory.Copy(value.Pointer,Pointer+32,12); } }
    [NativeMember("pad2")]
    public uint @Pad2 { get => SdkMemory.Read<uint >(Pointer+44); set { SdkMemory.Write(Pointer+44,value); } }
    [NativeMember("pos")]
    public RwV3d @Position { get => new RwV3d(Pointer+48); set { SdkMemory.Copy(value.Pointer,Pointer+48,12); } }
    [NativeMember("pad3")]
    public uint @Pad3 { get => SdkMemory.Read<uint >(Pointer+60); set { SdkMemory.Write(Pointer+60,value); } }
}
