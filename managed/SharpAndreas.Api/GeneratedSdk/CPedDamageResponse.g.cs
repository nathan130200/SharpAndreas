// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CPedDamageResponse : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=12;
    public CPedDamageResponse(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_fDamageHealth")]
    public float @DamageHealth { get => SdkMemory.Read<float >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("m_fDamageArmor")]
    public float @DamageArmor { get => SdkMemory.Read<float >(Pointer+4); set { SdkMemory.Write(Pointer+4,value); } }
    [NativeMember("m_bHealthZero")]
    public bool @HealthZero { get => SdkMemory.Read<bool >(Pointer+8); set { SdkMemory.Write(Pointer+8,value); } }
    [NativeMember("m_bForceDeath")]
    public bool @ForceDeath { get => SdkMemory.Read<bool >(Pointer+9); set { SdkMemory.Write(Pointer+9,value); } }
    [NativeMember("m_bDamageCalculated")]
    public bool @DamageCalculated { get => SdkMemory.Read<bool >(Pointer+10); set { SdkMemory.Write(Pointer+10,value); } }
    [NativeMember("m_bCheckIfAffectsPed")]
    public bool @CheckIfAffectsPed { get => SdkMemory.Read<bool >(Pointer+11); set { SdkMemory.Write(Pointer+11,value); } }
    public void @InitializeAt() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3246 >(3246)(Pointer); }
}
