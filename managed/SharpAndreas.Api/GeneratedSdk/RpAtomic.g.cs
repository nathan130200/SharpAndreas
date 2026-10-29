// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class RpAtomic : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=112;
    public RpAtomic(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("object")]
    public RwObjectHasFrame @Object { get => new RwObjectHasFrame(Pointer+0); set { SdkMemory.Copy(value.Pointer,Pointer+0,20); } }
    [NativeMember("repEntry")]
    public RwResEntry? @RepEntry { get => SdkMemory.Read<IntPtr>(Pointer+20) == IntPtr.Zero ? null : new RwResEntry(SdkMemory.Read<IntPtr>(Pointer+20)); set { SdkMemory.Write(Pointer+20,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("geometry")]
    public RpGeometry? @Geometry { get => SdkMemory.Read<IntPtr>(Pointer+24) == IntPtr.Zero ? null : new RpGeometry(SdkMemory.Read<IntPtr>(Pointer+24)); set { SdkMemory.Write(Pointer+24,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("boundingSphere")]
    public RwSphere @BoundingSphere { get => new RwSphere(Pointer+28); set { SdkMemory.Copy(value.Pointer,Pointer+28,16); } }
    [NativeMember("worldBoundingSphere")]
    public RwSphere @WorldBoundingSphere { get => new RwSphere(Pointer+44); set { SdkMemory.Copy(value.Pointer,Pointer+44,16); } }
    [NativeMember("clump")]
    public RpClump? @Clump { get => SdkMemory.Read<IntPtr>(Pointer+60) == IntPtr.Zero ? null : new RpClump(SdkMemory.Read<IntPtr>(Pointer+60)); set { SdkMemory.Write(Pointer+60,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("inClumpLink")]
    public RwLLLink @InClumpLink { get => new RwLLLink(Pointer+64); set { SdkMemory.Copy(value.Pointer,Pointer+64,8); } }
    [NativeMember("renderCallBack")]
    public NativeFunctionPointer<Callback_573b9d07bfff> @RenderCallBack { get => new NativeFunctionPointer<Callback_573b9d07bfff>(SdkMemory.Read<IntPtr>(Pointer+72)); set { SdkMemory.Write(Pointer+72,value.Pointer); } }
    [NativeMember("interpolator")]
    public RpInterpolator @Interpolator { get => new RpInterpolator(Pointer+76); set { SdkMemory.Copy(value.Pointer,Pointer+76,20); } }
    [NativeMember("renderFrame")]
    public ushort @RenderFrame { get => SdkMemory.Read<ushort >(Pointer+96); set { SdkMemory.Write(Pointer+96,value); } }
    [NativeMember("pad")]
    public ushort @Pad { get => SdkMemory.Read<ushort >(Pointer+98); set { SdkMemory.Write(Pointer+98,value); } }
    [NativeMember("llWorldSectorsInAtomic")]
    public RwLinkList @LlWorldSectorsInAtomic { get => new RwLinkList(Pointer+100); set { SdkMemory.Copy(value.Pointer,Pointer+100,8); } }
    [NativeMember("pipeline")]
    public RxPipeline? @Pipeline { get => SdkMemory.Read<IntPtr>(Pointer+108) == IntPtr.Zero ? null : new RxPipeline(SdkMemory.Read<IntPtr>(Pointer+108)); set { SdkMemory.Write(Pointer+108,value?.Pointer ?? IntPtr.Zero); } }
}
