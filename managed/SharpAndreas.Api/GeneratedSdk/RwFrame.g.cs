// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class RwFrame : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=164;
    public RwFrame(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("object")]
    public RwObject @Object { get => new RwObject(Pointer+0); set { SdkMemory.Copy(value.Pointer,Pointer+0,8); } }
    [NativeMember("inDirtyListLink")]
    public RwLLLink @InDirtyListLink { get => new RwLLLink(Pointer+8); set { SdkMemory.Copy(value.Pointer,Pointer+8,8); } }
    [NativeMember("modelling")]
    public RwMatrixTag @Modelling { get => new RwMatrixTag(Pointer+16); set { SdkMemory.Copy(value.Pointer,Pointer+16,64); } }
    [NativeMember("ltm")]
    public RwMatrixTag @Ltm { get => new RwMatrixTag(Pointer+80); set { SdkMemory.Copy(value.Pointer,Pointer+80,64); } }
    [NativeMember("objectList")]
    public RwLinkList @ObjectList { get => new RwLinkList(Pointer+144); set { SdkMemory.Copy(value.Pointer,Pointer+144,8); } }
    [NativeMember("child")]
    public RwFrame? @Child { get => SdkMemory.Read<IntPtr>(Pointer+152) == IntPtr.Zero ? null : new RwFrame(SdkMemory.Read<IntPtr>(Pointer+152)); set { SdkMemory.Write(Pointer+152,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("next")]
    public RwFrame? @Next { get => SdkMemory.Read<IntPtr>(Pointer+156) == IntPtr.Zero ? null : new RwFrame(SdkMemory.Read<IntPtr>(Pointer+156)); set { SdkMemory.Write(Pointer+156,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("root")]
    public RwFrame? @Root { get => SdkMemory.Read<IntPtr>(Pointer+160) == IntPtr.Zero ? null : new RwFrame(SdkMemory.Read<IntPtr>(Pointer+160)); set { SdkMemory.Write(Pointer+160,value?.Pointer ?? IntPtr.Zero); } }
}
