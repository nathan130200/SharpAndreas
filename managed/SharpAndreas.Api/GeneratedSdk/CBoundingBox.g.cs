// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CBoundingBox : CBox
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=24;
    public CBoundingBox(System.IntPtr pointer) : base(pointer) {}
    public void @InitializeAt() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D318 >(318)(Pointer); }
}
