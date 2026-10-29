// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CTaskSimpleSwim : CTaskSimple
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=100;
    public CTaskSimpleSwim(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_bFinishedBlending")]
    public bool @FinishedBlending { get => SdkMemory.Read<bool >(Pointer+8); set { SdkMemory.Write(Pointer+8,value); } }
    [NativeMember("m_bAnimBlockRefAdded")]
    public bool @AnimationBlockRefAdded { get => SdkMemory.Read<bool >(Pointer+9); set { SdkMemory.Write(Pointer+9,value); } }
    [NativeMember("m_nSwimState")]
    public eSwimState @SwimState { get => SdkMemory.Read<eSwimState >(Pointer+10); set { SdkMemory.Write(Pointer+10,value); } }
    [NativeMember("m_AnimID")]
    public int @AnimationID { get => SdkMemory.Read<int >(Pointer+12); set { SdkMemory.Write(Pointer+12,value); } }
    [NativeMember("m_fAnimSpeed")]
    public float @AnimationSpeed { get => SdkMemory.Read<float >(Pointer+16); set { SdkMemory.Write(Pointer+16,value); } }
    [NativeMember("m_vecPos")]
    public CVector @Position { get => new CVector(Pointer+20); set { SdkMemory.Copy(value.Pointer,Pointer+20,12); } }
    [NativeMember("m_pPed")]
    public CPed? @Ped { get => SdkMemory.Read<IntPtr>(Pointer+32) == IntPtr.Zero ? null : new CPed(SdkMemory.Read<IntPtr>(Pointer+32)); set { SdkMemory.Write(Pointer+32,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("flt_24")]
    public float @Flt24 { get => SdkMemory.Read<float >(Pointer+36); set { SdkMemory.Write(Pointer+36,value); } }
    [NativeMember("flt_28")]
    public float @Flt28 { get => SdkMemory.Read<float >(Pointer+40); set { SdkMemory.Write(Pointer+40,value); } }
    [NativeMember("flt_2C")]
    public float @Flt2C { get => SdkMemory.Read<float >(Pointer+44); set { SdkMemory.Write(Pointer+44,value); } }
    [NativeMember("flt_30")]
    public float @Flt30 { get => SdkMemory.Read<float >(Pointer+48); set { SdkMemory.Write(Pointer+48,value); } }
    [NativeMember("flt_34")]
    public float @Flt34 { get => SdkMemory.Read<float >(Pointer+52); set { SdkMemory.Write(Pointer+52,value); } }
    [NativeMember("m_pEntity")]
    public CEntity? @Entity { get => SdkMemory.Read<IntPtr>(Pointer+56) == IntPtr.Zero ? null : new CEntity(SdkMemory.Read<IntPtr>(Pointer+56)); set { SdkMemory.Write(Pointer+56,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_pClimbPos")]
    public CVector @ClimbPosition { get => new CVector(Pointer+60); set { SdkMemory.Copy(value.Pointer,Pointer+60,12); } }
    [NativeMember("m_fAngle")]
    public float @Angle { get => SdkMemory.Read<float >(Pointer+72); set { SdkMemory.Write(Pointer+72,value); } }
    [NativeMember("m_nSurfaceType")]
    public byte @SurfaceType { get => SdkMemory.Read<byte >(Pointer+76); set { SdkMemory.Write(Pointer+76,value); } }
    [NativeMember("flt_50")]
    public float @Flt50 { get => SdkMemory.Read<float >(Pointer+80); set { SdkMemory.Write(Pointer+80,value); } }
    [NativeMember("flt_54")]
    public float @Flt54 { get => SdkMemory.Read<float >(Pointer+84); set { SdkMemory.Write(Pointer+84,value); } }
    [NativeMember("m_nProcessTimeCounter")]
    public int @ProcessTimeCounter { get => SdkMemory.Read<int >(Pointer+88); set { SdkMemory.Write(Pointer+88,value); } }
    [NativeMember("m_pFxSystem")]
    public FxSystem_c? @FxSystem { get => SdkMemory.Read<IntPtr>(Pointer+92) == IntPtr.Zero ? null : new FxSystem_c(SdkMemory.Read<IntPtr>(Pointer+92)); set { SdkMemory.Write(Pointer+92,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_bTriggerWaterSplash")]
    public bool @TriggerWaterSplash { get => SdkMemory.Read<bool >(Pointer+96); set { SdkMemory.Write(Pointer+96,value); } }
    [NativeMember("pad2")]
    public NativeArray<sbyte> @Pad2 { get => new NativeArray<sbyte>(Pointer+97,3); }
    public void @InitializeAt(CVector? @pPosn,CPed? @pPed) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1317 >(1317)(Pointer,@pPosn?.Pointer ?? IntPtr.Zero,@pPed?.Pointer ?? IntPtr.Zero); }
}
