// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class _rpD3D9VertexShaderDescriptor : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=4;
    public _rpD3D9VertexShaderDescriptor(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("numDirectionalLights")]
    public byte @CountDirectionalLights { get => (byte)SdkMemory.ReadBits(Pointer,0,4); set { SdkMemory.WriteBits(Pointer,0,4,unchecked((ulong)value)); } }
    [NativeMember("numPointLights")]
    public byte @CountPointLights { get => (byte)SdkMemory.ReadBits(Pointer,4,4); set { SdkMemory.WriteBits(Pointer,4,4,unchecked((ulong)value)); } }
    [NativeMember("numSpotLights")]
    public byte @CountSpotLights { get => (byte)SdkMemory.ReadBits(Pointer,8,4); set { SdkMemory.WriteBits(Pointer,8,4,unchecked((ulong)value)); } }
    [NativeMember("numTexCoords")]
    public byte @CountTexCoordinates { get => (byte)SdkMemory.ReadBits(Pointer,12,4); set { SdkMemory.WriteBits(Pointer,12,4,unchecked((ulong)value)); } }
    [NativeMember("morphing")]
    public byte @Morphing { get => (byte)SdkMemory.ReadBits(Pointer,16,1); set { SdkMemory.WriteBits(Pointer,16,1,unchecked((ulong)value)); } }
    [NativeMember("numWeights")]
    public byte @CountWeights { get => (byte)SdkMemory.ReadBits(Pointer,17,3); set { SdkMemory.WriteBits(Pointer,17,3,unchecked((ulong)value)); } }
    [NativeMember("prelit")]
    public byte @Prelit { get => (byte)SdkMemory.ReadBits(Pointer,20,1); set { SdkMemory.WriteBits(Pointer,20,1,unchecked((ulong)value)); } }
    [NativeMember("normals")]
    public byte @Normals { get => (byte)SdkMemory.ReadBits(Pointer,21,1); set { SdkMemory.WriteBits(Pointer,21,1,unchecked((ulong)value)); } }
    [NativeMember("normalizeNormals")]
    public byte @NormalizeNormals { get => (byte)SdkMemory.ReadBits(Pointer,22,1); set { SdkMemory.WriteBits(Pointer,22,1,unchecked((ulong)value)); } }
    [NativeMember("modulateMaterial")]
    public byte @ModulateMaterial { get => (byte)SdkMemory.ReadBits(Pointer,23,1); set { SdkMemory.WriteBits(Pointer,23,1,unchecked((ulong)value)); } }
    [NativeMember("fogMode")]
    public byte @FogMode { get => (byte)SdkMemory.ReadBits(Pointer,24,2); set { SdkMemory.WriteBits(Pointer,24,2,unchecked((ulong)value)); } }
    [NativeMember("effect")]
    public byte @Effect { get => (byte)SdkMemory.ReadBits(Pointer,26,6); set { SdkMemory.WriteBits(Pointer,26,6,unchecked((ulong)value)); } }
}
