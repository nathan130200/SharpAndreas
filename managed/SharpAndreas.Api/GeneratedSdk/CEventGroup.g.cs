// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CEventGroup : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=76;
    public CEventGroup(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_pPed")]
    public CPed? @Ped { get => SdkMemory.Read<IntPtr>(Pointer+4) == IntPtr.Zero ? null : new CPed(SdkMemory.Read<IntPtr>(Pointer+4)); set { SdkMemory.Write(Pointer+4,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_dwCount")]
    public uint @Count { get => SdkMemory.Read<uint >(Pointer+8); set { SdkMemory.Write(Pointer+8,value); } }
    [NativeMember("m_apEvents")]
    public NativeArray<IntPtr> @Events { get => new NativeArray<IntPtr>(Pointer+12,16); }
}
