// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CCamera___unnamed__at_D__plugin_sdk_plugin_sa_game_sa_CCamera_h_298_5__1263a4fca1 : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=16;
    public CCamera___unnamed__at_D__plugin_sdk_plugin_sa_game_sa_CCamera_h_298_5__1263a4fca1(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_nModelIndex")]
    public int @ModelIndex { get => SdkMemory.Read<int >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("m_fDistance")]
    public float @Distance { get => SdkMemory.Read<float >(Pointer+4); set { SdkMemory.Write(Pointer+4,value); } }
    [NativeMember("m_fAltitude")]
    public float @Altitude { get => SdkMemory.Read<float >(Pointer+8); set { SdkMemory.Write(Pointer+8,value); } }
    [NativeMember("m_fAngle")]
    public float @Angle { get => SdkMemory.Read<float >(Pointer+12); set { SdkMemory.Write(Pointer+12,value); } }
}
