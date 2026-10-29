// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CPlantColEntEntry : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=20;
    public CPlantColEntEntry(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_pEntity")]
    public CEntity? @Entity { get => SdkMemory.Read<IntPtr>(Pointer+0) == IntPtr.Zero ? null : new CEntity(SdkMemory.Read<IntPtr>(Pointer+0)); set { SdkMemory.Write(Pointer+0,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_LocTriArray")]
    public NativePointer<IntPtr> @LocTriArray { get => new NativePointer<IntPtr>(SdkMemory.Read<IntPtr>(Pointer+4)); set { SdkMemory.Write(Pointer+4,value.Pointer); } }
    [NativeMember("m_nNumTris")]
    public ushort @CountTris { get => SdkMemory.Read<ushort >(Pointer+8); set { SdkMemory.Write(Pointer+8,value); } }
    [NativeMember("m_pNextEntry")]
    public CPlantColEntEntry? @NextEntry { get => SdkMemory.Read<IntPtr>(Pointer+12) == IntPtr.Zero ? null : new CPlantColEntEntry(SdkMemory.Read<IntPtr>(Pointer+12)); set { SdkMemory.Write(Pointer+12,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_pPrevEntry")]
    public CPlantColEntEntry? @PrevEntry { get => SdkMemory.Read<IntPtr>(Pointer+16) == IntPtr.Zero ? null : new CPlantColEntEntry(SdkMemory.Read<IntPtr>(Pointer+16)); set { SdkMemory.Write(Pointer+16,value?.Pointer ?? IntPtr.Zero); } }
}
