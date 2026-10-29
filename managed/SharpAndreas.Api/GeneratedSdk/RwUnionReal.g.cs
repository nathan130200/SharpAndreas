// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class RwUnionReal : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=4;
    public RwUnionReal(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("real")]
    public float @Real { get => SdkMemory.Read<float >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("floating")]
    public float @Floating { get => SdkMemory.Read<float >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("fixed")]
    public int @Fixed { get => SdkMemory.Read<int >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("splitfixed")]
    public RwSplitFixed @Splitfixed { get => new RwSplitFixed(Pointer+0); set { SdkMemory.Copy(value.Pointer,Pointer+0,4); } }
}
