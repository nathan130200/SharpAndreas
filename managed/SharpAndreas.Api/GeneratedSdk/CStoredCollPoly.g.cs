// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CStoredCollPoly : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=44;
    public CStoredCollPoly(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_aMeshVertices")]
    public NativeObjectArray<CVector> @MeshVertices { get => new NativeObjectArray<CVector>(Pointer+0,3,12); }
    [NativeMember("m_bIsActual")]
    public bool @IsActual { get => SdkMemory.Read<bool >(Pointer+36); set { SdkMemory.Write(Pointer+36,value); } }
    [NativeMember("m_nLighting")]
    public uint @Lighting { get => SdkMemory.Read<uint >(Pointer+40); set { SdkMemory.Write(Pointer+40,value); } }
}
