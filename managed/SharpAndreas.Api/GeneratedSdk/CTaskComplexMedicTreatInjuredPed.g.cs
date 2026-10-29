// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CTaskComplexMedicTreatInjuredPed : CTaskComplex
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=12;
    public CTaskComplexMedicTreatInjuredPed(System.IntPtr pointer) : base(pointer) {}
    public void @InitializeAt(CVehicle? @pAmbulance,CPed? @pMedic,bool @isPassenger) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4020 >(4020)(Pointer,@pAmbulance?.Pointer ?? IntPtr.Zero,@pMedic?.Pointer ?? IntPtr.Zero,(@isPassenger ? 1 : 0)); }
}
