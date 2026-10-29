// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CBulletInfo : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=44;
    public CBulletInfo(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_nWeaponType")]
    public eWeaponType @WeaponType { get => SdkMemory.Read<eWeaponType >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("m_pCreator")]
    public CEntity? @Creator { get => SdkMemory.Read<IntPtr>(Pointer+4) == IntPtr.Zero ? null : new CEntity(SdkMemory.Read<IntPtr>(Pointer+4)); set { SdkMemory.Write(Pointer+4,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_nDestroyTime")]
    public int @DestroyTime { get => SdkMemory.Read<int >(Pointer+8); set { SdkMemory.Write(Pointer+8,value); } }
    [NativeMember("m_bExists")]
    public bool @Exists { get => SdkMemory.Read<bool >(Pointer+12); set { SdkMemory.Write(Pointer+12,value); } }
    [NativeMember("m_vecPosition")]
    public CVector @Position { get => new CVector(Pointer+16); set { SdkMemory.Copy(value.Pointer,Pointer+16,12); } }
    [NativeMember("m_vecVelocity")]
    public CVector @Velocity { get => new CVector(Pointer+28); set { SdkMemory.Copy(value.Pointer,Pointer+28,12); } }
    [NativeMember("m_nDamage")]
    public short @Damage { get => SdkMemory.Read<short >(Pointer+40); set { SdkMemory.Write(Pointer+40,value); } }
    public static void @Initialise() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1238 >(1238)(); }
    public static void @Shutdown() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1239 >(1239)(); }
    public static bool @AddBullet(CEntity? @creator,eWeaponType @weaponType,CVector @position,CVector @velocity) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1240 >(1240)(@creator?.Pointer ?? IntPtr.Zero,(int)@weaponType,@position.Pointer,@velocity.Pointer); return __sdkResult != 0; }
    public static void @Update() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1241 >(1241)(); }
}
