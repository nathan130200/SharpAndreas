// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CWeaponModelInfo : CClumpModelInfo
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=40;
    public CWeaponModelInfo(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_weaponInfo")]
    public eWeaponType @WeaponInfo { get => SdkMemory.Read<eWeaponType >(Pointer+36); set { SdkMemory.Write(Pointer+36,value); } }
}
