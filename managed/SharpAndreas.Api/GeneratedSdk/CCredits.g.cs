// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CCredits : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=1;
    public CCredits(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("CreditsStartTime")]
    public static int @CreditsStartTime { get => SdkMemory.Read<int >(new IntPtr(0xC6E978)); set { SdkMemory.Write(new IntPtr(0xC6E978),value); } }
    [NativeMember("bCreditsGoing")]
    public static bool @CreditsGoing { get => SdkMemory.Read<bool >(new IntPtr(0xC6E97C)); set { SdkMemory.Write(new IntPtr(0xC6E97C),value); } }
    public static void @Render() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2314 >(2314)(); }
    public static void @PrintCreditText(float @scaleX,float @scaleY,NativePointer<ushort> @text,NativePointer<uint> @position,float @currentOffset,bool @highlighted) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2315 >(2315)(@scaleX,@scaleY,@text.Pointer,@position.Pointer,@currentOffset,(@highlighted ? 1 : 0)); }
    public static void @PrintCreditSpace(float @spaceSize,NativePointer<uint> @position) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2316 >(2316)(@spaceSize,@position.Pointer); }
    public static void @RenderCredits() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2317 >(2317)(); }
    public static void @Start() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2318 >(2318)(); }
    public static void @Stop() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2319 >(2319)(); }
}
