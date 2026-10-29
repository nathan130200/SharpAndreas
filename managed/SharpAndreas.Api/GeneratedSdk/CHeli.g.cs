// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CHeli : CAutomobile
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=2584;
    public CHeli(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_nHeliFlags")]
    public sbyte @HeliFlags { get => SdkMemory.Read<sbyte >(Pointer+2440); set { SdkMemory.Write(Pointer+2440,value); } }
    [NativeMember("_pad1")]
    public NativeArray<sbyte> @Pad1 { get => new NativeArray<sbyte>(Pointer+2441,3); }
    [NativeMember("m_fLeftRightSkid")]
    public float @LeftRightSkid { get => SdkMemory.Read<float >(Pointer+2444); set { SdkMemory.Write(Pointer+2444,value); } }
    [NativeMember("m_fSteeringUpDown")]
    public float @SteeringUpDown { get => SdkMemory.Read<float >(Pointer+2448); set { SdkMemory.Write(Pointer+2448,value); } }
    [NativeMember("m_fSteeringLeftRight")]
    public float @SteeringLeftRight { get => SdkMemory.Read<float >(Pointer+2452); set { SdkMemory.Write(Pointer+2452,value); } }
    [NativeMember("m_fAccelerationBreakStatus")]
    public float @AccelerationBreakStatus { get => SdkMemory.Read<float >(Pointer+2456); set { SdkMemory.Write(Pointer+2456,value); } }
    [NativeMember("field_99C")]
    public int @Field99C { get => SdkMemory.Read<int >(Pointer+2460); set { SdkMemory.Write(Pointer+2460,value); } }
    [NativeMember("m_fRotorZ")]
    public float @RotorZ { get => SdkMemory.Read<float >(Pointer+2464); set { SdkMemory.Write(Pointer+2464,value); } }
    [NativeMember("m_fSecondRotorZ")]
    public float @SecondRotorZ { get => SdkMemory.Read<float >(Pointer+2468); set { SdkMemory.Write(Pointer+2468,value); } }
    [NativeMember("m_fMaxAltitude")]
    public float @MaxAltitude { get => SdkMemory.Read<float >(Pointer+2472); set { SdkMemory.Write(Pointer+2472,value); } }
    [NativeMember("field_9AC")]
    public float @Field9AC { get => SdkMemory.Read<float >(Pointer+2476); set { SdkMemory.Write(Pointer+2476,value); } }
    [NativeMember("m_fMinAltitude")]
    public float @MinAltitude { get => SdkMemory.Read<float >(Pointer+2480); set { SdkMemory.Write(Pointer+2480,value); } }
    [NativeMember("field_9B4")]
    public int @Field9B4 { get => SdkMemory.Read<int >(Pointer+2484); set { SdkMemory.Write(Pointer+2484,value); } }
    [NativeMember("field_9B8")]
    public sbyte @Field9B8 { get => SdkMemory.Read<sbyte >(Pointer+2488); set { SdkMemory.Write(Pointer+2488,value); } }
    [NativeMember("m_nNumSwatOccupants")]
    public sbyte @CountSwatOccupants { get => SdkMemory.Read<sbyte >(Pointer+2489); set { SdkMemory.Write(Pointer+2489,value); } }
    [NativeMember("m_anSwatIDs")]
    public NativeArray<sbyte> @SwatIDs { get => new NativeArray<sbyte>(Pointer+2490,4); }
    [NativeMember("_pad2")]
    public NativeArray<sbyte> @Pad2 { get => new NativeArray<sbyte>(Pointer+2494,2); }
    [NativeMember("field_9C0")]
    public NativeArray<int> @Field9C0 { get => new NativeArray<int>(Pointer+2496,4); }
    [NativeMember("field_9D0")]
    public int @Field9D0 { get => SdkMemory.Read<int >(Pointer+2512); set { SdkMemory.Write(Pointer+2512,value); } }
    [NativeMember("m_pParticlesList")]
    public NativePointer<IntPtr> @ParticlesList { get => new NativePointer<IntPtr>(SdkMemory.Read<IntPtr>(Pointer+2516)); set { SdkMemory.Write(Pointer+2516,value.Pointer); } }
    [NativeMember("field_9D8")]
    public NativeArray<sbyte> @Field9D8 { get => new NativeArray<sbyte>(Pointer+2520,24); }
    [NativeMember("field_9F0")]
    public int @Field9F0 { get => SdkMemory.Read<int >(Pointer+2544); set { SdkMemory.Write(Pointer+2544,value); } }
    [NativeMember("m_vecSearchLightTarget")]
    public CVector @SearchLightTarget { get => new CVector(Pointer+2548); set { SdkMemory.Copy(value.Pointer,Pointer+2548,12); } }
    [NativeMember("m_fSearchLightIntensity")]
    public float @SearchLightIntensity { get => SdkMemory.Read<float >(Pointer+2560); set { SdkMemory.Write(Pointer+2560,value); } }
    [NativeMember("field_A04")]
    public int @FieldA04 { get => SdkMemory.Read<int >(Pointer+2564); set { SdkMemory.Write(Pointer+2564,value); } }
    [NativeMember("field_A08")]
    public int @FieldA08 { get => SdkMemory.Read<int >(Pointer+2568); set { SdkMemory.Write(Pointer+2568,value); } }
    [NativeMember("m_ppGunflashFx")]
    public NativePointer<IntPtr> @PpGunflashFx { get => new NativePointer<IntPtr>(SdkMemory.Read<IntPtr>(Pointer+2572)); set { SdkMemory.Write(Pointer+2572,value.Pointer); } }
    [NativeMember("m_nFiringMultiplier")]
    public sbyte @FiringMultiplier { get => SdkMemory.Read<sbyte >(Pointer+2576); set { SdkMemory.Write(Pointer+2576,value); } }
    [NativeMember("m_bSearchLightEnabled")]
    public bool @SearchLightEnabled { get => SdkMemory.Read<bool >(Pointer+2577); set { SdkMemory.Write(Pointer+2577,value); } }
    [NativeMember("_pad3")]
    public NativeArray<sbyte> @Pad3 { get => new NativeArray<sbyte>(Pointer+2578,2); }
    [NativeMember("field_A14")]
    public float @FieldA14 { get => SdkMemory.Read<float >(Pointer+2580); set { SdkMemory.Write(Pointer+2580,value); } }
    [NativeMember("bPoliceHelisAllowed")]
    public static bool @PoliceHelisAllowed { get => SdkMemory.Read<bool >(new IntPtr(0x8D338C)); set { SdkMemory.Write(new IntPtr(0x8D338C),value); } }
    [NativeMember("TestForNewRandomHelisTimer")]
    public static uint @TestForNewRandomHelisTimer { get => SdkMemory.Read<uint >(new IntPtr(0xC1C960)); set { SdkMemory.Write(new IntPtr(0xC1C960),value); } }
    [NativeMember("pHelis")]
    public static NativePointer<IntPtr> @Helis { get => new NativePointer<IntPtr>(new IntPtr(0xC1C964)); }
    [NativeMember("NumberOfSearchLights")]
    public static uint @NumberOfSearchLights { get => SdkMemory.Read<uint >(new IntPtr(0xC1C96C)); set { SdkMemory.Write(new IntPtr(0xC1C96C),value); } }
    [NativeMember("bHeliControlsCheat")]
    public static bool @HeliControlsCheat { get => SdkMemory.Read<bool >(new IntPtr(0xC1C970)); set { SdkMemory.Write(new IntPtr(0xC1C970),value); } }
    [NativeMember("HeliSearchLights")]
    public static tHeliLight? @HeliSearchLights { get => new IntPtr(0xC1C990) == IntPtr.Zero ? null : new tHeliLight(new IntPtr(0xC1C990)); }
    public void @InitializeAt(int @modelIndex,byte @createdBy) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1738 >(1738)(Pointer,@modelIndex,@createdBy); }
    public void @PreRenderAlways() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1739 >(1739)(Pointer); }
    public CVector @FindSwatPositionRelativeToHeli(int @swatNumber) { Game.CheckThread(); var result=NativeObject.AllocateStorage<CVector >(12); try { SdkBindings.Get<GeneratedDelegates.D1740 >(1740)(Pointer,@swatNumber,result.Pointer); return result; } catch { result.Dispose(); throw; } }
    public bool @SendDownSwat() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1741 >(1741)(Pointer); return __sdkResult != 0; }
    public static void @InitHelis() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1742 >(1742)(); }
    public static void @AddHeliSearchLight(CVector @origin,CVector @target,float @targetRadius,float @power,uint @coronaIndex,byte @unknownFlag,byte @drawShadow) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1743 >(1743)(@origin.Pointer,@target.Pointer,@targetRadius,@power,@coronaIndex,@unknownFlag,@drawShadow); }
    public static void @Pre_SearchLightCone() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1744 >(1744)(); }
    public static void @Post_SearchLightCone() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1745 >(1745)(); }
    public static void @SpecialHeliPreRender() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1746 >(1746)(); }
    public static void @SwitchPoliceHelis(bool @enable) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1747 >(1747)((@enable ? 1 : 0)); }
    public static void @SearchLightCone(int @coronaIndex,CVector @origin,CVector @target,float @targetRadius,float @power,byte @unknownFlag,byte @drawShadow,CVector? @arg7,CVector? @arg8,CVector? @arg9,bool @arg10,float @baseRadius) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1748 >(1748)(@coronaIndex,@origin.Pointer,@target.Pointer,@targetRadius,@power,@unknownFlag,@drawShadow,@arg7?.Pointer ?? IntPtr.Zero,@arg8?.Pointer ?? IntPtr.Zero,@arg9?.Pointer ?? IntPtr.Zero,(@arg10 ? 1 : 0),@baseRadius); }
    public static CHeli? @GenerateHeli(CPed? @target,bool @newsHeli) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1749 >(1749)(@target?.Pointer ?? IntPtr.Zero,(@newsHeli ? 1 : 0)); return __sdkResult == IntPtr.Zero ? null : new CHeli(__sdkResult); }
    public static bool @TestSniperCollision(CVector? @origin,CVector? @target) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1750 >(1750)(@origin?.Pointer ?? IntPtr.Zero,@target?.Pointer ?? IntPtr.Zero); return __sdkResult != 0; }
    public static void @UpdateHelis() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1751 >(1751)(); }
    public static void @RenderAllHeliSearchLights() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1752 >(1752)(); }
}
