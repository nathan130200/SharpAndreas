// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class rwPipeGlobals : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=96;
    public rwPipeGlobals(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("pipesFreeList")]
    public RwFreeList? @PipesFreeList { get => SdkMemory.Read<IntPtr>(Pointer+0) == IntPtr.Zero ? null : new RwFreeList(SdkMemory.Read<IntPtr>(Pointer+0)); set { SdkMemory.Write(Pointer+0,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("defaultRenderState")]
    public RxRenderStateVector @DefaultRenderState { get => new RxRenderStateVector(Pointer+4); set { SdkMemory.Copy(value.Pointer,Pointer+4,44); } }
    [NativeMember("allPipelines")]
    public RwLinkList @AllPipelines { get => new RwLinkList(Pointer+48); set { SdkMemory.Copy(value.Pointer,Pointer+48,8); } }
    [NativeMember("maxNodesPerPipe")]
    public uint @MaxNodesPerPipe { get => SdkMemory.Read<uint >(Pointer+56); set { SdkMemory.Write(Pointer+56,value); } }
    [NativeMember("currentAtomicPipeline")]
    public RxPipeline? @CurrentAtomicPipeline { get => SdkMemory.Read<IntPtr>(Pointer+60) == IntPtr.Zero ? null : new RxPipeline(SdkMemory.Read<IntPtr>(Pointer+60)); set { SdkMemory.Write(Pointer+60,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("currentWorldSectorPipeline")]
    public RxPipeline? @CurrentWorldSectorPipeline { get => SdkMemory.Read<IntPtr>(Pointer+64) == IntPtr.Zero ? null : new RxPipeline(SdkMemory.Read<IntPtr>(Pointer+64)); set { SdkMemory.Write(Pointer+64,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("currentMaterialPipeline")]
    public RxPipeline? @CurrentMaterialPipeline { get => SdkMemory.Read<IntPtr>(Pointer+68) == IntPtr.Zero ? null : new RxPipeline(SdkMemory.Read<IntPtr>(Pointer+68)); set { SdkMemory.Write(Pointer+68,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("genericAtomicPipeline")]
    public RxPipeline? @GenericAtomicPipeline { get => SdkMemory.Read<IntPtr>(Pointer+72) == IntPtr.Zero ? null : new RxPipeline(SdkMemory.Read<IntPtr>(Pointer+72)); set { SdkMemory.Write(Pointer+72,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("genericWorldSectorPipeline")]
    public RxPipeline? @GenericWorldSectorPipeline { get => SdkMemory.Read<IntPtr>(Pointer+76) == IntPtr.Zero ? null : new RxPipeline(SdkMemory.Read<IntPtr>(Pointer+76)); set { SdkMemory.Write(Pointer+76,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("genericMaterialPipeline")]
    public RxPipeline? @GenericMaterialPipeline { get => SdkMemory.Read<IntPtr>(Pointer+80) == IntPtr.Zero ? null : new RxPipeline(SdkMemory.Read<IntPtr>(Pointer+80)); set { SdkMemory.Write(Pointer+80,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("platformAtomicPipeline")]
    public RxPipeline? @PlatformAtomicPipeline { get => SdkMemory.Read<IntPtr>(Pointer+84) == IntPtr.Zero ? null : new RxPipeline(SdkMemory.Read<IntPtr>(Pointer+84)); set { SdkMemory.Write(Pointer+84,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("platformWorldSectorPipeline")]
    public RxPipeline? @PlatformWorldSectorPipeline { get => SdkMemory.Read<IntPtr>(Pointer+88) == IntPtr.Zero ? null : new RxPipeline(SdkMemory.Read<IntPtr>(Pointer+88)); set { SdkMemory.Write(Pointer+88,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("platformMaterialPipeline")]
    public RxPipeline? @PlatformMaterialPipeline { get => SdkMemory.Read<IntPtr>(Pointer+92) == IntPtr.Zero ? null : new RxPipeline(SdkMemory.Read<IntPtr>(Pointer+92)); set { SdkMemory.Write(Pointer+92,value?.Pointer ?? IntPtr.Zero); } }
}
