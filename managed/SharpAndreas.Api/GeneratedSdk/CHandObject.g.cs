// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CHandObject : CObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=396;
    public CHandObject(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_pPed")]
    public CPed? @Ped { get => SdkMemory.Read<IntPtr>(Pointer+380) == IntPtr.Zero ? null : new CPed(SdkMemory.Read<IntPtr>(Pointer+380)); set { SdkMemory.Write(Pointer+380,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_nBoneIndex")]
    public uint @BoneIndex { get => SdkMemory.Read<uint >(Pointer+384); set { SdkMemory.Write(Pointer+384,value); } }
    [NativeMember("m_pTexture")]
    public RwTexture? @Texture { get => SdkMemory.Read<IntPtr>(Pointer+388) == IntPtr.Zero ? null : new RwTexture(SdkMemory.Read<IntPtr>(Pointer+388)); set { SdkMemory.Write(Pointer+388,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_bUpdatedMatricesArray")]
    public bool @UpdatedMatricesArray { get => SdkMemory.Read<bool >(Pointer+392); set { SdkMemory.Write(Pointer+392,value); } }
}
