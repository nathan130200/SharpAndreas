// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class rpMeshGlobals : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=48;
    public rpMeshGlobals(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("nextSerialNum")]
    public short @NextSerialCount { get => SdkMemory.Read<short >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("triStripListEntryFreeList")]
    public RwFreeList? @TriStripListEntryFreeList { get => SdkMemory.Read<IntPtr>(Pointer+4) == IntPtr.Zero ? null : new RwFreeList(SdkMemory.Read<IntPtr>(Pointer+4)); set { SdkMemory.Write(Pointer+4,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("meshFlagsToPrimType")]
    public NativeArray<byte> @MeshFlagsToPrimType { get => new NativeArray<byte>(Pointer+8,31); }
    [NativeMember("primTypeToMeshFlags")]
    public NativeArray<byte> @PrimTypeToMeshFlags { get => new NativeArray<byte>(Pointer+39,7); }
}
