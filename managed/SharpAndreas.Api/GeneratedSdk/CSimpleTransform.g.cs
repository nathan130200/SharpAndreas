// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CSimpleTransform : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=16;
    public CSimpleTransform(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_vPosn")]
    public CVector @Position { get => new CVector(Pointer+0); set { SdkMemory.Copy(value.Pointer,Pointer+0,12); } }
    [NativeMember("m_fHeading")]
    public float @Heading { get => SdkMemory.Read<float >(Pointer+12); set { SdkMemory.Write(Pointer+12,value); } }
    public void @UpdateRwMatrix(RwMatrixTag? @out) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D272 >(272)(Pointer,@out?.Pointer ?? IntPtr.Zero); }
    public void @Invert(CSimpleTransform @base) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D273 >(273)(Pointer,@base.Pointer); }
    public void @UpdateMatrix(CMatrix? @out) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D274 >(274)(Pointer,@out?.Pointer ?? IntPtr.Zero); }
}
