// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class tEffectPedAttractor : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=48;
    public tEffectPedAttractor(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_vecQueueDir")]
    public RwV3d @QueueDirection { get => new RwV3d(Pointer+0); set { SdkMemory.Copy(value.Pointer,Pointer+0,12); } }
    [NativeMember("m_vecUseDir")]
    public RwV3d @UseDirection { get => new RwV3d(Pointer+12); set { SdkMemory.Copy(value.Pointer,Pointer+12,12); } }
    [NativeMember("m_vecForwardDir")]
    public RwV3d @ForwardDirection { get => new RwV3d(Pointer+24); set { SdkMemory.Copy(value.Pointer,Pointer+24,12); } }
    [NativeMember("m_nAttractorType")]
    public byte @AttractorType { get => SdkMemory.Read<byte >(Pointer+36); set { SdkMemory.Write(Pointer+36,value); } }
    [NativeMember("m_nPedExistingProbability")]
    public byte @PedExistingProbability { get => SdkMemory.Read<byte >(Pointer+37); set { SdkMemory.Write(Pointer+37,value); } }
    [NativeMember("field_36")]
    public sbyte @Field36 { get => SdkMemory.Read<sbyte >(Pointer+38); set { SdkMemory.Write(Pointer+38,value); } }
    [NativeMember("m_nFlags")]
    public byte @Flags { get => SdkMemory.Read<byte >(Pointer+39); set { SdkMemory.Write(Pointer+39,value); } }
    [NativeMember("m_szScriptName")]
    public NativeArray<sbyte> @ScriptName { get => new NativeArray<sbyte>(Pointer+40,8); }
}
