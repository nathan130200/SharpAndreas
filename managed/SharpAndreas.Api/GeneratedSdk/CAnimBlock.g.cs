// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CAnimBlock : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=32;
    public CAnimBlock(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("szName")]
    public NativeArray<sbyte> @Name { get => new NativeArray<sbyte>(Pointer+0,16); }
    [NativeMember("bLoaded")]
    public sbyte @Loaded { get => SdkMemory.Read<sbyte >(Pointer+16); set { SdkMemory.Write(Pointer+16,value); } }
    [NativeMember("pad")]
    public sbyte @Pad { get => SdkMemory.Read<sbyte >(Pointer+17); set { SdkMemory.Write(Pointer+17,value); } }
    [NativeMember("usRefs")]
    public short @Refs { get => SdkMemory.Read<short >(Pointer+18); set { SdkMemory.Write(Pointer+18,value); } }
    [NativeMember("startAnimation")]
    public int @StartAnimation { get => SdkMemory.Read<int >(Pointer+20); set { SdkMemory.Write(Pointer+20,value); } }
    [NativeMember("animationCount")]
    public int @AnimationCount { get => SdkMemory.Read<int >(Pointer+24); set { SdkMemory.Write(Pointer+24,value); } }
    [NativeMember("animationStyle")]
    public int @AnimationStyle { get => SdkMemory.Read<int >(Pointer+28); set { SdkMemory.Write(Pointer+28,value); } }
}
