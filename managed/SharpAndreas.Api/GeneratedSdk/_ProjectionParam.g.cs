// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class _ProjectionParam : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=152;
    public _ProjectionParam(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("at")]
    public RwV3d @At { get => new RwV3d(Pointer+0); set { SdkMemory.Copy(value.Pointer,Pointer+0,12); } }
    [NativeMember("invMatrix")]
    public RwMatrixTag @InvMatrix { get => new RwMatrixTag(Pointer+12); set { SdkMemory.Copy(value.Pointer,Pointer+12,64); } }
    [NativeMember("shadowValue")]
    public byte @ShadowValue { get => SdkMemory.Read<byte >(Pointer+76); set { SdkMemory.Write(Pointer+76,value); } }
    [NativeMember("fade")]
    public int @Fade { get => SdkMemory.Read<int >(Pointer+80); set { SdkMemory.Write(Pointer+80,value); } }
    [NativeMember("numIm3DBatch")]
    public uint @CountIm3DBatch { get => SdkMemory.Read<uint >(Pointer+84); set { SdkMemory.Write(Pointer+84,value); } }
    [NativeMember("entityMatrix")]
    public RwMatrixTag @EntityMatrix { get => new RwMatrixTag(Pointer+88); set { SdkMemory.Copy(value.Pointer,Pointer+88,64); } }
}
