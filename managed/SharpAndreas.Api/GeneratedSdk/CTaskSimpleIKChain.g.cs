// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CTaskSimpleIKChain : CTaskSimple
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=88;
    public CTaskSimpleIKChain(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_time")]
    public int @Time { get => SdkMemory.Read<int >(Pointer+8); set { SdkMemory.Write(Pointer+8,value); } }
    [NativeMember("m_blendTime")]
    public int @BlendTime { get => SdkMemory.Read<int >(Pointer+12); set { SdkMemory.Write(Pointer+12,value); } }
    [NativeMember("m_pIKChain")]
    public NativePointer<IntPtr> @IKChain { get => new NativePointer<IntPtr>(SdkMemory.Read<IntPtr>(Pointer+16)); set { SdkMemory.Write(Pointer+16,value.Pointer); } }
    [NativeMember("m_slotID")]
    public short @SlotID { get => SdkMemory.Read<short >(Pointer+20); set { SdkMemory.Write(Pointer+20,value); } }
    [NativeMember("m_pivotBoneTag")]
    public short @PivotBoneTag { get => SdkMemory.Read<short >(Pointer+22); set { SdkMemory.Write(Pointer+22,value); } }
    [NativeMember("m_effectorBoneTag")]
    public short @EffectorBoneTag { get => SdkMemory.Read<short >(Pointer+24); set { SdkMemory.Write(Pointer+24,value); } }
    [NativeMember("m_effectorVec")]
    public RwV3d @EffectorVec { get => new RwV3d(Pointer+28); set { SdkMemory.Copy(value.Pointer,Pointer+28,12); } }
    [NativeMember("m_pEntity")]
    public CEntity? @Entity { get => SdkMemory.Read<IntPtr>(Pointer+40) == IntPtr.Zero ? null : new CEntity(SdkMemory.Read<IntPtr>(Pointer+40)); set { SdkMemory.Write(Pointer+40,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_offsetBoneTag")]
    public int @OffsetBoneTag { get => SdkMemory.Read<int >(Pointer+44); set { SdkMemory.Write(Pointer+44,value); } }
    [NativeMember("m_offsetPos")]
    public RwV3d @OffsetPosition { get => new RwV3d(Pointer+48); set { SdkMemory.Copy(value.Pointer,Pointer+48,12); } }
    [NativeMember("m_speed")]
    public float @Speed { get => SdkMemory.Read<float >(Pointer+60); set { SdkMemory.Write(Pointer+60,value); } }
    [NativeMember("m_bEntityExist")]
    public bool @EntityExist { get => SdkMemory.Read<bool >(Pointer+64); set { SdkMemory.Write(Pointer+64,value); } }
    [NativeMember("m_blend")]
    public float @Blend { get => SdkMemory.Read<float >(Pointer+68); set { SdkMemory.Write(Pointer+68,value); } }
    [NativeMember("m_endTime")]
    public int @EndTime { get => SdkMemory.Read<int >(Pointer+72); set { SdkMemory.Write(Pointer+72,value); } }
    [NativeMember("m_targetBlend")]
    public float @TargetBlend { get => SdkMemory.Read<float >(Pointer+76); set { SdkMemory.Write(Pointer+76,value); } }
    [NativeMember("m_targetTime")]
    public int @TargetTime { get => SdkMemory.Read<int >(Pointer+80); set { SdkMemory.Write(Pointer+80,value); } }
    [NativeMember("m_isBlendingOut")]
    public int @IsBlendingOut { get => SdkMemory.Read<int >(Pointer+84); set { SdkMemory.Write(Pointer+84,value); } }
    public void @InitializeAt(NativePointer<sbyte> @idString,int @effectorBoneTag,RwV3d @effectorVec,int @pivotBoneTag,CEntity? @pEntity,int @offsetBoneTag,RwV3d @offsetPos,float @speed,int @time,int @blendTime) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4045 >(4045)(Pointer,@idString.Pointer,@effectorBoneTag,@effectorVec.Pointer,@pivotBoneTag,@pEntity?.Pointer ?? IntPtr.Zero,@offsetBoneTag,@offsetPos.Pointer,@speed,@time,@blendTime); }
}
