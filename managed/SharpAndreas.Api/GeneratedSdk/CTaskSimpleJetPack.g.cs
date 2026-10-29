// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CTaskSimpleJetPack : CTaskSimple
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=112;
    public CTaskSimpleJetPack(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_bIsFinished")]
    public bool @IsFinished { get => SdkMemory.Read<bool >(Pointer+8); set { SdkMemory.Write(Pointer+8,value); } }
    [NativeMember("m_bAddedIdleAnim")]
    public bool @AddedIdleAnimation { get => SdkMemory.Read<bool >(Pointer+9); set { SdkMemory.Write(Pointer+9,value); } }
    [NativeMember("m_bAnimsReferenced")]
    public bool @AnimsReferenced { get => SdkMemory.Read<bool >(Pointer+10); set { SdkMemory.Write(Pointer+10,value); } }
    [NativeMember("m_bAttackButtonPressed")]
    public bool @AttackButtonPressed { get => SdkMemory.Read<bool >(Pointer+11); set { SdkMemory.Write(Pointer+11,value); } }
    [NativeMember("m_bSwitchedWeapons")]
    public bool @SwitchedWeapons { get => SdkMemory.Read<bool >(Pointer+12); set { SdkMemory.Write(Pointer+12,value); } }
    [NativeMember("m_nThrustStop")]
    public sbyte @ThrustStop { get => SdkMemory.Read<sbyte >(Pointer+13); set { SdkMemory.Write(Pointer+13,value); } }
    [NativeMember("m_nThrustFwd")]
    public sbyte @ThrustFwd { get => SdkMemory.Read<sbyte >(Pointer+14); set { SdkMemory.Write(Pointer+14,value); } }
    [NativeMember("m_fThrustStrafe")]
    public float @ThrustStrafe { get => SdkMemory.Read<float >(Pointer+16); set { SdkMemory.Write(Pointer+16,value); } }
    [NativeMember("m_fThrustAngle")]
    public float @ThrustAngle { get => SdkMemory.Read<float >(Pointer+20); set { SdkMemory.Write(Pointer+20,value); } }
    [NativeMember("m_fLegSwingFwd")]
    public float @LegSwingFwd { get => SdkMemory.Read<float >(Pointer+24); set { SdkMemory.Write(Pointer+24,value); } }
    [NativeMember("m_fLegSwingSide")]
    public float @LegSwingSide { get => SdkMemory.Read<float >(Pointer+28); set { SdkMemory.Write(Pointer+28,value); } }
    [NativeMember("m_fLegTwist")]
    public float @LegTwist { get => SdkMemory.Read<float >(Pointer+32); set { SdkMemory.Write(Pointer+32,value); } }
    [NativeMember("m_fLegSwingFwdSpeed")]
    public float @LegSwingFwdSpeed { get => SdkMemory.Read<float >(Pointer+36); set { SdkMemory.Write(Pointer+36,value); } }
    [NativeMember("m_fLegSwingSideSpeed")]
    public float @LegSwingSideSpeed { get => SdkMemory.Read<float >(Pointer+40); set { SdkMemory.Write(Pointer+40,value); } }
    [NativeMember("m_fLegTwistSpeed")]
    public float @LegTwistSpeed { get => SdkMemory.Read<float >(Pointer+44); set { SdkMemory.Write(Pointer+44,value); } }
    [NativeMember("m_vecOldSpeed")]
    public CVector @OldSpeed { get => new CVector(Pointer+48); set { SdkMemory.Copy(value.Pointer,Pointer+48,12); } }
    [NativeMember("m_fOldHeading")]
    public float @OldHeading { get => SdkMemory.Read<float >(Pointer+60); set { SdkMemory.Write(Pointer+60,value); } }
    [NativeMember("m_pJetPackClump")]
    public RpClump? @JetPackClump { get => SdkMemory.Read<IntPtr>(Pointer+64) == IntPtr.Zero ? null : new RpClump(SdkMemory.Read<IntPtr>(Pointer+64)); set { SdkMemory.Write(Pointer+64,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_pAnim")]
    public CAnimBlendAssociation? @Animation { get => SdkMemory.Read<IntPtr>(Pointer+68) == IntPtr.Zero ? null : new CAnimBlendAssociation(SdkMemory.Read<IntPtr>(Pointer+68)); set { SdkMemory.Write(Pointer+68,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_vecTargetPos")]
    public CVector @TargetPosition { get => new CVector(Pointer+72); set { SdkMemory.Copy(value.Pointer,Pointer+72,12); } }
    [NativeMember("m_fCruiseHeight")]
    public float @CruiseHeight { get => SdkMemory.Read<float >(Pointer+84); set { SdkMemory.Write(Pointer+84,value); } }
    [NativeMember("m_nHoverTime")]
    public int @HoverTime { get => SdkMemory.Read<int >(Pointer+88); set { SdkMemory.Write(Pointer+88,value); } }
    [NativeMember("m_nStartHover")]
    public uint @StartHover { get => SdkMemory.Read<uint >(Pointer+92); set { SdkMemory.Write(Pointer+92,value); } }
    [NativeMember("m_pTargetEnt")]
    public CEntity? @TargetEnt { get => SdkMemory.Read<IntPtr>(Pointer+96) == IntPtr.Zero ? null : new CEntity(SdkMemory.Read<IntPtr>(Pointer+96)); set { SdkMemory.Write(Pointer+96,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_pFxSysL")]
    public FxSystem_c? @FxSysL { get => SdkMemory.Read<IntPtr>(Pointer+100) == IntPtr.Zero ? null : new FxSystem_c(SdkMemory.Read<IntPtr>(Pointer+100)); set { SdkMemory.Write(Pointer+100,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_pFxSysR")]
    public FxSystem_c? @FxSysR { get => SdkMemory.Read<IntPtr>(Pointer+104) == IntPtr.Zero ? null : new FxSystem_c(SdkMemory.Read<IntPtr>(Pointer+104)); set { SdkMemory.Write(Pointer+104,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_fxKeyTime")]
    public float @FxKeyTime { get => SdkMemory.Read<float >(Pointer+108); set { SdkMemory.Write(Pointer+108,value); } }
    [NativeMember("THRUST_NOMINAL")]
    public static float @THRUSTNOMINAL { get => SdkMemory.Read<float >(new IntPtr(0x8D2F38)); set { SdkMemory.Write(new IntPtr(0x8D2F38),value); } }
    [NativeMember("THRUST_FULL")]
    public static float @THRUSTFULL { get => SdkMemory.Read<float >(new IntPtr(0x8D2F3C)); set { SdkMemory.Write(new IntPtr(0x8D2F3C),value); } }
    [NativeMember("THRUST_STRAFE")]
    public static float @THRUSTSTRAFE { get => SdkMemory.Read<float >(new IntPtr(0x8D2F40)); set { SdkMemory.Write(new IntPtr(0x8D2F40),value); } }
    [NativeMember("THRUST_STOP")]
    public static float @THRUSTSTOP { get => SdkMemory.Read<float >(new IntPtr(0x8D2F44)); set { SdkMemory.Write(new IntPtr(0x8D2F44),value); } }
    [NativeMember("THRUST_MAX_ANGLE")]
    public static float @THRUSTMAXANGLE { get => SdkMemory.Read<float >(new IntPtr(0x8D2F48)); set { SdkMemory.Write(new IntPtr(0x8D2F48),value); } }
    [NativeMember("THRUST_MOVE_DAMPING")]
    public static float @THRUSTMOVEDAMPING { get => SdkMemory.Read<float >(new IntPtr(0x8D2F4C)); set { SdkMemory.Write(new IntPtr(0x8D2F4C),value); } }
    [NativeMember("JETPACK_TURN_RATE")]
    public static float @JETPACKTURNRATE { get => SdkMemory.Read<float >(new IntPtr(0x8D2F50)); set { SdkMemory.Write(new IntPtr(0x8D2F50),value); } }
    [NativeMember("JETPACK_ANGLE_RATE")]
    public static float @JETPACKANGLERATE { get => SdkMemory.Read<float >(new IntPtr(0x8D2F54)); set { SdkMemory.Write(new IntPtr(0x8D2F54),value); } }
    [NativeMember("LEG_SWING_MAX_ANGLE")]
    public static float @LEGSWINGMAXANGLE { get => SdkMemory.Read<float >(new IntPtr(0x8D2F58)); set { SdkMemory.Write(new IntPtr(0x8D2F58),value); } }
    [NativeMember("LEG_SWING_DELTA_V_MULT")]
    public static float @LEGSWINGDELTAVMULT { get => SdkMemory.Read<float >(new IntPtr(0x8D2F5C)); set { SdkMemory.Write(new IntPtr(0x8D2F5C),value); } }
    [NativeMember("LEG_SWING_GRAVITY_MULT")]
    public static float @LEGSWINGGRAVITYMULT { get => SdkMemory.Read<float >(new IntPtr(0x8D2F60)); set { SdkMemory.Write(new IntPtr(0x8D2F60),value); } }
    [NativeMember("LEG_SWING_DAMP_FRAC")]
    public static float @LEGSWINGDAMPFRAC { get => SdkMemory.Read<float >(new IntPtr(0x8D2F64)); set { SdkMemory.Write(new IntPtr(0x8D2F64),value); } }
    public void @InitializeAt(CVector? @pVecTargetPos,float @fCruiseHeight,int @nHoverTime) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1314 >(1314)(Pointer,@pVecTargetPos?.Pointer ?? IntPtr.Zero,@fCruiseHeight,@nHoverTime); }
}
