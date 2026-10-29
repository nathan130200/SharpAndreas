// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class rwStreamCamera : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=32;
    public rwStreamCamera(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("viewWindow")]
    public RwV2d @ViewWindow { get => new RwV2d(Pointer+0); set { SdkMemory.Copy(value.Pointer,Pointer+0,8); } }
    [NativeMember("viewOffset")]
    public RwV2d @ViewOffset { get => new RwV2d(Pointer+8); set { SdkMemory.Copy(value.Pointer,Pointer+8,8); } }
    [NativeMember("nearPlane")]
    public float @NearPlane { get => SdkMemory.Read<float >(Pointer+16); set { SdkMemory.Write(Pointer+16,value); } }
    [NativeMember("farPlane")]
    public float @FarPlane { get => SdkMemory.Read<float >(Pointer+20); set { SdkMemory.Write(Pointer+20,value); } }
    [NativeMember("fogPlane")]
    public float @FogPlane { get => SdkMemory.Read<float >(Pointer+24); set { SdkMemory.Write(Pointer+24,value); } }
    [NativeMember("projection")]
    public uint @Projection { get => SdkMemory.Read<uint >(Pointer+28); set { SdkMemory.Write(Pointer+28,value); } }
}
