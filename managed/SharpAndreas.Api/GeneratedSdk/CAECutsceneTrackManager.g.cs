// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CAECutsceneTrackManager : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=12;
    public CAECutsceneTrackManager(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("gap0")]
    public NativeArray<byte> @Gap0 { get => new NativeArray<byte>(Pointer+0,8); }
    [NativeMember("m_nStatus")]
    public uint @Status { get => SdkMemory.Read<uint >(Pointer+8); set { SdkMemory.Write(Pointer+8,value); } }
    public void @StopCutsceneTrack() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D253 >(253)(Pointer); }
    public void @StartTrackPlayback() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D254 >(254)(Pointer); }
    public void @Service(int @time) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D255 >(255)(Pointer,@time); }
    public void @PreloadBeatTrack(sbyte @arg1,bool @arg2) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D256 >(256)(Pointer,@arg1,(@arg2 ? 1 : 0)); }
    public void @PlayPreloadedCutsceneTrack() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D257 >(257)(Pointer); }
    public bool @IsCutsceneTrackActive() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D258 >(258)(Pointer); return __sdkResult != 0; }
    public sbyte @GetCutsceneTrackStatus() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D259 >(259)(Pointer); return __sdkResult; }
}
