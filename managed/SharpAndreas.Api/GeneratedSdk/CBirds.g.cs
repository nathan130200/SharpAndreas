// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CBirds : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=1;
    public CBirds(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("bHasBirdBeenShot")]
    public static bool @HasBirdBeenShot { get => SdkMemory.Read<bool >(new IntPtr(0xC6A8A0)); set { SdkMemory.Write(new IntPtr(0xC6A8A0),value); } }
    [NativeMember("NumberOfBirds")]
    public static uint @NumberOfBirds { get => SdkMemory.Read<uint >(new IntPtr(0xC6A8A4)); set { SdkMemory.Write(new IntPtr(0xC6A8A4),value); } }
    [NativeMember("aBirds")]
    public static CBird? @Birds { get => new IntPtr(0xC6A8B0) == IntPtr.Zero ? null : new CBird(new IntPtr(0xC6A8B0)); }
    [NativeMember("BirdShotAt")]
    public static CVector @BirdShotAt { get => new CVector(new IntPtr(0xC6AA48)); set { SdkMemory.Copy(value.Pointer,new IntPtr(0xC6AA48),12); } }
    public static void @Init() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1213 >(1213)(); }
    public static int @CreateNumberOfBirds(CVector @pos,CVector @destination,int @count,int @birdType,bool @checkObstacles) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1214 >(1214)(@pos.Pointer,@destination.Pointer,@count,@birdType,(@checkObstacles ? 1 : 0)); return __sdkResult; }
    public static void @Shutdown() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1215 >(1215)(); }
    public static void @Update() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1216 >(1216)(); }
    public static void @Render() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1217 >(1217)(); }
    public static void @HandleGunShot(CVector? @pointA,CVector? @pointB) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1218 >(1218)(@pointA?.Pointer ?? IntPtr.Zero,@pointB?.Pointer ?? IntPtr.Zero); }
}
