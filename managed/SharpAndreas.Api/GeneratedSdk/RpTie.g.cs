// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class RpTie : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=24;
    public RpTie(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("lAtomicInWorldSector")]
    public RwLLLink @LAtomicInWorldSector { get => new RwLLLink(Pointer+0); set { SdkMemory.Copy(value.Pointer,Pointer+0,8); } }
    [NativeMember("apAtom")]
    public RpAtomic? @Atom { get => SdkMemory.Read<IntPtr>(Pointer+8) == IntPtr.Zero ? null : new RpAtomic(SdkMemory.Read<IntPtr>(Pointer+8)); set { SdkMemory.Write(Pointer+8,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("lWorldSectorInAtomic")]
    public RwLLLink @LWorldSectorInAtomic { get => new RwLLLink(Pointer+12); set { SdkMemory.Copy(value.Pointer,Pointer+12,8); } }
    [NativeMember("worldSector")]
    public RpWorldSector? @WorldSector { get => SdkMemory.Read<IntPtr>(Pointer+20) == IntPtr.Zero ? null : new RpWorldSector(SdkMemory.Read<IntPtr>(Pointer+20)); set { SdkMemory.Write(Pointer+20,value?.Pointer ?? IntPtr.Zero); } }
}
