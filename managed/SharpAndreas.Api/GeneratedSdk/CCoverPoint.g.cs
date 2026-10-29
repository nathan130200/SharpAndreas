// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CCoverPoint : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=28;
    public CCoverPoint(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_nMaxPedsInCover")]
    public sbyte @MaxPedsInCover { get => SdkMemory.Read<sbyte >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("m_nCoverType")]
    public sbyte @CoverType { get => SdkMemory.Read<sbyte >(Pointer+1); set { SdkMemory.Write(Pointer+1,value); } }
    [NativeMember("m_nDirection")]
    public sbyte @Direction { get => SdkMemory.Read<sbyte >(Pointer+2); set { SdkMemory.Write(Pointer+2,value); } }
    [NativeMember("m_vecOffset")]
    public CVector @Offset { get => new CVector(Pointer+4); set { SdkMemory.Copy(value.Pointer,Pointer+4,12); } }
    [NativeMember("m_pCoverEntity")]
    public CEntity? @CoverEntity { get => SdkMemory.Read<IntPtr>(Pointer+16) == IntPtr.Zero ? null : new CEntity(SdkMemory.Read<IntPtr>(Pointer+16)); set { SdkMemory.Write(Pointer+16,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_apCoveredPeds")]
    public NativeArray<IntPtr> @CoveredPeds { get => new NativeArray<IntPtr>(Pointer+20,2); }
    public bool @CanAccomodateAnotherPed() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2295 >(2295)(Pointer); return __sdkResult != 0; }
    public void @ReleaseCoverPointForPed(CPed? @ped) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2296 >(2296)(Pointer,@ped?.Pointer ?? IntPtr.Zero); }
    public void @ReserveCoverPointForPed(CPed? @ped) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2297 >(2297)(Pointer,@ped?.Pointer ?? IntPtr.Zero); }
}
