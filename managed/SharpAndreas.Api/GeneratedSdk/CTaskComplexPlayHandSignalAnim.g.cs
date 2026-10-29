// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CTaskComplexPlayHandSignalAnim : CTaskComplex
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=24;
    public CTaskComplexPlayHandSignalAnim(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_animationId")]
    public int @AnimationId { get => SdkMemory.Read<int >(Pointer+12); set { SdkMemory.Write(Pointer+12,value); } }
    [NativeMember("m_fBlendFactor")]
    public float @BlendFactor { get => SdkMemory.Read<float >(Pointer+16); set { SdkMemory.Write(Pointer+16,value); } }
    [NativeMember("_pad")]
    public NativeArray<byte> @Pad { get => new NativeArray<byte>(Pointer+21,3); }
    public void @InitializeAt(int @animationId,float @blendFactor) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4021 >(4021)(Pointer,@animationId,@blendFactor); }
    public CTask? @CreateSubTask(int @taskType) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4022 >(4022)(Pointer,@taskType); return __sdkResult == IntPtr.Zero ? null : new CTask(__sdkResult); }
    public int @GetAnimIdForPed(CPed? @ped) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4023 >(4023)(Pointer,@ped?.Pointer ?? IntPtr.Zero); return __sdkResult; }
}
