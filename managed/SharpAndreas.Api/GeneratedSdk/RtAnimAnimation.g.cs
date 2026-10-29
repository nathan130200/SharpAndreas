// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class RtAnimAnimation : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=24;
    public RtAnimAnimation(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("interpInfo")]
    public RtAnimInterpolatorInfo? @InterpInfo { get => SdkMemory.Read<IntPtr>(Pointer+0) == IntPtr.Zero ? null : new RtAnimInterpolatorInfo(SdkMemory.Read<IntPtr>(Pointer+0)); set { SdkMemory.Write(Pointer+0,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("numFrames")]
    public int @CountFrames { get => SdkMemory.Read<int >(Pointer+4); set { SdkMemory.Write(Pointer+4,value); } }
    [NativeMember("flags")]
    public int @Flags { get => SdkMemory.Read<int >(Pointer+8); set { SdkMemory.Write(Pointer+8,value); } }
    [NativeMember("duration")]
    public float @Duration { get => SdkMemory.Read<float >(Pointer+12); set { SdkMemory.Write(Pointer+12,value); } }
    [NativeMember("pFrames")]
    public NativePointer<IntPtr> @Frames { get => new NativePointer<IntPtr>(SdkMemory.Read<IntPtr>(Pointer+16)); set { SdkMemory.Write(Pointer+16,value.Pointer); } }
    [NativeMember("customData")]
    public NativePointer<IntPtr> @CustomData { get => new NativePointer<IntPtr>(SdkMemory.Read<IntPtr>(Pointer+20)); set { SdkMemory.Write(Pointer+20,value.Pointer); } }
}
