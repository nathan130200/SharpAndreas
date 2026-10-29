// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class RpInterpolator : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=20;
    public RpInterpolator(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("flags")]
    public int @Flags { get => SdkMemory.Read<int >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("startMorphTarget")]
    public short @StartMorphTarget { get => SdkMemory.Read<short >(Pointer+4); set { SdkMemory.Write(Pointer+4,value); } }
    [NativeMember("endMorphTarget")]
    public short @EndMorphTarget { get => SdkMemory.Read<short >(Pointer+6); set { SdkMemory.Write(Pointer+6,value); } }
    [NativeMember("time")]
    public float @Time { get => SdkMemory.Read<float >(Pointer+8); set { SdkMemory.Write(Pointer+8,value); } }
    [NativeMember("recipTime")]
    public float @RecipTime { get => SdkMemory.Read<float >(Pointer+12); set { SdkMemory.Write(Pointer+12,value); } }
    [NativeMember("position")]
    public float @Position { get => SdkMemory.Read<float >(Pointer+16); set { SdkMemory.Write(Pointer+16,value); } }
}
