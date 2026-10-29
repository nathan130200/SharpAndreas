// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CPlaneTrail : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=256;
    public CPlaneTrail(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_avecPosn")]
    public NativeObjectArray<CVector> @Position { get => new NativeObjectArray<CVector>(Pointer+0,16,12); }
    [NativeMember("m_anTime")]
    public NativeArray<uint> @Time { get => new NativeArray<uint>(Pointer+192,16); }
    public void @Init() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3369 >(3369)(Pointer); }
    public void @Render(float @intensity) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3370 >(3370)(Pointer,@intensity); }
    public void @RegisterPoint(CVector @point) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3371 >(3371)(Pointer,@point.Pointer); }
}
