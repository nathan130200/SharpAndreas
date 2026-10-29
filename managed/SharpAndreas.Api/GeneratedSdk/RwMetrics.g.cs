// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class RwMetrics : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=28;
    public RwMetrics(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("numTriangles")]
    public uint @CountTriangles { get => SdkMemory.Read<uint >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("numProcTriangles")]
    public uint @CountProcTriangles { get => SdkMemory.Read<uint >(Pointer+4); set { SdkMemory.Write(Pointer+4,value); } }
    [NativeMember("numVertices")]
    public uint @CountVertices { get => SdkMemory.Read<uint >(Pointer+8); set { SdkMemory.Write(Pointer+8,value); } }
    [NativeMember("numTextureUploads")]
    public uint @CountTextureUploads { get => SdkMemory.Read<uint >(Pointer+12); set { SdkMemory.Write(Pointer+12,value); } }
    [NativeMember("sizeTextureUploads")]
    public uint @SizeTextureUploads { get => SdkMemory.Read<uint >(Pointer+16); set { SdkMemory.Write(Pointer+16,value); } }
    [NativeMember("numResourceAllocs")]
    public uint @CountResourceAllocs { get => SdkMemory.Read<uint >(Pointer+20); set { SdkMemory.Write(Pointer+20,value); } }
    [NativeMember("devSpecificMetrics")]
    public NativePointer<IntPtr> @DevSpecificMetrics { get => new NativePointer<IntPtr>(SdkMemory.Read<IntPtr>(Pointer+24)); set { SdkMemory.Write(Pointer+24,value.Pointer); } }
}
