// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CUpsideDownCarCheck___unnamed__at_D__plugin_sdk_plugin_sa_game_sa_CUps_747651c732 : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=8;
    public CUpsideDownCarCheck___unnamed__at_D__plugin_sdk_plugin_sa_game_sa_CUps_747651c732(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_nCarHandle")]
    public int @CarHandle { get => SdkMemory.Read<int >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("field_4")]
    public int @Field4 { get => SdkMemory.Read<int >(Pointer+4); set { SdkMemory.Write(Pointer+4,value); } }
}
