// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class COnscreenTimer : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=340;
    public COnscreenTimer(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_Clock")]
    public COnscreenTimerEntry @Clock { get => new COnscreenTimerEntry(Pointer+0); set { SdkMemory.Copy(value.Pointer,Pointer+0,64); } }
    [NativeMember("m_aCounters")]
    public NativeObjectArray<COnscreenCounterEntry> @Counters { get => new NativeObjectArray<COnscreenCounterEntry>(Pointer+64,4,68); }
    [NativeMember("m_bDisplay")]
    public bool @Display { get => SdkMemory.Read<bool >(Pointer+336); set { SdkMemory.Write(Pointer+336,value); } }
    [NativeMember("m_bPaused")]
    public bool @Paused { get => SdkMemory.Read<bool >(Pointer+337); set { SdkMemory.Write(Pointer+337,value); } }
    public void @AddClock(uint @varId,NativePointer<sbyte> @gxt,bool @bTimerDirection) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3235 >(3235)(Pointer,@varId,@gxt.Pointer,(@bTimerDirection ? 1 : 0)); }
    public void @AddCounter(int @varId,short @type,NativePointer<sbyte> @gxt,ushort @counterIndex) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3236 >(3236)(Pointer,@varId,@type,@gxt.Pointer,@counterIndex); }
    public void @AddCounterCounter(uint @varId,uint @maxValue,NativePointer<sbyte> @gxt,ushort @lineId) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3237 >(3237)(Pointer,@varId,@maxValue,@gxt.Pointer,@lineId); }
    public int @ClearClock(uint @varId) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3238 >(3238)(Pointer,@varId); return __sdkResult; }
    public void @ClearCounter(uint @varId) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3239 >(3239)(Pointer,@varId); }
    public void @Init() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3240 >(3240)(Pointer); }
    public void @Process() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3241 >(3241)(Pointer); }
    public void @ProcessForDisplay() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3242 >(3242)(Pointer); }
    public void @SetClockBeepCountdownSecs(uint @varID,uint @time) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3243 >(3243)(Pointer,@varID,@time); }
    public void @SetCounterColourID(uint @varID,byte @ColourID) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3244 >(3244)(Pointer,@varID,@ColourID); }
    public void @SetCounterFlashWhenFirstDisplayed(uint @varId,byte @bFlashWhenFirstDisplayed) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3245 >(3245)(Pointer,@varId,@bFlashWhenFirstDisplayed); }
}
