// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class RwFrustumPlane : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=20;
    public RwFrustumPlane(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("plane")]
    public RwPlane @Plane { get => new RwPlane(Pointer+0); set { SdkMemory.Copy(value.Pointer,Pointer+0,16); } }
    [NativeMember("closestX")]
    public byte @ClosestX { get => SdkMemory.Read<byte >(Pointer+16); set { SdkMemory.Write(Pointer+16,value); } }
    [NativeMember("closestY")]
    public byte @ClosestY { get => SdkMemory.Read<byte >(Pointer+17); set { SdkMemory.Write(Pointer+17,value); } }
    [NativeMember("closestZ")]
    public byte @ClosestZ { get => SdkMemory.Read<byte >(Pointer+18); set { SdkMemory.Write(Pointer+18,value); } }
    [NativeMember("pad")]
    public byte @Pad { get => SdkMemory.Read<byte >(Pointer+19); set { SdkMemory.Write(Pointer+19,value); } }
}
