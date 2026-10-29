// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class RwD3D9Vertex : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=28;
    public RwD3D9Vertex(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("x")]
    public float @X { get => SdkMemory.Read<float >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("y")]
    public float @Y { get => SdkMemory.Read<float >(Pointer+4); set { SdkMemory.Write(Pointer+4,value); } }
    [NativeMember("z")]
    public float @Z { get => SdkMemory.Read<float >(Pointer+8); set { SdkMemory.Write(Pointer+8,value); } }
    [NativeMember("rhw")]
    public float @Rhw { get => SdkMemory.Read<float >(Pointer+12); set { SdkMemory.Write(Pointer+12,value); } }
    [NativeMember("emissiveColor")]
    public uint @EmissiveColor { get => SdkMemory.Read<uint >(Pointer+16); set { SdkMemory.Write(Pointer+16,value); } }
    [NativeMember("u")]
    public float @U { get => SdkMemory.Read<float >(Pointer+20); set { SdkMemory.Write(Pointer+20,value); } }
    [NativeMember("v")]
    public float @V { get => SdkMemory.Read<float >(Pointer+24); set { SdkMemory.Write(Pointer+24,value); } }
}
