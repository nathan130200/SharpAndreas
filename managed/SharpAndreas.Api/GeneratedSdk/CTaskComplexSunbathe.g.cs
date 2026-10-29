// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CTaskComplexSunbathe : CTaskComplex
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=56;
    public CTaskComplexSunbathe(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_bStartStanding")]
    public bool @StartStanding { get => SdkMemory.Read<bool >(Pointer+12); set { SdkMemory.Write(Pointer+12,value); } }
    [NativeMember("m_bBathing")]
    public bool @Bathing { get => SdkMemory.Read<bool >(Pointer+13); set { SdkMemory.Write(Pointer+13,value); } }
    [NativeMember("m_bBeachAnimsReferenced")]
    public bool @BeachAnimsReferenced { get => SdkMemory.Read<bool >(Pointer+14); set { SdkMemory.Write(Pointer+14,value); } }
    [NativeMember("m_bSunbatheAnimsReferenced")]
    public bool @SunbatheAnimsReferenced { get => SdkMemory.Read<bool >(Pointer+15); set { SdkMemory.Write(Pointer+15,value); } }
    [NativeMember("m_bAborted")]
    public bool @Aborted { get => SdkMemory.Read<bool >(Pointer+16); set { SdkMemory.Write(Pointer+16,value); } }
    [NativeMember("m_BathingTimer")]
    public CTaskTimer @BathingTimer { get => new CTaskTimer(Pointer+20); set { SdkMemory.Copy(value.Pointer,Pointer+20,12); } }
    [NativeMember("m_SunbatherType")]
    public eSunbatherType @SunbatherType { get => SdkMemory.Read<eSunbatherType >(Pointer+32); set { SdkMemory.Write(Pointer+32,value); } }
    [NativeMember("m_pBeachAnimBlock")]
    public CAnimBlock? @BeachAnimationBlock { get => SdkMemory.Read<IntPtr>(Pointer+36) == IntPtr.Zero ? null : new CAnimBlock(SdkMemory.Read<IntPtr>(Pointer+36)); set { SdkMemory.Write(Pointer+36,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_pSunbatheAnimBlock")]
    public CAnimBlock? @SunbatheAnimationBlock { get => SdkMemory.Read<IntPtr>(Pointer+40) == IntPtr.Zero ? null : new CAnimBlock(SdkMemory.Read<IntPtr>(Pointer+40)); set { SdkMemory.Write(Pointer+40,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_BeachAnimBlockIndex")]
    public int @BeachAnimationBlockIndex { get => SdkMemory.Read<int >(Pointer+44); set { SdkMemory.Write(Pointer+44,value); } }
    [NativeMember("m_SunbatheAnimBlockIndex")]
    public int @SunbatheAnimationBlockIndex { get => SdkMemory.Read<int >(Pointer+48); set { SdkMemory.Write(Pointer+48,value); } }
    [NativeMember("m_pTowel")]
    public CObject? @Towel { get => SdkMemory.Read<IntPtr>(Pointer+52) == IntPtr.Zero ? null : new CObject(SdkMemory.Read<IntPtr>(Pointer+52)); set { SdkMemory.Write(Pointer+52,value?.Pointer ?? IntPtr.Zero); } }
    public void @InitializeAt(CObject? @pTowel,bool @bStartStanding) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4033 >(4033)(Pointer,@pTowel?.Pointer ?? IntPtr.Zero,(@bStartStanding ? 1 : 0)); }
}
