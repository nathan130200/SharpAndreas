// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CSetPieces : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=1;
    public CSetPieces(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("bDebug")]
    public static bool @Debug { get => SdkMemory.Read<bool >(new IntPtr(0xA957F8)); set { SdkMemory.Write(new IntPtr(0xA957F8),value); } }
    [NativeMember("NumSetPieces")]
    public static uint @CountSetPieces { get => SdkMemory.Read<uint >(new IntPtr(0xA957FC)); set { SdkMemory.Write(new IntPtr(0xA957FC),value); } }
    [NativeMember("aSetPieces")]
    public static CSetPiece? @SetPieces { get => new IntPtr(0xA95818) == IntPtr.Zero ? null : new CSetPiece(new IntPtr(0xA95818)); }
    public static void @AddOne(byte @type,CVector2D @cornerA,CVector2D @cornerB,CVector2D @spawnCoord1,CVector2D @targetCoord1,CVector2D @spawnCoord2,CVector2D @targetCoord2) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3737 >(3737)(@type,@cornerA.Pointer,@cornerB.Pointer,@spawnCoord1.Pointer,@targetCoord1.Pointer,@spawnCoord2.Pointer,@targetCoord2.Pointer); }
    public static void @Init() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3738 >(3738)(); }
    public static bool @Load() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3739 >(3739)(); return __sdkResult != 0; }
    public static bool @Save() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3740 >(3740)(); return __sdkResult != 0; }
    public static void @Update() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3741 >(3741)(); }
}
