// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CProjectileInfo : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=36;
    public CProjectileInfo(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_nWeaponType")]
    public uint @WeaponType { get => SdkMemory.Read<uint >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("m_pCreator")]
    public CEntity? @Creator { get => SdkMemory.Read<IntPtr>(Pointer+4) == IntPtr.Zero ? null : new CEntity(SdkMemory.Read<IntPtr>(Pointer+4)); set { SdkMemory.Write(Pointer+4,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_pVictim")]
    public CEntity? @Victim { get => SdkMemory.Read<IntPtr>(Pointer+8) == IntPtr.Zero ? null : new CEntity(SdkMemory.Read<IntPtr>(Pointer+8)); set { SdkMemory.Write(Pointer+8,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_nDestroyTime")]
    public int @DestroyTime { get => SdkMemory.Read<int >(Pointer+12); set { SdkMemory.Write(Pointer+12,value); } }
    [NativeMember("m_bActive")]
    public bool @Active { get => SdkMemory.Read<bool >(Pointer+16); set { SdkMemory.Write(Pointer+16,value); } }
    [NativeMember("m_vecLastPosn")]
    public CVector @LastPosition { get => new CVector(Pointer+20); set { SdkMemory.Copy(value.Pointer,Pointer+20,12); } }
    [NativeMember("m_pFxSystem")]
    public FxSystem_c? @FxSystem { get => SdkMemory.Read<IntPtr>(Pointer+32) == IntPtr.Zero ? null : new FxSystem_c(SdkMemory.Read<IntPtr>(Pointer+32)); set { SdkMemory.Write(Pointer+32,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("ms_apProjectile")]
    public static NativePointer<IntPtr> @Projectile { get => new NativePointer<IntPtr>(new IntPtr(0xC89110)); }
    public static void @Initialise() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3541 >(3541)(); }
    public static void @RemoveFXSystem(byte @bInstantly) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3542 >(3542)(@bInstantly); }
    public static void @Shutdown() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3543 >(3543)(); }
    public static CProjectileInfo? @GetProjectileInfo(int @infoId) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3544 >(3544)(@infoId); return __sdkResult == IntPtr.Zero ? null : new CProjectileInfo(__sdkResult); }
    public static void @RemoveNotAdd(CEntity? @creator,eWeaponType @weaponType,CVector @posn) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3545 >(3545)(@creator?.Pointer ?? IntPtr.Zero,(int)@weaponType,@posn.Pointer); }
    public static bool @AddProjectile(CEntity? @creator,eWeaponType @weaponType,CVector @posn,float @force,CVector? @direction,CEntity? @victim) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3546 >(3546)(@creator?.Pointer ?? IntPtr.Zero,(int)@weaponType,@posn.Pointer,@force,@direction?.Pointer ?? IntPtr.Zero,@victim?.Pointer ?? IntPtr.Zero); return __sdkResult != 0; }
    public static void @RemoveDetonatorProjectiles() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3547 >(3547)(); }
    public static void @RemoveProjectile(CProjectileInfo? @projectileInfo,CProjectile? @projectileObject) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3548 >(3548)(@projectileInfo?.Pointer ?? IntPtr.Zero,@projectileObject?.Pointer ?? IntPtr.Zero); }
    public static void @Update() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3549 >(3549)(); }
    public static bool @IsProjectileInRange(float @x1,float @y1,float @z1,float @x2,float @y2,float @z2,bool @bDestroy) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3550 >(3550)(@x1,@y1,@z1,@x2,@y2,@z2,(@bDestroy ? 1 : 0)); return __sdkResult != 0; }
    public static void @RemoveAllProjectiles() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3551 >(3551)(); }
    public static bool @RemoveIfThisIsAProjectile(CObject? @object) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3552 >(3552)(@object?.Pointer ?? IntPtr.Zero); return __sdkResult != 0; }
}
