// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CTaskComplexProstituteSolicit : CTaskComplex
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=48;
    public CTaskComplexProstituteSolicit(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_pClient")]
    public CPed? @Client { get => SdkMemory.Read<IntPtr>(Pointer+12) == IntPtr.Zero ? null : new CPed(SdkMemory.Read<IntPtr>(Pointer+12)); set { SdkMemory.Write(Pointer+12,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_vecVehiclePosn")]
    public CVector @VehiclePosition { get => new CVector(Pointer+16); set { SdkMemory.Copy(value.Pointer,Pointer+16,12); } }
    [NativeMember("m_nLastSavedTime")]
    public int @LastSavedTime { get => SdkMemory.Read<int >(Pointer+28); set { SdkMemory.Write(Pointer+28,value); } }
    [NativeMember("m_nNextTimeToCheckForSecludedPlace")]
    public int @NextTimeToCheckForSecludedPlace { get => SdkMemory.Read<int >(Pointer+32); set { SdkMemory.Write(Pointer+32,value); } }
    [NativeMember("m_nLastPaymentTime")]
    public int @LastPaymentTime { get => SdkMemory.Read<int >(Pointer+36); set { SdkMemory.Write(Pointer+36,value); } }
    [NativeMember("m_nVehicleMovementTimer")]
    public short @VehicleMovementTimer { get => SdkMemory.Read<short >(Pointer+40); set { SdkMemory.Write(Pointer+40,value); } }
    [NativeMember("m_nCurrentTimer")]
    public short @CurrentTimer { get => SdkMemory.Read<short >(Pointer+42); set { SdkMemory.Write(Pointer+42,value); } }
    [NativeMember("m_nFlags")]
    public CTaskComplexProstituteSolicit___unnamed__at_D__plugin_sdk_plugin_sa_ga_aa5ad5fe30 @Flags { get => new CTaskComplexProstituteSolicit___unnamed__at_D__plugin_sdk_plugin_sa_ga_aa5ad5fe30(Pointer+44); set { SdkMemory.Copy(value.Pointer,Pointer+44,2); } }
    public void @InitializeAt(CPed? @pClient) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4024 >(4024)(Pointer,@pClient?.Pointer ?? IntPtr.Zero); }
    public CTask? @CreateSubTask(int @taskId,CPed? @pProstitute) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4025 >(4025)(Pointer,@taskId,@pProstitute?.Pointer ?? IntPtr.Zero); return __sdkResult == IntPtr.Zero ? null : new CTask(__sdkResult); }
    public static void @GetRidOfPlayerProstitute() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4026 >(4026)(); }
    public static bool @IsTaskValid(CPed? @pProstitute,CPed? @pClient) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4027 >(4027)(@pProstitute?.Pointer ?? IntPtr.Zero,@pClient?.Pointer ?? IntPtr.Zero); return __sdkResult != 0; }
}
