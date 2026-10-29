// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CBox : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=24;
    public CBox(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_vecMin")]
    public CVector @Min { get => new CVector(Pointer+0); set { SdkMemory.Copy(value.Pointer,Pointer+0,12); } }
    [NativeMember("m_vecMax")]
    public CVector @Max { get => new CVector(Pointer+12); set { SdkMemory.Copy(value.Pointer,Pointer+12,12); } }
    public void @Set(CVector @vecMin,CVector @vecMax) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D316 >(316)(Pointer,@vecMin.Pointer,@vecMax.Pointer); }
    public void @Recalc() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D317 >(317)(Pointer); }
}
