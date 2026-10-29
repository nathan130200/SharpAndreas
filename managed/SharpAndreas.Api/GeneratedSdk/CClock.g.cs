// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CClock : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=1;
    public CClock(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("daysInMonth")]
    public static NativeArray<byte> @DaysInMonth { get => new NativeArray<byte>(new IntPtr(0x8CCF24),12); }
    [NativeMember("bClockHasBeenStored")]
    public static bool @ClockHasBeenStored { get => SdkMemory.Read<bool >(new IntPtr(0xB70144)); set { SdkMemory.Write(new IntPtr(0xB70144),value); } }
    [NativeMember("ms_Stored_nGameClockSeconds")]
    public static ushort @StoredNGameClockSeconds { get => SdkMemory.Read<ushort >(new IntPtr(0xB70148)); set { SdkMemory.Write(new IntPtr(0xB70148),value); } }
    [NativeMember("ms_Stored_nGameClockMinutes")]
    public static byte @StoredNGameClockMinutes { get => SdkMemory.Read<byte >(new IntPtr(0xB7014A)); set { SdkMemory.Write(new IntPtr(0xB7014A),value); } }
    [NativeMember("ms_Stored_nGameClockHours")]
    public static byte @StoredNGameClockHours { get => SdkMemory.Read<byte >(new IntPtr(0xB7014B)); set { SdkMemory.Write(new IntPtr(0xB7014B),value); } }
    [NativeMember("ms_Stored_nGameClockDays")]
    public static byte @StoredNGameClockDays { get => SdkMemory.Read<byte >(new IntPtr(0xB7014C)); set { SdkMemory.Write(new IntPtr(0xB7014C),value); } }
    [NativeMember("ms_Stored_nGameClockMonths")]
    public static byte @StoredNGameClockMonths { get => SdkMemory.Read<byte >(new IntPtr(0xB7014D)); set { SdkMemory.Write(new IntPtr(0xB7014D),value); } }
    [NativeMember("CurrentDay")]
    public static byte @CurrentDay { get => SdkMemory.Read<byte >(new IntPtr(0xB7014E)); set { SdkMemory.Write(new IntPtr(0xB7014E),value); } }
    [NativeMember("ms_nGameClockSeconds")]
    public static ushort @GameClockSeconds { get => SdkMemory.Read<ushort >(new IntPtr(0xB70150)); set { SdkMemory.Write(new IntPtr(0xB70150),value); } }
    [NativeMember("ms_nGameClockMinutes")]
    public static byte @GameClockMinutes { get => SdkMemory.Read<byte >(new IntPtr(0xB70152)); set { SdkMemory.Write(new IntPtr(0xB70152),value); } }
    [NativeMember("ms_nGameClockHours")]
    public static byte @GameClockHours { get => SdkMemory.Read<byte >(new IntPtr(0xB70153)); set { SdkMemory.Write(new IntPtr(0xB70153),value); } }
    [NativeMember("ms_nGameClockDays")]
    public static byte @GameClockDays { get => SdkMemory.Read<byte >(new IntPtr(0xB70154)); set { SdkMemory.Write(new IntPtr(0xB70154),value); } }
    [NativeMember("ms_nGameClockMonth")]
    public static byte @GameClockMonth { get => SdkMemory.Read<byte >(new IntPtr(0xB70155)); set { SdkMemory.Write(new IntPtr(0xB70155),value); } }
    [NativeMember("ms_nLastClockTick")]
    public static uint @LastClockTick { get => SdkMemory.Read<uint >(new IntPtr(0xB70158)); set { SdkMemory.Write(new IntPtr(0xB70158),value); } }
    [NativeMember("ms_nMillisecondsPerGameMinute")]
    public static uint @MillisecondsPerGameMinute { get => SdkMemory.Read<uint >(new IntPtr(0xB7015C)); set { SdkMemory.Write(new IntPtr(0xB7015C),value); } }
    public static ushort @GetGameClockMinutesUntil(byte @hours,byte @minutes) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1982 >(1982)(@hours,@minutes); return __sdkResult; }
    public static bool @GetIsTimeInRange(byte @hourA,byte @hourB) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1983 >(1983)(@hourA,@hourB); return __sdkResult != 0; }
    public static void @Initialise(uint @milisecondsPerGameMinute) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1984 >(1984)(@milisecondsPerGameMinute); }
    public static void @NormaliseGameClock() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1985 >(1985)(); }
    public static void @OffsetClockByADay(uint @timeDirection) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1986 >(1986)(@timeDirection); }
    public static void @RestoreClock() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1987 >(1987)(); }
    public static void @SetGameClock(byte @hours,byte @minutes,byte @day) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1988 >(1988)(@hours,@minutes,@day); }
    public static void @StoreClock() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1989 >(1989)(); }
    public static void @Update() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1990 >(1990)(); }
}
