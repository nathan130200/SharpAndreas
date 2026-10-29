// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CGridRef : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=1;
    public CGridRef(System.IntPtr pointer) : base(pointer) {}
    public static NativePointer<sbyte> @GetAreaName(byte @sectorX,byte @sectorY) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2924 >(2924)(@sectorX,@sectorY); return new NativePointer<sbyte>(__sdkResult); }
    public static uint @GetArtistBugstarID(byte @sectorX,byte @sectorY) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2925 >(2925)(@sectorX,@sectorY); return __sdkResult; }
    public static void @GetGridRefPositions(CVector @posn,NativePointer<byte> @outSectorX,NativePointer<byte> @outSectorY) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2926 >(2926)(@posn.Pointer,@outSectorX.Pointer,@outSectorY.Pointer); }
    public static void @GetGridRefPositions(NativePointer<byte> @outSectorX,NativePointer<byte> @outSectorY) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2927 >(2927)(@outSectorX.Pointer,@outSectorY.Pointer); }
    public static void @Init() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2928 >(2928)(); }
}
