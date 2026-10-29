// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CPedIntelligence : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=660;
    public CPedIntelligence(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_pPed")]
    public CPed? @Ped { get => SdkMemory.Read<IntPtr>(Pointer+0) == IntPtr.Zero ? null : new CPed(SdkMemory.Read<IntPtr>(Pointer+0)); set { SdkMemory.Write(Pointer+0,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_TaskMgr")]
    public CTaskManager @TaskMgr { get => new CTaskManager(Pointer+4); set { SdkMemory.Copy(value.Pointer,Pointer+4,48); } }
    [NativeMember("m_eventHandler")]
    public CEventHandler @EventHandler { get => new CEventHandler(Pointer+52); set { SdkMemory.Copy(value.Pointer,Pointer+52,52); } }
    [NativeMember("m_eventGroup")]
    public CEventGroup @EventGroup { get => new CEventGroup(Pointer+104); set { SdkMemory.Copy(value.Pointer,Pointer+104,76); } }
    [NativeMember("m_nDecisionMakerType")]
    public eDecisionMakerType @DecisionMakerType { get => SdkMemory.Read<eDecisionMakerType >(Pointer+180); set { SdkMemory.Write(Pointer+180,value); } }
    [NativeMember("m_nDecisionMakerTypeInGroup")]
    public eDecisionMakerType @DecisionMakerTypeInGroup { get => SdkMemory.Read<eDecisionMakerType >(Pointer+184); set { SdkMemory.Write(Pointer+184,value); } }
    [NativeMember("m_fHearingRange")]
    public float @HearingRange { get => SdkMemory.Read<float >(Pointer+188); set { SdkMemory.Write(Pointer+188,value); } }
    [NativeMember("m_fSeeingRange")]
    public float @SeeingRange { get => SdkMemory.Read<float >(Pointer+192); set { SdkMemory.Write(Pointer+192,value); } }
    [NativeMember("m_nDmNumPedsToScan")]
    public uint @DmCountPedsToScan { get => SdkMemory.Read<uint >(Pointer+196); set { SdkMemory.Write(Pointer+196,value); } }
    [NativeMember("m_fDmRadius")]
    public float @DmRadius { get => SdkMemory.Read<float >(Pointer+200); set { SdkMemory.Write(Pointer+200,value); } }
    [NativeMember("m_FollowNodeThresholdDistance")]
    public float @FollowNodeThresholdDistance { get => SdkMemory.Read<float >(Pointer+204); set { SdkMemory.Write(Pointer+204,value); } }
    [NativeMember("m_NextEventResponseSequence")]
    public sbyte @NextEventResponseSequence { get => SdkMemory.Read<sbyte >(Pointer+208); set { SdkMemory.Write(Pointer+208,value); } }
    [NativeMember("m_nEventId")]
    public byte @EventId { get => SdkMemory.Read<byte >(Pointer+209); set { SdkMemory.Write(Pointer+209,value); } }
    [NativeMember("m_nEventPriority")]
    public byte @EventPriority { get => SdkMemory.Read<byte >(Pointer+210); set { SdkMemory.Write(Pointer+210,value); } }
    [NativeMember("field_D3")]
    public sbyte @FieldD3 { get => SdkMemory.Read<sbyte >(Pointer+211); set { SdkMemory.Write(Pointer+211,value); } }
    [NativeMember("m_vehicleScanner")]
    public CEntityScanner @VehicleScanner { get => new CEntityScanner(Pointer+212); set { SdkMemory.Copy(value.Pointer,Pointer+212,80); } }
    [NativeMember("m_pedScanner")]
    public CEntityScanner @PedScanner { get => new CEntityScanner(Pointer+292); set { SdkMemory.Copy(value.Pointer,Pointer+292,80); } }
    [NativeMember("m_mentalState")]
    public CMentalState @MentalState { get => new CMentalState(Pointer+372); set { SdkMemory.Copy(value.Pointer,Pointer+372,20); } }
    [NativeMember("field_188")]
    public sbyte @Field188 { get => SdkMemory.Read<sbyte >(Pointer+392); set { SdkMemory.Write(Pointer+392,value); } }
    [NativeMember("m_eventScanner")]
    public CEventScanner @EventScanner { get => new CEventScanner(Pointer+396); set { SdkMemory.Copy(value.Pointer,Pointer+396,212); } }
    [NativeMember("m_collisionScanner")]
    public CCollisionEventScanner @CollisionScanner { get => new CCollisionEventScanner(Pointer+608); set { SdkMemory.Copy(value.Pointer,Pointer+608,1); } }
    [NativeMember("m_pedStuckChecker")]
    public CPedStuckChecker @PedStuckChecker { get => new CPedStuckChecker(Pointer+612); set { SdkMemory.Copy(value.Pointer,Pointer+612,16); } }
    [NativeMember("m_AnotherStaticCounter")]
    public int @AnotherStaticCounter { get => SdkMemory.Read<int >(Pointer+628); set { SdkMemory.Write(Pointer+628,value); } }
    [NativeMember("m_StaticCounter")]
    public int @StaticCounter { get => SdkMemory.Read<int >(Pointer+632); set { SdkMemory.Write(Pointer+632,value); } }
    [NativeMember("m_vecLastPedPosDuringDamageEntity")]
    public CVector @LastPedPositionDuringDamageEntity { get => new CVector(Pointer+636); set { SdkMemory.Copy(value.Pointer,Pointer+636,12); } }
    [NativeMember("m_apInterestingEntities")]
    public NativeArray<IntPtr> @InterestingEntities { get => new NativeArray<IntPtr>(Pointer+648,3); }
    public void @SetPedDecisionMakerType(eDecisionMakerType @dm) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1321 >(1321)(Pointer,(int)@dm); }
    public void @SetPedDecisionMakerTypeInGroup(eDecisionMakerType @dm) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1322 >(1322)(Pointer,(int)@dm); }
    public void @RestorePedDecisionMakerType() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1323 >(1323)(Pointer); }
    public void @SetHearingRange(float @range) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1324 >(1324)(Pointer,@range); }
    public void @SetSeeingRange(float @range) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1325 >(1325)(Pointer,@range); }
    public bool @IsInHearingRange(CVector @posn) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1326 >(1326)(Pointer,@posn.Pointer); return __sdkResult != 0; }
    public bool @IsInSeeingRange(CVector @posn) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1327 >(1327)(Pointer,@posn.Pointer); return __sdkResult != 0; }
    public bool @FindRespectedFriendInInformRange() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1328 >(1328)(Pointer); return __sdkResult != 0; }
    public bool @IsRespondingToEvent(int @event) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1329 >(1329)(Pointer,@event); return __sdkResult != 0; }
    public void @AddTaskPhysResponse(CTask? @task,bool @arg2) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1330 >(1330)(Pointer,@task?.Pointer ?? IntPtr.Zero,(@arg2 ? 1 : 0)); }
    public void @AddTaskEventResponseTemp(CTask? @task,bool @arg2) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1331 >(1331)(Pointer,@task?.Pointer ?? IntPtr.Zero,(@arg2 ? 1 : 0)); }
    public void @AddTaskEventResponseNonTemp(CTask? @task,bool @arg2) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1332 >(1332)(Pointer,@task?.Pointer ?? IntPtr.Zero,(@arg2 ? 1 : 0)); }
    public void @AddTaskPrimaryMaybeInGroup(CTask? @task,bool @arg2) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1333 >(1333)(Pointer,@task?.Pointer ?? IntPtr.Zero,(@arg2 ? 1 : 0)); }
    public CTask? @FindTaskByType(int @type) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1334 >(1334)(Pointer,@type); return __sdkResult == IntPtr.Zero ? null : new CTask(__sdkResult); }
    public CTaskSimpleFight? @GetTaskFighting() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1335 >(1335)(Pointer); return __sdkResult == IntPtr.Zero ? null : new CTaskSimpleFight(__sdkResult); }
    public CTaskSimpleUseGun? @GetTaskUseGun() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1336 >(1336)(Pointer); return __sdkResult == IntPtr.Zero ? null : new CTaskSimpleUseGun(__sdkResult); }
    public CTaskSimpleThrowProjectile? @GetTaskThrow() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1337 >(1337)(Pointer); return __sdkResult == IntPtr.Zero ? null : new CTaskSimpleThrowProjectile(__sdkResult); }
    public CTaskSimpleHoldEntity? @GetTaskHold(bool @arg1) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1338 >(1338)(Pointer,(@arg1 ? 1 : 0)); return __sdkResult == IntPtr.Zero ? null : new CTaskSimpleHoldEntity(__sdkResult); }
    public CTaskSimpleSwim? @GetTaskSwim() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1339 >(1339)(Pointer); return __sdkResult == IntPtr.Zero ? null : new CTaskSimpleSwim(__sdkResult); }
    public CTaskSimpleDuck? @GetTaskDuck(bool @arg1) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1340 >(1340)(Pointer,(@arg1 ? 1 : 0)); return __sdkResult == IntPtr.Zero ? null : new CTaskSimpleDuck(__sdkResult); }
    public CTaskSimpleJetPack? @GetTaskJetPack() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1341 >(1341)(Pointer); return __sdkResult == IntPtr.Zero ? null : new CTaskSimpleJetPack(__sdkResult); }
    public CTaskSimpleInAir? @GetTaskInAir() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1342 >(1342)(Pointer); return __sdkResult == IntPtr.Zero ? null : new CTaskSimpleInAir(__sdkResult); }
    public CTaskSimpleClimb? @GetTaskClimb() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1343 >(1343)(Pointer); return __sdkResult == IntPtr.Zero ? null : new CTaskSimpleClimb(__sdkResult); }
    public bool @GetUsingParachute() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1344 >(1344)(Pointer); return __sdkResult != 0; }
    public void @SetTaskDuckSecondary(ushort @arg1) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1345 >(1345)(Pointer,@arg1); }
    public void @ClearTaskDuckSecondary() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1346 >(1346)(Pointer); }
    public void @ClearTasks(bool @arg1,bool @arg2) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1347 >(1347)(Pointer,(@arg1 ? 1 : 0),(@arg2 ? 1 : 0)); }
    public void @FlushImmediately(bool @arg1) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1348 >(1348)(Pointer,(@arg1 ? 1 : 0)); }
    public C2dEffect? @GetEffectInUse() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1349 >(1349)(Pointer); return __sdkResult == IntPtr.Zero ? null : new C2dEffect(__sdkResult); }
    public void @SetEffectInUse(C2dEffect? @arg1) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1350 >(1350)(Pointer,@arg1?.Pointer ?? IntPtr.Zero); }
    public void @ProcessAfterProcCol() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1351 >(1351)(Pointer); }
    public void @ProcessAfterPreRender() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1352 >(1352)(Pointer); }
    public void @ProcessEventHandler() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1353 >(1353)(Pointer); }
    public bool @IsFriendlyWith(CPed @ped) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1354 >(1354)(Pointer,@ped.Pointer); return __sdkResult != 0; }
    public bool @IsThreatenedBy(CPed @ped) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1355 >(1355)(Pointer,@ped.Pointer); return __sdkResult != 0; }
    public bool @Respects(CPed @ped) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1356 >(1356)(Pointer,@ped.Pointer); return __sdkResult != 0; }
    public bool @IsInACarOrEnteringOne() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1357 >(1357)(Pointer); return __sdkResult != 0; }
    public static bool @AreFriends(CPed @ped1,CPed @ped2) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1358 >(1358)(@ped1.Pointer,@ped2.Pointer); return __sdkResult != 0; }
    public bool @IsPedGoingSomewhereOnFoot() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1359 >(1359)(Pointer); return __sdkResult != 0; }
    public NativePointer<int> @GetMoveStateFromGoToTask() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1360 >(1360)(Pointer); return new NativePointer<int>(__sdkResult); }
    public void @FlushIntelligence() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1361 >(1361)(Pointer); }
    public bool @TestForStealthKill(CPed? @pPed,bool @arg2) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1362 >(1362)(Pointer,@pPed?.Pointer ?? IntPtr.Zero,(@arg2 ? 1 : 0)); return __sdkResult != 0; }
    public void @RecordEventForScript(int @EventID,int @EventPriority) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1363 >(1363)(Pointer,@EventID,@EventPriority); }
    public bool @HasInterestingEntites() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1364 >(1364)(Pointer); return __sdkResult != 0; }
    public bool @IsInterestingEntity(CEntity? @pEntity) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1365 >(1365)(Pointer,@pEntity?.Pointer ?? IntPtr.Zero); return __sdkResult != 0; }
    public void @LookAtInterestingEntities() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1366 >(1366)(Pointer); }
    public void @RemoveAllInterestingEntities() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1367 >(1367)(Pointer); }
    public bool @IsPedGoingForCarDoor() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1368 >(1368)(Pointer); return __sdkResult != 0; }
    public float @CanSeeEntityWithLights(CEntity? @pEntity,bool @arg2) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1369 >(1369)(Pointer,@pEntity?.Pointer ?? IntPtr.Zero,(@arg2 ? 1 : 0)); return __sdkResult; }
    public void @ProcessStaticCounter() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1370 >(1370)(Pointer); }
    public void @ProcessFirst() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1371 >(1371)(Pointer); }
    public void @Process() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1372 >(1372)(Pointer); }
    public static void @FreeNative(NativePointer<IntPtr> @arg1) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1373 >(1373)(@arg1.Pointer); }
}
