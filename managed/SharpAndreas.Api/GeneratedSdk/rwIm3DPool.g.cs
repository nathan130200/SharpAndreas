// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class rwIm3DPool : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=60;
    public rwIm3DPool(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("numElements")]
    public ushort @CountElements { get => SdkMemory.Read<ushort >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("pad")]
    public ushort @Pad { get => SdkMemory.Read<ushort >(Pointer+2); set { SdkMemory.Write(Pointer+2,value); } }
    [NativeMember("elements")]
    public NativePointer<IntPtr> @Elements { get => new NativePointer<IntPtr>(SdkMemory.Read<IntPtr>(Pointer+4)); set { SdkMemory.Write(Pointer+4,value.Pointer); } }
    [NativeMember("stride")]
    public int @Stride { get => SdkMemory.Read<int >(Pointer+8); set { SdkMemory.Write(Pointer+8,value); } }
    [NativeMember("stash")]
    public _rwIm3DPoolStash @Stash { get => new _rwIm3DPoolStash(Pointer+12); set { SdkMemory.Copy(value.Pointer,Pointer+12,48); } }
}
