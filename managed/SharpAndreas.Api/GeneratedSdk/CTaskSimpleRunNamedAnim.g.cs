// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CTaskSimpleRunNamedAnim : CTaskSimpleAnim
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=100;
    public CTaskSimpleRunNamedAnim(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_animName")]
    public NativeArray<sbyte> @AnimationName { get => new NativeArray<sbyte>(Pointer+16,24); }
    [NativeMember("m_animGroupName")]
    public NativeArray<sbyte> @AnimationGroupName { get => new NativeArray<sbyte>(Pointer+40,16); }
    [NativeMember("m_fBlendDelta")]
    public float @BlendDelta { get => SdkMemory.Read<float >(Pointer+56); set { SdkMemory.Write(Pointer+56,value); } }
    [NativeMember("m_pAnimHierarchy")]
    public CAnimBlendHierarchy? @AnimationHierarchy { get => SdkMemory.Read<IntPtr>(Pointer+60) == IntPtr.Zero ? null : new CAnimBlendHierarchy(SdkMemory.Read<IntPtr>(Pointer+60)); set { SdkMemory.Write(Pointer+60,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_nTime")]
    public int @Time { get => SdkMemory.Read<int >(Pointer+64); set { SdkMemory.Write(Pointer+64,value); } }
    [NativeMember("m_timer")]
    public CTaskTimer @Timer { get => new CTaskTimer(Pointer+68); set { SdkMemory.Copy(value.Pointer,Pointer+68,12); } }
    [NativeMember("m_vecOffsetAtEnd")]
    public CVector @OffsetAtEnd { get => new CVector(Pointer+80); set { SdkMemory.Copy(value.Pointer,Pointer+80,12); } }
    [NativeMember("m_nFlags")]
    public uint @Flags { get => SdkMemory.Read<uint >(Pointer+92); set { SdkMemory.Write(Pointer+92,value); } }
    [NativeMember("m_nAnimId")]
    public short @AnimationId { get => SdkMemory.Read<short >(Pointer+96); set { SdkMemory.Write(Pointer+96,value); } }
    public void @InitializeAt(NativePointer<sbyte> @pAnimName,NativePointer<sbyte> @pAnimGroupName,int @flags,float @fBlendDelta,int @nTime,bool @bDontInterrupt,bool @bRunInSequence,bool @bOffsetPed,bool @bHoldLastFrame) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4052 >(4052)(Pointer,@pAnimName.Pointer,@pAnimGroupName.Pointer,@flags,@fBlendDelta,@nTime,(@bDontInterrupt ? 1 : 0),(@bRunInSequence ? 1 : 0),(@bOffsetPed ? 1 : 0),(@bHoldLastFrame ? 1 : 0)); }
}
