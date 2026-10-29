// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class RpHAnimAtomicGlobalVars : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=8;
    public RpHAnimAtomicGlobalVars(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("engineOffset")]
    public int @EngineOffset { get => SdkMemory.Read<int >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("HAnimFreeList")]
    public RwFreeList? @HAnimFreeList { get => SdkMemory.Read<IntPtr>(Pointer+4) == IntPtr.Zero ? null : new RwFreeList(SdkMemory.Read<IntPtr>(Pointer+4)); set { SdkMemory.Write(Pointer+4,value?.Pointer ?? IntPtr.Zero); } }
}
