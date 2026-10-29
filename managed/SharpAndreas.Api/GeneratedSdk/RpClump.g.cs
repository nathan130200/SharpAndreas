// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class RpClump : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=44;
    public RpClump(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("object")]
    public RwObject @Object { get => new RwObject(Pointer+0); set { SdkMemory.Copy(value.Pointer,Pointer+0,8); } }
    [NativeMember("atomicList")]
    public RwLinkList @AtomicList { get => new RwLinkList(Pointer+8); set { SdkMemory.Copy(value.Pointer,Pointer+8,8); } }
    [NativeMember("lightList")]
    public RwLinkList @LightList { get => new RwLinkList(Pointer+16); set { SdkMemory.Copy(value.Pointer,Pointer+16,8); } }
    [NativeMember("cameraList")]
    public RwLinkList @CameraList { get => new RwLinkList(Pointer+24); set { SdkMemory.Copy(value.Pointer,Pointer+24,8); } }
    [NativeMember("inWorldLink")]
    public RwLLLink @InWorldLink { get => new RwLLLink(Pointer+32); set { SdkMemory.Copy(value.Pointer,Pointer+32,8); } }
    [NativeMember("callback")]
    public NativeFunctionPointer<Callback_3e423b3dd85b> @Callback { get => new NativeFunctionPointer<Callback_3e423b3dd85b>(SdkMemory.Read<IntPtr>(Pointer+40)); set { SdkMemory.Write(Pointer+40,value.Pointer); } }
}
