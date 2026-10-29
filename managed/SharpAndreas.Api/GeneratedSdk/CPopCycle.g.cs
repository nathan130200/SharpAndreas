// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CPopCycle : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=1;
    public CPopCycle(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_NumOther_Cars")]
    public static float @CountOtherCars { get => SdkMemory.Read<float >(new IntPtr(0xC0BC30)); set { SdkMemory.Write(new IntPtr(0xC0BC30),value); } }
    [NativeMember("m_NumCops_Cars")]
    public static float @CountCopsCars { get => SdkMemory.Read<float >(new IntPtr(0xC0BC34)); set { SdkMemory.Write(new IntPtr(0xC0BC34),value); } }
    [NativeMember("m_NumGangs_Cars")]
    public static float @CountGangsCars { get => SdkMemory.Read<float >(new IntPtr(0xC0BC38)); set { SdkMemory.Write(new IntPtr(0xC0BC38),value); } }
    [NativeMember("m_NumDealers_Cars")]
    public static float @CountDealersCars { get => SdkMemory.Read<float >(new IntPtr(0xC0BC3C)); set { SdkMemory.Write(new IntPtr(0xC0BC3C),value); } }
    [NativeMember("m_NumOther_Peds")]
    public static float @CountOtherPeds { get => SdkMemory.Read<float >(new IntPtr(0xC0BC40)); set { SdkMemory.Write(new IntPtr(0xC0BC40),value); } }
    [NativeMember("m_NumCops_Peds")]
    public static float @CountCopsPeds { get => SdkMemory.Read<float >(new IntPtr(0xC0BC44)); set { SdkMemory.Write(new IntPtr(0xC0BC44),value); } }
    [NativeMember("m_NumGangs_Peds")]
    public static float @CountGangsPeds { get => SdkMemory.Read<float >(new IntPtr(0xC0BC48)); set { SdkMemory.Write(new IntPtr(0xC0BC48),value); } }
    [NativeMember("m_fPercOther")]
    public static float @PercOther { get => SdkMemory.Read<float >(new IntPtr(0xC0BC4C)); set { SdkMemory.Write(new IntPtr(0xC0BC4C),value); } }
    [NativeMember("m_fPercCops")]
    public static float @PercCops { get => SdkMemory.Read<float >(new IntPtr(0xC0BC50)); set { SdkMemory.Write(new IntPtr(0xC0BC50),value); } }
    [NativeMember("m_fPercGangs")]
    public static float @PercGangs { get => SdkMemory.Read<float >(new IntPtr(0xC0BC54)); set { SdkMemory.Write(new IntPtr(0xC0BC54),value); } }
    [NativeMember("m_fPercDealers")]
    public static float @PercDealers { get => SdkMemory.Read<float >(new IntPtr(0xC0BC58)); set { SdkMemory.Write(new IntPtr(0xC0BC58),value); } }
    [NativeMember("m_bCurrentZoneIsGangArea")]
    public static bool @CurrentZoneIsGangArea { get => SdkMemory.Read<bool >(new IntPtr(0xC0BC5C)); set { SdkMemory.Write(new IntPtr(0xC0BC5C),value); } }
    [NativeMember("m_fCurrentZoneDodgyness")]
    public static float @CurrentZoneDodgyness { get => SdkMemory.Read<float >(new IntPtr(0xC0BC60)); set { SdkMemory.Write(new IntPtr(0xC0BC60),value); } }
    [NativeMember("m_pCurrZone")]
    public static CZone? @CurrZone { get => new IntPtr(0xC0BC64) == IntPtr.Zero ? null : new CZone(new IntPtr(0xC0BC64)); }
    [NativeMember("m_pCurrZoneInfo")]
    public static CZoneInfo? @CurrZoneInfo { get => new IntPtr(0xC0BC68) == IntPtr.Zero ? null : new CZoneInfo(new IntPtr(0xC0BC68)); }
    [NativeMember("m_nCurrentZoneType")]
    public static int @CurrentZoneType { get => SdkMemory.Read<int >(new IntPtr(0xC0BC6C)); set { SdkMemory.Write(new IntPtr(0xC0BC6C),value); } }
    [NativeMember("m_nCurrentTimeOfWeek")]
    public static int @CurrentTimeOfWeek { get => SdkMemory.Read<int >(new IntPtr(0xC0BC70)); set { SdkMemory.Write(new IntPtr(0xC0BC70),value); } }
    [NativeMember("m_nCurrentTimeIndex")]
    public static int @CurrentTimeIndex { get => SdkMemory.Read<int >(new IntPtr(0xC0BC74)); set { SdkMemory.Write(new IntPtr(0xC0BC74),value); } }
    [NativeMember("m_nPercTypeGroup")]
    public static NativePointer<sbyte> @PercTypeGroup { get => new NativePointer<sbyte>(new IntPtr(0xC0BC78)); }
    [NativeMember("m_nPercOther")]
    public static NativePointer<byte> @PercOtherValue { get => new NativePointer<byte>(new IntPtr(0xC0DE38)); }
    [NativeMember("m_nPercCops")]
    public static NativePointer<byte> @PercCopsValue { get => new NativePointer<byte>(new IntPtr(0xC0E018)); }
    [NativeMember("m_nPercGang")]
    public static NativePointer<byte> @PercGang { get => new NativePointer<byte>(new IntPtr(0xC0E1F8)); }
    [NativeMember("m_nPercDealers")]
    public static NativePointer<byte> @PercDealersValue { get => new NativePointer<byte>(new IntPtr(0xC0E3D8)); }
    [NativeMember("m_nMaxNumCars")]
    public static NativePointer<byte> @MaxCountCars { get => new NativePointer<byte>(new IntPtr(0xC0E5B8)); }
    [NativeMember("m_nMaxNumPeds")]
    public static NativePointer<byte> @MaxCountPeds { get => new NativePointer<byte>(new IntPtr(0xC0E798)); }
    [NativeMember("m_NumDealers_Peds")]
    public static float @CountDealersPeds { get => SdkMemory.Read<float >(new IntPtr(0xC0E978)); set { SdkMemory.Write(new IntPtr(0xC0E978),value); } }
    public static bool @FindNewPedType(NativePointer<ePedType> @arg1,NativePointer<int> @modelindex,bool @arg3,bool @arg4) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3419 >(3419)(@arg1.Pointer,@modelindex.Pointer,(@arg3 ? 1 : 0),(@arg4 ? 1 : 0)); return __sdkResult != 0; }
    public static float @GetCurrentPercOther_Peds() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3420 >(3420)(); return __sdkResult; }
    public static void @Initialise() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3421 >(3421)(); }
    public static bool @IsPedAppropriateForCurrentZone(int @modelindex) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3422 >(3422)(@modelindex); return __sdkResult != 0; }
    public static bool @IsPedInGroup(int @modelIndex,int @PopCycle_Group) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3423 >(3423)(@modelIndex,@PopCycle_Group); return __sdkResult != 0; }
    public static bool @PedIsAcceptableInCurrentZone(int @modelIndex) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3424 >(3424)(@modelIndex); return __sdkResult != 0; }
    public static int @PickARandomGroupOfOtherPeds() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3425 >(3425)(); return __sdkResult; }
    public static void @PlayerKilledADealer() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3426 >(3426)(); }
    public static void @Update() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3427 >(3427)(); }
    public static void @UpdateAreaDodgyness() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3428 >(3428)(); }
    public static void @UpdateDealerStrengths() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3429 >(3429)(); }
    public static void @UpdatePercentages() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3430 >(3430)(); }
}
