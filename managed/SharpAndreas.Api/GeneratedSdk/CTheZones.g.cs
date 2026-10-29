// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CTheZones : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=1;
    public CTheZones(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_CurrLevel")]
    public static eLevelName @CurrLevel { get => SdkMemory.Read<eLevelName >(SdkBindings.Address(4657)); set { SdkMemory.Write(SdkBindings.Address(4657),value); } }
    [NativeMember("ExploredTerritoriesArray")]
    public static NativePointer<sbyte> @ExploredTerritoriesArray { get => new NativePointer<sbyte>(SdkMemory.Read<IntPtr>(SdkBindings.Address(4658))); }
    [NativeMember("TotalNumberExploredTerritories")]
    public static int @TotalNumberExploredTerritories { get => SdkMemory.Read<int >(SdkBindings.Address(4659)); set { SdkMemory.Write(SdkBindings.Address(4659),value); } }
    [NativeMember("TotalNumberOfInfoZones")]
    public static short @TotalNumberOfInfoZones { get => SdkMemory.Read<short >(SdkBindings.Address(4660)); set { SdkMemory.Write(SdkBindings.Address(4660),value); } }
    [NativeMember("ZoneInfoArray")]
    public static CZone? @ZoneInfoArray { get => SdkMemory.Read<IntPtr>(SdkBindings.Address(4661)) == IntPtr.Zero ? null : new CZone(SdkMemory.Read<IntPtr>(SdkBindings.Address(4661))); }
    [NativeMember("TotalNumberOfMapZones")]
    public static short @TotalNumberOfMapZones { get => SdkMemory.Read<short >(SdkBindings.Address(4662)); set { SdkMemory.Write(SdkBindings.Address(4662),value); } }
    [NativeMember("MapZoneArray")]
    public static CZone? @MapZoneArray { get => SdkMemory.Read<IntPtr>(SdkBindings.Address(4663)) == IntPtr.Zero ? null : new CZone(SdkMemory.Read<IntPtr>(SdkBindings.Address(4663))); }
    public static void @InitZonesPopulationSettings() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4161 >(4161)(); }
    public static void @ResetZonesRevealed() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4162 >(4162)(); }
    public static void @AssignZoneInfoForThisZone(short @index) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4163 >(4163)(@index); }
    public static bool @ZoneIsEntirelyContainedWithinOtherZone(CZone? @pZone1,CZone? @pZone2) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4164 >(4164)(@pZone1?.Pointer ?? IntPtr.Zero,@pZone2?.Pointer ?? IntPtr.Zero); return __sdkResult != 0; }
    public static bool @GetCurrentZoneLockedOrUnlocked(float @posx,float @posy) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4165 >(4165)(@posx,@posy); return __sdkResult != 0; }
    public static bool @PointLiesWithinZone(CVector? @pPoint,CZone? @pZone) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4166 >(4166)(@pPoint?.Pointer ?? IntPtr.Zero,@pZone?.Pointer ?? IntPtr.Zero); return __sdkResult != 0; }
    public static eLevelName @GetLevelFromPosition(CVector? @pPoint) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4167 >(4167)(@pPoint?.Pointer ?? IntPtr.Zero); return (eLevelName)__sdkResult; }
    public static CZone? @FindSmallestZoneForPosition(CVector @point,bool @FindOnlyZonesType0) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4168 >(4168)(@point.Pointer,(@FindOnlyZonesType0 ? 1 : 0)); return __sdkResult == IntPtr.Zero ? null : new CZone(__sdkResult); }
    public static CZoneInfo? @GetZoneInfo(CVector? @point,NativePointer<IntPtr> @outzone) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4169 >(4169)(@point?.Pointer ?? IntPtr.Zero,@outzone.Pointer); return __sdkResult == IntPtr.Zero ? null : new CZoneInfo(__sdkResult); }
    public static void @FillZonesWithGangColours(bool @DisableRadarGangColors) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4170 >(4170)((@DisableRadarGangColors ? 1 : 0)); }
    public static CZone? @GetInfoZone(short @index) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4171 >(4171)(@index); return __sdkResult == IntPtr.Zero ? null : new CZone(__sdkResult); }
    public static CZone? @GetMapZone(short @index) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4172 >(4172)(@index); return __sdkResult == IntPtr.Zero ? null : new CZone(__sdkResult); }
    public static double @Calc2DDistanceBetween2Zones(CZone? @Zone1,CZone? @Zone2) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4173 >(4173)(@Zone1?.Pointer ?? IntPtr.Zero,@Zone2?.Pointer ?? IntPtr.Zero); return __sdkResult; }
    public static void @Init() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4174 >(4174)(); }
    public static void @SetCurrentZoneAsUnlocked() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4175 >(4175)(); }
    public static void @CreateZone(NativePointer<sbyte> @name,eZoneType @type,float @posX1,float @posY1,float @posZ1,float @posX2,float @posY2,float @posZ2,eLevelName @island,NativePointer<sbyte> @GXT_key) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4176 >(4176)(@name.Pointer,(int)@type,@posX1,@posY1,@posZ1,@posX2,@posY2,@posZ2,(int)@island,@GXT_key.Pointer); }
    public static bool @FindZone(CVector? @point,int @zonename_part1,int @zonename_part2,eZoneType @type) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4177 >(4177)(@point?.Pointer ?? IntPtr.Zero,@zonename_part1,@zonename_part2,(int)@type); return __sdkResult != 0; }
    public static short @FindZoneByLabel(NativePointer<sbyte> @name,eZoneType @type) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4178 >(4178)(@name.Pointer,(int)@type); return __sdkResult; }
    public static void @SetZoneRadarColours(short @index,sbyte @flag,byte @red,byte @green,byte @blue) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4179 >(4179)(@index,@flag,@red,@green,@blue); }
    public static void @Update() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4180 >(4180)(); }
    public static void @Save() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4181 >(4181)(); }
    public static void @Load() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4182 >(4182)(); }
}
