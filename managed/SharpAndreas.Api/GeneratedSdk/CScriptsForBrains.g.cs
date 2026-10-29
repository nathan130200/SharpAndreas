// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CScriptsForBrains : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=1400;
    public CScriptsForBrains(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_aScriptForBrains")]
    public NativeObjectArray<CScriptsForBrains___unnamed__at_D__plugin_sdk_plugin_sa_game_sa_CScrip_16b3842072> @ScriptForBrains { get => new NativeObjectArray<CScriptsForBrains___unnamed__at_D__plugin_sdk_plugin_sa_game_sa_CScrip_16b3842072>(Pointer+0,70,20); }
    public void @AddNewScriptBrain(short @ImgIndex,short @Model,ushort @Priority,sbyte @attachType,sbyte @Type,float @Radius) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3697 >(3697)(Pointer,@ImgIndex,@Model,@Priority,@attachType,@Type,@Radius); }
    public void @AddNewStreamedScriptBrainForCodeUse(short @a2,NativePointer<sbyte> @a3,sbyte @attachtype) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3698 >(3698)(Pointer,@a2,@a3.Pointer,@attachtype); }
    public void @CheckIfNewEntityNeedsScript(CEntity? @pEntity,sbyte @attachType,NativePointer<IntPtr> @unused) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3699 >(3699)(Pointer,@pEntity?.Pointer ?? IntPtr.Zero,@attachType,@unused.Pointer); }
    public short @GetIndexOfScriptBrainWithThisName(NativePointer<sbyte> @name,sbyte @Attachtype) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3700 >(3700)(Pointer,@name.Pointer,@Attachtype); return __sdkResult; }
    public bool @HasAttractorScriptBrainWithThisNameLoaded(NativePointer<sbyte> @name) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3701 >(3701)(Pointer,@name.Pointer); return __sdkResult != 0; }
    public void @Init() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3702 >(3702)(Pointer); }
    public bool @IsObjectWithinBrainActivationRange(CObject? @entity,CVector? @point) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3703 >(3703)(Pointer,@entity?.Pointer ?? IntPtr.Zero,@point?.Pointer ?? IntPtr.Zero); return __sdkResult != 0; }
    public void @MarkAttractorScriptBrainWithThisNameAsNoLongerNeeded(NativePointer<sbyte> @name) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3704 >(3704)(Pointer,@name.Pointer); }
    public void @RequestAttractorScriptBrainWithThisName(NativePointer<sbyte> @name) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3705 >(3705)(Pointer,@name.Pointer); }
    public void @StartAttractorScriptBrainWithThisName(NativePointer<sbyte> @name,CEntity? @pEntity,byte @bHasAScriptBrain) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3706 >(3706)(Pointer,@name.Pointer,@pEntity?.Pointer ?? IntPtr.Zero,@bHasAScriptBrain); }
    public void @StartNewStreamedScriptBrain(byte @index,CEntity? @pEntity,byte @bHasAScriptBrain) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3707 >(3707)(Pointer,@index,@pEntity?.Pointer ?? IntPtr.Zero,@bHasAScriptBrain); }
    public void @StartOrRequestNewStreamedScriptBrain(byte @index,CEntity? @pEntity,sbyte @attachType,byte @bAddToWaitingArray) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3708 >(3708)(Pointer,@index,@pEntity?.Pointer ?? IntPtr.Zero,@attachType,@bAddToWaitingArray); }
    public void @StartOrRequestNewStreamedScriptBrainWithThisName(NativePointer<sbyte> @name,CEntity? @pEntity,sbyte @attachType) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3709 >(3709)(Pointer,@name.Pointer,@pEntity?.Pointer ?? IntPtr.Zero,@attachType); }
    public void @SwitchAllObjectBrainsWithThisID(sbyte @ID,bool @bStatus) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3710 >(3710)(Pointer,@ID,(@bStatus ? 1 : 0)); }
}
