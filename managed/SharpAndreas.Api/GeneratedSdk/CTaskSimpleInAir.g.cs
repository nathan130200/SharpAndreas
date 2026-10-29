// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CTaskSimpleInAir : CTaskSimple
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=60;
    public CTaskSimpleInAir(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_vecPosn")]
    public CVector @Position { get => new CVector(Pointer+8); set { SdkMemory.Copy(value.Pointer,Pointer+8,12); } }
    [NativeMember("m_fAngle")]
    public float @Angle { get => SdkMemory.Read<float >(Pointer+20); set { SdkMemory.Write(Pointer+20,value); } }
    [NativeMember("m_nSurfaceType")]
    public byte @SurfaceType { get => SdkMemory.Read<byte >(Pointer+24); set { SdkMemory.Write(Pointer+24,value); } }
    [NativeMember("_pad")]
    public NativeArray<sbyte> @Pad { get => new NativeArray<sbyte>(Pointer+25,3); }
    [NativeMember("m_pAnim")]
    public CAnimBlendAssociation? @Animation { get => SdkMemory.Read<IntPtr>(Pointer+28) == IntPtr.Zero ? null : new CAnimBlendAssociation(SdkMemory.Read<IntPtr>(Pointer+28)); set { SdkMemory.Write(Pointer+28,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_fHeight")]
    public float @Height { get => SdkMemory.Read<float >(Pointer+32); set { SdkMemory.Write(Pointer+32,value); } }
    [NativeMember("_pad2")]
    public NativeArray<sbyte> @Pad2 { get => new NativeArray<sbyte>(Pointer+37,3); }
    [NativeMember("m_nProcessCounter")]
    public int @ProcessCounter { get => SdkMemory.Read<int >(Pointer+40); set { SdkMemory.Write(Pointer+40,value); } }
    [NativeMember("m_timer")]
    public CTaskTimer @Timer { get => new CTaskTimer(Pointer+44); set { SdkMemory.Copy(value.Pointer,Pointer+44,12); } }
    [NativeMember("m_pEntity")]
    public CEntity? @Entity { get => SdkMemory.Read<IntPtr>(Pointer+56) == IntPtr.Zero ? null : new CEntity(SdkMemory.Read<IntPtr>(Pointer+56)); set { SdkMemory.Write(Pointer+56,value?.Pointer ?? IntPtr.Zero); } }
    public void @InitializeAt(bool @bUsingJumpGlide,bool @bUsingFallGlide,bool @bUsingClimbJump) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1320 >(1320)(Pointer,(@bUsingJumpGlide ? 1 : 0),(@bUsingFallGlide ? 1 : 0),(@bUsingClimbJump ? 1 : 0)); }
}
