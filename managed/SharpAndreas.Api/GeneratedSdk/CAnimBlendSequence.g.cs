// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CAnimBlendSequence : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=12;
    public CAnimBlendSequence(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_nHash")]
    public uint @Hash { get => SdkMemory.Read<uint >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("m_nFlags")]
    public ushort @Flags { get => SdkMemory.Read<ushort >(Pointer+4); set { SdkMemory.Write(Pointer+4,value); } }
    [NativeMember("m_nFrameCount")]
    public ushort @FrameCount { get => SdkMemory.Read<ushort >(Pointer+6); set { SdkMemory.Write(Pointer+6,value); } }
    [NativeMember("m_pFrames")]
    public NativePointer<IntPtr> @Frames { get => new NativePointer<IntPtr>(SdkMemory.Read<IntPtr>(Pointer+8)); set { SdkMemory.Write(Pointer+8,value.Pointer); } }
    public void @InitializeAt() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D627 >(627)(Pointer); }
    public void @CompressKeyframes(NativePointer<byte> @arg1) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D628 >(628)(Pointer,@arg1.Pointer); }
    public int @GetDataSize(bool @arg1) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D629 >(629)(Pointer,(@arg1 ? 1 : 0)); return __sdkResult; }
    public bool @MoveMemorY() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D630 >(630)(Pointer); return __sdkResult != 0; }
    public int @RemoveQuaternionFlips() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D631 >(631)(Pointer); return __sdkResult; }
    public void @RemoveUncompressedData(NativePointer<byte> @arg1) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D632 >(632)(Pointer,@arg1.Pointer); }
    public void @SetBoneTag(int @hash) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D633 >(633)(Pointer,@hash); }
    public void @SetName(NativePointer<sbyte> @string) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D634 >(634)(Pointer,@string.Pointer); }
    public void @SetNumFrames(int @count,bool @arg2,bool @arg3,NativePointer<byte> @arg4) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D635 >(635)(Pointer,@count,(@arg2 ? 1 : 0),(@arg3 ? 1 : 0),@arg4.Pointer); }
    public void @Uncompress(NativePointer<byte> @arg1) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D636 >(636)(Pointer,@arg1.Pointer); }
    public void @DestroyNative() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D637 >(637)(Pointer); }
}
