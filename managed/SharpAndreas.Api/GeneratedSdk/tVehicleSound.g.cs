// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class tVehicleSound : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=8;
    public tVehicleSound(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_nIndex")]
    public uint @Index { get => SdkMemory.Read<uint >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("m_pSound")]
    public CAESound? @Sound { get => SdkMemory.Read<IntPtr>(Pointer+4) == IntPtr.Zero ? null : new CAESound(SdkMemory.Read<IntPtr>(Pointer+4)); set { SdkMemory.Write(Pointer+4,value?.Pointer ?? IntPtr.Zero); } }
}
