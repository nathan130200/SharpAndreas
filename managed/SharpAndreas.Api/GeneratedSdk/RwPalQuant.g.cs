// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class RwPalQuant : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=16392;
    public RwPalQuant(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("Mcube")]
    public NativeObjectArray<_rwPalQuantRGBABox> @Mcube { get => new NativeObjectArray<_rwPalQuantRGBABox>(Pointer+0,256,32); }
    [NativeMember("Mvv")]
    public NativeArray<float> @Mvv { get => new NativeArray<float>(Pointer+8192,256); }
    [NativeMember("Mvol")]
    public NativeObjectArray<_rwPalQuantLeafNode> @Mvol { get => new NativeObjectArray<_rwPalQuantLeafNode>(Pointer+9216,256,28); }
    [NativeMember("root")]
    public _rwPalQuantOctNode? @Root { get => SdkMemory.Read<IntPtr>(Pointer+16384) == IntPtr.Zero ? null : new _rwPalQuantOctNode(SdkMemory.Read<IntPtr>(Pointer+16384)); set { SdkMemory.Write(Pointer+16384,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("cubefreelist")]
    public RwFreeList? @Cubefreelist { get => SdkMemory.Read<IntPtr>(Pointer+16388) == IntPtr.Zero ? null : new RwFreeList(SdkMemory.Read<IntPtr>(Pointer+16388)); set { SdkMemory.Write(Pointer+16388,value?.Pointer ?? IntPtr.Zero); } }
}
