// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CHud : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=1;
    public CHud(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_BigMessage")]
    public static NativeArray<sbyte> @BigMessage { get => new NativeArray<sbyte>(new IntPtr(0xBAACC0),128); }
    [NativeMember("bScriptDontDisplayAreaName")]
    public static bool @ScriptDontDisplayAreaName { get => SdkMemory.Read<bool >(new IntPtr(0xBAA3F8)); set { SdkMemory.Write(new IntPtr(0xBAA3F8),value); } }
    [NativeMember("bScriptDontDisplayVehicleName")]
    public static bool @ScriptDontDisplayVehicleName { get => SdkMemory.Read<bool >(new IntPtr(0xBAA3F9)); set { SdkMemory.Write(new IntPtr(0xBAA3F9),value); } }
    [NativeMember("bScriptForceDisplayWithCounters")]
    public static bool @ScriptForceDisplayWithCounters { get => SdkMemory.Read<bool >(new IntPtr(0xBAA3FA)); set { SdkMemory.Write(new IntPtr(0xBAA3FA),value); } }
    [NativeMember("bScriptDontDisplayRadar")]
    public static bool @ScriptDontDisplayRadar { get => SdkMemory.Read<bool >(new IntPtr(0xBAA3FB)); set { SdkMemory.Write(new IntPtr(0xBAA3FB),value); } }
    [NativeMember("m_LastBreathTime")]
    public static int @LastBreathTime { get => SdkMemory.Read<int >(new IntPtr(0xBAA3FC)); set { SdkMemory.Write(new IntPtr(0xBAA3FC),value); } }
    [NativeMember("bDrawClock")]
    public static bool @DrawClock { get => SdkMemory.Read<bool >(new IntPtr(0xBAA400)); set { SdkMemory.Write(new IntPtr(0xBAA400),value); } }
    [NativeMember("m_WeaponState")]
    public static int @WeaponState { get => SdkMemory.Read<int >(new IntPtr(0xBAA404)); set { SdkMemory.Write(new IntPtr(0xBAA404),value); } }
    [NativeMember("m_WeaponFadeTimer")]
    public static int @WeaponFadeTimer { get => SdkMemory.Read<int >(new IntPtr(0xBAA408)); set { SdkMemory.Write(new IntPtr(0xBAA408),value); } }
    [NativeMember("m_WeaponTimer")]
    public static int @WeaponTimer { get => SdkMemory.Read<int >(new IntPtr(0xBAA40C)); set { SdkMemory.Write(new IntPtr(0xBAA40C),value); } }
    [NativeMember("m_LastWeapon")]
    public static int @LastWeapon { get => SdkMemory.Read<int >(new IntPtr(0xBAA410)); set { SdkMemory.Write(new IntPtr(0xBAA410),value); } }
    [NativeMember("m_WantedState")]
    public static int @WantedState { get => SdkMemory.Read<int >(new IntPtr(0xBAA414)); set { SdkMemory.Write(new IntPtr(0xBAA414),value); } }
    [NativeMember("m_WantedFadeTimer")]
    public static int @WantedFadeTimer { get => SdkMemory.Read<int >(new IntPtr(0xBAA418)); set { SdkMemory.Write(new IntPtr(0xBAA418),value); } }
    [NativeMember("m_WantedTimer")]
    public static int @WantedTimer { get => SdkMemory.Read<int >(new IntPtr(0xBAA41C)); set { SdkMemory.Write(new IntPtr(0xBAA41C),value); } }
    [NativeMember("m_LastWanted")]
    public static int @LastWanted { get => SdkMemory.Read<int >(new IntPtr(0xBAA420)); set { SdkMemory.Write(new IntPtr(0xBAA420),value); } }
    [NativeMember("m_DisplayScoreState")]
    public static int @DisplayScoreState { get => SdkMemory.Read<int >(new IntPtr(0xBAA424)); set { SdkMemory.Write(new IntPtr(0xBAA424),value); } }
    [NativeMember("m_DisplayScoreFadeTimer")]
    public static int @DisplayScoreFadeTimer { get => SdkMemory.Read<int >(new IntPtr(0xBAA428)); set { SdkMemory.Write(new IntPtr(0xBAA428),value); } }
    [NativeMember("m_DisplayScoreTimer")]
    public static int @DisplayScoreTimer { get => SdkMemory.Read<int >(new IntPtr(0xBAA42C)); set { SdkMemory.Write(new IntPtr(0xBAA42C),value); } }
    [NativeMember("m_LastDisplayScore")]
    public static int @LastDisplayScore { get => SdkMemory.Read<int >(new IntPtr(0xBAA430)); set { SdkMemory.Write(new IntPtr(0xBAA430),value); } }
    [NativeMember("m_EnergyLostState")]
    public static int @EnergyLostState { get => SdkMemory.Read<int >(new IntPtr(0xBAA434)); set { SdkMemory.Write(new IntPtr(0xBAA434),value); } }
    [NativeMember("m_EnergyLostFadeTimer")]
    public static int @EnergyLostFadeTimer { get => SdkMemory.Read<int >(new IntPtr(0xBAA438)); set { SdkMemory.Write(new IntPtr(0xBAA438),value); } }
    [NativeMember("m_EnergyLostTimer")]
    public static int @EnergyLostTimer { get => SdkMemory.Read<int >(new IntPtr(0xBAA43C)); set { SdkMemory.Write(new IntPtr(0xBAA43C),value); } }
    [NativeMember("m_LastTimeEnergyLost")]
    public static int @LastTimeEnergyLost { get => SdkMemory.Read<int >(new IntPtr(0xBAA440)); set { SdkMemory.Write(new IntPtr(0xBAA440),value); } }
    [NativeMember("m_pVehicleNameToPrint")]
    public static NativePointer<sbyte> @VehicleNameToPrint { get => new NativePointer<sbyte>(SdkMemory.Read<IntPtr>(new IntPtr(0xBAA444))); set { SdkMemory.Write(new IntPtr(0xBAA444),value.Pointer); } }
    [NativeMember("m_VehicleState")]
    public static int @VehicleState { get => SdkMemory.Read<int >(new IntPtr(0xBAA448)); set { SdkMemory.Write(new IntPtr(0xBAA448),value); } }
    [NativeMember("m_VehicleFadeTimer")]
    public static int @VehicleFadeTimer { get => SdkMemory.Read<int >(new IntPtr(0xBAA44C)); set { SdkMemory.Write(new IntPtr(0xBAA44C),value); } }
    [NativeMember("m_VehicleNameTimer")]
    public static int @VehicleNameTimer { get => SdkMemory.Read<int >(new IntPtr(0xBAA450)); set { SdkMemory.Write(new IntPtr(0xBAA450),value); } }
    [NativeMember("m_pLastVehicleName")]
    public static NativePointer<sbyte> @LastVehicleName { get => new NativePointer<sbyte>(SdkMemory.Read<IntPtr>(new IntPtr(0xBAA454))); set { SdkMemory.Write(new IntPtr(0xBAA454),value.Pointer); } }
    [NativeMember("m_pVehicleName")]
    public static NativePointer<sbyte> @VehicleName { get => new NativePointer<sbyte>(SdkMemory.Read<IntPtr>(new IntPtr(0xBAA458))); set { SdkMemory.Write(new IntPtr(0xBAA458),value.Pointer); } }
    [NativeMember("m_bDraw3dMarkers")]
    public static bool @Draw3dMarkers { get => SdkMemory.Read<bool >(new IntPtr(0xBAA45C)); set { SdkMemory.Write(new IntPtr(0xBAA45C),value); } }
    [NativeMember("m_Wants_To_Draw_Hud")]
    public static bool @WantsToDrawHud { get => SdkMemory.Read<bool >(new IntPtr(0xBAA45D)); set { SdkMemory.Write(new IntPtr(0xBAA45D),value); } }
    [NativeMember("m_fHelpMessageTime")]
    public static float @HelpMessageTime { get => SdkMemory.Read<float >(new IntPtr(0xBAA460)); set { SdkMemory.Write(new IntPtr(0xBAA460),value); } }
    [NativeMember("m_fHelpMessageBoxWidth")]
    public static float @HelpMessageBoxWidth { get => SdkMemory.Read<float >(new IntPtr(0x8D0934)); set { SdkMemory.Write(new IntPtr(0x8D0934),value); } }
    [NativeMember("m_bHelpMessagePermanent")]
    public static bool @HelpMessagePermanent { get => SdkMemory.Read<bool >(new IntPtr(0xBAA464)); set { SdkMemory.Write(new IntPtr(0xBAA464),value); } }
    [NativeMember("m_fHelpMessageStatUpdateValue")]
    public static float @HelpMessageStatUpdateValue { get => SdkMemory.Read<float >(new IntPtr(0xBAA468)); set { SdkMemory.Write(new IntPtr(0xBAA468),value); } }
    [NativeMember("m_nHelpMessageMaxStatValue")]
    public static ushort @HelpMessageMaxStatValue { get => SdkMemory.Read<ushort >(new IntPtr(0xBAA46C)); set { SdkMemory.Write(new IntPtr(0xBAA46C),value); } }
    [NativeMember("m_nHelpMessageStatId")]
    public static ushort @HelpMessageStatId { get => SdkMemory.Read<ushort >(new IntPtr(0xBAA470)); set { SdkMemory.Write(new IntPtr(0xBAA470),value); } }
    [NativeMember("m_bHelpMessageQuick")]
    public static bool @HelpMessageQuick { get => SdkMemory.Read<bool >(new IntPtr(0xBAA472)); set { SdkMemory.Write(new IntPtr(0xBAA472),value); } }
    [NativeMember("m_nHelpMessageState")]
    public static int @HelpMessageState { get => SdkMemory.Read<int >(new IntPtr(0xBAA474)); set { SdkMemory.Write(new IntPtr(0xBAA474),value); } }
    [NativeMember("m_nHelpMessageFadeTimer")]
    public static int @HelpMessageFadeTimer { get => SdkMemory.Read<int >(new IntPtr(0xBAA478)); set { SdkMemory.Write(new IntPtr(0xBAA478),value); } }
    [NativeMember("m_nHelpMessageTimer")]
    public static int @HelpMessageTimer { get => SdkMemory.Read<int >(new IntPtr(0xBAA47C)); set { SdkMemory.Write(new IntPtr(0xBAA47C),value); } }
    [NativeMember("m_pHelpMessageToPrint")]
    public static NativePointer<sbyte> @HelpMessageToPrint { get => new NativePointer<sbyte>(new IntPtr(0xBAA480)); }
    [NativeMember("m_pLastHelpMessage")]
    public static NativePointer<sbyte> @LastHelpMessage { get => new NativePointer<sbyte>(new IntPtr(0xBAA610)); }
    [NativeMember("m_pHelpMessage")]
    public static NativePointer<sbyte> @HelpMessage { get => new NativePointer<sbyte>(new IntPtr(0xBAA7A0)); }
    [NativeMember("m_ZoneState")]
    public static int @ZoneState { get => SdkMemory.Read<int >(new IntPtr(0xBAA930)); set { SdkMemory.Write(new IntPtr(0xBAA930),value); } }
    [NativeMember("m_ZoneFadeTimer")]
    public static int @ZoneFadeTimer { get => SdkMemory.Read<int >(new IntPtr(0xBAA934)); set { SdkMemory.Write(new IntPtr(0xBAA934),value); } }
    [NativeMember("m_ZoneNameTimer")]
    public static int @ZoneNameTimer { get => SdkMemory.Read<int >(new IntPtr(0xBAA938)); set { SdkMemory.Write(new IntPtr(0xBAA938),value); } }
    [NativeMember("m_Message")]
    public static NativePointer<sbyte> @Message { get => new NativePointer<sbyte>(new IntPtr(0xBAB040)); }
    [NativeMember("m_ZoneToPrint")]
    public static NativePointer<sbyte> @ZoneToPrint { get => new NativePointer<sbyte>(SdkMemory.Read<IntPtr>(new IntPtr(0xBAB1D0))); set { SdkMemory.Write(new IntPtr(0xBAB1D0),value.Pointer); } }
    [NativeMember("m_pLastZoneName")]
    public static NativePointer<sbyte> @LastZoneName { get => new NativePointer<sbyte>(SdkMemory.Read<IntPtr>(new IntPtr(0xBAB1D4))); set { SdkMemory.Write(new IntPtr(0xBAB1D4),value.Pointer); } }
    [NativeMember("m_pZoneName")]
    public static NativePointer<sbyte> @ZoneName { get => new NativePointer<sbyte>(SdkMemory.Read<IntPtr>(new IntPtr(0xBAB1D8))); set { SdkMemory.Write(new IntPtr(0xBAB1D8),value.Pointer); } }
    [NativeMember("m_ItemToFlash")]
    public static short @ItemToFlash { get => SdkMemory.Read<short >(new IntPtr(0xBAB1DC)); set { SdkMemory.Write(new IntPtr(0xBAB1DC),value); } }
    [NativeMember("bDrawingVitalStats")]
    public static bool @DrawingVitalStats { get => SdkMemory.Read<bool >(new IntPtr(0xBAB1DE)); set { SdkMemory.Write(new IntPtr(0xBAB1DE),value); } }
    [NativeMember("Sprites")]
    public static CSprite2d? @Sprites { get => new IntPtr(0xBAB1FC) == IntPtr.Zero ? null : new CSprite2d(new IntPtr(0xBAB1FC)); }
    public static void @Draw() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2942 >(2942)(); }
    public static void @DrawAfterFade() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2943 >(2943)(); }
    public static void @DrawAreaName() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2944 >(2944)(); }
    public static void @DrawBustedWastedMessage() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2945 >(2945)(); }
    public static void @DrawCrossHairs() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2946 >(2946)(); }
    public static float @DrawFadeState(DRAW_FADE_STATE @fadeState,int @arg1) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2947 >(2947)((int)@fadeState,@arg1); return __sdkResult; }
    public static void @DrawHelpText() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2948 >(2948)(); }
    public static void @DrawMissionTimers() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2949 >(2949)(); }
    public static void @DrawMissionTitle() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2950 >(2950)(); }
    public static void @DrawOddJobMessage(byte @priority) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2951 >(2951)(@priority); }
    public static void @DrawRadar() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2952 >(2952)(); }
    public static void @DrawScriptText(byte @priority) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2953 >(2953)(@priority); }
    public static void @DrawSubtitles() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2954 >(2954)(); }
    public static void @DrawSuccessFailedMessage() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2955 >(2955)(); }
    public static void @DrawVehicleName() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2956 >(2956)(); }
    public static void @DrawVitalStats() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2957 >(2957)(); }
    public static void @GetRidOfAllHudMessages(byte @arg0) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2958 >(2958)(@arg0); }
    public static float @GetYPosBasedOnHealth(byte @playerId,float @pos,sbyte @offset) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2959 >(2959)(@playerId,@pos,@offset); return __sdkResult; }
    public static bool @HelpMessageDisplayed() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2960 >(2960)(); return __sdkResult != 0; }
    public static void @Initialise() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2961 >(2961)(); }
    public static void @ReInitialise() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2962 >(2962)(); }
    public static void @ResetWastedText() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2963 >(2963)(); }
    public static void @SetBigMessage(NativePointer<sbyte> @text,ushort @style) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2964 >(2964)(@text.Pointer,@style); }
    public static void @SetHelpMessage(NativePointer<sbyte> @text,bool @quickMessage,bool @permanent,bool @addToBrief) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2965 >(2965)(@text.Pointer,(@quickMessage ? 1 : 0),(@permanent ? 1 : 0),(@addToBrief ? 1 : 0)); }
    public static void @SetHelpMessageStatUpdate(byte @state,ushort @statId,float @diff,float @max) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2966 >(2966)(@state,@statId,@diff,@max); }
    public static void @SetHelpMessageWithNumber(NativePointer<sbyte> @text,int @number,bool @quickMessage,bool @permanent) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2967 >(2967)(@text.Pointer,@number,(@quickMessage ? 1 : 0),(@permanent ? 1 : 0)); }
    public static void @SetMessage(NativePointer<sbyte> @text) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2968 >(2968)(@text.Pointer); }
    public static void @SetVehicleName(NativePointer<sbyte> @name) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2969 >(2969)(@name.Pointer); }
    public static void @SetZoneName(NativePointer<sbyte> @name,byte @displayState) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2970 >(2970)(@name.Pointer,@displayState); }
    public static void @Shutdown() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2971 >(2971)(); }
    public static void @DrawAmmo(CPed? @ped,int @x,int @y,float @alpha) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2972 >(2972)(@ped?.Pointer ?? IntPtr.Zero,@x,@y,@alpha); }
    public static void @DrawPlayerInfo() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2973 >(2973)(); }
    public static void @DrawTripSkip() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2974 >(2974)(); }
    public static void @DrawWanted() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2975 >(2975)(); }
    public static void @DrawWeaponIcon(CPed? @ped,int @x,int @y,float @alpha) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2976 >(2976)(@ped?.Pointer ?? IntPtr.Zero,@x,@y,@alpha); }
    public static void @RenderArmorBar(int @playerId,int @x,int @y) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2977 >(2977)(@playerId,@x,@y); }
    public static void @RenderBreathBar(int @playerId,int @x,int @y) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2978 >(2978)(@playerId,@x,@y); }
    public static void @RenderHealthBar(int @playerId,int @x,int @y) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2979 >(2979)(@playerId,@x,@y); }
}
