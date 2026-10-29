// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class FxInfoManager_c : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=20;
    public FxInfoManager_c(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_nNumInfos")]
    public uint @CountInfos { get => SdkMemory.Read<uint >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("m_pInfos")]
    public NativePointer<IntPtr> @Infos { get => new NativePointer<IntPtr>(SdkMemory.Read<IntPtr>(Pointer+4)); set { SdkMemory.Write(Pointer+4,value.Pointer); } }
    [NativeMember("m_nFirstMovementInfo")]
    public byte @FirstMovementInfo { get => SdkMemory.Read<byte >(Pointer+8); set { SdkMemory.Write(Pointer+8,value); } }
    [NativeMember("m_nFirstRenderInfo")]
    public byte @FirstRenderInfo { get => SdkMemory.Read<byte >(Pointer+9); set { SdkMemory.Write(Pointer+9,value); } }
    [NativeMember("m_nLodStart")]
    public short @LodStart { get => SdkMemory.Read<short >(Pointer+12); set { SdkMemory.Write(Pointer+12,value); } }
    [NativeMember("m_nLodEnd")]
    public short @LodEnd { get => SdkMemory.Read<short >(Pointer+14); set { SdkMemory.Write(Pointer+14,value); } }
    [NativeMember("m_bHasFlatParticleEmitter")]
    public bool @HasFlatParticleEmitter { get => SdkMemory.Read<bool >(Pointer+16); set { SdkMemory.Write(Pointer+16,value); } }
    [NativeMember("m_bHasHeatHazeParticleEmitter")]
    public bool @HasHeatHazeParticleEmitter { get => SdkMemory.Read<bool >(Pointer+17); set { SdkMemory.Write(Pointer+17,value); } }
    [NativeMember("field_12")]
    public sbyte @Field12 { get => SdkMemory.Read<sbyte >(Pointer+18); set { SdkMemory.Write(Pointer+18,value); } }
    [NativeMember("field_13")]
    public sbyte @Field13 { get => SdkMemory.Read<sbyte >(Pointer+19); set { SdkMemory.Write(Pointer+19,value); } }
}
