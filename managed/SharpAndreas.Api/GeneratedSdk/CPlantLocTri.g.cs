// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CPlantLocTri : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=84;
    public CPlantLocTri(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_V1")]
    public CVector @V1 { get => new CVector(Pointer+0); set { SdkMemory.Copy(value.Pointer,Pointer+0,12); } }
    [NativeMember("m_V2")]
    public CVector @V2 { get => new CVector(Pointer+12); set { SdkMemory.Copy(value.Pointer,Pointer+12,12); } }
    [NativeMember("m_V3")]
    public CVector @V3 { get => new CVector(Pointer+24); set { SdkMemory.Copy(value.Pointer,Pointer+24,12); } }
    [NativeMember("m_Center")]
    public CVector @Center { get => new CVector(Pointer+36); set { SdkMemory.Copy(value.Pointer,Pointer+36,12); } }
    [NativeMember("m_SphereRadius")]
    public float @SphereRadius { get => SdkMemory.Read<float >(Pointer+48); set { SdkMemory.Write(Pointer+48,value); } }
    [NativeMember("m_Seed")]
    public NativeArray<float> @Seed { get => new NativeArray<float>(Pointer+52,3); }
    [NativeMember("m_nMaxNumPlants")]
    public NativeArray<ushort> @MaxCountPlants { get => new NativeArray<ushort>(Pointer+64,3); }
    [NativeMember("m_nSurfaceType")]
    public byte @SurfaceType { get => SdkMemory.Read<byte >(Pointer+70); set { SdkMemory.Write(Pointer+70,value); } }
    [NativeMember("m_nLighting")]
    public byte @Lighting { get => SdkMemory.Read<byte >(Pointer+71); set { SdkMemory.Write(Pointer+71,value); } }
    [NativeMember("m_createsPlants")]
    public byte @CreatesPlants { get => (byte)SdkMemory.ReadBits(Pointer,576,1); set { SdkMemory.WriteBits(Pointer,576,1,unchecked((ulong)value)); } }
    [NativeMember("m_createsObjects")]
    public byte @CreatesObjects { get => (byte)SdkMemory.ReadBits(Pointer,577,1); set { SdkMemory.WriteBits(Pointer,577,1,unchecked((ulong)value)); } }
    [NativeMember("m_createdObjects")]
    public byte @CreatedObjects { get => (byte)SdkMemory.ReadBits(Pointer,578,1); set { SdkMemory.WriteBits(Pointer,578,1,unchecked((ulong)value)); } }
    [NativeMember("m_pad")]
    public byte @Pad { get => (byte)SdkMemory.ReadBits(Pointer,579,5); set { SdkMemory.WriteBits(Pointer,579,5,unchecked((ulong)value)); } }
    [NativeMember("m_pNextTri")]
    public CPlantLocTri? @NextTri { get => SdkMemory.Read<IntPtr>(Pointer+76) == IntPtr.Zero ? null : new CPlantLocTri(SdkMemory.Read<IntPtr>(Pointer+76)); set { SdkMemory.Write(Pointer+76,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_pPrevTri")]
    public CPlantLocTri? @PrevTri { get => SdkMemory.Read<IntPtr>(Pointer+80) == IntPtr.Zero ? null : new CPlantLocTri(SdkMemory.Read<IntPtr>(Pointer+80)); set { SdkMemory.Write(Pointer+80,value?.Pointer ?? IntPtr.Zero); } }
}
