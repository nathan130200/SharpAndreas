// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CDamageAtomicModelInfo : CAtomicModelInfo
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=36;
    public CDamageAtomicModelInfo(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_pDamagedAtomic")]
    public RpAtomic? @DamagedAtomic { get => SdkMemory.Read<IntPtr>(Pointer+32) == IntPtr.Zero ? null : new RpAtomic(SdkMemory.Read<IntPtr>(Pointer+32)); set { SdkMemory.Write(Pointer+32,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("ms_bCreateDamagedVersion")]
    public static bool @CreateDamagedVersion { get => SdkMemory.Read<bool >(new IntPtr(0xA9B0B0)); set { SdkMemory.Write(new IntPtr(0xA9B0B0),value); } }
}
