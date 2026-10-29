// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CCheckpoints : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=1;
    public CCheckpoints(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("NumActiveCPts")]
    public static uint @CountActiveCPts { get => SdkMemory.Read<uint >(new IntPtr(0xC7C6D4)); set { SdkMemory.Write(new IntPtr(0xC7C6D4),value); } }
    [NativeMember("m_aCheckPtArray")]
    public static CCheckpoint? @CheckPtArray { get => new IntPtr(0xC7F158) == IntPtr.Zero ? null : new CCheckpoint(new IntPtr(0xC7F158)); }
    public static void @DeleteCP(uint @id,ushort @type) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1973 >(1973)(@id,@type); }
    public static void @Init() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1974 >(1974)(); }
    public static CCheckpoint? @PlaceMarker(uint @id,ushort @type,CVector @posn,CVector @direction,float @size,byte @red,byte @green,byte @blue,byte @alpha,ushort @pulsePeriod,float @pulseFraction,short @rotateRate) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1975 >(1975)(@id,@type,@posn.Pointer,@direction.Pointer,@size,@red,@green,@blue,@alpha,@pulsePeriod,@pulseFraction,@rotateRate); return __sdkResult == IntPtr.Zero ? null : new CCheckpoint(__sdkResult); }
    public static void @Render() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1976 >(1976)(); }
    public static void @SetHeading(uint @id,float @angle) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1977 >(1977)(@id,@angle); }
    public static void @Shutdown() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1978 >(1978)(); }
    public static void @Update() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1979 >(1979)(); }
    public static void @UpdatePos(uint @id,CVector @posn) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1980 >(1980)(@id,@posn.Pointer); }
}
