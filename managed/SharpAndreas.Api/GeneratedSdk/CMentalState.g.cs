// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CMentalState : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=20;
    public CMentalState(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_AngerAtPlayer")]
    public byte @AngerAtPlayer { get => SdkMemory.Read<byte >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("m_LastAngerAtPlayer")]
    public byte @LastAngerAtPlayer { get => SdkMemory.Read<byte >(Pointer+1); set { SdkMemory.Write(Pointer+1,value); } }
    [NativeMember("m_AngerTimer")]
    public CTaskTimer @AngerTimer { get => new CTaskTimer(Pointer+4); set { SdkMemory.Copy(value.Pointer,Pointer+4,12); } }
    [NativeMember("m_pedHealth")]
    public byte @PedHealth { get => SdkMemory.Read<byte >(Pointer+16); set { SdkMemory.Write(Pointer+16,value); } }
    [NativeMember("m_oldPedHealth")]
    public byte @OldPedHealth { get => SdkMemory.Read<byte >(Pointer+17); set { SdkMemory.Write(Pointer+17,value); } }
    [NativeMember("m_vehicleHealth")]
    public byte @VehicleHealth { get => SdkMemory.Read<byte >(Pointer+18); set { SdkMemory.Write(Pointer+18,value); } }
    [NativeMember("m_oldVehicleHealth")]
    public byte @OldVehicleHealth { get => SdkMemory.Read<byte >(Pointer+19); set { SdkMemory.Write(Pointer+19,value); } }
    public void @IncrementAnger(int @anger) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1297 >(1297)(Pointer,@anger); }
    public void @Process() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1298 >(1298)(Pointer); }
}
