// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class tBuildingSwap : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=12;
    public tBuildingSwap(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_pCBuilding")]
    public CBuilding? @CBuilding { get => SdkMemory.Read<IntPtr>(Pointer+0) == IntPtr.Zero ? null : new CBuilding(SdkMemory.Read<IntPtr>(Pointer+0)); set { SdkMemory.Write(Pointer+0,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_nOldModelIndex")]
    public int @OldModelIndex { get => SdkMemory.Read<int >(Pointer+4); set { SdkMemory.Write(Pointer+4,value); } }
    [NativeMember("m_nNewModelIndex")]
    public int @NewModelIndex { get => SdkMemory.Read<int >(Pointer+8); set { SdkMemory.Write(Pointer+8,value); } }
}
