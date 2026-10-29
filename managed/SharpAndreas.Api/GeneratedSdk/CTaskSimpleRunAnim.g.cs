// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CTaskSimpleRunAnim : CTaskSimpleAnim
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=32;
    public CTaskSimpleRunAnim(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_nAnimGroup")]
    public uint @AnimationGroup { get => SdkMemory.Read<uint >(Pointer+16); set { SdkMemory.Write(Pointer+16,value); } }
    [NativeMember("m_nAnimId")]
    public uint @AnimationId { get => SdkMemory.Read<uint >(Pointer+20); set { SdkMemory.Write(Pointer+20,value); } }
    [NativeMember("m_fBlendDelta")]
    public float @BlendDelta { get => SdkMemory.Read<float >(Pointer+24); set { SdkMemory.Write(Pointer+24,value); } }
    [NativeMember("m_nTaskType")]
    public ushort @TaskType { get => SdkMemory.Read<ushort >(Pointer+28); set { SdkMemory.Write(Pointer+28,value); } }
    public void @InitializeAt(uint @animGroup,uint @animID,float @fBlendDelta,bool @bHoldLastFrame) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4050 >(4050)(Pointer,@animGroup,@animID,@fBlendDelta,(@bHoldLastFrame ? 1 : 0)); }
    public void @InitializeAt(uint @animGroup,uint @animID,float @fBlendDelta,uint @nTaskType,NativePointer<sbyte> @pTaskName,bool @bHoldLastFrame) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4051 >(4051)(Pointer,@animGroup,@animID,@fBlendDelta,@nTaskType,@pTaskName.Pointer,(@bHoldLastFrame ? 1 : 0)); }
}
