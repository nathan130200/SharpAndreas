// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CVehicleModelInfo__CVehicleStructure : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=788;
    public CVehicleModelInfo__CVehicleStructure(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_avDummyPos")]
    public NativeObjectArray<CVector> @DummyPosition { get => new NativeObjectArray<CVector>(Pointer+0,15,12); }
    [NativeMember("m_aUpgrades")]
    public NativeObjectArray<UpgradePosnDesc> @Upgrades { get => new NativeObjectArray<UpgradePosnDesc>(Pointer+180,18,32); }
    [NativeMember("m_apExtras")]
    public NativeArray<IntPtr> @Extras { get => new NativeArray<IntPtr>(Pointer+756,6); }
    [NativeMember("m_nNumExtras")]
    public byte @CountExtras { get => SdkMemory.Read<byte >(Pointer+780); set { SdkMemory.Write(Pointer+780,value); } }
    [NativeMember("m_nMaskComponentsDamagable")]
    public uint @MaskComponentsDamagable { get => SdkMemory.Read<uint >(Pointer+784); set { SdkMemory.Write(Pointer+784,value); } }
}
