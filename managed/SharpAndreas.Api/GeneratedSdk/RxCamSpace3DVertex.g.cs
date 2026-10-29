// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class RxCamSpace3DVertex : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=40;
    public RxCamSpace3DVertex(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("cameraVertex")]
    public RwV3d @CameraVertex { get => new RwV3d(Pointer+0); set { SdkMemory.Copy(value.Pointer,Pointer+0,12); } }
    [NativeMember("clipFlags")]
    public byte @ClipFlags { get => SdkMemory.Read<byte >(Pointer+12); set { SdkMemory.Write(Pointer+12,value); } }
    [NativeMember("pad")]
    public NativeArray<byte> @Pad { get => new NativeArray<byte>(Pointer+13,3); }
    [NativeMember("col")]
    public RwRGBAReal @Collision { get => new RwRGBAReal(Pointer+16); set { SdkMemory.Copy(value.Pointer,Pointer+16,16); } }
    [NativeMember("u")]
    public float @U { get => SdkMemory.Read<float >(Pointer+32); set { SdkMemory.Write(Pointer+32,value); } }
    [NativeMember("v")]
    public float @V { get => SdkMemory.Read<float >(Pointer+36); set { SdkMemory.Write(Pointer+36,value); } }
}
