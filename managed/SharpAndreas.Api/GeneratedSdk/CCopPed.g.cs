// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CCopPed : CPed
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=1988;
    public CCopPed(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("field_79C")]
    public sbyte @Field79C { get => SdkMemory.Read<sbyte >(Pointer+1948); set { SdkMemory.Write(Pointer+1948,value); } }
    [NativeMember("field_79D")]
    public sbyte @Field79D { get => SdkMemory.Read<sbyte >(Pointer+1949); set { SdkMemory.Write(Pointer+1949,value); } }
    [NativeMember("m_copType")]
    public eCopType @CopType { get => SdkMemory.Read<eCopType >(Pointer+1952); set { SdkMemory.Write(Pointer+1952,value); } }
    [NativeMember("field_7A4")]
    public int @Field7A4 { get => SdkMemory.Read<int >(Pointer+1956); set { SdkMemory.Write(Pointer+1956,value); } }
    [NativeMember("m_pCopPartner")]
    public CCopPed? @CopPartner { get => SdkMemory.Read<IntPtr>(Pointer+1960) == IntPtr.Zero ? null : new CCopPed(SdkMemory.Read<IntPtr>(Pointer+1960)); set { SdkMemory.Write(Pointer+1960,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_apCriminalsToKill")]
    public NativeArray<IntPtr> @CriminalsToKill { get => new NativeArray<IntPtr>(Pointer+1964,5); }
    [NativeMember("field_7C0")]
    public sbyte @Field7C0 { get => SdkMemory.Read<sbyte >(Pointer+1984); set { SdkMemory.Write(Pointer+1984,value); } }
    public void @InitializeAt(eCopType @copType) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2279 >(2279)(Pointer,(int)@copType); }
    public void @SetPartner(CCopPed? @partner) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2280 >(2280)(Pointer,@partner?.Pointer ?? IntPtr.Zero); }
    public void @AddCriminalToKill(CPed? @criminal) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2281 >(2281)(Pointer,@criminal?.Pointer ?? IntPtr.Zero); }
    public void @RemoveCriminalToKill(CPed? @arg0,int @criminalIdx) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2282 >(2282)(Pointer,@arg0?.Pointer ?? IntPtr.Zero,@criminalIdx); }
    public void @ClearCriminalsToKill() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2283 >(2283)(Pointer); }
}
