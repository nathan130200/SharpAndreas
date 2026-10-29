// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class C3dMarkers : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=1;
    public C3dMarkers(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_colDiamond")]
    public static byte @CollisionDiamond { get => SdkMemory.Read<byte >(new IntPtr(0x8D5D8B)); set { SdkMemory.Write(new IntPtr(0x8D5D8B),value); } }
    [NativeMember("ms_directionArrows")]
    public static tDirectionArrow? @DirectionArrows { get => new IntPtr(0xC802E8) == IntPtr.Zero ? null : new tDirectionArrow(new IntPtr(0xC802E8)); }
    [NativeMember("m_user3dMarkerColor")]
    public static CRGBA @User3dMarkerColor { get => new CRGBA(new IntPtr(0xC7C620)); set { SdkMemory.Copy(value.Pointer,new IntPtr(0xC7C620),4); } }
    [NativeMember("ms_user3dMarkers")]
    public static tUser3dMarker? @User3dMarkers { get => new IntPtr(0xC80258) == IntPtr.Zero ? null : new tUser3dMarker(new IntPtr(0xC80258)); }
    [NativeMember("IgnoreRenderLimit")]
    public static bool @IgnoreRenderLimit { get => SdkMemory.Read<bool >(new IntPtr(0xC7C704)); set { SdkMemory.Write(new IntPtr(0xC7C704),value); } }
    [NativeMember("m_angleDiamond")]
    public static float @AngleDiamond { get => SdkMemory.Read<float >(new IntPtr(0xC7C700)); set { SdkMemory.Write(new IntPtr(0xC7C700),value); } }
    [NativeMember("NumActiveMarkers")]
    public static uint @CountActiveMarkers { get => SdkMemory.Read<uint >(new IntPtr(0xC7C6D8)); set { SdkMemory.Write(new IntPtr(0xC7C6D8),value); } }
    [NativeMember("m_aMarkerArray")]
    public static C3dMarker? @MarkerArray { get => new IntPtr(0xC7DD58) == IntPtr.Zero ? null : new C3dMarker(new IntPtr(0xC7DD58)); }
    [NativeMember("m_pRpClumpArray")]
    public static NativePointer<IntPtr> @RpClumpArray { get => new NativePointer<IntPtr>(new IntPtr(0xC7C6DC)); }
    public static int @DirectionArrowFindFirstFreeSlot() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D190 >(190)(); return __sdkResult; }
    public static void @DirectionArrowSet(CVector @posn,float @size,int @red,int @green,int @blue,int @alpha,float @dir_x,float @dir_y,float @dir_z) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D191 >(191)(@posn.Pointer,@size,@red,@green,@blue,@alpha,@dir_x,@dir_y,@dir_z); }
    public static void @DirectionArrowsDraw() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D192 >(192)(); }
    public static void @DirectionArrowsInit() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D193 >(193)(); }
    public static void @ForceRender(byte @bEnable) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D194 >(194)(@bEnable); }
    public static void @Init() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D195 >(195)(); }
    public static RpClump? @LoadMarker(NativePointer<sbyte> @modelName) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D196 >(196)(@modelName.Pointer); return __sdkResult == IntPtr.Zero ? null : new RpClump(__sdkResult); }
    public static bool @LoadUser3dMarkers() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D197 >(197)(); return __sdkResult != 0; }
    public static C3dMarker? @PlaceMarker(uint @id,ushort @type,CVector @posn,float @size,byte @red,byte @green,byte @blue,byte @alpha,ushort @pulsePeriod,float @pulseFraction,short @rotateRate,float @nrm_x,float @nrm_y,float @nrm_z,bool @zCheck) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D198 >(198)(@id,@type,@posn.Pointer,@size,@red,@green,@blue,@alpha,@pulsePeriod,@pulseFraction,@rotateRate,@nrm_x,@nrm_y,@nrm_z,(@zCheck ? 1 : 0)); return __sdkResult == IntPtr.Zero ? null : new C3dMarker(__sdkResult); }
    public static void @PlaceMarkerCone(uint @id,CVector @posn,float @size,byte @red,byte @green,byte @blue,byte @alpha,ushort @pulsePeriod,float @pulseFraction,short @rotateRate,byte @bEnableCollision) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D199 >(199)(@id,@posn.Pointer,@size,@red,@green,@blue,@alpha,@pulsePeriod,@pulseFraction,@rotateRate,@bEnableCollision); }
    public static void @PlaceMarkerSet(uint @id,ushort @type,CVector @posn,float @size,byte @red,byte @green,byte @blue,byte @alpha,ushort @pulsePeriod,float @pulseFraction,short @rotateRate) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D200 >(200)(@id,@type,@posn.Pointer,@size,@red,@green,@blue,@alpha,@pulsePeriod,@pulseFraction,@rotateRate); }
    public static void @Render() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D201 >(201)(); }
    public static void @SaveUser3dMarkers() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D202 >(202)(); }
    public static void @Shutdown() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D203 >(203)(); }
    public static void @Update() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D204 >(204)(); }
    public static RpAtomic? @User3dMarkerAtomicCB(RpAtomic? @atomic,NativePointer<IntPtr> @data) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D205 >(205)(@atomic?.Pointer ?? IntPtr.Zero,@data.Pointer); return __sdkResult == IntPtr.Zero ? null : new RpAtomic(__sdkResult); }
    public static void @User3dMarkerDelete(int @slotIndex) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D206 >(206)(@slotIndex); }
    public static void @User3dMarkerDeleteAll() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D207 >(207)(); }
    public static int @User3dMarkerFindFirstFreeSlot() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D208 >(208)(); return __sdkResult; }
    public static int @User3dMarkerSet(float @x,float @y,float @z,int @colour) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D209 >(209)(@x,@y,@z,@colour); return __sdkResult; }
    public static void @User3dMarkersDraw() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D210 >(210)(); }
}
