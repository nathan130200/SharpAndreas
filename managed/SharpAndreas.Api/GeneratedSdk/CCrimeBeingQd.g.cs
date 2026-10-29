// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CCrimeBeingQd : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=28;
    public CCrimeBeingQd(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_nCrimeType")]
    public uint @CrimeType { get => SdkMemory.Read<uint >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("m_nCrimeID")]
    public uint @CrimeID { get => SdkMemory.Read<uint >(Pointer+4); set { SdkMemory.Write(Pointer+4,value); } }
    [NativeMember("m_nTimeOfQing")]
    public uint @TimeOfQing { get => SdkMemory.Read<uint >(Pointer+8); set { SdkMemory.Write(Pointer+8,value); } }
    [NativeMember("m_vecCoors")]
    public CVector @Coors { get => new CVector(Pointer+12); set { SdkMemory.Copy(value.Pointer,Pointer+12,12); } }
    [NativeMember("m_bAlreadyReported")]
    public bool @AlreadyReported { get => SdkMemory.Read<bool >(Pointer+24); set { SdkMemory.Write(Pointer+24,value); } }
    [NativeMember("m_bPoliceDontReallyCare")]
    public bool @PoliceDontReallyCare { get => SdkMemory.Read<bool >(Pointer+25); set { SdkMemory.Write(Pointer+25,value); } }
}
