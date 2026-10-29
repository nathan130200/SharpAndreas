// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CModelInfoAccelerator : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=28;
    public CModelInfoAccelerator(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_pIDs")]
    public NativePointer<ushort> @IDs { get => new NativePointer<ushort>(SdkMemory.Read<IntPtr>(Pointer+0)); set { SdkMemory.Write(Pointer+0,value.Pointer); } }
    [NativeMember("m_nNumIDs")]
    public ushort @CountIDs { get => SdkMemory.Read<ushort >(Pointer+4); set { SdkMemory.Write(Pointer+4,value); } }
    [NativeMember("m_szFilePath")]
    public NativeArray<sbyte> @FilePath { get => new NativeArray<sbyte>(Pointer+6,20); }
    [NativeMember("field_1A")]
    public sbyte @Field1A { get => SdkMemory.Read<sbyte >(Pointer+26); set { SdkMemory.Write(Pointer+26,value); } }
    [NativeMember("m_bFileRead")]
    public bool @FileRead { get => SdkMemory.Read<bool >(Pointer+27); set { SdkMemory.Write(Pointer+27,value); } }
    public void @Init() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3195 >(3195)(Pointer); }
    public void @AddModelInfoId(ushort @modelId) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3196 >(3196)(Pointer,@modelId); }
    public ushort @GetNextModelInfoId() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3197 >(3197)(Pointer); return __sdkResult; }
    public void @AllocModelInfoIds() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3198 >(3198)(Pointer); }
    public void @FreeModelInfoIds() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3199 >(3199)(Pointer); }
    public void @GetEntry(NativePointer<IntPtr> @arg0,NativePointer<int> @arg1,NativePointer<sbyte> @arg2) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3200 >(3200)(Pointer,@arg0.Pointer,@arg1.Pointer,@arg2.Pointer); }
    public void @End(NativePointer<sbyte> @arg0) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3201 >(3201)(Pointer,@arg0.Pointer); }
    public void @InitializeAt() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3202 >(3202)(Pointer); }
    public bool @GetModelInfoIdFile() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3203 >(3203)(Pointer); return __sdkResult != 0; }
    public void @EndOfLoadPhase() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3204 >(3204)(Pointer); }
    public bool @Begin(NativePointer<sbyte> @filePath) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3205 >(3205)(Pointer,@filePath.Pointer); return __sdkResult != 0; }
}
