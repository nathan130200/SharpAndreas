// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CAutomobile___unnamed__at_D__plugin_sdk_plugin_sa_game_sa_CAutomobile__75858922c0 : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=1;
    public CAutomobile___unnamed__at_D__plugin_sdk_plugin_sa_game_sa_CAutomobile__75858922c0(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("bTaxiLight")]
    public bool @TaxiLight { get => SdkMemory.ReadBits(Pointer,0,1) != 0; set { SdkMemory.WriteBits(Pointer,0,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bShouldNotChangeColour")]
    public bool @ShouldNotChangeColor { get => SdkMemory.ReadBits(Pointer,1,1) != 0; set { SdkMemory.WriteBits(Pointer,1,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bWaterTight")]
    public bool @WaterTight { get => SdkMemory.ReadBits(Pointer,2,1) != 0; set { SdkMemory.WriteBits(Pointer,2,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bDoesNotGetDamagedUpsideDown")]
    public bool @DoesNotGetDamagedUpsideDown { get => SdkMemory.ReadBits(Pointer,3,1) != 0; set { SdkMemory.WriteBits(Pointer,3,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bCanBeVisiblyDamaged")]
    public bool @CanBeVisiblyDamaged { get => SdkMemory.ReadBits(Pointer,4,1) != 0; set { SdkMemory.WriteBits(Pointer,4,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bTankExplodesCars")]
    public bool @TankExplodesCars { get => SdkMemory.ReadBits(Pointer,5,1) != 0; set { SdkMemory.WriteBits(Pointer,5,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bIsBoggedDownInSand")]
    public bool @IsBoggedDownInSand { get => SdkMemory.ReadBits(Pointer,6,1) != 0; set { SdkMemory.WriteBits(Pointer,6,1,(value ? 1UL : 0UL)); } }
    [NativeMember("bIsMonsterTruck")]
    public bool @IsMonsterTruck { get => SdkMemory.ReadBits(Pointer,7,1) != 0; set { SdkMemory.WriteBits(Pointer,7,1,(value ? 1UL : 0UL)); } }
}
