// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CStuckCarCheck___unnamed__at_D__plugin_sdk_plugin_sa_game_sa_CStuckCar_15c17bac6a : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=36;
    public CStuckCarCheck___unnamed__at_D__plugin_sdk_plugin_sa_game_sa_CStuckCar_15c17bac6a(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_nCarHandle")]
    public int @CarHandle { get => SdkMemory.Read<int >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("m_vCarPos")]
    public CVector @CarPosition { get => new CVector(Pointer+4); set { SdkMemory.Copy(value.Pointer,Pointer+4,12); } }
    [NativeMember("m_nStartTime")]
    public int @StartTime { get => SdkMemory.Read<int >(Pointer+16); set { SdkMemory.Write(Pointer+16,value); } }
    [NativeMember("m_fDistance")]
    public float @Distance { get => SdkMemory.Read<float >(Pointer+20); set { SdkMemory.Write(Pointer+20,value); } }
    [NativeMember("m_nTime")]
    public int @Time { get => SdkMemory.Read<int >(Pointer+24); set { SdkMemory.Write(Pointer+24,value); } }
    [NativeMember("m_bCarStuck")]
    public bool @CarStuck { get => SdkMemory.Read<bool >(Pointer+28); set { SdkMemory.Write(Pointer+28,value); } }
    [NativeMember("field_1D")]
    public sbyte @Field1D { get => SdkMemory.Read<sbyte >(Pointer+29); set { SdkMemory.Write(Pointer+29,value); } }
    [NativeMember("m_bStuck")]
    public sbyte @Stuck { get => SdkMemory.Read<sbyte >(Pointer+30); set { SdkMemory.Write(Pointer+30,value); } }
    [NativeMember("m_bFlipped")]
    public sbyte @Flipped { get => SdkMemory.Read<sbyte >(Pointer+31); set { SdkMemory.Write(Pointer+31,value); } }
    [NativeMember("m_bbWarp")]
    public sbyte @BbWarp { get => SdkMemory.Read<sbyte >(Pointer+32); set { SdkMemory.Write(Pointer+32,value); } }
    [NativeMember("pathID")]
    public sbyte @PathID { get => SdkMemory.Read<sbyte >(Pointer+33); set { SdkMemory.Write(Pointer+33,value); } }
    [NativeMember("__pad")]
    public NativeArray<sbyte> @Pad { get => new NativeArray<sbyte>(Pointer+34,2); }
}
