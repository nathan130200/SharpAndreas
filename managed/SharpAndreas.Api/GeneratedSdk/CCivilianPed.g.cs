// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CCivilianPed : CPed
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=1948;
    public CCivilianPed(System.IntPtr pointer) : base(pointer) {}
    public void @InitializeAt(ePedType @pedType,uint @modelIndex) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1981 >(1981)(Pointer,(int)@pedType,@modelIndex); }
}
