// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CStreamedScripts : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=2632;
    public CStreamedScripts(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_aScripts")]
    public NativeObjectArray<CStreamedScripts___unnamed__at_D__plugin_sdk_plugin_sa_game_sa_CStream_be0d4b57d8> @Scripts { get => new NativeObjectArray<CStreamedScripts___unnamed__at_D__plugin_sdk_plugin_sa_game_sa_CStream_be0d4b57d8>(Pointer+0,82,32); }
    [NativeMember("m_nLargestExternalSize")]
    public int @LargestExternalSize { get => SdkMemory.Read<int >(Pointer+2624); set { SdkMemory.Write(Pointer+2624,value); } }
    [NativeMember("m_nCountOfScripts")]
    public short @CountOfScripts { get => SdkMemory.Read<short >(Pointer+2628); set { SdkMemory.Write(Pointer+2628,value); } }
    [NativeMember("field_A46")]
    public short @FieldA46 { get => SdkMemory.Read<short >(Pointer+2630); set { SdkMemory.Write(Pointer+2630,value); } }
    public int @FindStreamedScript(NativePointer<sbyte> @scriptname) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3851 >(3851)(Pointer,@scriptname.Pointer); return __sdkResult; }
    public int @FindStreamedScriptQuiet(NativePointer<sbyte> @scriptName) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3852 >(3852)(Pointer,@scriptName.Pointer); return __sdkResult; }
    public short @GetProperIndexFromIndexUsedByScript(short @scmIndex) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3853 >(3853)(Pointer,@scmIndex); return __sdkResult; }
    public NativePointer<sbyte> @GetStreamedScriptFilename(ushort @index) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3854 >(3854)(Pointer,@index); return new NativePointer<sbyte>(__sdkResult); }
    public ushort @GetStreamedScriptWithThisStartAddress(NativePointer<byte> @dataPtr) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3855 >(3855)(Pointer,@dataPtr.Pointer); return __sdkResult; }
    public void @Initialise() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3856 >(3856)(Pointer); }
    public void @LoadStreamedScript(RwStream? @stream,int @index) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3857 >(3857)(Pointer,@stream?.Pointer ?? IntPtr.Zero,@index); }
    public void @ReInitialise() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3858 >(3858)(Pointer); }
    public void @ReadStreamedScriptData() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3859 >(3859)(Pointer); }
    public int @RegisterScript(NativePointer<sbyte> @scriptName) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3860 >(3860)(Pointer,@scriptName.Pointer); return __sdkResult; }
    public void @RemoveStreamedScriptFromMemory(int @index) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3861 >(3861)(Pointer,@index); }
    public CRunningScript? @StartNewStreamedScript(int @index) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3862 >(3862)(Pointer,@index); return __sdkResult == IntPtr.Zero ? null : new CRunningScript(__sdkResult); }
}
