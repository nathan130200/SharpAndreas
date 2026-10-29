// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class RtAnimInterpolatorInfo : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=44;
    public RtAnimInterpolatorInfo(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("typeID")]
    public int @TypeID { get => SdkMemory.Read<int >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("interpKeyFrameSize")]
    public int @InterpKeyFrameSize { get => SdkMemory.Read<int >(Pointer+4); set { SdkMemory.Write(Pointer+4,value); } }
    [NativeMember("keyFrameApplyCB")]
    public NativeFunctionPointer<Callback_1a0daf25eaa9> @KeyFrameApplyCB { get => new NativeFunctionPointer<Callback_1a0daf25eaa9>(SdkMemory.Read<IntPtr>(Pointer+8)); set { SdkMemory.Write(Pointer+8,value.Pointer); } }
    [NativeMember("keyFrameBlendCB")]
    public NativeFunctionPointer<Callback_b24299e060f7> @KeyFrameBlendCB { get => new NativeFunctionPointer<Callback_b24299e060f7>(SdkMemory.Read<IntPtr>(Pointer+12)); set { SdkMemory.Write(Pointer+12,value.Pointer); } }
    [NativeMember("keyFrameInterpolateCB")]
    public NativeFunctionPointer<Callback_d2152ec2b7d5> @KeyFrameInterpolateCB { get => new NativeFunctionPointer<Callback_d2152ec2b7d5>(SdkMemory.Read<IntPtr>(Pointer+16)); set { SdkMemory.Write(Pointer+16,value.Pointer); } }
    [NativeMember("keyFrameAddCB")]
    public NativeFunctionPointer<Callback_ffa1d2280a5c> @KeyFrameAddCB { get => new NativeFunctionPointer<Callback_ffa1d2280a5c>(SdkMemory.Read<IntPtr>(Pointer+20)); set { SdkMemory.Write(Pointer+20,value.Pointer); } }
    [NativeMember("keyFrameMulRecipCB")]
    public NativeFunctionPointer<Callback_1a0daf25eaa9> @KeyFrameMulRecipCB { get => new NativeFunctionPointer<Callback_1a0daf25eaa9>(SdkMemory.Read<IntPtr>(Pointer+24)); set { SdkMemory.Write(Pointer+24,value.Pointer); } }
    [NativeMember("keyFrameStreamReadCB")]
    public NativeFunctionPointer<Callback_b0d8c05d4e2a> @KeyFrameStreamReadCB { get => new NativeFunctionPointer<Callback_b0d8c05d4e2a>(SdkMemory.Read<IntPtr>(Pointer+28)); set { SdkMemory.Write(Pointer+28,value.Pointer); } }
    [NativeMember("keyFrameStreamWriteCB")]
    public NativeFunctionPointer<Callback_b1662b88ec8b> @KeyFrameStreamWriteCB { get => new NativeFunctionPointer<Callback_b1662b88ec8b>(SdkMemory.Read<IntPtr>(Pointer+32)); set { SdkMemory.Write(Pointer+32,value.Pointer); } }
    [NativeMember("keyFrameStreamGetSizeCB")]
    public NativeFunctionPointer<Callback_5bbf71ff9e12> @KeyFrameStreamGetSizeCB { get => new NativeFunctionPointer<Callback_5bbf71ff9e12>(SdkMemory.Read<IntPtr>(Pointer+36)); set { SdkMemory.Write(Pointer+36,value.Pointer); } }
    [NativeMember("customDataSize")]
    public int @CustomDataSize { get => SdkMemory.Read<int >(Pointer+40); set { SdkMemory.Write(Pointer+40,value); } }
}
