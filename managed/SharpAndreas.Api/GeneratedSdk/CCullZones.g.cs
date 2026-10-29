// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CCullZones : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=1;
    public CCullZones(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("NumMirrorAttributeZones")]
    public static int @CountMirrorAttributeZones { get => SdkMemory.Read<int >(new IntPtr(0xC87AC4)); set { SdkMemory.Write(new IntPtr(0xC87AC4),value); } }
    [NativeMember("aMirrorAttributeZones")]
    public static NativeObjectArray<CCullZoneReflection> @MirrorAttributeZones { get => new NativeObjectArray<CCullZoneReflection>(new IntPtr(0xC815C0),72,24); }
    [NativeMember("NumTunnelAttributeZones")]
    public static int @CountTunnelAttributeZones { get => SdkMemory.Read<int >(new IntPtr(0xC87AC0)); set { SdkMemory.Write(new IntPtr(0xC87AC0),value); } }
    [NativeMember("aTunnelAttributeZones")]
    public static NativeObjectArray<CCullZone> @TunnelAttributeZones { get => new NativeObjectArray<CCullZone>(new IntPtr(0xC81C80),40,18); }
    [NativeMember("NumAttributeZones")]
    public static int @CountAttributeZones { get => SdkMemory.Read<int >(new IntPtr(0xC87AC8)); set { SdkMemory.Write(new IntPtr(0xC87AC8),value); } }
    [NativeMember("aAttributeZones")]
    public static NativeObjectArray<CCullZone> @AttributeZones { get => new NativeObjectArray<CCullZone>(new IntPtr(0xC81F50),1300,18); }
    [NativeMember("CurrentFlags_Player")]
    public static int @CurrentFlagsPlayer { get => SdkMemory.Read<int >(new IntPtr(0xC87AB8)); set { SdkMemory.Write(new IntPtr(0xC87AB8),value); } }
    [NativeMember("CurrentFlags_Camera")]
    public static int @CurrentFlagsCamera { get => SdkMemory.Read<int >(new IntPtr(0xC87ABC)); set { SdkMemory.Write(new IntPtr(0xC87ABC),value); } }
    [NativeMember("bMilitaryZonesDisabled")]
    public static bool @MilitaryZonesDisabled { get => SdkMemory.Read<bool >(new IntPtr(0xC87ACD)); set { SdkMemory.Write(new IntPtr(0xC87ACD),value); } }
    public static void @Init() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2325 >(2325)(); }
    public static void @Update() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2326 >(2326)(); }
    public static void @AddCullZone(CVector @center,float @unk1,float @fWidthY,float @fBottomZ,float @fWidthX,float @unk2,float @fTopZ,ushort @flags) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2327 >(2327)(@center.Pointer,@unk1,@fWidthY,@fBottomZ,@fWidthX,@unk2,@fTopZ,@flags); }
    public static void @AddTunnelAttributeZone(CVector @center,float @unk1,float @fWidthY,float @fBottomZ,float @fWidthX,float @unk2,float @fTopZ,ushort @flags) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2328 >(2328)(@center.Pointer,@unk1,@fWidthY,@fBottomZ,@fWidthX,@unk2,@fTopZ,@flags); }
    public static void @AddMirrorAttributeZone(CVector @center,float @unk1,float @fWidthY,float @fBottomZ,float @fWidthX,float @unk2,float @fTopZ,eZoneAttributes @flags,float @cm,float @vX,float @vY,float @vZ) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2329 >(2329)(@center.Pointer,@unk1,@fWidthY,@fBottomZ,@fWidthX,@unk2,@fTopZ,(int)@flags,@cm,@vX,@vY,@vZ); }
    public static bool @InRoomForAudio() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2330 >(2330)(); return __sdkResult != 0; }
    public static bool @FewerCars() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2331 >(2331)(); return __sdkResult != 0; }
    public static bool @CamNoRain() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2332 >(2332)(); return __sdkResult != 0; }
    public static bool @PlayerNoRain() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2333 >(2333)(); return __sdkResult != 0; }
    public static bool @FewerPeds() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2334 >(2334)(); return __sdkResult != 0; }
    public static bool @NoPolice() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2335 >(2335)(); return __sdkResult != 0; }
    public static bool @DoExtraAirResistanceForPlayer() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2336 >(2336)(); return __sdkResult != 0; }
    public static eZoneAttributes @FindTunnelAttributesForCoors(CVector @point) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2337 >(2337)(@point.Pointer); return (eZoneAttributes)__sdkResult; }
    public static CCullZoneReflection? @FindMirrorAttributesForCoors(CVector @cameraPosition) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2338 >(2338)(@cameraPosition.Pointer); return __sdkResult == IntPtr.Zero ? null : new CCullZoneReflection(__sdkResult); }
    public static CCullZone? @FindZoneWithStairsAttributeForPlayer() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2339 >(2339)(); return __sdkResult == IntPtr.Zero ? null : new CCullZone(__sdkResult); }
    public static eZoneAttributes @FindAttributesForCoors(CVector @pos) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2340 >(2340)(@pos.Pointer); return (eZoneAttributes)__sdkResult; }
}
