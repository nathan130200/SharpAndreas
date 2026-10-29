// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CTagManager : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=1;
    public CTagManager(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("MAX_TAGS")]
    public static uint @MAXTAGS { get => SdkMemory.Read<uint >(SdkBindings.Address(4656)); }
    public static void @Save() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3995 >(3995)(); }
    public static void @Load() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3996 >(3996)(); }
}
