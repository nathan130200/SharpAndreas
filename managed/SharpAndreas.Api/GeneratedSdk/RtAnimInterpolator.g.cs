// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class RtAnimInterpolator : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=76;
    public RtAnimInterpolator(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("pCurrentAnim")]
    public RtAnimAnimation? @CurrentAnimation { get => SdkMemory.Read<IntPtr>(Pointer+0) == IntPtr.Zero ? null : new RtAnimAnimation(SdkMemory.Read<IntPtr>(Pointer+0)); set { SdkMemory.Write(Pointer+0,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("currentTime")]
    public float @CurrentTime { get => SdkMemory.Read<float >(Pointer+4); set { SdkMemory.Write(Pointer+4,value); } }
    [NativeMember("pNextFrame")]
    public NativePointer<IntPtr> @NextFrame { get => new NativePointer<IntPtr>(SdkMemory.Read<IntPtr>(Pointer+8)); set { SdkMemory.Write(Pointer+8,value.Pointer); } }
    [NativeMember("pAnimCallBack")]
    public NativeFunctionPointer<Callback_7f79b8f6e1d6> @AnimationCallBack { get => new NativeFunctionPointer<Callback_7f79b8f6e1d6>(SdkMemory.Read<IntPtr>(Pointer+12)); set { SdkMemory.Write(Pointer+12,value.Pointer); } }
    [NativeMember("pAnimCallBackData")]
    public NativePointer<IntPtr> @AnimationCallBackData { get => new NativePointer<IntPtr>(SdkMemory.Read<IntPtr>(Pointer+16)); set { SdkMemory.Write(Pointer+16,value.Pointer); } }
    [NativeMember("animCallBackTime")]
    public float @AnimationCallBackTime { get => SdkMemory.Read<float >(Pointer+20); set { SdkMemory.Write(Pointer+20,value); } }
    [NativeMember("pAnimLoopCallBack")]
    public NativeFunctionPointer<Callback_7f79b8f6e1d6> @AnimationLoopCallBack { get => new NativeFunctionPointer<Callback_7f79b8f6e1d6>(SdkMemory.Read<IntPtr>(Pointer+24)); set { SdkMemory.Write(Pointer+24,value.Pointer); } }
    [NativeMember("pAnimLoopCallBackData")]
    public NativePointer<IntPtr> @AnimationLoopCallBackData { get => new NativePointer<IntPtr>(SdkMemory.Read<IntPtr>(Pointer+28)); set { SdkMemory.Write(Pointer+28,value.Pointer); } }
    [NativeMember("maxInterpKeyFrameSize")]
    public int @MaxInterpKeyFrameSize { get => SdkMemory.Read<int >(Pointer+32); set { SdkMemory.Write(Pointer+32,value); } }
    [NativeMember("currentInterpKeyFrameSize")]
    public int @CurrentInterpKeyFrameSize { get => SdkMemory.Read<int >(Pointer+36); set { SdkMemory.Write(Pointer+36,value); } }
    [NativeMember("currentAnimKeyFrameSize")]
    public int @CurrentAnimationKeyFrameSize { get => SdkMemory.Read<int >(Pointer+40); set { SdkMemory.Write(Pointer+40,value); } }
    [NativeMember("numNodes")]
    public int @CountNodes { get => SdkMemory.Read<int >(Pointer+44); set { SdkMemory.Write(Pointer+44,value); } }
    [NativeMember("isSubInterpolator")]
    public int @IsSubInterpolator { get => SdkMemory.Read<int >(Pointer+48); set { SdkMemory.Write(Pointer+48,value); } }
    [NativeMember("offsetInParent")]
    public int @OffsetInParent { get => SdkMemory.Read<int >(Pointer+52); set { SdkMemory.Write(Pointer+52,value); } }
    [NativeMember("parentAnimation")]
    public RtAnimInterpolator? @ParentAnimation { get => SdkMemory.Read<IntPtr>(Pointer+56) == IntPtr.Zero ? null : new RtAnimInterpolator(SdkMemory.Read<IntPtr>(Pointer+56)); set { SdkMemory.Write(Pointer+56,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("keyFrameApplyCB")]
    public NativeFunctionPointer<Callback_1a0daf25eaa9> @KeyFrameApplyCB { get => new NativeFunctionPointer<Callback_1a0daf25eaa9>(SdkMemory.Read<IntPtr>(Pointer+60)); set { SdkMemory.Write(Pointer+60,value.Pointer); } }
    [NativeMember("keyFrameBlendCB")]
    public NativeFunctionPointer<Callback_b24299e060f7> @KeyFrameBlendCB { get => new NativeFunctionPointer<Callback_b24299e060f7>(SdkMemory.Read<IntPtr>(Pointer+64)); set { SdkMemory.Write(Pointer+64,value.Pointer); } }
    [NativeMember("keyFrameInterpolateCB")]
    public NativeFunctionPointer<Callback_d2152ec2b7d5> @KeyFrameInterpolateCB { get => new NativeFunctionPointer<Callback_d2152ec2b7d5>(SdkMemory.Read<IntPtr>(Pointer+68)); set { SdkMemory.Write(Pointer+68,value.Pointer); } }
    [NativeMember("keyFrameAddCB")]
    public NativeFunctionPointer<Callback_ffa1d2280a5c> @KeyFrameAddCB { get => new NativeFunctionPointer<Callback_ffa1d2280a5c>(SdkMemory.Read<IntPtr>(Pointer+72)); set { SdkMemory.Write(Pointer+72,value.Pointer); } }
}
