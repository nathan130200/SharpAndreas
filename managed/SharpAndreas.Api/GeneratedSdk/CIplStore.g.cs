// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CIplStore : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=1;
    public CIplStore(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("ms_pQuadTree")]
    public static CQuadTreeNode? @QuadTree { get => SdkMemory.Read<IntPtr>(new IntPtr(0x8E3FAC)) == IntPtr.Zero ? null : new CQuadTreeNode(SdkMemory.Read<IntPtr>(new IntPtr(0x8E3FAC))); set { SdkMemory.Write(new IntPtr(0x8E3FAC),value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("ms_pPool")]
    public static CPool_IplDef__5df555a306? @Pool { get => SdkMemory.Read<IntPtr>(new IntPtr(0x8E3FB0)) == IntPtr.Zero ? null : new CPool_IplDef__5df555a306(SdkMemory.Read<IntPtr>(new IntPtr(0x8E3FB0))); set { SdkMemory.Write(new IntPtr(0x8E3FB0),value?.Pointer ?? IntPtr.Zero); } }
    public static int @AddIplSlot(NativePointer<sbyte> @name) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2987 >(2987)(@name.Pointer); return __sdkResult; }
    public static void @AddIplsNeededAtPosn(CVector @posn) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2988 >(2988)(@posn.Pointer); }
    public static void @ClearIplsNeededAtPosn() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2989 >(2989)(); }
    public static void @EnableDynamicStreaming(int @iplSlotIndex,bool @enable) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2990 >(2990)(@iplSlotIndex,(@enable ? 1 : 0)); }
    public static void @EnsureIplsAreInMemory(CVector @posn) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2991 >(2991)(@posn.Pointer); }
    public static int @FindIplSlot(NativePointer<sbyte> @name) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2992 >(2992)(@name.Pointer); return __sdkResult; }
    public static CRect? @GetBoundingBox(int @iplSlotIndex) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2993 >(2993)(@iplSlotIndex); return __sdkResult == IntPtr.Zero ? null : new CRect(__sdkResult); }
    public static NativePointer<int> @GetIplEntityIndexArray(int @arrayIndex) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2994 >(2994)(@arrayIndex); return new NativePointer<int>(__sdkResult); }
    public static NativePointer<sbyte> @GetIplName(int @iplSlotIndex) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2995 >(2995)(@iplSlotIndex); return new NativePointer<sbyte>(__sdkResult); }
    public static int @GetNewIplEntityIndexArray(int @entitiesCount) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2996 >(2996)(@entitiesCount); return __sdkResult; }
    public static bool @HaveIplsLoaded(CVector @coords,int @playerNumber) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2997 >(2997)(@coords.Pointer,@playerNumber); return __sdkResult != 0; }
    public static void @IncludeEntity(int @iplSlotIndex,CEntity? @entity) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2998 >(2998)(@iplSlotIndex,@entity?.Pointer ?? IntPtr.Zero); }
    public static void @Initialise() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2999 >(2999)(); }
    public static bool @Load() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3000 >(3000)(); return __sdkResult != 0; }
    public static void @LoadAllRemainingIpls() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3001 >(3001)(); }
    public static bool @LoadIpl(int @iplSlotIndex,NativePointer<byte> @data,int @dataSize) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3002 >(3002)(@iplSlotIndex,@data.Pointer,@dataSize); return __sdkResult != 0; }
    public static bool @LoadIplBoundingBox(int @iplSlotIndex,NativePointer<byte> @data,int @dataSize) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3003 >(3003)(@iplSlotIndex,@data.Pointer,@dataSize); return __sdkResult != 0; }
    public static void @LoadIpls(CVector @posn,bool @arg1) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3004 >(3004)(@posn.Pointer,(@arg1 ? 1 : 0)); }
    public static void @RemoveAllIpls() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3005 >(3005)(); }
    public static void @RemoveIpl(int @iplSlotIndex) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3006 >(3006)(@iplSlotIndex); }
    public static void @RemoveIplAndIgnore(int @iplSlotIndex) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3007 >(3007)(@iplSlotIndex); }
    public static void @RemoveIplSlot(int @iplSlotIndex) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3008 >(3008)(@iplSlotIndex); }
    public static void @RemoveIplWhenFarAway(int @iplSlotIndex) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3009 >(3009)(@iplSlotIndex); }
    public static void @RemoveRelatedIpls(int @entityArraysIndex) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3010 >(3010)(@entityArraysIndex); }
    public static void @RequestIplAndIgnore(int @iplSlotIndex) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3011 >(3011)(@iplSlotIndex); }
    public static void @RequestIpls(CVector @posn,int @playerNumber) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3012 >(3012)(@posn.Pointer,@playerNumber); }
    public static bool @Save() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3013 >(3013)(); return __sdkResult != 0; }
    public static void @SetIplsRequired(CVector @posn,int @playerNumber) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3014 >(3014)(@posn.Pointer,@playerNumber); }
    public static void @SetIsInterior(int @iplSlotIndex,bool @isInterior) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3015 >(3015)(@iplSlotIndex,(@isInterior ? 1 : 0)); }
    public static int @SetupRelatedIpls(NativePointer<sbyte> @iplName,int @entityArraysIndex,NativePointer<IntPtr> @instances) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3016 >(3016)(@iplName.Pointer,@entityArraysIndex,@instances.Pointer); return __sdkResult; }
    public static void @Shutdown() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3017 >(3017)(); }
}
