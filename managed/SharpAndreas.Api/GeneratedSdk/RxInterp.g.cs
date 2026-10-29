// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class RxInterp : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=12;
    public RxInterp(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("originalVert")]
    public ushort @OriginalVert { get => SdkMemory.Read<ushort >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("parentVert1")]
    public ushort @ParentVert1 { get => SdkMemory.Read<ushort >(Pointer+2); set { SdkMemory.Write(Pointer+2,value); } }
    [NativeMember("parentVert2")]
    public ushort @ParentVert2 { get => SdkMemory.Read<ushort >(Pointer+4); set { SdkMemory.Write(Pointer+4,value); } }
    [NativeMember("interp")]
    public float @Interp { get => SdkMemory.Read<float >(Pointer+8); set { SdkMemory.Write(Pointer+8,value); } }
}
