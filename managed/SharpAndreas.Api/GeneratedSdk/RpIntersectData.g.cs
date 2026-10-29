// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class RpIntersectData : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=24;
    public RpIntersectData(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("line")]
    public RwLine @Line { get => new RwLine(Pointer+0); set { SdkMemory.Copy(value.Pointer,Pointer+0,24); } }
    [NativeMember("point")]
    public RwV3d @Point { get => new RwV3d(Pointer+0); set { SdkMemory.Copy(value.Pointer,Pointer+0,12); } }
    [NativeMember("sphere")]
    public RwSphere @Sphere { get => new RwSphere(Pointer+0); set { SdkMemory.Copy(value.Pointer,Pointer+0,16); } }
    [NativeMember("box")]
    public RwBBox @Box { get => new RwBBox(Pointer+0); set { SdkMemory.Copy(value.Pointer,Pointer+0,24); } }
    [NativeMember("object")]
    public NativePointer<IntPtr> @Object { get => new NativePointer<IntPtr>(SdkMemory.Read<IntPtr>(Pointer+0)); set { SdkMemory.Write(Pointer+0,value.Pointer); } }
}
