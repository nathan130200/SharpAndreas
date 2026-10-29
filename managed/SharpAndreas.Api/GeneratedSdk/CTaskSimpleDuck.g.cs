// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CTaskSimpleDuck : CTaskSimple
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=40;
    public CTaskSimpleDuck(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_nStartTime")]
    public uint @StartTime { get => SdkMemory.Read<uint >(Pointer+8); set { SdkMemory.Write(Pointer+8,value); } }
    [NativeMember("m_nLengthOfDuck")]
    public ushort @LengthOfDuck { get => SdkMemory.Read<ushort >(Pointer+12); set { SdkMemory.Write(Pointer+12,value); } }
    [NativeMember("m_nShotWhizzingCounter")]
    public short @ShotWhizzingCounter { get => SdkMemory.Read<short >(Pointer+14); set { SdkMemory.Write(Pointer+14,value); } }
    [NativeMember("m_pDuckAnim")]
    public CAnimBlendAssociation? @DuckAnimation { get => SdkMemory.Read<IntPtr>(Pointer+16) == IntPtr.Zero ? null : new CAnimBlendAssociation(SdkMemory.Read<IntPtr>(Pointer+16)); set { SdkMemory.Write(Pointer+16,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_pMoveAnim")]
    public CAnimBlendAssociation? @MoveAnimation { get => SdkMemory.Read<IntPtr>(Pointer+20) == IntPtr.Zero ? null : new CAnimBlendAssociation(SdkMemory.Read<IntPtr>(Pointer+20)); set { SdkMemory.Write(Pointer+20,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_bIsFinished")]
    public bool @IsFinished { get => SdkMemory.Read<bool >(Pointer+24); set { SdkMemory.Write(Pointer+24,value); } }
    [NativeMember("m_bIsAborting")]
    public bool @IsAborting { get => SdkMemory.Read<bool >(Pointer+25); set { SdkMemory.Write(Pointer+25,value); } }
    [NativeMember("m_bNeedToSetDuckFlag")]
    public bool @NeedToSetDuckFlag { get => SdkMemory.Read<bool >(Pointer+26); set { SdkMemory.Write(Pointer+26,value); } }
    [NativeMember("m_bIsInControl")]
    public bool @IsInControl { get => SdkMemory.Read<bool >(Pointer+27); set { SdkMemory.Write(Pointer+27,value); } }
    [NativeMember("m_vecMoveCommand")]
    public CVector2D @MoveCommand { get => new CVector2D(Pointer+28); set { SdkMemory.Copy(value.Pointer,Pointer+28,8); } }
    [NativeMember("m_nDuckControlType")]
    public byte @DuckControlType { get => SdkMemory.Read<byte >(Pointer+36); set { SdkMemory.Write(Pointer+36,value); } }
    [NativeMember("m_nCountDownFrames")]
    public byte @CountDownFrames { get => SdkMemory.Read<byte >(Pointer+37); set { SdkMemory.Write(Pointer+37,value); } }
    public void @InitializeAt(eDuckControlTypes @DuckControlType,ushort @nLengthOfDuck,short @nUseShotsWhizzingEvents) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1318 >(1318)(Pointer,(int)@DuckControlType,@nLengthOfDuck,@nUseShotsWhizzingEvents); }
}
