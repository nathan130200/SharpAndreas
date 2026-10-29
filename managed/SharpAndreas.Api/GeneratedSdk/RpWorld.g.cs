// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class RpWorld : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=112;
    public RpWorld(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("object")]
    public RwObject @Object { get => new RwObject(Pointer+0); set { SdkMemory.Copy(value.Pointer,Pointer+0,8); } }
    [NativeMember("flags")]
    public uint @Flags { get => SdkMemory.Read<uint >(Pointer+8); set { SdkMemory.Write(Pointer+8,value); } }
    [NativeMember("renderOrder")]
    public RpWorldRenderOrder @RenderOrder { get => SdkMemory.Read<RpWorldRenderOrder >(Pointer+12); set { SdkMemory.Write(Pointer+12,value); } }
    [NativeMember("matList")]
    public RpMaterialList @List { get => new RpMaterialList(Pointer+16); set { SdkMemory.Copy(value.Pointer,Pointer+16,12); } }
    [NativeMember("rootSector")]
    public RpSector? @RootSector { get => SdkMemory.Read<IntPtr>(Pointer+28) == IntPtr.Zero ? null : new RpSector(SdkMemory.Read<IntPtr>(Pointer+28)); set { SdkMemory.Write(Pointer+28,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("numTexCoordSets")]
    public int @CountTexCoordinateSets { get => SdkMemory.Read<int >(Pointer+32); set { SdkMemory.Write(Pointer+32,value); } }
    [NativeMember("numClumpsInWorld")]
    public int @CountClumpsInWorld { get => SdkMemory.Read<int >(Pointer+36); set { SdkMemory.Write(Pointer+36,value); } }
    [NativeMember("currentClumpLink")]
    public RwLLLink? @CurrentClumpLink { get => SdkMemory.Read<IntPtr>(Pointer+40) == IntPtr.Zero ? null : new RwLLLink(SdkMemory.Read<IntPtr>(Pointer+40)); set { SdkMemory.Write(Pointer+40,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("clumpList")]
    public RwLinkList @ClumpList { get => new RwLinkList(Pointer+44); set { SdkMemory.Copy(value.Pointer,Pointer+44,8); } }
    [NativeMember("lightList")]
    public RwLinkList @LightList { get => new RwLinkList(Pointer+52); set { SdkMemory.Copy(value.Pointer,Pointer+52,8); } }
    [NativeMember("directionalLightList")]
    public RwLinkList @DirectionalLightList { get => new RwLinkList(Pointer+60); set { SdkMemory.Copy(value.Pointer,Pointer+60,8); } }
    [NativeMember("worldOrigin")]
    public RwV3d @WorldOrigin { get => new RwV3d(Pointer+68); set { SdkMemory.Copy(value.Pointer,Pointer+68,12); } }
    [NativeMember("boundingBox")]
    public RwBBox @BoundingBox { get => new RwBBox(Pointer+80); set { SdkMemory.Copy(value.Pointer,Pointer+80,24); } }
    [NativeMember("renderCallBack")]
    public NativeFunctionPointer<Callback_9a0e1db5a73a> @RenderCallBack { get => new NativeFunctionPointer<Callback_9a0e1db5a73a>(SdkMemory.Read<IntPtr>(Pointer+104)); set { SdkMemory.Write(Pointer+104,value.Pointer); } }
    [NativeMember("pipeline")]
    public RxPipeline? @Pipeline { get => SdkMemory.Read<IntPtr>(Pointer+108) == IntPtr.Zero ? null : new RxPipeline(SdkMemory.Read<IntPtr>(Pointer+108)); set { SdkMemory.Write(Pointer+108,value?.Pointer ?? IntPtr.Zero); } }
}
