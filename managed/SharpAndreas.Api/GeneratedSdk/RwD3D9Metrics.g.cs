// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class RwD3D9Metrics : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=24;
    public RwD3D9Metrics(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("numRenderStateChanges")]
    public uint @CountRenderStateChanges { get => SdkMemory.Read<uint >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("numTextureStageStateChanges")]
    public uint @CountTextureStageStateChanges { get => SdkMemory.Read<uint >(Pointer+4); set { SdkMemory.Write(Pointer+4,value); } }
    [NativeMember("numSamplerStageStateChanges")]
    public uint @CountSamplerStageStateChanges { get => SdkMemory.Read<uint >(Pointer+8); set { SdkMemory.Write(Pointer+8,value); } }
    [NativeMember("numMaterialChanges")]
    public uint @CountMaterialChanges { get => SdkMemory.Read<uint >(Pointer+12); set { SdkMemory.Write(Pointer+12,value); } }
    [NativeMember("numLightsChanged")]
    public uint @CountLightsChanged { get => SdkMemory.Read<uint >(Pointer+16); set { SdkMemory.Write(Pointer+16,value); } }
    [NativeMember("numVBSwitches")]
    public uint @CountVBSwitches { get => SdkMemory.Read<uint >(Pointer+20); set { SdkMemory.Write(Pointer+20,value); } }
}
