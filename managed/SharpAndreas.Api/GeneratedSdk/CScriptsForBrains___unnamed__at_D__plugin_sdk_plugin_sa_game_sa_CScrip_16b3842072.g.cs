// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CScriptsForBrains___unnamed__at_D__plugin_sdk_plugin_sa_game_sa_CScrip_16b3842072 : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=20;
    public CScriptsForBrains___unnamed__at_D__plugin_sdk_plugin_sa_game_sa_CScrip_16b3842072(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_nIMGindex")]
    public short @IMGindex { get => SdkMemory.Read<short >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("m_nAttachType")]
    public sbyte @AttachType { get => SdkMemory.Read<sbyte >(Pointer+2); set { SdkMemory.Write(Pointer+2,value); } }
    [NativeMember("m_nType")]
    public sbyte @Type { get => SdkMemory.Read<sbyte >(Pointer+3); set { SdkMemory.Write(Pointer+3,value); } }
    [NativeMember("Status")]
    public sbyte @Status { get => SdkMemory.Read<sbyte >(Pointer+4); set { SdkMemory.Write(Pointer+4,value); } }
    [NativeMember("Radius")]
    public float @Radius { get => SdkMemory.Read<float >(Pointer+8); set { SdkMemory.Write(Pointer+8,value); } }
    [NativeMember("m_nModelID")]
    public ushort @ModelID { get => SdkMemory.Read<ushort >(Pointer+12); set { SdkMemory.Write(Pointer+12,value); } }
    [NativeMember("m_nPriority")]
    public ushort @Priority { get => SdkMemory.Read<ushort >(Pointer+14); set { SdkMemory.Write(Pointer+14,value); } }
    [NativeMember("field_10")]
    public int @Field10 { get => SdkMemory.Read<int >(Pointer+16); set { SdkMemory.Write(Pointer+16,value); } }
}
