// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class RpCollTree : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=40;
    public RpCollTree(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("flags")]
    public uint @Flags { get => SdkMemory.Read<uint >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("bbox")]
    public RwBBox @Bbox { get => new RwBBox(Pointer+4); set { SdkMemory.Copy(value.Pointer,Pointer+4,24); } }
    [NativeMember("numEntries")]
    public ushort @CountEntries { get => SdkMemory.Read<ushort >(Pointer+28); set { SdkMemory.Write(Pointer+28,value); } }
    [NativeMember("numSplits")]
    public ushort @CountSplits { get => SdkMemory.Read<ushort >(Pointer+30); set { SdkMemory.Write(Pointer+30,value); } }
    [NativeMember("splits")]
    public RpCollSplit? @Splits { get => SdkMemory.Read<IntPtr>(Pointer+32) == IntPtr.Zero ? null : new RpCollSplit(SdkMemory.Read<IntPtr>(Pointer+32)); set { SdkMemory.Write(Pointer+32,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("map")]
    public NativePointer<ushort> @Map { get => new NativePointer<ushort>(SdkMemory.Read<IntPtr>(Pointer+36)); set { SdkMemory.Write(Pointer+36,value.Pointer); } }
}
