// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CScriptResourceManager___unnamed__at_D__plugin_sdk_plugin_sa_game_sa_C_462fc3ef09 : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=12;
    public CScriptResourceManager___unnamed__at_D__plugin_sdk_plugin_sa_game_sa_C_462fc3ef09(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_nModelId")]
    public int @ModelId { get => SdkMemory.Read<int >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("m_pThread")]
    public NativePointer<IntPtr> @Thread { get => new NativePointer<IntPtr>(SdkMemory.Read<IntPtr>(Pointer+4)); set { SdkMemory.Write(Pointer+4,value.Pointer); } }
    [NativeMember("type")]
    public ushort @Type { get => SdkMemory.Read<ushort >(Pointer+8); set { SdkMemory.Write(Pointer+8,value); } }
}
