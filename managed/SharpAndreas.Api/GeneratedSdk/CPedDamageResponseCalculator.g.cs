// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CPedDamageResponseCalculator : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=20;
    public CPedDamageResponseCalculator(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_pDamager")]
    public CEntity? @Damager { get => SdkMemory.Read<IntPtr>(Pointer+0) == IntPtr.Zero ? null : new CEntity(SdkMemory.Read<IntPtr>(Pointer+0)); }
    [NativeMember("m_fDamageFactor")]
    public float @DamageFactor { get => SdkMemory.Read<float >(Pointer+4); set { SdkMemory.Write(Pointer+4,value); } }
    [NativeMember("m_bodyPart")]
    public byte @BodyPart { get => SdkMemory.Read<byte >(Pointer+8); set { SdkMemory.Write(Pointer+8,value); } }
    [NativeMember("m_weaponType")]
    public eWeaponType @WeaponType { get => SdkMemory.Read<eWeaponType >(Pointer+12); set { SdkMemory.Write(Pointer+12,value); } }
    [NativeMember("m_bSpeak")]
    public bool @Speak { get => SdkMemory.Read<bool >(Pointer+16); set { SdkMemory.Write(Pointer+16,value); } }
    [NativeMember("ms_damageFactor")]
    public static float @DamageFactorValue { get => SdkMemory.Read<float >(new IntPtr(0x8A6260)); set { SdkMemory.Write(new IntPtr(0x8A6260),value); } }
    public void @InitializeAt(CEntity? @entity,float @fDamage,eWeaponType @weaponType,byte @bodyPart,bool @bSpeak) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3247 >(3247)(Pointer,@entity?.Pointer ?? IntPtr.Zero,@fDamage,(int)@weaponType,@bodyPart,(@bSpeak ? 1 : 0)); }
    public void @AccountForPedDamageStats(CPed? @ped,CPedDamageResponse @response) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3248 >(3248)(Pointer,@ped?.Pointer ?? IntPtr.Zero,@response.Pointer); }
    public void @AccountForPedArmour(CPed? @ped,CPedDamageResponse @response) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3249 >(3249)(Pointer,@ped?.Pointer ?? IntPtr.Zero,@response.Pointer); }
    public bool @ComputeWillForceDeath(CPed? @ped,CPedDamageResponse @response) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3250 >(3250)(Pointer,@ped?.Pointer ?? IntPtr.Zero,@response.Pointer); return __sdkResult != 0; }
    public void @ComputeWillKillPed(CPed? @ped,CPedDamageResponse @response,bool @bSpeak) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3251 >(3251)(Pointer,@ped?.Pointer ?? IntPtr.Zero,@response.Pointer,(@bSpeak ? 1 : 0)); }
    public void @ComputeDamageResponse(CPed? @ped,CPedDamageResponse @response,bool @bSpeak) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3252 >(3252)(Pointer,@ped?.Pointer ?? IntPtr.Zero,@response.Pointer,(@bSpeak ? 1 : 0)); }
}
