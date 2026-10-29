// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CAnimBlendHierarchy : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=24;
    public CAnimBlendHierarchy(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_hashKey")]
    public uint @HashKey { get => SdkMemory.Read<uint >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("m_pSequences")]
    public CAnimBlendSequence? @Sequences { get => SdkMemory.Read<IntPtr>(Pointer+4) == IntPtr.Zero ? null : new CAnimBlendSequence(SdkMemory.Read<IntPtr>(Pointer+4)); set { SdkMemory.Write(Pointer+4,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_nSeqCount")]
    public ushort @SeqCount { get => SdkMemory.Read<ushort >(Pointer+8); set { SdkMemory.Write(Pointer+8,value); } }
    [NativeMember("m_bRunningCompressed")]
    public bool @RunningCompressed { get => SdkMemory.Read<bool >(Pointer+10); set { SdkMemory.Write(Pointer+10,value); } }
    [NativeMember("field_B")]
    public sbyte @FieldB { get => SdkMemory.Read<sbyte >(Pointer+11); set { SdkMemory.Write(Pointer+11,value); } }
    [NativeMember("m_nAnimBlockId")]
    public int @AnimationBlockId { get => SdkMemory.Read<int >(Pointer+12); set { SdkMemory.Write(Pointer+12,value); } }
    [NativeMember("m_fTotalTime")]
    public float @TotalTime { get => SdkMemory.Read<float >(Pointer+16); set { SdkMemory.Write(Pointer+16,value); } }
    [NativeMember("field_14")]
    public int @Field14 { get => SdkMemory.Read<int >(Pointer+20); set { SdkMemory.Write(Pointer+20,value); } }
    public NativePointer<IntPtr> @AllocSequenceBlock(bool @arg1) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D638 >(638)(Pointer,(@arg1 ? 1 : 0)); return new NativePointer<IntPtr>(__sdkResult); }
    public void @InitializeAt() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D639 >(639)(Pointer); }
    public void @CalcTotalTime() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D640 >(640)(Pointer); }
    public void @CalcTotalTimeCompressed() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D641 >(641)(Pointer); }
    public void @RemoveAnimSequences() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D642 >(642)(Pointer); }
    public void @RemoveQuaternionFlips() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D643 >(643)(Pointer); }
    public void @RemoveUncompressedData() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D644 >(644)(Pointer); }
    public void @SetName(NativePointer<sbyte> @string) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D645 >(645)(Pointer,@string.Pointer); }
    public void @Shutdown() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D646 >(646)(Pointer); }
    public void @Uncompress() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D647 >(647)(Pointer); }
}
