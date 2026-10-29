// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CSphere : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=16;
    public CSphere(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_vecCenter")]
    public CVector @Center { get => new CVector(Pointer+0); set { SdkMemory.Copy(value.Pointer,Pointer+0,12); } }
    [NativeMember("m_fRadius")]
    public float @Radius { get => SdkMemory.Read<float >(Pointer+12); set { SdkMemory.Write(Pointer+12,value); } }
    public void @Set(float @radius,CVector @center) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D319 >(319)(Pointer,@radius,@center.Pointer); }
}
