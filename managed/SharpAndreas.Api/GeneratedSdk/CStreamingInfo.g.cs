// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CStreamingInfo : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=20;
    public CStreamingInfo(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_nNextIndex")]
    public short @NextIndex { get => SdkMemory.Read<short >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("m_nPrevIndex")]
    public short @PrevIndex { get => SdkMemory.Read<short >(Pointer+2); set { SdkMemory.Write(Pointer+2,value); } }
    [NativeMember("m_nNextIndexOnCd")]
    public short @NextIndexOnCd { get => SdkMemory.Read<short >(Pointer+4); set { SdkMemory.Write(Pointer+4,value); } }
    [NativeMember("m_nFlags")]
    public byte @Flags { get => SdkMemory.Read<byte >(Pointer+6); set { SdkMemory.Write(Pointer+6,value); } }
    [NativeMember("m_nImgId")]
    public byte @ImgId { get => SdkMemory.Read<byte >(Pointer+7); set { SdkMemory.Write(Pointer+7,value); } }
    [NativeMember("m_nCdPosn")]
    public uint @CdPosition { get => SdkMemory.Read<uint >(Pointer+8); set { SdkMemory.Write(Pointer+8,value); } }
    [NativeMember("m_nCdSize")]
    public uint @CdSize { get => SdkMemory.Read<uint >(Pointer+12); set { SdkMemory.Write(Pointer+12,value); } }
    [NativeMember("m_nLoadState")]
    public byte @LoadState { get => SdkMemory.Read<byte >(Pointer+16); set { SdkMemory.Write(Pointer+16,value); } }
    [NativeMember("ms_pArrayBase")]
    public static CStreamingInfo? @ArrayBase { get => SdkMemory.Read<IntPtr>(new IntPtr(0x9654B4)) == IntPtr.Zero ? null : new CStreamingInfo(SdkMemory.Read<IntPtr>(new IntPtr(0x9654B4))); set { SdkMemory.Write(new IntPtr(0x9654B4),value?.Pointer ?? IntPtr.Zero); } }
    public void @AddToList(CStreamingInfo? @listStart) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3863 >(3863)(Pointer,@listStart?.Pointer ?? IntPtr.Zero); }
    public uint @GetCdPosn() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3864 >(3864)(Pointer); return __sdkResult; }
    public bool @GetCdPosnAndSize(NativePointer<uint> @CdPosn,NativePointer<uint> @CdSize) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3865 >(3865)(Pointer,@CdPosn.Pointer,@CdSize.Pointer); return __sdkResult != 0; }
    public uint @GetCdSize() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3866 >(3866)(Pointer); return __sdkResult; }
    public CStreamingInfo? @GetNext() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3867 >(3867)(Pointer); return __sdkResult == IntPtr.Zero ? null : new CStreamingInfo(__sdkResult); }
    public CStreamingInfo? @GetPrev() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3868 >(3868)(Pointer); return __sdkResult == IntPtr.Zero ? null : new CStreamingInfo(__sdkResult); }
    public bool @InList() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3869 >(3869)(Pointer); return __sdkResult != 0; }
    public void @Init() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3870 >(3870)(Pointer); }
    public void @RemoveFromList() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3871 >(3871)(Pointer); }
    public void @SetCdPosnAndSize(uint @CdPosn,uint @CdSize) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3872 >(3872)(Pointer,@CdPosn,@CdSize); }
}
