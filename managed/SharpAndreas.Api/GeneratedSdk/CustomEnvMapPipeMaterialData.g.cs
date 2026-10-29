// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CustomEnvMapPipeMaterialData : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=12;
    public CustomEnvMapPipeMaterialData(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("scaleX")]
    public sbyte @ScaleX { get => SdkMemory.Read<sbyte >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("scaleY")]
    public sbyte @ScaleY { get => SdkMemory.Read<sbyte >(Pointer+1); set { SdkMemory.Write(Pointer+1,value); } }
    [NativeMember("transSclX")]
    public sbyte @TransSclX { get => SdkMemory.Read<sbyte >(Pointer+2); set { SdkMemory.Write(Pointer+2,value); } }
    [NativeMember("transSclY")]
    public sbyte @TransSclY { get => SdkMemory.Read<sbyte >(Pointer+3); set { SdkMemory.Write(Pointer+3,value); } }
    [NativeMember("shininess")]
    public sbyte @Shininess { get => SdkMemory.Read<sbyte >(Pointer+4); set { SdkMemory.Write(Pointer+4,value); } }
    [NativeMember("renderFrameCounter")]
    public short @RenderFrameCounter { get => SdkMemory.Read<short >(Pointer+6); set { SdkMemory.Write(Pointer+6,value); } }
    [NativeMember("texture")]
    public NativePointer<IntPtr> @Texture { get => new NativePointer<IntPtr>(SdkMemory.Read<IntPtr>(Pointer+8)); set { SdkMemory.Write(Pointer+8,value.Pointer); } }
}
