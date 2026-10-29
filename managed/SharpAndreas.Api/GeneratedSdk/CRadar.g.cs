// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CRadar : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=1;
    public CRadar(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("cachedCos")]
    public static float @CachedCos { get => SdkMemory.Read<float >(new IntPtr(0xBA8308)); set { SdkMemory.Write(new IntPtr(0xBA8308),value); } }
    [NativeMember("cachedSin")]
    public static float @CachedSin { get => SdkMemory.Read<float >(new IntPtr(0xBA830C)); set { SdkMemory.Write(new IntPtr(0xBA830C),value); } }
    [NativeMember("m_fRadarOrientation")]
    public static float @RadarOrientation { get => SdkMemory.Read<float >(new IntPtr(0xBA8310)); set { SdkMemory.Write(new IntPtr(0xBA8310),value); } }
    [NativeMember("m_radarRange")]
    public static float @RadarRange { get => SdkMemory.Read<float >(new IntPtr(0xBA8314)); set { SdkMemory.Write(new IntPtr(0xBA8314),value); } }
    [NativeMember("MapLegendList")]
    public static NativePointer<ushort> @MapLegendList { get => new NativePointer<ushort>(new IntPtr(0xBA8318)); }
    [NativeMember("MapLegendCounter")]
    public static ushort @MapLegendCounter { get => SdkMemory.Read<ushort >(new IntPtr(0xBA86B8)); set { SdkMemory.Write(new IntPtr(0xBA86B8),value); } }
    [NativeMember("ArrowBlipColour")]
    public static CRGBA? @ArrowBlipColor { get => new IntPtr(0xBA86D4) == IntPtr.Zero ? null : new CRGBA(new IntPtr(0xBA86D4)); }
    [NativeMember("ms_RadarTrace")]
    public static tRadarTrace? @RadarTrace { get => new IntPtr(0xBA86F0) == IntPtr.Zero ? null : new tRadarTrace(new IntPtr(0xBA86F0)); }
    [NativeMember("vec2DRadarOrigin")]
    public static CVector2D @Vec2DRadarOrigin { get => new CVector2D(new IntPtr(0xBAA248)); set { SdkMemory.Copy(value.Pointer,new IntPtr(0xBAA248),8); } }
    [NativeMember("RadarBlipSprites")]
    public static CSprite2d? @RadarBlipSprites { get => new IntPtr(0xBAA250) == IntPtr.Zero ? null : new CSprite2d(new IntPtr(0xBAA250)); }
    [NativeMember("m_radarRect")]
    public static CRect @RadarRect { get => new CRect(new IntPtr(0x8D0920)); set { SdkMemory.Copy(value.Pointer,new IntPtr(0x8D0920),16); } }
    [NativeMember("airstrip_location")]
    public static byte @AirstripLocation { get => SdkMemory.Read<byte >(new IntPtr(0xBA8300)); set { SdkMemory.Write(new IntPtr(0xBA8300),value); } }
    [NativeMember("airstrip_blip")]
    public static int @AirstripBlip { get => SdkMemory.Read<int >(new IntPtr(0xBA8304)); set { SdkMemory.Write(new IntPtr(0xBA8304),value); } }
    public static void @LoadTextures() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2789 >(2789)(); }
    public static int @GetNewUniqueBlipIndex(int @blipArrId) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2790 >(2790)(@blipArrId); return __sdkResult; }
    public static int @GetActualBlipArrayIndex(int @blipIndex) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2791 >(2791)(@blipIndex); return __sdkResult; }
    public static void @DrawLegend(int @x,int @y,int @blipType) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2792 >(2792)(@x,@y,@blipType); }
    public static float @LimitRadarPoint(CVector2D @point) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2793 >(2793)(@point.Pointer); return __sdkResult; }
    public static void @LimitToMap(NativePointer<float> @pX,NativePointer<float> @pY) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2794 >(2794)(@pX.Pointer,@pY.Pointer); }
    public static byte @CalculateBlipAlpha(float @distance) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2795 >(2795)(@distance); return __sdkResult; }
    public static void @TransformRadarPointToScreenSpace(CVector2D @out,CVector2D @in) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2796 >(2796)(@out.Pointer,@in.Pointer); }
    public static void @TransformRealWorldPointToRadarSpace(CVector2D @out,CVector2D @in) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2797 >(2797)(@out.Pointer,@in.Pointer); }
    public static void @TransformRadarPointToRealWorldSpace(CVector2D @out,CVector2D @in) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2798 >(2798)(@out.Pointer,@in.Pointer); }
    public static void @TransformRealWorldToTexCoordSpace(CVector2D @out,CVector2D @in,int @arg2,int @arg3) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2799 >(2799)(@out.Pointer,@in.Pointer,@arg2,@arg3); }
    public static void @CalculateCachedSinCos() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2800 >(2800)(); }
    public static int @SetCoordBlip(eBlipType @type,CVector @posn,uint @arg2,eBlipDisplay @blipDisplay,NativePointer<sbyte> @scriptName) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2801 >(2801)((int)@type,@posn.Pointer,@arg2,(int)@blipDisplay,@scriptName.Pointer); return __sdkResult; }
    public static int @SetShortRangeCoordBlip(eBlipType @type,CVector @posn,uint @arg2,eBlipDisplay @blipDisplay,NativePointer<sbyte> @scriptName) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2802 >(2802)((int)@type,@posn.Pointer,@arg2,(int)@blipDisplay,@scriptName.Pointer); return __sdkResult; }
    public static int @SetEntityBlip(eBlipType @type,int @entityHandle,uint @arg2,eBlipDisplay @blipDisplay) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2803 >(2803)((int)@type,@entityHandle,@arg2,(int)@blipDisplay); return __sdkResult; }
    public static void @ChangeBlipColour(int @blipIndex,uint @color) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2804 >(2804)(@blipIndex,@color); }
    public static bool @HasThisBlipBeenRevealed(int @blipArrId) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2805 >(2805)(@blipArrId); return __sdkResult != 0; }
    public static bool @DisplayThisBlip(int @spriteId,sbyte @priority) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2806 >(2806)(@spriteId,@priority); return __sdkResult != 0; }
    public static void @ChangeBlipBrightness(int @blipIndex,int @brightness) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2807 >(2807)(@blipIndex,@brightness); }
    public static void @ChangeBlipScale(int @blipIndex,int @size) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2808 >(2808)(@blipIndex,@size); }
    public static void @ChangeBlipDisplay(int @blipIndex,eBlipDisplay @blipDisplay) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2809 >(2809)(@blipIndex,(int)@blipDisplay); }
    public static void @SetBlipSprite(int @blipIndex,int @spriteId) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2810 >(2810)(@blipIndex,@spriteId); }
    public static void @SetBlipAlwaysDisplayInZoom(int @blipIndex,byte @display) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2811 >(2811)(@blipIndex,@display); }
    public static void @SetBlipFade(int @blipIndex,byte @fade) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2812 >(2812)(@blipIndex,@fade); }
    public static void @SetCoordBlipAppearance(int @blipIndex,byte @appearance) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2813 >(2813)(@blipIndex,@appearance); }
    public static void @SetBlipFriendly(int @blipIndex,byte @friendly) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2814 >(2814)(@blipIndex,@friendly); }
    public static void @SetBlipEntryExit(int @blipIndex,CEntryExit? @enex) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2815 >(2815)(@blipIndex,@enex?.Pointer ?? IntPtr.Zero); }
    public static void @ShowRadarTrace(float @x,float @y,uint @size,byte @red,byte @green,byte @blue,byte @alpha) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2816 >(2816)(@x,@y,@size,@red,@green,@blue,@alpha); }
    public static void @ShowRadarTraceWithHeight(float @x,float @y,uint @size,byte @red,byte @green,byte @blue,byte @alpha,byte @type) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2817 >(2817)(@x,@y,@size,@red,@green,@blue,@alpha,@type); }
    public static void @ShowRadarMarker(CVector @posn,uint @color,float @radius) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2818 >(2818)(@posn.Pointer,@color,@radius); }
    public static uint @GetRadarTraceColour(uint @color,byte @bright,byte @friendly) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2819 >(2819)(@color,@bright,@friendly); return __sdkResult; }
    public static void @DrawRotatingRadarSprite(CSprite2d? @sprite,float @x,float @y,float @angle,uint @width,uint @height,CRGBA @color) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2820 >(2820)(@sprite?.Pointer ?? IntPtr.Zero,@x,@y,@angle,@width,@height,@color.Pointer); }
    public static void @DrawYouAreHereSprite(float @x,float @y) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2821 >(2821)(@x,@y); }
    public static void @SetupRadarRect(int @x,int @y) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2822 >(2822)(@x,@y); }
    public static void @RequestMapSection(int @x,int @y) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2823 >(2823)(@x,@y); }
    public static void @RemoveMapSection(int @x,int @y) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2824 >(2824)(@x,@y); }
    public static void @RemoveRadarSections() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2825 >(2825)(); }
    public static void @StreamRadarSections(int @x,int @y) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2826 >(2826)(@x,@y); }
    public static int @ClipRadarPoly(CVector2D? @out,CVector2D? @in) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2827 >(2827)(@out?.Pointer ?? IntPtr.Zero,@in?.Pointer ?? IntPtr.Zero); return __sdkResult; }
    public static void @DrawAreaOnRadar(CRect @rect,CRGBA @color,bool @inMenu) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2828 >(2828)(@rect.Pointer,@color.Pointer,(@inMenu ? 1 : 0)); }
    public static void @DrawRadarMask() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2829 >(2829)(); }
    public static void @StreamRadarSections(CVector @worldPosn) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2830 >(2830)(@worldPosn.Pointer); }
    public static void @Shutdown() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2831 >(2831)(); }
    public static void @InitFrontEndMap() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2832 >(2832)(); }
    public static void @AddBlipToLegendList(byte @arg0,int @blipArrId) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2833 >(2833)(@arg0,@blipArrId); }
    public static void @SetMapCentreToPlayerCoords() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2834 >(2834)(); }
    public static void @Draw3dMarkers() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2835 >(2835)(); }
    public static void @SetRadarMarkerState(int @arg0,byte @arg1) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2836 >(2836)(@arg0,@arg1); }
    public static void @DrawRadarSprite(ushort @spriteId,float @x,float @y,byte @alpha) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2837 >(2837)(@spriteId,@x,@y,@alpha); }
    public static void @DrawRadarSection(int @x,int @y) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2838 >(2838)(@x,@y); }
    public static void @DrawRadarSectionMap(int @x,int @y,CRect @rect) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2839 >(2839)(@x,@y,@rect.Pointer); }
    public static void @DrawRadarGangOverlay(bool @inMenu) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2840 >(2840)((@inMenu ? 1 : 0)); }
    public static void @DrawRadarMap() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2841 >(2841)(); }
    public static void @DrawMap() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2842 >(2842)(); }
    public static void @DrawCoordBlip(int @blipArrId,byte @isSprite) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2843 >(2843)(@blipArrId,@isSprite); }
    public static void @DrawEntityBlip(int @blipArrId,byte @arg1) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2844 >(2844)(@blipArrId,@arg1); }
    public static void @ClearActualBlip(int @blipArrId) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2845 >(2845)(@blipArrId); }
    public static void @ClearBlipForEntity(eBlipType @blipType,int @entityHandle) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2846 >(2846)((int)@blipType,@entityHandle); }
    public static void @ClearBlip(int @blipIndex) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2847 >(2847)(@blipIndex); }
    public static void @SetupAirstripBlips() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2848 >(2848)(); }
    public static void @Initialise() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2849 >(2849)(); }
    public static void @DrawBlips() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2850 >(2850)(); }
    public static void @Load() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2851 >(2851)(); }
    public static void @Save() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2852 >(2852)(); }
}
