// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CPlantSurfProp : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=124;
    public CPlantSurfProp(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_nPlantSlotID")]
    public ushort @PlantSlotID { get => SdkMemory.Read<ushort >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("m_PlantData")]
    public NativeObjectArray<CPlantSurfPropPlantData> @PlantData { get => new NativeObjectArray<CPlantSurfPropPlantData>(Pointer+4,3,40); }
}
