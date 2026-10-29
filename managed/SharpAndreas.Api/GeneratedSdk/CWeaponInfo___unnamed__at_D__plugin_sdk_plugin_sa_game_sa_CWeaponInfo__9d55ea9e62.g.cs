// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CWeaponInfo___unnamed__at_D__plugin_sdk_plugin_sa_game_sa_CWeaponInfo__9d55ea9e62 : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=4;
    public CWeaponInfo___unnamed__at_D__plugin_sdk_plugin_sa_game_sa_CWeaponInfo__9d55ea9e62(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("bCanAim")]
    public uint @CanAim { get => (uint)SdkMemory.ReadBits(Pointer,0,1); set { SdkMemory.WriteBits(Pointer,0,1,unchecked((ulong)value)); } }
    [NativeMember("bAimWithArm")]
    public uint @AimWithArm { get => (uint)SdkMemory.ReadBits(Pointer,1,1); set { SdkMemory.WriteBits(Pointer,1,1,unchecked((ulong)value)); } }
    [NativeMember("b1stPerson")]
    public uint @B1stPerson { get => (uint)SdkMemory.ReadBits(Pointer,2,1); set { SdkMemory.WriteBits(Pointer,2,1,unchecked((ulong)value)); } }
    [NativeMember("bOnlyFreeAim")]
    public uint @OnlyFreeAim { get => (uint)SdkMemory.ReadBits(Pointer,3,1); set { SdkMemory.WriteBits(Pointer,3,1,unchecked((ulong)value)); } }
    [NativeMember("bMoveAim")]
    public uint @MoveAim { get => (uint)SdkMemory.ReadBits(Pointer,4,1); set { SdkMemory.WriteBits(Pointer,4,1,unchecked((ulong)value)); } }
    [NativeMember("bMoveFire")]
    public uint @MoveFire { get => (uint)SdkMemory.ReadBits(Pointer,5,1); set { SdkMemory.WriteBits(Pointer,5,1,unchecked((ulong)value)); } }
    [NativeMember("b06")]
    public uint @B06 { get => (uint)SdkMemory.ReadBits(Pointer,6,1); set { SdkMemory.WriteBits(Pointer,6,1,unchecked((ulong)value)); } }
    [NativeMember("b07")]
    public uint @B07 { get => (uint)SdkMemory.ReadBits(Pointer,7,1); set { SdkMemory.WriteBits(Pointer,7,1,unchecked((ulong)value)); } }
    [NativeMember("bThrow")]
    public uint @Throw { get => (uint)SdkMemory.ReadBits(Pointer,8,1); set { SdkMemory.WriteBits(Pointer,8,1,unchecked((ulong)value)); } }
    [NativeMember("bHeavy")]
    public uint @Heavy { get => (uint)SdkMemory.ReadBits(Pointer,9,1); set { SdkMemory.WriteBits(Pointer,9,1,unchecked((ulong)value)); } }
    [NativeMember("bContinuosFire")]
    public uint @ContinuosFire { get => (uint)SdkMemory.ReadBits(Pointer,10,1); set { SdkMemory.WriteBits(Pointer,10,1,unchecked((ulong)value)); } }
    [NativeMember("bTwinPistol")]
    public uint @TwinPistol { get => (uint)SdkMemory.ReadBits(Pointer,11,1); set { SdkMemory.WriteBits(Pointer,11,1,unchecked((ulong)value)); } }
    [NativeMember("bReload")]
    public uint @Reload { get => (uint)SdkMemory.ReadBits(Pointer,12,1); set { SdkMemory.WriteBits(Pointer,12,1,unchecked((ulong)value)); } }
    [NativeMember("bCrouchFire")]
    public uint @CrouchFire { get => (uint)SdkMemory.ReadBits(Pointer,13,1); set { SdkMemory.WriteBits(Pointer,13,1,unchecked((ulong)value)); } }
    [NativeMember("bReload2Start")]
    public uint @Reload2Start { get => (uint)SdkMemory.ReadBits(Pointer,14,1); set { SdkMemory.WriteBits(Pointer,14,1,unchecked((ulong)value)); } }
    [NativeMember("bLongReload")]
    public uint @LongReload { get => (uint)SdkMemory.ReadBits(Pointer,15,1); set { SdkMemory.WriteBits(Pointer,15,1,unchecked((ulong)value)); } }
    [NativeMember("bSlowdown")]
    public uint @Slowdown { get => (uint)SdkMemory.ReadBits(Pointer,16,1); set { SdkMemory.WriteBits(Pointer,16,1,unchecked((ulong)value)); } }
    [NativeMember("bRandSpeed")]
    public uint @RandSpeed { get => (uint)SdkMemory.ReadBits(Pointer,17,1); set { SdkMemory.WriteBits(Pointer,17,1,unchecked((ulong)value)); } }
    [NativeMember("bExpands")]
    public uint @Expands { get => (uint)SdkMemory.ReadBits(Pointer,18,1); set { SdkMemory.WriteBits(Pointer,18,1,unchecked((ulong)value)); } }
}
