// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CEntryExit___unnamed__at_D__plugin_sdk_plugin_sa_game_sa_CEntryExit_h__5360072982 : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=2;
    public CEntryExit___unnamed__at_D__plugin_sdk_plugin_sa_game_sa_CEntryExit_h__5360072982(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("bUnknownInterior")]
    public ushort @UnknownInterior { get => (ushort)SdkMemory.ReadBits(Pointer,0,1); set { SdkMemory.WriteBits(Pointer,0,1,unchecked((ulong)value)); } }
    [NativeMember("bUnknownPairing")]
    public ushort @UnknownPairing { get => (ushort)SdkMemory.ReadBits(Pointer,1,1); set { SdkMemory.WriteBits(Pointer,1,1,unchecked((ulong)value)); } }
    [NativeMember("bCreateLinkedPair")]
    public ushort @CreateLinkedPair { get => (ushort)SdkMemory.ReadBits(Pointer,2,1); set { SdkMemory.WriteBits(Pointer,2,1,unchecked((ulong)value)); } }
    [NativeMember("bRewardInterior")]
    public ushort @RewardInterior { get => (ushort)SdkMemory.ReadBits(Pointer,3,1); set { SdkMemory.WriteBits(Pointer,3,1,unchecked((ulong)value)); } }
    [NativeMember("bUsedRewardEntrance")]
    public ushort @UsedRewardEntrance { get => (ushort)SdkMemory.ReadBits(Pointer,4,1); set { SdkMemory.WriteBits(Pointer,4,1,unchecked((ulong)value)); } }
    [NativeMember("bCarsAndAircraft")]
    public ushort @CarsAndAircraft { get => (ushort)SdkMemory.ReadBits(Pointer,5,1); set { SdkMemory.WriteBits(Pointer,5,1,unchecked((ulong)value)); } }
    [NativeMember("bBikesAndMotorcycles")]
    public ushort @BikesAndMotorcycles { get => (ushort)SdkMemory.ReadBits(Pointer,6,1); set { SdkMemory.WriteBits(Pointer,6,1,unchecked((ulong)value)); } }
    [NativeMember("bDisableOnFoot")]
    public ushort @DisableOnFoot { get => (ushort)SdkMemory.ReadBits(Pointer,7,1); set { SdkMemory.WriteBits(Pointer,7,1,unchecked((ulong)value)); } }
    [NativeMember("bAcceptNpcGroup")]
    public ushort @AcceptNpcGroup { get => (ushort)SdkMemory.ReadBits(Pointer,8,1); set { SdkMemory.WriteBits(Pointer,8,1,unchecked((ulong)value)); } }
    [NativeMember("bFoodDateFlag")]
    public ushort @FoodDateFlag { get => (ushort)SdkMemory.ReadBits(Pointer,9,1); set { SdkMemory.WriteBits(Pointer,9,1,unchecked((ulong)value)); } }
    [NativeMember("bUnknownBurglary")]
    public ushort @UnknownBurglary { get => (ushort)SdkMemory.ReadBits(Pointer,10,1); set { SdkMemory.WriteBits(Pointer,10,1,unchecked((ulong)value)); } }
    [NativeMember("bDisableExit")]
    public ushort @DisableExit { get => (ushort)SdkMemory.ReadBits(Pointer,11,1); set { SdkMemory.WriteBits(Pointer,11,1,unchecked((ulong)value)); } }
    [NativeMember("bBurglaryAccess")]
    public ushort @BurglaryAccess { get => (ushort)SdkMemory.ReadBits(Pointer,12,1); set { SdkMemory.WriteBits(Pointer,12,1,unchecked((ulong)value)); } }
    [NativeMember("bEnteredWithoutExit")]
    public ushort @EnteredWithoutExit { get => (ushort)SdkMemory.ReadBits(Pointer,13,1); set { SdkMemory.WriteBits(Pointer,13,1,unchecked((ulong)value)); } }
    [NativeMember("bEnableAccess")]
    public ushort @EnableAccess { get => (ushort)SdkMemory.ReadBits(Pointer,14,1); set { SdkMemory.WriteBits(Pointer,14,1,unchecked((ulong)value)); } }
    [NativeMember("bDeleteEnex")]
    public ushort @DeleteEnex { get => (ushort)SdkMemory.ReadBits(Pointer,15,1); set { SdkMemory.WriteBits(Pointer,15,1,unchecked((ulong)value)); } }
}
