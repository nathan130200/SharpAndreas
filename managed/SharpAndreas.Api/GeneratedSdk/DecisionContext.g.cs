// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class DecisionContext : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=2;
    public DecisionContext(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("onFoot")]
    public bool @OnFoot { get => SdkMemory.Read<bool >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("inVehicle")]
    public bool @InVehicle { get => SdkMemory.Read<bool >(Pointer+1); set { SdkMemory.Write(Pointer+1,value); } }
    public void @InitializeAt() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1254 >(1254)(Pointer); }
    public void @InitializeAt(bool @onFoot,bool @inVehicle) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1255 >(1255)(Pointer,(@onFoot ? 1 : 0),(@inVehicle ? 1 : 0)); }
}
