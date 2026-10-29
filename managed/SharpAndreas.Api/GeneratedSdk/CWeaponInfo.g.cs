// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CWeaponInfo : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=112;
    public CWeaponInfo(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_nWeaponFire")]
    public uint @WeaponFire { get => SdkMemory.Read<uint >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("m_fTargetRange")]
    public float @TargetRange { get => SdkMemory.Read<float >(Pointer+4); set { SdkMemory.Write(Pointer+4,value); } }
    [NativeMember("m_fWeaponRange")]
    public float @WeaponRange { get => SdkMemory.Read<float >(Pointer+8); set { SdkMemory.Write(Pointer+8,value); } }
    [NativeMember("m_nModelId")]
    public int @ModelId { get => SdkMemory.Read<int >(Pointer+12); set { SdkMemory.Write(Pointer+12,value); } }
    [NativeMember("m_nModelId2")]
    public int @ModelId2 { get => SdkMemory.Read<int >(Pointer+16); set { SdkMemory.Write(Pointer+16,value); } }
    [NativeMember("m_nSlot")]
    public uint @Slot { get => SdkMemory.Read<uint >(Pointer+20); set { SdkMemory.Write(Pointer+20,value); } }
    [NativeMember("m_nFlags")]
    public CWeaponInfo___unnamed__at_D__plugin_sdk_plugin_sa_game_sa_CWeaponInfo__9d55ea9e62 @Flags { get => new CWeaponInfo___unnamed__at_D__plugin_sdk_plugin_sa_game_sa_CWeaponInfo__9d55ea9e62(Pointer+24); set { SdkMemory.Copy(value.Pointer,Pointer+24,4); } }
    [NativeMember("m_nAnimToPlay")]
    public uint @AnimationToPlay { get => SdkMemory.Read<uint >(Pointer+28); set { SdkMemory.Write(Pointer+28,value); } }
    [NativeMember("m_nAmmoClip")]
    public ushort @AmmoClip { get => SdkMemory.Read<ushort >(Pointer+32); set { SdkMemory.Write(Pointer+32,value); } }
    [NativeMember("m_nDamage")]
    public ushort @Damage { get => SdkMemory.Read<ushort >(Pointer+34); set { SdkMemory.Write(Pointer+34,value); } }
    [NativeMember("m_vecFireOffset")]
    public CVector @FireOffset { get => new CVector(Pointer+36); set { SdkMemory.Copy(value.Pointer,Pointer+36,12); } }
    [NativeMember("m_nSkillLevel")]
    public uint @SkillLevel { get => SdkMemory.Read<uint >(Pointer+48); set { SdkMemory.Write(Pointer+48,value); } }
    [NativeMember("m_nReqStatLevel")]
    public uint @ReqStatLevel { get => SdkMemory.Read<uint >(Pointer+52); set { SdkMemory.Write(Pointer+52,value); } }
    [NativeMember("m_fAccuracy")]
    public float @Accuracy { get => SdkMemory.Read<float >(Pointer+56); set { SdkMemory.Write(Pointer+56,value); } }
    [NativeMember("m_fMoveSpeed")]
    public float @MoveSpeed { get => SdkMemory.Read<float >(Pointer+60); set { SdkMemory.Write(Pointer+60,value); } }
    [NativeMember("m_fAnimLoopStart")]
    public float @AnimationLoopStart { get => SdkMemory.Read<float >(Pointer+64); set { SdkMemory.Write(Pointer+64,value); } }
    [NativeMember("m_fAnimLoopEnd")]
    public float @AnimationLoopEnd { get => SdkMemory.Read<float >(Pointer+68); set { SdkMemory.Write(Pointer+68,value); } }
    [NativeMember("m_nAnimLoopFire")]
    public uint @AnimationLoopFire { get => SdkMemory.Read<uint >(Pointer+72); set { SdkMemory.Write(Pointer+72,value); } }
    [NativeMember("m_nAnimLoop2Start")]
    public uint @AnimationLoop2Start { get => SdkMemory.Read<uint >(Pointer+76); set { SdkMemory.Write(Pointer+76,value); } }
    [NativeMember("m_nAnimLoop2End")]
    public uint @AnimationLoop2End { get => SdkMemory.Read<uint >(Pointer+80); set { SdkMemory.Write(Pointer+80,value); } }
    [NativeMember("m_nAnimLoop2Fire")]
    public uint @AnimationLoop2Fire { get => SdkMemory.Read<uint >(Pointer+84); set { SdkMemory.Write(Pointer+84,value); } }
    [NativeMember("m_fBreakoutTime")]
    public float @BreakoutTime { get => SdkMemory.Read<float >(Pointer+88); set { SdkMemory.Write(Pointer+88,value); } }
    [NativeMember("m_fSpeed")]
    public float @Speed { get => SdkMemory.Read<float >(Pointer+92); set { SdkMemory.Write(Pointer+92,value); } }
    [NativeMember("m_fRadius")]
    public float @Radius { get => SdkMemory.Read<float >(Pointer+96); set { SdkMemory.Write(Pointer+96,value); } }
    [NativeMember("m_fLifespan")]
    public float @Lifespan { get => SdkMemory.Read<float >(Pointer+100); set { SdkMemory.Write(Pointer+100,value); } }
    [NativeMember("m_fSpread")]
    public float @Spread { get => SdkMemory.Read<float >(Pointer+104); set { SdkMemory.Write(Pointer+104,value); } }
    [NativeMember("m_nAimOffsetIndex")]
    public ushort @AimOffsetIndex { get => SdkMemory.Read<ushort >(Pointer+108); set { SdkMemory.Write(Pointer+108,value); } }
    [NativeMember("m_nBaseCombo")]
    public byte @BaseCombo { get => SdkMemory.Read<byte >(Pointer+110); set { SdkMemory.Write(Pointer+110,value); } }
    [NativeMember("m_nNumCombos")]
    public byte @CountCombos { get => SdkMemory.Read<byte >(Pointer+111); set { SdkMemory.Write(Pointer+111,value); } }
    [NativeMember("ms_aWeaponNames")]
    public static NativePointer<IntPtr> @WeaponNames { get => new NativePointer<IntPtr>(new IntPtr(0x8D6150)); }
    public void @InitializeAt() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1305 >(1305)(Pointer); }
    public void @DestroyNative() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1306 >(1306)(Pointer); }
    public static void @LoadWeaponData() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1307 >(1307)(); }
    public static CWeaponInfo? @GetWeaponInfo(eWeaponType @weaponType,byte @skill) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1308 >(1308)((int)@weaponType,@skill); return __sdkResult == IntPtr.Zero ? null : new CWeaponInfo(__sdkResult); }
    public static eWeaponType @FindWeaponType(NativePointer<sbyte> @name) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1309 >(1309)(@name.Pointer); return (eWeaponType)__sdkResult; }
    public static eWeaponFire @FindWeaponFireType(NativePointer<sbyte> @name) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1310 >(1310)(@name.Pointer); return (eWeaponFire)__sdkResult; }
    public static void @Initialise() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1311 >(1311)(); }
    public static void @Shutdown() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1312 >(1312)(); }
}
