// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CColStore : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=1;
    public CColStore(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("ms_pColPool")]
    public static CPool_ColDef__9e9c6b7efb? @CollisionPool { get => SdkMemory.Read<IntPtr>(new IntPtr(0x965560)) == IntPtr.Zero ? null : new CPool_ColDef__9e9c6b7efb(SdkMemory.Read<IntPtr>(new IntPtr(0x965560))); set { SdkMemory.Write(new IntPtr(0x965560),value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("ms_pQuadTree")]
    public static CQuadTreeNode? @QuadTree { get => SdkMemory.Read<IntPtr>(new IntPtr(0x96555C)) == IntPtr.Zero ? null : new CQuadTreeNode(SdkMemory.Read<IntPtr>(new IntPtr(0x96555C))); set { SdkMemory.Write(new IntPtr(0x96555C),value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("ms_vecCollisionNeeded")]
    public static CVector @CollisionNeeded { get => new CVector(new IntPtr(0x965580)); set { SdkMemory.Copy(value.Pointer,new IntPtr(0x965580),12); } }
    [NativeMember("ms_bCollisionNeeded")]
    public static bool @CollisionNeededValue { get => SdkMemory.Read<bool >(new IntPtr(0x965558)); set { SdkMemory.Write(new IntPtr(0x965558),value); } }
    [NativeMember("ms_nRequiredCollisionArea")]
    public static int @RequiredCollisionArea { get => SdkMemory.Read<int >(new IntPtr(0x965554)); }
    public static void @Initialise() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2253 >(2253)(); }
    public static void @Shutdown() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2254 >(2254)(); }
    public static int @AddColSlot(NativePointer<sbyte> @name) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2255 >(2255)(@name.Pointer); return __sdkResult; }
    public static void @AddCollisionNeededAtPosn(CVector @pos) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2256 >(2256)(@pos.Pointer); }
    public static void @AddRef(int @colNum) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2257 >(2257)(@colNum); }
    public static void @BoundingBoxesPostProcess() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2258 >(2258)(); }
    public static void @EnsureCollisionIsInMemory(CVector @pos) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2259 >(2259)(@pos.Pointer); }
    public static CRect? @GetBoundingBox(int @colSlot) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2260 >(2260)(@colSlot); return __sdkResult == IntPtr.Zero ? null : new CRect(__sdkResult); }
    public static void @IncludeModelIndex(int @colSlot,int @modelId) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2261 >(2261)(@colSlot,@modelId); }
    public static bool @HasCollisionLoaded(CVector @pos,int @areaCode) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2262 >(2262)(@pos.Pointer,@areaCode); return __sdkResult != 0; }
    public static void @LoadAllBoundingBoxes() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2263 >(2263)(); }
    public static void @LoadAllCollision() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2264 >(2264)(); }
    public static void @LoadCol(int @colSlot,NativePointer<sbyte> @filename) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2265 >(2265)(@colSlot,@filename.Pointer); }
    public static bool @LoadCol(int @colSlot,NativePointer<byte> @data,int @dataSize) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2266 >(2266)(@colSlot,@data.Pointer,@dataSize); return __sdkResult != 0; }
    public static void @LoadCollision(CVector @pos,bool @bIgnorePlayerVeh) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2267 >(2267)(@pos.Pointer,(@bIgnorePlayerVeh ? 1 : 0)); }
    public static void @RemoveAllCollision() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2268 >(2268)(); }
    public static void @RemoveCol(int @colSlot) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2269 >(2269)(@colSlot); }
    public static void @RemoveColSlot(int @colSlot) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2270 >(2270)(@colSlot); }
    public static void @RemoveRef(int @colNum) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2271 >(2271)(@colNum); }
    public static void @RequestCollision(CVector @pos,int @areaCode) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2272 >(2272)(@pos.Pointer,@areaCode); }
    public static void @SetCollisionRequired(CVector @pos,int @areaCode) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2273 >(2273)(@pos.Pointer,@areaCode); }
}
