// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CStreamedScripts___unnamed__at_D__plugin_sdk_plugin_sa_game_sa_CStream_be0d4b57d8 : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=32;
    public CStreamedScripts___unnamed__at_D__plugin_sdk_plugin_sa_game_sa_CStream_be0d4b57d8(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("data")]
    public NativePointer<IntPtr> @Data { get => new NativePointer<IntPtr>(SdkMemory.Read<IntPtr>(Pointer+0)); set { SdkMemory.Write(Pointer+0,value.Pointer); } }
    [NativeMember("m_nStatus")]
    public sbyte @Status { get => SdkMemory.Read<sbyte >(Pointer+4); set { SdkMemory.Write(Pointer+4,value); } }
    [NativeMember("field_5")]
    public sbyte @Field5 { get => SdkMemory.Read<sbyte >(Pointer+5); set { SdkMemory.Write(Pointer+5,value); } }
    [NativeMember("m_nScmIndex")]
    public short @ScmIndex { get => SdkMemory.Read<short >(Pointer+6); set { SdkMemory.Write(Pointer+6,value); } }
    [NativeMember("m_Name")]
    public NativeArray<sbyte> @Name { get => new NativeArray<sbyte>(Pointer+8,20); }
    [NativeMember("m_nsize")]
    public int @Nsize { get => SdkMemory.Read<int >(Pointer+28); set { SdkMemory.Write(Pointer+28,value); } }
}
