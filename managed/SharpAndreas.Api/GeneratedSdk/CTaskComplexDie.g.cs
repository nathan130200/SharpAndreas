// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CTaskComplexDie : CTaskComplex
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=40;
    public CTaskComplexDie(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_nWeaponType")]
    public eWeaponType @WeaponType { get => SdkMemory.Read<eWeaponType >(Pointer+12); set { SdkMemory.Write(Pointer+12,value); } }
    [NativeMember("m_animGroup")]
    public int @AnimationGroup { get => SdkMemory.Read<int >(Pointer+16); set { SdkMemory.Write(Pointer+16,value); } }
    [NativeMember("m_animID")]
    public int @AnimationID { get => SdkMemory.Read<int >(Pointer+20); set { SdkMemory.Write(Pointer+20,value); } }
    [NativeMember("m_fBlendDelta")]
    public float @BlendDelta { get => SdkMemory.Read<float >(Pointer+24); set { SdkMemory.Write(Pointer+24,value); } }
    [NativeMember("m_fAnimSpeed")]
    public float @AnimationSpeed { get => SdkMemory.Read<float >(Pointer+28); set { SdkMemory.Write(Pointer+28,value); } }
    [NativeMember("nFallToDeathDir")]
    public int @FallToDeathDirection { get => SdkMemory.Read<int >(Pointer+36); set { SdkMemory.Write(Pointer+36,value); } }
    public void @InitializeAt(eWeaponType @nWeaponType,int @animGroup,int @animID,float @fBlendDelta,float @fAnimSpeed,bool @bBeingKilledByStealth,bool @bFallingToDeath,int @nFallToDeathDir,bool @bFallToDeathOverRailing) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4005 >(4005)(Pointer,(int)@nWeaponType,@animGroup,@animID,@fBlendDelta,@fAnimSpeed,(@bBeingKilledByStealth ? 1 : 0),(@bFallingToDeath ? 1 : 0),@nFallToDeathDir,(@bFallToDeathOverRailing ? 1 : 0)); }
}
