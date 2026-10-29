// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CTaskComplexKillPedFromBoat : CTaskComplex
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=16;
    public CTaskComplexKillPedFromBoat(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("pPed")]
    public CPed? @Ped { get => SdkMemory.Read<IntPtr>(Pointer+12) == IntPtr.Zero ? null : new CPed(SdkMemory.Read<IntPtr>(Pointer+12)); set { SdkMemory.Write(Pointer+12,value?.Pointer ?? IntPtr.Zero); } }
    public void @InitializeAt(CPed? @ped) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4017 >(4017)(Pointer,@ped?.Pointer ?? IntPtr.Zero); }
}
