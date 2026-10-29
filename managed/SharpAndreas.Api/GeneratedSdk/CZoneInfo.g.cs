// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CZoneInfo : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=17;
    public CZoneInfo(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_nGangDensity")]
    public NativeArray<sbyte> @GangDensity { get => new NativeArray<sbyte>(Pointer+0,10); }
    [NativeMember("m_nDealerCounter")]
    public sbyte @DealerCounter { get => SdkMemory.Read<sbyte >(Pointer+10); set { SdkMemory.Write(Pointer+10,value); } }
    [NativeMember("m_ZoneColor")]
    public CRGBA @ZoneColor { get => new CRGBA(Pointer+11); set { SdkMemory.Copy(value.Pointer,Pointer+11,4); } }
    [NativeMember("m_nFlags")]
    public sbyte @Flags { get => SdkMemory.Read<sbyte >(Pointer+15); set { SdkMemory.Write(Pointer+15,value); } }
    [NativeMember("m_nPopulationRace")]
    public sbyte @PopulationRace { get => SdkMemory.Read<sbyte >(Pointer+16); set { SdkMemory.Write(Pointer+16,value); } }
}
