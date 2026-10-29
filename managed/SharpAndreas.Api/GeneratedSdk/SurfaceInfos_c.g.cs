// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class SurfaceInfos_c : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=2292;
    public SurfaceInfos_c(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_adhesiveLimits")]
    public NativeArray<float> @AdhesiveLimits { get => new NativeArray<float>(Pointer+0,36); }
    [NativeMember("m_surfaces")]
    public NativeObjectArray<SurfaceInfo_c> @Surfaces { get => new NativeObjectArray<SurfaceInfo_c>(Pointer+144,179,12); }
    public uint @GetSurfaceIdFromName(NativePointer<sbyte> @cName) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4599 >(4599)(Pointer,@cName.Pointer); return __sdkResult; }
    public void @LoadAdhesiveLimits() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4600 >(4600)(Pointer); }
    public void @LoadSurfaceAudioInfos() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4601 >(4601)(Pointer); }
    public void @LoadSurfaceInfos() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4602 >(4602)(Pointer); }
    public void @Init() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4603 >(4603)(Pointer); }
    public eAdhesionGroup @GetAdhesionGroup(uint @id) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4604 >(4604)(Pointer,@id); return (eAdhesionGroup)__sdkResult; }
    public float @GetTyreGrip(uint @id) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4605 >(4605)(Pointer,@id); return __sdkResult; }
    public float @GetWetMultiplier(uint @id) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4606 >(4606)(Pointer,@id); return __sdkResult; }
    public uint @GetSkidmarkType(uint @id) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4607 >(4607)(Pointer,@id); return __sdkResult; }
    public eFrictionEffect @GetFrictionEffect(uint @id) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4608 >(4608)(Pointer,@id); return (eFrictionEffect)__sdkResult; }
    public uint @GetBulletFx(uint @id) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4609 >(4609)(Pointer,@id); return __sdkResult; }
    public bool @IsSoftLanding(uint @id) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4610 >(4610)(Pointer,@id); return __sdkResult != 0; }
    public bool @IsSeeThrough(uint @id) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4611 >(4611)(Pointer,@id); return __sdkResult != 0; }
    public bool @IsShootThrough(uint @id) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4612 >(4612)(Pointer,@id); return __sdkResult != 0; }
    public bool @IsSand(uint @id) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4613 >(4613)(Pointer,@id); return __sdkResult != 0; }
    public bool @IsWater(uint @id) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4614 >(4614)(Pointer,@id); return __sdkResult != 0; }
    public bool @IsShallowWater(uint @id) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4615 >(4615)(Pointer,@id); return __sdkResult != 0; }
    public bool @IsBeach(uint @id) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4616 >(4616)(Pointer,@id); return __sdkResult != 0; }
    public bool @IsSteepSlope(uint @id) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4617 >(4617)(Pointer,@id); return __sdkResult != 0; }
    public bool @IsGlass(uint @id) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4618 >(4618)(Pointer,@id); return __sdkResult != 0; }
    public bool @IsStairs(uint @id) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4619 >(4619)(Pointer,@id); return __sdkResult != 0; }
    public bool @IsSkateable(uint @id) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4620 >(4620)(Pointer,@id); return __sdkResult != 0; }
    public bool @IsPavement(uint @id) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4621 >(4621)(Pointer,@id); return __sdkResult != 0; }
    public uint @GetRoughness(uint @id) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4622 >(4622)(Pointer,@id); return __sdkResult; }
    public uint @GetFlammability(uint @id) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4623 >(4623)(Pointer,@id); return __sdkResult; }
    public bool @CreatesSparks(uint @id) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4624 >(4624)(Pointer,@id); return __sdkResult != 0; }
    public bool @CantSprintOn(uint @id) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4625 >(4625)(Pointer,@id); return __sdkResult != 0; }
    public bool @LeavesFootsteps(uint @id) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4626 >(4626)(Pointer,@id); return __sdkResult != 0; }
    public bool @ProducesFootDust(uint @id) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4627 >(4627)(Pointer,@id); return __sdkResult != 0; }
    public bool @MakesCarDirty(uint @id) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4628 >(4628)(Pointer,@id); return __sdkResult != 0; }
    public bool @MakesCarClean(uint @id) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4629 >(4629)(Pointer,@id); return __sdkResult != 0; }
    public bool @CreatesWheelGrass(uint @id) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4630 >(4630)(Pointer,@id); return __sdkResult != 0; }
    public bool @CreatesWheelGravel(uint @id) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4631 >(4631)(Pointer,@id); return __sdkResult != 0; }
    public bool @CreatesWheelMud(uint @id) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4632 >(4632)(Pointer,@id); return __sdkResult != 0; }
    public bool @CreatesWheelDust(uint @id) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4633 >(4633)(Pointer,@id); return __sdkResult != 0; }
    public bool @CreatesWheelSand(uint @id) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4634 >(4634)(Pointer,@id); return __sdkResult != 0; }
    public bool @CreatesWheelSpray(uint @id) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4635 >(4635)(Pointer,@id); return __sdkResult != 0; }
    public bool @CreatesPlants(uint @id) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4636 >(4636)(Pointer,@id); return __sdkResult != 0; }
    public bool @CreatesObjects(uint @id) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4637 >(4637)(Pointer,@id); return __sdkResult != 0; }
    public bool @CanClimb(uint @id) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4638 >(4638)(Pointer,@id); return __sdkResult != 0; }
    public bool @IsAudioConcrete(uint @id) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4639 >(4639)(Pointer,@id); return __sdkResult != 0; }
    public bool @IsAudioGrass(uint @id) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4640 >(4640)(Pointer,@id); return __sdkResult != 0; }
    public bool @IsAudioSand(uint @id) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4641 >(4641)(Pointer,@id); return __sdkResult != 0; }
    public bool @IsAudioGravel(uint @id) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4642 >(4642)(Pointer,@id); return __sdkResult != 0; }
    public bool @IsAudioWood(uint @id) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4643 >(4643)(Pointer,@id); return __sdkResult != 0; }
    public bool @IsAudioWater(uint @id) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4644 >(4644)(Pointer,@id); return __sdkResult != 0; }
    public bool @IsAudioMetal(uint @id) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4645 >(4645)(Pointer,@id); return __sdkResult != 0; }
    public bool @IsAudioLongGrass(uint @id) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4646 >(4646)(Pointer,@id); return __sdkResult != 0; }
    public bool @IsAudioTile(uint @id) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4647 >(4647)(Pointer,@id); return __sdkResult != 0; }
    public float @GetAdhesiveLimit(CColPoint? @colPoint) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4648 >(4648)(Pointer,@colPoint?.Pointer ?? IntPtr.Zero); return __sdkResult; }
}
