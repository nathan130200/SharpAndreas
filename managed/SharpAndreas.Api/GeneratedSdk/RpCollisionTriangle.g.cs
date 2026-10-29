// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class RpCollisionTriangle : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=40;
    public RpCollisionTriangle(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("normal")]
    public RwV3d @Normal { get => new RwV3d(Pointer+0); set { SdkMemory.Copy(value.Pointer,Pointer+0,12); } }
    [NativeMember("point")]
    public RwV3d @Point { get => new RwV3d(Pointer+12); set { SdkMemory.Copy(value.Pointer,Pointer+12,12); } }
    [NativeMember("index")]
    public int @Index { get => SdkMemory.Read<int >(Pointer+24); set { SdkMemory.Write(Pointer+24,value); } }
    [NativeMember("vertices")]
    public NativeArray<IntPtr> @Vertices { get => new NativeArray<IntPtr>(Pointer+28,3); }
}
