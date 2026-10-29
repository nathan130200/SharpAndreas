// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CTaskComplexCopInCar : CTaskComplex
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=52;
    public CTaskComplexCopInCar(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_pVehicle")]
    public CVehicle? @Vehicle { get => SdkMemory.Read<IntPtr>(Pointer+12) == IntPtr.Zero ? null : new CVehicle(SdkMemory.Read<IntPtr>(Pointer+12)); set { SdkMemory.Write(Pointer+12,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_pCop1")]
    public CPed? @Cop1 { get => SdkMemory.Read<IntPtr>(Pointer+16) == IntPtr.Zero ? null : new CPed(SdkMemory.Read<IntPtr>(Pointer+16)); set { SdkMemory.Write(Pointer+16,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_pCop2")]
    public CPed? @Cop2 { get => SdkMemory.Read<IntPtr>(Pointer+20) == IntPtr.Zero ? null : new CPed(SdkMemory.Read<IntPtr>(Pointer+20)); set { SdkMemory.Write(Pointer+20,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_timer1")]
    public CTaskTimer @Timer1 { get => new CTaskTimer(Pointer+24); set { SdkMemory.Copy(value.Pointer,Pointer+24,12); } }
    [NativeMember("m_timer2")]
    public CTaskTimer @Timer2 { get => new CTaskTimer(Pointer+36); set { SdkMemory.Copy(value.Pointer,Pointer+36,12); } }
    [NativeMember("m_nFlags")]
    public byte @Flags { get => SdkMemory.Read<byte >(Pointer+48); set { SdkMemory.Write(Pointer+48,value); } }
    [NativeMember("__flags")]
    public NativeArray<sbyte> @FlagsValue { get => new NativeArray<sbyte>(Pointer+49,3); }
    public void @InitializeAt(CVehicle? @pVeh,CPed? @pCop1,CPed? @pCop2,bool @arg3) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4004 >(4004)(Pointer,@pVeh?.Pointer ?? IntPtr.Zero,@pCop1?.Pointer ?? IntPtr.Zero,@pCop2?.Pointer ?? IntPtr.Zero,(@arg3 ? 1 : 0)); }
}
