// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CProjectile : CObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=380;
    public CProjectile(System.IntPtr pointer) : base(pointer) {}
    public void @InitializeAt(int @index) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3540 >(3540)(Pointer,@index); }
}
