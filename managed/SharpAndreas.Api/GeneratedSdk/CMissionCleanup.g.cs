// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CMissionCleanup : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=604;
    public CMissionCleanup(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_Objects")]
    public NativeObjectArray<tMissionCleanupEntity> @Objects { get => new NativeObjectArray<tMissionCleanupEntity>(Pointer+0,75,8); }
    [NativeMember("m_Count")]
    public sbyte @Count { get => SdkMemory.Read<sbyte >(Pointer+600); set { SdkMemory.Write(Pointer+600,value); } }
    public void @InitializeAt() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3188 >(3188)(Pointer); }
    public void @Init() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3189 >(3189)(Pointer); }
    public void @Process() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3190 >(3190)(Pointer); }
    public tMissionCleanupEntity? @FindFree() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3191 >(3191)(Pointer); return __sdkResult == IntPtr.Zero ? null : new tMissionCleanupEntity(__sdkResult); }
    public void @AddEntityToList(int @handle,MissionCleanUpEntityType @type) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3192 >(3192)(Pointer,@handle,(int)@type); }
    public void @RemoveEntityFromList(int @handle,MissionCleanUpEntityType @type) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3193 >(3193)(Pointer,@handle,(int)@type); }
    public void @CheckIfCollisionHasLoadedForMissionObjects() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3194 >(3194)(Pointer); }
}
