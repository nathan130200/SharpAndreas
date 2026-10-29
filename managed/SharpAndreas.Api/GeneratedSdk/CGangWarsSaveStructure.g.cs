// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CGangWarsSaveStructure : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=88;
    public CGangWarsSaveStructure(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("bGangWarsActive")]
    public bool @GangWarsActive { get => SdkMemory.Read<bool >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("State")]
    public uint @State { get => SdkMemory.Read<uint >(Pointer+4); set { SdkMemory.Write(Pointer+4,value); } }
    [NativeMember("TimeStarted")]
    public uint @TimeStarted { get => SdkMemory.Read<uint >(Pointer+8); set { SdkMemory.Write(Pointer+8,value); } }
    [NativeMember("GangWarZoneInfoIndex")]
    public uint @GangWarZoneInfoIndex { get => SdkMemory.Read<uint >(Pointer+12); set { SdkMemory.Write(Pointer+12,value); } }
    [NativeMember("GangWarNavigationZoneIndex")]
    public uint @GangWarNavigationZoneIndex { get => SdkMemory.Read<uint >(Pointer+16); set { SdkMemory.Write(Pointer+16,value); } }
    [NativeMember("CoorsOfPlayerAtStartOfWar")]
    public CVector @CoorsOfPlayerAtStartOfWar { get => new CVector(Pointer+20); set { SdkMemory.Copy(value.Pointer,Pointer+20,12); } }
    [NativeMember("Gang1")]
    public uint @Gang1 { get => SdkMemory.Read<uint >(Pointer+32); set { SdkMemory.Write(Pointer+32,value); } }
    [NativeMember("Gang2")]
    public uint @Gang2 { get => SdkMemory.Read<uint >(Pointer+36); set { SdkMemory.Write(Pointer+36,value); } }
    [NativeMember("WarFerocity")]
    public uint @WarFerocity { get => SdkMemory.Read<uint >(Pointer+40); set { SdkMemory.Write(Pointer+40,value); } }
    [NativeMember("LastTimeInArea")]
    public uint @LastTimeInArea { get => SdkMemory.Read<uint >(Pointer+44); set { SdkMemory.Write(Pointer+44,value); } }
    [NativeMember("State2")]
    public uint @State2 { get => SdkMemory.Read<uint >(Pointer+48); set { SdkMemory.Write(Pointer+48,value); } }
    [NativeMember("TimeTillNextAttack")]
    public float @TimeTillNextAttack { get => SdkMemory.Read<float >(Pointer+52); set { SdkMemory.Write(Pointer+52,value); } }
    [NativeMember("PointOfAttack")]
    public CVector @PointOfAttack { get => new CVector(Pointer+56); set { SdkMemory.Copy(value.Pointer,Pointer+56,12); } }
    [NativeMember("FightTimer")]
    public uint @FightTimer { get => SdkMemory.Read<uint >(Pointer+68); set { SdkMemory.Write(Pointer+68,value); } }
    [NativeMember("RadarBlip")]
    public uint @RadarBlip { get => SdkMemory.Read<uint >(Pointer+72); set { SdkMemory.Write(Pointer+72,value); } }
    [NativeMember("bPlayerIsCloseby")]
    public bool @PlayerIsCloseby { get => SdkMemory.Read<bool >(Pointer+76); set { SdkMemory.Write(Pointer+76,value); } }
    [NativeMember("TerritoryUnderControlPercentage")]
    public float @TerritoryUnderControlPercentage { get => SdkMemory.Read<float >(Pointer+80); set { SdkMemory.Write(Pointer+80,value); } }
    [NativeMember("Difficulty")]
    public float @Difficulty { get => SdkMemory.Read<float >(Pointer+84); set { SdkMemory.Write(Pointer+84,value); } }
    public void @Construct() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2888 >(2888)(Pointer); }
    public void @Extract() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2889 >(2889)(Pointer); }
}
