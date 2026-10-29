// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CTaskSimpleThrowProjectile : CTaskSimple
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=36;
    public CTaskSimpleThrowProjectile(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_bIsAborting")]
    public bool @IsAborting { get => SdkMemory.Read<bool >(Pointer+8); set { SdkMemory.Write(Pointer+8,value); } }
    [NativeMember("m_bFinished")]
    public bool @Finished { get => SdkMemory.Read<bool >(Pointer+9); set { SdkMemory.Write(Pointer+9,value); } }
    [NativeMember("m_bStarted")]
    public bool @Started { get => SdkMemory.Read<bool >(Pointer+10); set { SdkMemory.Write(Pointer+10,value); } }
    [NativeMember("m_pAnim")]
    public CAnimBlendAssociation? @Animation { get => SdkMemory.Read<IntPtr>(Pointer+12) == IntPtr.Zero ? null : new CAnimBlendAssociation(SdkMemory.Read<IntPtr>(Pointer+12)); set { SdkMemory.Write(Pointer+12,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_pTarget")]
    public CEntity? @Target { get => SdkMemory.Read<IntPtr>(Pointer+16) == IntPtr.Zero ? null : new CEntity(SdkMemory.Read<IntPtr>(Pointer+16)); set { SdkMemory.Write(Pointer+16,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_vecPosition")]
    public CVector @Position { get => new CVector(Pointer+20); set { SdkMemory.Copy(value.Pointer,Pointer+20,12); } }
    [NativeMember("m_nStartTime")]
    public uint @StartTime { get => SdkMemory.Read<uint >(Pointer+32); set { SdkMemory.Write(Pointer+32,value); } }
    public void @InitializeAt(CEntity? @pTarget,CVector @Posn) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1316 >(1316)(Pointer,@pTarget?.Pointer ?? IntPtr.Zero,@Posn.Pointer); }
}
