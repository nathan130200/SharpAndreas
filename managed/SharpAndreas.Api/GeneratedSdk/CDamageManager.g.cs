// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CDamageManager : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=24;
    public CDamageManager(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_fWheelDamageEffect")]
    public float @WheelDamageEffect { get => SdkMemory.Read<float >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("m_nEngineStatus")]
    public byte @EngineStatus { get => SdkMemory.Read<byte >(Pointer+4); set { SdkMemory.Write(Pointer+4,value); } }
    [NativeMember("m_nPanelsStatus")]
    public uint @PanelsStatus { get => SdkMemory.Read<uint >(Pointer+20); set { SdkMemory.Write(Pointer+20,value); } }
    public bool @GetComponentGroup(tComponent @component,NativePointer<tComponentGroup> @group,NativePointer<byte> @damageCompId) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D728 >(728)(Pointer,(int)@component,@group.Pointer,@damageCompId.Pointer); return __sdkResult != 0; }
    public void @ResetDamageStatus() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D729 >(729)(Pointer); }
    public void @SetLightStatus(eLights @light,uint @status) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D730 >(730)(Pointer,(int)@light,@status); }
    public uint @GetLightStatus(eLights @light) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D731 >(731)(Pointer,(int)@light); return __sdkResult; }
    public void @SetPanelStatus(int @panel,uint @status) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D732 >(732)(Pointer,@panel,@status); }
    public uint @GetPanelStatus(int @arg0) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D733 >(733)(Pointer,@arg0); return __sdkResult; }
    public void @SetWheelStatus(int @wheel,uint @status) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D734 >(734)(Pointer,@wheel,@status); }
    public uint @GetWheelStatus(int @wheel) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D735 >(735)(Pointer,@wheel); return __sdkResult; }
    public void @SetDoorStatus(eDoors @door,uint @status) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D736 >(736)(Pointer,(int)@door,@status); }
    public void @SetDoorStatus(int @doorNodeIndex,uint @status) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D737 >(737)(Pointer,@doorNodeIndex,@status); }
    public uint @GetDoorStatus(int @doorNodeIndex) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D738 >(738)(Pointer,@doorNodeIndex); return __sdkResult; }
    public uint @GetDoorStatus(eDoors @door) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D739 >(739)(Pointer,(int)@door); return __sdkResult; }
    public void @SetEngineStatus(uint @status) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D740 >(740)(Pointer,@status); }
    public uint @GetEngineStatus() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D741 >(741)(Pointer); return __sdkResult; }
    public void @SetAeroplaneCompStatus(int @component,uint @status) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D742 >(742)(Pointer,@component,@status); }
    public uint @GetAeroplaneCompStatus(int @component) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D743 >(743)(Pointer,@component); return __sdkResult; }
    public bool @ProgressDoorDamage(byte @damageCompId,CAutomobile? @car) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D744 >(744)(Pointer,@damageCompId,@car?.Pointer ?? IntPtr.Zero); return __sdkResult != 0; }
    public bool @ProgressEngineDamage(float @arg0) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D745 >(745)(Pointer,@arg0); return __sdkResult != 0; }
    public bool @ProgressPanelDamage(byte @panel) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D746 >(746)(Pointer,@panel); return __sdkResult != 0; }
    public bool @ProgressWheelDamage(byte @wheel) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D747 >(747)(Pointer,@wheel); return __sdkResult != 0; }
    public bool @ProgressAeroplaneDamage(byte @component) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D748 >(748)(Pointer,@component); return __sdkResult != 0; }
    public bool @ApplyDamage(CAutomobile? @car,tComponent @component,float @intensity,float @arg3) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D749 >(749)(Pointer,@car?.Pointer ?? IntPtr.Zero,(int)@component,@intensity,@arg3); return __sdkResult != 0; }
    public void @FuckCarCompletely(bool @skipWheels) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D750 >(750)(Pointer,(@skipWheels ? 1 : 0)); }
    public int @GetCarNodeIndexFromPanel(ePanels @panel) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D751 >(751)(Pointer,(int)@panel); return __sdkResult; }
    public int @GetCarNodeIndexFromDoor(eDoors @door) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D752 >(752)(Pointer,(int)@door); return __sdkResult; }
    public void @Reset() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D753 >(753)(Pointer); }
}
