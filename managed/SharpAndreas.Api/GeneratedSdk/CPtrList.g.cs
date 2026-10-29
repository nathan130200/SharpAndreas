// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CPtrList : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=4;
    public CPtrList(System.IntPtr pointer) : base(pointer) {}
    public CPtrNode? @GetNode() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D883 >(883)(Pointer); return __sdkResult == IntPtr.Zero ? null : new CPtrNode(__sdkResult); }
    public void @InitializeAt() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D884 >(884)(Pointer); }
    public uint @CountElements() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D885 >(885)(Pointer); return __sdkResult; }
    public bool @IsMemberOfList(NativePointer<IntPtr> @memberNode) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D886 >(886)(Pointer,@memberNode.Pointer); return __sdkResult != 0; }
}
