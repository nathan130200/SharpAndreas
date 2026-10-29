// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class tDirectionArrow : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=48;
    public tDirectionArrow(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_bIsUsed")]
    public bool @IsUsed { get => SdkMemory.Read<bool >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("m_vecPosition")]
    public CVector @Position { get => new CVector(Pointer+4); set { SdkMemory.Copy(value.Pointer,Pointer+4,12); } }
    [NativeMember("m_fSize")]
    public float @Size { get => SdkMemory.Read<float >(Pointer+16); set { SdkMemory.Write(Pointer+16,value); } }
    [NativeMember("m_vecDirection")]
    public CVector @Direction { get => new CVector(Pointer+20); set { SdkMemory.Copy(value.Pointer,Pointer+20,12); } }
    [NativeMember("m_nRed")]
    public uint @Red { get => SdkMemory.Read<uint >(Pointer+32); set { SdkMemory.Write(Pointer+32,value); } }
    [NativeMember("m_nGreen")]
    public uint @Green { get => SdkMemory.Read<uint >(Pointer+36); set { SdkMemory.Write(Pointer+36,value); } }
    [NativeMember("m_nBlue")]
    public uint @Blue { get => SdkMemory.Read<uint >(Pointer+40); set { SdkMemory.Write(Pointer+40,value); } }
    [NativeMember("m_nAlpha")]
    public uint @Alpha { get => SdkMemory.Read<uint >(Pointer+44); set { SdkMemory.Write(Pointer+44,value); } }
}
