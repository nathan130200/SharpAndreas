// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CPathFind : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=15488;
    public CPathFind(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("info")]
    public CNodeAddress @Info { get => new CNodeAddress(Pointer+0); set { SdkMemory.Copy(value.Pointer,Pointer+0,4); } }
    [NativeMember("m_apNodesSearchLists")]
    public NativeArray<IntPtr> @NodesSearchLists { get => new NativeArray<IntPtr>(Pointer+4,512); }
    [NativeMember("m_pPathNodes")]
    public NativeArray<IntPtr> @PathNodes { get => new NativeArray<IntPtr>(Pointer+2052,72); }
    [NativeMember("m_pNaviNodes")]
    public NativeArray<IntPtr> @NaviNodes { get => new NativeArray<IntPtr>(Pointer+2340,72); }
    [NativeMember("m_pNodeLinks")]
    public NativeArray<IntPtr> @NodeLinks { get => new NativeArray<IntPtr>(Pointer+2628,72); }
    [NativeMember("m_pLinkLengths")]
    public NativeArray<IntPtr> @LinkLengths { get => new NativeArray<IntPtr>(Pointer+2916,72); }
    [NativeMember("m_pPathIntersections")]
    public NativeArray<IntPtr> @PathIntersections { get => new NativeArray<IntPtr>(Pointer+3204,72); }
    [NativeMember("m_pNaviLinks")]
    public NativeArray<IntPtr> @NaviLinks { get => new NativeArray<IntPtr>(Pointer+3492,64); }
    [NativeMember("field_EA4")]
    public NativeArray<IntPtr> @FieldEA4 { get => new NativeArray<IntPtr>(Pointer+3748,64); }
    [NativeMember("m_dwNumNodes")]
    public NativeArray<uint> @CountNodes { get => new NativeArray<uint>(Pointer+4004,72); }
    [NativeMember("m_dwNumVehicleNodes")]
    public NativeArray<uint> @CountVehicleNodes { get => new NativeArray<uint>(Pointer+4292,72); }
    [NativeMember("m_dwNumPedNodes")]
    public NativeArray<uint> @CountPedNodes { get => new NativeArray<uint>(Pointer+4580,72); }
    [NativeMember("m_dwNumCarPathLinks")]
    public NativeArray<uint> @CountCarPathLinks { get => new NativeArray<uint>(Pointer+4868,72); }
    [NativeMember("m_dwNumAddresses")]
    public NativeArray<uint> @CountAddresses { get => new NativeArray<uint>(Pointer+5156,72); }
    [NativeMember("field_1544")]
    public NativeArray<int> @Field1544 { get => new NativeArray<int>(Pointer+5444,2048); }
    [NativeMember("m_dwTotalNumNodesInSearchList")]
    public uint @TotalCountNodesInSearchList { get => SdkMemory.Read<uint >(Pointer+13636); set { SdkMemory.Write(Pointer+13636,value); } }
    [NativeMember("char3548")]
    public NativeObjectArray<CNodeAddress> @Char3548 { get => new NativeObjectArray<CNodeAddress>(Pointer+13640,8,4); }
    [NativeMember("m_dwNumForbiddenAreas")]
    public uint @CountForbiddenAreas { get => SdkMemory.Read<uint >(Pointer+13672); set { SdkMemory.Write(Pointer+13672,value); } }
    [NativeMember("m_aForbiddenAreas")]
    public NativeObjectArray<CForbiddenArea> @ForbiddenAreas { get => new NativeObjectArray<CForbiddenArea>(Pointer+13676,64,28); }
    [NativeMember("m_bForbiddenForScriptedCarsEnabled")]
    public bool @ForbiddenForScriptedCarsEnabled { get => SdkMemory.Read<bool >(Pointer+15468); set { SdkMemory.Write(Pointer+15468,value); } }
    [NativeMember("_padding")]
    public NativeArray<sbyte> @Padding { get => new NativeArray<sbyte>(Pointer+15469,3); }
    [NativeMember("m_fForbiddenForScrCarsX1")]
    public float @ForbiddenForScrCarsX1 { get => SdkMemory.Read<float >(Pointer+15472); set { SdkMemory.Write(Pointer+15472,value); } }
    [NativeMember("m_fForbiddenForScrCarsX2")]
    public float @ForbiddenForScrCarsX2 { get => SdkMemory.Read<float >(Pointer+15476); set { SdkMemory.Write(Pointer+15476,value); } }
    [NativeMember("m_fForbiddenForScrCarsY1")]
    public float @ForbiddenForScrCarsY1 { get => SdkMemory.Read<float >(Pointer+15480); set { SdkMemory.Write(Pointer+15480,value); } }
    [NativeMember("m_fForbiddenForScrCarsY2")]
    public float @ForbiddenForScrCarsY2 { get => SdkMemory.Read<float >(Pointer+15484); set { SdkMemory.Write(Pointer+15484,value); } }
    public void @DoPathSearch(byte @pathType,CVector @origin,CNodeAddress @originAddr,CVector @target,CNodeAddress? @pResultNodes,NativePointer<short> @pNodesCount,int @maxNodesToFind,NativePointer<float> @pDistance,float @maxSearchDistance,CNodeAddress? @targetAddr,float @maxUnkLimit,bool @oneSideOnly,CNodeAddress @forbiddenNodeAddr,bool @includeNodesWithoutLinks,bool @waterPath) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D786 >(786)(Pointer,@pathType,@origin.Pointer,@originAddr.Pointer,@target.Pointer,@pResultNodes?.Pointer ?? IntPtr.Zero,@pNodesCount.Pointer,@maxNodesToFind,@pDistance.Pointer,@maxSearchDistance,@targetAddr?.Pointer ?? IntPtr.Zero,@maxUnkLimit,(@oneSideOnly ? 1 : 0),@forbiddenNodeAddr.Pointer,(@includeNodesWithoutLinks ? 1 : 0),(@waterPath ? 1 : 0)); }
    public bool @IsWaterNodeNearby(CVector @position,float @radius) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D787 >(787)(Pointer,@position.Pointer,@radius); return __sdkResult != 0; }
    public void @SetPathsNeededAtPosition(CVector @pos) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D788 >(788)(Pointer,@pos.Pointer); }
    public void @UpdateStreaming(bool @bForceStreaming) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D789 >(789)(Pointer,(@bForceStreaming ? 1 : 0)); }
    public CPathNode? @GetPathNode(CNodeAddress @address) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D790 >(790)(Pointer,@address.Pointer); return __sdkResult == IntPtr.Zero ? null : new CPathNode(__sdkResult); }
    public bool @Load() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D791 >(791)(Pointer); return __sdkResult != 0; }
    public bool @Save() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D792 >(792)(Pointer); return __sdkResult != 0; }
}
