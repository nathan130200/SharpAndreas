// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CFire : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=40;
    public CFire(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_nFlags")]
    public CFire___unnamed__at_D__plugin_sdk_plugin_sa_game_sa_CFire_h_15_5__6d529fb09f @Flags { get => new CFire___unnamed__at_D__plugin_sdk_plugin_sa_game_sa_CFire_h_15_5__6d529fb09f(Pointer+0); set { SdkMemory.Copy(value.Pointer,Pointer+0,1); } }
    [NativeMember("m_nScriptReferenceIndex")]
    public short @ScriptReferenceIndex { get => SdkMemory.Read<short >(Pointer+2); set { SdkMemory.Write(Pointer+2,value); } }
    [NativeMember("m_vecPosition")]
    public CVector @Position { get => new CVector(Pointer+4); set { SdkMemory.Copy(value.Pointer,Pointer+4,12); } }
    [NativeMember("m_pEntityTarget")]
    public CEntity? @EntityTarget { get => SdkMemory.Read<IntPtr>(Pointer+16) == IntPtr.Zero ? null : new CEntity(SdkMemory.Read<IntPtr>(Pointer+16)); set { SdkMemory.Write(Pointer+16,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_pEntityCreator")]
    public CEntity? @EntityCreator { get => SdkMemory.Read<IntPtr>(Pointer+20) == IntPtr.Zero ? null : new CEntity(SdkMemory.Read<IntPtr>(Pointer+20)); set { SdkMemory.Write(Pointer+20,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_nTimeToBurn")]
    public uint @TimeToBurn { get => SdkMemory.Read<uint >(Pointer+24); set { SdkMemory.Write(Pointer+24,value); } }
    [NativeMember("m_fStrength")]
    public float @Strength { get => SdkMemory.Read<float >(Pointer+28); set { SdkMemory.Write(Pointer+28,value); } }
    [NativeMember("m_nNumGenerationsAllowed")]
    public sbyte @CountGenerationsAllowed { get => SdkMemory.Read<sbyte >(Pointer+32); set { SdkMemory.Write(Pointer+32,value); } }
    [NativeMember("m_nRemovalDist")]
    public byte @RemovalDistance { get => SdkMemory.Read<byte >(Pointer+33); set { SdkMemory.Write(Pointer+33,value); } }
    [NativeMember("m_pFxSystem")]
    public FxSystem_c? @FxSystem { get => SdkMemory.Read<IntPtr>(Pointer+36) == IntPtr.Zero ? null : new FxSystem_c(SdkMemory.Read<IntPtr>(Pointer+36)); set { SdkMemory.Write(Pointer+36,value?.Pointer ?? IntPtr.Zero); } }
    public void @InitializeAt() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D848 >(848)(Pointer); }
    public void @DestroyNative() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D849 >(849)(Pointer); }
    public void @Initialise() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D850 >(850)(Pointer); }
    public void @CreateFxSysForStrength(RwV3d? @point,RwMatrixTag? @matrix) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D851 >(851)(Pointer,@point?.Pointer ?? IntPtr.Zero,@matrix?.Pointer ?? IntPtr.Zero); }
    public void @Extinguish() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D852 >(852)(Pointer); }
    public void @ProcessFire() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D853 >(853)(Pointer); }
}
