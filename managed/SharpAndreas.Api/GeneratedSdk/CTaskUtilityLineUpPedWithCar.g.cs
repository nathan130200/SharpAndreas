// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CTaskUtilityLineUpPedWithCar : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=28;
    public CTaskUtilityLineUpPedWithCar(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("pCoords")]
    public CVector? @Coordinates { get => SdkMemory.Read<IntPtr>(Pointer+0) == IntPtr.Zero ? null : new CVector(SdkMemory.Read<IntPtr>(Pointer+0)); set { SdkMemory.Write(Pointer+0,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("field_4")]
    public float @Field4 { get => SdkMemory.Read<float >(Pointer+4); set { SdkMemory.Write(Pointer+4,value); } }
    [NativeMember("field_8")]
    public int @Field8 { get => SdkMemory.Read<int >(Pointer+8); set { SdkMemory.Write(Pointer+8,value); } }
    [NativeMember("field_c")]
    public int @FieldC { get => SdkMemory.Read<int >(Pointer+12); set { SdkMemory.Write(Pointer+12,value); } }
    [NativeMember("time")]
    public int @Time { get => SdkMemory.Read<int >(Pointer+16); set { SdkMemory.Write(Pointer+16,value); } }
    [NativeMember("field_14")]
    public int @Field14 { get => SdkMemory.Read<int >(Pointer+20); set { SdkMemory.Write(Pointer+20,value); } }
    [NativeMember("pCTaskSimpleVtable")]
    public int @CTaskSimpleVtable { get => SdkMemory.Read<int >(Pointer+24); set { SdkMemory.Write(Pointer+24,value); } }
    public void @InitializeAt(CVector @Vector,int @nTime,int @arg3,int @arg4) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4008 >(4008)(Pointer,@Vector.Pointer,@nTime,@arg3,@arg4); }
    public CVector? @GetLocalPositionToOpenCarDoor(int @unused,CVehicle? @pVehicle,float @arg3,CAnimBlendAssociation? @pAnimBlendAssoc) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4009 >(4009)(Pointer,@unused,@pVehicle?.Pointer ?? IntPtr.Zero,@arg3,@pAnimBlendAssoc?.Pointer ?? IntPtr.Zero); return __sdkResult == IntPtr.Zero ? null : new CVector(__sdkResult); }
    public void @ProcessPed(CPed? @pPed,CVehicle? @pVehicle,CAnimBlendAssociation? @pAnimBlendAssoc) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4010 >(4010)(Pointer,@pPed?.Pointer ?? IntPtr.Zero,@pVehicle?.Pointer ?? IntPtr.Zero,@pAnimBlendAssoc?.Pointer ?? IntPtr.Zero); }
    public RwV3d? @GetPositionToOpenCarDoor(int @unused,CVehicle? @pVehicle,float @arg2,CAnimBlendAssociation? @pAnimBlendAssoc) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4011 >(4011)(Pointer,@unused,@pVehicle?.Pointer ?? IntPtr.Zero,@arg2,@pAnimBlendAssoc?.Pointer ?? IntPtr.Zero); return __sdkResult == IntPtr.Zero ? null : new RwV3d(__sdkResult); }
}
