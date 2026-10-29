// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class RpLight : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=64;
    public RpLight(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("object")]
    public RwObjectHasFrame @Object { get => new RwObjectHasFrame(Pointer+0); set { SdkMemory.Copy(value.Pointer,Pointer+0,20); } }
    [NativeMember("radius")]
    public float @Radius { get => SdkMemory.Read<float >(Pointer+20); set { SdkMemory.Write(Pointer+20,value); } }
    [NativeMember("color")]
    public RwRGBAReal @Color { get => new RwRGBAReal(Pointer+24); set { SdkMemory.Copy(value.Pointer,Pointer+24,16); } }
    [NativeMember("minusCosAngle")]
    public float @MinusCosAngle { get => SdkMemory.Read<float >(Pointer+40); set { SdkMemory.Write(Pointer+40,value); } }
    [NativeMember("WorldSectorsInLight")]
    public RwLinkList @WorldSectorsInLight { get => new RwLinkList(Pointer+44); set { SdkMemory.Copy(value.Pointer,Pointer+44,8); } }
    [NativeMember("inWorld")]
    public RwLLLink @InWorld { get => new RwLLLink(Pointer+52); set { SdkMemory.Copy(value.Pointer,Pointer+52,8); } }
    [NativeMember("lightFrame")]
    public ushort @LightFrame { get => SdkMemory.Read<ushort >(Pointer+60); set { SdkMemory.Write(Pointer+60,value); } }
    [NativeMember("pad")]
    public ushort @Pad { get => SdkMemory.Read<ushort >(Pointer+62); set { SdkMemory.Write(Pointer+62,value); } }
}
