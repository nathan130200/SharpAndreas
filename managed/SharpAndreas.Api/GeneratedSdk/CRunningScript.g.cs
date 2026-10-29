// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CRunningScript : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=224;
    public CRunningScript(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_pNext")]
    public CRunningScript? @Next { get => SdkMemory.Read<IntPtr>(Pointer+0) == IntPtr.Zero ? null : new CRunningScript(SdkMemory.Read<IntPtr>(Pointer+0)); set { SdkMemory.Write(Pointer+0,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_pPrev")]
    public CRunningScript? @Prev { get => SdkMemory.Read<IntPtr>(Pointer+4) == IntPtr.Zero ? null : new CRunningScript(SdkMemory.Read<IntPtr>(Pointer+4)); set { SdkMemory.Write(Pointer+4,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_szName")]
    public NativeArray<sbyte> @Name { get => new NativeArray<sbyte>(Pointer+8,8); }
    [NativeMember("m_pBaseIP")]
    public NativePointer<byte> @BaseIP { get => new NativePointer<byte>(SdkMemory.Read<IntPtr>(Pointer+16)); set { SdkMemory.Write(Pointer+16,value.Pointer); } }
    [NativeMember("m_pCurrentIP")]
    public NativePointer<byte> @CurrentIP { get => new NativePointer<byte>(SdkMemory.Read<IntPtr>(Pointer+20)); set { SdkMemory.Write(Pointer+20,value.Pointer); } }
    [NativeMember("m_apStack")]
    public NativeArray<IntPtr> @Stack { get => new NativeArray<IntPtr>(Pointer+24,8); }
    [NativeMember("m_nSP")]
    public ushort @SP { get => SdkMemory.Read<ushort >(Pointer+56); set { SdkMemory.Write(Pointer+56,value); } }
    [NativeMember("m_aLocalVars")]
    public NativeObjectArray<tScriptParam> @LocalVariables { get => new NativeObjectArray<tScriptParam>(Pointer+60,32,4); }
    [NativeMember("m_anTimers")]
    public NativeArray<int> @Timers { get => new NativeArray<int>(Pointer+188,2); }
    [NativeMember("m_bIsActive")]
    public bool @IsActive { get => SdkMemory.Read<bool >(Pointer+196); set { SdkMemory.Write(Pointer+196,value); } }
    [NativeMember("m_bCondResult")]
    public bool @CondResult { get => SdkMemory.Read<bool >(Pointer+197); set { SdkMemory.Write(Pointer+197,value); } }
    [NativeMember("m_bUseMissionCleanup")]
    public bool @UseMissionCleanup { get => SdkMemory.Read<bool >(Pointer+198); set { SdkMemory.Write(Pointer+198,value); } }
    [NativeMember("m_bIsExternal")]
    public bool @IsExternal { get => SdkMemory.Read<bool >(Pointer+199); set { SdkMemory.Write(Pointer+199,value); } }
    [NativeMember("m_bTextBlockOverride")]
    public bool @TextBlockOverride { get => SdkMemory.Read<bool >(Pointer+200); set { SdkMemory.Write(Pointer+200,value); } }
    [NativeMember("m_nWakeTime")]
    public int @WakeTime { get => SdkMemory.Read<int >(Pointer+204); set { SdkMemory.Write(Pointer+204,value); } }
    [NativeMember("m_nLogicalOp")]
    public ushort @LogicalOp { get => SdkMemory.Read<ushort >(Pointer+208); set { SdkMemory.Write(Pointer+208,value); } }
    [NativeMember("m_bNotFlag")]
    public bool @NotFlag { get => SdkMemory.Read<bool >(Pointer+210); set { SdkMemory.Write(Pointer+210,value); } }
    [NativeMember("m_bWastedBustedCheck")]
    public bool @WastedBustedCheck { get => SdkMemory.Read<bool >(Pointer+211); set { SdkMemory.Write(Pointer+211,value); } }
    [NativeMember("m_bWastedOrBusted")]
    public bool @WastedOrBusted { get => SdkMemory.Read<bool >(Pointer+212); set { SdkMemory.Write(Pointer+212,value); } }
    [NativeMember("m_pSceneSkipIP")]
    public NativePointer<byte> @SceneSkipIP { get => new NativePointer<byte>(SdkMemory.Read<IntPtr>(Pointer+216)); set { SdkMemory.Write(Pointer+216,value.Pointer); } }
    [NativeMember("m_bIsMission")]
    public bool @IsMission { get => SdkMemory.Read<bool >(Pointer+220); set { SdkMemory.Write(Pointer+220,value); } }
    [NativeMember("CommandHandlerTable")]
    public static NativeFunctionPointer<Callback_e7846ee7882b> @CommandHandlerTable { get => new NativeFunctionPointer<Callback_e7846ee7882b>(new IntPtr(0x8A6168)); }
    public void @AddScriptToList(NativePointer<IntPtr> @queuelist) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3628 >(3628)(Pointer,@queuelist.Pointer); }
    public void @CarInAreaCheckCommand(int @commandID) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3629 >(3629)(Pointer,@commandID); }
    public void @CharInAngledAreaCheckCommand(int @commandID) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3630 >(3630)(Pointer,@commandID); }
    public void @CharInAreaCheckCommand(int @commandID) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3631 >(3631)(Pointer,@commandID); }
    public tScriptParam @CollectNextParameterWithoutIncreasingPC() { Game.CheckThread(); var result=NativeObject.AllocateStorage<tScriptParam >(4); try { SdkBindings.Get<GeneratedDelegates.D3632 >(3632)(Pointer,result.Pointer); return result; } catch { result.Dispose(); throw; } }
    public void @CollectParameters(short @count) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3633 >(3633)(Pointer,@count); }
    public void @DoDeatharrestCheck() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3634 >(3634)(Pointer); }
    public void @FlameInAngledAreaCheckCommand(int @commandID) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3635 >(3635)(Pointer,@commandID); }
    public void @GetCorrectPedModelIndexForEmergencyServiceType(ePedType @pedType,NativePointer<int> @pModelId) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3636 >(3636)(Pointer,(int)@pedType,@pModelId.Pointer); }
    public short @GetIndexOfGlobalVariable() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3637 >(3637)(Pointer); return __sdkResult; }
    public short @GetPadState(ushort @playerIndex,ushort @buttonID) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3638 >(3638)(Pointer,@playerIndex,@buttonID); return __sdkResult; }
    public NativePointer<IntPtr> @GetPointerToLocalArrayElement(int @off,ushort @idx,byte @mul) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3639 >(3639)(Pointer,@off,@idx,@mul); return new NativePointer<IntPtr>(__sdkResult); }
    public NativePointer<IntPtr> @GetPointerToLocalVariable(int @varId) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3640 >(3640)(Pointer,@varId); return new NativePointer<IntPtr>(__sdkResult); }
    public tScriptParam? @GetPointerToScriptVariable(byte @variableType) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3641 >(3641)(Pointer,@variableType); return __sdkResult == IntPtr.Zero ? null : new tScriptParam(__sdkResult); }
    public void @GivePedScriptedTask(int @pedHandle,CTask? @task,int @commandID) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3642 >(3642)(Pointer,@pedHandle,@task?.Pointer ?? IntPtr.Zero,@commandID); }
    public void @Init() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3643 >(3643)(Pointer); }
    public bool @IsPedDead(CPed? @pPed) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3644 >(3644)(Pointer,@pPed?.Pointer ?? IntPtr.Zero); return __sdkResult != 0; }
    public void @LocateCarCommand(int @commandID) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3645 >(3645)(Pointer,@commandID); }
    public void @LocateCharCarCommand(int @commandID) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3646 >(3646)(Pointer,@commandID); }
    public void @LocateCharCharCommand(int @commandID) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3647 >(3647)(Pointer,@commandID); }
    public void @LocateCharCommand(int @commandID) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3648 >(3648)(Pointer,@commandID); }
    public void @LocateCharObjectCommand(int @commandID) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3649 >(3649)(Pointer,@commandID); }
    public void @LocateObjectCommand(int @commandID) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3650 >(3650)(Pointer,@commandID); }
    public void @ObjectInAngledAreaCheckCommand(int @commandID) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3651 >(3651)(Pointer,@commandID); }
    public void @ObjectInAreaCheckCommand(int @commandID) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3652 >(3652)(Pointer,@commandID); }
    public void @PlayAnimScriptCommand(int @commandID) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3653 >(3653)(Pointer,@commandID); }
    public void @Process() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3654 >(3654)(Pointer); }
    public sbyte @ProcessCommands0To99(int @commandID) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3655 >(3655)(Pointer,@commandID); return __sdkResult; }
    public sbyte @ProcessCommands1000To1099(int @commandID) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3656 >(3656)(Pointer,@commandID); return __sdkResult; }
    public sbyte @ProcessCommands100To199(int @commandID) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3657 >(3657)(Pointer,@commandID); return __sdkResult; }
    public sbyte @ProcessCommands1100To1199(int @commandID) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3658 >(3658)(Pointer,@commandID); return __sdkResult; }
    public sbyte @ProcessCommands1200To1299(int @commandID) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3659 >(3659)(Pointer,@commandID); return __sdkResult; }
    public sbyte @ProcessCommands1300To1399(int @commandID) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3660 >(3660)(Pointer,@commandID); return __sdkResult; }
    public sbyte @ProcessCommands1400To1499(int @commandID) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3661 >(3661)(Pointer,@commandID); return __sdkResult; }
    public sbyte @ProcessCommands1500To1599(int @commandID) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3662 >(3662)(Pointer,@commandID); return __sdkResult; }
    public sbyte @ProcessCommands1600To1699(int @commandID) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3663 >(3663)(Pointer,@commandID); return __sdkResult; }
    public sbyte @ProcessCommands1700To1799(int @commandID) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3664 >(3664)(Pointer,@commandID); return __sdkResult; }
    public sbyte @ProcessCommands1800To1899(int @commandID) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3665 >(3665)(Pointer,@commandID); return __sdkResult; }
    public sbyte @ProcessCommands1900To1999(int @commandID) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3666 >(3666)(Pointer,@commandID); return __sdkResult; }
    public sbyte @ProcessCommands2000To2099(int @commandID) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3667 >(3667)(Pointer,@commandID); return __sdkResult; }
    public sbyte @ProcessCommands200To299(int @commandID) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3668 >(3668)(Pointer,@commandID); return __sdkResult; }
    public sbyte @ProcessCommands2100To2199(int @commandID) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3669 >(3669)(Pointer,@commandID); return __sdkResult; }
    public sbyte @ProcessCommands2200To2299(int @commandID) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3670 >(3670)(Pointer,@commandID); return __sdkResult; }
    public sbyte @ProcessCommands2300To2399(int @commandID) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3671 >(3671)(Pointer,@commandID); return __sdkResult; }
    public sbyte @ProcessCommands2400To2499(int @commandID) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3672 >(3672)(Pointer,@commandID); return __sdkResult; }
    public sbyte @ProcessCommands2500To2599(int @commandID) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3673 >(3673)(Pointer,@commandID); return __sdkResult; }
    public sbyte @ProcessCommands2600To2699(int @commandID) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3674 >(3674)(Pointer,@commandID); return __sdkResult; }
    public sbyte @ProcessCommands300To399(int @commandID) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3675 >(3675)(Pointer,@commandID); return __sdkResult; }
    public sbyte @ProcessCommands400To499(int @commandID) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3676 >(3676)(Pointer,@commandID); return __sdkResult; }
    public sbyte @ProcessCommands500To599(int @commandID) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3677 >(3677)(Pointer,@commandID); return __sdkResult; }
    public sbyte @ProcessCommands600To699(int @commandID) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3678 >(3678)(Pointer,@commandID); return __sdkResult; }
    public sbyte @ProcessCommands700To799(int @commandID) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3679 >(3679)(Pointer,@commandID); return __sdkResult; }
    public sbyte @ProcessCommands800To899(int @commandID) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3680 >(3680)(Pointer,@commandID); return __sdkResult; }
    public sbyte @ProcessCommands900To999(int @commandID) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3681 >(3681)(Pointer,@commandID); return __sdkResult; }
    public void @ProcessOneCommand() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3682 >(3682)(Pointer); }
    public void @ReadArrayInformation(int @move,NativePointer<ushort> @pOffset,NativePointer<int> @pIdx) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3683 >(3683)(Pointer,@move,@pOffset.Pointer,@pIdx.Pointer); }
    public void @ReadParametersForNewlyStartedScript(CRunningScript? @pNewScript) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3684 >(3684)(Pointer,@pNewScript?.Pointer ?? IntPtr.Zero); }
    public void @ReadTextLabelFromScript(NativePointer<sbyte> @pBuffer,byte @nBufferLength) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3685 >(3685)(Pointer,@pBuffer.Pointer,@nBufferLength); }
    public void @RemoveScriptFromList(NativePointer<IntPtr> @queuelist) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3686 >(3686)(Pointer,@queuelist.Pointer); }
    public void @ScriptTaskPickUpObject(int @commandID) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3687 >(3687)(Pointer,@commandID); }
    public void @SetCharCoordinates(CPed? @pPed,float @x_coord,float @y_coord,float @z_coord,bool @bWarpGang,bool @bOffset) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3688 >(3688)(Pointer,@pPed?.Pointer ?? IntPtr.Zero,@x_coord,@y_coord,@z_coord,(@bWarpGang ? 1 : 0),(@bOffset ? 1 : 0)); }
    public void @ShutdownThisScript() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3689 >(3689)(Pointer); }
    public void @StoreParameters(short @count) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3690 >(3690)(Pointer,@count); }
    public bool @ThisIsAValidRandomPed(ePedType @pedType,bool @civilian,bool @gang,bool @criminal) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3691 >(3691)(Pointer,(int)@pedType,(@civilian ? 1 : 0),(@gang ? 1 : 0),(@criminal ? 1 : 0)); return __sdkResult != 0; }
    public void @UpdateCompareFlag(bool @state) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3692 >(3692)(Pointer,(@state ? 1 : 0)); }
    public void @UpdatePC(int @newIP) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3693 >(3693)(Pointer,@newIP); }
}
