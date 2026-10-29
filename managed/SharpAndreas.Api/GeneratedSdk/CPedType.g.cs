// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CPedType : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=1;
    public CPedType(System.IntPtr pointer) : base(pointer) {}
    public static void @Load() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3312 >(3312)(); }
    public static void @Save() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3313 >(3313)(); }
}
