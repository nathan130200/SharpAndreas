// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CShotInfo : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=44;
    public CShotInfo(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_nWeaponType")]
    public int @WeaponType { get => SdkMemory.Read<int >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("m_vecOrigin")]
    public CVector @Origin { get => new CVector(Pointer+4); set { SdkMemory.Copy(value.Pointer,Pointer+4,12); } }
    [NativeMember("m_vecTargetOffset")]
    public CVector @TargetOffset { get => new CVector(Pointer+16); set { SdkMemory.Copy(value.Pointer,Pointer+16,12); } }
    [NativeMember("m_fRange")]
    public float @Range { get => SdkMemory.Read<float >(Pointer+28); set { SdkMemory.Write(Pointer+28,value); } }
    [NativeMember("m_pCreator")]
    public CEntity? @Creator { get => SdkMemory.Read<IntPtr>(Pointer+32) == IntPtr.Zero ? null : new CEntity(SdkMemory.Read<IntPtr>(Pointer+32)); set { SdkMemory.Write(Pointer+32,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_nDestroyTime")]
    public int @DestroyTime { get => SdkMemory.Read<int >(Pointer+36); set { SdkMemory.Write(Pointer+36,value); } }
    [NativeMember("m_bExist")]
    public bool @Exist { get => SdkMemory.Read<bool >(Pointer+40); set { SdkMemory.Write(Pointer+40,value); } }
    [NativeMember("m_bExecuted")]
    public bool @Executed { get => SdkMemory.Read<bool >(Pointer+41); set { SdkMemory.Write(Pointer+41,value); } }
    [NativeMember("ms_afRandTable")]
    public static NativePointer<float> @RandTable { get => new NativePointer<float>(new IntPtr(0xC89628)); }
    public static void @Initialise() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3777 >(3777)(); }
    public static void @Shutdown() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3778 >(3778)(); }
    public static bool @AddShot(CEntity? @creator,eWeaponType @weaponType,CVector @origin,CVector @target) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3779 >(3779)(@creator?.Pointer ?? IntPtr.Zero,(int)@weaponType,@origin.Pointer,@target.Pointer); return __sdkResult != 0; }
    public static bool @GetFlameThrowerShotPosn(byte @shotId,CVector? @outPosn) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3780 >(3780)(@shotId,@outPosn?.Pointer ?? IntPtr.Zero); return __sdkResult != 0; }
    public static void @Update() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3781 >(3781)(); }
}
