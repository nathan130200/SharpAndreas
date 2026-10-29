// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class _rpD3D9VertexShaderDispatchDescriptor : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=8;
    public _rpD3D9VertexShaderDispatchDescriptor(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("offsetMaterialColor")]
    public byte @OffsetMaterialColor { get => SdkMemory.Read<byte >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("offsetFogRange")]
    public byte @OffsetFogRange { get => SdkMemory.Read<byte >(Pointer+1); set { SdkMemory.Write(Pointer+1,value); } }
    [NativeMember("offsetEffect")]
    public byte @OffsetEffect { get => SdkMemory.Read<byte >(Pointer+2); set { SdkMemory.Write(Pointer+2,value); } }
    [NativeMember("offsetMorphingCoef")]
    public byte @OffsetMorphingCoef { get => SdkMemory.Read<byte >(Pointer+3); set { SdkMemory.Write(Pointer+3,value); } }
    [NativeMember("offsetBoneMatrices")]
    public byte @OffsetBoneMatrices { get => SdkMemory.Read<byte >(Pointer+4); set { SdkMemory.Write(Pointer+4,value); } }
    [NativeMember("pad")]
    public NativeArray<byte> @Pad { get => new NativeArray<byte>(Pointer+5,3); }
}
