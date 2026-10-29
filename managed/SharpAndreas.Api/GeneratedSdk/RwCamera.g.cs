// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class RwCamera : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=388;
    public RwCamera(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("object")]
    public RwObjectHasFrame @Object { get => new RwObjectHasFrame(Pointer+0); set { SdkMemory.Copy(value.Pointer,Pointer+0,20); } }
    [NativeMember("projectionType")]
    public RwCameraProjection @ProjectionType { get => SdkMemory.Read<RwCameraProjection >(Pointer+20); set { SdkMemory.Write(Pointer+20,value); } }
    [NativeMember("beginUpdate")]
    public NativeFunctionPointer<Callback_83a3169f8885> @BeginUpdate { get => new NativeFunctionPointer<Callback_83a3169f8885>(SdkMemory.Read<IntPtr>(Pointer+24)); set { SdkMemory.Write(Pointer+24,value.Pointer); } }
    [NativeMember("endUpdate")]
    public NativeFunctionPointer<Callback_83a3169f8885> @EndUpdate { get => new NativeFunctionPointer<Callback_83a3169f8885>(SdkMemory.Read<IntPtr>(Pointer+28)); set { SdkMemory.Write(Pointer+28,value.Pointer); } }
    [NativeMember("viewMatrix")]
    public RwMatrixTag @ViewMatrix { get => new RwMatrixTag(Pointer+32); set { SdkMemory.Copy(value.Pointer,Pointer+32,64); } }
    [NativeMember("frameBuffer")]
    public RwRaster? @FrameBuffer { get => SdkMemory.Read<IntPtr>(Pointer+96) == IntPtr.Zero ? null : new RwRaster(SdkMemory.Read<IntPtr>(Pointer+96)); set { SdkMemory.Write(Pointer+96,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("zBuffer")]
    public RwRaster? @ZBuffer { get => SdkMemory.Read<IntPtr>(Pointer+100) == IntPtr.Zero ? null : new RwRaster(SdkMemory.Read<IntPtr>(Pointer+100)); set { SdkMemory.Write(Pointer+100,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("viewWindow")]
    public RwV2d @ViewWindow { get => new RwV2d(Pointer+104); set { SdkMemory.Copy(value.Pointer,Pointer+104,8); } }
    [NativeMember("recipViewWindow")]
    public RwV2d @RecipViewWindow { get => new RwV2d(Pointer+112); set { SdkMemory.Copy(value.Pointer,Pointer+112,8); } }
    [NativeMember("viewOffset")]
    public RwV2d @ViewOffset { get => new RwV2d(Pointer+120); set { SdkMemory.Copy(value.Pointer,Pointer+120,8); } }
    [NativeMember("nearPlane")]
    public float @NearPlane { get => SdkMemory.Read<float >(Pointer+128); set { SdkMemory.Write(Pointer+128,value); } }
    [NativeMember("farPlane")]
    public float @FarPlane { get => SdkMemory.Read<float >(Pointer+132); set { SdkMemory.Write(Pointer+132,value); } }
    [NativeMember("fogPlane")]
    public float @FogPlane { get => SdkMemory.Read<float >(Pointer+136); set { SdkMemory.Write(Pointer+136,value); } }
    [NativeMember("zScale")]
    public float @ZScale { get => SdkMemory.Read<float >(Pointer+140); set { SdkMemory.Write(Pointer+140,value); } }
    [NativeMember("zShift")]
    public float @ZShift { get => SdkMemory.Read<float >(Pointer+144); set { SdkMemory.Write(Pointer+144,value); } }
    [NativeMember("frustumPlanes")]
    public NativeObjectArray<RwFrustumPlane> @FrustumPlanes { get => new NativeObjectArray<RwFrustumPlane>(Pointer+148,6,20); }
    [NativeMember("frustumBoundBox")]
    public RwBBox @FrustumBoundBox { get => new RwBBox(Pointer+268); set { SdkMemory.Copy(value.Pointer,Pointer+268,24); } }
    [NativeMember("frustumCorners")]
    public NativeObjectArray<RwV3d> @FrustumCorners { get => new NativeObjectArray<RwV3d>(Pointer+292,8,12); }
}
