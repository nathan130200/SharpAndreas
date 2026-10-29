// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CTaskSimpleFacial : CTaskSimple
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=28;
    public CTaskSimpleFacial(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_Timer")]
    public CTaskTimer @Timer { get => new CTaskTimer(Pointer+8); set { SdkMemory.Copy(value.Pointer,Pointer+8,12); } }
    [NativeMember("m_nFacialExpression")]
    public eFacialExpression @FacialExpression { get => SdkMemory.Read<eFacialExpression >(Pointer+20); set { SdkMemory.Write(Pointer+20,value); } }
    [NativeMember("m_nDuration")]
    public int @Duration { get => SdkMemory.Read<int >(Pointer+24); set { SdkMemory.Write(Pointer+24,value); } }
    public void @InitializeAt(eFacialExpression @nFacialExpress,int @nDuration) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4015 >(4015)(Pointer,(int)@nFacialExpress,@nDuration); }
}
