// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CMouseControllerState : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=20;
    public CMouseControllerState(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("lmb")]
    public byte @Lmb { get => SdkMemory.Read<byte >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("rmb")]
    public byte @Rmb { get => SdkMemory.Read<byte >(Pointer+1); set { SdkMemory.Write(Pointer+1,value); } }
    [NativeMember("mmb")]
    public byte @Mmb { get => SdkMemory.Read<byte >(Pointer+2); set { SdkMemory.Write(Pointer+2,value); } }
    [NativeMember("wheelUp")]
    public byte @WheelUp { get => SdkMemory.Read<byte >(Pointer+3); set { SdkMemory.Write(Pointer+3,value); } }
    [NativeMember("wheelDown")]
    public byte @WheelDown { get => SdkMemory.Read<byte >(Pointer+4); set { SdkMemory.Write(Pointer+4,value); } }
    [NativeMember("bmx1")]
    public byte @Bmx1 { get => SdkMemory.Read<byte >(Pointer+5); set { SdkMemory.Write(Pointer+5,value); } }
    [NativeMember("bmx2")]
    public byte @Bmx2 { get => SdkMemory.Read<byte >(Pointer+6); set { SdkMemory.Write(Pointer+6,value); } }
    [NativeMember("__align")]
    public sbyte @Align { get => SdkMemory.Read<sbyte >(Pointer+7); set { SdkMemory.Write(Pointer+7,value); } }
    [NativeMember("z")]
    public float @Z { get => SdkMemory.Read<float >(Pointer+8); set { SdkMemory.Write(Pointer+8,value); } }
    [NativeMember("x")]
    public float @X { get => SdkMemory.Read<float >(Pointer+12); set { SdkMemory.Write(Pointer+12,value); } }
    [NativeMember("y")]
    public float @Y { get => SdkMemory.Read<float >(Pointer+16); set { SdkMemory.Write(Pointer+16,value); } }
}
