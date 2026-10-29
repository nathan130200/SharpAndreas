// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CCover : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=1;
    public CCover(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_NumPoints")]
    public static uint @CountPoints { get => SdkMemory.Read<uint >(new IntPtr(0xC197A4)); set { SdkMemory.Write(new IntPtr(0xC197A4),value); } }
    [NativeMember("m_aPoints")]
    public static NativeObjectArray<CCoverPoint> @Points { get => new NativeObjectArray<CCoverPoint>(new IntPtr(0xC197C8),100,28); }
    [NativeMember("m_ListOfProcessedBuildings")]
    public static CPtrListDoubleLink @ListOfProcessedBuildings { get => new CPtrListDoubleLink(new IntPtr(0xC1A2B8)); set { SdkMemory.Copy(value.Pointer,new IntPtr(0xC1A2B8),4); } }
    public static void @AddCoverPoint(int @maxPeds,CEntity? @coverEntity,CVector? @position,sbyte @coverType,byte @direction) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2298 >(2298)(@maxPeds,@coverEntity?.Pointer ?? IntPtr.Zero,@position?.Pointer ?? IntPtr.Zero,@coverType,@direction); }
    public static float @CalculateHorizontalSize(CColTriangle? @triangle,CVector? @vertPositions) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2299 >(2299)(@triangle?.Pointer ?? IntPtr.Zero,@vertPositions?.Pointer ?? IntPtr.Zero); return __sdkResult; }
    public static sbyte @DoLineCheckWithinObject(CColTriangle? @triangle,int @a2,CVector? @a3,CVector? @a4,CVector @a5,CVector @a6) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2300 >(2300)(@triangle?.Pointer ?? IntPtr.Zero,@a2,@a3?.Pointer ?? IntPtr.Zero,@a4?.Pointer ?? IntPtr.Zero,@a5.Pointer,@a6.Pointer); return __sdkResult; }
    public static bool @DoesCoverPointStillProvideCover(CCoverPoint? @point,CVector @position) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2301 >(2301)(@point?.Pointer ?? IntPtr.Zero,@position.Pointer); return __sdkResult != 0; }
    public static void @Find2HighestPoints(CColTriangle? @triangle,CVector? @vertPositions,NativePointer<int> @outPoint1,NativePointer<int> @outPoint2) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2302 >(2302)(@triangle?.Pointer ?? IntPtr.Zero,@vertPositions?.Pointer ?? IntPtr.Zero,@outPoint1.Pointer,@outPoint2.Pointer); }
    public static CCoverPoint? @FindAndReserveCoverPoint(CPed? @ped,CVector @position,bool @a3) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2303 >(2303)(@ped?.Pointer ?? IntPtr.Zero,@position.Pointer,(@a3 ? 1 : 0)); return __sdkResult == IntPtr.Zero ? null : new CCoverPoint(__sdkResult); }
    public static bool @FindCoordinatesCoverPoint(CCoverPoint? @point,CPed? @ped,CVector @position,CVector @outCoordinates) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2304 >(2304)(@point?.Pointer ?? IntPtr.Zero,@ped?.Pointer ?? IntPtr.Zero,@position.Pointer,@outCoordinates.Pointer); return __sdkResult != 0; }
    public static void @FindCoverPointsForThisBuilding(CBuilding? @building) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2305 >(2305)(@building?.Pointer ?? IntPtr.Zero); }
    public static byte @FindDirFromVector(float @x,float @y) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2306 >(2306)(@x,@y); return __sdkResult; }
    public static CVector @FindVectorFromDir(byte @direction) { Game.CheckThread(); var result=NativeObject.AllocateStorage<CVector >(12); try { SdkBindings.Get<GeneratedDelegates.D2307 >(2307)(@direction,result.Pointer); return result; } catch { result.Dispose(); throw; } }
    public static CVector @FindVectorFromFirstToMissingVertex(CColTriangle? @triangle,NativePointer<int> @a3,CVector? @vertPositions) { Game.CheckThread(); var result=NativeObject.AllocateStorage<CVector >(12); try { SdkBindings.Get<GeneratedDelegates.D2308 >(2308)(@triangle?.Pointer ?? IntPtr.Zero,@a3.Pointer,@vertPositions?.Pointer ?? IntPtr.Zero,result.Pointer); return result; } catch { result.Dispose(); throw; } }
    public static void @Init() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2309 >(2309)(); }
    public static void @RemoveCoverPointIfEntityLost(CCoverPoint? @point) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2310 >(2310)(@point?.Pointer ?? IntPtr.Zero); }
    public static void @RemoveCoverPointsForThisEntity(CEntity? @entity) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2311 >(2311)(@entity?.Pointer ?? IntPtr.Zero); }
    public static bool @ShouldThisBuildingHaveItsCoverPointsCreated(CBuilding? @building) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2312 >(2312)(@building?.Pointer ?? IntPtr.Zero); return __sdkResult != 0; }
    public static void @Update() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2313 >(2313)(); }
}
