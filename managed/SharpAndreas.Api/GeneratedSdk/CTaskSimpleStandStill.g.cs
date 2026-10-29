// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CTaskSimpleStandStill : CTaskSimple
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=32;
    public CTaskSimpleStandStill(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_nTime")]
    public int @Time { get => SdkMemory.Read<int >(Pointer+8); set { SdkMemory.Write(Pointer+8,value); } }
    [NativeMember("m_timer")]
    public CTaskTimer @Timer { get => new CTaskTimer(Pointer+12); set { SdkMemory.Copy(value.Pointer,Pointer+12,12); } }
    [NativeMember("m_bLooped")]
    public bool @Looped { get => SdkMemory.Read<bool >(Pointer+24); set { SdkMemory.Write(Pointer+24,value); } }
    [NativeMember("m_bUseAnimIdleStance")]
    public bool @UseAnimationIdleStance { get => SdkMemory.Read<bool >(Pointer+25); set { SdkMemory.Write(Pointer+25,value); } }
    [NativeMember("m_fBlendData")]
    public float @BlendData { get => SdkMemory.Read<float >(Pointer+28); set { SdkMemory.Write(Pointer+28,value); } }
    public void @InitializeAt(int @nTime,bool @Looped,bool @bUseAnimIdleStance,float @fBlendData) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4053 >(4053)(Pointer,@nTime,(@Looped ? 1 : 0),(@bUseAnimIdleStance ? 1 : 0),@fBlendData); }
}
