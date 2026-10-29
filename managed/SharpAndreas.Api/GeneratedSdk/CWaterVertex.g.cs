// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CWaterVertex : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=20;
    public CWaterVertex(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("x")]
    public short @X { get => SdkMemory.Read<short >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("y")]
    public short @Y { get => SdkMemory.Read<short >(Pointer+2); set { SdkMemory.Write(Pointer+2,value); } }
    [NativeMember("rp")]
    public CRenPar @Rp { get => new CRenPar(Pointer+4); set { SdkMemory.Copy(value.Pointer,Pointer+4,16); } }
}
