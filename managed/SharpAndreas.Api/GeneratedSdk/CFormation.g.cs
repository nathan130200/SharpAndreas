// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CFormation : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=1;
    public CFormation(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_aFinalPedLinkToDestinations")]
    public static NativeArray<int> @FinalPedLinkToDestinations { get => new NativeArray<int>(new IntPtr(0xC1A2C0),8); }
    [NativeMember("m_aPedLinkToDestinations")]
    public static NativeArray<int> @PedLinkToDestinations { get => new NativeArray<int>(new IntPtr(0xC1A2E0),8); }
    [NativeMember("m_Destinations")]
    public static CPointList @Destinations { get => new CPointList(new IntPtr(0xC1A318)); set { SdkMemory.Copy(value.Pointer,new IntPtr(0xC1A318),316); } }
    [NativeMember("m_DestinationPeds")]
    public static CPedList @DestinationPeds { get => new CPedList(new IntPtr(0xC1A458)); set { SdkMemory.Copy(value.Pointer,new IntPtr(0xC1A458),124); } }
    [NativeMember("m_Peds")]
    public static CPedList @Peds { get => new CPedList(new IntPtr(0xC1A4D8)); set { SdkMemory.Copy(value.Pointer,new IntPtr(0xC1A4D8),124); } }
    public static void @DistributeDestinations(CPedList? @pedlist) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2728 >(2728)(@pedlist?.Pointer ?? IntPtr.Zero); }
    public static void @DistributeDestinations_CoverPoints(CPedList? @pedlist,CVector @pos) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2729 >(2729)(@pedlist?.Pointer ?? IntPtr.Zero,@pos.Pointer); }
    public static void @DistributeDestinations_PedsToAttack(CPedList? @pedlist) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2730 >(2730)(@pedlist?.Pointer ?? IntPtr.Zero); }
    public static void @FindCoverPoints(CVector @pos,float @radius) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2731 >(2731)(@pos.Pointer,@radius); }
    public static void @FindCoverPointsBehindBox(CPointList? @pointlist,CVector @Pos,CMatrix? @coverEntityMatrix,CVector? @vecCenter,CVector? @vecMin,CVector? @vecMax,float @radius) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2732 >(2732)(@pointlist?.Pointer ?? IntPtr.Zero,@Pos.Pointer,@coverEntityMatrix?.Pointer ?? IntPtr.Zero,@vecCenter?.Pointer ?? IntPtr.Zero,@vecMin?.Pointer ?? IntPtr.Zero,@vecMax?.Pointer ?? IntPtr.Zero,@radius); }
    public static int @FindNearestAvailableDestination(CVector @pos,NativePointer<float> @pOutDistance) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2733 >(2733)(@pos.Pointer,@pOutDistance.Pointer); return __sdkResult; }
    public static void @GenerateGatherDestinations(CPedList? @pedList,CPed? @ped) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2734 >(2734)(@pedList?.Pointer ?? IntPtr.Zero,@ped?.Pointer ?? IntPtr.Zero); }
    public static void @GenerateGatherDestinations_AroundCar(CPedList? @pedlist,CVehicle? @vehicle) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2735 >(2735)(@pedlist?.Pointer ?? IntPtr.Zero,@vehicle?.Pointer ?? IntPtr.Zero); }
    public static bool @ReturnDestinationForPed(CPed? @ped,CVector? @pos) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2736 >(2736)(@ped?.Pointer ?? IntPtr.Zero,@pos?.Pointer ?? IntPtr.Zero); return __sdkResult != 0; }
    public static int @ReturnTargetPedForPed(CPed? @ped,NativePointer<IntPtr> @pOutTargetPed) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2737 >(2737)(@ped?.Pointer ?? IntPtr.Zero,@pOutTargetPed.Pointer); return __sdkResult; }
}
