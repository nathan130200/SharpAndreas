// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CTimeCycleBox : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=40;
    public CTimeCycleBox(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("box")]
    public CBox @Box { get => new CBox(Pointer+0); set { SdkMemory.Copy(value.Pointer,Pointer+0,24); } }
    [NativeMember("farclip")]
    public short @Farclip { get => SdkMemory.Read<short >(Pointer+24); set { SdkMemory.Write(Pointer+24,value); } }
    [NativeMember("lodDistMult")]
    public byte @LodDistanceMult { get => SdkMemory.Read<byte >(Pointer+26); set { SdkMemory.Write(Pointer+26,value); } }
    [NativeMember("extraColor")]
    public int @ExtraColor { get => SdkMemory.Read<int >(Pointer+28); set { SdkMemory.Write(Pointer+28,value); } }
    [NativeMember("strength")]
    public float @Strength { get => SdkMemory.Read<float >(Pointer+32); set { SdkMemory.Write(Pointer+32,value); } }
    [NativeMember("falloff")]
    public float @Falloff { get => SdkMemory.Read<float >(Pointer+36); set { SdkMemory.Write(Pointer+36,value); } }
}
