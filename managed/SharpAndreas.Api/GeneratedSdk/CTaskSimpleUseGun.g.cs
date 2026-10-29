// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CTaskSimpleUseGun : CTaskSimple
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=60;
    public CTaskSimpleUseGun(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_bIsFinished")]
    public bool @IsFinished { get => SdkMemory.Read<bool >(Pointer+8); set { SdkMemory.Write(Pointer+8,value); } }
    [NativeMember("m_bIsInControl")]
    public bool @IsInControl { get => SdkMemory.Read<bool >(Pointer+9); set { SdkMemory.Write(Pointer+9,value); } }
    [NativeMember("m_bMoveControl")]
    public bool @MoveControl { get => SdkMemory.Read<bool >(Pointer+10); set { SdkMemory.Write(Pointer+10,value); } }
    [NativeMember("m_bFiredGun")]
    public bool @FiredGun { get => SdkMemory.Read<bool >(Pointer+11); set { SdkMemory.Write(Pointer+11,value); } }
    [NativeMember("m_bBlockedLOS")]
    public bool @BlockedLOS { get => SdkMemory.Read<bool >(Pointer+12); set { SdkMemory.Write(Pointer+12,value); } }
    [NativeMember("m_bSkipAim")]
    public bool @SkipAim { get => SdkMemory.Read<bool >(Pointer+14); set { SdkMemory.Write(Pointer+14,value); } }
    [NativeMember("m_nNextCommand")]
    public byte @NextCommand { get => SdkMemory.Read<byte >(Pointer+15); set { SdkMemory.Write(Pointer+15,value); } }
    [NativeMember("m_nLastCommand")]
    public byte @LastCommand { get => SdkMemory.Read<byte >(Pointer+16); set { SdkMemory.Write(Pointer+16,value); } }
    [NativeMember("m_vecMoveCommand")]
    public CVector2D @MoveCommand { get => new CVector2D(Pointer+20); set { SdkMemory.Copy(value.Pointer,Pointer+20,8); } }
    [NativeMember("m_pTarget")]
    public CEntity? @Target { get => SdkMemory.Read<IntPtr>(Pointer+28) == IntPtr.Zero ? null : new CEntity(SdkMemory.Read<IntPtr>(Pointer+28)); set { SdkMemory.Write(Pointer+28,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_vecTarget")]
    public CVector @TargetValue { get => new CVector(Pointer+32); set { SdkMemory.Copy(value.Pointer,Pointer+32,12); } }
    [NativeMember("m_pAnim")]
    public CAnimBlendAssociation? @Animation { get => SdkMemory.Read<IntPtr>(Pointer+44) == IntPtr.Zero ? null : new CAnimBlendAssociation(SdkMemory.Read<IntPtr>(Pointer+44)); set { SdkMemory.Write(Pointer+44,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_pWeaponInfo")]
    public CWeaponInfo? @WeaponInfo { get => SdkMemory.Read<IntPtr>(Pointer+48) == IntPtr.Zero ? null : new CWeaponInfo(SdkMemory.Read<IntPtr>(Pointer+48)); set { SdkMemory.Write(Pointer+48,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_nBurstLength")]
    public ushort @BurstLength { get => SdkMemory.Read<ushort >(Pointer+52); set { SdkMemory.Write(Pointer+52,value); } }
    [NativeMember("m_nBurstShots")]
    public ushort @BurstShots { get => SdkMemory.Read<ushort >(Pointer+54); set { SdkMemory.Write(Pointer+54,value); } }
    [NativeMember("m_nCountDownFrames")]
    public byte @CountDownFrames { get => SdkMemory.Read<byte >(Pointer+56); set { SdkMemory.Write(Pointer+56,value); } }
    [NativeMember("m_ArmIKInUse")]
    public bool @ArmIKInUse { get => SdkMemory.Read<bool >(Pointer+57); set { SdkMemory.Write(Pointer+57,value); } }
    [NativeMember("m_LookIKInUse")]
    public bool @LookIKInUse { get => SdkMemory.Read<bool >(Pointer+58); set { SdkMemory.Write(Pointer+58,value); } }
    [NativeMember("m_bAimImmediate")]
    public bool @AimImmediate { get => SdkMemory.Read<bool >(Pointer+59); set { SdkMemory.Write(Pointer+59,value); } }
    public void @InitializeAt(CEntity? @pTargetEntity,CVector @vecTarget,byte @nCommand,ushort @nBurstLength,bool @bAimImmediate) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1313 >(1313)(Pointer,@pTargetEntity?.Pointer ?? IntPtr.Zero,@vecTarget.Pointer,@nCommand,@nBurstLength,(@bAimImmediate ? 1 : 0)); }
}
