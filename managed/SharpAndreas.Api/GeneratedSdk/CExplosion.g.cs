// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CExplosion : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=124;
    public CExplosion(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_nType")]
    public uint @Type { get => SdkMemory.Read<uint >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("m_vecPosition")]
    public CVector @Position { get => new CVector(Pointer+4); set { SdkMemory.Copy(value.Pointer,Pointer+4,12); } }
    [NativeMember("m_fRadius")]
    public float @Radius { get => SdkMemory.Read<float >(Pointer+16); set { SdkMemory.Write(Pointer+16,value); } }
    [NativeMember("m_fPropagationRate")]
    public float @PropagationRate { get => SdkMemory.Read<float >(Pointer+20); set { SdkMemory.Write(Pointer+20,value); } }
    [NativeMember("m_pCreator")]
    public CEntity? @Creator { get => SdkMemory.Read<IntPtr>(Pointer+24) == IntPtr.Zero ? null : new CEntity(SdkMemory.Read<IntPtr>(Pointer+24)); set { SdkMemory.Write(Pointer+24,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_pVictim")]
    public CEntity? @Victim { get => SdkMemory.Read<IntPtr>(Pointer+28) == IntPtr.Zero ? null : new CEntity(SdkMemory.Read<IntPtr>(Pointer+28)); set { SdkMemory.Write(Pointer+28,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_nExpireTime")]
    public int @ExpireTime { get => SdkMemory.Read<int >(Pointer+32); set { SdkMemory.Write(Pointer+32,value); } }
    [NativeMember("m_fDamagePercentage")]
    public float @DamagePercentage { get => SdkMemory.Read<float >(Pointer+36); set { SdkMemory.Write(Pointer+36,value); } }
    [NativeMember("m_bIsActive")]
    public bool @IsActive { get => SdkMemory.Read<bool >(Pointer+40); set { SdkMemory.Write(Pointer+40,value); } }
    [NativeMember("m_nActiveCounter")]
    public byte @ActiveCounter { get => SdkMemory.Read<byte >(Pointer+41); set { SdkMemory.Write(Pointer+41,value); } }
    [NativeMember("m_bMakeSound")]
    public bool @MakeSound { get => SdkMemory.Read<bool >(Pointer+42); set { SdkMemory.Write(Pointer+42,value); } }
    [NativeMember("m_nCreatedTime")]
    public int @CreatedTime { get => SdkMemory.Read<int >(Pointer+44); set { SdkMemory.Write(Pointer+44,value); } }
    [NativeMember("m_nParticlesExpireTime")]
    public int @ParticlesExpireTime { get => SdkMemory.Read<int >(Pointer+48); set { SdkMemory.Write(Pointer+48,value); } }
    [NativeMember("m_fVisibleDistance")]
    public float @VisibleDistance { get => SdkMemory.Read<float >(Pointer+52); set { SdkMemory.Write(Pointer+52,value); } }
    [NativeMember("m_fGroundZ")]
    public float @GroundZ { get => SdkMemory.Read<float >(Pointer+56); set { SdkMemory.Write(Pointer+56,value); } }
    [NativeMember("m_nFuelTimer")]
    public int @FuelTimer { get => SdkMemory.Read<int >(Pointer+60); set { SdkMemory.Write(Pointer+60,value); } }
    [NativeMember("m_vecFuelDirection")]
    public NativeObjectArray<CVector> @FuelDirection { get => new NativeObjectArray<CVector>(Pointer+64,3,12); }
    [NativeMember("m_fFuelOffsetDistance")]
    public NativeArray<float> @FuelOffsetDistance { get => new NativeArray<float>(Pointer+100,3); }
    [NativeMember("m_fFuelSpeed")]
    public NativeArray<float> @FuelSpeed { get => new NativeArray<float>(Pointer+112,3); }
    [NativeMember("m_ExplosionAudioEntity")]
    public static CAEExplosionAudioEntity @ExplosionAudioEntity { get => new CAEExplosionAudioEntity(new IntPtr(0xC888D0)); set { SdkMemory.Copy(value.Pointer,new IntPtr(0xC888D0),128); } }
    public static void @ClearAllExplosions() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2530 >(2530)(); }
    public static void @Shutdown() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2531 >(2531)(); }
    public static byte @GetExplosionActiveCounter(byte @explosionId) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2532 >(2532)(@explosionId); return __sdkResult; }
    public static void @ResetExplosionActiveCounter(byte @explosionId) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2533 >(2533)(@explosionId); }
    public static bool @DoesExplosionMakeSound(byte @explosionId) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2534 >(2534)(@explosionId); return __sdkResult != 0; }
    public static uint @GetExplosionType(byte @explosionId) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2535 >(2535)(@explosionId); return __sdkResult; }
    public static CVector? @GetExplosionPosition(byte @explosionId) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2536 >(2536)(@explosionId); return __sdkResult == IntPtr.Zero ? null : new CVector(__sdkResult); }
    public static bool @TestForExplosionInArea(eExplosionType @explosionType,float @x1,float @y1,float @z1,float @x2,float @y2,float @z2) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2537 >(2537)((int)@explosionType,@x1,@y1,@z1,@x2,@y2,@z2); return __sdkResult != 0; }
    public static void @RemoveAllExplosionsInArea(CVector @posn,float @radius) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2538 >(2538)(@posn.Pointer,@radius); }
    public static void @Initialise() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2539 >(2539)(); }
    public static bool @AddExplosion(CEntity? @victim,CEntity? @creator,eExplosionType @explosionType,CVector @posn,uint @time,byte @makeSound,float @camShake,byte @visibility) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2540 >(2540)(@victim?.Pointer ?? IntPtr.Zero,@creator?.Pointer ?? IntPtr.Zero,(int)@explosionType,@posn.Pointer,@time,@makeSound,@camShake,@visibility); return __sdkResult != 0; }
    public static void @Update() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2541 >(2541)(); }
}
