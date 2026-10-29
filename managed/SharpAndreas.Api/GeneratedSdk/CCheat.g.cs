// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CCheat : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=1;
    public CCheat(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_aCheatFunctions")]
    public static NativeArray<IntPtr> @CheatFunctions { get => new NativeArray<IntPtr>(new IntPtr(0x8A5B58),92); }
    [NativeMember("m_aCheatHashKeys")]
    public static NativeArray<int> @CheatHashKeys { get => new NativeArray<int>(new IntPtr(0x8A5CC8),92); }
    [NativeMember("m_CheatString")]
    public static NativeArray<sbyte> @CheatString { get => new NativeArray<sbyte>(new IntPtr(0x969110),30); }
    [NativeMember("m_aCheatsActive")]
    public static NativeArray<bool> @CheatsActive { get => new NativeArray<bool>(new IntPtr(0x969130),92); }
    [NativeMember("m_bHasPlayerCheated")]
    public static bool @HasPlayerCheated { get => SdkMemory.Read<bool >(new IntPtr(0x96918C)); set { SdkMemory.Write(new IntPtr(0x96918C),value); } }
    public static void @AddToCheatString(sbyte @LastPressedKey) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1902 >(1902)(@LastPressedKey); }
    public static void @AdrenalineCheat() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1903 >(1903)(); }
    public static void @AllCarsAreGreatCheat() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1904 >(1904)(); }
    public static void @AllCarsAreShitCheat() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1905 >(1905)(); }
    public static void @ApacheCheat() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1906 >(1906)(); }
    public static void @BeachPartyCheat() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1907 >(1907)(); }
    public static void @BlackCarsCheat() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1908 >(1908)(); }
    public static void @BlowUpCarsCheat() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1909 >(1909)(); }
    public static void @CloudyWeatherCheat() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1910 >(1910)(); }
    public static void @CountrysideInvasionCheat() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1911 >(1911)(); }
    public static void @DozerCheat() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1912 >(1912)(); }
    public static void @DrivebyCheat() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1913 >(1913)(); }
    public static void @DuskCheat() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1914 >(1914)(); }
    public static void @ElvisLivesCheat() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1915 >(1915)(); }
    public static void @EverybodyAttacksPlayerCheat() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1916 >(1916)(); }
    public static void @ExtraSunnyWeatherCheat() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1917 >(1917)(); }
    public static void @FastTimeCheat() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1918 >(1918)(); }
    public static void @FatCheat() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1919 >(1919)(); }
    public static void @FlyboyCheat() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1920 >(1920)(); }
    public static void @FoggyWeatherCheat() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1921 >(1921)(); }
    public static void @FunhouseCheat() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1922 >(1922)(); }
    public static void @GangLandCheat() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1923 >(1923)(); }
    public static void @GangsCheat() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1924 >(1924)(); }
    public static void @GolfcartCheat() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1925 >(1925)(); }
    public static void @HandleSpecialCheats(int @CheatID) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1926 >(1926)(@CheatID); }
    public static void @HealthCheat() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1927 >(1927)(); }
    public static void @HearseCheat() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1928 >(1928)(); }
    public static void @JetpackCheat() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1929 >(1929)(); }
    public static void @LoveConquersAllCheat() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1930 >(1930)(); }
    public static void @LovefistCheat() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1931 >(1931)(); }
    public static void @MayhemCheat() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1932 >(1932)(); }
    public static void @MidnightCheat() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1933 >(1933)(); }
    public static void @MoneyArmourHealthCheat() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1934 >(1934)(); }
    public static void @MonsterTruckCheat() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1935 >(1935)(); }
    public static void @MuscleCheat() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1936 >(1936)(); }
    public static void @NinjaCheat() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1937 >(1937)(); }
    public static void @NotWantedCheat() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1938 >(1938)(); }
    public static void @ParachuteCheat() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1939 >(1939)(); }
    public static void @PinkCarsCheat() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1940 >(1940)(); }
    public static void @PredatorCheat() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1941 >(1941)(); }
    public static void @QuadCheat() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1942 >(1942)(); }
    public static void @RainyWeatherCheat() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1943 >(1943)(); }
    public static void @RiotCheat() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1944 >(1944)(); }
    public static void @SandstormCheat() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1945 >(1945)(); }
    public static void @SkinnyCheat() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1946 >(1946)(); }
    public static void @SlowTimeCheat() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1947 >(1947)(); }
    public static void @StaminaCheat() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1948 >(1948)(); }
    public static void @StockCar2Cheat() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1949 >(1949)(); }
    public static void @StockCar3Cheat() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1950 >(1950)(); }
    public static void @StockCar4Cheat() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1951 >(1951)(); }
    public static void @StockCarCheat() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1952 >(1952)(); }
    public static void @StormCheat() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1953 >(1953)(); }
    public static void @StuntPlaneCheat() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1954 >(1954)(); }
    public static void @SuicideCheat() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1955 >(1955)(); }
    public static void @SunnyWeatherCheat() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1956 >(1956)(); }
    public static void @TankCheat() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1957 >(1957)(); }
    public static void @TankerCheat() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1958 >(1958)(); }
    public static void @TrashmasterCheat() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1959 >(1959)(); }
    public static CVehicle? @VehicleCheat(int @vehicleModelId) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1960 >(1960)(@vehicleModelId); return __sdkResult == IntPtr.Zero ? null : new CVehicle(__sdkResult); }
    public static void @VehicleSkillsCheat() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1961 >(1961)(); }
    public static void @VillagePeopleCheat() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1962 >(1962)(); }
    public static void @VortexCheat() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1963 >(1963)(); }
    public static void @WantedCheat() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1964 >(1964)(); }
    public static void @WantedLevelDownCheat() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1965 >(1965)(); }
    public static void @WantedLevelUpCheat() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1966 >(1966)(); }
    public static void @WeaponCheat1() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1967 >(1967)(); }
    public static void @WeaponCheat2() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1968 >(1968)(); }
    public static void @WeaponCheat3() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1969 >(1969)(); }
    public static void @WeaponSkillsCheat() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1970 >(1970)(); }
    public static void @ResetCheats() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1971 >(1971)(); }
}
