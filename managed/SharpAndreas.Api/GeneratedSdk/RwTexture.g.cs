// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class RwTexture : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=88;
    public RwTexture(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("raster")]
    public RwRaster? @Raster { get => SdkMemory.Read<IntPtr>(Pointer+0) == IntPtr.Zero ? null : new RwRaster(SdkMemory.Read<IntPtr>(Pointer+0)); set { SdkMemory.Write(Pointer+0,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("dict")]
    public RwTexDictionary? @Dict { get => SdkMemory.Read<IntPtr>(Pointer+4) == IntPtr.Zero ? null : new RwTexDictionary(SdkMemory.Read<IntPtr>(Pointer+4)); set { SdkMemory.Write(Pointer+4,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("lInDictionary")]
    public RwLLLink @LInDictionary { get => new RwLLLink(Pointer+8); set { SdkMemory.Copy(value.Pointer,Pointer+8,8); } }
    [NativeMember("name")]
    public NativeArray<sbyte> @Name { get => new NativeArray<sbyte>(Pointer+16,32); }
    [NativeMember("mask")]
    public NativeArray<sbyte> @Mask { get => new NativeArray<sbyte>(Pointer+48,32); }
    [NativeMember("filterAddressing")]
    public uint @FilterAddressing { get => SdkMemory.Read<uint >(Pointer+80); set { SdkMemory.Write(Pointer+80,value); } }
    [NativeMember("refCount")]
    public int @RefCount { get => SdkMemory.Read<int >(Pointer+84); set { SdkMemory.Write(Pointer+84,value); } }
}
