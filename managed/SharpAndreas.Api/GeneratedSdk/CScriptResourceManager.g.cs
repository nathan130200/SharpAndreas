// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CScriptResourceManager : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=900;
    public CScriptResourceManager(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_aScriptResources")]
    public NativeObjectArray<CScriptResourceManager___unnamed__at_D__plugin_sdk_plugin_sa_game_sa_C_462fc3ef09> @ScriptResources { get => new NativeObjectArray<CScriptResourceManager___unnamed__at_D__plugin_sdk_plugin_sa_game_sa_C_462fc3ef09>(Pointer+0,75,12); }
    public void @AddToResourceManager(int @modelID,uint @ResourceType,CRunningScript? @pScript) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3694 >(3694)(Pointer,@modelID,@ResourceType,@pScript?.Pointer ?? IntPtr.Zero); }
    public bool @HasResourceBeenRequested(int @ModelId,uint @a4) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3695 >(3695)(Pointer,@ModelId,@a4); return __sdkResult != 0; }
    public bool @RemoveFromResourceManager(int @modelID,uint @ResourceType,CRunningScript? @pScript) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3696 >(3696)(Pointer,@modelID,@ResourceType,@pScript?.Pointer ?? IntPtr.Zero); return __sdkResult != 0; }
}
