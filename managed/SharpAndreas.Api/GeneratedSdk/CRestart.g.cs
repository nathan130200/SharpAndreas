// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CRestart : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=1;
    public CRestart(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("bOverrideRespawnBasePointForMission")]
    public static bool @OverrideRespawnBasePointForMission { get => SdkMemory.Read<bool >(new IntPtr(0xA43248)); set { SdkMemory.Write(new IntPtr(0xA43248),value); } }
    [NativeMember("OverrideRespawnBasePointForMission")]
    public static CVector? @OverrideRespawnBasePointForMissionValue { get => new IntPtr(0xA4342C) == IntPtr.Zero ? null : new CVector(new IntPtr(0xA4342C)); }
    [NativeMember("OverrideHeading")]
    public static float @OverrideHeading { get => SdkMemory.Read<float >(new IntPtr(0xA43260)); set { SdkMemory.Write(new IntPtr(0xA43260),value); } }
    [NativeMember("bOverrideRestart")]
    public static bool @OverrideRestart { get => SdkMemory.Read<bool >(new IntPtr(0xA43264)); set { SdkMemory.Write(new IntPtr(0xA43264),value); } }
    [NativeMember("OverridePosition")]
    public static CVector? @OverridePosition { get => new IntPtr(0xA43408) == IntPtr.Zero ? null : new CVector(new IntPtr(0xA43408)); }
    [NativeMember("NumberOfPoliceRestarts")]
    public static short @NumberOfPoliceRestarts { get => SdkMemory.Read<short >(new IntPtr(0xA43268)); set { SdkMemory.Write(new IntPtr(0xA43268),value); } }
    [NativeMember("PoliceRestartWhenToUse")]
    public static int @PoliceRestartWhenToUse { get => SdkMemory.Read<int >(new IntPtr(0xA43270)); set { SdkMemory.Write(new IntPtr(0xA43270),value); } }
    [NativeMember("PoliceRestartHeadings")]
    public static float @PoliceRestartHeadings { get => SdkMemory.Read<float >(new IntPtr(0xA43298)); set { SdkMemory.Write(new IntPtr(0xA43298),value); } }
    [NativeMember("PoliceRestartPoints")]
    public static CVector? @PoliceRestartPoints { get => new IntPtr(0xA43390) == IntPtr.Zero ? null : new CVector(new IntPtr(0xA43390)); }
    [NativeMember("NumberOfHospitalRestarts")]
    public static short @NumberOfHospitalRestarts { get => SdkMemory.Read<short >(new IntPtr(0xA4326C)); set { SdkMemory.Write(new IntPtr(0xA4326C),value); } }
    [NativeMember("HospitalRestartWhenToUse")]
    public static int @HospitalRestartWhenToUse { get => SdkMemory.Read<int >(new IntPtr(0xA432C0)); set { SdkMemory.Write(new IntPtr(0xA432C0),value); } }
    [NativeMember("HospitalRestartHeadings")]
    public static float @HospitalRestartHeadings { get => SdkMemory.Read<float >(new IntPtr(0xA432E8)); set { SdkMemory.Write(new IntPtr(0xA432E8),value); } }
    [NativeMember("HospitalRestartPoints")]
    public static CVector? @HospitalRestartPoints { get => new IntPtr(0xA43318) == IntPtr.Zero ? null : new CVector(new IntPtr(0xA43318)); }
    public static void @AddHospitalRestartPoint(CVector @point,float @angle,int @townId) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3593 >(3593)(@point.Pointer,@angle,@townId); }
    public static void @AddPoliceRestartPoint(CVector @point,float @angle,int @townId) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3594 >(3594)(@point.Pointer,@angle,@townId); }
    public static void @CancelOverrideRestart() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3595 >(3595)(); }
    public static void @ClearRespawnPointForDurationOfMission() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3596 >(3596)(); }
    public static void @FindClosestHospitalRestartPoint(CVector @point,CVector? @storedPoint,NativePointer<float> @storedAngle) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3597 >(3597)(@point.Pointer,@storedPoint?.Pointer ?? IntPtr.Zero,@storedAngle.Pointer); }
    public static void @FindClosestPoliceRestartPoint(CVector @point,CVector? @storedPoint,NativePointer<float> @storedAngle) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3598 >(3598)(@point.Pointer,@storedPoint?.Pointer ?? IntPtr.Zero,@storedAngle.Pointer); }
    public static void @Initialise() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3599 >(3599)(); }
    public static void @Load() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3600 >(3600)(); }
    public static void @OverrideNextRestart(CVector @point,float @angle) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3601 >(3601)(@point.Pointer,@angle); }
    public static void @Save() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3602 >(3602)(); }
    public static void @SetRespawnPointForDurationOfMission(CVector @point) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3603 >(3603)(@point.Pointer); }
}
