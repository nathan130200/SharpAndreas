// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CustomSpecMapPipeMaterialData : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=8;
    public CustomSpecMapPipeMaterialData(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("specularity")]
    public float @Specularity { get => SdkMemory.Read<float >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("texture")]
    public NativePointer<IntPtr> @Texture { get => new NativePointer<IntPtr>(SdkMemory.Read<IntPtr>(Pointer+4)); set { SdkMemory.Write(Pointer+4,value.Pointer); } }
}
