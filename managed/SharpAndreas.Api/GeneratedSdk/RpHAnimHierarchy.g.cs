// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class RpHAnimHierarchy : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=36;
    public RpHAnimHierarchy(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("flags")]
    public int @Flags { get => SdkMemory.Read<int >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("numNodes")]
    public int @CountNodes { get => SdkMemory.Read<int >(Pointer+4); set { SdkMemory.Write(Pointer+4,value); } }
    [NativeMember("pMatrixArray")]
    public RwMatrixTag? @MatrixArray { get => SdkMemory.Read<IntPtr>(Pointer+8) == IntPtr.Zero ? null : new RwMatrixTag(SdkMemory.Read<IntPtr>(Pointer+8)); set { SdkMemory.Write(Pointer+8,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("pMatrixArrayUnaligned")]
    public NativePointer<IntPtr> @MatrixArrayUnaligned { get => new NativePointer<IntPtr>(SdkMemory.Read<IntPtr>(Pointer+12)); set { SdkMemory.Write(Pointer+12,value.Pointer); } }
    [NativeMember("pNodeInfo")]
    public RpHAnimNodeInfo? @NodeInfo { get => SdkMemory.Read<IntPtr>(Pointer+16) == IntPtr.Zero ? null : new RpHAnimNodeInfo(SdkMemory.Read<IntPtr>(Pointer+16)); set { SdkMemory.Write(Pointer+16,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("parentFrame")]
    public RwFrame? @ParentFrame { get => SdkMemory.Read<IntPtr>(Pointer+20) == IntPtr.Zero ? null : new RwFrame(SdkMemory.Read<IntPtr>(Pointer+20)); set { SdkMemory.Write(Pointer+20,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("parentHierarchy")]
    public RpHAnimHierarchy? @ParentHierarchy { get => SdkMemory.Read<IntPtr>(Pointer+24) == IntPtr.Zero ? null : new RpHAnimHierarchy(SdkMemory.Read<IntPtr>(Pointer+24)); set { SdkMemory.Write(Pointer+24,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("rootParentOffset")]
    public int @RootParentOffset { get => SdkMemory.Read<int >(Pointer+28); set { SdkMemory.Write(Pointer+28,value); } }
    [NativeMember("currentAnim")]
    public RtAnimInterpolator? @CurrentAnimation { get => SdkMemory.Read<IntPtr>(Pointer+32) == IntPtr.Zero ? null : new RtAnimInterpolator(SdkMemory.Read<IntPtr>(Pointer+32)); set { SdkMemory.Write(Pointer+32,value?.Pointer ?? IntPtr.Zero); } }
}
