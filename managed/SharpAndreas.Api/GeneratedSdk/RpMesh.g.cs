// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class RpMesh : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=12;
    public RpMesh(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("indices")]
    public NativePointer<ushort> @Indices { get => new NativePointer<ushort>(SdkMemory.Read<IntPtr>(Pointer+0)); set { SdkMemory.Write(Pointer+0,value.Pointer); } }
    [NativeMember("numIndices")]
    public uint @CountIndices { get => SdkMemory.Read<uint >(Pointer+4); set { SdkMemory.Write(Pointer+4,value); } }
    [NativeMember("material")]
    public RpMaterial? @Material { get => SdkMemory.Read<IntPtr>(Pointer+8) == IntPtr.Zero ? null : new RpMaterial(SdkMemory.Read<IntPtr>(Pointer+8)); set { SdkMemory.Write(Pointer+8,value?.Pointer ?? IntPtr.Zero); } }
}
