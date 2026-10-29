// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CPedGroupPlacer : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=1;
    public CPedGroupPlacer(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("ms_minGangSize")]
    public static int @MinGangSize { get => SdkMemory.Read<int >(new IntPtr(0x86C6C4)); }
    [NativeMember("ms_maxGangSize")]
    public static int @MaxGangSize { get => SdkMemory.Read<int >(new IntPtr(0x86C6C8)); }
    public bool @PlaceChatGroup(ePedType @pedtype,int @numOfPeds,CVector? @origin,int @unused) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3292 >(3292)(Pointer,(int)@pedtype,@numOfPeds,@origin?.Pointer ?? IntPtr.Zero,@unused); return __sdkResult != 0; }
    public bool @PlaceFormationGroup(ePedType @pedtype,int @numOfPeds,CVector? @origin,int @unused) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3293 >(3293)(Pointer,(int)@pedtype,@numOfPeds,@origin?.Pointer ?? IntPtr.Zero,@unused); return __sdkResult != 0; }
    public bool @PlaceGroup(ePedType @pedtype,int @numOfPeds,CVector? @origin,int @nGroupPlacerType) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3294 >(3294)(Pointer,(int)@pedtype,@numOfPeds,@origin?.Pointer ?? IntPtr.Zero,@nGroupPlacerType); return __sdkResult != 0; }
    public bool @PlaceRandomGroup(ePedType @pedtype,int @numOfPeds,CVector? @origin,int @unused) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3295 >(3295)(Pointer,(int)@pedtype,@numOfPeds,@origin?.Pointer ?? IntPtr.Zero,@unused); return __sdkResult != 0; }
}
